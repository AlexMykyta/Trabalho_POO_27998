using Objects; 
using Utilities;

namespace Trabalho_POO
{
    public partial class AdminPanelClient : Form
    {
        public AdminPanelClient()
        {
            InitializeComponent();
        }

        private void AdminPanelClient_Load(object sender, EventArgs e)
        {
            LoadUsersToGrid();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
            if (e.ColumnIndex == dataGridView1.Columns["btnRemove"].Index && e.RowIndex >= 0)
            {
                // Confirmar remoção
                var result = MessageBox.Show("Tem a certeza de que deseja remover este utilizador?", "Confirmar Remoção", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    // Remove a linha da grid
                    dataGridView1.Rows.RemoveAt(e.RowIndex);

                    // Atualiza o ficheiro
                    SaveUsersToFile();
                }
            }
        }

        private void SaveUsersToFile()
        {
            try
            {
                var lines = new List<string>();

                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    if (row.IsNewRow) continue;

                    var name = row.Cells["ColumName"].Value?.ToString() ?? string.Empty;
                    var email = row.Cells["ColumEmail"].Value?.ToString() ?? string.Empty;
                    var birthDate = row.Cells["ColumDataNascimento"].Value?.ToString() ?? string.Empty;
                    var password = row.Cells["ColumnPass"].Value?.ToString() ?? string.Empty;
                    var role = row.Cells["ColmunTypeUser"].Value?.ToString() ?? string.Empty;

                    // Adiciona ao ficheiro (formato original)
                    lines.Add($"{Guid.NewGuid()},{name},{email},{birthDate},{password},{role}");
                }

                // Atualiza o ficheiro
                File.WriteAllLines(@"C:\TrabalhoPOO\Trabalho_POO\Bd\Users.txt", lines);
                MessageBox.Show("Utilizadores salvos com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao salvar utilizadores: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadUsersToGrid()
        {
            try
            {
                // Carregar os utilizadores usando o método UserManager
                var users = UserManager.LoadUsers();

                // Preencher a grid com os dados (sem o ID)
                foreach (var user in users)
                {
                    dataGridView1.Rows.Add(
                        user.Name,                    // Nome
                        user.Email,                   // Email
                        user.DataNascimento.ToShortDateString(), // Data de Nascimento
                        user.Password,                // Password
                        user.Role                     // Tipo de Utilizador
                    );
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao carregar utilizadores: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }

}
