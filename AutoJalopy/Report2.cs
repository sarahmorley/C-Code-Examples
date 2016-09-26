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
    public partial class Report2 : Form
    {
        int UserID;
        public Report2(int userID)
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

        private void Report2_Load(object sender, EventArgs e)
        {

            dgvReport2.AutoGenerateColumns = false;
            dgvReport2.ColumnCount = 4;

            dgvReport2.Columns[0].HeaderText = "Customer ID";
            dgvReport2.Columns[0].DataPropertyName = "CustomerId";

            dgvReport2.Columns[1].HeaderText = "First Name";
            dgvReport2.Columns[1].DataPropertyName = "FirstName";

            dgvReport2.Columns[2].HeaderText = "Last Name";
            dgvReport2.Columns[2].DataPropertyName = "LastName";

            dgvReport2.Columns[3].HeaderText = "Car";
            dgvReport2.Columns[3].DataPropertyName = "Registration";
        }

        private void btnGenerateReport2_Click(object sender, EventArgs e)
        {
            using (LinqDataContext linq = new LinqDataContext())
            {
                var CustomersCars = from cars in linq.tblCars
                                    join customers in linq.tblCustomers                                 
                                    on cars.CustomerId equals customers.CustomerId        
                                    orderby cars.CustomerId                         
                                    select new
                                    {
                                        customers.CustomerId,
                                        customers.FirstName,
                                        customers.LastName,
                                        cars.Registration
                                    };
                foreach (var record in CustomersCars)
                {
                    dgvReport2.DataSource = CustomersCars;
                }
            }
        }

    }
}
