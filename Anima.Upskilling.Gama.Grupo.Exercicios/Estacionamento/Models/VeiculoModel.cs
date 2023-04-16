namespace Estacionamento.Models;

public class VeiculoModel
{
    private static int _id = 1;

    // Veiculo
    public int Id { get; private set; } = _id;
    public string Placa { get; set; }
    public string Cor { get; set; }
    public string Fabricante { get; set; }
    public string Modelo { get; set; }
    public DateTime DataCadastro { get; set; } = DateTime.Now;

    // Cliente
    public int IdCliente { get; set; }
    public string NomeCliente { get; set; }

    public VeiculoModel()
    {
        _id++;
    }
}