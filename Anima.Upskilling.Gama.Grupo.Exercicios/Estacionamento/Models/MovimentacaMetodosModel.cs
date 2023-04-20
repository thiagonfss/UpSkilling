namespace Estacionamento.Models;

public partial class MovimentacaModel
{
    public void Atualizar()
    {
        _tickets = _service.GetTickets().Result;
    }
}
