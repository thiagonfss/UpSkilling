using Estacionamento.Models;

namespace Estacionamento.StaticHelpers;

static class TicketModelStaticList
{
    public static List<TicketModel> Get(List<ClienteModel> _clientes, List<VeiculoModel> _veiculos, double valorPorMinuto)
    {
        int minIdCliente = _clientes.Min(cliente => cliente.Id);
        int maxIdCliente = _clientes.Max(cliente => cliente.Id);

        int minIdVeiculo = _veiculos.Min(veiculo => veiculo.Id);
        int maxIdVeiculo = _veiculos.Max(veiculo => veiculo.Id);

        // Lista de Tickets Iniciada
        List<TicketModel> tickets = Enumerable.Range(1, maxIdVeiculo).Select(_ => new TicketModel
        {
            Entrada = StaticRandom.GetRandomDataCadastro(),
        }).ToList();

        // Add Veiculos
        tickets.ForEach(ticket =>
        {
            int idRandom = StaticRandom.GetRandomIdVeiculo(maxIdVeiculo);
            bool ticketVeiculoExiste = tickets.FindAll(t => t.IdVeiculo.GetValueOrDefault() == idRandom).Any();

            if (!ticketVeiculoExiste)
            {
                VeiculoModel veiculo = _veiculos.Single(v => v.Id == idRandom);
                ticket.IdVeiculo = veiculo.Id;
                ticket.DescricaoVeiculo = $"Modelo: {veiculo.Fabricante} {veiculo.Modelo}, Cor: {veiculo.Cor}, Placa: {veiculo.Placa}";

                ticket.IdCliente = veiculo.IdCliente;
                ticket.NomeCliente = veiculo.NomeCliente;
            }
        });

        // Crianto Tickets Abertos
        tickets.ForEach(ticket =>
        {
            ticket.IniciarTcket(valorPorMinuto);
        });

        // Crianto Tickets Fechados
        tickets.ForEach(ticket =>
        {
            if (StaticRandom.RandomBoolean() && ticket.Ativo)
                ticket.FecharTcket();
        });

        return tickets.Where(ticket => ticket.IdCliente != 0).ToList();
    }
}