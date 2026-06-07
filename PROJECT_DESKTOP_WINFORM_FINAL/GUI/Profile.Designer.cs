namespace PROJECT_DESKTOP_WINFORM_FINAL.GUI
{
    partial class Profile
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
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtName = new TextBox();
            txtEmail = new TextBox();
            txtRole = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(255, 112, 67);
            label1.Location = new Point(42, 30);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(333, 38);
            label1.TabIndex = 1;
            label1.Text = "THÔNG TIN TÀI KHOẢN";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(42, 99);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(117, 25);
            label2.TabIndex = 2;
            label2.Text = "Tên hiển thị:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(42, 151);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(68, 25);
            label3.TabIndex = 3;
            label3.Text = "Email: ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(42, 201);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(73, 25);
            label4.TabIndex = 4;
            label4.Text = "Vai trò:";
            // 
            // txtName
            // 
            txtName.BackColor = Color.White;
            txtName.Location = new Point(179, 90);
            txtName.Margin = new Padding(4, 4, 4, 4);
            txtName.Name = "txtName";
            txtName.ReadOnly = true;
            txtName.Size = new Size(353, 31);
            txtName.TabIndex = 6;
            // 
            // txtEmail
            // 
            txtEmail.BackColor = Color.White;
            txtEmail.Location = new Point(179, 142);
            txtEmail.Margin = new Padding(4, 4, 4, 4);
            txtEmail.Name = "txtEmail";
            txtEmail.ReadOnly = true;
            txtEmail.Size = new Size(353, 31);
            txtEmail.TabIndex = 7;
            // 
            // txtRole
            // 
            txtRole.BackColor = Color.White;
            txtRole.Location = new Point(179, 192);
            txtRole.Margin = new Padding(4, 4, 4, 4);
            txtRole.Name = "txtRole";
            txtRole.ReadOnly = true;
            txtRole.Size = new Size(353, 31);
            txtRole.TabIndex = 8;
            // 
            // Profile
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1231, 619);
            Controls.Add(txtRole);
            Controls.Add(txtEmail);
            Controls.Add(txtName);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(4, 4, 4, 4);
            Name = "Profile";
            Text = "Profile";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtName;
        private TextBox txtEmail;
        private TextBox txtRole;
    }
}