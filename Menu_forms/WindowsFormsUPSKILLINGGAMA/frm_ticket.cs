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
        private ValorServico valorServico;

        public frm_ticket()
        {
            InitializeComponent();
            valorServico = new ValorServico();

            // Preenchendo a ComboBox com os valores do enum
            foreach (var servicoSelecionado in Enum.GetValues(typeof(TipoServicoEnum)))
            {
                cb_tpo_servico.Items.Add(servicoSelecionado);
            }

            // Definir o objeto ValorServico com os valores desejados
            valorServico.Mensalista = 90;
            valorServico.Diaria = 25;
            valorServico.Hora = 7.5;
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

            // Exibir a data e hora + tipo de serviço em um rótulo
            lbl_dat_hora.Text = dataHoraEntrada.ToString();
            lbl_tpo_servico.Text = $"Valor do Mensalista: {valorServico.Mensalista}\n" +
                                   $"Valor da Diária: {valorServico.Diaria}\n" +
                                   $"Valor da Hora: {valorServico.Hora}";
        }

        private void cb_tpo_entrada_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Obter o tipo de serviço selecionado no ComboBox
            TipoServicoEnum tipoServicoSelecionado = (TipoServicoEnum)cb_tpo_servico.SelectedItem;

            // Definir o texto do rótulo lbl_tpo_servico com base no tipo de serviço selecionado
            switch (tipoServicoSelecionado)
            {
                case TipoServicoEnum.Mensalista:
                    lbl_tpo_servico.Text = $"Valor do Mensalista: {valorServico.Mensalista}";
                    break;
                case TipoServicoEnum.Diaria:
                    lbl_tpo_servico.Text = $"Valor da Diária: {valorServico.Diaria}";
                    break;
                case TipoServicoEnum.Hora:
                    lbl_tpo_servico.Text = $"Valor da Hora: {valorServico.Hora}";
                    break;
            }
        }

        private void lbl_tpo_servico_Click(object sender, EventArgs e)
        {

        }
    }
}
