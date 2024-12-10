namespace Trabalho_POO
{
    partial class MainAdminPanel
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainAdminPanel));
            panel2 = new Panel();
            label1 = new Label();
            nightControlBox1 = new ReaLTaiizor.Controls.NightControlBox();
            btSideBar = new PictureBox();
            sideBar = new FlowLayoutPanel();
            button1 = new Button();
            btClientManagement = new Button();
            button2 = new Button();
            btLogOut = new Button();
            SideBarTime = new System.Windows.Forms.Timer(components);
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btSideBar).BeginInit();
            sideBar.SuspendLayout();
            SuspendLayout();
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
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(1282, 55);
            panel2.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(131, 13);
            label1.Name = "label1";
            label1.Size = new Size(80, 28);
            label1.TabIndex = 2;
            label1.Text = "Admin ";
            label1.Click += label1_Click;
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
            nightControlBox1.Location = new Point(1143, 0);
            nightControlBox1.MaximizeHoverColor = Color.FromArgb(15, 255, 255, 255);
            nightControlBox1.MaximizeHoverForeColor = Color.White;
            nightControlBox1.MinimizeHoverColor = Color.FromArgb(15, 255, 255, 255);
            nightControlBox1.MinimizeHoverForeColor = Color.White;
            nightControlBox1.Name = "nightControlBox1";
            nightControlBox1.Size = new Size(139, 31);
            nightControlBox1.TabIndex = 1;
            // 
            // btSideBar
            // 
            btSideBar.Image = (Image)resources.GetObject("btSideBar.Image");
            btSideBar.Location = new Point(11, 5);
            btSideBar.Margin = new Padding(3, 4, 3, 4);
            btSideBar.Name = "btSideBar";
            btSideBar.Size = new Size(86, 36);
            btSideBar.SizeMode = PictureBoxSizeMode.CenterImage;
            btSideBar.TabIndex = 1;
            btSideBar.TabStop = false;
            btSideBar.Click += btSideBar_Click;
            // 
            // sideBar
            // 
            sideBar.BackColor = SystemColors.ControlDarkDark;
            sideBar.Controls.Add(button1);
            sideBar.Controls.Add(btClientManagement);
            sideBar.Controls.Add(button2);
            sideBar.Controls.Add(btLogOut);
            sideBar.Dock = DockStyle.Left;
            sideBar.Location = new Point(0, 55);
            sideBar.Margin = new Padding(3, 4, 3, 4);
            sideBar.Name = "sideBar";
            sideBar.Size = new Size(105, 545);
            sideBar.TabIndex = 6;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ControlDarkDark;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(3, 4);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Padding = new Padding(34, 0, 51, 0);
            button1.Size = new Size(283, 72);
            button1.TabIndex = 7;
            button1.Text = "   Clientes";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // btClientManagement
            // 
            btClientManagement.BackColor = SystemColors.ControlDarkDark;
            btClientManagement.FlatAppearance.BorderSize = 0;
            btClientManagement.FlatStyle = FlatStyle.Flat;
            btClientManagement.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btClientManagement.ForeColor = Color.White;
            btClientManagement.Image = (Image)resources.GetObject("btClientManagement.Image");
            btClientManagement.ImageAlign = ContentAlignment.MiddleLeft;
            btClientManagement.Location = new Point(3, 84);
            btClientManagement.Margin = new Padding(3, 4, 3, 4);
            btClientManagement.Name = "btClientManagement";
            btClientManagement.Padding = new Padding(34, 0, 51, 0);
            btClientManagement.Size = new Size(283, 72);
            btClientManagement.TabIndex = 6;
            btClientManagement.Text = "        Alojamentos";
            btClientManagement.UseVisualStyleBackColor = false;
            btClientManagement.Click += btClientManagement_Click;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.ControlDarkDark;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.White;
            button2.Image = (Image)resources.GetObject("button2.Image");
            button2.ImageAlign = ContentAlignment.MiddleLeft;
            button2.Location = new Point(3, 164);
            button2.Margin = new Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Padding = new Padding(34, 0, 51, 0);
            button2.Size = new Size(283, 72);
            button2.TabIndex = 8;
            button2.Text = "            Reservados";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
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
            btLogOut.Location = new Point(3, 244);
            btLogOut.Margin = new Padding(3, 4, 3, 4);
            btLogOut.Name = "btLogOut";
            btLogOut.Padding = new Padding(34, 0, 51, 0);
            btLogOut.Size = new Size(280, 68);
            btLogOut.TabIndex = 6;
            btLogOut.Text = "    Logout";
            btLogOut.UseVisualStyleBackColor = false;
            btLogOut.Click += btLogOut_Click;
            // 
            // SideBarTime
            // 
            SideBarTime.Tick += timer1_Tick;
            // 
            // MainAdminPanel
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1282, 600);
            Controls.Add(sideBar);
            Controls.Add(panel2);
            FormBorderStyle = FormBorderStyle.None;
            IsMdiContainer = true;
            Margin = new Padding(3, 4, 3, 4);
            Name = "MainAdminPanel";
            Text = "AdminPainel";
            Load += MainAdminPanel_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)btSideBar).EndInit();
            sideBar.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel2;
        private Label label1;
        private ReaLTaiizor.Controls.NightControlBox nightControlBox1;
        private PictureBox btSideBar;
        private FlowLayoutPanel sideBar;
        private Button btClientManagement;
        private Button btLogOut;
        private Button button1;
        private System.Windows.Forms.Timer SideBarTime;
        private Button button2;
    }
}