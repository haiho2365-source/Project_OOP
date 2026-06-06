namespace PROJECT_DESKTOP_WINFORM_FINAL.GUI
{
    partial class UC_MyNews
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
            dgvMyPosts = new DataGridView();
            btnAdd = new Button();
            btnEdit = new Button();
            btnDelete = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvMyPosts).BeginInit();
            SuspendLayout();
            // 
            // dgvMyPosts
            // 
            dgvMyPosts.BackgroundColor = Color.White;
            dgvMyPosts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMyPosts.Location = new Point(0, 43);
            dgvMyPosts.Name = "dgvMyPosts";
            dgvMyPosts.ReadOnly = true;
            dgvMyPosts.RowHeadersWidth = 62;
            dgvMyPosts.Size = new Size(1043, 566);
            dgvMyPosts.TabIndex = 1;
            dgvMyPosts.CellClick += dgvMyNews_CellClick;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.White;
            btnAdd.Location = new Point(0, 3);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(112, 34);
            btnAdd.TabIndex = 2;
            btnAdd.Text = "Thêm";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnThemMoi_Click;
            // 
            // btnEdit
            // 
            btnEdit.BackColor = Color.White;
            btnEdit.Location = new Point(118, 3);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(112, 34);
            btnEdit.TabIndex = 3;
            btnEdit.Text = "Sửa";
            btnEdit.UseVisualStyleBackColor = false;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.White;
            btnDelete.Location = new Point(236, 3);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(112, 34);
            btnDelete.TabIndex = 4;
            btnDelete.Text = "Xoá";
            btnDelete.UseVisualStyleBackColor = false;
            // 
            // UC_MyNews
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(btnDelete);
            Controls.Add(btnEdit);
            Controls.Add(btnAdd);
            Controls.Add(dgvMyPosts);
            Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Name = "UC_MyNews";
            Size = new Size(1043, 609);
            ((System.ComponentModel.ISupportInitialize)dgvMyPosts).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvMyPosts;
        private Button btnAdd;
        private Button btnEdit;
        private Button btnDelete;
    }
}
