using Estacionamento.Models;

namespace Estacionamento.Services.Interfaces
{
    public interface IVeiculoService
    {
        Task<List<VeiculoModel>> GetVeiculos();
        Task<bool> CadastrarVeiculo(VeiculoModel veiculo, bool msgStatus = true);
    }
}
