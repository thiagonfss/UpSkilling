using Estacionamento.Extensions;
using Estacionamento.Models;
using Estacionamento.Repository;
using Estacionamento.Repository.Interfaces;
using Estacionamento.Services.Interfaces;

namespace Estacionamento.Services;

    public class VeiculoService : IVeiculoService
    {
        private IVeiculoRepository _veiculoRepository;

        public VeiculoService()
        {
            _veiculoRepository = new VeiculoRepository();
        }

        public async Task<List<VeiculoModel>> GetVeiculos()
        {
            return (await _veiculoRepository.GetVeiculos()).ToList();
        }

        public async Task<VeiculoModel> GetVeiculo(int id)
        {
            return await _veiculoRepository.GetVeiculo(id);
        }

        public async Task<bool> CadastrarVeiculo(VeiculoModel veiculo, bool msgStatus = true)
        {
            VeiculoModel veiculoNormalizado = new VeiculoModel()
            {
                Placa = veiculo.Placa.ToUpper().Replace(" ", ""),
                Modelo = veiculo.Modelo.ToTittleCase(),
                Cor = veiculo.Cor.ToTittleCase(),
                Fabricante = veiculo.Fabricante.ToTittleCase(),
                IdCliente = veiculo.IdCliente,
                NomeCliente = veiculo.NomeCliente,
            };

            bool veiculoSalvo = await _veiculoRepository.SalvarVeiculo(veiculoNormalizado);

            if (msgStatus)
            {
                if (veiculoSalvo)
                {
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine($"\t*Veículo {veiculo.Fabricante} {veiculo.Modelo}, Placa '{veiculo.Placa}' foi cadastrado com sucesso!\n");
                Console.ResetColor();
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine($"\t*Erro ao tentar cadastrar o veículo {veiculo.Fabricante} {veiculo.Modelo}, Placa '{veiculo.Placa}'! Contate o suporte.\n");
                    Console.ResetColor();
                }
            }

            return veiculoSalvo;
        }
    }