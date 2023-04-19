using Estacionamento.Models;
using Estacionamento.Context;
using Microsoft.EntityFrameworkCore;

namespace Estacionamento.Repository
{
    public class ClienteRepository
    {
        private readonly EstacionamentoContext _context;
        public ClienteRepository()
        {
            _context = new EstacionamentoContext();
        }

        public void SalvarCliente(ClienteModel cliente)
        {
            _context.Clientes.Add(cliente);
            _context.SaveChanges();
        }

        public ClienteModel BuscarClientePorId(int id)
        {
            return _context.Clientes.Where(x => x.Id == id).FirstOrDefault();
        }
        
        public List<ClienteModel> RetornaTodosClientes()
        {
            return _context.Clientes.ToList();
        }
    }
}
