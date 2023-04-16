namespace Estacionamento.Models;

public class MovimentacaModel
{
    readonly IEnumerable<TicketModel> _tickets;
    readonly double _valorPorMinuto;
    readonly int _totalVagas = 0;

    public string ValorPorMinuto 
    { 
        get => $"R$ {_valorPorMinuto:F2}"; 
    }
   
    public string TotalVagasDisponiveis 
    {
        get
        {
            int vagas = _totalVagas - _tickets.Count(tickt => tickt.Ativo);
            string text = vagas > 1 ? "Vagas" : "Vaga";
            return $"{vagas} {text}";
        }
    }

    public string TotalVeiculosEstacionados
    {
        get
        {
            int veiculos = _tickets.Count(tickt => tickt.Ativo);
            string text = veiculos == 1 ? "Veículos" : "Veículo";
            return $"{veiculos} {text}";
        }
    }

    public bool TemVagaDisponivel
    {
        get => _totalVagas - _tickets.Count(tickt => tickt.Ativo) > 0;
    }

    public MovimentacaModel(List<TicketModel> tickts, double valorPorMinuto, int totalVagas)
	{
        _tickets = tickts;
        _valorPorMinuto = valorPorMinuto;
        _totalVagas = totalVagas;
    }
}
