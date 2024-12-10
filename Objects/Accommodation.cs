namespace Objects
{
    public class Accomodation
    {
        public int ID { get; set; }               // Identificador único
        public string Name { get; set; }          // Nome do alojamento
        public string BedType { get; set; }       // Tipo de cama
        public int Capacity { get; set; }         // Capacidade
        public bool SeaView { get; set; }         // Vista para o mar
        public bool BreakfastIncluded { get; set; } // Pequeno-almoço incluído
        public bool DinnerIncluded { get; set; }  // Jantar incluído
        public decimal Price { get; set; }        // Preço
        public bool IsActive { get; set; }        // Estado do alojamento

        // Construtor atualizado
        public Accomodation(int id, string name, string bedType, int capacity, bool seaView, bool breakfastIncluded, bool dinnerIncluded, decimal price, bool isActive)
        {
            ID = id;
            Name = name;
            BedType = bedType;
            Capacity = capacity;
            SeaView = seaView;
            BreakfastIncluded = breakfastIncluded;
            DinnerIncluded = dinnerIncluded;
            Price = price;
            IsActive = isActive;
        }

        // Método para converter os dados num formato que será guardado no ficheiro .txt
        public override string ToString()
        {
            return $"{ID};{Name};{BedType};{Capacity};{SeaView};{BreakfastIncluded};{DinnerIncluded};{Price};{IsActive}";
        }
    }

}

