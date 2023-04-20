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
        var tickets = (await _ticketRepository.GetTickets()).ToList();
        return AtualizarTicketsModel(tickets);
    }

    public async Task<bool> CadastrarTicket(TicketModel ticket, bool msgStatus = true)
    {
        bool ticketSalvo = await _ticketRepository.SalvarTicket(AtualizarTicketModel(ticket));

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

    public async Task<bool> AtualizarTicket(TicketModel ticket, bool msgStatus = true)
    {
        bool ticketAtualizado = await _ticketRepository.AtualizarTicket(AtualizarTicketModel(ticket));

        if (msgStatus)
        {
            if (ticketAtualizado)
            {
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine($"\t*Fechar Ticket {ticket.Id:D4} Operação concluida sucesso!\n");
                Console.ResetColor();
                Thread.Sleep(1500);
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine($"\t*Não foi possível alterar o status do tícket {ticket.Id:D4}! Contate o suporte.\n");
                Console.ResetColor();
                Thread.Sleep(1500);
            }
        }

        return ticketAtualizado;
    }

    private List<TicketModel> AtualizarTicketsModel(List<TicketModel> tickets)
    {
        tickets.ForEach(ticket =>
        {
            ticket.TempoEstacionado = TempoEstacionado(ticket);
            ticket.ValorTicket = AtualizaValorEstacionamento(ticket);
        });

        return tickets;
    }

    private TicketModel AtualizarTicketModel(TicketModel ticket)
    {
            var ticketModel = new TicketModel()
            {
                Id = ticket.Id,
                Ativo = ticket.Ativo,
                ValorPorMinuto = ticket.ValorPorMinuto,
                Entrada = ticket.Entrada,
                Saida = ticket.Saida,

                // Detalhes Ticket
                TempoEstacionado = TempoEstacionado(ticket),
                ValorTicket = AtualizaValorEstacionamento(ticket),

                // Cliente
                IdCliente = ticket.IdCliente,
                NomeCliente = ticket.NomeCliente,

                // Veiculo
                IdVeiculo = ticket.IdVeiculo,
                DescricaoVeiculo = ticket.DescricaoVeiculo
            };

        return ticketModel;
    }

    private string TempoEstacionado(TicketModel ticket)
    {
        return TimeSpan.FromMinutes(AtualizaTempoEstacionado(ticket).GetValueOrDefault()).ToString(@"hh\:mm\:ss");
    }

    private Nullable<int> AtualizaTempoEstacionado(TicketModel ticket)
    {
        if (ticket.Ativo)
            return (int)(DateTime.Now - ticket.Entrada).TotalMinutes;

        return (int)(ticket.Saida.Value - ticket.Entrada).TotalMinutes; ;
    }

    private double AtualizaValorEstacionamento(TicketModel ticket)
    {
        return AtualizaTempoEstacionado(ticket).GetValueOrDefault() * ticket.ValorPorMinuto;
    }
}
