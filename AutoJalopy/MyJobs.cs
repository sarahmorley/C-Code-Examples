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
    public partial class MyJobs : Form
    {
        int UserID;
        public MyJobs(int userID)
        {
            UserID = userID;
            InitializeComponent();
        }


        private void MyJobs_Load(object sender, EventArgs e)
        {
            dgvMyJobs.AutoGenerateColumns = false;
            dgvMyJobs.ColumnCount = 4;

            dgvMyJobs.Columns[0].HeaderText = "Registration";
            dgvMyJobs.Columns[0].DataPropertyName = "Registration";

            dgvMyJobs.Columns[1].HeaderText = "Job Description";
            dgvMyJobs.Columns[1].DataPropertyName = "Description";

            dgvMyJobs.Columns[2].HeaderText = "Start Date";
            dgvMyJobs.Columns[2].DataPropertyName = "StartDate";

            dgvMyJobs.Columns[3].HeaderText = "Completion Date";
            dgvMyJobs.Columns[3].DataPropertyName = "CompletionDate";

                          

        }

        private void btnBacktoMM_Click(object sender, EventArgs e)
        {
            MainMenu mMenu = new MainMenu(UserID);
            mMenu.Show();
            this.Close();
        }

        private void btnViewJobs_Click(object sender, EventArgs e)
        {
            using (LinqDataContext linq = new LinqDataContext())
            {

                var myJobs = from jobs in linq.tblJobCards
                             where jobs.UserId == UserID
                             select jobs;

                if (myJobs.Any())
                {
                    dgvMyJobs.DataSource = myJobs;
                }
                else
                {
                    MessageBox.Show($"You have no jobs assigned");
                }
            }
        }

        private void btnComplete_Click(object sender, EventArgs e)
        {
            try
            {
                int rowIndex = GetCurrentIndex4();

                string selectedJob = GetJob(rowIndex);

                using (LinqDataContext linq = new LinqDataContext())
                {
                    var jobToDelete = (from jobs in linq.tblJobCards
                                           where jobs.Registration == selectedJob
                                           select jobs).First();

                    if (jobToDelete != null)
                    {
                        linq.tblJobCards.DeleteOnSubmit(jobToDelete);
                        linq.SubmitChanges();
                        MessageBox.Show($"{jobToDelete.Description} on {jobToDelete.Registration} deleted");                 
                    }

                    var myJobs = from jobs in linq.tblJobCards
                                 where jobs.UserId == UserID
                                 select jobs;

                    if (myJobs.Any())
                    {
                        dgvMyJobs.DataSource = myJobs;
                    }
                    else
                    {
                        dgvMyJobs.DataSource = null; 
                        MessageBox.Show($"You have no jobs assigned");
                    }
                }
            }
            catch
            {
                MessageBox.Show($"Error: You have not selected a job card to delete");
            }
        }

        private string GetJob(int rowIndex)
        {
            return dgvMyJobs.Rows[rowIndex].Cells[0].Value.ToString();
        }

        private int GetCurrentIndex4()
        {
            int rowIndex = dgvMyJobs.CurrentRow.Index;

            return rowIndex;
        }

    }
}
