
using Estacionamento.Context;
using Estacionamento.Models;

namespace Estacionamento.Repository
{
    public class VeiculoRepository
    {
        private readonly EstacionamentoContext _context;
        public VeiculoRepository()
        {
            _context = new EstacionamentoContext();
        }
        public void SalvarVeiculo(VeiculoModel veiculo)
        {
            _context.Veiculos.Add(veiculo);
            _context.SaveChanges();
        }

        public VeiculoModel BuscarVeiculoPorId(int id)
        {
            return _context.Veiculos.Where(x => x.Id == id).FirstOrDefault();
        }

        public List<VeiculoModel> RetornaTodosVeiculos()
        {
            return _context.Veiculos.ToList();
        }

        public List<VeiculoModel> BuscarVeiculosPorCliente(int idCliente)
        {
            return _context.Veiculos.Where(x => x.IdCliente == idCliente).ToList();
        }
    }
}
