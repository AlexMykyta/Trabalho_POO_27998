using System;

namespace Objects
{
    public class ReservationClient
    {
        public Guid ReservationID { get; set; }           // ID da reserva
        public Guid ClientID { get; set; }           // ID do cliente
        public int AccommodationID { get; set; }        // ID do alojamento
        public string AccommodationName { get; set; }   // Nome do alojamento
        public DateTime StartDate { get; set; }     // Data de início da reserva
        public DateTime EndDate { get; set; }        // Data de fim da reserva
        public decimal Price { get; set; }           // Preço total da reserva

        // Construtor
        public ReservationClient(Guid reservationID, Guid clientID, int accommodationID,
                                  string accommodationName, DateTime startDate,
                                  DateTime endDate, decimal price)
        {
            ReservationID = reservationID;
            ClientID = clientID;
            AccommodationID = accommodationID;
            AccommodationName = accommodationName;
            StartDate = startDate;
            EndDate = endDate;
            Price = price;
        }

        // Método para converter os dados em string (para gravar num ficheiro)
        public override string ToString()
        {
            return $"{ReservationID};{ClientID};{AccommodationID};{AccommodationName};{StartDate:yyyy-MM-dd};{EndDate:yyyy-MM-dd};{Price}";
        }
    }
}
