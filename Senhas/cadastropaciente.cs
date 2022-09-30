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
            tabControl1.TabPages.Remove(tabPage3);
        }

        public string sexo,peso, altura;
        public string sus, a, b, c, d, z, f, g, h, i, j, k, l, m, n, o, p, q, r, s, t, u, v, x, pdf, linha;
        

        private void btn_salvar_Click_1(object sender, EventArgs e)
        {
            checkbox();
            try
            {
                tbox_sus.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
                sus = tbox_sus.Text;
                tbox_sus.TextMaskFormat = MaskFormat.IncludePromptAndLiterals;

                tbox_peso.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
                peso = tbox_peso.Text;
                tbox_peso.TextMaskFormat = MaskFormat.IncludePromptAndLiterals;

                tbox_altura.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
                altura = tbox_altura.Text;
                tbox_altura.TextMaskFormat = MaskFormat.IncludePromptAndLiterals;

                MySqlConnection conexao = new MySqlConnection(global.strConn);
                conexao.Open();
                string cmd;
                label11.Text = peso;

                if (linha == "1")
                {
                    cmd = "update  info set  a = '" + a + "', b = '" + b + "',c= '" + c + "', d='" + d + "',e= '" + z + "' ,f= '" + f + "', g= '" + g + "',h = '" + h + "',i= '" + i + "', j = '" + j + "',k = '" + k + "',l = '" + l + "',m= '" + m + "',n= '" + n + "',o= '" + o + "',p='" + p + "',q= '" + q + "',r= '" + r + "',s= '" + s + "',t= '" + t + "',u='" + u + "', v='" + v + "', peso = '" + peso + "' , altura ='" + altura+"' where cod_sus = '" + sus + "' ";

                }
                else
                {
                    cmd = "insert into info values('" + sus + "','" + a + "', '" + b + "', '" + c + "', '" + d + "', '" + z + "' ,'" + f + "', '" + g + "', '" + h + "', '" + i + "', '" + j + "','" + k + "', '" + l + "', '" + m + "', '" + n + "', '" + o + "','" + p + "', '" + q + "', '" + r + "', '" + s + "', '" + t + "','" + u + "', '" + v + "','"+peso+"','"+altura+"')";
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

        public cadastropaciente(string sus, string nome, string end, string data, string obs, string sexo, string tel, string tab)
        {
            InitializeComponent();
            if (tab == "0")
            {
                tabControl1.TabPages.Remove(tabPage3);
            }
            tbox_tel.Text = tel;
            tbox_sus.Text = sus;
            tbox_nome.Text = nome;
            tbox_end.Text = end;
            tbox_data.Text = data;
            tbox_obs.Text = obs;
            tbox_sus.Enabled = false;
            btn_cadastrar.Visible = false;
            
            
          
            string SEXO = sexo;
            if (SEXO == "F")
            {
                rfem.Checked = true;
            }
            if (SEXO == "M")
            {
                rmas.Checked = true;
            }

            try
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
                    tbox_peso.Text = Convert.ToString(dr[23]);
                    tbox_altura.Text = Convert.ToString(dr[24]);
                    

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
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_cadastrar_Click(object sender, EventArgs e)
        {
            tbox_tel.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            string tel = tbox_tel.Text;
            tbox_tel.TextMaskFormat = MaskFormat.IncludePromptAndLiterals;

            tbox_sus.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            string sus = tbox_sus.Text;
            tbox_sus.TextMaskFormat = MaskFormat.IncludePromptAndLiterals;

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

                string cmd = "insert into paciente(cod_sus, nome, tel, end, data_nasc, obs,sexo) values('" + sus + "','"+tbox_nome.Text+"', '" + tel + "', '" + tbox_end.Text + "', '" + data_nasc + "', '" + tbox_obs.Text + "','"+sexo+"')";
                MySqlCommand command = new MySqlCommand(cmd, conexao);
                command.ExecuteNonQuery();
                MessageBox.Show("CADASTRO REALIZADO");
                tbox_sus.Clear();
                tbox_nome.Clear();
                tbox_tel.Clear();
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
            tbox_tel.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            string tel = tbox_tel.Text;
            tbox_tel.TextMaskFormat = MaskFormat.IncludePromptAndLiterals;

            tbox_sus.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            string sus = tbox_sus.Text;
            tbox_sus.TextMaskFormat = MaskFormat.IncludePromptAndLiterals;

            

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

                string cmd = "update paciente set nome = '" + tbox_nome.Text + "', end = '" + tbox_end.Text + "', tel = '"+tel+"', data_nasc =  '" + data_nasc + "' , obs = '" + tbox_obs.Text + "', sexo = '"+sexo+"' where cod_sus = '" + sus + "'";
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

      

        private void btn_salvar_Click(object sender, EventArgs e)
        {

        }
    }
}
