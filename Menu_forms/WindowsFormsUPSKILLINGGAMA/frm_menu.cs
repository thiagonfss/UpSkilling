using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsUPSKILLINGGAMA
{
    public partial class frm_menu : Form
    {
        public frm_menu()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        private void btn_cdt_clientes_Click(object sender, EventArgs e)
        {
            frm_clientes frm = new frm_clientes();
            frm.Show();
        }

        private void btn_cdt_veiculos_Click(object sender, EventArgs e)
        {
            frm_veiculos frm = new frm_veiculos();
            frm.Show();
        }

        private void btn_hist_vendas_Click(object sender, EventArgs e)
        {
            frm_hist_vendas frm = new frm_hist_vendas();
            frm.Show();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_clientes frm = new frm_clientes();
            frm.Show();
        }

        private void veiculosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_veiculos frm = new frm_veiculos();
            frm.Show();
        }
                
    }
}
