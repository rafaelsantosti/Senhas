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
    public partial class medico : Form
    {
        
        public medico()
        {
            InitializeComponent();
        }

        private void medico_Load(object sender, EventArgs e)
        {
            
            string dia = Convert.ToDateTime(DateTime.Now).ToString("yyyy-MM-dd");
            var dt = new DataTable();
            
            string sql = ("select senha as 'Senha',data_nasc as 'Data de Nascimento', nome as 'Nome',TIMESTAMPDIFF(YEAR, data_nasc, CURDATE()) as Idade ,obs as 'Observações',x.cod_sus,end From paciente x inner join senhas y on x.cod_sus = y.cod_sus where data_senha like '"+dia+"%' order by senha asc;");



            try
            {
                using (var cn = new MySqlConnection(global.strConn))
                {
                    cn.Open();
                    using (var da = new MySqlDataAdapter(sql, cn))
                    {
                        da.Fill(dt);
                        dgv_pacientes.DataSource = dt;
                        dgv_pacientes.Columns[1].Visible = false;
                        dgv_pacientes.Columns[5].Visible = false;
                        dgv_pacientes.Columns[6].Visible = false;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgv_pacientes_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                string sus = dgv_pacientes.CurrentRow.Cells[5].Value.ToString();
                string nome = dgv_pacientes.CurrentRow.Cells[2].Value.ToString();
                string end = dgv_pacientes.CurrentRow.Cells[6].Value.ToString();
                string data = dgv_pacientes.CurrentRow.Cells[1].Value.ToString();
                string obs = dgv_pacientes.CurrentRow.Cells[4].Value.ToString();
                cadastropaciente alterar = new cadastropaciente(sus, nome, end, data, obs);
                alterar.Show();
            }
            catch (Exception)
            {
                MessageBox.Show("SELECIONE UM PACIENTE PARA ALTERAR");
            }
        }

        private void btn_chamar_Click(object sender, EventArgs e)
        {
           

        }
    }
}
