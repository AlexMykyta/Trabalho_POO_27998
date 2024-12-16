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
            flpAccommodations = new FlowLayoutPanel();
            SuspendLayout();
            // 
            // flpAccommodations
            // 
            flpAccommodations.Location = new Point(0, 32);
            flpAccommodations.Name = "flpAccommodations";
            flpAccommodations.Size = new Size(982, 418);
            flpAccommodations.TabIndex = 0;
            flpAccommodations.Paint += flpAccommodations_Paint;
            // 
            // ClientReservation
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(982, 450);
            Controls.Add(flpAccommodations);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ClientReservation";
            Text = "Reservations";
            Load += Reservations_Load;
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel flpAccommodations;
    }
}