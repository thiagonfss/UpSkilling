using Estacionamento.Extensions;
using Estacionamento.Models;
using Estacionamento.Repository;
using Estacionamento.Repository.Interfaces;
using Estacionamento.Services.Interfaces;

namespace Estacionamento.Services;
public class ClienteService : IClienteService
{
    private IClienteRepository _clienteRepository;

	public ClienteService()
    {
        _clienteRepository = new ClienteRepository();
    }

    public async Task<List<ClienteModel>> GetClientes()
    {
        return (await _clienteRepository.GetClientes()).ToList();
    }

    public async Task<ClienteModel> GetCliente(int id)
    {
        return await _clienteRepository.GetCliente(id);
    }

    public async Task<bool> CadastrarCliente(ClienteModel cliente, bool msgStatus = true)
    {
        ClienteModel clienteNormalizado= new ClienteModel()
        {
            NomeCompleto = cliente.NomeCompleto.ToTittleCase(),
            Cpf = cliente.Cpf.ToCpfNormalized(),
            NumeroCelular = cliente.NumeroCelular.ToNumberPhoneNormalized()
        };

        bool clienteSalvo = await _clienteRepository.SalvarCliente(clienteNormalizado);

        if (msgStatus)
        {
            if (clienteSalvo)
            {
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine($"\t*Cliente '{cliente.NomeCompleto}' cadastrado com sucesso!\n");
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine($"\t*Erro ao tentar cadastrar o cliente '{cliente.NomeCompleto}'! Contate o suporte.\n");
                Console.ResetColor();
            }
        }

        return clienteSalvo;
    }
}