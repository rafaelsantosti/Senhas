using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Printing;
using MySql.Data.MySqlClient;
using System.Diagnostics;
using Microsoft.VisualBasic;

namespace Senhas
{
    public partial class home : Form
    {
        public home()
        {
            InitializeComponent();
        }

        private void btn_recepcao_Click(object sender, EventArgs e)
        {
            this.Hide();
            recepcao frece = new recepcao();
            frece.Closed += (s, args) => this.Show();
            frece.Show();

        }

        private void btn_medico_Click(object sender, EventArgs e)
        {

            //this.Hide();
            medico fmedico = new medico();
            fmedico.Closed += (s, args) => this.Show();
            fmedico.Show();

        }

        private void btn_telao_Click(object sender, EventArgs e)
        {
            //this.Hide();
            telao ftelao = new telao();
            ftelao.Closed += (s, args) => this.Show();
            ftelao.Show();
        }

        private void home_Load(object sender, EventArgs e)
        {


            try
            {
                MySqlConnection conexao = new MySqlConnection(global.strConn);
                conexao.Open();
                MySqlCommand cmd = new MySqlCommand("show databases", conexao);
                MySqlDataReader dr = cmd.ExecuteReader();
                string banco="";

                while (dr.Read())
                {
                    banco = Convert.ToString(dr[0]);

                    if (banco == "bancoparasistemasus")
                    {
                        break;
                    }
                }

                if (banco != "bancoparasistemasus")
                {
                    criar_banco();

                    Properties.Settings.Default.bancoDados = "bancoparasistemasus";

                    Properties.Settings.Default.Save();
                }
            }

            catch (Exception)
            {
                DialogResult confirm = MessageBox.Show("Falha ao conectar com o MYSQL, possui o MYSQL WORKBENCH instalado?", "Configuração", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);

                if (confirm.ToString().ToUpper() == "YES")
                {
                    MessageBox.Show("Digite corretamente os dados de conexao com o MYSQL");
                    servidor serv = new servidor();
                    serv.Show();
                    serv.Closed += (s, args) => Application.Restart();
                    this.Enabled = false;
                }
                if (confirm.ToString().ToUpper() == "NO")
                {
                    DialogResult confirmar = MessageBox.Show("Clique em Sim para iniciar o download faça a instalação e inicie novamente!", "Configuração", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
                    if (confirmar.ToString().ToUpper() == "YES")
                    {

                        Process.Start("https://dev.mysql.com/get/Downloads/MySQLInstaller/mysql-installer-community-8.0.30.0.msi");
                        this.Close();
                    }
                    else
                    {
                        this.Close();
                    }

                }
                if (confirm.ToString().ToUpper() == "CANCEL")
                {
                    this.Close();
                }
            }
            
            }

        private void btn_confi_Click(object sender, EventArgs e)
        {
            string senha = Interaction.InputBox("Insira a senha do administrador. admin", "Senha Configuração");
            if (senha == "admin")
            { 
            confi con = new confi();
            con.Show();
            con.Closed += (s, args) => Application.Restart();
            this.Enabled = false;
           }
        }


        static void criar_banco()
        {
            try
            {
                
                string criar = "create database bancoparasistemasus;use bancoparasistemasus;create table paciente(cod_sus int primary key ,nome char(250),end char (250),data_nasc date,obs varchar(300),sexo char (3));create table senhas(data_senha datetime,cod_sus int,senha int);create table senhasatendidas(cod int primary key auto_increment, data_senha datetime, data_chamada datetime, cod_sus int,senha int ); create table senhatelao( senha int,data_senha datetime,nome char(200),repetir int);create table info(cod_sus int,a int, b int , c int , d int , e int , f int , g int , h int , i int , j int , k int , l int , m int , n int, o int , p int , q int , r int , s int , t int , u int , v int);";
                MySqlConnection conexao = new MySqlConnection(global.server);
                conexao.Open();
                MySqlCommand command = new MySqlCommand(criar, conexao);
                command.ExecuteNonQuery();
                conexao.Close();
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
    }

    
}
