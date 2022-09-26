using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            //this.Hide();
            main fmain = new main();
            fmain.Closed += (s, args) => this.Show();
            fmain.Show();

        }

        private void btn_medico_Click(object sender, EventArgs e)
        { 
            
                this.Hide();
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
    }
}
