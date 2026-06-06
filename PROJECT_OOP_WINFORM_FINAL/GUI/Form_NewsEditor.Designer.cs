namespace PROJECT_DESKTOP_WINFORM_FINAL.GUI
{
    partial class Form_NewsEditor
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
            txtTitle = new TextBox();
            cboCategory = new ComboBox();
            label3 = new Label();
            dtpBroadcastTime = new DateTimePicker();
            label4 = new Label();
            txtVideoLink = new TextBox();
            label5 = new Label();
            rtbContent = new RichTextBox();
            btnSave = new Button();
            btnCancel = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(60, 65);
            label1.Name = "label1";
            label1.Size = new Size(111, 28);
            label1.TabIndex = 0;
            label1.Text = "Tên bản tin:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(60, 109);
            label2.Name = "label2";
            label2.Size = new Size(118, 28);
            label2.TabIndex = 1;
            label2.Text = "Loại bản tin:";
            // 
            // txtTitle
            // 
            txtTitle.Location = new Point(255, 59);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(566, 34);
            txtTitle.TabIndex = 2;
            // 
            // cboCategory
            // 
            cboCategory.FormattingEnabled = true;
            cboCategory.Items.AddRange(new object[] { "Bản tin Thời sự hàng ngày", "Bản tin Khẩn cấp / Tin nóng", "Phóng sự hiện trường", "Tạp chí Truyền hình" });
            cboCategory.Location = new Point(255, 106);
            cboCategory.Name = "cboCategory";
            cboCategory.Size = new Size(235, 36);
            cboCategory.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(60, 155);
            label3.Name = "label3";
            label3.Size = new Size(190, 28);
            label3.TabIndex = 4;
            label3.Text = "Thời gian phát sóng:";
            // 
            // dtpBroadcastTime
            // 
            dtpBroadcastTime.CustomFormat = "dd/MM/yyyy HH:mm";
            dtpBroadcastTime.Format = DateTimePickerFormat.Custom;
            dtpBroadcastTime.Location = new Point(255, 155);
            dtpBroadcastTime.Name = "dtpBroadcastTime";
            dtpBroadcastTime.Size = new Size(300, 34);
            dtpBroadcastTime.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(60, 201);
            label4.Name = "label4";
            label4.Size = new Size(105, 28);
            label4.TabIndex = 6;
            label4.Text = "Link video:";
            // 
            // txtVideoLink
            // 
            txtVideoLink.Location = new Point(255, 201);
            txtVideoLink.Name = "txtVideoLink";
            txtVideoLink.Size = new Size(566, 34);
            txtVideoLink.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(60, 256);
            label5.Name = "label5";
            label5.Size = new Size(165, 28);
            label5.TabIndex = 8;
            label5.Text = "Nội dung bản tin:";
            // 
            // rtbContent
            // 
            rtbContent.Location = new Point(255, 256);
            rtbContent.Name = "rtbContent";
            rtbContent.Size = new Size(610, 257);
            rtbContent.TabIndex = 9;
            rtbContent.Text = "";
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.FromArgb(0, 114, 118);
            btnSave.FlatAppearance.BorderSize = 0;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSave.ForeColor = Color.White;
            btnSave.Location = new Point(788, 4);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(112, 42);
            btnSave.TabIndex = 10;
            btnSave.Text = "Đăng";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.FromArgb(198, 40, 40);
            btnCancel.FlatAppearance.BorderSize = 0;
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancel.ForeColor = Color.White;
            btnCancel.Location = new Point(906, 4);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(112, 42);
            btnCancel.TabIndex = 11;
            btnCancel.Text = "Huỷ";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // Form_NewsEditor
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1021, 553);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(rtbContent);
            Controls.Add(label5);
            Controls.Add(txtVideoLink);
            Controls.Add(label4);
            Controls.Add(dtpBroadcastTime);
            Controls.Add(label3);
            Controls.Add(cboCategory);
            Controls.Add(txtTitle);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form_NewsEditor";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form_NewsEditor";
            Load += Form_NewsEditor_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtTitle;
        private ComboBox cboCategory;
        private Label label3;
        private DateTimePicker dtpBroadcastTime;
        private Label label4;
        private TextBox txtVideoLink;
        private Label label5;
        private RichTextBox rtbContent;
        private Button btnSave;
        private Button btnCancel;
    }
}