using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Project_OOP;

namespace PROJECT_OOP_WINFORM_FINAL
{
    public partial class UC_NewsManager : UserControl
    {
        private PublicationManager _pubManager;
        private Person _currentUser; // Thêm biến lưu người dùng hiện tại

        // Hàm khởi tạo mới nhận thêm đối tượng Person
        public UC_NewsManager(PublicationManager pMgr, Person currentUser)
        {
            InitializeComponent();
            this._pubManager = pMgr;
            this._currentUser = currentUser;

            // Khởi tạo các giá trị mặc định cho giao diện
            this.btnApprove.Visible = false;
            this.btnCloseContent.Visible = false;
            this.btnDelete.Visible = false;
            this.rtbContent.Visible = false;

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

            // Nạp dữ liệu ban đầu
            this.btnFilter_Click(null, null); // Gọi bộ lọc để lấy dữ liệu đúng quyền
        }

        private void LoadData(List<Publication> dataList)
        {
            this.dgvNews.DataSource = null;
            this.dgvNews.DataSource = dataList;
            this.dgvNews.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // Ẩn các cột không cần thiết
            if (this.dgvNews.Columns["Id"] != null) this.dgvNews.Columns["Id"].Visible = false;
            if (this.dgvNews.Columns["PublishDate"] != null) this.dgvNews.Columns["PublishDate"].Visible = false;
            if (this.dgvNews.Columns["ViewCount"] != null) this.dgvNews.Columns["ViewCount"].Visible = false;

            // Định dạng các cột hiển thị
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

            // Xử lý cột IsApproved: Ẩn đi nếu không phải Admin
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

                // Lọc theo quyền: Nếu KHÔNG phải Admin, chỉ hiển thị bài ĐÃ DUYỆT
                if (!(_currentUser is Admin) && !p.IsApproved)
                {
                    continue;
                }

                bool matchType = false;
                bool matchTime = false;

                // Lọc loại tin
                if (selectedType == "Tất cả loại tin") matchType = true;
                else if (selectedType == "Tin khẩn cấp (Phát ngay)" && p is BreakingNews) matchType = true;
                else if (selectedType == "Tin thường nhật" && p is DailyNews && !(p is BreakingNews)) matchType = true;
                else if (selectedType == "Phóng sự Video" && p is VideoReport) matchType = true;
                else if (selectedType == "Tạp chí truyền hình" && p is WeeklyMagazine) matchType = true;

                // Lọc thời gian
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

            // Đóng khung hiển thị nội dung khi lọc lại dữ liệu
            this.rtbContent.Visible = false;
            this.btnCloseContent.Visible = false;
            this.btnApprove.Visible = false;
            this.btnDelete.Visible = false;
        }

        private void dgvNews_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && this.dgvNews.CurrentRow != null)
            {
                // Hiển thị khung đọc nội dung
                this.btnCloseContent.Visible = true;
                this.rtbContent.Visible = true;

                // Hiển thị nút Duyệt và Xoá NẾU LÀ ADMIN
                if (_currentUser is Admin)
                {
                    this.btnApprove.Visible = true;
                    this.btnDelete.Visible = true;
                }

                string id = this.dgvNews.CurrentRow.Cells["Id"].Value.ToString();
                List<Publication> allPosts = this._pubManager.GetPostList();
                Publication selected = null;

                for (int i = 0; i < allPosts.Count; i = i + 1)
                {
                    if (allPosts[i].Id == id) { selected = allPosts[i]; break; }
                }

                if (selected != null)
                {
                    string info = "ĐÀI TRUYỀN HÌNH VIỆT NAM\n";
                    info += "--- KỊCH BẢN PHÁT SÓNG ---\n";
                    info += "Lịch phát: " + selected.AirTime.ToString("HH:mm") + " Ngày " + selected.AirTime.ToString("dd/MM/yyyy") + "\n";
                    info += "Tiêu đề: " + selected.Title + "\n";
                    info += "------------------------------------------\n";

                    if (selected is BreakingNews)
                    {
                        BreakingNews bn = (BreakingNews)selected;
                        info += "[TIN KHẨN CẤP - PHÁT CẮT NGANG CHƯƠNG TRÌNH]\n";
                        info += "Mức độ nghiêm trọng: " + bn.TrendLevel + "\n";
                        info += "Trạng thái nguồn tin: " + (bn.IsConfirmed ? "Đã xác thực" : "Đang chờ xác minh hiện trường");
                    }
                    else if (selected is DailyNews)
                    {
                        DailyNews dn = (DailyNews)selected;
                        info += "[BẢN TIN THỜI SỰ TRONG NGÀY]\nĐộ thu hút dự kiến: " + dn.TrendLevel + "/10\n";
                    }
                    else if (selected is VideoReport)
                    {
                        VideoReport vr = (VideoReport)selected;
                        info += "[PHÓNG SỰ VIDEO HIỆN TRƯỜNG]\n";
                        info += "Yêu cầu kỹ thuật: Phát video độ phân giải " + vr.Resolution + "\n";
                        info += "Thời lượng chiếm sóng: " + vr.Duration + " phút\n";
                    }
                    else if (selected is WeeklyMagazine)
                    {
                        WeeklyMagazine wm = (WeeklyMagazine)selected;
                        info += "[TẠP CHÍ TRUYỀN HÌNH CUỐI TUẦN]\nBiên tập viên/Tác giả: " + wm.Author + "\n";
                        info += "Tài liệu/Hình ảnh tham chiếu: " + (wm.References.Count > 0 ? wm.References[0] : "Lấy từ kho tư liệu số") + "\n";
                    }

                    // Thêm phần nội dung chính
                    info += "\n[NỘI DUNG/KỊCH BẢN CHI TIẾT]\n";
                    // Ghi chú: Nếu class Publication có thuộc tính Content thì mở dòng dưới
                    // info += selected.Content + "\n"; 

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
    }
}