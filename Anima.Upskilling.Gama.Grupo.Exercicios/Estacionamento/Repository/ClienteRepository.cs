using Estacionamento.Models;
using Estacionamento.Repository.Interfaces;
using System.Data.SQLite;
using System.Data;
using Dapper;

namespace Estacionamento.Repository;

internal class ClienteRepository : SqLiteBaseRepository, IClienteRepository
{
    public async Task<ClienteModel> GetCliente(int id)
    {
        try
        {
            using (IDbConnection conexao = GetConnection())
            {
                var sql = @"
                            SELECT * 
                            FROM Clientes 
                            WHERE Id = @Id
                            ";

                return await conexao.QueryFirstOrDefaultAsync<ClienteModel>(sql, new { Id = id });
            }
        }
        catch (Exception)
        {
            return new ClienteModel();
        }
    }

    public async Task<IEnumerable<ClienteModel>> GetClientes()
    {
        try
        {
            using (IDbConnection conexao = GetConnection())
            {
                var sql = @"
                            SELECT * 
                            FROM Clientes 
                            ";

                return await conexao.QueryAsync<ClienteModel>(sql);
            }
        }
        catch (Exception)
        {
            return Enumerable.Empty<ClienteModel>();
        }
    }

    public async Task<bool> AtualizarCliente(ClienteModel cliente)
    {
        try
        {
            using (IDbConnection conexao = GetConnection())
            {
                var sql = @"
                    UPDATE Clientes
                    SET NomeCompleto = @NomeCompleto,
                        Cpf = @Cpf,
                        NumeroCelular = @NumeroCelular,
                        DataCadastro = @DataCadastro
                    WHERE Id = @Id;
                    ";

                return await conexao.ExecuteAsync(sql, cliente) > 0;
            }
        }
        catch (Exception)
        {
            return false;
        }
    }

    public async Task<bool> DeletarCliente(ClienteModel cliente)
    {
        try
        {
            using (IDbConnection conexao = GetConnection())
            {
                var sql = @"
                    DELETE
                    FROM Clientes
                    WHERE Id = @Id;
                    ";

                return await conexao.ExecuteAsync(sql, new { ID = cliente.Id }) > 0;
            }
        }
        catch (Exception)
        {
            return false;
        }
    }

    public async Task<bool> SalvarCliente(ClienteModel cliente)
    {
        try
        {
            using (IDbConnection conexao = GetConnection())
            {
                string sql = @"
                        INSERT INTO Clientes (NomeCompleto, Cpf, NumeroCelular, DataCadastro) 
                        VALUES (@NomeCompleto, @Cpf, @NumeroCelular, @DataCadastro);";

                return await conexao.ExecuteAsync(sql, cliente) > 0;
            }
        }
        catch (Exception)
        {
            return false;
        }
    }
}