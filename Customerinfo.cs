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
    public partial class Customerinfo : Form
    {
        int w; double h,hs,bm;
        public Customerinfo()
        {
            InitializeComponent();
        }

        Customer_Info_Class c = new Customer_Info_Class();

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Home hm = new Home();
            hm.Show();
            Visible = false;
           
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void lblcustomerinforedirect_Click(object sender, EventArgs e)
        {

        }

        private void Customerinfo_Load(object sender, EventArgs e)
        {

        }

        private void txtname_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtaddress_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtphone_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtemail_TextChanged(object sender, EventArgs e)
        {

        }

        private void rbmale_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rbfemale_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void txtage_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtbiceps_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtcalf_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtchest_TextChanged(object sender, EventArgs e)
        {

        }

        private void txthip_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtweight_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void txtheight_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void txtfat_TextChanged(object sender, EventArgs e)
        {

        }

        private void rbsix_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rbyear_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void cbpt_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

       

        private void btnsubmit_Click(object sender, EventArgs e)
        {
            c.Customer_Name = txtname.Text;
            Console.WriteLine(txtname.Text);
            c.Address = txtaddress.Text;
            Console.WriteLine(txtaddress.Text);
            c.Phone_No = txtphone.Text;
            Console.WriteLine(txtphone.Text);
            c.Email_Id = txtemail.Text;
            Console.WriteLine(txtemail.Text);
            if (rbmale.Checked)
            {
                c.Gender = rbmale.Text;
                Console.WriteLine(rbmale.Text);
            }
            if (rbfemale.Checked)
            {
                c.Gender = rbfemale.Text;
                Console.WriteLine(rbfemale.Text);
            }
            c.Age = txtage.Text;
            Console.WriteLine(txtage.Text);
            c.Biceps_Size = txtbiceps.Text;
            Console.WriteLine(txtbiceps.Text);
            c.Back_Size = txtBack.Text;
            Console.WriteLine(txtBack.Text);
            c.Chest_Size = txtchest.Text;
            Console.WriteLine(txtchest.Text);
            c.Triceps_Size = txtriceps.Text;
            Console.WriteLine(txtriceps.Text);
            c.Shoulder_Size = txtShoulder.Text;
            Console.WriteLine(txtShoulder.Text);
            c.Legs_Size = txtLegs.Text;
            Console.WriteLine(txtLegs.Text);
            c.Weight = txtweight.Text;
            Console.WriteLine(txtweight.Text);
            c.Height = txtheight.Text;
            Console.WriteLine(txtheight.Text);
            c.Fat_Percent = txtfat.Text;
            Console.WriteLine(txtfat.Text);

            if (rbsix.Checked)
            {
                c.Package = rbsix.Text;
                Console.WriteLine(rbsix.Text);
            }
            if (rbyear.Checked)
            {

                c.Package = rbyear.Text;
                Console.WriteLine(rbyear.Text);
            }
            c.Personal_Trainer = cbpt.Text;
            Console.WriteLine(cbpt.Text);
            c.Time_Preference = cbTP.Text;
            Console.WriteLine(cbTP.Text);
            c.BMI = lblbmivalue.Text;
            Console.WriteLine(lblbmivalue.Text);
            c.Fees = txtfees.Text;
            Console.WriteLine(txtfees.Text);
            c.Joining_Date = DateTime.Today.Date;
            Console.WriteLine(c.Joining_Date);
            bool success = c.Insert(c);
            bool success2 = c.Insert2(c);

            if (success == true)
            {
                MessageBox.Show("Customer Added");
                clear_Click();

            }
            else
            {
                MessageBox.Show("Failed to Add");
            }

        }

        private void cbTP_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lblbmivalue_Click(object sender, EventArgs e)
        {
            
        }

        private void btncal_Click(object sender, EventArgs e)
        {
            w = Convert.ToInt32(txtweight.Text);
            h = Convert.ToDouble(txtheight.Text);
            hs = h * h;           
            bm = w / hs;
           
            
            lblbmivalue.Text = bm.ToString();
            lblbmivalue.Visible = true;
            
            
        }

        private void lblbmi_Click(object sender, EventArgs e)
        {

        }

        public void btnclear_Click(object sender, EventArgs e)
        {
            txtname.Text = "";
            txtaddress.Text = "";
            txtphone.Text = "";
            txtemail.Text = "";
            rbmale.Checked = false;
            rbfemale.Checked = false;
            txtage.Text = "";
            txtbiceps.Text = "";
            txtBack.Text = "";
            txtchest.Text = "";
            txtriceps.Text = "";
            txtweight.Text = "";
            txtheight.Text = "";
            txtLegs.Text = "";
            txtShoulder.Text = "";
            txtfat.Text = "";
            txtfees.Text = "";
            rbmale.Checked = false;
            rbfemale.Checked = false;
            rbsix.Checked = false;
            rbyear.Checked = false;
            cbpt.ResetText();
            cbTP.ResetText();
            lblbmivalue.Text = "0";
        }

        public void clear_Click()
        {
            txtname.Text = "";
            txtaddress.Text = "";
            txtphone.Text = "";
            txtemail.Text = "";
            rbmale.Checked = false;
            rbfemale.Checked = false;
            txtage.Text = "";
            txtbiceps.Text = "";
            txtBack.Text = "";
            txtchest.Text = "";
            txtriceps.Text = "";
            txtweight.Text = "";
            txtheight.Text = "";
            txtShoulder.Text = "";
            txtLegs.Text = "";
            txtfat.Text = "";
            txtfees.Text = "";
            rbmale.Checked = false;
            rbfemale.Checked = false;
            rbsix.Checked = false;
            rbyear.Checked = false;
            cbpt.ResetText();
            cbTP.ResetText();
            lblbmivalue.Text = "0";
        }

        
    }
}
