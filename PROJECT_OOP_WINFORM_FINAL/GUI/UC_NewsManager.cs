using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Project_Desktop;

namespace PROJECT_DESKTOP_WINFORM_FINAL.GUI
{
    public partial class UC_NewsManager : UserControl
    {
        private PublicationManager _pubManager;
        private Person _currentUser;

        public UC_NewsManager(PublicationManager pMgr, Person currentUser)
        {
            InitializeComponent();
            this._pubManager = pMgr;
            this._currentUser = currentUser;

            this.btnApprove.Visible = false;
            this.btnCloseContent.Visible = false;
            this.btnDelete.Visible = false;
            this.rtbContent.Visible = false;
            this.btnWatch.Visible = false;

            this.cbFilter.Items.Add("Tất cả loại tin");
            this.cbFilter.Items.Add("Tin khẩn cấp (Phát ngay)");
            this.cbFilter.Items.Add("Tin thường nhật");
            this.cbFilter.Items.Add("Phóng sự Video");
            this.cbFilter.Items.Add("Tạp chí truyền hình");
            this.cbFilter.SelectedIndex = 0;

            this.cbTimeFilter.Items.Add("Tất cả thời gian");
            this.cbTimeFilter.Items.Add("Phát sóng hôm nay");
            this.cbTimeFilter.Items.Add("Phát sóng ngày mai");
            this.cbTimeFilter.Items.Add("Đã phát sóng (Quá khứ)");
            this.cbTimeFilter.Items.Add("Sắp phát sóng (Tương lai)");
            this.cbTimeFilter.SelectedIndex = 0;

            this.btnFilter_Click(null, null);
        }

        private void LoadData(List<Publication> dataList)
        {
            this.dgvNews.DataSource = null;
            this.dgvNews.DataSource = dataList;
            this.dgvNews.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            if (this.dgvNews.Columns["Id"] != null) this.dgvNews.Columns["Id"].Visible = false;
            if (this.dgvNews.Columns["PublishDate"] != null) this.dgvNews.Columns["PublishDate"].Visible = false;
            if (this.dgvNews.Columns["ViewCount"] != null) this.dgvNews.Columns["ViewCount"].Visible = false;

            if (this.dgvNews.Columns["Title"] != null)
            {
                this.dgvNews.Columns["Title"].HeaderText = "Tên kịch bản / Bản tin";
                this.dgvNews.Columns["Title"].FillWeight = 200;
            }
            if (this.dgvNews.Columns["AirTime"] != null)
            {
                this.dgvNews.Columns["AirTime"].HeaderText = "Lịch phát sóng";
                this.dgvNews.Columns["AirTime"].DefaultCellStyle.Format = "HH:mm (dd/MM)";
                this.dgvNews.Columns["AirTime"].FillWeight = 100;
            }

            if (this.dgvNews.Columns["IsApproved"] != null)
            {
                this.dgvNews.Columns["IsApproved"].HeaderText = "Đã duyệt";
                this.dgvNews.Columns["IsApproved"].FillWeight = 60;
                this.dgvNews.Columns["IsApproved"].Visible = _currentUser is Admin;
            }
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            List<Publication> allPosts = this._pubManager.GetPostList();
            List<Publication> filteredList = new List<Publication>();

            string selectedType = this.cbFilter.SelectedItem?.ToString() ?? "Tất cả loại tin";
            string selectedTime = this.cbTimeFilter.SelectedItem?.ToString() ?? "Tất cả thời gian";
            DateTime now = DateTime.Now;

            for (int i = 0; i < allPosts.Count; i = i + 1)
            {
                Publication p = allPosts[i];

                if (!(_currentUser is Admin) && !p.IsApproved)
                {
                    continue;
                }

                bool matchType = false;
                bool matchTime = false;

                if (selectedType == "Tất cả loại tin") matchType = true;
                else if (selectedType == "Tin khẩn cấp (Phát ngay)" && p is BreakingNews) matchType = true;
                else if (selectedType == "Tin thường nhật" && p is DailyNews && !(p is BreakingNews)) matchType = true;
                else if (selectedType == "Phóng sự Video" && p is VideoReport) matchType = true;
                else if (selectedType == "Tạp chí truyền hình" && p is WeeklyMagazine) matchType = true;

                if (selectedTime == "Tất cả thời gian") matchTime = true;
                else if (selectedTime == "Phát sóng hôm nay" && p.AirTime.Date == now.Date) matchTime = true;
                else if (selectedTime == "Phát sóng ngày mai" && p.AirTime.Date == now.AddDays(1).Date) matchTime = true;
                else if (selectedTime == "Đã phát sóng (Quá khứ)" && p.AirTime < now) matchTime = true;
                else if (selectedTime == "Sắp phát sóng (Tương lai)" && p.AirTime >= now) matchTime = true;

                if (matchType == true && matchTime == true)
                {
                    filteredList.Add(p);
                }
            }

            this.LoadData(filteredList);

            this.rtbContent.Visible = false;
            this.btnCloseContent.Visible = false;
            this.btnApprove.Visible = false;
            this.btnDelete.Visible = false;
            this.btnWatch.Visible = false;
        }

