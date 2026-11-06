using System;
using System.Windows.Forms;

namespace LAB2
{
    public class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

            if (txtUsername.Text.Trim() == "" || txtPassword.Text.Trim() == "")
            {
                MessageBox.Show("Username and Password cannot be empty!", "Login Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {

                ChooseForm choose = new ChooseForm();
                choose.Show();
                this.Hide();
            }
        }

        private void LoginForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }


        private System.ComponentModel.IContainer components = null;

     
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            panelHeader = new System.Windows.Forms.Panel();
            lblHeader = new System.Windows.Forms.Label();
            lblUsername = new System.Windows.Forms.Label();
            txtUsername = new System.Windows.Forms.TextBox();
            lblPassword = new System.Windows.Forms.Label();
            txtPassword = new System.Windows.Forms.TextBox();
            btnLogin = new System.Windows.Forms.Button();
            panelHeader.SuspendLayout();
            SuspendLayout();
            // 
            // panelHeader
            // 
            panelHeader.BackColor = System.Drawing.Color.FromArgb(92, 58, 33);
            panelHeader.Controls.Add(lblHeader);
            panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            panelHeader.Location = new System.Drawing.Point(0, 0);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new System.Drawing.Size(460, 70);
            panelHeader.TabIndex = 0;
            // 
            // lblHeader
            // 
            lblHeader.Dock = System.Windows.Forms.DockStyle.Fill;
            lblHeader.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            lblHeader.ForeColor = System.Drawing.Color.FromArgb(255, 248, 231);
            lblHeader.Location = new System.Drawing.Point(0, 0);
            lblHeader.Name = "lblHeader";
            lblHeader.Size = new System.Drawing.Size(460, 70);
            lblHeader.TabIndex = 0;
            lblHeader.Text = "LOGIN";
            lblHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Font = new System.Drawing.Font("Segoe UI", 11F);
            lblUsername.ForeColor = System.Drawing.Color.FromArgb(92, 58, 33);
            lblUsername.Location = new System.Drawing.Point(40, 110);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new System.Drawing.Size(100, 25);
            lblUsername.TabIndex = 1;
            lblUsername.Text = "Username:";
            // 
            // txtUsername
            // 
            txtUsername.BackColor = System.Drawing.Color.White;
            txtUsername.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            txtUsername.Font = new System.Drawing.Font("Segoe UI", 11F);
            txtUsername.ForeColor = System.Drawing.Color.FromArgb(92, 58, 33);
            txtUsername.Location = new System.Drawing.Point(160, 106);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new System.Drawing.Size(260, 27);
            txtUsername.TabIndex = 2;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Font = new System.Drawing.Font("Segoe UI", 11F);
            lblPassword.ForeColor = System.Drawing.Color.FromArgb(92, 58, 33);
            lblPassword.Location = new System.Drawing.Point(40, 165);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new System.Drawing.Size(100, 25);
            lblPassword.TabIndex = 3;
            lblPassword.Text = "Password:";
            // 
            // txtPassword
            // 
            txtPassword.BackColor = System.Drawing.Color.White;
            txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            txtPassword.Font = new System.Drawing.Font("Segoe UI", 11F);
            txtPassword.ForeColor = System.Drawing.Color.FromArgb(92, 58, 33);
            txtPassword.Location = new System.Drawing.Point(160, 161);
            txtPassword.Name = "txtPassword";
            txtPassword.UseSystemPasswordChar = true;
            txtPassword.Size = new System.Drawing.Size(260, 27);
            txtPassword.TabIndex = 4;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = System.Drawing.Color.FromArgb(92, 58, 33);
            btnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            btnLogin.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(92, 58, 33);
            btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnLogin.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            btnLogin.ForeColor = System.Drawing.Color.FromArgb(255, 248, 231);
            btnLogin.Location = new System.Drawing.Point(160, 225);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new System.Drawing.Size(260, 42);
            btnLogin.TabIndex = 5;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            AcceptButton = btnLogin;
            BackColor = System.Drawing.Color.FromArgb(255, 248, 231);
            ClientSize = new System.Drawing.Size(460, 320);
            Controls.Add(lblUsername);
            Controls.Add(txtUsername);
            Controls.Add(lblPassword);
            Controls.Add(txtPassword);
            Controls.Add(btnLogin);
            Controls.Add(panelHeader);
            Font = new System.Drawing.Font("Segoe UI", 11F);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            ForeColor = System.Drawing.Color.FromArgb(92, 58, 33);
            MaximizeBox = false;
            Name = "LoginForm";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Login";
            FormClosed += LoginForm_FormClosed;
            panelHeader.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnLogin;
    }
}
