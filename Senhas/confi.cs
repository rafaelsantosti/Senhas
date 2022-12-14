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
using Microsoft.VisualBasic;

namespace Senhas
{
    public partial class confi : Form
    {
       
        public string deletar;
        public confi()
        {
           

            InitializeComponent();
        }

        private void confi_Load(object sender, EventArgs e)
        {
            list.GridLines = true;
            tbox_servidor.Text = Properties.Settings.Default.servidor;
            tbox_banco.Text = Properties.Settings.Default.bancoDados;
            tbox_login.Text = Properties.Settings.Default.usuario;
            tbox_senha.Text = Properties.Settings.Default.senha;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.servidor = tbox_servidor.Text;
            Properties.Settings.Default.bancoDados = tbox_banco.Text;
            Properties.Settings.Default.usuario = tbox_login.Text;
            Properties.Settings.Default.senha = tbox_senha.Text;
            Properties.Settings.Default.Save();
            MessageBox.Show("Configuração de conexão salva.");

        }

        private void btn_testar_Click(object sender, EventArgs e)
        {
            
            string testecon = "server='"+tbox_servidor.Text+"';User Id='"+tbox_login.Text+"';database='"+tbox_banco.Text+"';password='"+tbox_senha.Text+"';Convert Zero Datetime=True ";
            try
            {
                using (var con = new MySqlConnection(testecon))
                {
                    con.Open();
                    MessageBox.Show("Conexão concluida!");
                    con.Close();

                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Falha: " + ex.Message);

            }
        }

        private void btn_sair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_deletar_Click(object sender, EventArgs e)
        {
            try
            {

                deletar = list.SelectedItems[0].SubItems[0].Text;


                DialogResult confirm = MessageBox.Show("DESEJA EXCLUIR O BANCO DE DADOS " + deletar + "?", "EXCLUIR", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);

                if (confirm.ToString().ToUpper() == "YES")
                {
                    DialogResult confirmar = MessageBox.Show("TODOS OS DADOS SERÂO PERDIDOS, ESSA OPERAÇÂO NÂO PODE SER DESFEITA!", "EXCLUIR", MessageBoxButtons.YesNo, MessageBoxIcon.Stop, MessageBoxDefaultButton.Button2);

                    if (confirmar.ToString().ToUpper() == "YES")
                    {

                        string testecon = "drop database " + deletar + ";";
                        try
                        {
                            MySqlConnection conexao = new MySqlConnection(global.strConn);
                            conexao.Open();
                            MySqlCommand delete = new MySqlCommand("drop database " + deletar + ";", conexao);
                            delete.ExecuteNonQuery();
                            conexao.Close();
                            MessageBox.Show("BANCO DE DADOS " + deletar + " FOI EXCLUIDO");
                            btn_show.PerformClick();
                        }
                        catch (Exception ex)
                        {

                            MessageBox.Show("Falha: " + ex.Message);

                        }
                    }

                }
            }
            catch (Exception)
            {
                MessageBox.Show("Escolha um banco para excluir", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

                    
                
            
        

        private void btn_criar_Click(object sender, EventArgs e)
        {

            string banco = Interaction.InputBox("Qual nome do banco a ser criado?","CRIAR DATABASE");

            if (banco != "")
            {
                try
                {

                    string criar = "create database "+banco+"; use "+banco+"; create table paciente(cod_sus char(15) primary key, nome char(250), tel char(11), end char(250), data_nasc date, obs varchar(300), sexo char(3)); create table senhas(data_senha datetime, cod_sus char(15), senha int); create table senhasatendidas(cod int primary key auto_increment, data_senha datetime, data_chamada datetime, cod_sus char(15), senha int); create table senhatelao(senha int, data_senha datetime, nome char(200), repetir int); create table info(cod_sus char(15), a int, b int, c int, d int, e int, f int, g int, h int, i int, j int, k int, l int, m int, n int, o int, p int, q int, r int, s int, t int, u int, v int, peso char(6), altura char(4))";
                    MySqlConnection conexao = new MySqlConnection(global.server);
                    conexao.Open();
                    MySqlCommand command = new MySqlCommand(criar, conexao);
                    command.ExecuteNonQuery();
                    conexao.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

            
        }

        private void btn_show_Click(object sender, EventArgs e)
        {

            try
            {
                MySqlConnection conexao = new MySqlConnection(global.server);
                conexao.Open();
                MySqlCommand show = new MySqlCommand("show databases;", conexao);
                
                MySqlDataReader select = show.ExecuteReader();
                DataTable dt = new DataTable();


                //dt.Load(select);

                list.Items.Clear();
                while (select.Read())
                {
                    list.Items.Add(Convert.ToString(select[0]));
                }

              //  list.Items.Add(Convert.ToString(dt));
           
                conexao.Close();
                
            }
            catch (Exception ex)
            {

                MessageBox.Show("Falha: " + ex.Message);

            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lbl_servidor_Click(object sender, EventArgs e)
        {

        }

        private void tbox_senha_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbox_login_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbox_banco_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbox_servidor_TextChanged(object sender, EventArgs e)
        {

        }
    }
    
}

