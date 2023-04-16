using Estacionamento.Models;

namespace Estacionamento.StaticHelpers;

public static class VeiculoModelStaticList
{
    public static List<VeiculoModel> Get(List<ClienteModel> _clientes)
    {
        int _minIdCliente = _clientes.Min(cliente => cliente.Id);
        int _maxIdCliente = _clientes.Max(cliente => cliente.Id);

        List<VeiculoModel> veiculos = new List<VeiculoModel>()
        {
            new VeiculoModel()
            {
                Modelo = "Civic",
                Fabricante = "Honda",
                Placa = "ABC1234",
                Cor = "Prata",
                IdCliente = StaticRandom.GetRandomIdCliente(_minIdCliente, _maxIdCliente),
                DataCadastro = StaticRandom.GetRandomDataCadastro()
            },
            new VeiculoModel()
            {
                Modelo = "Golf",
                Fabricante = "Volkswagen",
                Placa = "DEF5678",
                Cor = "Preto",
                IdCliente = StaticRandom.GetRandomIdCliente(_minIdCliente, _maxIdCliente),
                DataCadastro = StaticRandom.GetRandomDataCadastro()
            },
            new VeiculoModel()
            {
                Modelo = "Onix",
                Fabricante = "Chevrolet",
                Placa = "GHI9012",
                Cor = "Vermelho",
                IdCliente = StaticRandom.GetRandomIdCliente(_minIdCliente, _maxIdCliente),
                DataCadastro = StaticRandom.GetRandomDataCadastro()
            },
            new VeiculoModel()
            {
                Modelo = "Corolla",
                Fabricante = "Toyota",
                Placa = "JKL3456",
                Cor = "Branco",
                IdCliente = StaticRandom.GetRandomIdCliente(_minIdCliente, _maxIdCliente),
                DataCadastro = StaticRandom.GetRandomDataCadastro()
            },
            new VeiculoModel()
            {
                Modelo = "Celta",
                Fabricante = "Chevrolet",
                Placa = "MNO7890",
                Cor = "Azul",
                IdCliente = StaticRandom.GetRandomIdCliente(_minIdCliente, _maxIdCliente),
                DataCadastro = StaticRandom.GetRandomDataCadastro()
            },
            new VeiculoModel()
            {
                Modelo = "Fiesta",
                Fabricante = "Ford",
                Placa = "PQR1234",
                Cor = "Prata",
                IdCliente = StaticRandom.GetRandomIdCliente(_minIdCliente, _maxIdCliente),
                DataCadastro = StaticRandom.GetRandomDataCadastro()
            },
            new VeiculoModel()
            {
                Modelo = "Uno",
                Fabricante = "Fiat",
                Placa = "STU5678",
                Cor = "Preto",
                IdCliente = StaticRandom.GetRandomIdCliente(_minIdCliente, _maxIdCliente),
                DataCadastro = StaticRandom.GetRandomDataCadastro()
            },
            new VeiculoModel()
            {
                Modelo = "HB20",
                Fabricante = "Hyundai",
                Placa = "VWX9012",
                Cor = "Vermelho",
                IdCliente = StaticRandom.GetRandomIdCliente(_minIdCliente, _maxIdCliente),
                DataCadastro = StaticRandom.GetRandomDataCadastro()
            },
            new VeiculoModel()
            {
                Modelo = "Cruze",
                Fabricante = "Chevrolet",
                Placa = "YZA3456",
                Cor = "Branco",
                IdCliente = StaticRandom.GetRandomIdCliente(_minIdCliente, _maxIdCliente),
                DataCadastro = StaticRandom.GetRandomDataCadastro()
            }
        };

        veiculos.ForEach(veiculo => veiculo.NomeCliente = _clientes.Single(y => y.Id == veiculo.IdCliente).NomeCompleto);
        
        return veiculos;
    }
}