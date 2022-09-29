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
    public partial class gerenciador : Form
    {
        public gerenciador()
        {
            InitializeComponent();
        }

        

        private void tbox_filtro_KeyUp(object sender, KeyEventArgs e)
        {
            var dt = new DataTable();
            string filtro = "";
            try
            {
                filtro = Convert.ToDateTime(tbox_filtro.Text).ToString("yyyy-MM-dd");
            }
            catch (Exception)
            {
                filtro = tbox_filtro.Text;
            }


            string sql;

            if (filtro == "")
            {
                sql = "select nome as 'Nome' , x.cod_sus as 'SUS' , x.data_senha as 'Data da Retirada', x.data_chamada as 'Data Atendimento' from senhasatendidas x inner join senhatelao y on x.data_senha = y.data_senha;";
            }
            else
            {
                sql = "select nome as 'Nome' , x.cod_sus as 'SUS' , x.data_senha as 'Data da Retirada', x.data_chamada as 'Data Atendimento' from senhasatendidas x inner join senhatelao y on x.data_senha = y.data_senha where nome like '" + filtro + "%' or x.cod_sus like '" + filtro + "%' or x.data_senha like '" + filtro + "%'";
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

        private void combo_SelectedIndexChanged(object sender, EventArgs e)
        {
            //pesquisa via textbox
            if (combo.SelectedIndex == 0)
            {
                tbox_filtro.Enabled = true;
                if (tbox_filtro.Text == "")
                {
                    tbox_filtro.Text = "Digite sua pesquisa aqui";
                }


            }

            //listar todas as senhas
            if (combo.SelectedIndex == 1)
            {
                if (tbox_filtro.Text != "Digite sua pesquisa aqui")
                {
                    tbox_filtro.Text = "Digite sua pesquisa aqui";
                }
                tbox_filtro.Enabled = false;
                var dt = new DataTable();
                string sql;
                sql = "select nome as Nome, x.cod_sus as SUS, data_senha as 'Data de Retirada', data_chamada as 'Data Atendimento' from senhasatendidas x inner join paciente y on x.cod_sus = y.cod_sus";

                try
                {
                    using (var cn = new MySqlConnection(global.strConn))
                    {
                        cn.Open();
                        using (var da = new MySqlDataAdapter(sql, cn))
                        {
                            da.Fill(dt);
                            dgv_pacientes.DataSource = dt;
                            cn.Close();

                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            //proximas senhas
            if (combo.SelectedIndex == 2)
            {
                if (tbox_filtro.Text != "Digite sua pesquisa aqui")
                {
                    tbox_filtro.Text = "Digite sua pesquisa aqui";
                }
                tbox_filtro.Enabled = false;
                string dia = Convert.ToDateTime(DateTime.Now).ToString("yyyy-MM-dd");
                var dt = new DataTable();
                string sql = ("Select x.nome as 'Nome' , y.senha as 'Senha', y.data_senha as 'Data de Retirada' from paciente x inner join senhas y on x.cod_sus = y.cod_sus where y.data_senha like '"+ dia + "%'");



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
            //senhas chamadas hoje
            if (combo.SelectedIndex == 3)
            {
                if (tbox_filtro.Text != "Digite sua pesquisa aqui")
                {
                    tbox_filtro.Text = "Digite sua pesquisa aqui";
                }
                tbox_filtro.Enabled = false;
                //senhas atendidas Hoje
                string dia = Convert.ToDateTime(DateTime.Now).ToString("yyyy-MM-dd");
                var dt = new DataTable();
                string sql = ("Select y.nome as 'Nome' , x.senha as 'SENHA',x.data_senha as 'Data de Retirada',x.data_chamada as 'Data da Chamada' from senhasatendidas x inner join paciente y on x.cod_sus = y.cod_sus where data_senha like'" + dia + "%'");



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
            //todas senhas chamadas
            if (combo.SelectedIndex == 4)
            {
                if (tbox_filtro.Text != "Digite sua pesquisa aqui")
                {
                    tbox_filtro.Text = "Digite sua pesquisa aqui";
                }
                tbox_filtro.Enabled = false;
                var dt = new DataTable();
                string sql;
                sql = "Select y.nome as 'Nome' , x.senha as 'Senha',x.data_senha as 'Data de Retirada',x.data_chamada as 'Data da Chamada' from senhasatendidas x inner join paciente y on x.cod_sus = y.cod_sus";

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

        }

        private void tbox_filtro_Click(object sender, EventArgs e)
        {
            if(tbox_filtro.Text=="Digite sua pesquisa aqui")

            {
                tbox_filtro.Text = "";
            }
        }

        private void gerenciador_Load(object sender, EventArgs e)
        {

        }

        private void tbox_filtro_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

