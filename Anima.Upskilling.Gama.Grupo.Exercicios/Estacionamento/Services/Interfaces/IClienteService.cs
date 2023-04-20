using Estacionamento.Models;

namespace Estacionamento.Services.Interfaces;

public interface IClienteService
{
    Task<List<ClienteModel>> GetClientes();
    Task<ClienteModel> GetCliente(int id);
    Task<bool> CadastrarCliente(ClienteModel cliente, bool msgStatus = true);
}