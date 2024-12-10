using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trabalho_POO
{
    public partial class AdminPanelReservation : Form
    {
        public AdminPanelReservation()
        {
            InitializeComponent();
        }

        private void Clients_Load(object sender, EventArgs e)
        {
            LoadAccomodations();
            ConfigureComboBoxes();
        }

        private void btnCreateAcco_Click(object sender, EventArgs e)
        {
            CreateAccomodationAdmin createAccomodationForm = new CreateAccomodationAdmin();

            createAccomodationForm.ShowDialog();

        }

        public void LoadAccomodations()
        {
            string filePath = @"C:\TrabalhoPOO\Trabalho_POO\Bd\Accomodation.txt";

            if (!File.Exists(filePath))
            {
                MessageBox.Show("O ficheiro de alojamentos não foi encontrado!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Limpar o DataGridView antes de carregar
            dataGridView1.Rows.Clear();

            // Ler todas as linhas do ficheiro
            var lines = File.ReadAllLines(filePath);

            foreach (var line in lines)
            {
                if (string.IsNullOrWhiteSpace(line)) continue;

                var parts = line.Split(';');
                if (parts.Length != 9) continue;

                // Remover espaços extras dos valores
                string bedType = parts[2].Trim();
                string capacity = parts[3].Trim();

                // Verificar e ajustar valores inválidos
                if (!new[] { "Cama de Casal", "Cama de Solteiro", "2 camas individuais", "Cama King Size" }.Contains(bedType))
                {
                    bedType = "Cama de Casal"; // Valor padrão
                }

                if (!new[] { "1", "2", "3", "4", "5", "6", "7", "8", "9" }.Contains(capacity))
                {
                    capacity = "1"; // Valor padrão
                }

                // Adicionar ao DataGridView
                dataGridView1.Rows.Add(
                    parts[0], // ID
                    parts[1].Trim(), // Name
                    bedType,  // Type Bed (ajustado)
                    capacity, // Capacity (ajustado)
                    bool.Parse(parts[4]), // Sea View
                    bool.Parse(parts[5]), // Breakfast Included
                    bool.Parse(parts[6]), // Dinner Included
                    decimal.Parse(parts[7].Trim()), // Price
                    bool.Parse(parts[8].Trim()) // Status
                );
            }
        }



        private void ConfigureComboBoxes()
        {
            // Preencher opções para Tipo de Cama
            var bedTypeColumn = (DataGridViewComboBoxColumn)dataGridView1.Columns["ColumTypeBed"];
            bedTypeColumn.Items.AddRange("Cama de Casal", "Cama de Solteiro", "2 camas individuais", "Cama King Size");

            // Preencher opções para Capacidade
            var capacityColumn = (DataGridViewComboBoxColumn)dataGridView1.Columns["ColumCapacity"];
            capacityColumn.Items.AddRange("1", "2", "3", "4", "5", "6", "7", "8", "9");
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridView1.Columns["btnRemove"].Index && e.RowIndex >= 0)
            {
                // Confirmar remoção
                var confirmResult = MessageBox.Show(
                    "Tem a certeza de que deseja remover esta linha?",
                    "Confirmar Remoção",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (confirmResult == DialogResult.Yes)
                {
                    // Remover linha do DataGridView
                    dataGridView1.Rows.RemoveAt(e.RowIndex);

                    // Atualizar o ficheiro para refletir a remoção
                    SaveAccomodationsToFile();
                }
            }
        }

        private void SaveAccomodationsToFile()
        {
            string filePath = @"C:\TrabalhoPOO\Trabalho_POO\Bd\Accomodation.txt";

            using (StreamWriter writer = new StreamWriter(filePath, false)) // Sobrescrever o ficheiro
            {
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    if (!row.IsNewRow) // Ignorar a última linha vazia
                    {
                        string line = string.Join(";",
                                row.Cells["ColumID"].Value,
                                row.Cells["ColumName"].Value,
                                row.Cells["ColumTypeBed"].Value,
                                row.Cells["ColumCapacity"].Value,
                                row.Cells["ColumSeaView"].Value,
                                row.Cells["ColumBreakfast"].Value,
                                row.Cells["ColumDinner"].Value,
                                row.Cells["ColumPrice"].Value,
                                row.Cells["ColumActive"].Value
                        );
                        writer.WriteLine(line);
                    }
                }
            }
        }
    }
}
