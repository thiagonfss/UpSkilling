using Estacionamento.Models;
using System;

namespace Estacionamento.StaticHelpers;

public static class ClienteModelStaticList
{
    public static List<ClienteModel> Get()
    {
        return new List<ClienteModel>()
        {
            new ClienteModel()
            {
                NomeCompleto = "Rafael Deroncio",
                Cpf = StaticRandom.GetRandomCpf(),
                NumeroCelular = "11 9 9999-5555"
            },
            new ClienteModel()
            {
                NomeCompleto = "Cairo Costa",
                Cpf = StaticRandom.GetRandomCpf(),
                NumeroCelular = StaticRandom.GetRandomNumeroCelular(),
                DataCadastro = StaticRandom.GetRandomDataCadastro()
            },
            new ClienteModel()
            {
                NomeCompleto = "Thales Eugenio",
                Cpf = StaticRandom.GetRandomCpf(),
                NumeroCelular = StaticRandom.GetRandomNumeroCelular(),
                DataCadastro = StaticRandom.GetRandomDataCadastro()
            },
            new ClienteModel()
            {
                NomeCompleto = "Gabriel Correia",
                Cpf = StaticRandom.GetRandomCpf(),
                NumeroCelular = StaticRandom.GetRandomNumeroCelular(),
                DataCadastro = StaticRandom.GetRandomDataCadastro()
            },
            new ClienteModel()
            {
                NomeCompleto = "Matheus Chaves",
                Cpf = StaticRandom.GetRandomCpf(),
                NumeroCelular = StaticRandom.GetRandomNumeroCelular(),
                DataCadastro = StaticRandom.GetRandomDataCadastro()
            },
            new ClienteModel()
            {
                NomeCompleto = "Thiago Felipe",
                Cpf = StaticRandom.GetRandomCpf(),
                NumeroCelular = StaticRandom.GetRandomNumeroCelular(),
                DataCadastro = StaticRandom.GetRandomDataCadastro()
            },
            new ClienteModel()
            {
                NomeCompleto = "Eduardo Gonçalves",
                Cpf = StaticRandom.GetRandomCpf(),
                NumeroCelular = StaticRandom.GetRandomNumeroCelular(),
                DataCadastro = StaticRandom.GetRandomDataCadastro()
            },
        };

    }
}