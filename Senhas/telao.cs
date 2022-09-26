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
    public partial class telao : Form
    {
        int segundo = 0;
        string senha_antiga = "0";
        string senha_nova = "0";

        public telao()
        {
            InitializeComponent();
        }

        private void telao_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            string dia = Convert.ToDateTime(DateTime.Now).ToString("yyyy-MM-dd");

            MySqlConnection conexao = new MySqlConnection(global.strConn);
            conexao.Open();
            MySqlCommand cmd = new MySqlCommand("Select * from sistema.senhatelao where data_senha like'"+dia+"%' order by senha desc", conexao);
            MySqlDataReader dr = cmd.ExecuteReader();

            if (dr.HasRows)
            {
                dr.Read();


                senha_nova = Convert.ToString(dr[0]);
                conexao.Close();

                if (senha_antiga != senha_nova)
                {
                    timer2.Enabled = true;
                    senha_antiga = senha_nova;
                    SoundPlayer alarme = new SoundPlayer("alarm.wav");
                    alarme.Play();
                    segundo = 8;
                }
                else
                {

                }

            }


        }


        private void timer2_Tick(object sender, EventArgs e)
        {
            lbl_senha.Text = senha_nova;
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
