namespace Objects
{
    public class Accomodation
    {
        // Propriedades
        public int ID { get; set; }
        public string Name { get; set; }           // TextBox
        public string BedType { get; set; }       // ComboBox
        public int Capacity { get; set; }         // ComboBox
        public bool SeaView { get; set; }         // CheckBox
        public bool BreakfastIncluded { get; set; } // CheckBox
        public bool DinnerIncluded { get; set; }  // CheckBox
        public decimal Price { get; set; }        // TextBox (convertido para decimal)

        // Construtor
        public Accomodation(int id,string name, string bedType, int capacity, bool seaView, bool breakfastIncluded, bool dinnerIncluded, decimal price)
        {
            ID = id;
            Name = name;
            BedType = bedType;
            Capacity = capacity;
            SeaView = seaView;
            BreakfastIncluded = breakfastIncluded;
            DinnerIncluded = dinnerIncluded;
            Price = price;
        }

        public override string ToString()
        {
            return $"{ID};{Name};{BedType};{Capacity};{SeaView};{BreakfastIncluded};{DinnerIncluded};{Price}";
        }
    }
}
