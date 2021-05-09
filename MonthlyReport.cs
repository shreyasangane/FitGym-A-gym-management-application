using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;
using FITZONE.Classes;
using System.Configuration;
using System.Data.SqlClient;

namespace FITZONE
{
    public partial class MonthlyReport : Form
    {
        int w; double h, hs, bm;
        string[] arr_legs = new string[20]; int li = 0, ci=0, si=0, bai=0, bpi=0 , ti=0; DateTime Last_Report;
        string[] arr_shoulder = new string[20];
        string[] arr_back = new string[20];
        string[] arr_biceps = new string[20];
        string[] arr_triceps = new string[20];
        string[] arr_chest = new string[20];

        int[] arr_exp_legs = new int[20];
        int[] arr_exp_shoulder = new int[20];
        int[] arr_exp_back = new int[20];
        int[] arr_exp_biceps = new int[20];
        int[] arr_exp_triceps = new int[20];
        int[] arr_exp_chest = new int[20];

        int[] arr_final_report = new int[20];


        Customer_Report_Class c = new Customer_Report_Class();
        Exercise_Report_Info_Class d = new Exercise_Report_Info_Class();
        Expected_Count_Info_Class a = new Expected_Count_Info_Class();
       

        public MonthlyReport()
        {
            InitializeComponent();
        }

