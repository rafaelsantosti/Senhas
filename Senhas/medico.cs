using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Senhas
{
    public partial class medico : Form
    {

        public medico()
        {
            InitializeComponent();
        }

        public void atualizar()
        {
            string dia = Convert.ToDateTime(DateTime.Now).ToString("yyyy-MM-dd");
            var dt = new DataTable();
            
            string sql = ("select senha as 'Senha',data_nasc as 'Data de Nascimento', nome as 'Nome',TIMESTAMPDIFF(YEAR, data_nasc, CURDATE()) as Idade ,sexo as 'Sexo' ,obs as 'Observações',x.cod_sus,end, tel From paciente x inner join senhas y on x.cod_sus = y.cod_sus where data_senha like '" + dia + "%' order by senha asc;");

            try
            {
                using (var cn = new MySqlConnection(global.strConn))
                {
                    cn.Open();
                    using (var da = new MySqlDataAdapter(sql, cn))
                    {
                        da.Fill(dt);
                        dgv_pacientes.DataSource = dt;


                        DataGridViewColumn coluna1 = dgv_pacientes.Columns[0];
                        coluna1.Width = 100;

                        DataGridViewColumn coluna2 = dgv_pacientes.Columns[2];
                        coluna2.Width = 500;

                        DataGridViewColumn coluna3 = dgv_pacientes.Columns[3];
                        coluna3.Width = 100;

                        DataGridViewColumn coluna4 = dgv_pacientes.Columns[4];
                        coluna4.Width = 100;

                        DataGridViewColumn coluna5 = dgv_pacientes.Columns[5];
                        coluna5.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;


                        try
                        {


                            if (Convert.ToString(dgv_pacientes.Rows[0].Cells[0].Value) == "0")
                            {
                                var linha = dgv_pacientes.Rows[0];
                                dgv_pacientes.Rows.Remove(linha);
                            }
                        }
                        catch(Exception)
                        {

                        }
                        dgv_pacientes.Columns[1].Visible = false;
                        dgv_pacientes.Columns[6].Visible = false;
                        dgv_pacientes.Columns[7].Visible = false;
                        dgv_pacientes.Columns[8].Visible = false;

                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                this.Close();
            }
        }
    
    


        private void medico_Load(object sender, EventArgs e)
        {

            atualizar();
           
        }

        private void dgv_pacientes_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                string sus = dgv_pacientes.CurrentRow.Cells[6].Value.ToString();
                string nome = dgv_pacientes.CurrentRow.Cells[2].Value.ToString();
                string end = dgv_pacientes.CurrentRow.Cells[6].Value.ToString();
                string data = dgv_pacientes.CurrentRow.Cells[1].Value.ToString();
                string obs = dgv_pacientes.CurrentRow.Cells[5].Value.ToString();
                string sexo = dgv_pacientes.CurrentRow.Cells[4].Value.ToString();
                string tel = dgv_pacientes.CurrentRow.Cells[8].Value.ToString();
                string tab = "1";
                cadastropaciente alterar = new cadastropaciente(sus, nome, end, data, obs,sexo,tel,tab);
                alterar.Closed += (s, args) => this.atualizar();
                alterar.Show();
            }
            catch (Exception)
            {
                MessageBox.Show("SELECIONE UM PACIENTE PARA ALTERAR");
            }
        }

        private void btn_chamar_Click(object sender, EventArgs e)
        {
            DialogResult confirm = MessageBox.Show("Deseja chamar a proxima senha?", "Chamar Senha", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);


            if (confirm.ToString().ToUpper() == "YES")
            {

                string dia = Convert.ToDateTime(DateTime.Now).ToString("yyyy-MM-dd");
                string data_senha, cod_sus, senha, nome, chamada;




                try
                {
                    MySqlConnection conexao = new MySqlConnection(global.strConn);
                    MySqlConnection conexao2 = new MySqlConnection(global.strConn);
                    conexao.Open();
                    conexao2.Open();
                    // MySqlCommand sel = new MySqlCommand("select data_senha,x.cod_sus,senha,nome from senhas x inner join paciente y on x.cod_sus = y.cod_sus where data_senha like'" + dia + "%' order by senha asc", conexao);
                    MySqlCommand sel = new MySqlCommand("with senha as (select data_senha, x.cod_sus, senha, nome, ROW_NUMBER() OVER(ORDER BY senha) as RowNum from senhas x inner join paciente y on x.cod_sus = y.cod_sus  where data_senha like '" + dia + "%')select * from senha where RowNum = 2; ", conexao);
                    MySqlCommand del = new MySqlCommand("select data_senha,x.cod_sus,senha,nome from senhas x inner join paciente y on x.cod_sus = y.cod_sus where data_senha like'" + dia + "%' order by senha asc", conexao2);

                    MySqlDataReader drdel = del.ExecuteReader();
                    MySqlDataReader drsel = sel.ExecuteReader();







                    if (drsel.HasRows)
                    {

                        drdel.Read();
                        drsel.Read();

                        data_senha = Convert.ToDateTime(drsel[0]).ToString("yyyy-MM-dd HH:mm:ss");
                        cod_sus = Convert.ToString(drsel[1]);
                        senha = Convert.ToString(drsel[2]);
                        int senhaapagar = Convert.ToInt16(drdel[2]);
                        nome = Convert.ToString(drsel[3]);
                        chamada = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");

                        conexao.Close();
                        conexao2.Close();



                        string cmd_insert_senhas = "insert into senhasatendidas(data_senha, data_chamada, cod_sus, senha) values('" + data_senha + "','" + chamada + "','" + cod_sus + "','" + senha + "')";
                        conexao.Open();
                        conexao2.Open();
                        MySqlCommand command = new MySqlCommand(cmd_insert_senhas, conexao);
                        command.ExecuteNonQuery();
                        conexao.Close();
                        conexao2.Close();

                        conexao.Open();
                        conexao2.Open();
                        MySqlCommand deletar = new MySqlCommand("delete from senhas where senha = '" + senhaapagar + "';", conexao);
                        deletar.ExecuteNonQuery();
                        conexao.Close();
                        conexao2.Close();

                        conexao.Open();
                        conexao2.Open();
                        MySqlCommand telao = new MySqlCommand("insert into senhatelao(senha,data_senha,nome) values  ('" + senha + "','" + data_senha + "','" + nome + "');", conexao);
                        telao.ExecuteNonQuery();
                        conexao.Close();
                        conexao2.Close();

                        try
                        {
                            atualizar();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }

                        MessageBox.Show("SENHA CHAMADA");
                        


                    }
                    else
                    {
                        MessageBox.Show("NENHUMA SENHA PARA CHAMAR");
                    }


                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {

        }

        private void repetir_Click(object sender, EventArgs e)
        {
            DialogResult confirm = MessageBox.Show("Deseja repetir a ultima senha?", "REPETIR SENHA", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

            if (confirm.ToString().ToUpper() == "YES")
            {
                string dia = Convert.ToDateTime(DateTime.Now).ToString("yyyy-MM-dd");
                string data;

                string cod;





                MySqlConnection conexao = new MySqlConnection(global.strConn);
                conexao.Open();
                MySqlCommand cmd = new MySqlCommand("Select * from senhatelao where data_senha like '" + dia + "%' order by senha desc", conexao);
                MySqlDataReader dr = cmd.ExecuteReader();

                if (dr.HasRows)
                {
                    dr.Read();

                    cod = Convert.ToString(dr[3]);
                    data = Convert.ToDateTime(dr[1]).ToString("yyyy-MM-dd HH:mm:ss");

                    conexao.Close();

                    string cmd_repetir = "update senhatelao set repetir = '1' where data_senha = '" + data + "'";
                    conexao.Open();
                    MySqlCommand repetir = new MySqlCommand(cmd_repetir, conexao);
                    repetir.ExecuteNonQuery();
                    conexao.Close();
                }
            }
        }

        

        private void timer1_Tick(object sender, EventArgs e)
        {
            atualizar();
        }
    }
}
