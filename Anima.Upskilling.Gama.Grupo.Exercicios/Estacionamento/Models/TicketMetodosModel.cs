namespace Estacionamento.Models;

public partial class TicketModel
{
    public void IniciarTcket(double cobranca)
    {
        this.Ativo = true;
        this.ValorPorMinuto = cobranca;
    }

    public void FecharTcket()
    {
        this.Ativo = false;
        this.Saida = DateTime.Now;
    }
}