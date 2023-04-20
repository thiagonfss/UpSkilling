using Estacionamento.Extensions;
using Estacionamento.Models;
using Estacionamento.Repository;
using Estacionamento.Repository.Interfaces;
using Estacionamento.Services.Interfaces;

namespace Estacionamento.Services;

    public class TicketService : ITicketService
    {
        private ITicketRepository _ticketRepository;

        public TicketService()
        {
            _ticketRepository = new TicketRepository();
        }

        public async Task<List<TicketModel>> GetTickets()
        {
            return (await _ticketRepository.GetTickets()).ToList();
        }

        public async Task<bool> CadastrarTicket(TicketModel ticket, bool msgStatus = true)
        {

            bool ticketSalvo = await _ticketRepository.SalvarTicket(ticket);

            if (msgStatus)
            {
                if (ticketSalvo)
                {
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine($"\t*Ticket {ticket.Id:D4} foi cadastrado com sucesso!\n");
                Console.ResetColor();
                }
                else
                {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine($"\t*Erro ao cadastrar o Ticket {ticket.Id:D4}! Contate o suporte.\n");
                Console.ResetColor();
                }
            }

            return ticketSalvo;
        }
    }