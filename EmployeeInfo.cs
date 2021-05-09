using FITZONE.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FITZONE
{
    public partial class EmployeeInfo : Form
    {
        public EmployeeInfo()
        {
            InitializeComponent();
        }

        Employee_Info_Class c = new Employee_Info_Class();

        private void lblcustomer_Click(object sender, EventArgs e)
        {
            Home hm = new Home();
            hm.Show();
            Visible = false;
        }

        private void btnempsubmit_Click(object sender, EventArgs e)
        {
            c.Employee_Name = txtempname.Text;
            c.Address = txtempaddress.Text;
            c.Phone_No = txtempphone.Text;
            c.Email_Id = txtempemail.Text;
            c.Salary = txtempsalary.Text;
            c.Shift_Time = cbempshift.Text;

            if (rbempmale.Checked)
            {
                c.Gender = rbempmale.Text;
            }
            if (rbempfemale.Checked)
            {
                c.Gender = rbempfemale.Text;
            }
            
            c.Age = txtempage.Text;

            bool success = c.Insert(c);
            if (success == true)
            {
                MessageBox.Show("Employee Added");
                btnempclear_Click();

            }
            else
            {
                MessageBox.Show("Failed to Add");
            }
        }

        private void txtempname_TextChanged(object sender, EventArgs e)
        {

        }

        public void btnemp_Clear(object sender, EventArgs e)
        {
            txtempname.Text = "";
            txtempaddress.Text = "";
            txtempphone.Text = "";
            txtempemail.Text = "";
            txtempsalary.Text = "";
            cbempshift.ResetText();
            rbempmale.Checked = false;
            rbempfemale.Checked = false;
            txtempage.Text = "";
            
        }

        public void btnempclear_Click()
        {

        }
    }
}
