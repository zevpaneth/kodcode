using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace employee
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                int code = int.Parse(txtCode.Text);
                string id = txtId.Text;
                string firstName = txtFirstName.Text;
                string lastName = txtLastName.Text;
                DateTime birthDate = dtpBirthDate.Value;
                string phoneNumber = txtPhoneNumber.Text;
                string callNumber = txtCallNumber.Text;
                string street = txtStreet.Text;
                string houseNumber = txtHouseNumber.Text;
                string city = txtCity.Text;
                bool isMale = GetMale();
                string status = GetStatus();

                Employee employee = new Employee(code, id, firstName, lastName, birthDate, phoneNumber, callNumber, street, houseNumber, city, isMale, status);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error creating employee: " + ex.Message);
            }
        }

        private bool GetMale()
        {
            return rdbMale.Checked;
        }

        private string GetStatus()
        {
            if (rdbSingle.Checked)
            {
                return rdbSingle.Text;
            }
            else if (rdbMarried.Checked)
            {
                return rdbMarried.Text;
            }
            else if (rdbDivorcee.Checked)
            {
                return rdbDivorcee.Text;
            }
            else if (rdbWidower.Checked)
            {
                return rdbWidower.Text;
            }

            return string.Empty;
        }

        

        private void btnNew_Click(object sender, EventArgs e)
        {
            txtAge.Text = string.Empty;
            txtCallNumber.Text = string.Empty;
            txtCity.Text = string.Empty;
            txtFirstName.Text = string.Empty;
            txtLastName.Text = string.Empty;
            txtCode.Text = string.Empty;
            txtHouseNumber.Text = string.Empty;
            txtId.Text = string.Empty;
            txtPhoneNumber.Text = string.Empty;
            txtStreet.Text = string.Empty;
            
        }

        private void btnAddition_Click(object sender, EventArgs e)
        {
            Employee employee = new Employee(int.Parse(txtCode.Text))
        }

        private void txtCode_TextChanged(object sender, EventArgs e)
        {
            if 
        }
    }
}
