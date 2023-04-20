using Estacionamento.Models;

namespace Estacionamento.Repository.Interfaces;
public interface IClienteRepository
{
    Task<IEnumerable<ClienteModel>> GetClientes();
    Task<ClienteModel> GetCliente(int id);
    Task<bool> SalvarCliente(ClienteModel cliente);
    Task<bool> AtualizarCliente(ClienteModel cliente);
    Task<bool> DeletarCliente(ClienteModel cliente);
}
