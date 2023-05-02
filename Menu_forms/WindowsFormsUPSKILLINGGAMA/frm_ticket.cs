using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsUPSKILLINGGAMA.Configurations;
using WindowsFormsUPSKILLINGGAMA.Models;

namespace WindowsFormsUPSKILLINGGAMA
{
    public partial class frm_ticket : Form
    {
        public frm_ticket()
        {
            InitializeComponent();

            // Preenchendo a ComboBox com os valores do enum
            foreach (var servicoSelecionado in Enum.GetValues(typeof(TipoServicoEnum)))
            {
                cb_tpo_servico.Items.Add(servicoSelecionado);
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void lbl_dat_hora_Click(object sender, EventArgs e)
        {

        }

        private void btn_reg_entrada_Click(object sender, EventArgs e)
        {
            // Obter a data e hora atual
            DateTime dataHoraEntrada = DateTime.Now;

            // Obter o tipo de serviço selecionado no ComboBox
            foreach (var tipoServico in Enum.GetValues(typeof(TipoServicoEnum)))
            {
                cb_tpo_servico.Items.Add(tipoServico);
            }

            // Definir o objeto ValorServico com os valores desejados
            ValorServico valorServico = new ValorServico();
            int mensalista = valorServico.Mensalista; // retorna 90
            int diaria = valorServico.Diaria; // retorna 25
            double hora = valorServico.Hora; // retorna 7.5

            // Exibir a data e hora + tipo de serviço em um rótulo
            lbl_dat_hora.Text = dataHoraEntrada.ToString();
            lbl_tpo_servico.Text = $"Valor do Mensalista: {valorServico.Mensalista}\n" +
                                   $"Valor da Diária: {valorServico.Diaria}\n" +
                                   $"Valor da Hora: {valorServico.Hora}";
        }

        private void cb_tpo_entrada_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void lbl_tpo_servico_Click(object sender, EventArgs e)
        {

        }
    }
}
