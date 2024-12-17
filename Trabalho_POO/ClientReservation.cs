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
                        Width = 220, // Largura
                        Height = 300, // Altura ajustada
                        BackColor = Color.White,
                        Margin = new Padding(10),
                        BorderStyle = BorderStyle.FixedSingle
                    };

                    // Nome do Alojamento (Título)
                    var titleLabel = new Label
                    {
                        Text = accommodation.Name.ToUpper(),
                        Font = new Font("Segoe UI", 10, FontStyle.Bold),
                        ForeColor = Color.Black,
                        Location = new Point(10, 5),
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

                    // Label para "Data Início"
                    card.Controls.Add(new Label
                    {
                        Text = "Data Início:",
                        Font = new Font("Segoe UI", 8),
                        ForeColor = Color.Black,
                        Location = new Point(10, 135),
                        AutoSize = true
                    });

                    // DateTimePicker: Data Início
                    var dtpStartDate = new DateTimePicker
                    {
                        Location = new Point(10, 150),
                        Width = 200,
                        Value = DateTime.Now,
                        Format = DateTimePickerFormat.Short
                    };
                    card.Controls.Add(dtpStartDate);

                    // Label para "Data Fim"
                    card.Controls.Add(new Label
                    {
                        Text = "Data Fim:",
                        Font = new Font("Segoe UI", 8),
                        ForeColor = Color.Black,
                        Location = new Point(10, 185),
                        AutoSize = true
                    });

                    // DateTimePicker: Data Fim
                    var dtpEndDate = new DateTimePicker
                    {
                        Location = new Point(10, 200),
                        Width = 200,
                        Value = DateTime.Now,
                        Format = DateTimePickerFormat.Short
                    };
                    card.Controls.Add(dtpEndDate);

                    // Botão Reservar
                    var actionButton = new Button
                    {
                        Text = "Reservar",
                        BackColor = Color.LightGray,
                        ForeColor = Color.Black,
                        Location = new Point(10, 240), // Posição final ajustada
                        Width = 200,
                        Height = 30,
                        Font = new Font("Segoe UI", 9, FontStyle.Bold)
                    };

                    // Evento do botão Reservar
                    actionButton.Click += (sender, e) =>
                    {
                        ReserveAccommodation(accommodation, dtpStartDate.Value, dtpEndDate.Value);
                    };

                    card.Controls.Add(actionButton);

                    // Adicionar o card ao FlowLayoutPanel
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
        private void ReserveAccommodation(Accomodation accommodation, DateTime startDate, DateTime endDate)
        {
            try
            {
                // Verificar se o ID do cliente está na sessão
                if (SessionClient.UserId == Guid.Empty)
                {
                    MessageBox.Show("Nenhum cliente autenticado! Faça login novamente.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Criar os dados da reserva
                var reservation = new ReservationClient(
                    Guid.NewGuid(),                  // ID da reserva (único)
                    SessionClient.UserId,            // ID do cliente (da sessão)
                    accommodation.ID,                // ID do alojamento
                    accommodation.Name,              // Nome do alojamento
                    startDate,                       // Data de início
                    endDate,                         // Data de fim
                    accommodation.Price              // Preço
                );

                // Guardar a reserva no ficheiro
                SaveReservationToFile(reservation);

                // Mensagem de sucesso
                MessageBox.Show("Reserva efetuada com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao processar reserva: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SaveReservationToFile(ReservationClient reservation)
        {
            string filePath = @"C:\TrabalhoPOO\Trabalho_POO\Bd\ClientReservation.txt";

            // Converter os dados da reserva para uma linha
            string reservationLine = $"{reservation.ReservationID};" +
                                     $"{reservation.ClientID};" +
                                     $"{reservation.AccommodationID};" +
                                     $"{reservation.AccommodationName};" +
                                     $"{reservation.StartDate:yyyy-MM-dd};" +
                                     $"{reservation.EndDate:yyyy-MM-dd};" +
                                     $"{reservation.Price}";

            // Guardar no ficheiro
            File.AppendAllText(filePath, reservationLine + Environment.NewLine);
        }

        private void flpAccommodations_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
