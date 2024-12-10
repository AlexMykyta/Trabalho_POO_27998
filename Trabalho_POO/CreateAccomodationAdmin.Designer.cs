namespace Trabalho_POO
{
    partial class CreateAccomodationAdmin
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            txtBoxName = new TextBox();
            cbTypeBed = new ComboBox();
            cbCapacity = new ComboBox();
            checkboxSea = new CheckBox();
            checkBoxBreakFast = new CheckBox();
            checkBoxDinner = new CheckBox();
            txtPrice = new TextBox();
            btnCreateAcco = new Button();
            BtnBack = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F);
            label1.Location = new Point(25, 66);
            label1.Name = "label1";
            label1.Size = new Size(274, 37);
            label1.TabIndex = 0;
            label1.Text = "Create Accomodation";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(12, 122);
            label2.Name = "label2";
            label2.Size = new Size(56, 21);
            label2.TabIndex = 1;
            label2.Text = "Nome:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(9, 166);
            label3.Name = "label3";
            label3.Size = new Size(105, 21);
            label3.TabIndex = 2;
            label3.Text = "Tipo de cama:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(9, 205);
            label4.Name = "label4";
            label4.Size = new Size(93, 21);
            label4.TabIndex = 3;
            label4.Text = "Capacidade:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F);
            label5.Location = new Point(9, 250);
            label5.Name = "label5";
            label5.Size = new Size(127, 21);
            label5.TabIndex = 4;
            label5.Text = "Vista para o mar:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F);
            label6.Location = new Point(9, 297);
            label6.Name = "label6";
            label6.Size = new Size(130, 21);
            label6.TabIndex = 5;
            label6.Text = "Pequeno Almoço:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F);
            label7.Location = new Point(9, 336);
            label7.Name = "label7";
            label7.Size = new Size(55, 21);
            label7.TabIndex = 6;
            label7.Text = "Jantar:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F);
            label8.Location = new Point(9, 380);
            label8.Name = "label8";
            label8.Size = new Size(52, 21);
            label8.TabIndex = 7;
            label8.Text = "Preço:";
            // 
            // txtBoxName
            // 
            txtBoxName.Location = new Point(74, 124);
            txtBoxName.Name = "txtBoxName";
            txtBoxName.Size = new Size(225, 23);
            txtBoxName.TabIndex = 8;
            // 
            // cbTypeBed
            // 
            cbTypeBed.FormattingEnabled = true;
            cbTypeBed.Items.AddRange(new object[] { "Cama de Casal", "Cama de Solteiro", "2 camas individuais", "Cama King Size " });
            cbTypeBed.Location = new Point(120, 168);
            cbTypeBed.Name = "cbTypeBed";
            cbTypeBed.Size = new Size(179, 23);
            cbTypeBed.TabIndex = 9;
            // 
            // cbCapacity
            // 
            cbCapacity.FormattingEnabled = true;
            cbCapacity.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "7", "8", "9" });
            cbCapacity.Location = new Point(108, 207);
            cbCapacity.Name = "cbCapacity";
            cbCapacity.Size = new Size(191, 23);
            cbCapacity.TabIndex = 10;
            // 
            // checkboxSea
            // 
            checkboxSea.AutoSize = true;
            checkboxSea.Font = new Font("Segoe UI", 20F);
            checkboxSea.Location = new Point(142, 257);
            checkboxSea.Name = "checkboxSea";
            checkboxSea.Size = new Size(15, 14);
            checkboxSea.TabIndex = 11;
            checkboxSea.UseVisualStyleBackColor = true;
            // 
            // checkBoxBreakFast
            // 
            checkBoxBreakFast.AutoSize = true;
            checkBoxBreakFast.Font = new Font("Segoe UI", 20F);
            checkBoxBreakFast.Location = new Point(145, 304);
            checkBoxBreakFast.Name = "checkBoxBreakFast";
            checkBoxBreakFast.Size = new Size(15, 14);
            checkBoxBreakFast.TabIndex = 12;
            checkBoxBreakFast.UseVisualStyleBackColor = true;
            // 
            // checkBoxDinner
            // 
            checkBoxDinner.AutoSize = true;
            checkBoxDinner.Font = new Font("Segoe UI", 20F);
            checkBoxDinner.Location = new Point(74, 343);
            checkBoxDinner.Name = "checkBoxDinner";
            checkBoxDinner.Size = new Size(15, 14);
            checkBoxDinner.TabIndex = 13;
            checkBoxDinner.UseVisualStyleBackColor = true;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(74, 382);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(118, 23);
            txtPrice.TabIndex = 14;
            // 
            // btnCreateAcco
            // 
            btnCreateAcco.Location = new Point(88, 429);
            btnCreateAcco.Name = "btnCreateAcco";
            btnCreateAcco.Size = new Size(124, 35);
            btnCreateAcco.TabIndex = 15;
            btnCreateAcco.Text = "CREATE";
            btnCreateAcco.UseVisualStyleBackColor = true;
            btnCreateAcco.Click += btnCreateAcco_Click;
            // 
            // BtnBack
            // 
            BtnBack.Location = new Point(25, 12);
            BtnBack.Name = "BtnBack";
            BtnBack.Size = new Size(75, 51);
            BtnBack.TabIndex = 16;
            BtnBack.Text = "Back";
            BtnBack.UseVisualStyleBackColor = true;
            BtnBack.Click += BtnBack_Click_1;
            // 
            // CreateAccomodationAdmin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(311, 503);
            Controls.Add(BtnBack);
            Controls.Add(btnCreateAcco);
            Controls.Add(txtPrice);
            Controls.Add(checkBoxDinner);
            Controls.Add(checkBoxBreakFast);
            Controls.Add(checkboxSea);
            Controls.Add(cbCapacity);
            Controls.Add(cbTypeBed);
            Controls.Add(txtBoxName);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "CreateAccomodationAdmin";
            Text = "CreatAccomodationAdmin";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private TextBox txtBoxName;
        private ComboBox cbTypeBed;
        private ComboBox cbCapacity;
        private CheckBox checkboxSea;
        private CheckBox checkBoxBreakFast;
        private CheckBox checkBoxDinner;
        private TextBox txtPrice;
        private Button btnCreateAcco;
        private Button BtnBack;
    }
}