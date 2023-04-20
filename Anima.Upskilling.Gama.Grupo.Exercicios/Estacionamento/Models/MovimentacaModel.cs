using Estacionamento.Services.Interfaces;

namespace Estacionamento.Models;

public partial class MovimentacaModel
{
    private readonly ITicketService _service;
    private IEnumerable<TicketModel> _tickets;
    private double _valorPorMinuto;
    private int _totalVagas = 0;

    public string ValorPorMinuto 
    { 
        get => $"R$ {_valorPorMinuto:F2}"; 
    }
   
    public string TotalVagasDisponiveis 
    {
        get
        {
            int vagas = _totalVagas - _tickets.Count(tickt => tickt.Ativo);
            string text = vagas == 1 ? "Vaga" : "Vagas";
            return $"{vagas} {text}";
        }
    }

    public string TotalVeiculosEstacionados
    {
        get
        {
            int veiculos = _tickets.Count(tickt => tickt.Ativo);
            string text = veiculos == 1 ? "Veículo" : "Veículos";
            return $"{veiculos} {text}";
        }
    }

    public bool TemVagaDisponivel
    {
        get => _totalVagas - _tickets.Count(tickt => tickt.Ativo) > 0;
    }

    public MovimentacaModel(ITicketService service, double valorPorMinuto, int totalVagas)
	{
        _service = service;
        _tickets = service.GetTickets().Result.AsEnumerable();
        _valorPorMinuto = valorPorMinuto;
        _totalVagas = totalVagas;    
    }
}
