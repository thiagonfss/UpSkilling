using Estacionamento.Models;

namespace Estacionamento.Repository.Interfaces;

public interface ITicketRepository
{
    Task<IEnumerable<TicketModel>> GetTickets();
    Task<TicketModel> GetTicket(int id);
    Task<bool> SalvarTicket(TicketModel ticket);
    Task<bool> AtualizarTicket(TicketModel ticket);
    Task<bool> DeletarTicket(TicketModel ticket);
}
