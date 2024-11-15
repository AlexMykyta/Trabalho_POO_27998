using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objects
{
    public class Accommodation
    {
        public string Name { get; set; }
        public string Type { get; set; } // Ex: "Quarto", "Apartamento", etc.
        public int Capacity { get; set; }
        public decimal PricePerNight { get; set; }
        public bool BreakfastIncluded { get; set; }
        public bool HasSeaView { get; set; }

        public Accommodation(string name, string type, int capacity, decimal pricePerNight, bool breakfastIncluded, bool hasSeaView)
        {
            Name = name;
            Type = type;
            Capacity = capacity;
            PricePerNight = pricePerNight;
            BreakfastIncluded = breakfastIncluded;
            HasSeaView = hasSeaView;
        }

        public override string ToString()
        {
            return $"{Name} ({Type}) - Capacidade: {Capacity}, Preço por noite: {PricePerNight:C}";
        }
    }

}
