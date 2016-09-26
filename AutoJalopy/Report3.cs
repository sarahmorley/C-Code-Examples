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
    public partial class Report3 : Form
    {
        int UserID;
        public Report3(int userID)
        {
            UserID = userID;
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            SelectReport reportSelector = new SelectReport(UserID);
            reportSelector.Show();
            this.Close();
        }

        private void btnGenerateReport3_Click(object sender, EventArgs e)
        {
            using (LinqDataContext linq = new LinqDataContext())
            {
                var jobCards = from jobcards in linq.tblJobCards  
                               join customers in linq.tblCars on jobcards.Registration equals customers.Registration                                 
                                    select new
                                    {
                                        jobcards.JobCardId,
                                        jobcards.Description,
                                        customers.CustomerId,
                                        jobcards.UserId,
                                        jobcards.CompletionDate
                                    };
                
                foreach( var record in jobCards)
                {
                    dgvReport3.DataSource = jobCards;
                }
            }
        }

        private void Report3_Load(object sender, EventArgs e)
        {
            dgvReport3.AutoGenerateColumns = false;
            dgvReport3.ColumnCount = 5;

            dgvReport3.Columns[0].HeaderText = "JobCard ID";
            dgvReport3.Columns[0].DataPropertyName = "JobCardId";

            dgvReport3.Columns[1].HeaderText = "Job Description";
            dgvReport3.Columns[1].DataPropertyName = "Description";

            dgvReport3.Columns[2].HeaderText = "Customer";
            dgvReport3.Columns[2].DataPropertyName = "CustomerId";

            dgvReport3.Columns[3].HeaderText = "Mechanic Assigned";
            dgvReport3.Columns[3].DataPropertyName = "UserId";

            dgvReport3.Columns[4].HeaderText = "Completion Date";
            dgvReport3.Columns[4].DataPropertyName = "CompletionDate";

        }
    }
}
