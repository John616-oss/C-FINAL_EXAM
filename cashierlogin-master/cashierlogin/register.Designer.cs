namespace cashierlogin
{
    partial class register
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
            lblFirstname = new Label();
            lblLastname = new Label();
            lblUsername = new Label();
            txtFirstname = new TextBox();
            txtLastname = new TextBox();
            txtUsername = new TextBox();
            btnCreate = new Button();
            lblPassword = new Label();
            txtRole = new Label();
            txtPassword = new TextBox();
            cmbRole = new ComboBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(266, 32);
            label1.Name = "label1";
            label1.Size = new Size(191, 39);
            label1.TabIndex = 0;
            label1.Text = "REGISTER ";
            // 
            // lblFirstname
            // 
            lblFirstname.AutoSize = true;
            lblFirstname.Location = new Point(93, 98);
            lblFirstname.Name = "lblFirstname";
            lblFirstname.Size = new Size(73, 17);
            lblFirstname.TabIndex = 1;
            lblFirstname.Text = "Firstname:";
            lblFirstname.Click += label2_Click;
            // 
            // lblLastname
            // 
            lblLastname.AutoSize = true;
            lblLastname.Location = new Point(95, 136);
            lblLastname.Name = "lblLastname";
            lblLastname.Size = new Size(71, 17);
            lblLastname.TabIndex = 2;
            lblLastname.Text = "Lastname:";
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Location = new Point(93, 175);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(73, 17);
            lblUsername.TabIndex = 3;
            lblUsername.Text = "Username:";
            // 
            // txtFirstname
            // 
            txtFirstname.Location = new Point(181, 95);
            txtFirstname.Margin = new Padding(3, 2, 3, 2);
            txtFirstname.Name = "txtFirstname";
            txtFirstname.PlaceholderText = "First name";
            txtFirstname.Size = new Size(342, 25);
            txtFirstname.TabIndex = 4;
            // 
            // txtLastname
            // 
            txtLastname.Location = new Point(181, 133);
            txtLastname.Margin = new Padding(3, 2, 3, 2);
            txtLastname.Name = "txtLastname";
            txtLastname.PlaceholderText = "Last Name";
            txtLastname.Size = new Size(342, 25);
            txtLastname.TabIndex = 5;
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(183, 172);
            txtUsername.Margin = new Padding(3, 2, 3, 2);
            txtUsername.Name = "txtUsername";
            txtUsername.PlaceholderText = "Username";
            txtUsername.Size = new Size(342, 25);
            txtUsername.TabIndex = 6;
            // 
            // btnCreate
            // 
            btnCreate.BackColor = Color.Blue;
            btnCreate.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCreate.ForeColor = SystemColors.Control;
            btnCreate.Location = new Point(181, 304);
            btnCreate.Margin = new Padding(3, 2, 3, 2);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(344, 45);
            btnCreate.TabIndex = 8;
            btnCreate.Text = "REGISTER";
            btnCreate.UseVisualStyleBackColor = false;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Location = new Point(93, 213);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(70, 17);
            lblPassword.TabIndex = 9;
            lblPassword.Text = "Password:";
            lblPassword.Click += lblPassword_Click;
            // 
            // txtRole
            // 
            txtRole.AutoSize = true;
            txtRole.Location = new Point(124, 259);
            txtRole.Name = "txtRole";
            txtRole.Size = new Size(39, 17);
            txtRole.TabIndex = 10;
            txtRole.Text = "Role:";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(181, 210);
            txtPassword.Margin = new Padding(3, 2, 3, 2);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '•';
            txtPassword.PlaceholderText = "Password";
            txtPassword.Size = new Size(342, 25);
            txtPassword.TabIndex = 11;
            // 
            // cmbRole
            // 
            cmbRole.FormattingEnabled = true;
            cmbRole.Items.AddRange(new object[] { "Admin", "Employee" });
            cmbRole.Location = new Point(181, 256);
            cmbRole.Margin = new Padding(3, 2, 3, 2);
            cmbRole.Name = "cmbRole";
            cmbRole.Size = new Size(342, 25);
            cmbRole.TabIndex = 12;
            // 
            // register
            // 
            AutoScaleDimensions = new SizeF(8F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DodgerBlue;
            ClientSize = new Size(661, 424);
            Controls.Add(cmbRole);
            Controls.Add(txtPassword);
            Controls.Add(txtRole);
            Controls.Add(lblPassword);
            Controls.Add(btnCreate);
            Controls.Add(txtUsername);
            Controls.Add(txtLastname);
            Controls.Add(txtFirstname);
            Controls.Add(lblUsername);
            Controls.Add(lblLastname);
            Controls.Add(lblFirstname);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Margin = new Padding(3, 2, 3, 2);
            Name = "register";
            Text = "register";
            Load += register_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label lblFirstname;
        private Label lblLastname;
        private Label lblUsername;
        private TextBox txtFirstname;
        private TextBox txtLastname;
        private TextBox txtUsername;
        private Button btnCreate;
        private Label lblPassword;
        private Label txtRole;
        private TextBox txtPassword;
        private ComboBox cmbRole;
    }
}