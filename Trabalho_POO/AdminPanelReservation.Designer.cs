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
            btnEdit = new Button();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // btnCreateAcco
            // 
            btnCreateAcco.Location = new Point(878, 21);
            btnCreateAcco.Name = "btnCreateAcco";
            btnCreateAcco.Size = new Size(128, 53);
            btnCreateAcco.TabIndex = 2;
            btnCreateAcco.Text = "Create Accomodation";
            btnCreateAcco.UseVisualStyleBackColor = true;
            btnCreateAcco.Click += btnCreateAcco_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { ColumID, ColumName, ColumTypeBed, ColumCapacity, ColumSeaView, ColumBreakfast, ColumDinner, ColumPrice, ColumActive, btnRemove });
            dataGridView1.Location = new Point(10, 80);
            dataGridView1.Margin = new Padding(3, 2, 3, 2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(995, 278);
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
            // btnEdit
            // 
            btnEdit.Location = new Point(10, 52);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(113, 23);
            btnEdit.TabIndex = 4;
            btnEdit.Text = "Modo Edição";
            btnEdit.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(270, 46);
            button1.Name = "button1";
            button1.Size = new Size(8, 8);
            button1.TabIndex = 5;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // AdminPanelReservation
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            AutoValidate = AutoValidate.Disable;
            ClientSize = new Size(1108, 450);
            Controls.Add(button1);
            Controls.Add(btnEdit);
            Controls.Add(dataGridView1);
            Controls.Add(btnCreateAcco);
            FormBorderStyle = FormBorderStyle.None;
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
        private Button btnEdit;
        private Button button1;
    }
}