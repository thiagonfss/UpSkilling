using Estacionamento.Extensions;

namespace Estacionamento.StaticHelpers;

public static class StaticRandom
{
    private static Random _random = new Random();

    public static bool RandomBoolean() => _random.Next(0, 2) == 1;

    public static int GetRandomIdCliente(int minId, int maxId)
    {
        return _random.Next(minId, maxId + 1);
    }

    public static int GetRandomIdVeiculo(int minId, int maxId)
    {
        return _random.Next(minId, maxId + 1);
    }

    public static int GetRandomIdVeiculo(int maxId)
    {
        int random = 0;

        while (random == 0)
        {
            random = _random.Next(maxId + 1);
        }

        return random;
    }

    public static int GetRandomIdVeiculoCliente(int minId, int maxId)
    {
        int random = 0;
        bool pararSorteio = false;

        while (!pararSorteio)
        {
            random = _random.Next(minId, maxId + 1);

            if (random == minId || random == maxId)
            {
                pararSorteio = true;
            }
        }

        return random;
    }

    public static DateTime GetRandomDataCadastro()
    {
        var dataAtual = DateTime.Now;
        var novaData = DateTime.Now;

        var diaAtual = dataAtual.Day;
        var mesAtual = dataAtual.Month;
        var anoAtual = dataAtual.Year;
        var horaAtual = dataAtual.Hour;
        var minAtual = dataAtual.Minute;

        while (novaData >= dataAtual)
        {
            novaData = new DateTime(
                _random.Next(anoAtual, anoAtual+1), 
                _random.Next(mesAtual, mesAtual+1), 
                _random.Next(diaAtual-5, diaAtual+1), 
                _random.Next(1, horaAtual+1), 
                _random.Next(1, minAtual+1), 
                0);
        }

        return novaData;
    }

    public static string GetRandomCpf()
    {
        string cpf = string.Concat(Enumerable.Range(1, 9).Select(x => new Random().Next(10).ToString()));

        cpf += Enumerable.Range(0, 2).Select(i =>
        {
            int soma = cpf.Take(9 + i).Select((c, j) => int.Parse(c.ToString()) * (10 + i - j)).Sum();
            return (soma % 11 < 2) ? "0" : (11 - soma % 11).ToString();
        }).Aggregate((acc, x) => acc + x);

        return cpf.ToCpfNormalized();
    }

    public static string GetRandomNumeroCelular()
    {
        string telefone = $"{new Random().Next(11, 99):D2} 9 {new Random().Next(1000, 9999):D4}-{new Random().Next(1000, 9999):D4}";

        return telefone.ToNumberPhoneNormalized();
    }
}