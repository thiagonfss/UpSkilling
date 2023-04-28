using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsUPSKILLINGGAMA.Models;

namespace WindowsFormsUPSKILLINGGAMA
{
    public partial class frm_clientes : Form
    {
        public frm_clientes()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void frm_clientes_Load(object sender, EventArgs e)
        {

        }

        private void btn_cadastrar_Click(object sender, EventArgs e)
        {
            ClienteModel cliente = new ClienteModel();

            cliente.Id = 0; //implementar
            cliente.Nome = this.txt_nome.Text;
            cliente.Telefone = this.txt_telefone.Text;

            // _clienteService.Cadastrar(cliente);
        }
    }
}
