using System;
using System.Windows.Forms;

namespace LAB2
{
    public class ChooseForm : Form
    {
        public ChooseForm()
        {
            InitializeComponent();
        }

        private void btnBicycle_Click(object sender, EventArgs e)
        {
            BicycleForm bicycle = new BicycleForm();
            bicycle.Show();
            this.Hide();
        }

        private void btnMushroom_Click(object sender, EventArgs e)
        {
            MushroomForm mushroom = new MushroomForm();
            mushroom.Show();
            this.Hide();
        }

        private void ChooseForm_FormClosed(object sender, FormClosedEventArgs e)
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
            lblTitle = new System.Windows.Forms.Label();
            btnBicycle = new System.Windows.Forms.Button();
            btnMushroom = new System.Windows.Forms.Button();
            panelHeader.SuspendLayout();
            SuspendLayout();
           
            panelHeader.BackColor = System.Drawing.Color.FromArgb(92, 58, 33);
            panelHeader.Controls.Add(lblHeader);
            panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            panelHeader.Location = new System.Drawing.Point(0, 0);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new System.Drawing.Size(480, 70);
            panelHeader.TabIndex = 0;
           
            lblHeader.Dock = System.Windows.Forms.DockStyle.Fill;
            lblHeader.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            lblHeader.ForeColor = System.Drawing.Color.FromArgb(255, 248, 231);
            lblHeader.Location = new System.Drawing.Point(0, 0);
            lblHeader.Name = "lblHeader";
            lblHeader.Size = new System.Drawing.Size(480, 70);
            lblHeader.TabIndex = 0;
            lblHeader.Text = "CHOOSE";
            lblHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
           
            lblTitle.AutoSize = false;
            lblTitle.Font = new System.Drawing.Font("Segoe UI", 13F);
            lblTitle.ForeColor = System.Drawing.Color.FromArgb(92, 58, 33);
            lblTitle.Location = new System.Drawing.Point(0, 100);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new System.Drawing.Size(480, 40);
            lblTitle.TabIndex = 1;
            lblTitle.Text = "What do you want to do?";
            lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
          
            btnBicycle.BackColor = System.Drawing.Color.FromArgb(92, 58, 33);
            btnBicycle.Cursor = System.Windows.Forms.Cursors.Hand;
            btnBicycle.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(92, 58, 33);
            btnBicycle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnBicycle.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            btnBicycle.ForeColor = System.Drawing.Color.FromArgb(255, 248, 231);
            btnBicycle.Location = new System.Drawing.Point(60, 170);
            btnBicycle.Name = "btnBicycle";
            btnBicycle.Size = new System.Drawing.Size(160, 42);
            btnBicycle.TabIndex = 2;
            btnBicycle.Text = "Bicycle";
            btnBicycle.UseVisualStyleBackColor = false;
            btnBicycle.Click += btnBicycle_Click;
           
            btnMushroom.BackColor = System.Drawing.Color.FromArgb(92, 58, 33);
            btnMushroom.Cursor = System.Windows.Forms.Cursors.Hand;
            btnMushroom.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(92, 58, 33);
            btnMushroom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnMushroom.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            btnMushroom.ForeColor = System.Drawing.Color.FromArgb(255, 248, 231);
            btnMushroom.Location = new System.Drawing.Point(260, 170);
            btnMushroom.Name = "btnMushroom";
            btnMushroom.Size = new System.Drawing.Size(160, 42);
            btnMushroom.TabIndex = 3;
            btnMushroom.Text = "Mushroom";
            btnMushroom.UseVisualStyleBackColor = false;
            btnMushroom.Click += btnMushroom_Click;
           
            AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            BackColor = System.Drawing.Color.FromArgb(255, 248, 231);
            ClientSize = new System.Drawing.Size(480, 290);
            Controls.Add(lblTitle);
            Controls.Add(btnBicycle);
            Controls.Add(btnMushroom);
            Controls.Add(panelHeader);
            Font = new System.Drawing.Font("Segoe UI", 11F);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            ForeColor = System.Drawing.Color.FromArgb(92, 58, 33);
            MaximizeBox = false;
            Name = "ChooseForm";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Choose";
            FormClosed += ChooseForm_FormClosed;
            panelHeader.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnBicycle;
        private System.Windows.Forms.Button btnMushroom;
    }
}
