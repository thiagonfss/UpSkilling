using Estacionamento.Models;

namespace Estacionamento.Repository.Interfaces;

public interface IVeiculoRepository
{
    Task<IEnumerable<VeiculoModel>> GetVeiculos();
    Task<VeiculoModel> GetVeiculo(int id);
    Task<bool> SalvarVeiculo(VeiculoModel veiculo);
    Task<bool> AtualizarVeiculo(VeiculoModel veiculo);
    Task<bool> DeletarVeiculo(VeiculoModel veiculo);
}