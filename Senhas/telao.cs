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
using System.Speech.Synthesis;

namespace Senhas
{
    public partial class telao : Form
    {
        

        SoundPlayer alarme = new SoundPlayer("alarm.wav");
        int segundo = 0;
        string senha_antiga = "0";
        string senha_nova = "0";
        string nome;
        string repetir;
        SpeechSynthesizer leitor = new SpeechSynthesizer();
        
        


        public void start()
        {

            timer2.Enabled = true;
            segundo = 8;
        }

        public  telao()
        {
            InitializeComponent();
            
        }

        private void telao_Load(object sender, EventArgs e)
        {
            leitor.SelectVoice("Microsoft Maria Desktop");
            leitor.Rate = -1;
        }

        public void timer1_Tick(object sender, EventArgs e)
        {
            string dia = Convert.ToDateTime(DateTime.Now).ToString("yyyy-MM-dd");
            try
            {
                MySqlConnection conexao = new MySqlConnection(global.strConn);
                conexao.Open();
                MySqlCommand cmd = new MySqlCommand("Select * from senhatelao where data_senha like'" + dia + "%' order by senha desc", conexao);
                MySqlDataReader dr = cmd.ExecuteReader();

                if (dr.HasRows)
                {
                    dr.Read();

                    nome = "\n" + Convert.ToString(dr[2]);
                    senha_nova = Convert.ToString(dr[0]);
                    repetir = Convert.ToString(dr[3]);
                    string data = Convert.ToDateTime(dr[1]).ToString("yyyy-MM-dd HH:mm:ss");

                    conexao.Close();

                    if (senha_antiga != senha_nova)
                    {
                        timer2.Enabled = true;
                        senha_antiga = senha_nova;
                        SoundPlayer alarme = new SoundPlayer("alarm.wav");
                        // alarme.Play();
                        leitor.SpeakAsync(nome);
                        segundo = 8;
                    }
                    else
                    {

                    }
                    if (repetir == "1")
                    {
                        string cmd_repetir = "update senhatelao set repetir = '0' where data_senha = '" + data + "'";
                        conexao.Open();
                        MySqlCommand repetir = new MySqlCommand(cmd_repetir, conexao);
                        repetir.ExecuteNonQuery();
                        conexao.Close();

                        timer2.Enabled = true;
                        senha_antiga = senha_nova;
                        SoundPlayer alarme = new SoundPlayer("alarm.wav");
                        leitor.SpeakAsync(nome);
                        // alarme.Play();
                        segundo = 8;
                    }

                }
            }
            catch (Exception ex)
            {
                this.Close();
                MessageBox.Show(ex.Message);
                
            }


        }


       public void timer2_Tick(object sender, EventArgs e)
        {
            lbl_senha.Text = senha_nova +  nome;
            
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
                lbl_senha.BackColor = Color.Red;
                timer2.Enabled = false;
            }
            segundo--;
        
        }
    }
}