        private void lblcustomer_Click(object sender, EventArgs e)
        {
            Home hm = new Home();
            hm.Show();
            Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                if (txtBMI.Text == "")
                {
                    MessageBox.Show("Select Customer");
                }
                else if (txtback.Text == "" || txtbiceps.Text == "" || txtchest.Text == "" || txtShoulder.Text == "" || txttricpes.Text == "" || txtlegs.Text == "" || txtweight.Text == "" || txtheight.Text == "" || txtfat.Text == "" || txtnwbmi.Text == "")
                {
                    MessageBox.Show("All TextFields Are Mandatory To Be Filled");
                }
                else
                {
                    c.Customer_Name = cbsearchcust.Text;
                    c.Report_Date = DateTime.Now.Date;
              //          DateTime.Now.ToString("d/M/yyyy");                     
                    c.BMI = txtnwbmi.Text;
                    c.Biceps_Size = txtbiceps.Text;
                    c.Triceps_Size = txttricpes.Text;
                    c.Chest_Size = txtchest.Text;
                    c.Back_Size = txtback.Text;
                    c.Shoulder_Size = txtShoulder.Text;
                    c.Legs_Size = txtlegs.Text;
                    c.Height = txtheight.Text;
                    c.Weight = txtweight.Text;
                    c.Fat_Percent = txtfat.Text;

                    bool success2 = c.Insert2(c);

                    if (success2 == true)
                    {
                        MessageBox.Show("Report Generated In E:");
                       

                    }
                    else
                    {
                        MessageBox.Show("Failed to Generate");
                    }

                    d.Customer_Name = cbsearchcust.Text;
                    d.Last_Report_Date = Convert.ToDateTime(txtlastreport.Text);

                    d.Today_Date = DateTime.Today;

                    DataTable dt1 = d.Legs_Select(d);
                    foreach (DataRow row in dt1.Rows)
                    {
                        foreach (DataColumn dc in dt1.Columns)
                        {
                            arr_legs[li] = row[dc].ToString();
                            li++;
                        }
                    }

                    DataTable dt2 = d.Chest_Select(d);
                    foreach (DataRow row in dt2.Rows)
                    {
                        foreach (DataColumn dc in dt2.Columns)
                        {
                            arr_chest[ci] = row[dc].ToString();
                            ci++;
                            //Console.WriteLine(row[dc].ToString());
                        }
                    }

                    DataTable dt3 = d.Shoulder_Select(d);
                    foreach (DataRow row in dt3.Rows)
                    {
                        foreach (DataColumn dc in dt3.Columns)
                        {
                            arr_shoulder[si] = row[dc].ToString();
                            si++;
                            //Console.WriteLine(row[dc].ToString());
                        }
                    }

                    DataTable dt4 = d.Triceps_Select(d);
                    foreach (DataRow row in dt4.Rows)
                    {
                        foreach (DataColumn dc in dt4.Columns)
                        {
                            arr_triceps[ti] = row[dc].ToString();
                            ti++;
                            //Console.WriteLine(row[dc].ToString());
                        }
                    }


                    DataTable dt5 = d.Back_Select(d);
                    foreach (DataRow row in dt5.Rows)
                    {
                        foreach (DataColumn dc in dt5.Columns)
                        {
                            arr_back[bai] = row[dc].ToString();
                            bai++;
                            //  Console.WriteLine(row[dc].ToString());
                        }
                    }

                    DataTable dt6 = d.Biceps_Select(d);
                    foreach (DataRow row in dt6.Rows)
                    {
                        foreach (DataColumn dc in dt6.Columns)
                        {
                            arr_biceps[bpi] = row[dc].ToString();
                            bpi++;
                            //Console.WriteLine(row[dc].ToString());
                        }
                    }

                   

                    li = 0; ci = 0; si = 0; bai = 0; bpi = 0; ti = 0;
                    DataTable dt7 = a.Legs_Count(a);

                    foreach (DataRow row in dt7.Rows)
                    {
                        foreach (DataColumn dc in dt7.Columns)
                        {
                            arr_exp_legs[li] = Convert.ToInt32(row[dc]);

                            // Console.WriteLine(arr_exp_legs[li]);
                            li++;
                        }
                    }

                    DataTable dt8 = a.Chest_Count(a);
                    foreach (DataRow row in dt8.Rows)
                    {
                        foreach (DataColumn dc in dt8.Columns)
                        {
                            arr_exp_chest[ci] = Convert.ToInt32(row[dc]);

                            //   Console.WriteLine(arr_exp_chest[ci]);
                            ci++;
                        }
                    }

                    DataTable dt9 = a.Shoulder_Count(a);
                    foreach (DataRow row in dt9.Rows)
                    {
                        foreach (DataColumn dc in dt9.Columns)
                        {
                            arr_exp_shoulder[si] = Convert.ToInt32(row[dc]);

                            //   Console.WriteLine(arr_exp_shoulder[si]);
                            si++;
                        }
                    }

                    DataTable dt10 = a.Triceps_Count(a);
                    foreach (DataRow row in dt10.Rows)
                    {
                        foreach (DataColumn dc in dt10.Columns)
                        {
                            arr_exp_triceps[ti] = Convert.ToInt32(row[dc]);

                            //     Console.WriteLine(arr_exp_triceps[ti]);
                            ti++;
                        }
                    }

                    DataTable dt11 = a.Back_Count(a);
                    foreach (DataRow row in dt11.Rows)
                    {
                        foreach (DataColumn dc in dt11.Columns)
                        {
                            arr_exp_back[bai] = Convert.ToInt32(row[dc]);

                            //     Console.WriteLine(arr_exp_back[bai]);
                            bai++;
                        }
                    }

                    DataTable dt12 = a.Biceps_Count(a);

                    foreach (DataRow row in dt12.Rows)
                    {
                        foreach (DataColumn dc in dt12.Columns)
                        {
                            arr_exp_biceps[bpi] = Convert.ToInt32(row[dc]);

                            //      Console.WriteLine(arr_exp_biceps[bpi]);
                            bpi++;
                        }
                    }


                    //----------------------Get Last Report's Data-------------------------  
                    int i = 0;
                    DataTable drp = d.LastReport_Select(d);
                    foreach (DataRow row in drp.Rows)
                    {
                        foreach (DataColumn dc in drp.Columns)
                        {
                            arr_final_report[i] = Convert.ToInt32(row[dc]);
                            // Console.WriteLine(row[dc].ToString());
                            i++;
                        }
                    }

                    Console.WriteLine("++++++++++++++", txtback.Text);
                    Console.WriteLine(txtback.Text);



                    Document doc = new Document();
                    PdfWriter.GetInstance(doc, new FileStream("E:/Report.pdf", FileMode.Create));
                    doc.Open();
                    Paragraph P1 = new Paragraph("Name: " + cbsearchcust.Text + "  ");
                    doc.Add(P1);
                    Paragraph P3 = new Paragraph("----------------------------------------------------------------------");
                    doc.Add(P3);
                    P1 = new Paragraph("Day: " + "  " + tbday.Text + "  " + "Date: " + tbdate.Text + "  " + "BMI: " + txtBMI.Text);
                    doc.Add(P3);
                    doc.Add(P1);
                    doc.Add(P3);
                    doc.Add(Chunk.NEWLINE);
                    Console.WriteLine("++++++++++++++",txtback.Text);
                    Paragraph P5 = new Paragraph("Present Record :"  + " \n BICEPS SIZE: " + txtbiceps.Text + "    " + " TRICEPS SIZE: " + txttricpes.Text + "    " + " CHEST SIZE: " + txtchest.Text + "   "+ " BACK SIZE: " + txtback.Text  +  "    " + " SHOULDER SIZE: " + txtShoulder.Text + "    " + " LEGS SIZE: " + txtlegs.Text + " Height: "+ txtheight.Text + "  " + " Weight :"+txtweight.Text + "  " +" Fat_Percent:" + txtfat.Text+ " BMI :" + txtBMI.Text);
                    doc.Add(P5);
                    doc.Add(Chunk.NEWLINE);
                  Paragraph  P2 = new Paragraph("Last Months Record : " + txtlastreport.Text + " \nBICEPS SIZE: " + arr_final_report[0] + "     TRICEPS SIZE: " + arr_final_report[1] + "     CHEST SIZE: " + arr_final_report[2] + "     BACK SIZE: " + arr_final_report[3] + "     SHOULDER SIZE: " + arr_final_report[4] + "     LEGS SIZE: " + arr_final_report[5] + "     HEIGHT: " + arr_final_report[6] + "     WEIGHT: " + arr_final_report[7] + "     FAT CERCENT: " + arr_final_report[8] + "     BMI :" + arr_final_report[9]);
                    doc.Add(P2);
                    doc.Add(P3);

                    if (arr_shoulder[0] == "")
                    {
                        Paragraph temp = new Paragraph("Shoulder Exercises Are Not Assigned");
                        doc.Add(temp);
                    }
                    else
                    {
                        Paragraph ShoulderEXP = new Paragraph("Shoulder Execises :- ( Monthly Expected Count ) \n" + "Barbell_Push_Press = " + arr_exp_shoulder[0] * 4 + "   Dumbell_Press= " + arr_exp_shoulder[1] * 4 + "   Dumbell_Incline_Row= " + arr_exp_shoulder[2] * 4 + "   Seated_Overhead_Dumbell_Press= " + arr_exp_shoulder[3] * 4 + "   Seated_Overhead_Barbell_Press= " + arr_exp_shoulder[4] * 4 + "   Upright_Row= " + arr_exp_shoulder[5] * 4 + "   Arnold_Press= " + arr_exp_shoulder[6] * 4 + "   Lateral_Raise= " + arr_exp_shoulder[7] * 4 + "   Front_Raise=" + arr_exp_shoulder[8] * 4);
                        Paragraph ShoulderACT = new Paragraph("Shoulder Execises :- ( Monthly Actual Count ) \n" + "Barbell_Push_Press = " + arr_shoulder[0] + "   Dumbell_Press= " + arr_shoulder[1] + "   Dumbell_Incline_Row= " + arr_shoulder[2] + "   Seated_Overhead_Dumbell_Press= " + arr_shoulder[3] + "   Seated_Overhead_Barbell_Press= " + arr_shoulder[4] + "   Upright_Row= " + arr_shoulder[5] + "   Arnold_Press= " + arr_shoulder[6] + "   Lateral_Raise= " + arr_shoulder[7] + "   Front_Raise= " + arr_shoulder[8]);
                        doc.Add(ShoulderEXP);
                        doc.Add(Chunk.NEWLINE);
                        doc.Add(ShoulderACT);
                    }
                    doc.Add(P3);

                    if (arr_chest[0] == "")
                    {
                        Paragraph temp = new Paragraph("Chest Exercises Are Not Assigned");
                        doc.Add(temp);
                    }
                    else
                    {
                        Paragraph ChestEXP = new Paragraph("Chest Execises :- ( Monthly Expected Count ) \n" + "Barbell_Bench_Press = " + arr_exp_chest[0] * 4 + "   Flat_Bench_DUumbell_Press= " + arr_exp_chest[1] * 4 + "   Low_Incline_Barbell_Press= " + arr_exp_chest[2] * 4 + "   Machine_Decline_Press= " + arr_exp_chest[3] * 4 + "   Seated_Machine_Chest_Press= " + arr_exp_chest[4] * 4 + "   Incline_Dumbell_Press= " + arr_exp_chest[5] * 4 + "   Push_Ups= " + arr_exp_chest[6] * 4 + "   Incline_bench_Cable_Fly= " + arr_exp_chest[7] * 4 + "   Incline_Dumbell_Pullover= " + arr_exp_chest[8] * 4);
                        Paragraph ChestACT = new Paragraph("Chest Execises :- ( Monthly Actual Count ) \n" + "Barbell_Bench_Press = " + arr_chest[0] + "   Flat_Bench_DUumbell_Press= " + arr_chest[1] + "   Low_Incline_Barbell_Press= " + arr_chest[2] + "   Machine_Decline_Press= " + arr_chest[3] + "   Seated_Machine_Chest_Press= " + arr_chest[4] + "   Incline_Dumbell_Press= " + arr_chest[5] + "   Push_Ups= " + arr_chest[6] + "   Incline_bench_Cable_Fly= " + arr_chest[7] + "   Incline_Dumbell_Pullover= " + arr_chest[8]);
                        doc.Add(ChestEXP);
                        doc.Add(Chunk.NEWLINE);
                        doc.Add(ChestACT);
                    }
                     doc.Add(P3);


                     if (arr_legs[0] == "")
                     {
                         Paragraph temp = new Paragraph("Legs Exercises Are Not Assigned");
                         doc.Add(temp);
                     }
                     else
                     {
                         Paragraph LegsEXP = new Paragraph("Legs Execises :- ( Monthly Expected Count ) \n" + "Free_Squats = " + arr_exp_legs[0] * 4 + "   Weighted_Squats= " + arr_exp_legs[1] * 4 + "   Free_Lunges= " + arr_exp_legs[2] * 4 + "   Weighted_Lunges= " + arr_exp_legs[3] * 4 + "   Leg_Press = " + arr_exp_legs[4] * 4 + "   Leg_Curls_Front = " + arr_exp_legs[5] * 4 + "   Leg_Curls_Back= " + arr_exp_legs[6] * 4 + "   Free_Calf_Raise= " + arr_exp_legs[7] * 4 + "   Weighte_Calf_Raise= " + arr_exp_legs[8] * 4);
                         Paragraph LegsACT = new Paragraph("Legs Execises :- ( Monthly Actual Count ) \n" + "Free_Squats = " + arr_legs[0] + "   Weighted_Squats= " + arr_legs[1] + "   Free_Lunges= " + arr_legs[2] + "   Weighted_Lunges= " + arr_legs[3] + "   Leg_Press = " + arr_legs[4] + "   Leg_Curls_Front = " + arr_legs[5] + "   Leg_Curls_Back= " + arr_legs[6] + "   Free_Calf_Raise= " + arr_legs[7] + "   Weighte_Calf_Raise= " + arr_legs[8]);
                         doc.Add(LegsEXP);
                         doc.Add(Chunk.NEWLINE);
                         doc.Add(LegsACT);
                     }
                    doc.Add(P3);


                    if (arr_triceps[0] == "")
                    {
                        Paragraph temp = new Paragraph("Triceps Exercises Are Not Assigned");
                        doc.Add(temp);
                    }
                    else
                    {

                        Paragraph TricepsEXP = new Paragraph("Triceps Execises :- ( Monthly Expected Count ) \n" + "Close_Grip_Bench_Press = " + arr_exp_triceps[0] * 4 + "   Rope_Triceps_Push_Down= " + arr_exp_triceps[1] * 4 + "   Triceps_Dips= " + arr_exp_triceps[2] * 4 + "   Overhead_Triceps_Extension= " + arr_exp_triceps[3] * 4 + "   Skullcrusher = " + arr_exp_triceps[4] * 4 + "   Diamond_Pressup = " + arr_exp_triceps[5] * 4);
                        Paragraph TricepsACT = new Paragraph("Triceps Execises :- ( Monthly Actual Count ) \n" + "Close_Grip_Bench_Press = " + arr_triceps[0] + "   Rope_Triceps_Push_Down= " + arr_triceps[1] + "   Triceps_Dips= " + arr_triceps[2] + "   Overhead_Triceps_Extension= " + arr_triceps[3] + "   Skullcrusher = " + arr_triceps[4] + "   Diamond_Pressup = " + arr_triceps[5]);
                        doc.Add(TricepsEXP);
                        doc.Add(Chunk.NEWLINE);
                        doc.Add(TricepsACT);
                    }
                    doc.Add(P3);

                    if (arr_back[0] == "")
                    {
                        Paragraph temp = new Paragraph("Back Exercises Are Not Assigned");
                        doc.Add(temp);
                    }
                    else
                    {

                        Paragraph BackEXP = new Paragraph("Back Execises :- ( Monthly Expected Count ) \n" + "Deadlift = " + arr_exp_back[0] * 4 + "   Pullups= " + arr_exp_back[1] * 4 + "   Bentrows= " + arr_exp_back[2] * 4 + "   Chinup= " + arr_exp_back[3] * 4 + "   Tbar_Standing= " + arr_exp_back[4] * 4 + "   Seated_Row= " + arr_exp_back[5] * 4 + "   Reverse_Grip_Machine_Row= " + arr_exp_back[6] * 4 + "   Pulldown= " + arr_exp_back[7] * 4 + "   Decline_Dumbell_Pullover=" + arr_exp_back[8] * 4 + "   Single_Arm_Dumbell_Row=" + arr_exp_back[9] * 4);
                        Paragraph BackACT = new Paragraph("Back Execises :- ( Monthly Actual Count ) \n" + "Deadlift = " + arr_back[0] + "   Pullups= " + arr_back[1] + "   Bentrows= " + arr_back[2] + "   Chinup= " + arr_back[3] + "   Tbar_Standing= " + arr_back[4] + "   Seated_Row= " + arr_back[5] + "   Reverse_Grip_Machine_Row= " + arr_back[6] + "   Pulldown= " + arr_back[7] + "   Decline_Dumbell_Pullover=" + arr_back[8] + "   Single_Arm_Dumbell_Row=" + arr_back[9]);
                        doc.Add(BackEXP);
                        doc.Add(Chunk.NEWLINE);
                        doc.Add(BackACT);
                    }
                    doc.Add(P3);

                    if (arr_biceps[0] == "")
                    {
                        Paragraph temp = new Paragraph("Biceps Exercises Are Not Assigned");
                        doc.Add(temp);
                    }
                    else
                    {

                        Paragraph BicepsEXP = new Paragraph("Biceps Execises :- ( Monthly Expected Count ) \n" + "Biceps_Curl = " + arr_exp_biceps[0] * 4 + "   Machine_Curls_Super_Set= " + arr_exp_biceps[1] * 4 + "   Biceps_Curls_Rod_Press= " + arr_exp_biceps[2] * 4 + "   Hammer_Curls= " + arr_exp_biceps[3] * 4 + "   Wide_Grip_Standing_Barbel = " + arr_exp_biceps[4] * 4 + "   Overhead_Cable_Curl = " + arr_exp_biceps[5] * 4);
                        Paragraph BicepsACT = new Paragraph("Biceps Execises :- ( Monthly Actual Count ) \n" + "Biceps_Curl = " + arr_biceps[0] + "   Machine_Curls_Super_Set= " + arr_biceps[1] + "   Biceps_Curls_Rod_Press= " + arr_biceps[2] + "   Hammer_Curls= " + arr_biceps[3] + "   Wide_Grip_Standing_Barbel = " + arr_biceps[4] + "   Overhead_Cable_Curl = " + arr_biceps[5]);
                        doc.Add(BicepsEXP);
                        doc.Add(Chunk.NEWLINE);
                        doc.Add(BicepsACT);
                    }
                    doc.Add(P3);
                    doc.Close();
                    MessageBox.Show("Report Created Successful");
                    page_load();

                }
            }
            catch (System.IO.IOException)
            {
                System.Windows.Forms.MessageBox.Show("Close Current Report And Then Generate New");
            }
            
        }

