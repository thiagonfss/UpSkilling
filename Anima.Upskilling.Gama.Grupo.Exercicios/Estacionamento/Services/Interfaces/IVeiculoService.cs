using Estacionamento.Models;

namespace Estacionamento.Services.Interfaces
{
    public interface IVeiculoService
    {
        Task<List<VeiculoModel>> GetVeiculos();
        Task<VeiculoModel> GetVeiculo(int id);
        Task<bool> CadastrarVeiculo(VeiculoModel veiculo, bool msgStatus = true);
    }
}
