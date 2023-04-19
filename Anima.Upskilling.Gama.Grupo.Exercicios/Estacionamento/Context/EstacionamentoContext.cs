
using Estacionamento.Models;
using Microsoft.EntityFrameworkCore;

namespace Estacionamento.Context
{
    public class EstacionamentoContext : DbContext
    {
        public DbSet<ClienteModel> Clientes { get; set; }
        public DbSet<VeiculoModel> Veiculos { get; set; }
        public DbSet<TicketModel> Tickets { get; set; }

        public EstacionamentoContext()
        {
            AppContext.SetSwitch("Npgsql.EnableLegacyTimestampBehavior", true);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {   
            optionsBuilder.UseNpgsql("User ID=<nome_usuario>; Password = <senha>; Host = <host>; Port = <porta>; Database = <nome_banco>;");
        }
    }
}
