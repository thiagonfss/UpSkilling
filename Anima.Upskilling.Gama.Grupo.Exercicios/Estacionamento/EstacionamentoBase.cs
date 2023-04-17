using ConsoleTables;
using Estacionamento.Extensions;
using Estacionamento.Models;
using Estacionamento.StaticHelpers;

namespace Estacionamento;

public class EstacionamentoBase
{
    const int _maxtentativas = 4;
    private int _tentativas = 1;
    private bool _sair = false;

    private double _valorPorMinuto = 0;

    private List<ClienteModel> Clientes;
    private List<VeiculoModel> Veiculos;
    private List<TicketModel> Tickets;
    private MovimentacaModel Status;

    public EstacionamentoBase(double valorPorMinuto, int totalVagas)
    {
        _valorPorMinuto = valorPorMinuto;

        // Dados Dinamicos - prod.
        Clientes = new List<ClienteModel>();
        Veiculos = new List<VeiculoModel>();
        Tickets = new List<TicketModel>();

        // Dados Staticos - desenv.
        //Clientes = ClienteModelStaticList.Get();
        //Veiculos = VeiculoModelStaticList.Get(Clientes, totalVagas);
        //Tickets = TicketModelStaticList.Get(Clientes, Veiculos, _valorPorMinuto);

        // Status
        Status = new MovimentacaModel(Tickets, valorPorMinuto, totalVagas);
    }

    public EstacionamentoBase()
    {
    }

    public void IniciarMenu()
    {
        while (!_sair)
        {
            string opcao = Opcoes();

            switch (opcao)
            {
                case "1":
                    CadastrarCliente();
                    break;

                case "2":
                    ListarClientes();
                    break;

                case "3":
                    CadastrarVeiculo();
                    break;

                case "4":
                    ListarVeiculos();
                    break;

                case "5":
                    CadastrarTicket();
                    break;

                case "6":
                    ListarTickets();
                    break;

                case "7":
                    FecharTicket();
                    break;

                case "0":
                    Encerrar();
                    break;

                default:
                    ValidaTentativas(opcao);
                    break;
            }
        }

        return;
    }

    private void Apresentacao()
    {
        Console.Clear();
        Console.WriteLine("+----------------+-----------------------+---------------------------+-------------------+");
        Console.Write("|");
        Console.ForegroundColor = ConsoleColor.Green;
        Console.Write("                                   Bem-vindo ao GamaParking                             ");
        Console.ResetColor();
        Console.WriteLine("|");

        GerarTabelaConsole(new List<MovimentacaModel>() { Status });
    }

    private string Opcoes()
    {
        Apresentacao();

        Console.WriteLine("Selecione uma opção:");
        Console.WriteLine("\t1 - Cadastrar Cliente");
        Console.WriteLine("\t2 - Listar Clientes");
        Console.WriteLine("\t3 - Cadastrar Veículo");
        Console.WriteLine("\t4 - Listar Veículos");
        Console.WriteLine("\t5 - Cadastrar Ticket");
        Console.WriteLine("\t6 - Listar Tickets");
        Console.WriteLine("\t7 - Fechar Ticket");
        Console.WriteLine("\t0 - Encerrar");

        Console.Write("Opção: ");
        string opcaoConsole = Console.ReadLine();

        return opcaoConsole;
    }

    private void CadastrarCliente()
    {
        bool sairCadastroCliente = false;
        const int maxTotalTentativasCadastroCliente = 3;
        int totalTentativasCadastroCliente = 0;

        while (!sairCadastroCliente)
        {
            if (sairCadastroCliente)
                break;

            Apresentacao();
            Console.WriteLine("Opção selecionada: Cadastrar Cliente");

            ClienteModel cliente = new();

            Console.Write("\tNome: ");
            string nome = Console.ReadLine();
            cliente.NomeCompleto = nome.ToTittleCase();

            Console.Write("\tCPF: ");
            cliente.Cpf = Console.ReadLine();
            cliente.Cpf = cliente.Cpf.ToCpfNormalized();

            Console.Write("\tTelefone: ");
            cliente.NumeroCelular = Console.ReadLine();
            cliente.NumeroCelular = cliente.NumeroCelular.ToNumberPhoneNormalized();

            Clientes.Add(cliente);

            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine($"\t*Cliente '{cliente.NomeCompleto}' cadastrado com sucesso!\n");
            Console.ResetColor();

            Console.Write("Deseja cadastrar outro cliente? [S / N]: ");
            string novoCadastro = Console.ReadLine();

            switch (novoCadastro.ToUpper())
            {
                case "S":
                    break;

                case "N":
                    sairCadastroCliente = true;
                    break;

                default:
                    totalTentativasCadastroCliente++;
                    sairCadastroCliente = OpcaoInvalida(totalTentativasCadastroCliente, maxTotalTentativasCadastroCliente);
                    break;
            }
        }

        IniciarMenu();
    }

