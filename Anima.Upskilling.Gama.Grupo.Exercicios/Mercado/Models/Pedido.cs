
namespace Mercado.Models
{
    public class Pedido : ModelBase
    {
        public Guid IdCliente { get; private set; }
        public double ValorTotal { get; private set; } = 0D;
        public DateTime Data { get; set; } = DateTime.Now;

        public List<PedidoProduto> produtos { get; private set; } = new List<PedidoProduto>();

        public Pedido() { }

        public Pedido(Guid cliente)
        {
            IdCliente = cliente;
        }

        public double AtulizaValorPedido()
        {
            ValorTotal = 0D;

            foreach(var produto in produtos)
            {
                ValorTotal += (produto.ValorVenda * produto.Quantidade);
            }

            return ValorTotal;
        }

        public void ListarPedido(List<Pedido> pedidos, List<Cliente> clientes, List<Produto> produtos)
        {
            foreach (var pedido in pedidos)
            {
                Console.WriteLine($"Id Pedido: {pedido.Id}");
                Console.WriteLine($"Cliente: {clientes.Where(x => x.Id.Equals(pedido.IdCliente)).First().Nome}");
                Console.WriteLine($"Valor Total: R$ {pedido.ValorTotal.ToString("N2")}");
                Console.WriteLine($"Data: {pedido.Data}");

                if(pedido.produtos != null)
                {
                    Console.WriteLine("\nPRODUTOS:\n");

                    foreach (var produtosPedido in pedido.produtos)
                    {
                        var produto = produtos.Where(x => x.Id.Equals(produtosPedido.IdProduto)).First();

                        Console.WriteLine($"Id Produto: {produto.Id}");
                        Console.WriteLine($"Nome: {produto.Nome}");
                        Console.WriteLine($"Descricao: {produto.Descricao}");
                        Console.WriteLine($"Valor Unidade: R$ {produto.Valor.ToString("N2")}");
                        Console.WriteLine($"Quantidade: {produtosPedido.Quantidade}");
                        Console.WriteLine($"Valor Total Item: R$ {(produto.Valor * produtosPedido.Quantidade).ToString("N2")}");
                        Console.WriteLine("------------------------------");
                    }
                }
                Console.WriteLine("======================================");
            }
            Console.WriteLine("Pressione Enter para continuar ...");
            Console.ReadKey();
        }
    }
}
