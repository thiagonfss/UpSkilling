namespace Estacionamento.Models;

public class VeiculoModel
{
    // Veiculo
    public int Id { get; private set; }
    public string Placa { get; set; }
    public string Cor { get; set; }
    public string Fabricante { get; set; }
    public string Modelo { get; set; }
    public DateTime DataCadastro { get; set; } = DateTime.Now;

    // Cliente
    public int IdCliente { get; set; }
    public string NomeCliente { get; set; }
}