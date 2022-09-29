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
    public partial class servidor : Form
    {
        public servidor()
        {
            InitializeComponent();
        }

        private void servidor_Load(object sender, EventArgs e)
        {
            tbox_servidor.Text = Properties.Settings.Default.servidor;
            tbox_login.Text = Properties.Settings.Default.usuario;
            tbox_senha.Text = Properties.Settings.Default.senha;
        }

        private void btn_salvar_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.servidor = tbox_servidor.Text;
            Properties.Settings.Default.usuario = tbox_login.Text;
            Properties.Settings.Default.senha = tbox_senha.Text;
            Properties.Settings.Default.Save();
            MessageBox.Show("Configuração de conexão salva.");
        }

        private void btn_testar_Click(object sender, EventArgs e)
        {
            string testecon = "server='" + tbox_servidor.Text + "';User Id='" + tbox_login.Text + "';password='" + tbox_senha.Text + "';Convert Zero Datetime=True ";
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
    }
}
