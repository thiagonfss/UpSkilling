namespace Estacionamento.Models;
public class ClienteModel
{
    private int _id;

    public int Id { get; private set; }
    public string NomeCompleto { get; set; }
    public string Cpf { get; set; }
    public string Telefone { get; set; }
}