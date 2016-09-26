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
    public partial class   AutoJalopy : Form
    {
        int UserID;
        public AutoJalopy(int userID)
        {
            UserID = userID;
            InitializeComponent();
        }


        private void AutoJalopy_Load(object sender, EventArgs e)
        {
            dgvCustomers.AutoGenerateColumns = false;
            dgvCustomers.ColumnCount = 5;
            dgvCustomers.Columns[0].HeaderText = "Customer ID";
            dgvCustomers.Columns[0].DataPropertyName = "CustomerId";

            dgvCustomers.Columns[1].HeaderText = "First Name";
            dgvCustomers.Columns[1].DataPropertyName = "FirstName";

            dgvCustomers.Columns[2].HeaderText = "Last Name";
            dgvCustomers.Columns[2].DataPropertyName = "LastName";

            dgvCustomers.Columns[3].HeaderText = "Email";
            dgvCustomers.Columns[3].DataPropertyName = "email";

            dgvCustomers.Columns[4].HeaderText = "Phone";
            dgvCustomers.Columns[4].DataPropertyName = "Phone";

            dgvCars.AutoGenerateColumns = false;
            dgvCars.ColumnCount = 4;
            dgvCars.Columns[0].ReadOnly = true; 
            dgvCars.Columns[0].HeaderText = "Registration";
            dgvCars.Columns[0].DataPropertyName = "Registration";

            dgvCars.Columns[1].HeaderText = "Car Make";
            dgvCars.Columns[1].DataPropertyName = "CarMake";

            dgvCars.Columns[2].HeaderText = "Model";
            dgvCars.Columns[2].DataPropertyName = "Model";

            dgvCars.Columns[3].HeaderText = "Customer Id";
            dgvCars.Columns[3].DataPropertyName = "CustomerId";

            dgvJobCards.AutoGenerateColumns = false;
            dgvJobCards.ColumnCount = 5;

            dgvJobCards.Columns[0].ReadOnly = true;
            dgvJobCards.Columns[0].HeaderText = "JobCard Id";
            dgvJobCards.Columns[0].DataPropertyName = "JobCardId";

            dgvJobCards.Columns[1].HeaderText = "Job Description";
            dgvJobCards.Columns[1].DataPropertyName = "Description";

            dgvJobCards.Columns[2].HeaderText = "Staff Id";
            dgvJobCards.Columns[2].DataPropertyName = "UserId";

            dgvJobCards.Columns[3].HeaderText = "Start Date";
            dgvJobCards.Columns[3].DataPropertyName = "StartDate";

            dgvJobCards.Columns[4].HeaderText = "Completion Date";
            dgvJobCards.Columns[4].DataPropertyName = "CompletionDate";

        }

        //this is the search button 
        private void btnProceed_Click(object sender, EventArgs e)
        {
            SearchCustomer(); 
        }


        private void SearchCustomer()
        {
            dgvCustomers.DataSource = null;

            if (txtCusFName.Text != "" && txtCusLName.Text != "")
            {
                using (LinqDataContext linq = new LinqDataContext())
                {
                    var searchedCus = from Cus in linq.tblCustomers
                                      where Cus.FirstName == txtCusFName.Text
                                      && Cus.LastName == txtCusLName.Text
                                      select Cus;

                    if (searchedCus.Any())
                    {
                        dgvCustomers.DataSource = searchedCus;
                    }
                    else
                    {
                        MessageBox.Show($"No customer on file: Create Customer Record.");
                    }

                }
            }
            else MessageBox.Show($"Error: Enter customer first and last name in order to search"); 
        }

        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            if (txtCusFName.Text != "" && txtCusLName.Text != "")
            {
                using (LinqDataContext linq = new LinqDataContext())
                {
                    tblCustomer newCustomer = new tblCustomer
                    {
                        FirstName = txtCusFName.Text,
                        LastName = txtCusLName.Text,
                        email = txtcusEmail.Text,
                        Phone = txtcusPhone.Text
                    };

                    linq.tblCustomers.InsertOnSubmit(newCustomer);
                    linq.SubmitChanges();

                    MessageBox.Show($"New customer {newCustomer.FirstName} added");
                    SearchCustomer();
                }
            }
            else MessageBox.Show($"Error: You must enter a first and last name before adding a customer"); 
        }
           
        
        

        private void btnEditCustomer_Click(object sender, EventArgs e)
        {
            try
            {
                int rowIndex = GetCurrentIndex();

                int selectedCusID = GetCustomerId(rowIndex);

                using (LinqDataContext linq = new LinqDataContext())
                {
                    var customerToUpdate = (from cus in linq.tblCustomers
                                            where cus.CustomerId == selectedCusID
                                            select cus).First();

                    if (customerToUpdate != null)
                    {
                        customerToUpdate.FirstName = Convert.ToString(dgvCustomers.Rows[rowIndex].Cells[1].Value);
                        customerToUpdate.LastName = Convert.ToString(dgvCustomers.Rows[rowIndex].Cells[2].Value);
                        customerToUpdate.Phone = Convert.ToString(dgvCustomers.Rows[rowIndex].Cells[3].Value);
                        customerToUpdate.email = Convert.ToString(dgvCustomers.Rows[rowIndex].Cells[4].Value);


                        try
                        {
                            linq.SubmitChanges();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                            throw;
                        }
                    }

                }
            }catch
            {
                MessageBox.Show($"Error: You have not selected a customer to edit"); 
            }
        }

        private int GetCustomerId(int rowIndex)
        {
            return Convert.ToInt32(dgvCustomers.Rows[rowIndex].Cells[0].Value);
        }

        private int GetCurrentIndex()
        {
            int rowIndex = dgvCustomers.CurrentRow.Index;

            return rowIndex;
        }

        private void btnSelectCus_Click(object sender, EventArgs e)
        {
            try
            {
                tblCustomer selectedCus = (tblCustomer)dgvCustomers.CurrentRow.DataBoundItem;

                using (LinqDataContext linq = new LinqDataContext())
                {
                    var cusCar = from cars in linq.tblCars
                                 where selectedCus.CustomerId == cars.CustomerId
                                 select cars;

                    if (cusCar.Any())
                    {
                        dgvCars.DataSource = cusCar;
                        lblCarslabel.Text = selectedCus.FirstName + " " + selectedCus.LastName + "'s";
                    }
                    else
                    {
                        dgvCars.DataSource = cusCar;
                        MessageBox.Show($"This customer has now cars assigned: Add a car.");
                    }
                }
              
            }catch
            {
                MessageBox.Show($"Error: You must enter customer details before selecting");
            }
        }

        private void btnAddCar_Click(object sender, EventArgs e)
        {
            if (txtReg.Text != "")
            {
                tblCustomer selectedCus = (tblCustomer)dgvCustomers.CurrentRow.DataBoundItem;
                using (LinqDataContext linq = new LinqDataContext())
                {

                    tblCar newCar = new tblCar
                    {
                        CustomerId = selectedCus.CustomerId,
                        Registration = txtReg.Text,
                        CarMake = txtMake.Text,
                        Model = txtModel.Text
                    };

                    linq.tblCars.InsertOnSubmit(newCar);
                    linq.SubmitChanges();

                    MessageBox.Show($"New car {newCar.Registration} added");
                    DisplayCars();

                }
            }
            else MessageBox.Show($"Error: You must enter a Registration before adding a car"); 
        }

       private void DisplayCars()
        {
            dgvCars.DataSource = null;
            tblCustomer selectedCus = (tblCustomer)dgvCustomers.CurrentRow.DataBoundItem;
            using (LinqDataContext linq = new LinqDataContext())
            {
                var CusCars = from car in linq.tblCars
                              where car.CustomerId == selectedCus.CustomerId
                                  select car;
               
                    dgvCars.DataSource = CusCars;
            }
        }

        private void btnSelectCar_Click(object sender, EventArgs e)
        {
            try
            {
                tblCar selectedCar = (tblCar)dgvCars.CurrentRow.DataBoundItem;
                lblJobCardsFor.Text = selectedCar.Registration;

                using (LinqDataContext linq = new LinqDataContext())
                {
                    var jobCar = from jobs in linq.tblJobCards
                                 where selectedCar.Registration == jobs.Registration
                                 select jobs;

                    if (jobCar.Any())
                    {
                        dgvJobCards.DataSource = jobCar;
                    }
                    else
                    {
                        dgvJobCards.DataSource = jobCar;
                        MessageBox.Show($"There are no jobs assigned to this car. Add a job");
                    }
                }
              
            }
            catch
            {
                MessageBox.Show($"Error: No car selected"); 
            }

        }

        private void btnAddJob_Click(object sender, EventArgs e)
        {
            try
            {
                using (LinqDataContext linq = new LinqDataContext())
                {

                    tblCar selectedCar = (tblCar)dgvCars.CurrentRow.DataBoundItem;

                    tblJobCard newJobCard = new tblJobCard
                    {
                        Description = cmbJobs.SelectedItem.ToString(),
                        UserId = int.Parse(cmbMechanics.SelectedItem.ToString()),
                        Registration = selectedCar.Registration,
                        StartDate = DateTime.Parse(dtpStartDate.Text),
                        CompletionDate = DateTime.Parse(dtpCompletionDate.Text)
                    };

                    linq.tblJobCards.InsertOnSubmit(newJobCard);
                    linq.SubmitChanges();

                    MessageBox.Show($"New Job {newJobCard.Description} added to {newJobCard.Registration}");
                    DisplayJobs();
                }
            }catch
            {
                MessageBox.Show($"Error: You cannot add a job without selecting a car"); 
            }

        }

        private void DisplayJobs()
        {
            dgvJobCards.DataSource = null;
            tblCar selectedCar = (tblCar)dgvCars.CurrentRow.DataBoundItem;
            using (LinqDataContext linq = new LinqDataContext())
            {
                var jobCards = from job in linq.tblJobCards
                               where job.Registration == selectedCar.Registration
                               select job;

                dgvJobCards.DataSource = jobCards;
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {

            MainMenu mMenu = new MainMenu(UserID);
            mMenu.Show();
            this.Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            dgvJobCards.DataSource = null;
            dgvCars.DataSource = null;
            dgvCustomers.DataSource = null;
            txtCusFName.Clear();
            txtCusLName.Clear();
            txtcusPhone.Clear();
            txtcusEmail.Clear();
            lblJobCardsFor.Hide();
            lblCarslabel.Hide();
            txtMake.Clear();
            txtModel.Clear();
            txtReg.Clear();                                   
        }

        private void btnEditCar_Click(object sender, EventArgs e)
        {
            try
            {
                int rowIndex = GetCurrentIndex2();

                string selectedCarReg = GetCarReg(rowIndex);

                using (LinqDataContext linq = new LinqDataContext())
                {
                    var carToUpdate = (from car in linq.tblCars
                                            where car.Registration == selectedCarReg.ToString()
                                            select car).First();

                    if (carToUpdate != null)
                    {
                       
                        carToUpdate.CarMake = Convert.ToString(dgvCars.Rows[rowIndex].Cells[1].Value);
                        carToUpdate.Model = Convert.ToString(dgvCars.Rows[rowIndex].Cells[2].Value);
                      
                                
                        try
                        {
                            linq.SubmitChanges();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                            throw;
                        }
                    }

                }
            }
            catch
            {
                MessageBox.Show($"Error: You have not selected a car to edit");
            }
        }

        private string GetCarReg(int rowIndex)
        {
            return Convert.ToString(dgvCars.Rows[rowIndex].Cells[0].Value);
        }

        private int GetCurrentIndex2()
        {
            int rowIndex = dgvCars.CurrentRow.Index;

            return rowIndex;
        }

        private void btnEditJobCards_Click(object sender, EventArgs e)
        {
            try
            {
                int rowIndex = GetCurrentIndex3();

                int selectedJobCardId = GetJobCardId(rowIndex);

                using (LinqDataContext linq = new LinqDataContext())
                {
                    var jobToUpdate = (from job in linq.tblJobCards
                                       where job.JobCardId == selectedJobCardId
                                       select job).First();

                    if (jobToUpdate != null)
                    {

                        jobToUpdate.Description= Convert.ToString(dgvJobCards.Rows[rowIndex].Cells[1].Value);
                        jobToUpdate.UserId = Convert.ToInt32(dgvJobCards.Rows[rowIndex].Cells[2].Value);
                        jobToUpdate.StartDate = Convert.ToDateTime(dgvJobCards.Rows[rowIndex].Cells[3].Value);
                        jobToUpdate.CompletionDate = Convert.ToDateTime(dgvJobCards.Rows[rowIndex].Cells[4].Value);


                        try
                        {
                            linq.SubmitChanges();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                            throw;
                        }
                    }

                }
            }
            catch
            {
                MessageBox.Show($"Error: You have not selected a jobCard to edit");
            }
        }

        private int GetJobCardId(int rowIndex)
        {
            return Convert.ToInt32(dgvJobCards.Rows[rowIndex].Cells[0].Value);
        }

        private int GetCurrentIndex3()
        {
            int rowIndex = dgvJobCards.CurrentRow.Index;

            return rowIndex;
        }

        private void btnDeleteJobCard_Click(object sender, EventArgs e)
        {
            try
            {
                int rowIndex = GetCurrentIndex3();

                int selectedJobCardId = GetJobCardId(rowIndex);

                using (LinqDataContext linq = new LinqDataContext())
                {
                    var jobCardToDelete = (from jobs in linq.tblJobCards
                                           where jobs.JobCardId == selectedJobCardId
                                           select jobs).First();

                    if (jobCardToDelete != null)
                    {
                        linq.tblJobCards.DeleteOnSubmit(jobCardToDelete);
                        linq.SubmitChanges();
                        MessageBox.Show($"{jobCardToDelete.JobCardId} {jobCardToDelete.Description} deleted");
                        DisplayJobs();
                    }
                }
            }
            catch
            {
                MessageBox.Show($"Error: You have not selected a job card to delete");
            }
         
        }

        private void btnSearchCar_Click(object sender, EventArgs e)
        {
            dgvCars.DataSource = null;

            if (txtReg.Text != "")
            {
                using (LinqDataContext linq = new LinqDataContext())
                {
                    var searchedCar = from Car in linq.tblCars
                                      where Car.Registration == txtReg.Text
                                      select Car;

                    if (searchedCar.Any())
                    {
                        dgvCars.DataSource = searchedCar;
                    }
                    else
                    {
                        MessageBox.Show($"No car with that registration on file");
                    }
                }
            }
            else MessageBox.Show($"Error: Enter a Registration");
        }
    }
} 