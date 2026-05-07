namespace PROJECT_OOP_WINFORM_FINAL
{
    partial class UC_NewsManager
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
            btnApprove = new Button();
            btnDelete = new Button();
            dgvNews = new DataGridView();
            rtbContent = new RichTextBox();
            cbFilter = new ComboBox();
            btnFilter = new Button();
            btnCloseContent = new Button();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            cbTimeFilter = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dgvNews).BeginInit();
            SuspendLayout();
            // 
            // btnApprove
            // 
            btnApprove.BackColor = Color.FromArgb(76, 175, 80);
            btnApprove.FlatStyle = FlatStyle.Flat;
            btnApprove.ForeColor = Color.White;
            btnApprove.Location = new Point(592, 41);
            btnApprove.Name = "btnApprove";
            btnApprove.Size = new Size(112, 55);
            btnApprove.TabIndex = 18;
            btnApprove.Text = "Duyệt";
            btnApprove.UseVisualStyleBackColor = false;
            btnApprove.Click += btnApprove_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.FromArgb(198, 40, 40);
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.ForeColor = Color.White;
            btnDelete.Location = new Point(710, 41);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(112, 55);
            btnDelete.TabIndex = 17;
            btnDelete.Text = "Xoá";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // dgvNews
            // 
            dgvNews.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvNews.BackgroundColor = Color.White;
            dgvNews.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvNews.Location = new Point(1, 98);
            dgvNews.Name = "dgvNews";
            dgvNews.ReadOnly = true;
            dgvNews.RowHeadersWidth = 62;
            dgvNews.Size = new Size(1043, 509);
            dgvNews.TabIndex = 10;
            dgvNews.CellClick += dgvNews_CellClick;
            // 
            // rtbContent
            // 
            rtbContent.BackColor = Color.White;
            rtbContent.Location = new Point(262, 41);
            rtbContent.Name = "rtbContent";
            rtbContent.ReadOnly = true;
            rtbContent.Size = new Size(678, 470);
            rtbContent.TabIndex = 19;
            rtbContent.Text = "";
            rtbContent.TextChanged += rtbContent_TextChanged;
            // 
            // cbFilter
            // 
            cbFilter.FormattingEnabled = true;
            cbFilter.Location = new Point(3, 60);
            cbFilter.Name = "cbFilter";
            cbFilter.Size = new Size(286, 36);
            cbFilter.TabIndex = 21;
            // 
            // btnFilter
            // 
            btnFilter.BackColor = Color.White;
            btnFilter.FlatStyle = FlatStyle.Flat;
            btnFilter.Location = new Point(589, 62);
            btnFilter.Name = "btnFilter";
            btnFilter.Size = new Size(112, 34);
            btnFilter.TabIndex = 22;
            btnFilter.Text = "Lọc";
            btnFilter.UseVisualStyleBackColor = false;
            btnFilter.Click += btnFilter_Click;
            // 
            // btnCloseContent
            // 
            btnCloseContent.BackColor = Color.FromArgb(255, 112, 67);
            btnCloseContent.FlatStyle = FlatStyle.Flat;
            btnCloseContent.ForeColor = Color.White;
            btnCloseContent.Location = new Point(828, 41);
            btnCloseContent.Name = "btnCloseContent";
            btnCloseContent.Size = new Size(112, 55);
            btnCloseContent.TabIndex = 23;
            btnCloseContent.Text = "Đóng";
            btnCloseContent.UseVisualStyleBackColor = false;
            btnCloseContent.Click += btnCloseContent_Click;
            // 
            // cbTimeFilter
            // 
            cbTimeFilter.FormattingEnabled = true;
            cbTimeFilter.Location = new Point(295, 60);
            cbTimeFilter.Name = "cbTimeFilter";
            cbTimeFilter.Size = new Size(288, 36);
            cbTimeFilter.TabIndex = 24;
            // 
            // UC_NewsManager
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnDelete);
            Controls.Add(btnCloseContent);
            Controls.Add(btnApprove);
            Controls.Add(rtbContent);
            Controls.Add(btnFilter);
            Controls.Add(dgvNews);
            Controls.Add(cbFilter);
            Controls.Add(cbTimeFilter);
            Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Name = "UC_NewsManager";
            Size = new Size(1043, 609);
            ((System.ComponentModel.ISupportInitialize)dgvNews).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnApprove;
        private Button btnDelete;
        private DataGridView dgvNews;
        private RichTextBox rtbContent;
        private ComboBox cbFilter;
        private Button btnFilter;
        private Button btnCloseContent;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private ComboBox cbTimeFilter;
    }
}
