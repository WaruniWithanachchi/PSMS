namespace Pet_Shop_Management_System
{
    partial class MainForm
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
            labelexit = new Label();
            label1 = new Label();
            buttonDashboard = new Button();
            buttonCustomers = new Button();
            buttonProducts = new Button();
            buttonCash = new Button();
            buttonLogout = new Button();
            panel2 = new Panel();
            button1 = new Button();
            panel3 = new Panel();
            dashboard1 = new Dashboard();
            addCustomer1 = new AddCustomer();
            addEmployee1 = new AddEmployee();
            addProduct1 = new AddProduct();
            addCash1 = new AddCash();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(192, 192, 255);
            panel1.Controls.Add(labelexit);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1231, 68);
            panel1.TabIndex = 0;
            // 
            // labelexit
            // 
            labelexit.AutoSize = true;
            labelexit.Font = new Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelexit.ForeColor = Color.Purple;
            labelexit.Location = new Point(1180, 23);
            labelexit.Name = "labelexit";
            labelexit.Size = new Size(39, 21);
            labelexit.TabIndex = 8;
            labelexit.Text = "Exit";
            labelexit.Click += labelexit_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(19, 23);
            label1.Name = "label1";
            label1.Size = new Size(369, 28);
            label1.TabIndex = 7;
            label1.Text = "Pet Shop Management System";
            // 
            // buttonDashboard
            // 
            buttonDashboard.BackColor = Color.Purple;
            buttonDashboard.FlatAppearance.BorderColor = Color.White;
            buttonDashboard.FlatAppearance.BorderSize = 3;
            buttonDashboard.FlatStyle = FlatStyle.Flat;
            buttonDashboard.Font = new Font("Century Schoolbook", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonDashboard.ForeColor = SystemColors.ButtonHighlight;
            buttonDashboard.Location = new Point(19, 88);
            buttonDashboard.Name = "buttonDashboard";
            buttonDashboard.Size = new Size(171, 59);
            buttonDashboard.TabIndex = 5;
            buttonDashboard.Text = "Dashboard";
            buttonDashboard.TextAlign = ContentAlignment.MiddleRight;
            buttonDashboard.UseVisualStyleBackColor = false;
            buttonDashboard.Click += buttonDashboard_Click;
            // 
            // buttonCustomers
            // 
            buttonCustomers.BackColor = Color.Purple;
            buttonCustomers.FlatAppearance.BorderColor = Color.White;
            buttonCustomers.FlatAppearance.BorderSize = 3;
            buttonCustomers.FlatStyle = FlatStyle.Flat;
            buttonCustomers.Font = new Font("Century Schoolbook", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonCustomers.ForeColor = SystemColors.ButtonHighlight;
            buttonCustomers.Location = new Point(19, 176);
            buttonCustomers.Name = "buttonCustomers";
            buttonCustomers.Size = new Size(171, 58);
            buttonCustomers.TabIndex = 15;
            buttonCustomers.Text = "Customers";
            buttonCustomers.TextAlign = ContentAlignment.MiddleRight;
            buttonCustomers.UseVisualStyleBackColor = false;
            buttonCustomers.Click += buttonCustomers_Click_1;
            // 
            // buttonProducts
            // 
            buttonProducts.BackColor = Color.Purple;
            buttonProducts.FlatAppearance.BorderColor = Color.White;
            buttonProducts.FlatAppearance.BorderSize = 3;
            buttonProducts.FlatStyle = FlatStyle.Flat;
            buttonProducts.Font = new Font("Century Schoolbook", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonProducts.ForeColor = SystemColors.ButtonHighlight;
            buttonProducts.Location = new Point(19, 371);
            buttonProducts.Name = "buttonProducts";
            buttonProducts.Size = new Size(171, 58);
            buttonProducts.TabIndex = 19;
            buttonProducts.Text = "Products";
            buttonProducts.TextAlign = ContentAlignment.MiddleRight;
            buttonProducts.UseVisualStyleBackColor = false;
            buttonProducts.Click += buttonProducts_Click;
            // 
            // buttonCash
            // 
            buttonCash.BackColor = Color.Purple;
            buttonCash.FlatAppearance.BorderColor = Color.White;
            buttonCash.FlatAppearance.BorderSize = 3;
            buttonCash.FlatStyle = FlatStyle.Flat;
            buttonCash.Font = new Font("Century Schoolbook", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonCash.ForeColor = SystemColors.ButtonHighlight;
            buttonCash.Location = new Point(19, 459);
            buttonCash.Name = "buttonCash";
            buttonCash.Size = new Size(171, 57);
            buttonCash.TabIndex = 21;
            buttonCash.Text = "Cash";
            buttonCash.TextAlign = ContentAlignment.MiddleRight;
            buttonCash.UseVisualStyleBackColor = false;
            buttonCash.Click += buttonCash_Click;
            // 
            // buttonLogout
            // 
            buttonLogout.BackColor = Color.FromArgb(192, 192, 255);
            buttonLogout.FlatAppearance.BorderColor = Color.FromArgb(0, 0, 64);
            buttonLogout.FlatStyle = FlatStyle.Flat;
            buttonLogout.Font = new Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonLogout.ForeColor = SystemColors.ActiveCaptionText;
            buttonLogout.Location = new Point(66, 562);
            buttonLogout.Name = "buttonLogout";
            buttonLogout.Size = new Size(96, 38);
            buttonLogout.TabIndex = 22;
            buttonLogout.Text = "Log Out";
            buttonLogout.TextAlign = ContentAlignment.MiddleLeft;
            buttonLogout.UseVisualStyleBackColor = false;
            buttonLogout.Click += buttonLogout_Click_1;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(192, 192, 255);
            panel2.Controls.Add(button1);
            panel2.Controls.Add(buttonDashboard);
            panel2.Controls.Add(buttonLogout);
            panel2.Controls.Add(buttonCash);
            panel2.Controls.Add(buttonCustomers);
            panel2.Controls.Add(buttonProducts);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 68);
            panel2.Name = "panel2";
            panel2.Size = new Size(231, 626);
            panel2.TabIndex = 23;
            // 
            // button1
            // 
            button1.BackColor = Color.Purple;
            button1.FlatAppearance.BorderSize = 3;
            button1.Font = new Font("Century Schoolbook", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(19, 273);
            button1.Name = "button1";
            button1.Size = new Size(171, 57);
            button1.TabIndex = 23;
            button1.Text = "Employees";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // panel3
            // 
            panel3.Controls.Add(dashboard1);
            panel3.Controls.Add(addCustomer1);
            panel3.Controls.Add(addEmployee1);
            panel3.Controls.Add(addProduct1);
            panel3.Controls.Add(addCash1);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(231, 68);
            panel3.Name = "panel3";
            panel3.Size = new Size(1000, 626);
            panel3.TabIndex = 24;
            // 
            // dashboard1
            // 
            dashboard1.BackColor = SystemColors.Control;
            dashboard1.Location = new Point(-12, 0);
            dashboard1.Name = "dashboard1";
            dashboard1.Size = new Size(1250, 808);
            dashboard1.TabIndex = 4;
            // 
            // addCustomer1
            // 
            addCustomer1.Location = new Point(0, 0);
            addCustomer1.Name = "addCustomer1";
            addCustomer1.Size = new Size(1250, 808);
            addCustomer1.TabIndex = 3;
            // 
            // addEmployee1
            // 
            addEmployee1.Location = new Point(0, 0);
            addEmployee1.Name = "addEmployee1";
            addEmployee1.Size = new Size(1250, 808);
            addEmployee1.TabIndex = 2;
            // 
            // addProduct1
            // 
            addProduct1.Location = new Point(0, 0);
            addProduct1.Name = "addProduct1";
            addProduct1.Size = new Size(1250, 808);
            addProduct1.TabIndex = 1;
            // 
            // addCash1
            // 
            addCash1.Location = new Point(0, 0);
            addCash1.Name = "addCash1";
            addCash1.Size = new Size(1250, 808);
            addCash1.TabIndex = 0;
            addCash1.Load += addCash1_Load;
            // 
            // MainForm
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(1231, 694);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MainForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button buttonDashboard;
        private Button buttonCustomers;
        private Button buttonProducts;
        private Button buttonCash;
        private Button buttonLogout;
        private Label label1;
        private Panel panel2;
        private Panel panel3;
        private AddCash addCash1;
        private Dashboard dashboard1;
        private AddCustomer addCustomer1;
        private AddEmployee addEmployee1;
        private AddProduct addProduct1;
        private Label labelexit;
        private Button button1;
    }
}