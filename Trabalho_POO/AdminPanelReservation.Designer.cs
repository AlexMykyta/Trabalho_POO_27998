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
            SuspendLayout();
            // 
            // btnCreateAcco
            // 
            btnCreateAcco.Location = new Point(567, 45);
            btnCreateAcco.Name = "btnCreateAcco";
            btnCreateAcco.Size = new Size(128, 53);
            btnCreateAcco.TabIndex = 2;
            btnCreateAcco.Text = "Create Accomodation";
            btnCreateAcco.UseVisualStyleBackColor = true;
            btnCreateAcco.Click += btnCreateAcco_Click;
            // 
            // AdminPanelReservation
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnCreateAcco);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AdminPanelReservation";
            Text = "Clients";
            Load += Clients_Load;
            ResumeLayout(false);
        }

        #endregion
        private Button btnCreateAcco;
    }
}