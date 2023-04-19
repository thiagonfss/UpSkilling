
using Estacionamento.Context;
using Estacionamento.Models;

namespace Estacionamento.Repository
{
    public class TicketRepository
    {
        private readonly EstacionamentoContext _context;
        public TicketRepository()
        {
            _context = new EstacionamentoContext();
        }

        public void SalvarTicket(TicketModel ticket)
        {
            _context.Tickets.Add(ticket);
            _context.SaveChanges();
        }

        public TicketModel BuscarTicketPorId(int id)
        {
            return _context.Tickets.Where(x => x.Id == id).FirstOrDefault();
        }

        public List<TicketModel> RetornaTodosTickets()
        {
            return _context.Tickets.ToList();
        }
    }
}
