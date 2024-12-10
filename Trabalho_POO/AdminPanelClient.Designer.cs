namespace Trabalho_POO
{
    partial class AdminPanelClient
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dataGridView1 = new DataGridView();
            ColumName = new DataGridViewTextBoxColumn();
            ColumEmail = new DataGridViewTextBoxColumn();
            ColumDataNascimento = new DataGridViewTextBoxColumn();
            ColumnPass = new DataGridViewTextBoxColumn();
            ColmunTypeUser = new DataGridViewTextBoxColumn();
            btnRemove = new DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { ColumName, ColumEmail, ColumDataNascimento, ColumnPass, ColmunTypeUser, btnRemove });
            dataGridView1.Location = new Point(197, 67);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(802, 419);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // ColumName
            // 
            ColumName.HeaderText = "Nome";
            ColumName.MinimumWidth = 6;
            ColumName.Name = "ColumName";
            ColumName.ReadOnly = true;
            ColumName.Width = 125;
            // 
            // ColumEmail
            // 
            ColumEmail.HeaderText = "E-mail";
            ColumEmail.MinimumWidth = 6;
            ColumEmail.Name = "ColumEmail";
            ColumEmail.ReadOnly = true;
            ColumEmail.Width = 125;
            // 
            // ColumDataNascimento
            // 
            ColumDataNascimento.HeaderText = "Data de Nascimento";
            ColumDataNascimento.MinimumWidth = 6;
            ColumDataNascimento.Name = "ColumDataNascimento";
            ColumDataNascimento.ReadOnly = true;
            ColumDataNascimento.Width = 125;
            // 
            // ColumnPass
            // 
            ColumnPass.HeaderText = "PassWord";
            ColumnPass.MinimumWidth = 6;
            ColumnPass.Name = "ColumnPass";
            ColumnPass.ReadOnly = true;
            ColumnPass.Width = 125;
            // 
            // ColmunTypeUser
            // 
            ColmunTypeUser.HeaderText = "Type User";
            ColmunTypeUser.MinimumWidth = 6;
            ColmunTypeUser.Name = "ColmunTypeUser";
            ColmunTypeUser.ReadOnly = true;
            ColmunTypeUser.Width = 125;
            // 
            // btnRemove
            // 
            btnRemove.HeaderText = "Remover";
            btnRemove.MinimumWidth = 6;
            btnRemove.Name = "btnRemove";
            btnRemove.ReadOnly = true;
            btnRemove.Width = 125;
            // 
            // AdminPanelClient
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoValidate = AutoValidate.Disable;
            ClientSize = new Size(1219, 600);
            Controls.Add(dataGridView1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "AdminPanelClient";
            Text = "AdminPanelClient";
            Load += AdminPanelClient_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn ColumName;
        private DataGridViewTextBoxColumn ColumEmail;
        private DataGridViewTextBoxColumn ColumDataNascimento;
        private DataGridViewTextBoxColumn ColumnPass;
        private DataGridViewTextBoxColumn ColmunTypeUser;
        private DataGridViewButtonColumn btnRemove;
    }
}