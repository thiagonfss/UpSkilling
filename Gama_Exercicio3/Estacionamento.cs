namespace Gama_Exercicio3;

public class Estacionamento
{
    public void IniciarMenu()
    {
        bool sair = false;

        while (!sair)
        {
            Console.WriteLine("Bem-vindo ao sistema de gerenciamento de clientes e veículos!");
            Console.WriteLine("Selecione uma opção:");
            Console.WriteLine("1 - Cadastrar Cliente");
            Console.WriteLine("2 - Cadastrar Veículo");
            Console.WriteLine("3 - Listar Clientes e Veículos");
            Console.WriteLine("4 - Cadastrar Movimentação");
            Console.WriteLine("0 - Encerrar");

            string opcao = Console.ReadLine();

            switch (opcao)
            {
                case "1":
                    Console.WriteLine("Opção selecionada: Cadastrar Cliente");
                    CadastrarCliente();
                    break;

                case "2":
                    Console.WriteLine("Opção selecionada: Cadastrar Veículo");
                    CadastrarVeiculo();
                    break;

                case "3":
                    Console.WriteLine("Opção selecionada: Listar Clientes e Veículos");
                    ListarClientesVeiculos();
                    break;

                case "4":
                    Console.WriteLine("Opção selecionada: Cadastrar Movimentação");
                    CadastrarMovimentacao();
                    break;

                case "0":
                    Console.WriteLine("Opção selecionada: Encerrar");
                    sair = true;
                    break;

                default:
                    Console.WriteLine("Opção inválida. Selecione uma opção válida.");
                    break;
            }
        }
    }

    private void CadastrarCliente()
    {

    }

    private void CadastrarVeiculo()
    {

    }

    private void ListarClientesVeiculos()
    {

    }

    private void CadastrarMovimentacao()
    {

    }
}