        private void MonthlyReport_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'fITZONEDataSet10.Monthly_Report_Info' table. You can move, or remove it, as needed.
            this.monthly_Report_InfoTableAdapter.Fill(this.fITZONEDataSet10.Monthly_Report_Info);
            // TODO: This line of code loads data into the 'fITZONEDataSet9.Customer_Info' table. You can move, or remove it, as needed.
            this.customer_InfoTableAdapter.Fill(this.fITZONEDataSet9.Customer_Info);
            tbday.Text = DateTime.Now.DayOfWeek.ToString();
            tbdate.Text = DateTime.Today.ToString("d/M/yyyy");

        }

        private void cbsearchcust_SelectedIndexChanged(object sender, EventArgs e)
        {
            string name = cbsearchcust.Text;
           // MessageBox.Show(name);
            c.Customer_Name = name;

            DataTable dt = c.Select1(c);
            foreach (DataRow row in dt.Rows)
            {
                // ... Write value of first field as integer.
               // MessageBox.Show(row[0].ToString());
                txtBMI.Text = row[0].ToString();
            }

            foreach (DataRow row in dt.Rows)
            {
                // ... Write value of first field as integer.
                // MessageBox.Show(row[0].ToString());

                
                txtlastreport.Text = row[1].ToString();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            txtback.Text = "";
            txtbiceps.Text = "";
            txtchest.Text = "";
            txtShoulder.Text = "";
            txttricpes.Text = "";
            txtlegs.Text = "";
            txtweight.Text = "";
            txtheight.Text = "";
            txtfat.Text = "";
            txtnwbmi.Text = "";
        }

       public void page_load(){
            this.customer_InfoTableAdapter.Fill(this.fITZONEDataSet9.Customer_Info);
            this.monthly_Report_InfoTableAdapter.Fill(this.fITZONEDataSet10.Monthly_Report_Info);
            tbday.Text = DateTime.Now.DayOfWeek.ToString();
            tbdate.Text = DateTime.Today.ToString("d/M/yyyy");
            txtback.Text = "";
            txtbiceps.Text = "";
            txtchest.Text = "";
            txtShoulder.Text = "";
            txttricpes.Text = "";
            txtlegs.Text = "";
            txtweight.Text = "";
            txtheight.Text = "";
            txtfat.Text = "";
            txtnwbmi.Text = "";
        }

       private void btngnbmi_Click(object sender, EventArgs e)
       {
           w = Convert.ToInt32(txtweight.Text);
           h = Convert.ToDouble(txtheight.Text);
           hs = h * h;
           bm = w / hs;

           txtnwbmi.Text = bm.ToString();
       }
       static string myconnstrng = ConfigurationManager.ConnectionStrings["connstrng"].ConnectionString;
       private void txtsearchrecord_TextChanged(object sender, EventArgs e)
       {
           String keyword = txtsearchrecord.Text;
           SqlConnection conn = new SqlConnection(myconnstrng);
           SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM Monthly_Report_Info WHERE Customer_Name LIKE '%" + keyword + "%' ", conn);
           DataTable dt = new DataTable();

           sda.Fill(dt);
           datagvrecord.DataSource = dt;
       }
    }
}
