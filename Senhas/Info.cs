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
    public partial class Info : Form
    {
        
        public Info(string cod_sus, string NOME)
        {
            InitializeComponent();
            groupBox1.Text = NOME;
            sus = cod_sus;
            asma.Text = sus;
        }

        public string sus,a, b, c, d, z, f, g, h, i, j, k, l, m, n, o, p, q, r, s, t, u, v, x,pdf,linha;

        private void Info_Load(object sender, EventArgs e)
        {

            MySqlConnection conexao = new MySqlConnection(global.strConn);
            conexao.Open();
            MySqlCommand cmd = new MySqlCommand("Select * from info where cod_sus = '" + sus + "'", conexao);
            MySqlDataReader dr = cmd.ExecuteReader();

            if (dr.HasRows)
            {
                dr.Read();
                linha = "1";
                a = Convert.ToString(dr[1]);
                b = Convert.ToString(dr[2]);
                c = Convert.ToString(dr[3]);
                d = Convert.ToString(dr[4]);
                z = Convert.ToString(dr[5]);
                f = Convert.ToString(dr[6]);
                g = Convert.ToString(dr[7]);
                h = Convert.ToString(dr[8]);
                i = Convert.ToString(dr[9]);
                j = Convert.ToString(dr[10]);
                k = Convert.ToString(dr[11]);
                l = Convert.ToString(dr[12]);
                m = Convert.ToString(dr[13]);
                n = Convert.ToString(dr[14]);
                o = Convert.ToString(dr[15]);
                p = Convert.ToString(dr[16]);
                q = Convert.ToString(dr[17]);
                r = Convert.ToString(dr[18]);
                s = Convert.ToString(dr[19]);
                t = Convert.ToString(dr[20]);
                u = Convert.ToString(dr[21]);
                v = Convert.ToString(dr[22]);

                conexao.Close();

                if (a == "1")
                {
                    asma.Checked = true;
                }

                if (b == "1")
                {
                    desnu.Checked = true;
                }

                if (c == "1")
                {
                    diabe.Checked = true;
                }

                if (d == "1")
                {
                    dpoc.Checked = true;
                }

                if (z == "1")
                {
                    hiper.Checked = true;
                }

                if (f == "1")
                {
                    obe.Checked = true;
                }

                if (g == "1")
                {
                    pre.Checked = true;
                }

                if (h == "1")
                {
                    puericultura.Checked = true;
                }

                if (i == "1")
                {
                    puerperio.Checked = true;
                }

                if (j == "1")
                {
                    saude.Checked = true;
                }

                if (k == "1")
                {
                    taba.Checked = true;
                }

                if (l == "1")
                {
                    alcool.Checked = true;
                }

                if (m == "1")
                {
                   drogas.Checked = true;
                }

                if (n == "1")
                {
                    mental.Checked = true;
                }

                if (o == "1")
                {
                    reabi.Checked = true;
                }

                if (p == "1")
                {
                    tuber.Checked = true;
                }

                if (q == "1")
                {
                    hanse.Checked = true;
                }

                if (r == "1")
                {
                    dengue.Checked = true;
                }

                if (s == "1")
                {
                    dst.Checked = true;
                }

                if (t == "1")
                {
                    utero.Checked = true;
                }

                if (u == "1")
                {
                    mama.Checked = true;
                }

                if (v == "1")
                {
                    risco.Checked = true;
                }

                
                
            }
        }


        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }
         public void checkbox()
        {
            

            if (asma.Checked == true)
            {
                 a = "1";
            }
            else
            {
                 a = "0";
            }

            if (desnu.Checked == true)
            {
                 b = "1";
            }
            else
            {
                 b = "0";
            }

            if (diabe.Checked == true)
            {
                 c = "1";
            }
            else
            {
                c = "0";
            }

            if (dpoc.Checked == true)
            {
                 d = "1";
            }
            else
            {
                 d = "0";
            }

            if (hiper.Checked == true)
            {
                 z = "1";
            }
            else
            {
               z = "0";
            }

            if (obe.Checked == true)
            {
                 f = "1";
            }
            else
            {
                f = "0";
            }

            if (pre.Checked == true)
            {
                g = "1";
            }
            else
            {
               g = "0";
            }

            if (puericultura.Checked == true)
            {
                h = "1";
            }
            else
            {
                h = "0";
            }

            if (puerperio.Checked == true)
            {
                i = "1";
            }
            else
            {
                i = "0";
            }

            if (saude.Checked == true)
            {
                j = "1";
            }
            else
            {
                j = "0";
            }

            if (taba.Checked == true)
            {
                k = "1";
            }
            else
            {
                k = "0";
            }

            if (alcool.Checked == true)
            {
                l = "1";
            }
            else
            {
                l = "0";
            }

            if (drogas.Checked == true)
            {
                m = "1";
            }
            else
            {
                m = "0";
            }

            if (mental.Checked == true)
            {
                n = "1";
            }
            else
            {
                n = "0";
            }

            if (reabi.Checked == true)
            {
                o = "1";
            }
            else
            {
                o = "0";
            }

            if (tuber.Checked == true)
            {
                p = "1";
            }
            else
            {
                p = "0";
            }

            if (hanse.Checked == true)
            {
                q = "1";
            }
            else
            {
                q = "0";
            }

            if (dengue.Checked == true)
            {
                r = "1";
            }
            else
            {
                r = "0";
            }

            if (dst.Checked == true)
            {
                s = "1";
            }
            else
            {
                s = "0";
            }

            if (utero.Checked == true)
            {
                t = "1";
            }
            else
            {
                t = "0";
            }

            if (mama.Checked == true)
            {
                u = "1";
            }
            else
            {
                u = "0";
            }

            if (risco.Checked == true)
            {
                v = "1";
            }
            else
            {
                v = "0";
            }


        }
        private void btn_salvar_Click(object sender, EventArgs e)
        {

            checkbox();
            try
            {
                
                MySqlConnection conexao = new MySqlConnection(global.strConn);
                conexao.Open();
                string cmd;

                if (linha == "1")
                {
                    cmd = "update  info set  a = '" + a + "', b = '" + b + "',c= '" + c + "', d='" + d + "',e= '" + z + "' ,f= '" + f + "', g= '" + g + "',h = '" + h + "',i= '" + i + "', j = '" + j + "',k = '" + k + "',l = '" + l + "',m= '" + m + "',n= '" + n + "',o= '" + o + "',p='" + p + "',q= '" + q + "',r= '" + r + "',s= '" + s + "',t= '" + t + "',u='" + u + "', v='" + v + "' where cod_sus = '"+sus+"' ";

                }
                else
                {
                    cmd = "insert into info values('" + sus + "','" + a + "', '" + b + "', '" + c + "', '" + d + "', '" + z + "' ,'" + f + "', '" + g + "', '" + h + "', '" + i + "', '" + j + "','" + k + "', '" + l + "', '" + m + "', '" + n + "', '" + o + "','" + p + "', '" + q + "', '" + r + "', '" + s + "', '" + t + "','" + u + "', '" + v + "')";
                }
                    
                MySqlCommand command = new MySqlCommand(cmd, conexao);
                command.ExecuteNonQuery();
                conexao.Close();
                MessageBox.Show("Informações adicionadas");
               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_voltar_Click(object sender, EventArgs e)
        {

        }
    }
}
