namespace Estacionamento.Models;

public partial class TicketModel
{
    // Ticket
    public int Id { get; set; }
    public bool Ativo { get; set; }
    public double ValorPorMinuto { get; set; }
    public DateTime Entrada { get; set; } = DateTime.Now;
    public Nullable<DateTime> Saida { get; set; }

    // Detalhes Ticket
    public string TempoEstacionado { get; set; }
    public double ValorTicket { get; set; }

    // Cliente
    public int IdCliente { get; set; }
    public string NomeCliente { get; set; }

    // Veiculo
    public Nullable<int> IdVeiculo { get; set; }
    public string DescricaoVeiculo { get; set; }
}