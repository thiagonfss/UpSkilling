
namespace Mercado.Models
{
    public class Produto : ModelBase
    {
        public string? Nome { get; set; }
        public string? Descricao { get; set; }
        public double Valor { get; private set; }
        public int QuantidadeEstoque { get; private set; }

        public Produto(string? nome, string? descricao, double valor, int estoque)
        {
            Nome = nome;
            Descricao = descricao;
            Valor = valor;
            QuantidadeEstoque = estoque;
        }

        public Produto(){}

        public void AtualizaEstoque(int quantidade)
        {
            QuantidadeEstoque += quantidade;
        }

        public void ListarProduto(List<Produto> produtos)
        {
            Console.WriteLine("===== Lista de Produtos =====");
            foreach (var produto in produtos)
            {
                Console.WriteLine($"Id: {produto.Id}");
                Console.WriteLine($"Nome: {produto.Nome}");
                Console.WriteLine($"Descricao: {produto.Descricao}");
                Console.WriteLine($"Valor: R$ {produto.Valor.ToString("N2")}");
                Console.WriteLine($"Estoque: {produto.QuantidadeEstoque}");
                Console.WriteLine("------------------------------");
            }
            Console.WriteLine("Pressione Enter para continuar ...");
            Console.ReadKey();
        }
    }
}
