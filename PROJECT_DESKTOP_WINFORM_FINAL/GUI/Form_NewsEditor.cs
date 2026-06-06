using Project_Desktop;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROJECT_DESKTOP_WINFORM_FINAL.GUI
{
    public partial class Form_NewsEditor : Form
    {
        public Publication CreatedPost { get; private set; }
        private bool isEditMode = false;
        public Form_NewsEditor()
        {
            InitializeComponent();
        }

        public Form_NewsEditor(Publication post) : this()
        {
            isEditMode = true;
            CreatedPost = post;

            txtTitle.Text = post.Title;
            dtpBroadcastTime.Value = post.PublishDate;
            rtbContent.Text = post.Content;
            txtVideoLink.Text = post.VideoUrl;

            if (post is DailyNews) cboCategory.SelectedIndex = 0;
            else if (post is VideoReport) cboCategory.SelectedIndex = 1;
            else if (post is WeeklyMagazine) cboCategory.SelectedIndex = 2;
            else if (post is BreakingNews) cboCategory.SelectedIndex = 3;

            btnSave.Text = "Cập nhật"; 
        }
        private void Form_NewsEditor_Load(object sender, EventArgs e)
        {

        }
        private void LoadCategories()
        {
            cboCategory.Items.Clear();
            cboCategory.Items.Add("Bản tin Thời sự (DailyNews)");
            cboCategory.Items.Add("Phóng sự Video (VideoReport)");
            cboCategory.Items.Add("Tạp chí truyền hình (WeeklyMagazine)");
            cboCategory.Items.Add("Tin khẩn cấp (BreakingNews)");
            cboCategory.SelectedIndex = 0;
        }



        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTitle.Text) || string.IsNullOrWhiteSpace(rtbContent.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ Tiêu đề và Nội dung!");
                return;
            }

            if (!isEditMode)
            {
                string id = "BN" + DateTime.Now.Ticks.ToString().Substring(10);
                string title = txtTitle.Text;
                DateTime thoiGian = dtpBroadcastTime.Value;

                switch (cboCategory.SelectedIndex)
                {
                    case 0:
                        CreatedPost = new DailyNews(id, title, thoiGian, 1);
                        break;
                    case 1:
                        CreatedPost = new VideoReport(id, title, thoiGian, 5.0, "FullHD");
                        break;
                    case 2:
                        CreatedPost = new WeeklyMagazine(id, title, thoiGian, "Phóng viên");
                        break;
                    case 3:
                        CreatedPost = new BreakingNews(id, title, thoiGian, 5);
                        break;
                    default:
                        MessageBox.Show("Vui lòng chọn loại bản tin!");
                        return;
                }
            }
            else
            {
                CreatedPost.Title = txtTitle.Text;
                CreatedPost.PublishDate = dtpBroadcastTime.Value;
            }

            if (CreatedPost != null)
            {
                CreatedPost.Content = rtbContent.Text;
                CreatedPost.VideoUrl = txtVideoLink.Text;
            }

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