    private void ListarClientes()
    {
        Apresentacao();
        Console.WriteLine("Opção selecionada: Listar Clientes");
        GerarTabelaConsole(Clientes);
        RetornarMenu();
    }

    private void CadastrarVeiculo()
    {
        bool sairCadastroVeiculo = false;
        const int maxTotalTentativasCadastroVeiculo = 3;
        int totalTentativasCadastroVeiculo = 0;

        while (!sairCadastroVeiculo)
        {
            Apresentacao();
            Console.WriteLine("Opção selecionada: Cadastrar Veículo");

            VeiculoModel veiculo= new();

            ClienteModel cliente = ValidarIdClienteConsole();
            veiculo.IdCliente = cliente.Id;
            veiculo.NomeCliente = cliente.NomeCompleto;
            
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"\tID: {veiculo.IdCliente:D4} - Cliente: {veiculo.NomeCliente}\n");
            Thread.Sleep(1500);
            Console.ResetColor();

            Console.Write("\tMarca/Fabricante: ");
            string fabricante = Console.ReadLine();
            veiculo.Fabricante = fabricante.ToTittleCase();

            Console.Write("\tModelo: ");
            string modelo = Console.ReadLine();
            veiculo.Modelo = modelo.ToTittleCase();

            Console.Write("\tCor: ");
            string cor = Console.ReadLine();
            veiculo.Cor = cor.ToTittleCase();

            Console.Write("\tPlaca: ");
            string placa = Console.ReadLine();
            veiculo.Placa = placa.ToUpper();

            Veiculos.Add(veiculo);

            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine($"\t*Veículo {veiculo.Fabricante} {veiculo.Modelo}, Placa '{veiculo.Placa}' foi cadastrado com sucesso!\n");
            Console.ResetColor();

            Console.Write("Deseja cadastrar outro veiculo? [S / N]: ");
            string novoCadastro = Console.ReadLine();

            switch (novoCadastro.ToUpper())
            {
                case "S":
                    CadastrarVeiculo();
                    break;

                case "N":
                    sairCadastroVeiculo = true;
                    break;

                default:
                    totalTentativasCadastroVeiculo++;
                    sairCadastroVeiculo = OpcaoInvalida(totalTentativasCadastroVeiculo, maxTotalTentativasCadastroVeiculo);
                    break;
            }
        }

