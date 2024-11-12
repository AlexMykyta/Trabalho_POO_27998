namespace Trabalho_POO
{
    partial class New
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
            btCreate = new Button();
            tbEmail = new TextBox();
            label2 = new Label();
            label1 = new Label();
            label4 = new Label();
            label5 = new Label();
            tbName = new TextBox();
            label6 = new Label();
            tbBirthDate = new TextBox();
            tBoxPassword = new TextBox();
            panel1 = new Panel();
            button1 = new Button();
            pictureBox1 = new PictureBox();
            label3 = new Label();
            checkBox1 = new CheckBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btCreate
            // 
            btCreate.BackColor = SystemColors.ControlDarkDark;
            btCreate.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btCreate.ForeColor = Color.White;
            btCreate.Location = new Point(428, 393);
            btCreate.Name = "btCreate";
            btCreate.Size = new Size(174, 36);
            btCreate.TabIndex = 23;
            btCreate.Text = "Create";
            btCreate.UseVisualStyleBackColor = false;
            btCreate.Click += btCreate_Click;
            // 
            // tbEmail
            // 
            tbEmail.BackColor = SystemColors.ButtonHighlight;
            tbEmail.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tbEmail.ForeColor = Color.White;
            tbEmail.Location = new Point(358, 253);
            tbEmail.Name = "tbEmail";
            tbEmail.Size = new Size(315, 29);
            tbEmail.TabIndex = 21;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ActiveCaptionText;
            label2.Location = new Point(358, 229);
            label2.Name = "label2";
            label2.Size = new Size(57, 21);
            label2.TabIndex = 19;
            label2.Text = "Email:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(413, 34);
            label1.Name = "label1";
            label1.Size = new Size(189, 32);
            label1.TabIndex = 18;
            label1.Text = "Create Account";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ActiveCaptionText;
            label4.Location = new Point(358, 296);
            label4.Name = "label4";
            label4.Size = new Size(86, 21);
            label4.TabIndex = 25;
            label4.Text = "Password:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.ActiveCaptionText;
            label5.Location = new Point(358, 162);
            label5.Name = "label5";
            label5.Size = new Size(91, 21);
            label5.TabIndex = 24;
            label5.Text = "Birth Date:";
            // 
            // tbName
            // 
            tbName.BackColor = SystemColors.ButtonHighlight;
            tbName.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tbName.ForeColor = Color.White;
            tbName.Location = new Point(358, 116);
            tbName.Name = "tbName";
            tbName.Size = new Size(315, 29);
            tbName.TabIndex = 29;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = SystemColors.ActiveCaptionText;
            label6.Location = new Point(355, 92);
            label6.Name = "label6";
            label6.Size = new Size(60, 21);
            label6.TabIndex = 28;
            label6.Text = "Name:";
            // 
            // tbBirthDate
            // 
            tbBirthDate.BackColor = SystemColors.ButtonHighlight;
            tbBirthDate.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tbBirthDate.ForeColor = Color.White;
            tbBirthDate.Location = new Point(358, 186);
            tbBirthDate.MaxLength = 10;
            tbBirthDate.Name = "tbBirthDate";
            tbBirthDate.Size = new Size(315, 29);
            tbBirthDate.TabIndex = 30;
            // 
            // tBoxPassword
            // 
            tBoxPassword.BackColor = SystemColors.ButtonHighlight;
            tBoxPassword.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tBoxPassword.ForeColor = Color.White;
            tBoxPassword.Location = new Point(358, 320);
            tBoxPassword.MaxLength = 14;
            tBoxPassword.Name = "tBoxPassword";
            tBoxPassword.PasswordChar = '*';
            tBoxPassword.Size = new Size(315, 29);
            tBoxPassword.TabIndex = 31;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlDarkDark;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(button1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(334, 478);
            panel1.TabIndex = 33;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ControlDarkDark;
            button1.ForeColor = SystemColors.ActiveCaptionText;
            button1.Location = new Point(12, 12);
            button1.Name = "button1";
            button1.Size = new Size(75, 37);
            button1.TabIndex = 0;
            button1.Text = "< Back";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources._88973;
            pictureBox1.Location = new Point(106, 216);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(124, 116);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 22;
            pictureBox1.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ActiveCaptionText;
            label3.Location = new Point(22, 92);
            label3.Name = "label3";
            label3.Size = new Size(293, 45);
            label3.TabIndex = 21;
            label3.Text = "Hotel Managment";
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(358, 355);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(108, 19);
            checkBox1.TabIndex = 34;
            checkBox1.Text = "Show Password";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // New
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(685, 478);
            Controls.Add(checkBox1);
            Controls.Add(panel1);
            Controls.Add(tBoxPassword);
            Controls.Add(tbBirthDate);
            Controls.Add(tbName);
            Controls.Add(label6);
            Controls.Add(label4);
            Controls.Add(label5);
            Controls.Add(btCreate);
            Controls.Add(tbEmail);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "New";
            Text = "New";
            Load += New_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btCreate;
        private TextBox tbPassword;
        private TextBox tbEmail;
        private Label label3;
        private Label label2;
        private Label label1;
        //private TextBox tbPassword;
        private Label label4;
        private Label label5;
        private TextBox tbName;
        private Label label6;
        private TextBox tbBirthDate;
        private TextBox tBoxPassword;
        private Panel panel1;
        private Button button1;
        private PictureBox pictureBox1;
        private CheckBox checkBox1;
    }
}