using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoJalopy
{
    public partial class  MainMenu : Form
    {
        int UserID;
        public MainMenu(int userID)
        {
            UserID = userID;

            InitializeComponent();
        }

        private void btnAdministration_Click(object sender, EventArgs e)
        {//only allow admin to access this form
            LinqDataContext linq = new LinqDataContext();
            var user = from staff in linq.tblStaffs
                       where staff.Admin == true && staff.UserId == UserID
                       select staff;
            if (user.Any())
            {
                AutoJalopy autoJForm = new AutoJalopy(UserID);
                autoJForm.Show();
                this.Close();
            }
            else MessageBox.Show($"You must be an admin user to access this form"); 
                   
        }

        private void btnMyJobs_Click(object sender, EventArgs e)
        {
            MyJobs myjobsfrm = new MyJobs(UserID);           
            myjobsfrm.Show();
            this.Close();
        }

        private void btnCloseApp_Click(object sender, EventArgs e)
        {
            frmLogin loginform = new frmLogin();
            loginform.Show();
            this.Close();
        }

        private void btnReports_Click(object sender, EventArgs e)
        {
            SelectReport reportselector = new SelectReport(UserID);
            reportselector.Show();
            this.Close();
        }
    }
}
