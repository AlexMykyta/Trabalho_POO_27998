namespace Trabalho_POO
{
    partial class ClientReservation
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
            airButton1 = new ReaLTaiizor.Controls.AirButton();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 48F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(1, -1);
            label1.Name = "label1";
            label1.Size = new Size(681, 86);
            label1.TabIndex = 0;
            label1.Text = "Teste Reservas Clientes";
            // 
            // airButton1
            // 
            airButton1.Customization = "7e3t//Ly8v/r6+v/5ubm/+vr6//f39//p6en/zw8PP8UFBT/gICA/w==";
            airButton1.Font = new Font("Segoe UI", 9F);
            airButton1.Image = null;
            airButton1.Location = new Point(300, 240);
            airButton1.Name = "airButton1";
            airButton1.NoRounding = false;
            airButton1.Size = new Size(100, 45);
            airButton1.TabIndex = 1;
            airButton1.Text = "airButton1";
            airButton1.Transparent = false;
            // 
            // Reservations
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1138, 643);
            Controls.Add(airButton1);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Reservations";
            Text = "Reservations";
            Load += Reservations_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ReaLTaiizor.Controls.AirButton airButton1;
    }
}