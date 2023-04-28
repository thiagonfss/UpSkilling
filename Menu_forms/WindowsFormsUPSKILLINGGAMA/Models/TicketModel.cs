using System;

namespace WindowsFormsUPSKILLINGGAMA.Models
{
    public class TicketModel
    {
        public int Id { get; set; }
        public int IdVeiculo { get; set; }
        public DateTime DataEntrada { get; set; } = DateTime.Now;
        public DateTime? DataSaida { get; set; } = null;
    }
}
