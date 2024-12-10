namespace Trabalho_POO
{
    partial class AdminPanelReservation
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
            btnCreateAcco = new Button();
            dataGridView1 = new DataGridView();
            ColumID = new DataGridViewTextBoxColumn();
            ColumName = new DataGridViewTextBoxColumn();
            ColumTypeBed = new DataGridViewComboBoxColumn();
            ColumCapacity = new DataGridViewComboBoxColumn();
            ColumSeaView = new DataGridViewCheckBoxColumn();
            ColumBreakfast = new DataGridViewCheckBoxColumn();
            ColumDinner = new DataGridViewCheckBoxColumn();
            ColumPrice = new DataGridViewTextBoxColumn();
            ColumActive = new DataGridViewCheckBoxColumn();
            btnRemove = new DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // btnCreateAcco
            // 
            btnCreateAcco.Location = new Point(1003, 28);
            btnCreateAcco.Margin = new Padding(3, 4, 3, 4);
            btnCreateAcco.Name = "btnCreateAcco";
            btnCreateAcco.Size = new Size(146, 71);
            btnCreateAcco.TabIndex = 2;
            btnCreateAcco.Text = "Create Accomodation";
            btnCreateAcco.UseVisualStyleBackColor = true;
            btnCreateAcco.Click += btnCreateAcco_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { ColumID, ColumName, ColumTypeBed, ColumCapacity, ColumSeaView, ColumBreakfast, ColumDinner, ColumPrice, ColumActive, btnRemove });
            dataGridView1.Location = new Point(12, 106);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1137, 371);
            dataGridView1.TabIndex = 3;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // ColumID
            // 
            ColumID.HeaderText = "ID";
            ColumID.MinimumWidth = 6;
            ColumID.Name = "ColumID";
            ColumID.ReadOnly = true;
            ColumID.Width = 125;
            // 
            // ColumName
            // 
            ColumName.HeaderText = "Name";
            ColumName.MinimumWidth = 6;
            ColumName.Name = "ColumName";
            ColumName.ReadOnly = true;
            ColumName.Width = 125;
            // 
            // ColumTypeBed
            // 
            ColumTypeBed.HeaderText = "Type Bed";
            ColumTypeBed.MinimumWidth = 6;
            ColumTypeBed.Name = "ColumTypeBed";
            ColumTypeBed.ReadOnly = true;
            ColumTypeBed.Width = 125;
            // 
            // ColumCapacity
            // 
            ColumCapacity.HeaderText = "Capacidade";
            ColumCapacity.MinimumWidth = 6;
            ColumCapacity.Name = "ColumCapacity";
            ColumCapacity.ReadOnly = true;
            ColumCapacity.Width = 125;
            // 
            // ColumSeaView
            // 
            ColumSeaView.HeaderText = "Vista Mar";
            ColumSeaView.MinimumWidth = 6;
            ColumSeaView.Name = "ColumSeaView";
            ColumSeaView.ReadOnly = true;
            ColumSeaView.Width = 50;
            // 
            // ColumBreakfast
            // 
            ColumBreakfast.HeaderText = "Pequeno almoco";
            ColumBreakfast.MinimumWidth = 6;
            ColumBreakfast.Name = "ColumBreakfast";
            ColumBreakfast.ReadOnly = true;
            ColumBreakfast.Width = 80;
            // 
            // ColumDinner
            // 
            ColumDinner.HeaderText = "Jantar";
            ColumDinner.MinimumWidth = 6;
            ColumDinner.Name = "ColumDinner";
            ColumDinner.ReadOnly = true;
            ColumDinner.Width = 80;
            // 
            // ColumPrice
            // 
            ColumPrice.HeaderText = "Preço";
            ColumPrice.MinimumWidth = 6;
            ColumPrice.Name = "ColumPrice";
            ColumPrice.ReadOnly = true;
            ColumPrice.Width = 125;
            // 
            // ColumActive
            // 
            ColumActive.HeaderText = "Status";
            ColumActive.MinimumWidth = 6;
            ColumActive.Name = "ColumActive";
            ColumActive.ReadOnly = true;
            ColumActive.Width = 125;
            // 
            // btnRemove
            // 
            btnRemove.HeaderText = "Remover";
            btnRemove.MinimumWidth = 6;
            btnRemove.Name = "btnRemove";
            btnRemove.ReadOnly = true;
            btnRemove.Text = "Remover";
            btnRemove.ToolTipText = "Remover";
            btnRemove.Width = 125;
            // 
            // AdminPanelReservation
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            AutoValidate = AutoValidate.Disable;
            ClientSize = new Size(1266, 600);
            Controls.Add(dataGridView1);
            Controls.Add(btnCreateAcco);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "AdminPanelReservation";
            Text = "Clients";
            Load += Clients_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Button btnCreateAcco;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn ColumID;
        private DataGridViewTextBoxColumn ColumName;
        private DataGridViewComboBoxColumn ColumTypeBed;
        private DataGridViewComboBoxColumn ColumCapacity;
        private DataGridViewCheckBoxColumn ColumSeaView;
        private DataGridViewCheckBoxColumn ColumBreakfast;
        private DataGridViewCheckBoxColumn ColumDinner;
        private DataGridViewTextBoxColumn ColumPrice;
        private DataGridViewCheckBoxColumn ColumActive;
        private DataGridViewButtonColumn btnRemove;
    }
}