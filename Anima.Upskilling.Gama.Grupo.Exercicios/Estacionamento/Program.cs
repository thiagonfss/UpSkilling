using Estacionamento;

//var repository = new Estacionamento.Repository.ClienteRepository();
//List<Estacionamento.Models.ShowTablesModel> tables = repository.GetTables();
//Console.WriteLine(tables.Count);

EstacionamentoBase estacionamento = new EstacionamentoBase(0.25, 5);
estacionamento.IniciarMenu();
