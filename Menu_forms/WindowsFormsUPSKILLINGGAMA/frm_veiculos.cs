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
    public partial class frm_veiculos : Form
    {
        public frm_veiculos()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_cadastrar_Click(object sender, EventArgs e)
        {
            VeiculoModel veiculo = new VeiculoModel();

            veiculo.Id = 0; // _veiculoService.GetNewId();
            veiculo.Modelo = this.txt_modelo.Text;
            veiculo.Placa = this.txt_placa.Text;

            // _veiculoService.Cadastrar(veiculo);
        }
    }
}
