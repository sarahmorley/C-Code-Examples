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
    public partial class Reports : Form
    {
        int UserID;
        public Reports(int userID)
        {
            UserID = userID;
            InitializeComponent();
        }

        private void Reports_Load(object sender, EventArgs e)
        {
            dgvReport1.AutoGenerateColumns = false;
            dgvReport1.ColumnCount = 5;

            dgvReport1.Columns[0].HeaderText = "JobCard ID";
            dgvReport1.Columns[0].DataPropertyName = "JobCardId";

            dgvReport1.Columns[1].HeaderText = "Job Description";
            dgvReport1.Columns[1].DataPropertyName = "Description";

            dgvReport1.Columns[2].HeaderText = "Mechanic Assigned";
            dgvReport1.Columns[2].DataPropertyName = "UserId";

            dgvReport1.Columns[3].HeaderText = "Start Date";
            dgvReport1.Columns[3].DataPropertyName = "StartDate";

            dgvReport1.Columns[4].HeaderText = "Completion Date";
            dgvReport1.Columns[4].DataPropertyName = "CompletionDate";

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            SelectReport reportSelector = new SelectReport(UserID);
            reportSelector.Show();
            this.Close();
        }

        private void btnGenerateReport1_Click(object sender, EventArgs e)
        {
            try
            {
                using (LinqDataContext linq = new LinqDataContext())
                {

                    var workLoad = from jobs in linq.tblJobCards
                                   where jobs.UserId == int.Parse(cmbChooseMechanic.Text)
                                   && jobs.CompletionDate < DateTime.Now.AddDays(14)
                                   select new
                                   {
                                       jobs.JobCardId,
                                       jobs.Description,
                                       jobs.UserId,
                                       jobs.StartDate,
                                       jobs.CompletionDate
                                   };
                    if (workLoad.Any())
                    {
                        foreach (var record in workLoad)
                        {
                            dgvReport1.DataSource = workLoad;
                        }
                    }
                    else
                    {
                        MessageBox.Show($"This mechanic has no assigned jobs for the next two weeks");
                        dgvReport1.DataSource = workLoad; 
                    }
                }
            }
            catch
            {
                MessageBox.Show($"You must select a mechanic before you can generate a report");
            }
            }
            

            
           
        }
    }

