namespace Estacionamento;

public class EstacionamentoBase
{
    private bool _sair;

    public void IniciarMenu()
    {
        Console.WriteLine("Bem-vindo ao sistema de gerenciamento de clientes e veículos!");
        _sair = false;

        while (!_sair)
        {
            Console.WriteLine("\nSelecione uma opção:");
            Console.WriteLine("\t1 - Cadastrar Cliente");
            Console.WriteLine("\t2 - Cadastrar Veículo");
            Console.WriteLine("\t3 - Listar Clientes e Veículos");
            Console.WriteLine("\t4 - Cadastrar Movimentação");
            Console.WriteLine("\t0 - Encerrar");

            Console.Write("Opção: ");
            string opcao = Console.ReadLine();

            switch (opcao)
            {
                case "1":
                    CadastrarCliente();
                    break;

                case "2":
                    CadastrarVeiculo();
                    break;

                case "3":
                    ListarClientesVeiculos();
                    break;

                case "4":
                    CadastrarMovimentacao();
                    break;

                case "0":
                    Encerrar();
                    break;

                default:
                    Console.WriteLine("Opção inválida. Selecione uma opção válida.");
                    break;
            }
        }
    }

    private void CadastrarCliente()
    {
        Console.WriteLine("Opção selecionada: Cadastrar Cliente");
    }

    private void CadastrarVeiculo()
    {
        Console.WriteLine("Opção selecionada: Cadastrar Veículo");
    }

    private void ListarClientesVeiculos()
    {
        Console.WriteLine("Opção selecionada: Listar Clientes e Veículos");
    }

    private void CadastrarMovimentacao()
    {
        Console.WriteLine("Opção selecionada: Cadastrar Movimentação");
    }

    private void Encerrar()
    {
        Console.WriteLine("Opção selecionada: Encerrar");
        _sair = true;
    }
}