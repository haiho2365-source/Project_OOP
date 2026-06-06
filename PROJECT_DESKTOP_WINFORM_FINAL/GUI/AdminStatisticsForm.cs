using Microsoft.Reporting.WinForms;
using Project_Desktop;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace PROJECT_DESKTOP_WINFORM_FINAL.GUI
{
    public class AdminStatisticsForm : Form
    {
        private const string ReportResource = "PROJECT_DESKTOP_WINFORM_FINAL.Reports.AdminStatisticsReport.rdlc";
        private readonly AdminLinqSqlRepository _repository = new AdminLinqSqlRepository();
        private ReportViewer reportViewer = null!;
        private Button btnRefresh = null!;

        public AdminStatisticsForm()
        {
            InitializeComponent();
            LoadReport();
        }

        private void InitializeComponent()
        {
            Panel topPanel = new Panel();
            Label lblTitle = new Label();
            this.btnRefresh = new Button();
            this.reportViewer = new ReportViewer();

            this.SuspendLayout();

            topPanel.BackColor = Color.White;
            topPanel.Dock = DockStyle.Top;
            topPanel.Height = 54;

            lblTitle.Dock = DockStyle.Left;
            lblTitle.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblTitle.ForeColor = Color.FromArgb(0, 114, 118);
            lblTitle.Padding = new Padding(18, 0, 0, 0);
            lblTitle.Size = new Size(420, 54);
            lblTitle.Text = "BÁO CÁO THỐNG KÊ";
            lblTitle.TextAlign = ContentAlignment.MiddleLeft;

            this.btnRefresh.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            this.btnRefresh.BackColor = Color.FromArgb(255, 112, 67);
            this.btnRefresh.FlatAppearance.BorderSize = 0;
            this.btnRefresh.FlatStyle = FlatStyle.Flat;
            this.btnRefresh.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            this.btnRefresh.ForeColor = Color.White;
            this.btnRefresh.Location = new Point(870, 8);
            this.btnRefresh.Size = new Size(132, 38);
            this.btnRefresh.Text = "LÀM MỚI";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += btnRefresh_Click;

            topPanel.Controls.Add(lblTitle);
            topPanel.Controls.Add(this.btnRefresh);

            this.reportViewer.Dock = DockStyle.Fill;
            this.reportViewer.LocalReport.ReportEmbeddedResource = ReportResource;
            this.reportViewer.Name = "reportViewer";
            this.reportViewer.ProcessingMode = ProcessingMode.Local;
            this.reportViewer.Visible = false;

            this.AutoScaleMode = AutoScaleMode.None;
            this.BackColor = Color.White;
            this.ClientSize = new Size(1021, 355);
            this.Controls.Add(this.reportViewer);
            this.Controls.Add(topPanel);
            this.Font = new Font("Segoe UI", 10F);
            this.FormBorderStyle = FormBorderStyle.None;
            this.Name = "AdminStatisticsForm";
            this.Text = "Báo cáo thống kê";

            this.ResumeLayout(false);
        }

        private void LoadReport()
        {
            try
            {
                AdminStatisticsReport report = this._repository.LoadStatistics();
                List<AdminStatisticsReportRow> rows = BuildReportRows(report);

                this.reportViewer.Visible = true;
                this.reportViewer.LocalReport.ReportEmbeddedResource = ReportResource;
                this.reportViewer.LocalReport.DataSources.Clear();
                this.reportViewer.LocalReport.DataSources.Add(
                    new ReportDataSource("DataSetAdminStatistics", rows));
                this.reportViewer.RefreshReport();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không thể tải báo cáo thống kê: " + ex.Message, "Lỗi database", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private static List<AdminStatisticsReportRow> BuildReportRows(AdminStatisticsReport report)
        {
            List<AdminStatisticsReportRow> rows = new List<AdminStatisticsReportRow>
            {
                new AdminStatisticsReportRow("Tổng quan", "Tổng người dùng", report.TotalUsers),
                new AdminStatisticsReportRow("Tổng quan", "Tổng bài báo", report.TotalPublications),
                new AdminStatisticsReportRow("Tổng quan", "Bài báo đã duyệt", report.ApprovedPublications),
                new AdminStatisticsReportRow("Tổng quan", "Bài báo chờ duyệt", report.PendingPublications),
                new AdminStatisticsReportRow("Tổng quan", "Thư chưa đọc", report.UnreadMessages)
            };

            AddStatisticRows(rows, "Người dùng theo vai trò", report.UsersByRole);
            AddStatisticRows(rows, "Bài báo theo loại", report.PublicationsByType);
            AddStatisticRows(rows, "Trạng thái duyệt", report.PublicationsByStatus);

            return rows;
        }

        private static void AddStatisticRows(List<AdminStatisticsReportRow> rows, string section, IEnumerable<StatisticRow> statistics)
        {
            foreach (StatisticRow statistic in statistics)
            {
                rows.Add(new AdminStatisticsReportRow(section, statistic.Name, statistic.Count));
            }
        }

        private void btnRefresh_Click(object? sender, EventArgs e)
        {
            LoadReport();
        }
    }

    public class AdminStatisticsReportRow
    {
        public AdminStatisticsReportRow(string section, string name, int count)
        {
            this.Section = section;
            this.Name = name;
            this.Count = count;
        }

        public string Section { get; set; }
        public string Name { get; set; }
        public int Count { get; set; }
    }
}