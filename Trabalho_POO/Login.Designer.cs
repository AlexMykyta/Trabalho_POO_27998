namespace Trabalho_POO
{
    partial class Login
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
            btLogin = new Button();
            tbPassword = new TextBox();
            tbEmail = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            llCreate = new LinkLabel();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            label4 = new Label();
            checkBox1 = new CheckBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btLogin
            // 
            btLogin.BackColor = SystemColors.ControlDarkDark;
            btLogin.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btLogin.ForeColor = Color.White;
            btLogin.Location = new Point(422, 330);
            btLogin.Name = "btLogin";
            btLogin.Size = new Size(156, 33);
            btLogin.TabIndex = 17;
            btLogin.Text = "Login";
            btLogin.UseVisualStyleBackColor = false;
            btLogin.Click += btLogin_Click;
            // 
            // tbPassword
            // 
            tbPassword.BackColor = SystemColors.ButtonHighlight;
            tbPassword.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tbPassword.ForeColor = Color.Black;
            tbPassword.Location = new Point(349, 256);
            tbPassword.MaxLength = 14;
            tbPassword.Name = "tbPassword";
            tbPassword.PasswordChar = '*';
            tbPassword.Size = new Size(324, 29);
            tbPassword.TabIndex = 16;
            // 
            // tbEmail
            // 
            tbEmail.BackColor = Color.White;
            tbEmail.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tbEmail.ForeColor = Color.Black;
            tbEmail.Location = new Point(350, 181);
            tbEmail.Name = "tbEmail";
            tbEmail.Size = new Size(323, 29);
            tbEmail.TabIndex = 15;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(349, 232);
            label3.Name = "label3";
            label3.Size = new Size(86, 21);
            label3.TabIndex = 14;
            label3.Text = "Password:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(350, 157);
            label2.Name = "label2";
            label2.Size = new Size(57, 21);
            label2.TabIndex = 13;
            label2.Text = "Email:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(442, 67);
            label1.Name = "label1";
            label1.Size = new Size(119, 32);
            label1.TabIndex = 12;
            label1.Text = "Welcome";
            // 
            // llCreate
            // 
            llCreate.ActiveLinkColor = Color.Black;
            llCreate.AutoSize = true;
            llCreate.BackColor = Color.Transparent;
            llCreate.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            llCreate.ForeColor = Color.Black;
            llCreate.LinkColor = Color.Black;
            llCreate.Location = new Point(58, 421);
            llCreate.Name = "llCreate";
            llCreate.Size = new Size(210, 21);
            llCreate.TabIndex = 18;
            llCreate.TabStop = true;
            llCreate.Text = "Click to create an account";
            llCreate.LinkClicked += llCreate_LinkClicked;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ButtonShadow;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(llCreate);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(334, 478);
            panel1.TabIndex = 19;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources._88973;
            pictureBox1.Location = new Point(96, 181);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(124, 116);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 20;
            pictureBox1.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ActiveCaptionText;
            label4.Location = new Point(12, 57);
            label4.Name = "label4";
            label4.Size = new Size(293, 45);
            label4.TabIndex = 19;
            label4.Text = "Hotel Managment";
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.ForeColor = SystemColors.ActiveCaptionText;
            checkBox1.Location = new Point(350, 291);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(123, 23);
            checkBox1.TabIndex = 20;
            checkBox1.Text = "Show Password";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(685, 478);
            Controls.Add(checkBox1);
            Controls.Add(panel1);
            Controls.Add(btLogin);
            Controls.Add(tbPassword);
            Controls.Add(tbEmail);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 10F);
            ForeColor = SystemColors.ButtonHighlight;
            FormBorderStyle = FormBorderStyle.None;
            Name = "Login";
            Text = "Form2";
            Load += Login_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btLogin;
        private TextBox tbPassword;
        private TextBox tbEmail;
        private Label label3;
        private Label label2;
        private Label label1;
        private LinkLabel llCreate;
        private Panel panel1;
        private PictureBox pictureBox1;
        private Label label4;
        private CheckBox checkBox1;
    }
}