        IniciarMenu();
    }

    private void ListarVeiculos()
    {
        Apresentacao();
        Console.WriteLine("Opção selecionada: Listar Veículos");
        GerarTabelaConsole(Veiculos);
        RetornarMenu();
    }

    private void CadastrarTicket()
    {
        if (!Status.TemVagaDisponivel)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"\nNo momento não há vagas disponíveis.");
            Thread.Sleep(1500);
            Console.ResetColor();

            return;
        }

        bool sairCadastroTicket = false;
        const int maxTotalTentativasCadastroTicket = 3;
        int totalTentativasCadastroTicket = 0;
        const int maxTotalTentativasConfirmarCadastroTicket = 3;
        int totalTentativasConfirmarCadastroTicket = 0;

        while (!sairCadastroTicket)
        {
            Apresentacao();
            Console.WriteLine("Opção selecionada: Cadastrar Tiket");

            TicketModel ticket = new();

            ClienteModel cliente = ValidarIdClienteConsole();
            ticket.IdCliente = cliente.Id;
            ticket.NomeCliente = cliente.NomeCompleto;

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"\tID: {cliente.Id:D4} - Cliente: {cliente.NomeCompleto}\n");
            Thread.Sleep(1500);
            Console.ResetColor();

            VeiculoModel veiculo = ValidarIdVeiculoConsole(cliente.Id);
            if (veiculo == null)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine($"\t*Cliente {ticket.Id:D4} {cliente.NomeCompleto} Não possui veículo cadastrado!\n");
                Console.ResetColor();
                Thread.Sleep(1500);
                break;
            }

            ticket.IdVeiculo = cliente.Id;
            ticket.DescricaoVeiculo = $"Modelo: {veiculo.Fabricante} {veiculo.Modelo}, Cor: {veiculo.Cor}, Placa: {veiculo.Placa}";

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"\tTicket: {ticket.Id:D4} -> Valor por minuto: {_valorPorMinuto}");
            Console.WriteLine($"\tData Início: {ticket.Entrada}");
            Console.WriteLine($"\tCliente:{cliente.Id:D4} {cliente.NomeCompleto}");
            Console.WriteLine($"\tDescrição: {ticket.DescricaoVeiculo}\n");
            Thread.Sleep(1500);
            Console.ResetColor();

            Console.Write("\nDeseja Salvar? [S / N]: ");
            string confirmaCadastro = Console.ReadLine();

            switch (confirmaCadastro.ToUpper())
            {
                case "S":
                    ticket.IniciarTcket(_valorPorMinuto);
                    Tickets.Add(ticket);
                    break;

                case "N":
                    sairCadastroTicket = true;
                    break;

                default:
                    totalTentativasConfirmarCadastroTicket++;
                    sairCadastroTicket = OpcaoInvalida(totalTentativasConfirmarCadastroTicket, maxTotalTentativasConfirmarCadastroTicket);
                    break;
            }

            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine($"\t*Ticket {ticket.Id:D4} foi cadastrado com sucesso!\n");
            Console.ResetColor();

            Console.Write("Deseja cadastrar outro ticket? [S / N]: ");
            string novoCadastro = Console.ReadLine();

            switch (novoCadastro.ToUpper())
            {
                case "S":
                    CadastrarTicket();
                    break;

                case "N":
                    sairCadastroTicket = true;
                    break;

                default:
                    totalTentativasCadastroTicket++;
                    sairCadastroTicket = OpcaoInvalida(totalTentativasCadastroTicket, maxTotalTentativasCadastroTicket);
                    break;
            }
        }

        IniciarMenu();
    }

    private void ListarTickets()
    {
        Apresentacao();
        Console.WriteLine("Opção selecionada: Listar Tickets");
        GerarTabelaConsole(Tickets);
        RetornarMenu();
    }

    private void FecharTicket()
    {
        bool sairFecharTicket = false;
        const int maxTotalTentativasConfirmarFecharTicket = 3;
        int totalTentativasConfirmarFecharTicket = 0;


        while (!sairFecharTicket)
        {
            Apresentacao();
            Console.WriteLine("Opção selecionada: Fechar Tiket");

            TicketModel ticket = ValidarIdTicketConsole();
            VeiculoModel veiculo = Veiculos.Single(x => x.Id == ticket.IdVeiculo);
            ClienteModel cliente = Clientes.Single(x => x.Id == ticket.IdCliente);

            Console.ForegroundColor = ConsoleColor.Green;
            var status = ticket.Ativo ? "ABERTO" : "FECHADO";
            Console.WriteLine($"\tTicket: {ticket.Id:D4} {status} -> Valor por minuto: R$ {_valorPorMinuto:F2}");
            Console.WriteLine($"\tCliente:{cliente.Id:D4} {cliente.NomeCompleto}");
            Console.WriteLine($"\tDescrição: {ticket.DescricaoVeiculo}\n");
            Console.WriteLine($"\tData Início: {ticket.Entrada}");
            Console.WriteLine($"\tData Saída: {DateTime.Now}");
            Console.WriteLine($"\tTempo Estacionado: {ticket.TempoEstacionado}");
            Console.WriteLine($"\tValor Final: {ticket.ValorTicket:F2}");
            Thread.Sleep(1500);
            Console.ResetColor();

            if (!ticket.Ativo)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine($"\t*Ticket {ticket.Id:D4} foi fechado em {ticket.Saida}\n");
                Console.ResetColor();
                Thread.Sleep(1500);
                IniciarMenu();
                sairFecharTicket = true;
            }

            Console.Write("\nDeseja Fechar? [S / N]: ");
            string confirmaFechar = Console.ReadLine();

            switch (confirmaFechar.ToUpper())
            {
                case "S":
                    Tickets.ForEach(t => 
                    {
                        if (t.Id == ticket.Id)
                        {
                            ticket.FecharTcket();
                        }
                    });
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.WriteLine($"\t*Fechar Ticket {ticket.Id:D4} Operação concluida sucesso!\n");
                    Console.ResetColor();
                    Thread.Sleep(1500);
                    break;

                case "N":
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.WriteLine($"\t*Fechar Ticket {ticket.Id:D4}: Operação cancelada!\n");
                    Console.ResetColor();
                    Thread.Sleep(1500);
                    sairFecharTicket = true;
                    break;

                default:
                    totalTentativasConfirmarFecharTicket++;
                    sairFecharTicket = OpcaoInvalida(totalTentativasConfirmarFecharTicket, maxTotalTentativasConfirmarFecharTicket);
                    break;
            }
        }

        IniciarMenu();
    }

    private ClienteModel ValidarIdClienteConsole()
    {
        int id = ValidarIdConsole("Cliente");

        ClienteModel cliente = Clientes.Find(cliente => cliente.Id == id);

        if (cliente is null || cliente.Id == 0)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write($"Cliente não localizado para 'ID' informado! Retornando ao menu principal ...");
            Thread.Sleep(2500);
            Console.ResetColor();
            IniciarMenu();
        }

        return cliente;
    }

    private VeiculoModel ValidarIdVeiculoConsole(int idCliente)
    {
        int id = 0;

        var veiculos = Veiculos.FindAll(veiculo => veiculo.IdCliente == idCliente);

        if (veiculos.Count > 0)
        {
            GerarTabelaConsole(veiculos);
            id = ValidarIdConsole("Veículo");

            VeiculoModel veiculo = Veiculos.Find(cliente => cliente.Id == id);

            if (veiculo is null || veiculo.Id == 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write($"Veículo não localizado para 'ID' informado! Retornando ao menu principal ...");
                Thread.Sleep(2500);
                Console.ResetColor();
            }

            return veiculo;
        }

        return null;
    }

    private TicketModel ValidarIdTicketConsole()
    {
        int id = ValidarIdConsole("Ticket");

        TicketModel ticket = Tickets.Find(ticket => ticket.Id == id);

        if (ticket is null || ticket.Id == 0)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write($"Ticket não localizado para 'ID' informado! Retornando ao menu principal ...");
            Thread.Sleep(2500);
            Console.ResetColor();
            IniciarMenu();
        }

        return ticket;
    }

    private int ValidarIdConsole(string model)
    {
        int id = 0;
        int tentativas = 0;
        bool sairValidaId = false;

        while (!sairValidaId)
        {
            Console.Write($"\tID {model.ToTittleCase()} (num. inteiro): ");
            int.TryParse(Console.ReadLine(), out id);

            if (id > 0)
            {
                sairValidaId = true;
            }
            else
            {
                tentativas++;

                if (tentativas == 3)
                    OpcaoInvalida(tentativas, 3);
            }
        }

        return id;
    }

    private void Encerrar()
    {   
        Console.WriteLine("Opção selecionada: Encerrar ...");
        Thread.Sleep(1500);
        _sair = true;
        Environment.Exit(0);
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

    private void GerarTabelaConsole<T>(List<T> items)
    {
        ConsoleTable.From<T>(items).Write(Format.Alternative);
    }

    private void RetornarMenu(int sleep = 2500, ConsoleColor consoleColor = ConsoleColor.Yellow)
    {
        Thread.Sleep(sleep);
        Console.ForegroundColor = consoleColor;
        Console.Write($"Pressione qualquer tecla para retornar ao menu...");
        Console.ResetColor();

        Console.ReadKey();
        IniciarMenu();
    }

    private bool OpcaoInvalida(int tentativas, int maxTentativa)
    {
        if (tentativas == maxTentativa)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"{tentativas}ª Tentativa: Opção inválida.");
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write($"Número de tentativas excedido! Retornando ao menu principal ...");
            return true;
        }

        Console.ResetColor();
        Thread.Sleep(2500);
        IniciarMenu();
        return false;
    }
}