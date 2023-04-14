namespace Gama_Exercicio3.Models;

public class VeiculoModel
{
    private int _id;

    public int Id { get; private set; }
    public string Placa { get; set; }
    public string Fabricante { get; set; }
    public string Modelo { get; set; }
    public ClienteModel Cliente { get; set; }
    public TicketModel Ticket { get; set; }
}