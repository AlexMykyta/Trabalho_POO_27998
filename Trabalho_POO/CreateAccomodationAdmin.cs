using Objects;
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
    public partial class CreateAccomodationAdmin : Form
    {
        public CreateAccomodationAdmin()
        {
            InitializeComponent();
        }

        private void BtnBack_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCreateAcco_Click(object sender, EventArgs e)
        {
            try
            {
                // Gerar um ID único
                int id = GenerateUniqueID();

                // Capturar os valores do formulário
                string name = txtBoxName.Text;
                string bedType = cbTypeBed.SelectedItem.ToString();
                int capacity = int.Parse(cbCapacity.SelectedItem.ToString());
                bool seaView = checkboxSea.Checked;
                bool breakfastIncluded = checkBoxBreakFast.Checked;
                bool dinnerIncluded = checkBoxDinner.Checked;
                decimal price = decimal.Parse(txtPrice.Text);

                // O alojamento será criado como ativo por padrão
                bool isActive = true;

                // Criar um novo alojamento
                Accomodation newAccomodation = new Accomodation(id, name, bedType, capacity, seaView, breakfastIncluded, dinnerIncluded, price, isActive);

                // Guardar os dados no ficheiro
                SaveToFile(newAccomodation);

                // Mensagem de sucesso
                MessageBox.Show("Alojamento criado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Limpar os campos do formulário
                ClearForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao criar alojamento: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private int GenerateUniqueID()
        {
            string filePath = @"C:\TrabalhoPOO\Trabalho_POO\Bd\Accomodation.txt";
            int maxID = 0;

            if (File.Exists(filePath))
            {
                var lines = File.ReadAllLines(filePath);
                foreach (var line in lines)
                {
                    var parts = line.Split(';');
                    if (int.TryParse(parts[0], out int id))
                    {
                        if (id > maxID)
                        {
                            maxID = id;
                        }
                    }
                }
            }

            return maxID + 1; 
        }

        private void SaveToFile(Accomodation accomodation)
        {
            string filePath = @"C:\TrabalhoPOO\Trabalho_POO\Bd\Accomodation.txt";

            
            using (StreamWriter sw = new StreamWriter(filePath, true))
            {
                sw.WriteLine(accomodation.ToString());
            }
        }

        private void ClearForm()
        {
            txtBoxName.Text = "";
            cbTypeBed.SelectedIndex = -1;
            cbCapacity.SelectedIndex = -1;
            checkboxSea.Checked = false;
            checkBoxBreakFast.Checked = false;
            checkBoxDinner.Checked = false;
            txtPrice.Text = "";

            this.Close();
        }

    }
}
