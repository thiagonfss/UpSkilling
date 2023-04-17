
namespace Mercado.Models
{
    public class Cliente : ModelBase
    {
        public string? Nome { get; set; }
        public string? Endereco { get; set; }

        public Cliente() { }

        public Cliente(string? nome, string? endereco)
        {
            Nome = nome;
            Endereco = endereco;
        }

        public void ListarCliente(List<Cliente> clientes)
        {
            Console.WriteLine("===== Lista de clientes =====");
            foreach (var cliente in clientes)
            {
                Console.WriteLine($"Id: {cliente.Id}");
                Console.WriteLine($"Nome: {cliente.Nome}");
                Console.WriteLine($"Telefone: {cliente.Endereco}");
                Console.WriteLine("------------------------------");
            }
            Console.WriteLine("Pressione Enter para continuar ...");
            Console.ReadKey();
        }
    }
}
