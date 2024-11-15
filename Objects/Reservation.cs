using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objects
{
    public class Reservation
    {
        public User Client { get; set; }
        public Accommodation Accommodation { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string Status { get; set; } // "Pendente", "Aprovada", "Recusada"

        public Reservation(User client, Accommodation accommodation, DateTime startDate, DateTime endDate)
        {
            Client = client;
            Accommodation = accommodation;
            StartDate = startDate;
            EndDate = endDate;
            Status = "Pendente";
        }

        public override string ToString()
        {
            return $"Cliente: {Client.Name}, Alojamento: {Accommodation.Name}, Período: {StartDate:dd/MM/yyyy} - {EndDate:dd/MM/yyyy}, Estado: {Status}";
        }
    }

}
