
namespace Mercado.Models
{
    public class PedidoProduto : ModelBase
    {
        public Guid IdProduto { get; private set; }
        public int Quantidade { get; private set; }
        public double ValorVenda {get; private set;}

        public PedidoProduto(Guid idProduto, int quantidade, double valor)
        {
            IdProduto = idProduto;
            Quantidade = quantidade;
            ValorVenda = valor;
        }
    }
}
