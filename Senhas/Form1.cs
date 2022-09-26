using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;


namespace Senhas
{
    public partial class Form1 : Form
    {
        int segundo = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_senha_Click(object sender, EventArgs e)
        {
            if (fila.Count > 0)
            {
                //  SoundPlayer chamada = new SoundPlayer(@"C:\WinFormsApp1\WinFormsApp1\alarm.wav");
                //  chamada.Play();

                
                    
                lbl_senha.Text = fila.Peek();

                con = Convert.ToInt32(fila.Peek());
                
                lbl_senha.Visible = true;
               
                fila.Dequeue();
                segundo = 5;
                timer1.Enabled = true;

            }
            else
            {
                MessageBox.Show("FILA ESTÁ VAZIA");
            }
        }


        Queue<string> fila = new Queue<string>();
        int con = 0;

        private void btn_retirar_Click(object sender, EventArgs e)
        {
            con = con + 1;
            fila.Enqueue(Convert.ToString(con));
            lbl_total1.Text = Convert.ToString(con);

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
            

            if (segundo%2==0)
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

        private void button1_Click(object sender, EventArgs e)
        {
           
            
                try
                {
                using (var con = new MySqlConnection(global.strConn))
                    {
                    con.Open();
                    MessageBox.Show("Conexão concluida!");
                   
                    }
                }
                catch (Exception ex)
                {
                
                MessageBox.Show("Falha: " + ex.Message);

                }
        }
    }


}
