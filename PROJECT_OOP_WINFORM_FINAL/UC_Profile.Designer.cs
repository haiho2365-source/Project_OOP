namespace PROJECT_OOP_WINFORM_FINAL
{
    partial class UC_Profile
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

        #region Component Designer generated code

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
            lblExtra = new Label();
            txtName = new TextBox();
            txtEmail = new TextBox();
            txtRole = new TextBox();
            txtExtraInfo = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(333, 38);
            label1.TabIndex = 0;
            label1.Text = "THÔNG TIN TÀI KHOẢN";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(3, 59);
            label2.Name = "label2";
            label2.Size = new Size(111, 28);
            label2.TabIndex = 1;
            label2.Text = "Tên hiển thị";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(3, 99);
            label3.Name = "label3";
            label3.Size = new Size(59, 28);
            label3.TabIndex = 2;
            label3.Text = "Email";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(3, 139);
            label4.Name = "label4";
            label4.Size = new Size(69, 28);
            label4.TabIndex = 3;
            label4.Text = "Vai trò";
            // 
            // lblExtra
            // 
            lblExtra.AutoSize = true;
            lblExtra.Location = new Point(3, 180);
            lblExtra.Name = "lblExtra";
            lblExtra.Size = new Size(65, 28);
            lblExtra.TabIndex = 4;
            lblExtra.Text = "label5";
            // 
            // txtName
            // 
            txtName.BackColor = Color.White;
            txtName.Location = new Point(120, 56);
            txtName.Name = "txtName";
            txtName.ReadOnly = true;
            txtName.Size = new Size(283, 34);
            txtName.TabIndex = 5;
            // 
            // txtEmail
            // 
            txtEmail.BackColor = Color.White;
            txtEmail.Location = new Point(120, 96);
            txtEmail.Name = "txtEmail";
            txtEmail.ReadOnly = true;
            txtEmail.Size = new Size(283, 34);
            txtEmail.TabIndex = 6;
            // 
            // txtRole
            // 
            txtRole.BackColor = Color.White;
            txtRole.Location = new Point(120, 136);
            txtRole.Name = "txtRole";
            txtRole.ReadOnly = true;
            txtRole.Size = new Size(283, 34);
            txtRole.TabIndex = 7;
            // 
            // txtExtraInfo
            // 
            txtExtraInfo.BackColor = Color.White;
            txtExtraInfo.Location = new Point(120, 180);
            txtExtraInfo.Name = "txtExtraInfo";
            txtExtraInfo.ReadOnly = true;
            txtExtraInfo.Size = new Size(283, 34);
            txtExtraInfo.TabIndex = 8;
            // 
            // UC_Profile
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(txtExtraInfo);
            Controls.Add(txtRole);
            Controls.Add(txtEmail);
            Controls.Add(txtName);
            Controls.Add(lblExtra);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Name = "UC_Profile";
            Size = new Size(1043, 609);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label lblExtra;
        private TextBox txtName;
        private TextBox txtEmail;
        private TextBox txtRole;
        private TextBox txtExtraInfo;
    }
}
