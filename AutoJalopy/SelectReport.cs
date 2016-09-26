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
    public partial class SelectReport : Form
    {
        int UserID;
        public SelectReport(int userID)
        {
            UserID = userID;
            InitializeComponent();
        }

        private void btnReport1_Click(object sender, EventArgs e)
        {
            LinqDataContext linq = new LinqDataContext();
            var headmechanic = from staff in linq.tblStaffs
                       where staff.Role == "HeadMechanic"| staff.Role == "ManagingDirector" && staff.UserId == UserID
                       select staff;
            if (headmechanic.Any())
            {
                Reports report1 = new Reports(UserID);
                report1.Show();
                this.Close();
            }
            else MessageBox.Show($"This report is reserved for the Head Mechanic and the Mr Daley Only");
        }

        private void btnReport2_Click(object sender, EventArgs e)
        {
            Report2 report2 = new Report2(UserID);
            report2.Show();
            this.Close();
        }

        private void btnReport3_Click(object sender, EventArgs e)
        {
            Report3 report3 = new Report3(UserID);
            report3.Show();
            this.Close();
        }

        private void btnBacktoMM_Click(object sender, EventArgs e)
        {
            MainMenu mm = new MainMenu(UserID);
            mm.Show();
            this.Close();

        }
    }
}
