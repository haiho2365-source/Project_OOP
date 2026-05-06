using System;
using System.Windows.Forms;
using Project_OOP; 

namespace PROJECT_OOP_WINFORM_FINAL
{
    public partial class UC_UserManagement : UserControl
    {
        private UserManager _userManager;

        public UC_UserManagement(UserManager uMgr)
        {
            InitializeComponent();
            _userManager = uMgr;

            LoadData();
        }

        private void LoadData()
        {
            List<Person> listToShow = this._userManager.GetUsersForDisplay();

            this.dgvUsers.DataSource = null;
            this.dgvUsers.DataSource = listToShow;

            if (this.dgvUsers.Columns["Password"] != null)
            {
                this.dgvUsers.Columns["Password"].Visible = false;
            }
        }


    }
}