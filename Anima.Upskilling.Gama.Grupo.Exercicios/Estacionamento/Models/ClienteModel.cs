namespace Estacionamento.Models;

public class ClienteModel
{
    public int Id { get; private set; }
    public string NomeCompleto { get; set; }
    public string Cpf { get; set; }
    public string NumeroCelular { get; set; }
    public DateTime DataCadastro { get; set; } = DateTime.Now;
}