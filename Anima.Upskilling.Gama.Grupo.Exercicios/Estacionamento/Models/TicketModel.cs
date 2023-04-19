namespace Estacionamento.Models;

public class TicketModel
{
    // Ticket
    public int Id { get;  set; }
    public bool Ativo { get; private set; } = false;
    private double _valorPorMinuto { get; set; } = 0;
    public string ValorPorMinuto { get => $"R$ {this._valorPorMinuto:F2}"; }
    public DateTime Entrada { get; set; }
    public Nullable<DateTime> Saida { get; set; }

    // Detalhes Ticket
    public string TempoEstacionado { get => TimeSpan.FromMinutes(_tempoEstacionado.GetValueOrDefault()).ToString(@"hh\:mm\:ss"); }
    public string ValorTicket { get => $"R$ {AtualizaValorEstacionamento():F2}"; }

    // Cliente
    public int IdCliente { get; set; }
    public string NomeCliente { get; set; }

    // Veiculo
    public Nullable<int> IdVeiculo { get; set; }
    public string DescricaoVeiculo { get; set; }

    private Nullable<int> _tempoEstacionado { get => AtualizaTempoEstacionado(); }

    public void IniciarTcket(double cobranca)
    {
        this.Ativo = true;
        this._valorPorMinuto = cobranca;
    }

    public void FecharTcket()
    {
        this.Ativo = false;
        this.Saida = DateTime.Now;
    }

    private Nullable<int> AtualizaTempoEstacionado()
    {
        if (Ativo)
            return (int)(DateTime.Now - this.Entrada).TotalMinutes;

        return (int)(this.Saida.Value - this.Entrada).TotalMinutes; ;
    }

    private double AtualizaValorEstacionamento()
    {
        return _tempoEstacionado.GetValueOrDefault() * _valorPorMinuto;
    }

}