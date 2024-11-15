using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objects
{
    public class CheckIn
    {
        public Reservation Reservation { get; set; }
        public DateTime CheckInDate { get; set; }
        public string Status { get; set; } // "Realizado", "Pendente", "Cancelado"

        public CheckIn(Reservation reservation, DateTime checkInDate)
        {
            Reservation = reservation;
            CheckInDate = checkInDate;
            Status = "Pendente";
        }

        public override string ToString()
        {
            return $"Reserva: {Reservation}, Data de Check-In: {CheckInDate:dd/MM/yyyy}, Estado: {Status}";
        }
    }

}
