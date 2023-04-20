using Estacionamento.Models;
using Estacionamento.Repository.Interfaces;
using System.Data;
using Dapper;

namespace Estacionamento.Repository
{
    internal class TicketRepository : SqLiteBaseRepository, ITicketRepository
    {
        public async Task<TicketModel> GetTicket(int id)
        {
            try
            {
                using (IDbConnection conexao = GetConnection())
                {
                    var sql = @"
                                SELECT *
                                FROM Tickets
                                WHERE Id = @Id
                                ";
                    return await conexao.QueryFirstOrDefaultAsync<TicketModel>(sql, new { Id = id });
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task<IEnumerable<TicketModel>> GetTickets()
        {
            try
            {
                using (IDbConnection conexao = GetConnection())
                {
                    var sql = @"
                                SELECT * 
                                FROM Tickets 
                                ";

                    return await conexao.QueryAsync<TicketModel>(sql);
                }
            }
            catch (Exception)
            {
                return Enumerable.Empty<TicketModel>();
            }
        }

        public async Task<bool> AtualizarTicket(TicketModel ticket)
        {
            try
            {
                using (IDbConnection conexao = GetConnection())
                {
                    var sql = @"
                                UPDATE Tickets
                                SET Ativo = @Ativo,
                                    ValorPorMinuto = @ValorPorMinuto,
                                    Entrada = @Entrada,
                                    Saida = @Saida,
                                    TempoEstacionado = @TempoEstacionado,
                                    ValorTicket = @ValorTicket,
                                    IdCliente = @IdCliente,
                                    NomeCliente = @NomeCliente,
                                    IdVeiculo = @IdVeiculo,
                                    DescricaoVeiculo = @DescricaoVeiculo
                                WHERE Id = @Id;
                                ";

                    return await conexao.ExecuteAsync(sql, ticket) > 0;
                }
            }
            catch (Exception)
            {
                return false;
            }
        }

        public async Task<bool> DeletarTicket(TicketModel ticket)
        {
            try
            {
                using (IDbConnection conexao = GetConnection())
                {
                    var sql = @"
                                DELETE
                                FROM Tickets
                                WHERE Id = @Id;
                                ";

                    return await conexao.ExecuteAsync(sql, new { ID = ticket.Id }) > 0;
                }
            }
            catch (Exception)
            {
                return false;
            }
        }

        public async Task<bool> SalvarTicket(TicketModel ticket)
        {
            try
            {
                using (IDbConnection conexao = GetConnection())
                {
                    string sql = @"
                                    INSERT INTO Tickets (Ativo, ValorPorMinuto, Entrada, Saida, TempoEstacionado, ValorTicket, DataCadastro, IdCliente, NomeCliente, IdVeiculo, DescricaoVeiculo) 
                                    VALUES (@Ativo, @ValorPorMinuto, @Entrada, @Saida, @TempoEstacionado, @ValorTicket, @DataCadastro, @IdCliente, @NomeCliente, @IdVeiculo, @DescricaoVeiculo);";

                    return await conexao.ExecuteAsync(sql, ticket) > 0;
                }
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}