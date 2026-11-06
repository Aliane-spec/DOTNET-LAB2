using System;
using System.Windows.Forms;

namespace LAB2
{
    public class MushroomForm : Form
    {
        public MushroomForm()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            bool hasRing = AskYesNo("Q1. Does your mushroom have a ring? ");

            if (hasRing)
            {
                bool growsInForest = AskYesNo("Q2. Does your mushroom grow in a forest? ");

                if (growsInForest)
                {
                    PrintMushroom("Amanite tue-mouche");
                }
                else
                {
                    bool hasConvexCup = AskYesNo("Q3. Does your mushroom have a convex cup? ");

                    if (hasConvexCup)
                        PrintMushroom("Agaric Jaunissant");
                    else
                        PrintMushroom("Coprin chevelu");
                }
            }
            else
            {
                bool hasGills = AskYesNo("Q2. Does your mushroom have gills? ");

                if (!hasGills)
                {
                    PrintMushroom("Cepe de bordeau");
                }
                else
                {
                    bool hasConvexCup = AskYesNo("Q3. Does your mushroom have a convex cup? ");

                    if (hasConvexCup)
                        PrintMushroom("Pied bleu");
                    else
                        PrintMushroom("Girolle");
                }
            }
        }

        private bool AskYesNo(string question)
        {
            DialogResult answer = MessageBox.Show(question, "MUSHROOM IDENTIFIER",
                                                  MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (answer == DialogResult.Yes)
                return true;

            return false;
        }

        private void PrintMushroom(string mushroom)
        {
            MessageBox.Show($"Your mushroom is: {mushroom}", "Result",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void MushroomForm_FormClosed(object sender, FormClosedEventArgs e)
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
            lblList = new System.Windows.Forms.Label();
            lblInfo = new System.Windows.Forms.Label();
            btnStart = new System.Windows.Forms.Button();
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
            panelHeader.Size = new System.Drawing.Size(560, 70);
            panelHeader.TabIndex = 0;
            // 
            // lblHeader
            // 
            lblHeader.Dock = System.Windows.Forms.DockStyle.Fill;
            lblHeader.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            lblHeader.ForeColor = System.Drawing.Color.FromArgb(255, 248, 231);
            lblHeader.Location = new System.Drawing.Point(0, 0);
            lblHeader.Name = "lblHeader";
            lblHeader.Size = new System.Drawing.Size(560, 70);
            lblHeader.TabIndex = 0;
            lblHeader.Text = "MUSHROOM IDENTIFIER";
            lblHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblList
            // 
            lblList.AutoSize = true;
            lblList.Font = new System.Drawing.Font("Segoe UI", 11F);
            lblList.ForeColor = System.Drawing.Color.FromArgb(92, 58, 33);
            lblList.Location = new System.Drawing.Point(60, 100);
            lblList.Name = "lblList";
            lblList.Size = new System.Drawing.Size(290, 150);
            lblList.TabIndex = 1;
            lblList.Text = "Think of one of these mushrooms:\n  1. Agaric Jaunissant\n  2. Amanite tue-mouche\n  3. Cepe de bordeau\n  4. Coprin chevelu\n  5. Girolle\n  6. Pied bleu";
            // 
            // lblInfo
            // 
            lblInfo.AutoSize = true;
            lblInfo.Font = new System.Drawing.Font("Segoe UI", 11F);
            lblInfo.ForeColor = System.Drawing.Color.FromArgb(92, 58, 33);
            lblInfo.Location = new System.Drawing.Point(60, 295);
            lblInfo.Name = "lblInfo";
            lblInfo.Size = new System.Drawing.Size(400, 25);
            lblInfo.TabIndex = 2;
            lblInfo.Text = "Click Start and answer each question with Yes or No.";
            // 
            // btnStart
            // 
            btnStart.BackColor = System.Drawing.Color.FromArgb(92, 58, 33);
            btnStart.Cursor = System.Windows.Forms.Cursors.Hand;
            btnStart.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(92, 58, 33);
            btnStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnStart.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            btnStart.ForeColor = System.Drawing.Color.FromArgb(255, 248, 231);
            btnStart.Location = new System.Drawing.Point(180, 345);
            btnStart.Name = "btnStart";
            btnStart.Size = new System.Drawing.Size(200, 42);
            btnStart.TabIndex = 3;
            btnStart.Text = "Start";
            btnStart.UseVisualStyleBackColor = false;
            btnStart.Click += btnStart_Click;
            // 
            // btnBack
            // 
            btnBack.BackColor = System.Drawing.Color.FromArgb(232, 217, 191);
            btnBack.Cursor = System.Windows.Forms.Cursors.Hand;
            btnBack.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(92, 58, 33);
            btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnBack.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            btnBack.ForeColor = System.Drawing.Color.FromArgb(92, 58, 33);
            btnBack.Location = new System.Drawing.Point(80, 425);
            btnBack.Name = "btnBack";
            btnBack.Size = new System.Drawing.Size(180, 42);
            btnBack.TabIndex = 4;
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
            btnLogout.Location = new System.Drawing.Point(300, 425);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new System.Drawing.Size(180, 42);
            btnLogout.TabIndex = 5;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.Click += btnLogout_Click;
            // 
            // MushroomForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            BackColor = System.Drawing.Color.FromArgb(255, 248, 231);
            ClientSize = new System.Drawing.Size(560, 500);
            Controls.Add(lblList);
            Controls.Add(lblInfo);
            Controls.Add(btnStart);
            Controls.Add(btnBack);
            Controls.Add(btnLogout);
            Controls.Add(panelHeader);
            Font = new System.Drawing.Font("Segoe UI", 11F);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            ForeColor = System.Drawing.Color.FromArgb(92, 58, 33);
            MaximizeBox = false;
            Name = "MushroomForm";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "MUSHROOM IDENTIFIER";
            FormClosed += MushroomForm_FormClosed;
            panelHeader.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.Label lblList;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnLogout;
    }
}
