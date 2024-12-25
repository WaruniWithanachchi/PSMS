namespace Pet_Shop_Management_System
{
    partial class LoginForm
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
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            label1 = new Label();
            label5 = new Label();
            pictureBox2 = new PictureBox();
            panel2 = new Panel();
            pictureBox3 = new PictureBox();
            panel3 = new Panel();
            button1 = new Button();
            label6 = new Label();
            label7 = new Label();
            textUserName = new TextBox();
            textPassword = new TextBox();
            checkBox1 = new CheckBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(192, 192, 255);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(239, 498);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Pets;
            pictureBox1.Location = new Point(29, 37);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(176, 163);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Harrington", 16.2F, FontStyle.Bold);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(76, 298);
            label2.Name = "label2";
            label2.Size = new Size(75, 32);
            label2.TabIndex = 0;
            label2.Text = "User";
            label2.Click += label1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Harrington", 16.2F, FontStyle.Bold);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(52, 244);
            label1.Name = "label1";
            label1.Size = new Size(132, 32);
            label1.TabIndex = 0;
            label1.Text = "Welcome";
            label1.Click += label1_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Purple;
            label5.Location = new Point(283, 74);
            label5.Name = "label5";
            label5.Size = new Size(212, 21);
            label5.TabIndex = 1;
            label5.Text = "Login to the account...";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources._4148245_200;
            pictureBox2.Location = new Point(283, 134);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(46, 38);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            // 
            // panel2
            // 
            panel2.Location = new Point(283, 178);
            panel2.Name = "panel2";
            panel2.Size = new Size(355, 2);
            panel2.TabIndex = 3;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.login_password_3;
            pictureBox3.Location = new Point(283, 230);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(46, 38);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 2;
            pictureBox3.TabStop = false;
            // 
            // panel3
            // 
            panel3.Location = new Point(283, 274);
            panel3.Name = "panel3";
            panel3.Size = new Size(355, 2);
            panel3.TabIndex = 3;
            // 
            // button1
            // 
            button1.BackColor = Color.Purple;
            button1.FlatAppearance.BorderColor = Color.FromArgb(0, 0, 64);
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Century Schoolbook", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.Location = new Point(283, 333);
            button1.Name = "button1";
            button1.Size = new Size(355, 54);
            button1.TabIndex = 4;
            button1.Text = "Login";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.Purple;
            label6.Location = new Point(565, 294);
            label6.Name = "label6";
            label6.Size = new Size(92, 20);
            label6.TabIndex = 5;
            label6.Text = "Clear Fields";
            label6.Click += label6_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.Purple;
            label7.Location = new Point(440, 409);
            label7.Name = "label7";
            label7.Size = new Size(39, 21);
            label7.TabIndex = 5;
            label7.Text = "Exit";
            label7.Click += label7_Click;
            // 
            // textUserName
            // 
            textUserName.BorderStyle = BorderStyle.None;
            textUserName.Font = new Font("Century", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textUserName.ForeColor = Color.Silver;
            textUserName.Location = new Point(335, 134);
            textUserName.Multiline = true;
            textUserName.Name = "textUserName";
            textUserName.Size = new Size(303, 38);
            textUserName.TabIndex = 6;
            // 
            // textPassword
            // 
            textPassword.BorderStyle = BorderStyle.None;
            textPassword.Font = new Font("Century", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textPassword.ForeColor = Color.Silver;
            textPassword.Location = new Point(335, 230);
            textPassword.Multiline = true;
            textPassword.Name = "textPassword";
            textPassword.Size = new Size(303, 35);
            textPassword.TabIndex = 6;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(292, 285);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(132, 24);
            checkBox1.TabIndex = 7;
            checkBox1.Text = "Show Password";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // LoginForm
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(729, 498);
            Controls.Add(checkBox1);
            Controls.Add(textPassword);
            Controls.Add(textUserName);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(button1);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(label5);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LoginForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Label label1;
        private Label label5;
        private PictureBox pictureBox2;
        private Panel panel2;
        private PictureBox pictureBox3;
        private Panel panel3;
        private Button button1;
        private Label label6;
        private Label label7;
        private TextBox textUserName;
        private TextBox textPassword;
        private Label label2;
        private CheckBox checkBox1;
    }
}