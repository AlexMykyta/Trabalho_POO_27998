namespace Trabalho_POO
{
    partial class Main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            nightControlBox1 = new ReaLTaiizor.Controls.NightControlBox();
            label1 = new Label();
            btSideBar = new PictureBox();
            panel2 = new Panel();
            sideBar = new FlowLayoutPanel();
            btReservations = new Button();
            btAbout = new Button();
            btLogOut = new Button();
            menuTransition = new System.Windows.Forms.Timer(components);
            sideBarTransition = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)btSideBar).BeginInit();
            panel2.SuspendLayout();
            sideBar.SuspendLayout();
            SuspendLayout();
            // 
            // nightControlBox1
            // 
            nightControlBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            nightControlBox1.BackColor = Color.Transparent;
            nightControlBox1.CloseHoverColor = Color.FromArgb(199, 80, 80);
            nightControlBox1.CloseHoverForeColor = Color.White;
            nightControlBox1.DefaultLocation = true;
            nightControlBox1.DisableMaximizeColor = Color.Black;
            nightControlBox1.DisableMinimizeColor = Color.Black;
            nightControlBox1.EnableCloseColor = Color.Black;
            nightControlBox1.EnableMaximizeButton = false;
            nightControlBox1.EnableMaximizeColor = Color.Black;
            nightControlBox1.EnableMinimizeButton = true;
            nightControlBox1.EnableMinimizeColor = Color.Black;
            nightControlBox1.Location = new Point(879, 0);
            nightControlBox1.MaximizeHoverColor = Color.FromArgb(15, 255, 255, 255);
            nightControlBox1.MaximizeHoverForeColor = Color.White;
            nightControlBox1.MinimizeHoverColor = Color.FromArgb(15, 255, 255, 255);
            nightControlBox1.MinimizeHoverForeColor = Color.White;
            nightControlBox1.Name = "nightControlBox1";
            nightControlBox1.Size = new Size(139, 31);
            nightControlBox1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(74, 8);
            label1.Name = "label1";
            label1.Size = new Size(225, 21);
            label1.TabIndex = 2;
            label1.Text = "Gestão Alojamento Turístico";
            // 
            // btSideBar
            // 
            btSideBar.Image = (Image)resources.GetObject("btSideBar.Image");
            btSideBar.Location = new Point(10, 4);
            btSideBar.Name = "btSideBar";
            btSideBar.Size = new Size(58, 27);
            btSideBar.SizeMode = PictureBoxSizeMode.CenterImage;
            btSideBar.TabIndex = 1;
            btSideBar.TabStop = false;
            btSideBar.Click += btSideBar_Click;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ControlDarkDark;
            panel2.Controls.Add(label1);
            panel2.Controls.Add(nightControlBox1);
            panel2.Controls.Add(btSideBar);
            panel2.Dock = DockStyle.Top;
            panel2.ForeColor = Color.Transparent;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1018, 41);
            panel2.TabIndex = 4;
            panel2.Paint += panel2_Paint;
            // 
            // sideBar
            // 
            sideBar.BackColor = SystemColors.ControlDarkDark;
            sideBar.Controls.Add(btReservations);
            sideBar.Controls.Add(btAbout);
            sideBar.Controls.Add(btLogOut);
            sideBar.Dock = DockStyle.Left;
            sideBar.Location = new Point(0, 41);
            sideBar.Name = "sideBar";
            sideBar.Size = new Size(83, 490);
            sideBar.TabIndex = 3;
            // 
            // btReservations
            // 
            btReservations.BackColor = SystemColors.ControlDarkDark;
            btReservations.FlatAppearance.BorderSize = 0;
            btReservations.FlatStyle = FlatStyle.Flat;
            btReservations.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btReservations.ForeColor = Color.White;
            btReservations.Image = (Image)resources.GetObject("btReservations.Image");
            btReservations.ImageAlign = ContentAlignment.MiddleLeft;
            btReservations.Location = new Point(3, 3);
            btReservations.Name = "btReservations";
            btReservations.Padding = new Padding(30, 0, 45, 0);
            btReservations.Size = new Size(248, 54);
            btReservations.TabIndex = 6;
            btReservations.Text = "    Reservations";
            btReservations.UseVisualStyleBackColor = false;
            btReservations.Click += btReservations_Click_1;
            // 
            // btAbout
            // 
            btAbout.BackColor = SystemColors.ControlDarkDark;
            btAbout.FlatAppearance.BorderSize = 0;
            btAbout.FlatStyle = FlatStyle.Flat;
            btAbout.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btAbout.ForeColor = Color.White;
            btAbout.Image = (Image)resources.GetObject("btAbout.Image");
            btAbout.ImageAlign = ContentAlignment.MiddleLeft;
            btAbout.Location = new Point(3, 63);
            btAbout.Name = "btAbout";
            btAbout.Padding = new Padding(30, 0, 45, 0);
            btAbout.Size = new Size(245, 54);
            btAbout.TabIndex = 6;
            btAbout.Text = "    About";
            btAbout.UseVisualStyleBackColor = false;
            btAbout.Click += btAbout_Click;
            // 
            // btLogOut
            // 
            btLogOut.BackColor = SystemColors.ControlDarkDark;
            btLogOut.FlatAppearance.BorderSize = 0;
            btLogOut.FlatStyle = FlatStyle.Flat;
            btLogOut.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btLogOut.ForeColor = Color.White;
            btLogOut.Image = (Image)resources.GetObject("btLogOut.Image");
            btLogOut.ImageAlign = ContentAlignment.MiddleLeft;
            btLogOut.Location = new Point(3, 123);
            btLogOut.Name = "btLogOut";
            btLogOut.Padding = new Padding(30, 0, 45, 0);
            btLogOut.Size = new Size(245, 51);
            btLogOut.TabIndex = 6;
            btLogOut.Text = "    Logout";
            btLogOut.UseVisualStyleBackColor = false;
            // 
            // menuTransition
            // 
            menuTransition.Tick += menuTransition_Tick;
            // 
            // sideBarTransition
            // 
            sideBarTransition.Interval = 10;
            sideBarTransition.Tick += sideBarTransition_Tick;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(1018, 531);
            Controls.Add(sideBar);
            Controls.Add(panel2);
            ForeColor = SystemColors.ControlLightLight;
            FormBorderStyle = FormBorderStyle.None;
            IsMdiContainer = true;
            Name = "Main";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)btSideBar).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            sideBar.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private ReaLTaiizor.Controls.NightControlBox nightControlBox1;
        private Label label1;
        private PictureBox btSideBar;
        private Panel panel2;
        private FlowLayoutPanel sideBar;
        private Button btReservations;
        private Button btLogOut;
        private Button btAbout;
        private System.Windows.Forms.Timer menuTransition;
        private System.Windows.Forms.Timer sideBarTransition;
    }
}
