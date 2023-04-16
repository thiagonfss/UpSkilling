namespace Estacionamento.Models;

public class ClienteModel
{
    private static int _id = 1;

    public int Id { get; private set; } = _id;
    public string NomeCompleto { get; set; }
    public string Cpf { get; set; }
    public string NumeroCelular { get; set; }
    public DateTime DataCadastro { get; set; } = DateTime.Now;

    public ClienteModel()
    {
        _id++;
    }
}