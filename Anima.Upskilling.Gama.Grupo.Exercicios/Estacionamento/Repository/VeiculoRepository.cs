using Estacionamento.Models;
using Estacionamento.Repository.Interfaces;
using System.Data;
using Dapper;

namespace Estacionamento.Repository
{
    internal class VeiculoRepository : SqLiteBaseRepository, IVeiculoRepository
    {
        public async Task<VeiculoModel> GetVeiculo(int id)
        {
            try
            {
                using (IDbConnection conexao = GetConnection())
                {
                    var sql = @"
                                SELECT *
                                FROM Veiculos
                                WHERE Id = @Id
                                ";
                    return await conexao.QueryFirstOrDefaultAsync<VeiculoModel>(sql, new { Id = id });
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task<IEnumerable<VeiculoModel>> GetVeiculos()
        {
            try
            {
                using (IDbConnection conexao = GetConnection())
                {
                    var sql = @"
                                SELECT * 
                                FROM Veiculos 
                                ";

                    return await conexao.QueryAsync<VeiculoModel>(sql);
                }
            }
            catch (Exception)
            {
                return Enumerable.Empty<VeiculoModel>();
            }
        }

        public async Task<bool> AtualizarVeiculo(VeiculoModel veiculo)
        {
            try
            {
                using (IDbConnection conexao = GetConnection())
                {
                    var sql = @"
                                UPDATE Veiculos
                                SET Modelo = @Modelo,
                                    Placa = @Placa,
                                    Cor = @Cor,
                                    DataCadastro = @DataCadastro
                                WHERE Id = @Id;
                                ";

                    return await conexao.ExecuteAsync(sql, veiculo) > 0;
                }
            }
            catch (Exception)
            {
                return false;
            }
        }

        public async Task<bool> DeletarVeiculo(VeiculoModel veiculo)
        {
            try
            {
                using (IDbConnection conexao = GetConnection())
                {
                    var sql = @"
                                DELETE
                                FROM Veiculos
                                WHERE Id = @Id;
                                ";

                    return await conexao.ExecuteAsync(sql, new { ID = veiculo.Id }) > 0;
                }
            }
            catch (Exception)
            {
                return false;
            }
        }

        public async Task<bool> SalvarVeiculo(VeiculoModel veiculo)
        {
            try
            {
                using (IDbConnection conexao = GetConnection())
                {
                    string sql = @"
                                    INSERT INTO Veiculos (Modelo, Placa, Cor, Fabricante, Modelo, DataCadastro, IdCliente, NomeCliente) 
                                    VALUES (@Modelo, @Placa, @Cor, @Fabricante, @Modelo, @DataCadastro, @IdCliente, @NomeCliente);";

                    return await conexao.ExecuteAsync(sql, veiculo) > 0;
                }
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}