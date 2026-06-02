using Project_OOP;
using System;
using System.Windows.Forms;

namespace PROJECT_OOP_WINFORM_FINAL
{
    public partial class UC_MyNews : UserControl
    {
        private PublicationManager _pubManager;
        private Person _currentUser;

        public UC_MyNews()
        {
            InitializeComponent();
        }

        public UC_MyNews(PublicationManager pubManager, Person user)
        {
            InitializeComponent();
            this._pubManager = pubManager; 
            this._currentUser = user;      

            LoadData(); 
        }

        public void LoadData()
        {
            if (_pubManager == null) return;

            dgvMyPosts.DataSource = null;
            dgvMyPosts.DataSource = _pubManager.GetPostList();

            if (dgvMyPosts.Columns["Content"] != null) dgvMyPosts.Columns["Content"].Visible = false;
            if (dgvMyPosts.Columns["VideoUrl"] != null) dgvMyPosts.Columns["VideoUrl"].Visible = false;
        }

        private void btnThemMoi_Click(object sender, EventArgs e)
        {
            using (Form_NewsEditor frm = new Form_NewsEditor())
            {
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    _pubManager.AddPost(frm.CreatedPost);
                    LoadData();
                    MessageBox.Show("Thêm bản tin mới thành công!");
                }
            }
        }

        private void dgvMyNews_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                Publication selectedPost = dgvMyPosts.Rows[e.RowIndex].DataBoundItem as Publication;

                if (selectedPost == null) return;

                string columnName = dgvMyPosts.Columns[e.ColumnIndex].Name;

                if (columnName == "btnEdit")
                {
                    using (Form_NewsEditor frm = new Form_NewsEditor(selectedPost))
                    {
                        if (frm.ShowDialog() == DialogResult.OK)
                        {
                            LoadData();
                            MessageBox.Show("Cập nhật thành công!");
                        }
                    }
                }
                else if (columnName == "btnDelete")
                {
                    DialogResult dr = MessageBox.Show("Bạn có chắc muốn xoá bản tin này?", "Xác nhận", MessageBoxButtons.YesNo);
                    if (dr == DialogResult.Yes)
                    {
                        _pubManager.RemovePost(selectedPost.Id);
                        LoadData();
                        MessageBox.Show("Đã xoá bản tin.");
                    }
                }
            }
        }
    }
}