        private void dgvNews_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && this.dgvNews.CurrentRow != null)
            {
                this.rtbContent.Visible = true;
                this.btnCloseContent.Visible = true;
                this.btnWatch.Visible = true;

                this.btnWatch.BringToFront();
                this.btnCloseContent.BringToFront();

                if (_currentUser is Admin)
                {
                    this.btnApprove.Visible = true;
                    this.btnDelete.Visible = true;

                    this.btnApprove.BringToFront();
                    this.btnDelete.BringToFront();
                }
                else
                {
                    this.btnApprove.Visible = false;
                    this.btnDelete.Visible = false;
                }

                string id = this.dgvNews.CurrentRow.Cells["Id"].Value.ToString();
                Publication selected = this._pubManager.GetPostList().Find(p => p.Id == id);

                if (selected != null)
                {
                    string info = "CHI TIẾT BẢN TIN" + Environment.NewLine;
                    info += "Tiêu đề: " + selected.Title + Environment.NewLine;
                    info += "Lịch phát: " + selected.AirTime.ToString("HH:mm dd/MM/yyyy") + Environment.NewLine;
                    info += "NỘI DUNG KỊCH BẢN:" + Environment.NewLine + selected.Content;

                    this.rtbContent.Text = info;
                }
            }
        }

        private void btnCloseContent_Click(object sender, EventArgs e)
        {
            this.btnApprove.Visible = false;
            this.btnCloseContent.Visible = false;
            this.btnDelete.Visible = false;
            this.rtbContent.Visible = false;
            this.btnWatch.Visible = false;
            this.rtbContent.Clear();
        }

        private void btnApprove_Click(object sender, EventArgs e)
        {
            if (this.dgvNews.CurrentRow != null)
            {
                string id = this.dgvNews.CurrentRow.Cells["Id"].Value.ToString();

                List<Publication> allPosts = this._pubManager.GetPostList();
                for (int i = 0; i < allPosts.Count; i++)
                {
                    if (allPosts[i].Id == id)
                    {
                        allPosts[i].IsApproved = true;
                        MessageBox.Show("Duyệt kịch bản thành công! Sẵn sàng lên sóng.");
                        this.btnFilter_Click(sender, e);
                        break;
                    }
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (this.dgvNews.CurrentRow != null)
            {
                string id = this.dgvNews.CurrentRow.Cells["Id"].Value.ToString();
                if (MessageBox.Show("Bạn có chắc chắn muốn gỡ bản tin này khỏi lịch phát sóng?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    this._pubManager.RemovePost(id);
                    this.btnFilter_Click(sender, e);
                    this.rtbContent.Visible = false;
                    this.btnCloseContent.Visible = false;
                    this.btnApprove.Visible = false;
                    this.btnDelete.Visible = false;
                }
            }
        }

        private void rtbContent_TextChanged(object sender, EventArgs e)
        {
        }

        private void dgvNews_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void btnWatch_Click(object sender, EventArgs e)
        {
            if (this.dgvNews.CurrentRow != null)
            {
                string id = this.dgvNews.CurrentRow.Cells["Id"].Value.ToString();
                Publication selectedPost = this._pubManager.GetPostList().Find(p => p.Id == id);

                if (selectedPost != null)
                {
                    string url = selectedPost.VideoUrl;

                    if (!string.IsNullOrEmpty(url))
                    {
                        try
                        {
                            System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
                            {
                                FileName = url,
                                UseShellExecute = true
                            });
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Lỗi mở link: " + ex.Message);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Bản tin này chưa có link video!", "Thông báo");
                    }
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn bản tin!");
            }
        }

        private void LoadNewsToGrid()
        {
            dgvNews.Rows.Clear();

            List<Publication> allPosts = _pubManager.GetPostList();

            foreach (Publication p in allPosts)
            {
                if (p.IsApproved == true)
                {
                    dgvNews.Rows.Add(p.Id, p.Title, p.PublishDate.ToString("dd/MM/yyyy"), p.ViewCount);
                }
            }
        }
    }
}