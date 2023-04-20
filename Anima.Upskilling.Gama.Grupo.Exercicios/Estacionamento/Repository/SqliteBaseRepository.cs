using Dapper;
using Estacionamento.Extensions;
using Estacionamento.Models;
using Estacionamento.Repository.Interfaces;
using System.Data;
using System.Data.SQLite;

namespace Estacionamento.Repository;

public class SqLiteBaseRepository
{
    private static SQLiteConnection _sqliteConnection;
    private static string _connectionString = "Data Source=C:\\Users\\rafael.deroncio\\Desktop\\Rafael\\Gama\\GitHubGrupo\\UpSkilling\\Anima.Upskilling.Gama.Grupo.Exercicios\\Estacionamento\\EstacionamentoDatabase.db";

    public SqLiteBaseRepository()
    {

    }

    public static IDbConnection GetConnection() // CONNECTION
    {
        _sqliteConnection = new SQLiteConnection(_connectionString);
        _sqliteConnection.Open();
        return _sqliteConnection;
    }
}