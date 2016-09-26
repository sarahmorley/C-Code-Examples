using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace AutoJalopy
{
    public partial class frmLogin : Form
    {
  
        public frmLogin()
        {
            
            InitializeComponent();
        }



        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (IsvalidUser())
            {
                int userID = CurrentUserID();
                using (MainMenu mMenu = new MainMenu(userID))
                {
                    mMenu.ShowDialog();
                }

                this.Hide();
              
            }
            else
            {
                MessageBox.Show($"Invalid Login details");
            }
        }


        private bool IsvalidUser()
        {

            if (txtUserID.Text != "" && txtPassword.Text != "")
            {
                LinqDataContext linq = new LinqDataContext();
                var user = from staff in linq.tblStaffs
                           where staff.UserId == int.Parse(txtUserID.Text)
                           && staff.Password == txtPassword.Text
                           select staff;
                
                if (user.Any())
                {
                   
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
           
        }

        private void btnCloseApplication_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public int CurrentUserID()
        {
            LinqDataContext linq = new LinqDataContext();
            var user = from staff in linq.tblStaffs
                       where staff.UserId == int.Parse(txtUserID.Text)
                       && staff.Password == txtPassword.Text
                       select staff.UserId;

            return user.First();
        }

    }
}
