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
    public partial class AddUpdateProgress : Form
    {
        public AddUpdateProgress()
        {
            InitializeComponent();
        }
        AddUpdateProgress_Info_Class c = new AddUpdateProgress_Info_Class();
        

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

        private void AddUpdateProgress_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'fITZONEDataSet8.Customer_Info' table. You can move, or remove it, as needed.
            this.customer_InfoTableAdapter.Fill(this.fITZONEDataSet8.Customer_Info);
            tbday.Text = DateTime.Now.DayOfWeek.ToString();
            tbdate.Text = DateTime.Today.ToString("d/M/yyyy");

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void lblcustomer_Click(object sender, EventArgs e)
        {
            Home hm = new Home();
            hm.Show();
            Visible = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

       

        private void cbsearchcust_SelectedIndexChanged(object sender, EventArgs e)
        {
            string name = cbsearchcust.Text;
            
            c.Customer_Name = name;
            DataTable dt = c.Select1(c);
            foreach (DataRow row in dt.Rows)
             {
            // ... Write value of first field as integer.
                 txtBMI.Text = row[0].ToString();
             }
            string BMI = txtBMI.Text;
            float BM = float.Parse(BMI);

            c.BMI = BM;
            c.Day_Name = tbday.Text;

            DataTable dt2 = c.Select2(c);
            foreach (DataRow row in dt2.Rows)
            {
                // ... Write value of first field as integer.
                txtFocus.Text = row[0].ToString();
            }
                                                                           
            
        }
        int B = 1,E=1; int h = 0; int L = 0;
        private void txtFocus_TextChanged(object sender, EventArgs e)
        {
            c.Body_Parts = txtFocus.Text;
            DataTable dt = c.Select3(c);
            foreach (DataRow row in dt.Rows)
            {
                System.Windows.Forms.Label lbl = new System.Windows.Forms.Label();
                this.Controls.Add(lbl);
                lbl.Top = 200 + h;
                lbl.Left = 100;
                lbl.Name = "LblDyn" + this.E.ToString(); 
                lbl.Text = row[0].ToString();
                E = E + 1;
                h = h + 40;
              
            }

            foreach (DataRow row in dt.Rows)
            {
                System.Windows.Forms.TextBox txt = new System.Windows.Forms.TextBox();
                this.Controls.Add(txt);
                txt.Top = 200 + L;
                txt.Left =300;
                txt.Name = "TextBox" + this.B.ToString(); 
                Console.WriteLine(txt.Name);
                B = B + 1;
                L = L + 40;
                
            }
      //      int count = dt.Rows.Count;
         /*   for (int i = 1; i <= count; i++)
            {

                System.Windows.Forms.Label lbl = new System.Windows.Forms.Label();
                this.Controls.Add(lbl);
                lbl.Top = 200 + h;
                lbl.Left = 100;
                lbl.Text = "labels" + this.B.ToString();
                B = B + 1;
                h = h + 40;
            }   */
        }



        private void button1_Click(object sender, EventArgs e)
        {
            c.Body_Parts = txtFocus.Text;
            DataTable dt = c.Select3(c);
            int ct = dt.Rows.Count;
            // MessageBox.Show(ct.ToString());
            string[] t = new string[ct];

            /*    foreach (Control r in this.Controls)
              {
                  if (r is TextBox)
                  {
                      TextBox cb = r as TextBox;
                      MessageBox.Show(cb .Text);
                  }

              }
            */
            bool success;
            
            
                c.Day_Name = tbday.Text;
                c.Date = DateTime.Today.Date;
                c.ctcount = ct;
                c.Customer_Name = cbsearchcust.Text;
                c.Focus = txtFocus.Text;
                if (ct == 1)
                {
                    c.Exercise_Count1 = ((TextBox)this.Controls["TextBox" + (1).ToString()]).Text;
                }
                if (ct == 2)
                {
                    c.Exercise_Count1 = ((TextBox)this.Controls["TextBox" + (1).ToString()]).Text;
                    c.Exercise_Count2 = ((TextBox)this.Controls["TextBox" + (2).ToString()]).Text;

                }
                if (ct == 3)
                {
                    c.Exercise_Count1 = ((TextBox)this.Controls["TextBox" + (1).ToString()]).Text;
                    c.Exercise_Count2 = ((TextBox)this.Controls["TextBox" + (2).ToString()]).Text;
                    c.Exercise_Count3 = ((TextBox)this.Controls["TextBox" + (3).ToString()]).Text;
                }

                if (ct == 4)
                {
                    c.Exercise_Count1 = ((TextBox)this.Controls["TextBox" + (1).ToString()]).Text;
                    c.Exercise_Count2 = ((TextBox)this.Controls["TextBox" + (2).ToString()]).Text;
                    c.Exercise_Count3 = ((TextBox)this.Controls["TextBox" + (3).ToString()]).Text;
                    c.Exercise_Count4 = ((TextBox)this.Controls["TextBox" + (4).ToString()]).Text;
                }
                if (ct == 5)
                {
                    c.Exercise_Count1 = ((TextBox)this.Controls["TextBox" + (1).ToString()]).Text;
                    c.Exercise_Count2 = ((TextBox)this.Controls["TextBox" + (2).ToString()]).Text;
                    c.Exercise_Count3 = ((TextBox)this.Controls["TextBox" + (3).ToString()]).Text;
                    c.Exercise_Count4 = ((TextBox)this.Controls["TextBox" + (4).ToString()]).Text;
                    c.Exercise_Count5 = ((TextBox)this.Controls["TextBox" + (5).ToString()]).Text;
                }
                if (ct == 6)
                {
                    c.Exercise_Count1 = ((TextBox)this.Controls["TextBox" + (1).ToString()]).Text;
                    c.Exercise_Count2 = ((TextBox)this.Controls["TextBox" + (2).ToString()]).Text;
                    c.Exercise_Count3 = ((TextBox)this.Controls["TextBox" + (3).ToString()]).Text;
                    c.Exercise_Count4 = ((TextBox)this.Controls["TextBox" + (4).ToString()]).Text;
                    c.Exercise_Count5 = ((TextBox)this.Controls["TextBox" + (5).ToString()]).Text;
                    c.Exercise_Count6 = ((TextBox)this.Controls["TextBox" + (6).ToString()]).Text;                   
                }
                if (ct == 7)
                {
                    c.Exercise_Count1 = ((TextBox)this.Controls["TextBox" + (1).ToString()]).Text;
                    c.Exercise_Count2 = ((TextBox)this.Controls["TextBox" + (2).ToString()]).Text;
                    c.Exercise_Count3 = ((TextBox)this.Controls["TextBox" + (3).ToString()]).Text;
                    c.Exercise_Count4 = ((TextBox)this.Controls["TextBox" + (4).ToString()]).Text;
                    c.Exercise_Count5 = ((TextBox)this.Controls["TextBox" + (5).ToString()]).Text;
                    c.Exercise_Count6 = ((TextBox)this.Controls["TextBox" + (6).ToString()]).Text;
                    c.Exercise_Count7 = ((TextBox)this.Controls["TextBox" + (7).ToString()]).Text;
                }
                if (ct == 8)
                {
                    c.Exercise_Count1 = ((TextBox)this.Controls["TextBox" + (1).ToString()]).Text;
                    c.Exercise_Count2 = ((TextBox)this.Controls["TextBox" + (2).ToString()]).Text;
                    c.Exercise_Count3 = ((TextBox)this.Controls["TextBox" + (3).ToString()]).Text;
                    c.Exercise_Count4 = ((TextBox)this.Controls["TextBox" + (4).ToString()]).Text;
                    c.Exercise_Count5 = ((TextBox)this.Controls["TextBox" + (5).ToString()]).Text;
                    c.Exercise_Count6 = ((TextBox)this.Controls["TextBox" + (6).ToString()]).Text;
                    c.Exercise_Count7 = ((TextBox)this.Controls["TextBox" + (7).ToString()]).Text;
                    c.Exercise_Count8 = ((TextBox)this.Controls["TextBox" + (8).ToString()]).Text;
                }
                if (ct == 9)
                {
                    c.Exercise_Count1 = ((TextBox)this.Controls["TextBox" + (1).ToString()]).Text;
                    c.Exercise_Count2 = ((TextBox)this.Controls["TextBox" + (2).ToString()]).Text;
                    c.Exercise_Count3 = ((TextBox)this.Controls["TextBox" + (3).ToString()]).Text;
                    c.Exercise_Count4 = ((TextBox)this.Controls["TextBox" + (4).ToString()]).Text;
                    c.Exercise_Count5 = ((TextBox)this.Controls["TextBox" + (5).ToString()]).Text;
                    c.Exercise_Count6 = ((TextBox)this.Controls["TextBox" + (6).ToString()]).Text;
                    c.Exercise_Count7 = ((TextBox)this.Controls["TextBox" + (7).ToString()]).Text;
                    c.Exercise_Count8 = ((TextBox)this.Controls["TextBox" + (8).ToString()]).Text;
                    c.Exercise_Count9 = ((TextBox)this.Controls["TextBox" + (9).ToString()]).Text;
                }

                if (ct == 10)
                {
                    c.Exercise_Count1 = ((TextBox)this.Controls["TextBox" + (1).ToString()]).Text;
                    c.Exercise_Count2 = ((TextBox)this.Controls["TextBox" + (2).ToString()]).Text;
                    c.Exercise_Count3 = ((TextBox)this.Controls["TextBox" + (3).ToString()]).Text;
                    c.Exercise_Count4 = ((TextBox)this.Controls["TextBox" + (4).ToString()]).Text;
                    c.Exercise_Count5 = ((TextBox)this.Controls["TextBox" + (5).ToString()]).Text;
                    c.Exercise_Count6 = ((TextBox)this.Controls["TextBox" + (6).ToString()]).Text;
                    c.Exercise_Count7 = ((TextBox)this.Controls["TextBox" + (7).ToString()]).Text;
                    c.Exercise_Count8 = ((TextBox)this.Controls["TextBox" + (8).ToString()]).Text;
                    c.Exercise_Count9 = ((TextBox)this.Controls["TextBox" + (9).ToString()]).Text;
                    c.Exercise_Count10 = ((TextBox)this.Controls["TextBox" + (10).ToString()]).Text;
                }   
              
                                                           
              //  MessageBox.Show(c.Customer_Name);
              //  MessageBox.Show(c.Exercise_Name);
                success = c.Insert(c);

                if (success == true)
                {
                    MessageBox.Show("Added");
                }
                              

        }


    }
}
