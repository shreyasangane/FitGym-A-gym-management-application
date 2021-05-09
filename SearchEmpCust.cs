using FITZONE.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FITZONE
{
    public partial class SearchEmpCust : Form
    {
        public SearchEmpCust()
        {
            InitializeComponent();
        }
        string selection;
        Search_Cust_Emp_Class d = new Search_Cust_Emp_Class();
        SqlDataAdapter sda;

        private void SearchEmpCust_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void lblempsearch_Click(object sender, EventArgs e)
        {

        }

        private void lblcustomer_Click(object sender, EventArgs e)
        {
            Home hm = new Home();
            hm.Show();
            Visible = false;
        }
        
        static string myconnstrng = ConfigurationManager.ConnectionStrings["connstrng"].ConnectionString;

        private void txtsearchcustomer_TextChanged(object sender, EventArgs e)
        {
            string keyword = txtsearchcustomer.Text;
            SqlConnection conn = new SqlConnection(myconnstrng);
            
            if (rbCustomer.Checked)
            {
                 sda = new SqlDataAdapter("SELECT * FROM Customer_Info WHERE Customer_Name LIKE '%" + keyword + "%' ", conn);
            }

            if (rbEmployee.Checked)
            {
                 sda = new SqlDataAdapter("SELECT * FROM Employee_Info WHERE Employee_Name LIKE '%" + keyword + "%' ", conn);
            }

            DataTable dt = new DataTable();

            sda.Fill(dt);
            dgvcustemp.DataSource = dt;
            

        }

        private void rbCustomer_CheckedChanged(object sender, EventArgs e)
        {
            if (rbCustomer.Checked)
            {
                DataTable dt = d.SelectCust(d);

                dgvcustemp.DataSource = dt;
  
            }
        }

        private void rbEmployee_CheckedChanged(object sender, EventArgs e)
        {
            if (rbEmployee.Checked)
            {
                DataTable dt = d.SelectEmp(d);

                dgvcustemp.DataSource = dt;

            }
        }
    }
}
