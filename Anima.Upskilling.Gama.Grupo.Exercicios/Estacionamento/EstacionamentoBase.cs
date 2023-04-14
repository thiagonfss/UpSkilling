namespace Estacionamento;

public class EstacionamentoBase
{
    const int _maxtentativas = 4;
    private int _tentativas = 1;
    private bool _sair = false;
    

    public void IniciarMenu()
    {
        while (!_sair)
        {
            string opcao = ApresentarOpcoes();

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
                    ValidaTentativas(opcao);
                    break;
            }
        }
    }

    private void Apresentacao()
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Bem-vindo ao GamaParking!");
        Console.ResetColor();
    }

    private string ApresentarOpcoes()
    {
        Apresentacao();

        Console.WriteLine("\nSelecione uma opção:");
        Console.WriteLine("\t1 - Cadastrar Cliente");
        Console.WriteLine("\t2 - Cadastrar Veículo");
        Console.WriteLine("\t3 - Listar Clientes e Veículos");
        Console.WriteLine("\t4 - Cadastrar Movimentação");
        Console.WriteLine("\t0 - Encerrar");

        Console.Write("Opção: ");
        string opcaoConsole = Console.ReadLine();

        return opcaoConsole;
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

    private void ValidaTentativas(string opcao)
    {
        if (_tentativas == _maxtentativas)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\nNúmero de tentativas excedido. Encerrando ...");
            _sair = true;
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"Opção '{opcao.Trim()}' inválida! Selecione uma opção válida.");
            _tentativas++;
        }

        Console.ResetColor();
        Thread.Sleep(2500);
        Console.Clear();
    }
}