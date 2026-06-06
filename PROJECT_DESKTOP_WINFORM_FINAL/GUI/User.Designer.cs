namespace PROJECT_DESKTOP_WINFORM_FINAL.GUI
{
    partial class User
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
            label2 = new Label();
            label1 = new Label();
            panel1 = new Panel();
            btnPostWatch = new Button();
            btnLogout = new Button();
            btnProfile = new Button();
            panel2 = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(255, 112, 67);
            label2.Location = new Point(132, 54);
            label2.Name = "label2";
            label2.Size = new Size(166, 48);
            label2.TabIndex = 4;
            label2.Text = "BẢN TIN";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(174, 48);
            label1.TabIndex = 3;
            label1.Text = "QUẢN LÝ";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 114, 118);
            panel1.Controls.Add(btnPostWatch);
            panel1.Controls.Add(btnLogout);
            panel1.Controls.Add(btnProfile);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1021, 198);
            panel1.TabIndex = 1;
            // 
            // btnPostWatch
            // 
            btnPostWatch.BackColor = Color.FromArgb(0, 114, 118);
            btnPostWatch.FlatAppearance.BorderSize = 0;
            btnPostWatch.FlatStyle = FlatStyle.Flat;
            btnPostWatch.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnPostWatch.ForeColor = Color.White;
            btnPostWatch.Location = new Point(0, 119);
            btnPostWatch.Name = "btnPostWatch";
            btnPostWatch.Size = new Size(133, 79);
            btnPostWatch.TabIndex = 9;
            btnPostWatch.Text = "Xem\r\nbản tin\r\n";
            btnPostWatch.UseVisualStyleBackColor = false;
            btnPostWatch.Click += btnPostWatch_Click;
            btnPostWatch.MouseEnter += btnNav_MouseEnter;
            btnPostWatch.MouseLeave += btnNav_MouseLeave;
            // 
            // btnLogout
            // 
            btnLogout.BackColor = Color.FromArgb(0, 114, 118);
            btnLogout.FlatAppearance.BorderSize = 0;
            btnLogout.FlatStyle = FlatStyle.Flat;
            btnLogout.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnLogout.ForeColor = Color.White;
            btnLogout.Location = new Point(888, 119);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(133, 79);
            btnLogout.TabIndex = 9;
            btnLogout.Text = "Đăng xuất";
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.Click += btnLogout_Click;
            btnLogout.MouseEnter += btnNav_MouseEnter;
            btnLogout.MouseLeave += btnNav_MouseLeave;
            // 
            // btnProfile
            // 
            btnProfile.BackColor = Color.FromArgb(0, 114, 118);
            btnProfile.FlatAppearance.BorderSize = 0;
            btnProfile.FlatStyle = FlatStyle.Flat;
            btnProfile.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnProfile.ForeColor = Color.White;
            btnProfile.Location = new Point(132, 119);
            btnProfile.Name = "btnProfile";
            btnProfile.Size = new Size(133, 79);
            btnProfile.TabIndex = 8;
            btnProfile.Text = "Hồ sơ";
            btnProfile.UseVisualStyleBackColor = false;
            btnProfile.Click += btnProfile_Click;
            btnProfile.MouseEnter += btnNav_MouseEnter;
            btnProfile.MouseLeave += btnNav_MouseLeave;
            // 
            // panel2
            // 
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 198);
            panel2.Name = "panel2";
            panel2.Size = new Size(1021, 355);
            panel2.TabIndex = 2;
            // 
            // User
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1021, 553);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "User";
            Text = "User";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label2;
        private Label label1;
        private Panel panel1;
        private Button btnLogout;
        private Button btnProfile;
        private Button btnPostWatch;
        private Panel panel2;
    }
}