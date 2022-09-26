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
using System.Media;

namespace Senhas
{
    
    public partial class main : Form
    {
        int segundo;
        public main()
        {
            InitializeComponent();
            
    }

        private void btn_senha_Click(object sender, EventArgs e)
        {

        }

        private void btn_carregar_Click(object sender, EventArgs e)
        {
            var dt = new DataTable();
            string sql;
            sql = "Select * from sistema.paciente";

            try
            {
                using (var cn = new MySqlConnection(global.strConn))
                {
                    cn.Open();
                    using (var da = new MySqlDataAdapter(sql, cn))
                    {
                        da.Fill(dt);
                        dgv_pacientes.DataSource = dt;

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void btn_load_Click(object sender, EventArgs e)
        {

            var dt = new DataTable();
            string sql;
            sql = "Select * from sistema.senhasatendidas";

            try
            {
                using (var cn = new MySqlConnection(global.strConn))
                {
                    cn.Open();
                    using (var da = new MySqlDataAdapter(sql, cn))
                    {
                        da.Fill(dt);
                        dgv_pacientes.DataSource = dt;

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_teste_Click(object sender, EventArgs e)
        {

            try
            {

                MySqlConnection conexao = new MySqlConnection(global.strConn);
                conexao.Open();
                MySqlCommand cmd = new MySqlCommand("Select data_nasc from sistema.paciente where cod_sus=12345678", conexao);
                MySqlDataReader dr = cmd.ExecuteReader();

                dr.Read();

                string datasql = Convert.ToDateTime(dr[0]).ToString("dd/MM/yyyy");
                lbl_data.Text = datasql;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }



        }

        private void btn_retirar_Click(object sender, EventArgs e)
        {


            if (dgv_pacientes.CurrentRow != null)
            {

                string sus = dgv_pacientes.CurrentRow.Cells[0].Value.ToString();
                string nome = dgv_pacientes.CurrentRow.Cells[1].Value.ToString();
                string date = Convert.ToDateTime(DateTime.Now).ToString("yyyy-MM-dd HH:mm:ss");
                string dia = Convert.ToDateTime(DateTime.Now).ToString("yyyy-MM-dd");
                int datasql = 0;

                MySqlConnection conexao = new MySqlConnection(global.strConn);

                conexao.Open();

                MySqlCommand select = new MySqlCommand("Select senha from sistema.senhas where data_senha like'" + dia + "%' order by senha desc", conexao);
                MySqlDataReader dr = select.ExecuteReader();
               // lbl_total1.Text = Convert.ToString(dr[0]);
               // lbl_data.Text = Convert.ToString(datasql);
                

                DialogResult confirm = MessageBox.Show("Deseja tirar uma senha para : " + nome + "", "Retirar Senha", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2);

                if (confirm.ToString().ToUpper() == "YES")
                {
                    if (dr.HasRows)
                    {
                        dr.Read();
                        datasql = Convert.ToInt16(dr[0]) + 1;
                        lbl_total1.Text = Convert.ToString(dr[0]);
                        lbl_data.Text = Convert.ToString(datasql);

                        conexao.Close();
                        conexao.Open();

                        string insert = "insert into sistema.senhas (data_senha,cod_sus,senha) values ('" + date + "','" + sus + "','" + datasql + "');";
                        MySqlCommand cmdinsert = new MySqlCommand(insert, conexao);
                        cmdinsert.ExecuteNonQuery();
                        MessageBox.Show("Senha retirada");

                        conexao.Close();
                    }
                    else
                    {
                        conexao.Close();
                        conexao.Open();

                        MySqlCommand selectsenhachamada = new MySqlCommand("Select senha from sistema.senhasatendidas where data_senha like'" + dia + "%' order by senha desc", conexao);
                        MySqlDataReader dr2 = selectsenhachamada.ExecuteReader();

                        
                    
                        

                        if(dr2.HasRows)
                        {
                            dr2.Read();
                            datasql = Convert.ToInt16(dr2[0]) + 1;
                            lbl_total1.Text = Convert.ToString(dr2[0]);
                            lbl_data.Text = Convert.ToString(datasql);

                            conexao.Close();
                            conexao.Open();
                            string insert = "insert into sistema.senhas (data_senha,cod_sus,senha) values ('" + date + "','" + sus + "','" + datasql + "');";
                            MySqlCommand cmdinsert = new MySqlCommand(insert, conexao);
                            cmdinsert.ExecuteNonQuery();
                            MessageBox.Show("Senha retirada");
                            conexao.Close();
                        }
                        else
                        {
                            conexao.Close();
                            conexao.Open();
                            string insert = "insert into sistema.senhas (data_senha,cod_sus,senha) values ('" + date + "','" + sus + "','1');";
                            MySqlCommand cmdinsert = new MySqlCommand(insert, conexao);
                            cmdinsert.ExecuteNonQuery();
                            MessageBox.Show("Senha retirada");
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







        private void btn_cadastro_Click(object sender, EventArgs e)
        {
            cadastropaciente cpa = new cadastropaciente();
            cpa.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {

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
                    string cmd = "delete  from sistema.senhas where cod_sus = " + sus + " ; delete  from sistema.paciente where cod_sus = " + sus + "";
                    MySqlCommand command = new MySqlCommand(cmd, conexao);
                    command.ExecuteNonQuery();
                    btn_load.PerformClick();
                    MessageBox.Show("OS DADOS DO PACIENTE FORAM EXCLUIDOS");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            cadastropaciente cpa = new cadastropaciente();
            cpa.Show();
        }

        private void alterar_click(object sender, EventArgs e)
        {
            try
            {
                string sus = dgv_pacientes.CurrentRow.Cells[0].Value.ToString();
                string nome = dgv_pacientes.CurrentRow.Cells[1].Value.ToString();
                string end = dgv_pacientes.CurrentRow.Cells[2].Value.ToString();
                string data = dgv_pacientes.CurrentRow.Cells[3].Value.ToString();
                string obs = dgv_pacientes.CurrentRow.Cells[4].Value.ToString();
                cadastropaciente alterar = new cadastropaciente(sus, nome, end, data, obs);
                alterar.Show();
            }
            catch (Exception)
            {
                MessageBox.Show("SELECIONE UM PACIENTE PARA ALTERAR");
            }


        }

        private void btn_listarsenha_Click(object sender, EventArgs e)
        {
            var dt = new DataTable();
            string sql;
            sql = "Select * from sistema.senhas";

            try
            {
                using (var cn = new MySqlConnection(global.strConn))
                {
                    cn.Open();
                    using (var da = new MySqlDataAdapter(sql, cn))
                    {
                        da.Fill(dt);
                        dgv_pacientes.DataSource = dt;

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btn_listarsenhadia_Click(object sender, EventArgs e)
        {
            string dia = Convert.ToDateTime(DateTime.Now).ToString("yyyy-MM-dd");
            var dt = new DataTable();
            string sql = ("Select * from sistema.senhas where data_senha like'" + dia + "%'");



            try
            {
                using (var cn = new MySqlConnection(global.strConn))
                {
                    cn.Open();
                    using (var da = new MySqlDataAdapter(sql, cn))
                    {
                        da.Fill(dt);
                        dgv_pacientes.DataSource = dt;

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void main_Load(object sender, EventArgs e)
        {
            string dia = Convert.ToDateTime(DateTime.Now).ToString("yyyy-MM-dd");

            

                MySqlConnection conexao = new MySqlConnection(global.strConn);

                conexao.Open();

                MySqlCommand cmd = new MySqlCommand("Select senha from sistema.senhas where data_senha like'" + dia + "%' order by senha desc", conexao);
                MySqlDataReader dr = cmd.ExecuteReader();

                if (dr.HasRows)
                {
                    dr.Read();
                    lbl_total1.Text = Convert.ToString(dr[0]);
                }
            
        }

        private void btn_senha_Click_1(object sender, EventArgs e)
        {
            string dia = Convert.ToDateTime(DateTime.Now).ToString("yyyy-MM-dd");
            string data_senha, cod_sus, senha, chamada;
            
            SoundPlayer alarme = new SoundPlayer("alarm.wav");



            MySqlConnection conexao = new MySqlConnection(global.strConn);
            conexao.Open();
            MySqlCommand cmd = new MySqlCommand("Select * from sistema.senhas where data_senha like'" + dia + "%' order by senha asc", conexao);
            MySqlDataReader dr = cmd.ExecuteReader();

            if (dr.HasRows)
            {
                dr.Read();
                

                
                data_senha = Convert.ToDateTime(dr[0]).ToString("yyyy-MM-dd HH:mm:ss");
                cod_sus = Convert.ToString(dr[1]);
                senha = Convert.ToString(dr[2]);
                chamada = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");

                conexao.Close();

                string cmd_insert_senhas = "insert into sistema.senhasatendidas(data_senha, data_chamada, cod_sus, senha) values('" + data_senha + "','" + chamada + "','" + cod_sus + "','" + senha + "')";
                conexao.Open();     
                MySqlCommand command = new MySqlCommand(cmd_insert_senhas, conexao);
                command.ExecuteNonQuery();
                conexao.Close();

                conexao.Open();
                MySqlCommand deletar = new MySqlCommand("delete from sistema.senhas where senha = '" + senha + "';", conexao);
                deletar.ExecuteNonQuery();
                conexao.Close();

                conexao.Open();
                MySqlCommand telao = new MySqlCommand("insert into sistema.senhatelao(senha,data_senha) values  ('" + senha + "','"+data_senha+"');", conexao);
                telao.ExecuteNonQuery();
                conexao.Close();

                lbl_senha.Visible = true;
                lbl_senha.Text = senha;
                segundo = 8;
                timer1.Enabled = true;
                
                MessageBox.Show("SENHA CHAMADA");
                
                

            }
            else
            {
                MessageBox.Show("NENHUMA SENHA PARA CHAMAR");
            }
            }

        private void tbox_filtro_KeyUp(object sender, KeyEventArgs e)
        {
            var dt = new DataTable();
            string filtro = "";
            try
            {
                filtro = Convert.ToDateTime(tbox_filtro.Text).ToString("yyyy-MM-dd");
            }
            catch(Exception)
            {
                filtro = tbox_filtro.Text;
            }
            
           // string filtro = tbox_filtro.Text;
            //string filtro = Convert.ToDateTime(tbox_filtro.Text).ToString("yyyy-MM-dd");
            string sql;

            if (filtro == "")
            {
                sql = "Select * from sistema.paciente";
            }
            else
            {
                sql = "Select * from sistema.paciente where nome like  '"+filtro+"%' or cod_sus like '"+filtro+"%' or data_nasc like '"+filtro+"%'"; 
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

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_senhasatendidashoje_Click(object sender, EventArgs e)
        {
            string dia = Convert.ToDateTime(DateTime.Now).ToString("yyyy-MM-dd");
            var dt = new DataTable();
            string sql = ("Select * from sistema.senhasatendidas where data_senha like'" + dia + "%'");



            try
            {
                using (var cn = new MySqlConnection(global.strConn))
                {
                    cn.Open();
                    using (var da = new MySqlDataAdapter(sql, cn))
                    {
                        da.Fill(dt);
                        dgv_pacientes.DataSource = dt;

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void medico_Click(object sender, EventArgs e)
        {
            medico fmedico = new Senhas.medico();
            fmedico.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (segundo % 2 == 0)
            {
                lbl_senha.BackColor = Control.DefaultBackColor;

            }
            else
            {
                lbl_senha.BackColor = Color.Red;


            }
            if (segundo < 1)
            {
                timer1.Enabled = false;
            }
            segundo--;
        }
    }
    }

