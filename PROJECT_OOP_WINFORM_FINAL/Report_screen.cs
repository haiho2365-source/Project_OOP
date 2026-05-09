using Project_OOP;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROJECT_OOP_WINFORM_FINAL
{
    public partial class Report_screen : Form
    {
        private PublicationManager _pubManager;
        private Person _currentUser;

        private Button _currentActiveButton;

        public Report_screen()
        {
            InitializeComponent();
        }

        public Report_screen(PublicationManager pubManager, Person user)
        {
            InitializeComponent(); 
            this._pubManager = pubManager;
            this._currentUser = user;

            this.Text = "Khu vực Phóng viên: " + _currentUser.FullName;
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

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);

            if (this._currentUser != null)
            {
                UC_Profile ucProfile = new UC_Profile(this._currentUser);

                this.panel2.Controls.Clear();

                ucProfile.Dock = DockStyle.Fill;
                this.panel2.Controls.Add(ucProfile);
                ucProfile.BringToFront();
            }
            else
            {
                MessageBox.Show("Không tìm thấy thông tin tài khoản!");
            }
        }

        private void btnPostMgr_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear();

            UC_MyNews ucMyNews = new UC_MyNews(this._pubManager, this._currentUser);

            ucMyNews.Dock = DockStyle.Fill;

            panel2.Controls.Add(ucMyNews);

        }
    }
}
