using Mercado.Models;

namespace Mercado.Services
{
    public class MenuService
    {
        private List<Pedido> _pedidos = new List<Pedido>();
        private List<Cliente> _clientes = new List<Cliente>() { new Cliente("Cliente Generico", "Endereco") };
        private List<Produto> _produtos = new List<Produto>() { new Produto("Produto Generico", "Descricao", 3.99D, 100) };

        public void MenuOpcao()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Digite uma das opções abaixo:");
                Console.WriteLine("1 - Cadastrar Cliente");
                Console.WriteLine("2 - Listar Clientes");

                Console.WriteLine("3 - Cadastrar Produto");
                Console.WriteLine("4 - Listar Produtos");

                Console.WriteLine("5 - Realizar Pedido");
                Console.WriteLine("6 - Listar Pedidos");

                Console.WriteLine("7 - Adicionar itens a um pedido");
                Console.WriteLine("8 - Remover itens de um pedido");

                Console.WriteLine("0 - Sair");

                var opcao = int.Parse(Console.ReadLine());
                var sair = false;
                switch (opcao)
                {
                    case 1:
                        Console.Clear();
                        Console.WriteLine("Digite o nome do cliente");
                        var nome = Console.ReadLine();
                        Console.WriteLine("Digite o endereço do cliente");
                        var endereco = Console.ReadLine();

                        Cliente clienteNovo = new Cliente(nome, endereco);
                        _clientes.Add(clienteNovo);

                        Console.WriteLine("Cliente cadastrado com sucesso!");
                        Console.ReadKey();
                        break;
                    case 2:
                        Cliente clienteList = new Cliente();
                        clienteList.ListarCliente(_clientes);
                        break;
                    case 3:
                        Console.Clear();
                        Console.WriteLine("Digite o Titulo do produto:");
                        var nomeProduto = Console.ReadLine();
                        Console.WriteLine("Descricao produto:");
                        var descricaoProduto = Console.ReadLine();
                        Console.WriteLine("Valor do produto:");
                        var valorProduto = double.Parse(Console.ReadLine());
                        Console.WriteLine("Quantidade em estoque");
                        var estoque = int.Parse(Console.ReadLine());
                        Produto produtoNovo = new Produto(nomeProduto, descricaoProduto, valorProduto, estoque);
                        _produtos.Add(produtoNovo);
                        Console.WriteLine("Produto cadastrado com sucesso....");
                        break;
                    case 4:
                        Console.Clear();
                        Produto produto = new Produto();
                        produto.ListarProduto(_produtos);
                        break;
                    case 5:
                        Console.WriteLine("====== Realizar um novo pedido =====");
                        Cliente cliente = new Cliente();
                        cliente.ListarCliente(_clientes);

                        var guidCliente = RecebeGuid(_clientes);
                        Pedido pedidoNovo = new Pedido(guidCliente);
                        _pedidos.Add(pedidoNovo);
                        Console.WriteLine("Pedido Aberto Com Sucesso, pode adicionar itens ao seu pedido!");
                        break;
                    case 6:
                        Console.Clear();
                        Pedido pedido = new Pedido();
                        pedido.ListarPedido(_pedidos, _clientes, _produtos);
                        break;
                    case 7:
                        Console.Clear();
                        Pedido realizaPedido = new Pedido();
                        realizaPedido.ListarPedido(_pedidos, _clientes, _produtos);

                        Console.WriteLine("\nDigite o Id do Pedido ao qual deseja adicionar um item");
                        var idPedido = RecebeGuid(_pedidos);
                        var pedidoCliente = _pedidos.Where(x => x.Id.Equals(idPedido)).First();
                        Produto produtoListar = new Produto();
                        while (true)
                        {
                            produtoListar.ListarProduto(_produtos);

                            Console.WriteLine("\nDigite id do produto que deseja adicionar:");
                            var idProduto = RecebeGuid(_produtos);
                            Console.WriteLine("Quantidade que necessita:");
                            var quantidade = int.Parse(Console.ReadLine());

                            var valorVenda = _produtos.Where(x => x.Id.Equals(idProduto)).First().Valor;

                            PedidoProduto pedidoProduto = new PedidoProduto(idProduto, quantidade, valorVenda);
                            pedidoCliente.produtos.Add(pedidoProduto);
                            pedidoCliente.AtulizaValorPedido();

                            var produtoAdicao = _produtos.Where(x => x.Id.Equals(idProduto)).First();
                            produtoAdicao.AtualizaEstoque(quantidade * (-1));
                            
                            Console.WriteLine("Produto adicionado! para sair do cadastro digite 0");
                            if (Console.ReadLine() == "0") break;
                            Console.Clear();
                        }

                        break;
                    case 8:
                        Console.Clear();
                        Pedido removePedido = new Pedido();
                        removePedido.ListarPedido(_pedidos, _clientes, _produtos);

                        Console.WriteLine("\n Digite o Id do Pedido ao qual deseja remover um item");
                        idPedido = RecebeGuid(_pedidos);
                        pedido = _pedidos.Where(x => x.Id.Equals(idPedido)).First();

                        if (!pedido.produtos.Any())
                        {
                            Console.WriteLine("Este pedido não possui produtos vínculados!");
                            break;
                        }

                        while (true)
                        {
                            Console.WriteLine("Digite id do produto que deseja remover:");
                            var idProduto = RecebeGuid(_produtos);
                            var produtoPedido = pedido.produtos.Where(x => x.IdProduto.Equals(idProduto)).First();

                            pedido.produtos.Remove(produtoPedido);
                            pedido.AtulizaValorPedido();

                            var produtoRemocao = _produtos.Where(x => x.Id.Equals(idProduto)).First();
                            produtoRemocao.AtualizaEstoque(produtoPedido.Quantidade);

                            Console.WriteLine("Produto removido com sucesso! para sair da remoção digite 0");
                            if (Console.ReadLine() == "0") break;
                        }

                        break;
                    case 0:
                        Console.Clear();
                        Console.WriteLine("Obrigado e volte sempre :)");
                        Console.ReadKey();
                        sair = true;
                        break;
                }
                if (sair) break;
            }
        }

        public bool ValidaGuid(Guid guid, IEnumerable<ModelBase> lista)
        {
            if (lista.Where(x => x.Id.Equals(guid)).ToList().Any()) return true;
            return false;
        }

        public Guid RecebeGuid(IEnumerable<ModelBase> lista)
        {
            while (true)
            {
                Console.WriteLine("Insira o Id para operacao:");
                var guid = Guid.Parse(Console.ReadLine());
                if (ValidaGuid(guid, lista)) return guid;
                Console.WriteLine("Id inválido por favor tente novamente!");
            }
        }
    }
}
