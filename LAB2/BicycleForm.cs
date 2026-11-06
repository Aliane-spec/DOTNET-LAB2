using System;
using System.Windows.Forms;

namespace LAB2
{
    public class BicycleForm : Form
    {
        public BicycleForm()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            if (!TryReadIntInRange(txtStart.Text, 0, 23, out int start))
            {
                MessageBox.Show("Invalid input. Enter an integer between 0 and 23.",
                                "Starting hour", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTotal.Text = "";
                return;
            }

            if (!TryReadIntInRange(txtEnd.Text, 1, 24, out int end))
            {
                MessageBox.Show("Invalid input. Enter an integer between 1 and 24.",
                                "Ending hour", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTotal.Text = "";
                return;
            }

            if (start >= end)
            {
                MessageBox.Show("Error: starting time must be less than ending time.",
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTotal.Text = "";
                return;
            }

            int total = 0;
            string details = "";

            for (int hour = start; hour < end; hour++)
            {
                int rate = RatePerHour(hour);
                total += rate;

                details += $"  Hour {hour}: {rate} RWF\n";
            }

            txtTotal.Text = $"{total:N0} RWF";

            MessageBox.Show(details + $"\nTotal amount to pay: {total:N0} RWF",
                            "BICYCLE RENTAL", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private bool TryReadIntInRange(string input, int min, int max, out int value)
        {
            if (int.TryParse(input, out value) && value >= min && value <= max)
            {
                return true;
            }

            return false;
        }

        private int RatePerHour(int hour)
        {
            if (hour >= 0 && hour < 7)
                return 500;

            if (hour >= 7 && hour < 14)
                return 1000;

            if (hour >= 14 && hour < 19)
                return 1500;

            if (hour >= 19 && hour < 21)
                return 1000;

            if (hour >= 21 && hour < 24)
                return 500;

            throw new ArgumentOutOfRangeException(nameof(hour), "Hour must be between 0 and 23.");
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            ChooseForm choose = new ChooseForm();
            choose.Show();
            this.Hide();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            LoginForm login = new LoginForm();
            login.Show();
            this.Hide();
        }

        private void BicycleForm_FormClosed(object sender, FormClosedEventArgs e)
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
            lblStart = new System.Windows.Forms.Label();
            txtStart = new System.Windows.Forms.TextBox();
            lblEnd = new System.Windows.Forms.Label();
            txtEnd = new System.Windows.Forms.TextBox();
            btnCalculate = new System.Windows.Forms.Button();
            lblTotal = new System.Windows.Forms.Label();
            txtTotal = new System.Windows.Forms.TextBox();
            btnBack = new System.Windows.Forms.Button();
            btnLogout = new System.Windows.Forms.Button();
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
            panelHeader.Size = new System.Drawing.Size(520, 70);
            panelHeader.TabIndex = 0;
            // 
            // lblHeader
            // 
            lblHeader.Dock = System.Windows.Forms.DockStyle.Fill;
            lblHeader.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            lblHeader.ForeColor = System.Drawing.Color.FromArgb(255, 248, 231);
            lblHeader.Location = new System.Drawing.Point(0, 0);
            lblHeader.Name = "lblHeader";
            lblHeader.Size = new System.Drawing.Size(520, 70);
            lblHeader.TabIndex = 0;
            lblHeader.Text = "BICYCLE RENTAL";
            lblHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblStart
            // 
            lblStart.AutoSize = true;
            lblStart.Font = new System.Drawing.Font("Segoe UI", 11F);
            lblStart.ForeColor = System.Drawing.Color.FromArgb(92, 58, 33);
            lblStart.Location = new System.Drawing.Point(40, 105);
            lblStart.Name = "lblStart";
            lblStart.Size = new System.Drawing.Size(170, 25);
            lblStart.TabIndex = 1;
            lblStart.Text = "Starting hour (0-23):";
            // 
            // txtStart
            // 
            txtStart.BackColor = System.Drawing.Color.White;
            txtStart.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            txtStart.Font = new System.Drawing.Font("Segoe UI", 11F);
            txtStart.ForeColor = System.Drawing.Color.FromArgb(92, 58, 33);
            txtStart.Location = new System.Drawing.Point(290, 101);
            txtStart.Name = "txtStart";
            txtStart.Size = new System.Drawing.Size(190, 27);
            txtStart.TabIndex = 2;
            // 
            // lblEnd
            // 
            lblEnd.AutoSize = true;
            lblEnd.Font = new System.Drawing.Font("Segoe UI", 11F);
            lblEnd.ForeColor = System.Drawing.Color.FromArgb(92, 58, 33);
            lblEnd.Location = new System.Drawing.Point(40, 160);
            lblEnd.Name = "lblEnd";
            lblEnd.Size = new System.Drawing.Size(160, 25);
            lblEnd.TabIndex = 3;
            lblEnd.Text = "Ending hour (1-24):";
            // 
            // txtEnd
            // 
            txtEnd.BackColor = System.Drawing.Color.White;
            txtEnd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            txtEnd.Font = new System.Drawing.Font("Segoe UI", 11F);
            txtEnd.ForeColor = System.Drawing.Color.FromArgb(92, 58, 33);
            txtEnd.Location = new System.Drawing.Point(290, 156);
            txtEnd.Name = "txtEnd";
            txtEnd.Size = new System.Drawing.Size(190, 27);
            txtEnd.TabIndex = 4;
            // 
            // btnCalculate
            // 
            btnCalculate.BackColor = System.Drawing.Color.FromArgb(92, 58, 33);
            btnCalculate.Cursor = System.Windows.Forms.Cursors.Hand;
            btnCalculate.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(92, 58, 33);
            btnCalculate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnCalculate.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            btnCalculate.ForeColor = System.Drawing.Color.FromArgb(255, 248, 231);
            btnCalculate.Location = new System.Drawing.Point(290, 215);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new System.Drawing.Size(190, 42);
            btnCalculate.TabIndex = 5;
            btnCalculate.Text = "Calculate";
            btnCalculate.UseVisualStyleBackColor = false;
            btnCalculate.Click += btnCalculate_Click;
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Font = new System.Drawing.Font("Segoe UI", 11F);
            lblTotal.ForeColor = System.Drawing.Color.FromArgb(92, 58, 33);
            lblTotal.Location = new System.Drawing.Point(40, 285);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new System.Drawing.Size(50, 25);
            lblTotal.TabIndex = 6;
            lblTotal.Text = "Total:";
            // 
            // txtTotal
            // 
            txtTotal.BackColor = System.Drawing.Color.White;
            txtTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            txtTotal.Font = new System.Drawing.Font("Segoe UI", 11F);
            txtTotal.ForeColor = System.Drawing.Color.FromArgb(92, 58, 33);
            txtTotal.Location = new System.Drawing.Point(290, 281);
            txtTotal.Name = "txtTotal";
            txtTotal.ReadOnly = true;
            txtTotal.Size = new System.Drawing.Size(190, 27);
            txtTotal.TabIndex = 7;
            // 
            // btnBack
            // 
            btnBack.BackColor = System.Drawing.Color.FromArgb(232, 217, 191);
            btnBack.Cursor = System.Windows.Forms.Cursors.Hand;
            btnBack.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(92, 58, 33);
            btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnBack.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            btnBack.ForeColor = System.Drawing.Color.FromArgb(92, 58, 33);
            btnBack.Location = new System.Drawing.Point(60, 355);
            btnBack.Name = "btnBack";
            btnBack.Size = new System.Drawing.Size(180, 42);
            btnBack.TabIndex = 8;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // btnLogout
            // 
            btnLogout.BackColor = System.Drawing.Color.FromArgb(232, 217, 191);
            btnLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            btnLogout.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(92, 58, 33);
            btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnLogout.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            btnLogout.ForeColor = System.Drawing.Color.FromArgb(92, 58, 33);
            btnLogout.Location = new System.Drawing.Point(280, 355);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new System.Drawing.Size(180, 42);
            btnLogout.TabIndex = 9;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.Click += btnLogout_Click;
            // 
            // BicycleForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            BackColor = System.Drawing.Color.FromArgb(255, 248, 231);
            ClientSize = new System.Drawing.Size(520, 430);
            Controls.Add(lblStart);
            Controls.Add(txtStart);
            Controls.Add(lblEnd);
            Controls.Add(txtEnd);
            Controls.Add(btnCalculate);
            Controls.Add(lblTotal);
            Controls.Add(txtTotal);
            Controls.Add(btnBack);
            Controls.Add(btnLogout);
            Controls.Add(panelHeader);
            Font = new System.Drawing.Font("Segoe UI", 11F);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            ForeColor = System.Drawing.Color.FromArgb(92, 58, 33);
            MaximizeBox = false;
            Name = "BicycleForm";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "BICYCLE RENTAL";
            FormClosed += BicycleForm_FormClosed;
            panelHeader.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.Label lblStart;
        private System.Windows.Forms.TextBox txtStart;
        private System.Windows.Forms.Label lblEnd;
        private System.Windows.Forms.TextBox txtEnd;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnLogout;
    }
}
