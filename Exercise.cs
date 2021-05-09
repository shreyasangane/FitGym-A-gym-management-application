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
    public partial class Exercise : Form
    {
        public Exercise()
        {
            InitializeComponent();
        }

        Bodyparts_Info_Class c = new Bodyparts_Info_Class();
        Exercise_Info_Class d = new Exercise_Info_Class();

        string list;
        string bpart, listexer, listcount; 
        
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            list = listBox1.GetItemText(listBox1.SelectedItem);
            txtupdtparts.Text = list;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void lblcustomer_Click(object sender, EventArgs e)
        {
            Home hm = new Home();
            hm.Show();
            Visible = false;
        }

        private void btnupdateexer_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {         
            d.Exercise = txtaddexercise.Text;
            d.Daily_Expected_Count = txtadddec.Text;
           // d.Body_Parts = cbSelectBodyPart.Text;

            bool success = d.Insert(d);
            if (success == true)
            {
                MessageBox.Show("Exercise Added");
                Page_Load2();


            }
            else
            {
                MessageBox.Show("Failed to Add");
            }
        }

        private void btnAddparts_Click(object sender, EventArgs e)
        {
            c.Body_Parts = txtaddparts.Text;
            // bool createsuccess = c.Create(c);
            bool success = c.Insert(c);
            if (success == true)
            {
                MessageBox.Show("Body Part Added");
                Page_Load2();
               

            }
            else
            {
                MessageBox.Show("Failed to Add");
            }
        }

        private void txtaddparts_TextChanged(object sender, EventArgs e)
        {

        }

       

        private void txtupdtparts_TextChanged(object sender, EventArgs e)
        {

        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            list = listBox1.GetItemText(listBox1.SelectedItem);

            c.Body_Parts = list;

          //  bool tabledeletesuccess = c.TableDelete(c);
            bool success = c.Delete(c);

            if (success == true)
            {
                MessageBox.Show("deleted");
                Page_Load2();
            }
            else
            {
                MessageBox.Show("failed");
            }
        }

        public void Page_Load2(){
            this.bodyparts_InfoTableAdapter.Fill(this.fITZONEDataSet.Bodyparts_Info);
           // this.exercise_InfoTableAdapter.Fill(this.fITZONEDataSet1.Exercise_Info);

            d.Body_Parts = cbSelectBodyPart.Text;


            DataTable dt = d.Select(d);

            listboxexercise.DataSource = dt;
            listboxexercise.DisplayMember = "Exercise";
            listboxexercise.ValueMember = "Exercise";

            listboxcount.DataSource = dt;
            listboxcount.DisplayMember = "Daily_Expected_Count";
            listboxcount.ValueMember = "Daily_Expected_Count";

            txtaddexercise.Text = "";
            txtadddec.Text = "";
            txtupdateexerise.Text = "";
            txtupdatedecount.Text = "";
        }
        
        private void Page_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'fITZONEDataSet1.Exercise_Info' table. You can move, or remove it, as needed.            
            this.bodyparts_InfoTableAdapter.Fill(this.fITZONEDataSet.Bodyparts_Info);
           
            d.Body_Parts = cbSelectBodyPart.Text;


            DataTable dt = d.Select(d);

            listboxexercise.DataSource = dt;
            listboxexercise.DisplayMember = "Exercise";
            listboxexercise.ValueMember = "Exercise";

            listboxcount.DataSource = dt;
            listboxcount.DisplayMember = "Daily_Expected_Count";
            listboxcount.ValueMember = "Daily_Expected_Count";

        }

        private void btnUpdateparts_Click(object sender, EventArgs e)
        {
            list = listBox1.GetItemText(listBox1.SelectedItem);
            c.OB = list;  // stores oriiginal part
            c.Body_Parts = txtupdtparts.Text;  //stores changed part
            bool success = c.Update(c);

            if (success == true)
            {
                MessageBox.Show("Updated");
                Page_Load2();
            }
            else
            {
                MessageBox.Show("failed");
            }

        }

        private void listboxexercise_SelectedIndexChanged(object sender, EventArgs e)
        {
            listexer = listboxexercise.GetItemText(listboxexercise.SelectedItem);
            txtupdateexerise.Text = listexer;
        }

        private void cbSelectBodyPart_SelectedIndexChanged(object sender, EventArgs e)
        {
            list = listBox1.GetItemText(listBox1.SelectedItem);
            bpart = cbSelectBodyPart.Text;

            d.Body_Parts = bpart;


            DataTable dt = d.Select(d);
            listboxexercise.DataSource = dt;
            listboxexercise.DisplayMember = "Exercise";
            listboxexercise.ValueMember = "Exercise";

            listboxcount.DataSource = dt;
            listboxcount.DisplayMember = "Daily_Expected_Count";
            listboxcount.ValueMember = "Daily_Expected_Count";
           
        }

        private void listboxcount_SelectedIndexChanged(object sender, EventArgs e)
        {
           listcount = listboxcount.GetItemText(listboxexercise.SelectedItem);
           txtupdatedecount.Text = listcount;
            
        }

        private void btnupdtdecount_Click(object sender, EventArgs e)
        {
            listexer = listboxexercise.GetItemText(listboxexercise.SelectedItem);
            listcount = listboxcount.GetItemText(listboxexercise.SelectedItem);
            d.UPDExercise = listexer; // stores oriiginal part
            d.Exercise = txtupdateexerise.Text; //stores changed part
            d.UPDDaily_Expected_Count = listcount;  // stores oriiginal part
            d.Daily_Expected_Count = txtupdatedecount.Text; //stores changed part
            
            bool success = d.Update(d);

            if (success == true)
            {
                MessageBox.Show("Updated");
                Page_Load2();
            }
            else
            {
                MessageBox.Show("failed");
            }
        }

        private void btndeleteexercise_Click(object sender, EventArgs e)
        {
            listexer = listboxexercise.GetItemText(listboxexercise.SelectedItem);

            d.Exercise = listexer;

            bool success = d.Delete(d);

            if (success == true)
            {
                MessageBox.Show("deleted");
                Page_Load2();
            }
            else
            {
                MessageBox.Show("failed");
            }
        }

       
    }
}
