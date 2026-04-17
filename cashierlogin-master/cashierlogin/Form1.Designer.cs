namespace cashierlogin
{
    partial class Form1
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
            label1 = new Label();
            label2 = new Label();
            txtUsername = new TextBox();
            txtPassword = new TextBox();
            btnLogin = new Button();
            btnRegister = new Button();
            label3 = new Label();
            cmbRole = new ComboBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(110, 34);
            label1.Name = "label1";
            label1.Size = new Size(260, 45);
            label1.TabIndex = 0;
            label1.Text = "CASHIER LOGIN";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(46, 107);
            label2.Name = "label2";
            label2.Size = new Size(73, 17);
            label2.TabIndex = 1;
            label2.Text = "Username:";
            label2.Click += label2_Click;
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(121, 104);
            txtUsername.Margin = new Padding(3, 2, 3, 2);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(249, 25);
            txtUsername.TabIndex = 2;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(121, 151);
            txtPassword.Margin = new Padding(3, 2, 3, 2);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(249, 25);
            txtPassword.TabIndex = 3;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.Blue;
            btnLogin.ForeColor = SystemColors.Control;
            btnLogin.Location = new Point(121, 235);
            btnLogin.Margin = new Padding(3, 2, 3, 2);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(120, 39);
            btnLogin.TabIndex = 4;
            btnLogin.Text = "LOGIN";
            btnLogin.UseVisualStyleBackColor = false;
            // 
            // btnRegister
            // 
            btnRegister.BackColor = Color.Green;
            btnRegister.ForeColor = SystemColors.Control;
            btnRegister.Location = new Point(250, 235);
            btnRegister.Margin = new Padding(3, 2, 3, 2);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(120, 39);
            btnRegister.TabIndex = 5;
            btnRegister.Text = "REGISTER";
            btnRegister.UseVisualStyleBackColor = false;
            btnRegister.Click += button2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(49, 154);
            label3.Name = "label3";
            label3.Size = new Size(70, 17);
            label3.TabIndex = 6;
            label3.Text = "Password:";
            label3.Click += label3_Click;
            // 
            // cmbRole
            // 
            cmbRole.FormattingEnabled = true;
            cmbRole.Items.AddRange(new object[] { "Admin", "Emplooyee" });
            cmbRole.Location = new Point(121, 191);
            cmbRole.Margin = new Padding(3, 2, 3, 2);
            cmbRole.Name = "cmbRole";
            cmbRole.Size = new Size(249, 25);
            cmbRole.TabIndex = 7;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DodgerBlue;
            ClientSize = new Size(482, 334);
            Controls.Add(cmbRole);
            Controls.Add(label3);
            Controls.Add(btnRegister);
            Controls.Add(btnLogin);
            Controls.Add(txtPassword);
            Controls.Add(txtUsername);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtUsername;
        private TextBox txtPassword;
        private Button btnLogin;
        private Button btnRegister;
        private Label label3;
        private ComboBox cmbRole;
    }
}
