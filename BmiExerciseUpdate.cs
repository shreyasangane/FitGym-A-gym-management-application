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
    public partial class BmiExerciseUpdate : Form
    {
        public BmiExerciseUpdate()
        {
            InitializeComponent();
        }

        BMI_Exercise_Info_Class c = new BMI_Exercise_Info_Class();

        static string myconnstrng = ConfigurationManager.ConnectionStrings["connstrng"].ConnectionString;
       

        private void lblcustomer_Click(object sender, EventArgs e)
        {
            Home hm = new Home();
            hm.Show();
            Visible = false;
        }

        private void BmiExerciseUpdate_Load(object sender, EventArgs e)
        {
          
            this.bMI_Exercise_InfoTableAdapter2.Fill(this.fITZONEDataSet6.BMI_Exercise_Info);          
         //   this.bodyparts_InfoTableAdapter1.Fill(this.fITZONEDataSet5.Bodyparts_Info);          
            this.bodyparts_InfoTableAdapter.Fill(this.fITZONEDataSet7.Bodyparts_Info);
            SqlConnection conn = new SqlConnection(myconnstrng);
            conn.Open();
            SqlCommand cmd1 = conn.CreateCommand();
            cmd1.CommandType = CommandType.Text;
            cmd1.CommandText = "SELECT DISTINCT BMIClass FROM BMI_Exercise_Info";
            cmd1.ExecuteNonQuery();

            DataTable dt1 = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd1);

            da.Fill(dt1);

            foreach (DataRow dr in dt1.Rows)
            {
                comboBox1.Items.Add(dr["BMIClass"].ToString());

            }
            //-----------------------------------------------------
            SqlCommand cmd2 = conn.CreateCommand();
            cmd2.CommandType = CommandType.Text;
            cmd2.CommandText = "SELECT DISTINCT Day_Name FROM BMI_Exercise_Info";
            cmd2.ExecuteNonQuery();

            DataTable dt2 = new DataTable();
            SqlDataAdapter db = new SqlDataAdapter(cmd2);

            db.Fill(dt2);

            foreach (DataRow dr in dt2.Rows)
            {
                comboBox2.Items.Add(dr["Day_Name"].ToString());

            }

            //--------------------


            conn.Close();
            
        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.bMI_Exercise_InfoTableAdapter.FillBy(this.fITZONEDataSet2.BMI_Exercise_Info);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillBy1ToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.bMI_Exercise_InfoTableAdapter.FillBy1(this.fITZONEDataSet2.BMI_Exercise_Info);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillBy2ToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.bMI_Exercise_InfoTableAdapter.FillBy2(this.fITZONEDataSet2.BMI_Exercise_Info);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lblchange_Click(object sender, EventArgs e)
        {
            c.BMIClass = comboBox1.Text;
            c.Day_Name = comboBox2.Text;

         /*   var lst = lbbodyparts.SelectedItems.Cast<DataRowView>();
           
            foreach (var item in lst)
            {
                MessageBox.Show(item.Row[0].ToString()); // Or Row[1]...
               
            }
           */
            
         //   c.Body_Part1 = listselected[0];
           // c.Body_Part2 = listselected[1];
            c.Body_Part1 = lbbodyparts.GetItemText(lbbodyparts.SelectedItem);
            

            bool success = c.Update(c);

            if (success == true)
            {
                MessageBox.Show("Updated");
                Page_Load2();
            }
            else
            {
                MessageBox.Show(" Updation failed");
            }
        }

        public void Page_Load2()
        {
            this.bMI_Exercise_InfoTableAdapter2.Fill(this.fITZONEDataSet6.BMI_Exercise_Info);          
        //    this.bodyparts_InfoTableAdapter1.Fill(this.fITZONEDataSet5.Bodyparts_Info);
            this.bodyparts_InfoTableAdapter.Fill(this.fITZONEDataSet7.Bodyparts_Info);
            //SqlConnection conn = new SqlConnection(myconnstrng);
            //conn.Open();
            //SqlCommand cmd1 = conn.CreateCommand();
            //cmd1.CommandType = CommandType.Text;
            //cmd1.CommandText = "SELECT DISTINCT BMIClass FROM BMI_Exercise_Info";
            //cmd1.ExecuteNonQuery();

            //DataTable dt1 = new DataTable();
            //SqlDataAdapter da = new SqlDataAdapter(cmd1);

            //da.Fill(dt1);

            //foreach (DataRow dr in dt1.Rows)
            //{
            //    comboBox1.Items.Add(dr["BMIClass"].ToString());

            //}
            ////-----------------------------------------------------
            //SqlCommand cmd2 = conn.CreateCommand();
            //cmd2.CommandType = CommandType.Text;
            //cmd2.CommandText = "SELECT DISTINCT Day_Name FROM BMI_Exercise_Info";
            //cmd2.ExecuteNonQuery();

            //DataTable dt2 = new DataTable();
            //SqlDataAdapter db = new SqlDataAdapter(cmd2);

            //db.Fill(dt2);

            //foreach (DataRow dr in dt2.Rows)
            //{
            //    comboBox2.Items.Add(dr["Day_Name"].ToString());

            //}

            ////--------------------


            //conn.Close();
            
        }

        private void lbbodyparts_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
