using EmployeeApplication.EmployeeInterface;
using System.ComponentModel;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace EmployeeApplication
{
    namespace EmployeeInterface
    {
        //PartTimeEmployee class implements IEmployee interface
        public class PartTimeEmployee : IEmployee
        {
            //Private fields for storing employee information
            private string first_name;
            private string last_name;
            private string department;
            private string job_title;
            private double basic_salary;
            private int hoursworked;
            private double rate;
            private double salary;

            //Constructor to initialize employee information
            public PartTimeEmployee(String FirstName, String LastName, String Department, String Job)
            {
                first_name = FirstName;
                last_name = LastName;
                department = Department;
                job_title = Job;
            }
            //Public properties for accessing employee information
            public String FirstName
            {
                get { return first_name; }
                set { first_name = value; }
            }
            public String LastName
            {
                get { return last_name; }
                set { last_name = value; }
            }
            public String Department
            {
                get { return department; }
                set { department = value; }
            }
            public String JobTitle
            {
                get { return job_title; }
                set { job_title = value; }
            }
            public double BasicSalary
            {
                get { return basic_salary; }
                set { basic_salary = value; }
            }

            //Method to compute salary
            public void computeSalary(int hoursWorked, double ratePerHour)
            {
                hoursworked = hoursWorked;
                rate = ratePerHour;

                double s = hoursworked * rate;
                basic_salary = s;
                salary = basic_salary;

            }
            //Method to get salary
            public double getSalary()
            {
                return salary;
            }
        }
        //IEmployee interface defines properties and method
        interface IEmployee
        {
            public String FirstName { get; set; }
            public String LastName { get; set; }
            public String Department { get; set; }
            public String JobTitle { get; set; }
            public double BasicSalary { get; set; }

            public void computeSalary(int hoursWorked, double ratePerHour);
        }
    }
    public partial class frmComputeSalary : Form
    {
        public frmComputeSalary()
        {
            InitializeComponent();
        }
        private void frmComputeSalary_Load(object sender, EventArgs e)
        {
            //TextBox Placeholders
            txtFIrstName.PlaceholderText = "First Name";
            txtLastName.PlaceholderText = "Last Name";
            txtDepartment.PlaceholderText = "Department";
            txtJob.PlaceholderText = "Job Title";
            txtRPH.PlaceholderText = "Rate Per Hour";
            txtTHW.PlaceholderText = "Total Hours";
        }

        private void btnCompute_Click(object sender, EventArgs e)
        {
            if (txtFIrstName.Text != "" && txtLastName.Text != "" && txtDepartment.Text != "" && txtJob.Text != "" && txtRPH.Text != "" && txtTHW.Text != "")
            {
                
                PartTimeEmployee PTE = new PartTimeEmployee(txtFIrstName.Text, txtLastName.Text, txtDepartment.Text, txtJob.Text);
                PTE.computeSalary(int.Parse(txtTHW.Text), double.Parse(txtRPH.Text));
                lblFirstName.Text = txtFIrstName.Text;
                lblLastName.Text = txtLastName.Text;
                lblSalary.Text = Convert.ToString("$" + PTE.getSalary());
                lblDepartment.Text = txtDepartment.Text;
                lblJobTitle.Text = txtJob.Text;
            }
            else
            {
                MessageBox.Show("Please complete the form!", "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //Clear fields
        private void btnClear_Click(object sender, EventArgs e)
        {
            txtFIrstName.Text = "";
            txtLastName.Text = "";
            txtDepartment.Text = "";
            txtJob.Text = "";
            txtRPH.Text = "";
            txtTHW.Text = "";
            lblFirstName.Text = "";
            lblLastName.Text = "";
            lblSalary.Text = "";
            lblDepartment.Text = "";
            lblJobTitle.Text = "";
        }
        //Validations
        private void txtFIrstName_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(txtFIrstName.Text))
            {
                
                TextValidation.SetError(txtFIrstName, "Please enter your first name!");
                e.Cancel = true;
            }
            else if (!Regex.IsMatch(txtFIrstName.Text, @"^[a-zA-Z]+$"))
            {
                TextValidation.SetError(txtFIrstName, "Please enter alphabetical characters only.");
                e.Cancel = true;
            }
            else
            {
                TextValidation.SetError(txtFIrstName, "");
            }
        }

        private void txtLastName_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(txtLastName.Text))
            {
                TextValidation.SetError(txtLastName, "Please enter your last name!");
                e.Cancel = true;
            }
            else if (!Regex.IsMatch(txtLastName.Text, @"^[a-zA-Z]+$"))
            {
                TextValidation.SetError(txtLastName, "Please enter alphabetical characters only.");
                e.Cancel = true;
            }
            else
            {
                TextValidation.SetError(txtLastName, "");
            }
        }

        private void txtDepartment_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(txtDepartment.Text))
            {
                TextValidation.SetError(txtDepartment, "Please enter your department!");
                txtDepartment.Focus();
                e.Cancel = true;
            }
            else if (!Regex.IsMatch(txtDepartment.Text, @"^[a-zA-Z]+$"))
            {
                TextValidation.SetError(txtDepartment, "Please enter alphabetical characters only.");
                e.Cancel = true;
            }
            else
            {
                TextValidation.SetError(txtDepartment, "");
            }
        }

        private void txtJob_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(txtJob.Text))
            {
                TextValidation.SetError(txtJob, "Please enter your job!");
                e.Cancel = true;
            }
            else if (!Regex.IsMatch(txtJob.Text, @"^[a-zA-Z]+$"))
            {
                TextValidation.SetError(txtJob, "Please enter alphabetical characters only.");
                e.Cancel = true;
            }
            else
            {
                TextValidation.SetError(txtJob, "");
            }
        }

        private void txtRPH_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtRPH.Text))
            {
                TextValidation.SetError(txtRPH, "Please enter your rate per hour!");
                e.Cancel = true;
            }
            else if (!Regex.IsMatch(txtRPH.Text, @"^[0-9]+(\.[0-9]+)?$"))
            {
                TextValidation.SetError(txtRPH, "Please enter numeric characters only.");
                e.Cancel = true;
            }
            else
            {
                TextValidation.SetError(txtRPH, "");
            }
        }

        private void txtTHW_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtTHW.Text))
            {
                TextValidation.SetError(txtTHW, "Please enter your total hours worked!");
                e.Cancel = true;
            }
            else if (!Regex.IsMatch(txtTHW.Text, @"^[0-9]+$"))
            {
                TextValidation.SetError(txtTHW, "Please enter numeric characters only.");
                e.Cancel = true;
            }
            else
            {
                TextValidation.SetError(txtTHW, "");
            }
        }
    }
}
