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
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void Home_Load(object sender, EventArgs e)
        {

        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Customerinfo cust = new Customerinfo();
            cust.Show();
            Visible = false;

        }

        private void lblcustomer_Click(object sender, EventArgs e)
        {
            Home hm = new Home();
            hm.Show();
            Visible = false;
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            EmployeeInfo emp = new EmployeeInfo();
            emp.Show();
            Visible = false;

        }

        private void lblsearchempcust_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SearchEmpCust search = new SearchEmpCust();
            search.Show();
            Visible = false;
        }

        private void lbladdprogress_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AddUpdateProgress aup = new AddUpdateProgress();
            aup.Show();
            Visible = false;
        }

        private void lblprogress_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MonthlyReport mr = new MonthlyReport();
            mr.Show();
            Visible = false;
        }

        private void linkExercise_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Exercise exer = new Exercise();
            exer.Show();
            Visible = false;            
        }

        private void linkLabel3_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            BmiExerciseUpdate BMU = new BmiExerciseUpdate();
            BMU.Show();
            Visible = false;
        }
    }
}
