using Project_Desktop;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace PROJECT_DESKTOP_WINFORM_FINAL.GUI
{
    public partial class Manager : Form
    {
        private Database _database;
        private UserManager _userManager;
        private PublicationManager _pubManager;
        private Person _currentUser;
        private Button _currentActiveButton;
        private Button _btnMailbox = null!;
        private Button _btnStatistics = null!;

        public Manager(Database db, UserManager uMgr, PublicationManager pMgr, Person currentUser)
        {
            InitializeComponent();

            this._database = db;
            this._userManager = uMgr;
            this._pubManager = pMgr;
            this._currentUser = currentUser;
            InitializeAdminButtons();
        }


        private void InitializeAdminButtons()
        {
            _btnMailbox = CreateNavButton("Hòm thư", btnProfile.Right + 6);
            _btnMailbox.Click += btnMailbox_Click;

            _btnStatistics = CreateNavButton("Báo cáo\r\nthống kê", _btnMailbox.Right + 6);
            _btnStatistics.Click += btnStatistics_Click;

            panel1.Controls.Add(_btnMailbox);
            panel1.Controls.Add(_btnStatistics);
            _btnMailbox.BringToFront();
            _btnStatistics.BringToFront();
        }

        private Button CreateNavButton(string text, int left)
        {
            Button button = new Button();
            button.BackColor = Color.FromArgb(0, 114, 118);
            button.FlatAppearance.BorderSize = 0;
            button.FlatStyle = FlatStyle.Flat;
            button.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            button.ForeColor = Color.White;
            button.Location = new Point(left, btnProfile.Top);
            button.Padding = Padding.Empty;
            button.Size = btnProfile.Size;
            button.Text = text;
            button.TextAlign = ContentAlignment.MiddleCenter;
            button.UseVisualStyleBackColor = false;
            button.MouseEnter += btnNav_MouseEnter;
            button.MouseLeave += btnNav_MouseLeave;
            return button;
        }
        private void ShowFunction(Form form)
        {
            panel2.Controls.Clear();
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            panel2.Controls.Add(form);
            form.Show();
            form.BringToFront();
        }

        private void ActivateButton(object btnSender)
        {
            if (btnSender != null)
            {
                if (_currentActiveButton != (Button)btnSender)
                {
                    DeactivateButton();

                    _currentActiveButton = (Button)btnSender;
                    _currentActiveButton.BackColor = Color.FromArgb(255, 140, 0);
                    _currentActiveButton.ForeColor = Color.White;
                }
            }
        }

        private void DeactivateButton()
        {
            if (_currentActiveButton != null)
            {
                _currentActiveButton.BackColor = Color.FromArgb(0, 114, 118);
                _currentActiveButton.ForeColor = Color.White;
            }
        }

        private void btnNav_MouseEnter(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (btn != _currentActiveButton)
            {
                btn.BackColor = Color.FromArgb(255, 112, 67);
            }
        }

        private void btnNav_MouseLeave(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (btn != _currentActiveButton)
            {
                btn.BackColor = Color.FromArgb(0, 114, 118);
            }
        }

        private void btnUserMgr_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            ShowFunction(new GUI.UserManagement(_userManager));
        }

        private void btnPostMgr_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);

            ShowFunction(new GUI.NewsManager(this._pubManager, this._currentUser));
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);

            if (this._currentUser != null)
            {
                panel2.Controls.Clear();

                var frmProfile = new PROJECT_DESKTOP_WINFORM_FINAL.GUI.Profile(this._currentUser);
                frmProfile.TopLevel = false;
                frmProfile.FormBorderStyle = FormBorderStyle.None;
                frmProfile.Dock = DockStyle.Fill;

                panel2.Controls.Add(frmProfile);
                frmProfile.Show();
                frmProfile.BringToFront();
            }
            else
            {
                MessageBox.Show("Không tìm thấy thông tin tài khoản!");
            }
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void btnMailbox_Click(object? sender, EventArgs e)
        {
            ActivateButton(sender!);
            ShowFunction(new MailboxForm(this._currentUser));
        }

        private void btnStatistics_Click(object? sender, EventArgs e)
        {
            ActivateButton(sender!);
            ShowFunction(new AdminStatisticsForm());
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {
        }
    }
}
