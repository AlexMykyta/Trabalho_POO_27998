using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objects
{
    public class Consultation
    {
        public List<Accomodation> ListAvailableAccommodations(List<Accomodation> accommodations)
        {
            return accommodations.Where(a => true /* lógica para verificar disponibilidade */).ToList();
        }

        public List<Reservation> ListReservationsByStatus(List<Reservation> reservations, string status)
        {
            return reservations.Where(r => r.Status == status).ToList();
        }
    }

}
