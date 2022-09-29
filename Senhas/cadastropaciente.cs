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
    public partial class cadastropaciente : Form
    {
        public cadastropaciente()
        {
            InitializeComponent();
            button1.Visible = false;
        }

        public string sexo;

        public cadastropaciente(string sus, string nome, string end, string data, string obs ,string sexo) 
        {
            InitializeComponent();
            tbox_sus.Text = sus;
            tbox_nome.Text = nome;
            tbox_end.Text = end;
            tbox_data.Text = data;
            tbox_obs.Text = obs;
            tbox_sus.Enabled = false;
            btn_cadastrar.Visible = false;
            btn_informacoes.Visible = true;
            string SEXO = sexo;
            if (SEXO == "F")
            {
                rfem.Checked = true;
            }
            if (SEXO == "M")
            {
                rmas.Checked = true;
            }


        }

        private void btn_cadastrar_Click(object sender, EventArgs e)
        {
            
            if (rmas.Checked == true)
            {
                sexo = "M";
            }
            if (rfem.Checked == true)
            {
                sexo = "F";
            }
            try
            {
                MySqlConnection conexao = new MySqlConnection(global.strConn);
                conexao.Open();
                string data_nasc = Convert.ToDateTime(tbox_data.Text).ToString("yyyy-MM-dd");

                string cmd = "insert into paciente(cod_sus, nome, end, data_nasc, obs,sexo) values('" + tbox_sus.Text + "', '" + tbox_nome.Text + "', '" + tbox_end.Text + "', '" + data_nasc + "', '" + tbox_obs.Text + "','"+sexo+"')";
                MySqlCommand command = new MySqlCommand(cmd, conexao);
                command.ExecuteNonQuery();
                MessageBox.Show("CADASTRO REALIZADO");
                tbox_sus.Clear();
                tbox_nome.Clear();
                
                tbox_end.Clear();
                tbox_obs.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }   

        private void btn_voltar_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void cadastropaciente_Load(object sender, EventArgs e)
        {
            tbox_data.MaxDate = DateTime.Now;
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            if (rmas.Checked == true)
            {
                sexo = "M";
            }
            if (rfem.Checked == true)
            {
                sexo = "F";
            }

            try
            {
                MySqlConnection conexao = new MySqlConnection(global.strConn);
                conexao.Open();
                string data_nasc = Convert.ToDateTime(tbox_data.Text).ToString("yyyy-MM-dd");

                string cmd = "update paciente set nome = '" + tbox_nome.Text + "', end = '" + tbox_end.Text + "', data_nasc =  '" + data_nasc + "' , obs = '" + tbox_obs.Text + "', sexo = '"+sexo+"' where cod_sus = '" + tbox_sus.Text + "'";
                MySqlCommand command = new MySqlCommand(cmd, conexao);
                command.ExecuteNonQuery();
                MessageBox.Show("DADOS ALTERADOS");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btn_informacoes_Click(object sender, EventArgs e)
        {
            string  cod_sus = tbox_sus.Text;
            Info info = new Info(cod_sus,tbox_nome.Text);
            info.Show();
        }
    }
}
