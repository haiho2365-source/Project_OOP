namespace PROJECT_DESKTOP_WINFORM_FINAL.GUI
{
    partial class MyNews
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
            btnAdd = new Button();
            btnEdit = new Button();
            btnDelete = new Button();
            dgvMyPosts = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvMyPosts).BeginInit();
            SuspendLayout();
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.White;
            btnAdd.Location = new Point(15, 15);
            btnAdd.Margin = new Padding(4, 4, 4, 4);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(140, 42);
            btnAdd.TabIndex = 3;
            btnAdd.Text = "Thêm";
            btnAdd.UseVisualStyleBackColor = false;
            // 
            // btnEdit
            // 
            btnEdit.BackColor = Color.White;
            btnEdit.Location = new Point(182, 15);
            btnEdit.Margin = new Padding(4, 4, 4, 4);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(140, 42);
            btnEdit.TabIndex = 4;
            btnEdit.Text = "Sửa";
            btnEdit.UseVisualStyleBackColor = false;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.White;
            btnDelete.Location = new Point(354, 15);
            btnDelete.Margin = new Padding(4, 4, 4, 4);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(140, 42);
            btnDelete.TabIndex = 5;
            btnDelete.Text = "Xoá";
            btnDelete.UseVisualStyleBackColor = false;
            // 
            // dgvMyPosts
            // 
            dgvMyPosts.BackgroundColor = Color.White;
            dgvMyPosts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMyPosts.Location = new Point(15, 65);
            dgvMyPosts.Margin = new Padding(4, 4, 4, 4);
            dgvMyPosts.Name = "dgvMyPosts";
            dgvMyPosts.ReadOnly = true;
            dgvMyPosts.RowHeadersWidth = 62;
            dgvMyPosts.Size = new Size(1302, 482);
            dgvMyPosts.TabIndex = 6;
            // 
            // MyNews
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 114, 118);
            ClientSize = new Size(1332, 562);
            Controls.Add(dgvMyPosts);
            Controls.Add(btnDelete);
            Controls.Add(btnEdit);
            Controls.Add(btnAdd);
            Margin = new Padding(4, 4, 4, 4);
            Name = "MyNews";
            Text = "MyNews";
            ((System.ComponentModel.ISupportInitialize)dgvMyPosts).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnAdd;
        private Button btnEdit;
        private Button btnDelete;
        private DataGridView dgvMyPosts;
    }
}