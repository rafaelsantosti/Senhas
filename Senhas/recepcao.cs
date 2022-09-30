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
    public partial class recepcao : Form
    {

        public int datasql = 0;
        public string nome;
        public recepcao()
        {
            InitializeComponent();

        }

        public void retirarsenha()
        {
            if (dgv_pacientes.CurrentRow != null)
            {

                string sus = dgv_pacientes.CurrentRow.Cells[0].Value.ToString();
                nome = dgv_pacientes.CurrentRow.Cells[1].Value.ToString();
                string date = Convert.ToDateTime(DateTime.Now).ToString("yyyy-MM-dd HH:mm:ss");
                string dia = Convert.ToDateTime(DateTime.Now).ToString("yyyy-MM-dd");
                datasql = 0;

                MySqlConnection conexao = new MySqlConnection(global.strConn);

                conexao.Open();

                MySqlCommand select = new MySqlCommand("Select senha from senhas where data_senha like'" + dia + "%' order by senha desc", conexao);
                MySqlDataReader dr = select.ExecuteReader();
                


                DialogResult confirm = MessageBox.Show("Deseja tirar uma senha para : " + nome + "", "Retirar Senha", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2);

                if (confirm.ToString().ToUpper() == "YES")
                {
                    if (dr.HasRows)
                    {
                        dr.Read();
                        datasql = Convert.ToInt16(dr[0]) + 1;


                        conexao.Close();
                        conexao.Open();

                        string insert = "insert into senhas (data_senha,cod_sus,senha) values ('" + date + "','" + sus + "','" + datasql + "');";
                        MySqlCommand cmdinsert = new MySqlCommand(insert, conexao);
                        cmdinsert.ExecuteNonQuery();
                        pd.Print();


                        conexao.Close();
                    }
                    else
                    {
                        conexao.Close();
                        conexao.Open();

                        MySqlCommand selectsenhachamada = new MySqlCommand("Select senha from senhasatendidas where data_senha like'" + dia + "%' order by senha desc", conexao);
                        MySqlDataReader dr2 = selectsenhachamada.ExecuteReader();





                        if (dr2.HasRows)
                        {
                            dr2.Read();
                            datasql = Convert.ToInt16(dr2[0]) + 1;


                            conexao.Close();
                            conexao.Open();
                            string insert = "insert into senhas (data_senha,cod_sus,senha) values ('" + date + "','" + sus + "','" + datasql + "');";
                            MySqlCommand cmdinsert = new MySqlCommand(insert, conexao);
                            cmdinsert.ExecuteNonQuery();
                            pd.Print();

                            conexao.Close();
                        }
                        else
                        {
                            conexao.Close();
                            conexao.Open();
                            string insert = "insert into senhas (data_senha,cod_sus,senha) values ('" + date + "','" + sus + "','0');";
                            string insert2 = "insert into senhas (data_senha,cod_sus,senha) values ('" + date + "','" + sus + "','1');";
                            MySqlCommand cmdinsert = new MySqlCommand(insert, conexao);
                            MySqlCommand cmdinsert2 = new MySqlCommand(insert2, conexao);
                            cmdinsert.ExecuteNonQuery();
                            cmdinsert2.ExecuteNonQuery();
                            pd.Print();

                            conexao.Close();

                        }

                    }
                }
            }
            else
            {
                MessageBox.Show("ESCOLHA UM PACIENTE!");
            }
        }
    
    

        public void atualizar()
        {
            var dt = new DataTable();
            string sql;
            sql = "select cod_sus as 'CNS', nome as 'Nome', data_nasc as 'Data de Nascimento', end as 'Endereço',obs ,sexo,tel from paciente";

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
                        coluna1.Width = 220;

                        DataGridViewColumn coluna2 = dgv_pacientes.Columns[1];
                        coluna2.Width = 500;

                        DataGridViewColumn coluna3 = dgv_pacientes.Columns[2];
                        coluna3.Width = 170;

                        DataGridViewColumn coluna4 = dgv_pacientes.Columns[3];
                        coluna4.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;


                        dgv_pacientes.Columns[4].Visible = false;
                        dgv_pacientes.Columns[5].Visible = false;
                        dgv_pacientes.Columns[6].Visible = false;


                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                this.Close();
            }
        }

    private void recepcao_Load(object sender, EventArgs e)
        {

            atualizar();
           
        }

        private void tbox_filtro_KeyUp(object sender, KeyEventArgs e)
        {
            var dt = new DataTable();
            string filtro = "";
            try
            {
                filtro = Convert.ToDateTime(tbox_filtro.Text).ToString("yyyy-MM-dd");
            }
            catch (Exception)
            {
                filtro = tbox_filtro.Text;
            }


            string sql;

            if (filtro == "")
            {
                sql = "select cod_sus as 'SUS', nome as 'Nome', data_nasc as 'Data de Nascimento', end as 'Endereço' , obs,sexo  from paciente";
            }
            else
            {
                sql = "select cod_sus as 'SUS', nome as 'Nome', data_nasc as 'Data de Nascimento', end as 'Endereço',obs,sexo from paciente where nome like  '" + filtro + "%' or cod_sus like '" + filtro + "%' or data_nasc like '" + filtro + "%'";
            }

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
                        coluna1.Width = 220;

                        DataGridViewColumn coluna2 = dgv_pacientes.Columns[1];
                        coluna2.Width = 500;

                        DataGridViewColumn coluna3 = dgv_pacientes.Columns[2];
                        coluna3.Width = 170;

                        DataGridViewColumn coluna4 = dgv_pacientes.Columns[3];
                        coluna4.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        private void btn_cadastro_Click(object sender, EventArgs e)
        {
            cadastropaciente cpa = new cadastropaciente();
            cpa.Closed += (s, args) => this.atualizar();
            cpa.Show();
        }

        private void alterar_cadastro_Click(object sender, EventArgs e)
        {
            try
            {
                string tab = "0";
                string sus = dgv_pacientes.CurrentRow.Cells[0].Value.ToString();
                string nome = dgv_pacientes.CurrentRow.Cells[1].Value.ToString();
                string data = dgv_pacientes.CurrentRow.Cells[2].Value.ToString();
                string end = dgv_pacientes.CurrentRow.Cells[3].Value.ToString();
                string obs = dgv_pacientes.CurrentRow.Cells[4].Value.ToString();
                string sexo = dgv_pacientes.CurrentRow.Cells[5].Value.ToString();
                string tel = dgv_pacientes.CurrentRow.Cells[6].Value.ToString();
                cadastropaciente alterar = new cadastropaciente(sus, nome, end, data, obs, sexo,tel,tab);
                alterar.Closed += (s, args) => this.atualizar();
                alterar.Show();
            }
            catch (Exception ex)
            {
               // MessageBox.Show("SELECIONE UM PACIENTE PARA ALTERAR");
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_excluir_Click(object sender, EventArgs e)
        {
            try
            {

                string sus = dgv_pacientes.CurrentRow.Cells[0].Value.ToString();
                string nome = dgv_pacientes.CurrentRow.Cells[1].Value.ToString();
                DialogResult confirm = MessageBox.Show("Deseja deletar dados do Paciente : " + nome + "", "DELETAR PACIENTE", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2);
                if (confirm.ToString().ToUpper() == "YES")
                {

                    MySqlConnection conexao = new MySqlConnection(global.strConn);
                    conexao.Open();
                    string cmd = "delete  from senhas where cod_sus = " + sus + " ; delete  from paciente where cod_sus = " + sus + "";
                    MySqlCommand command = new MySqlCommand(cmd, conexao);
                    command.ExecuteNonQuery();
                    atualizar();
                    
                    MessageBox.Show("OS DADOS DO PACIENTE FORAM EXCLUIDOS");

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void btn_pacientes_Click(object sender, EventArgs e)
        {
            var dt = new DataTable();
            string sql;
            sql = "select cod_sus as 'SUS', nome as 'Nome', data_nasc as 'Data de Nascimento', end as 'Endereço',obs from paciente";

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
                        coluna1.Width = 200;

                        DataGridViewColumn coluna2 = dgv_pacientes.Columns[1];
                        coluna2.Width = 400;

                        DataGridViewColumn coluna3 = dgv_pacientes.Columns[2];
                        coluna3.Width = 170;

                        DataGridViewColumn coluna4 = dgv_pacientes.Columns[3];
                        coluna4.Width = 700;

                        dgv_pacientes.Columns[4].Visible = false;

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_retirar_Click(object sender, EventArgs e)
        {
            retirarsenha();
            
        }

        public void btn_senha_Click(object sender, EventArgs e)
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
                    conexao2.Open(); MySqlCommand sel = new MySqlCommand("with senha as (select data_senha, x.cod_sus, senha, nome, ROW_NUMBER() OVER(ORDER BY senha) as RowNum from senhas x inner join paciente y on x.cod_sus = y.cod_sus  where data_senha like '" + dia + "%')select * from senha where RowNum = 2; ", conexao);
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
        private void btn_gerenciar_Click(object sender, EventArgs e)
        {
            gerenciador gsenha = new gerenciador();
            gsenha.Show();
        }

        private void pd_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            if (datasql == 0)
            {
                datasql = 1;
            }
            string texto = "SENHA:\n     " + datasql + "\n ";
            string datanome = "" + DateTime.Now + "\n" + nome + "";
            Font tipo_fonte = new Font("Arial", 50, FontStyle.Bold, GraphicsUnit.Pixel);
            Font fonte_nome = new Font("Arial", 12, FontStyle.Bold, GraphicsUnit.Pixel);
            SolidBrush cor = new SolidBrush(Color.Black);
            Point local = new Point(5, 30);
            Point localnome = new Point(10, 160);

            e.Graphics.DrawString(texto, tipo_fonte, cor, local);
            e.Graphics.DrawString(datanome, fonte_nome, cor, localnome);
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
                MySqlCommand cmd = new MySqlCommand("Select * from senhatelao where data_senha like '"+dia+"%' order by senha desc", conexao);
                MySqlDataReader dr = cmd.ExecuteReader();

                if (dr.HasRows)
                {
                    dr.Read();

                    cod = Convert.ToString(dr[3]);
                    data = Convert.ToDateTime(dr[1]).ToString("yyyy-MM-dd HH:mm:ss");

                    conexao.Close();

                    string cmd_repetir = "update senhatelao set repetir = '1' where data_senha = '"+data+"'";
                    conexao.Open();
                    MySqlCommand repetir = new MySqlCommand(cmd_repetir, conexao);
                    repetir.ExecuteNonQuery();
                    conexao.Close();
                }
            }
        }

        private void tbox_filtro_Click(object sender, EventArgs e)
        {
            if (tbox_filtro.Text == "Digite sua pesquisa aqui")

            {
                tbox_filtro.Text = "";
            }
        }

        private void dgv_pacientes_DoubleClick(object sender, EventArgs e)
        {
            retirarsenha();
        }
    }
}
