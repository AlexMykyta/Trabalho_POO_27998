using Objects;

namespace Trabalho_POO
{
    public partial class ClientReservation : Form
    {
        public ClientReservation()
        {
            InitializeComponent();
            LoadAccommodations();
        }

        private void Reservations_Load(object sender, EventArgs e)
        {

        }

        private void airButton1_Click(object sender, EventArgs e)
        {

        }

        private void LoadAccommodations()
        {
            try
            {
                flpAccommodations.Controls.Clear();

                string filePath = @"C:\TrabalhoPOO\Trabalho_POO\Bd\Accomodation.txt";

                var accommodations = File.ReadAllLines(filePath)
                                         .Select(line => ParseAccommodation(line))
                                         .Where(a => a.IsActive)
                                         .ToList();

                foreach (var accommodation in accommodations)
                {
                    var card = new Panel
                    {
                        Width = 220, // Reduzir a largura
                        Height = 180, // Reduzir a altura
                        BackColor = Color.White,
                        Margin = new Padding(10),
                        BorderStyle = BorderStyle.FixedSingle
                    };

                    // Nome do Alojamento (Título no topo, com posição fixa)
                    var titleLabel = new Label
                    {
                        Text = accommodation.Name.ToUpper(),
                        Font = new Font("Segoe UI", 10, FontStyle.Bold),
                        ForeColor = Color.Black,
                        Location = new Point(10, 5), // Posição fixa no topo
                        AutoSize = true
                    };
                    card.Controls.Add(titleLabel);

                    // Tipo de Cama
                    card.Controls.Add(new Label
                    {
                        Text = $"Cama: {accommodation.BedType}",
                        Font = new Font("Segoe UI", 8),
                        ForeColor = Color.Black,
                        Location = new Point(10, 30),
                        AutoSize = true
                    });

                    // Capacidade
                    card.Controls.Add(new Label
                    {
                        Text = $"Capacidade: {accommodation.Capacity} pessoas",
                        Font = new Font("Segoe UI", 8),
                        ForeColor = Color.Black,
                        Location = new Point(10, 45),
                        AutoSize = true
                    });

                    // Vista para o Mar
                    card.Controls.Add(new Label
                    {
                        Text = $"Vista para o Mar: {(accommodation.SeaView ? "Sim" : "Não")}",
                        Font = new Font("Segoe UI", 8),
                        ForeColor = Color.Black,
                        Location = new Point(10, 60),
                        AutoSize = true
                    });

                    // Pequeno Almoço
                    card.Controls.Add(new Label
                    {
                        Text = $"Pequeno Almoço: {(accommodation.BreakfastIncluded ? "Incluído" : "Não")}",
                        Font = new Font("Segoe UI", 8),
                        ForeColor = Color.Black,
                        Location = new Point(10, 75),
                        AutoSize = true
                    });

                    // Jantar
                    card.Controls.Add(new Label
                    {
                        Text = $"Jantar: {(accommodation.DinnerIncluded ? "Incluído" : "Não")}",
                        Font = new Font("Segoe UI", 8),
                        ForeColor = Color.Black,
                        Location = new Point(10, 90),
                        AutoSize = true
                    });

                    // Preço
                    card.Controls.Add(new Label
                    {
                        Text = $"Preço: {accommodation.Price:C}",
                        Font = new Font("Segoe UI", 9, FontStyle.Bold),
                        ForeColor = Color.DarkGreen,
                        Location = new Point(10, 110),
                        AutoSize = true
                    });

                    // Botão Reservar
                    var actionButton = new Button
                    {
                        Text = "Reservar",
                        BackColor = Color.LightGray, // Botão cinzento
                        ForeColor = Color.Black,
                        Location = new Point(10, 135), // Posição no fundo
                        Width = 200, // Largura fixa
                        Height = 30,
                        Font = new Font("Segoe UI", 9, FontStyle.Bold)
                    };

                    actionButton.Click += (sender, e) => ReserveAccommodation(accommodation);
                    card.Controls.Add(actionButton);

                    flpAccommodations.Controls.Add(card);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        // Método auxiliar para converter uma linha do ficheiro num objeto Accommodation
        private Accomodation ParseAccommodation(string line)
        {
            var parts = line.Split(';'); // Divide a linha pelo delimitador ";"

            if (parts.Length != 9) // Garante que tem exatamente 9 campos
                throw new FormatException("Linha inválida no ficheiro!");

            return new Accomodation(
                int.Parse(parts[0]),          // ID
                parts[1],                     // Name
                parts[2],                     // BedType
                int.Parse(parts[3]),          // Capacity
                bool.Parse(parts[4]),         // SeaView
                bool.Parse(parts[5]),         // BreakfastIncluded
                bool.Parse(parts[6]),         // DinnerIncluded
                decimal.Parse(parts[7]),      // Price
                bool.Parse(parts[8])          // IsActive
            );
        }

        // Método para "reservar" um alojamento (exemplo)
        private void ReserveAccommodation(Accomodation accommodation)
        {
            MessageBox.Show($"Reserva efetuada para: {accommodation.Name}", "Reserva", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void flpAccommodations_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
