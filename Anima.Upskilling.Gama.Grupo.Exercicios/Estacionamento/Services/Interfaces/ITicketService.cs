using Estacionamento.Models;

namespace Estacionamento.Services.Interfaces
{
    public interface ITicketService
    {
        Task<List<TicketModel>> GetTickets();
        Task<bool> AtualizarTicket(TicketModel ticket, bool msgStatus = true);
        Task<bool> CadastrarTicket(TicketModel ticket, bool msgStatus = true);
    }
}
