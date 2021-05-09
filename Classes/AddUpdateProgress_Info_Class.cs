using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FITZONE.Classes
{
    class AddUpdateProgress_Info_Class
    {
        public int counter { get; set; }
        public string Customer_Name { get; set; }
        public float BMI { get; set; }
        public string Day_Name { get; set; }
        public DateTime Date { get; set; }
        public string Body_Parts { get; set; }
        public string Focus { get; set; }
        public string Exercise_Count { get; set; }
        public string Exercise_Name { get; set; }
        public string Exercise_Count1 { get; set; }
        public string Exercise_Count2 { get; set; }
        public string Exercise_Count3 { get; set; }
        public string Exercise_Count4 { get; set; }
        public string Exercise_Count5 { get; set; }
        public string Exercise_Count6 { get; set; }
        public string Exercise_Count7 { get; set; }
        public string Exercise_Count8 { get; set; }
        public string Exercise_Count9 { get; set; }
        public string Exercise_Count10 { get; set; }
        public int ctcount { get; set; }
        string sql2; SqlCommand cmd;

        static string myconnstrng = ConfigurationManager.ConnectionStrings["connstrng"].ConnectionString;

        public DataTable Select1(AddUpdateProgress_Info_Class d)
        {
            SqlConnection conn = new SqlConnection(myconnstrng);
            DataTable dt = new DataTable();

            try
            {
                //  string sql = "INSERT INTO Exercise_Info(Customer_Name,Address,Phone_No,Email_Id,Gender,Age,Biceps_Size,Calf_Size,Chest_Size,Hip_Size,Weight,Height,Fat_Percent,Package,Personal_Trainer,Time_Preference,BMI) VALUES(@Customer_Name, @Address, @Phone_No, @Email_Id, @Gender, @Age, @Biceps_Size, @Calf_Size, @Chest_Size, @Hip_Size,@Weight,@Height,@Fat_Percent,@Package,@Personal_Trainer,@Time_Preference,@BMI)";
                string sql = "Select BMI FROM Monthly_Report_Info WHERE Customer_Name= @Customer_Name ";
                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@Customer_Name", d.Customer_Name);

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);


                conn.Open();
                adapter.Fill(dt);

                int rows = cmd.ExecuteNonQuery();


            }
            catch (System.Data.SqlClient.SqlException sqlException)
            {
                System.Windows.Forms.MessageBox.Show(sqlException.Message);
            }

            finally
            {
                conn.Close();
            }
            return dt;

        }
        public DataTable Select2(AddUpdateProgress_Info_Class d)
        {
            SqlConnection conn = new SqlConnection(myconnstrng);
            DataTable dt2 = new DataTable();
            

            try
            {
                //  string sql = "INSERT INTO Exercise_Info(Customer_Name,Address,Phone_No,Email_Id,Gender,Age,Biceps_Size,Calf_Size,Chest_Size,Hip_Size,Weight,Height,Fat_Percent,Package,Personal_Trainer,Time_Preference,BMI) VALUES(@Customer_Name, @Address, @Phone_No, @Email_Id, @Gender, @Age, @Biceps_Size, @Calf_Size, @Chest_Size, @Hip_Size,@Weight,@Height,@Fat_Percent,@Package,@Personal_Trainer,@Time_Preference,@BMI)";

                if (BMI < 20)
                {
                     sql2 = "SELECT Body_Part1 FROM BMI_Exercise_Info WHERE  BMIClass='less than 20' and Day_Name=@Day_Name ";
                     
                }
                if (BMI >=20 && BMI <26)
                {
                    sql2 = "SELECT Body_Part1 FROM BMI_Exercise_Info WHERE  BMIClass='between 20-26' and Day_Name=@Day_Name ";

                }
                if (BMI >= 26 && BMI < 36)
                {
                    sql2 = "SELECT Body_Part1 FROM BMI_Exercise_Info WHERE  BMIClass='between 26-36' and Day_Name=@Day_Name ";

                }
                if (BMI >=36)
                {
                    sql2 = "SELECT Body_Part1 FROM BMI_Exercise_Info WHERE  BMIClass='Above 36' and Day_Name=@Day_Name ";

                }


                SqlCommand cmd = new SqlCommand(sql2, conn);

                cmd.Parameters.AddWithValue("@Day_Name", d.Day_Name);

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);


                conn.Open();
                adapter.Fill(dt2);

                int rows = cmd.ExecuteNonQuery();


            }
            catch (System.Data.SqlClient.SqlException sqlException)
            {
                System.Windows.Forms.MessageBox.Show(sqlException.Message);
            }

            finally
            {
                conn.Close();
            }
            return dt2;

        }

        public DataTable Select3(AddUpdateProgress_Info_Class d)
        {
            SqlConnection conn = new SqlConnection(myconnstrng);
            DataTable dt = new DataTable();

            try
            {
                //  string sql = "INSERT INTO Exercise_Info(Customer_Name,Address,Phone_No,Email_Id,Gender,Age,Biceps_Size,Calf_Size,Chest_Size,Hip_Size,Weight,Height,Fat_Percent,Package,Personal_Trainer,Time_Preference,BMI) VALUES(@Customer_Name, @Address, @Phone_No, @Email_Id, @Gender, @Age, @Biceps_Size, @Calf_Size, @Chest_Size, @Hip_Size,@Weight,@Height,@Fat_Percent,@Package,@Personal_Trainer,@Time_Preference,@BMI)";
                string sql = "Select Exercise FROM Exercise_Info WHERE Body_Parts= @Body_Parts ";
                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@Body_Parts", d.Body_Parts);

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);


                conn.Open();
                adapter.Fill(dt);

                int rows = cmd.ExecuteNonQuery();


            }
            catch (System.Data.SqlClient.SqlException sqlException)
            {
                System.Windows.Forms.MessageBox.Show(sqlException.Message);
            }

            finally
            {
                conn.Close();
            }
            return dt;

        }

        public bool Insert(AddUpdateProgress_Info_Class d)
        {
            bool isSuccess = true;
            
            SqlConnection conn = new SqlConnection(myconnstrng);
            try
            {
                //  string sql = "INSERT INTO Customer_Info(Customer_Name,Address,Phone_No,Email_Id,Gender,Age,Biceps_Size,Calf_Size,Chest_Size,Hip_Size,Weight,Height,Fat_Percent,Package,Personal_Trainer,Time_Preference,BMI) VALUES(@Customer_Name, @Address, @Phone_No, @Email_Id, @Gender, @Age, @Biceps_Size, @Calf_Size, @Chest_Size, @Hip_Size,@Weight,@Height,@Fat_Percent,@Package,@Personal_Trainer,@Time_Preference,@BMI)";
                if (d.Focus.ToLower() == "shoulder")
                {
                    if (ctcount == 1)
                    {
                        sql2 = "INSERT INTO Shoulder_Info  VALUES (@Customer_Name , @Day_Name, @Date , @Exercise_Count1)";
                        cmd = new SqlCommand(sql2, conn);

                        cmd.Parameters.AddWithValue("@Exercise_Count1", d.Exercise_Count1);
                    }

                    if (ctcount == 2)
                    {
                      
                        sql2 = "INSERT INTO Shoulder_Info  VALUES (@Customer_Name , @Day_Name, @Date , @Exercise_Count1, @Exercise_Count2)";
                        cmd = new SqlCommand(sql2, conn);
                        
                        cmd.Parameters.AddWithValue("@Exercise_Count1", d.Exercise_Count1);
                        cmd.Parameters.AddWithValue("@Exercise_Count2", d.Exercise_Count2);
                    }

                    if (ctcount == 3)
                    {
                        sql2 = "INSERT INTO Shoulder_Info  VALUES (@Customer_Name , @Day_Name, @Date , @Exercise_Count1, @Exercise_Count2 , @Exercise_Count3)";
                        cmd = new SqlCommand(sql2, conn);

                        cmd.Parameters.AddWithValue("@Exercise_Count1", d.Exercise_Count1);
                        cmd.Parameters.AddWithValue("@Exercise_Count2", d.Exercise_Count2);
                        cmd.Parameters.AddWithValue("@Exercise_Count3", d.Exercise_Count3);
                    }

                    if (ctcount == 4)
                    {
                        sql2 = "INSERT INTO Shoulder_Info  VALUES (@Customer_Name , @Day_Name, @Date , @Exercise_Count1, @Exercise_Count2, @Exercise_Count3, @Exercise_Count4)";
                        cmd = new SqlCommand(sql2, conn);

                        cmd.Parameters.AddWithValue("@Exercise_Count1", d.Exercise_Count1);
                        cmd.Parameters.AddWithValue("@Exercise_Count2", d.Exercise_Count2);
                        cmd.Parameters.AddWithValue("@Exercise_Count3", d.Exercise_Count3);
                        cmd.Parameters.AddWithValue("@Exercise_Count4", d.Exercise_Count4);
                    }

                    if (ctcount == 5)
                    {
                        sql2 = "INSERT INTO Shoulder_Info  VALUES (@Customer_Name , @Day_Name, @Date ,@Exercise_Count1, @Exercise_Count2,@Exercise_Count3,@Exercise_Count4,@Exercise_Count5)";
                        cmd = new SqlCommand(sql2, conn);

                        cmd.Parameters.AddWithValue("@Exercise_Count1", d.Exercise_Count1);
                        cmd.Parameters.AddWithValue("@Exercise_Count2", d.Exercise_Count2);
                        cmd.Parameters.AddWithValue("@Exercise_Count3", d.Exercise_Count3);
                        cmd.Parameters.AddWithValue("@Exercise_Count4", d.Exercise_Count4);
                        cmd.Parameters.AddWithValue("@Exercise_Count5", d.Exercise_Count5);
                    }
                    if (ctcount == 6)
                    {
                        sql2 = "INSERT INTO Shoulder_Info  VALUES (@Customer_Name , @Day_Name, @Date ,@Exercise_Count1, @Exercise_Count2,@Exercise_Count3,@Exercise_Count4,@Exercise_Count5,@Exercise_Count6)";
                        cmd = new SqlCommand(sql2, conn);

                        cmd.Parameters.AddWithValue("@Exercise_Count1", d.Exercise_Count1);
                        cmd.Parameters.AddWithValue("@Exercise_Count2", d.Exercise_Count2);
                        cmd.Parameters.AddWithValue("@Exercise_Count3", d.Exercise_Count3);
                        cmd.Parameters.AddWithValue("@Exercise_Count4", d.Exercise_Count4);
                        cmd.Parameters.AddWithValue("@Exercise_Count5", d.Exercise_Count5);
                        cmd.Parameters.AddWithValue("@Exercise_Count6", d.Exercise_Count6);
                    }
                    if (ctcount == 7)
                    {
                        sql2 = "INSERT INTO Shoulder_Info  VALUES (@Customer_Name , @Day_Name, @Date ,@Exercise_Count1, @Exercise_Count2,@Exercise_Count3,@Exercise_Count4,@Exercise_Count5,@Exercise_Count6,@Exercise_Count7)";
                        cmd = new SqlCommand(sql2, conn);

                        cmd.Parameters.AddWithValue("@Exercise_Count1", d.Exercise_Count1);
                        cmd.Parameters.AddWithValue("@Exercise_Count2", d.Exercise_Count2);
                        cmd.Parameters.AddWithValue("@Exercise_Count3", d.Exercise_Count3);
                        cmd.Parameters.AddWithValue("@Exercise_Count4", d.Exercise_Count4);
                        cmd.Parameters.AddWithValue("@Exercise_Count5", d.Exercise_Count5);
                        cmd.Parameters.AddWithValue("@Exercise_Count6", d.Exercise_Count6);
                        cmd.Parameters.AddWithValue("@Exercise_Count7", d.Exercise_Count7);
                    }
                    if (ctcount == 8)
                    {
                        sql2 = "INSERT INTO Shoulder_Info  VALUES (@Customer_Name , @Day_Name, @Date ,@Exercise_Count1, @Exercise_Count2,@Exercise_Count3,@Exercise_Count4,@Exercise_Count5,@Exercise_Count6,@Exercise_Count7,@Exercise_Count8)";
                        cmd = new SqlCommand(sql2, conn);

                        cmd.Parameters.AddWithValue("@Exercise_Count1", d.Exercise_Count1);
                        cmd.Parameters.AddWithValue("@Exercise_Count2", d.Exercise_Count2);
                        cmd.Parameters.AddWithValue("@Exercise_Count3", d.Exercise_Count3);
                        cmd.Parameters.AddWithValue("@Exercise_Count4", d.Exercise_Count4);
                        cmd.Parameters.AddWithValue("@Exercise_Count5", d.Exercise_Count5);
                        cmd.Parameters.AddWithValue("@Exercise_Count6", d.Exercise_Count6);
                        cmd.Parameters.AddWithValue("@Exercise_Count7", d.Exercise_Count7);
                        cmd.Parameters.AddWithValue("@Exercise_Count8", d.Exercise_Count8);
                    }
                    if (ctcount == 9)
                    {
                        sql2 = "INSERT INTO Shoulder_Info  VALUES (@Customer_Name , @Day_Name, @Date ,@Exercise_Count1, @Exercise_Count2,@Exercise_Count3,@Exercise_Count4,@Exercise_Count5,@Exercise_Count6,@Exercise_Count7,@Exercise_Count8,@Exercise_Count9)";
                        cmd = new SqlCommand(sql2, conn);

                        cmd.Parameters.AddWithValue("@Exercise_Count1", d.Exercise_Count1);
                        cmd.Parameters.AddWithValue("@Exercise_Count2", d.Exercise_Count2);
                        cmd.Parameters.AddWithValue("@Exercise_Count3", d.Exercise_Count3);
                        cmd.Parameters.AddWithValue("@Exercise_Count4", d.Exercise_Count4);
                        cmd.Parameters.AddWithValue("@Exercise_Count5", d.Exercise_Count5);
                        cmd.Parameters.AddWithValue("@Exercise_Count6", d.Exercise_Count6);
                        cmd.Parameters.AddWithValue("@Exercise_Count7", d.Exercise_Count7);
                        cmd.Parameters.AddWithValue("@Exercise_Count8", d.Exercise_Count8);
                        cmd.Parameters.AddWithValue("@Exercise_Count9", d.Exercise_Count9);
                    }

                    if (ctcount == 10)
                    {
                        sql2 = "INSERT INTO Shoulder_Info  VALUES (@Customer_Name , @Day_Name, @Date ,@Exercise_Count1, @Exercise_Count2,@Exercise_Count3,@Exercise_Count4,@Exercise_Count5,@Exercise_Count6,@Exercise_Count7,@Exercise_Count8,@Exercise_Count9,@Exercise_Count10)";
                        cmd = new SqlCommand(sql2, conn);

                        cmd.Parameters.AddWithValue("@Exercise_Count1", d.Exercise_Count1);
                        cmd.Parameters.AddWithValue("@Exercise_Count2", d.Exercise_Count2);
                        cmd.Parameters.AddWithValue("@Exercise_Count3", d.Exercise_Count3);
                        cmd.Parameters.AddWithValue("@Exercise_Count4", d.Exercise_Count4);
                        cmd.Parameters.AddWithValue("@Exercise_Count5", d.Exercise_Count5);
                        cmd.Parameters.AddWithValue("@Exercise_Count6", d.Exercise_Count6);
                        cmd.Parameters.AddWithValue("@Exercise_Count7", d.Exercise_Count7);
                        cmd.Parameters.AddWithValue("@Exercise_Count8", d.Exercise_Count8);
                        cmd.Parameters.AddWithValue("@Exercise_Count9", d.Exercise_Count9);
                        cmd.Parameters.AddWithValue("@Exercise_Count10", d.Exercise_Count10);
                    }
                 
                                              
                   
                }

                if (d.Focus.ToLower() == "chest")
                {
                    if (ctcount == 1)
                    {
                        sql2 = "INSERT INTO Chest_Info  VALUES (@Customer_Name , @Day_Name, @Date , @Exercise_Count1)";
                        cmd = new SqlCommand(sql2, conn);

                        cmd.Parameters.AddWithValue("@Exercise_Count1", d.Exercise_Count1);
                    }

                    if (ctcount == 2)
                    {

                        sql2 = "INSERT INTO Chest_Info  VALUES (@Customer_Name , @Day_Name, @Date , @Exercise_Count1, @Exercise_Count2)";
                        cmd = new SqlCommand(sql2, conn);

                        cmd.Parameters.AddWithValue("@Exercise_Count1", d.Exercise_Count1);
                        cmd.Parameters.AddWithValue("@Exercise_Count2", d.Exercise_Count2);
                    }

                    if (ctcount == 3)
                    {
                        sql2 = "INSERT INTO Chest_Info  VALUES (@Customer_Name , @Day_Name, @Date , @Exercise_Count1, @Exercise_Count2 , @Exercise_Count3)";
                        cmd = new SqlCommand(sql2, conn);

                        cmd.Parameters.AddWithValue("@Exercise_Count1", d.Exercise_Count1);
                        cmd.Parameters.AddWithValue("@Exercise_Count2", d.Exercise_Count2);
                        cmd.Parameters.AddWithValue("@Exercise_Count3", d.Exercise_Count3);
                    }

                    if (ctcount == 4)
                    {
                        sql2 = "INSERT INTO Chest_Info  VALUES (@Customer_Name , @Day_Name, @Date , @Exercise_Count1, @Exercise_Count2, @Exercise_Count3, @Exercise_Count4)";
                        cmd = new SqlCommand(sql2, conn);

                        cmd.Parameters.AddWithValue("@Exercise_Count1", d.Exercise_Count1);
                        cmd.Parameters.AddWithValue("@Exercise_Count2", d.Exercise_Count2);
                        cmd.Parameters.AddWithValue("@Exercise_Count3", d.Exercise_Count3);
                        cmd.Parameters.AddWithValue("@Exercise_Count4", d.Exercise_Count4);
                    }

                    if (ctcount == 5)
                    {
                        sql2 = "INSERT INTO Chest_Info  VALUES (@Customer_Name , @Day_Name, @Date ,@Exercise_Count1, @Exercise_Count2,@Exercise_Count3,@Exercise_Count4,@Exercise_Count5)";
                        cmd = new SqlCommand(sql2, conn);

                        cmd.Parameters.AddWithValue("@Exercise_Count1", d.Exercise_Count1);
                        cmd.Parameters.AddWithValue("@Exercise_Count2", d.Exercise_Count2);
                        cmd.Parameters.AddWithValue("@Exercise_Count3", d.Exercise_Count3);
                        cmd.Parameters.AddWithValue("@Exercise_Count4", d.Exercise_Count4);
                        cmd.Parameters.AddWithValue("@Exercise_Count5", d.Exercise_Count5);
                    }
                    if (ctcount == 6)
                    {
                        sql2 = "INSERT INTO Chest_Info  VALUES (@Customer_Name , @Day_Name, @Date ,@Exercise_Count1, @Exercise_Count2,@Exercise_Count3,@Exercise_Count4,@Exercise_Count5,@Exercise_Count6)";
                        cmd = new SqlCommand(sql2, conn);

                        cmd.Parameters.AddWithValue("@Exercise_Count1", d.Exercise_Count1);
                        cmd.Parameters.AddWithValue("@Exercise_Count2", d.Exercise_Count2);
                        cmd.Parameters.AddWithValue("@Exercise_Count3", d.Exercise_Count3);
                        cmd.Parameters.AddWithValue("@Exercise_Count4", d.Exercise_Count4);
                        cmd.Parameters.AddWithValue("@Exercise_Count5", d.Exercise_Count5);
                        cmd.Parameters.AddWithValue("@Exercise_Count6", d.Exercise_Count6);
                    }
                    if (ctcount == 7)
                    {
                        sql2 = "INSERT INTO Chest_Info  VALUES (@Customer_Name , @Day_Name, @Date ,@Exercise_Count1, @Exercise_Count2,@Exercise_Count3,@Exercise_Count4,@Exercise_Count5,@Exercise_Count6,@Exercise_Count7)";
                        cmd = new SqlCommand(sql2, conn);

                        cmd.Parameters.AddWithValue("@Exercise_Count1", d.Exercise_Count1);
                        cmd.Parameters.AddWithValue("@Exercise_Count2", d.Exercise_Count2);
                        cmd.Parameters.AddWithValue("@Exercise_Count3", d.Exercise_Count3);
                        cmd.Parameters.AddWithValue("@Exercise_Count4", d.Exercise_Count4);
                        cmd.Parameters.AddWithValue("@Exercise_Count5", d.Exercise_Count5);
                        cmd.Parameters.AddWithValue("@Exercise_Count6", d.Exercise_Count6);
                        cmd.Parameters.AddWithValue("@Exercise_Count7", d.Exercise_Count7);
                    }
                    if (ctcount == 8)
                    {
                        sql2 = "INSERT INTO Chest_Info  VALUES (@Customer_Name , @Day_Name, @Date ,@Exercise_Count1, @Exercise_Count2,@Exercise_Count3,@Exercise_Count4,@Exercise_Count5,@Exercise_Count6,@Exercise_Count7,@Exercise_Count8)";
                        cmd = new SqlCommand(sql2, conn);

                        cmd.Parameters.AddWithValue("@Exercise_Count1", d.Exercise_Count1);
                        cmd.Parameters.AddWithValue("@Exercise_Count2", d.Exercise_Count2);
                        cmd.Parameters.AddWithValue("@Exercise_Count3", d.Exercise_Count3);
                        cmd.Parameters.AddWithValue("@Exercise_Count4", d.Exercise_Count4);
                        cmd.Parameters.AddWithValue("@Exercise_Count5", d.Exercise_Count5);
                        cmd.Parameters.AddWithValue("@Exercise_Count6", d.Exercise_Count6);
                        cmd.Parameters.AddWithValue("@Exercise_Count7", d.Exercise_Count7);
                        cmd.Parameters.AddWithValue("@Exercise_Count8", d.Exercise_Count8);
                    }
                    if (ctcount == 9)
                    {
                        sql2 = "INSERT INTO Chest_Info  VALUES (@Customer_Name , @Day_Name, @Date ,@Exercise_Count1, @Exercise_Count2,@Exercise_Count3,@Exercise_Count4,@Exercise_Count5,@Exercise_Count6,@Exercise_Count7,@Exercise_Count8,@Exercise_Count9)";
                        cmd = new SqlCommand(sql2, conn);

                        cmd.Parameters.AddWithValue("@Exercise_Count1", d.Exercise_Count1);
                        cmd.Parameters.AddWithValue("@Exercise_Count2", d.Exercise_Count2);
                        cmd.Parameters.AddWithValue("@Exercise_Count3", d.Exercise_Count3);
                        cmd.Parameters.AddWithValue("@Exercise_Count4", d.Exercise_Count4);
                        cmd.Parameters.AddWithValue("@Exercise_Count5", d.Exercise_Count5);
                        cmd.Parameters.AddWithValue("@Exercise_Count6", d.Exercise_Count6);
                        cmd.Parameters.AddWithValue("@Exercise_Count7", d.Exercise_Count7);
                        cmd.Parameters.AddWithValue("@Exercise_Count8", d.Exercise_Count8);
                        cmd.Parameters.AddWithValue("@Exercise_Count9", d.Exercise_Count9);
                    }

                    if (ctcount == 10)
                    {
                        sql2 = "INSERT INTO Chest_Info VALUES (@Customer_Name , @Day_Name, @Date ,@Exercise_Count1, @Exercise_Count2,@Exercise_Count3,@Exercise_Count4,@Exercise_Count5,@Exercise_Count6,@Exercise_Count7,@Exercise_Count8,@Exercise_Count9,@Exercise_Count10)";
                        cmd = new SqlCommand(sql2, conn);

                        cmd.Parameters.AddWithValue("@Exercise_Count1", d.Exercise_Count1);
                        cmd.Parameters.AddWithValue("@Exercise_Count2", d.Exercise_Count2);
                        cmd.Parameters.AddWithValue("@Exercise_Count3", d.Exercise_Count3);
                        cmd.Parameters.AddWithValue("@Exercise_Count4", d.Exercise_Count4);
                        cmd.Parameters.AddWithValue("@Exercise_Count5", d.Exercise_Count5);
                        cmd.Parameters.AddWithValue("@Exercise_Count6", d.Exercise_Count6);
                        cmd.Parameters.AddWithValue("@Exercise_Count7", d.Exercise_Count7);
                        cmd.Parameters.AddWithValue("@Exercise_Count8", d.Exercise_Count8);
                        cmd.Parameters.AddWithValue("@Exercise_Count9", d.Exercise_Count9);
                        cmd.Parameters.AddWithValue("@Exercise_Count10", d.Exercise_Count10);
                    }



                }

                if (d.Focus.ToLower() == "back")
                {
                    if (ctcount == 1)
                    {
                        sql2 = "INSERT INTO Back_Info  VALUES (@Customer_Name , @Day_Name, @Date , @Exercise_Count1)";
                        cmd = new SqlCommand(sql2, conn);

                        cmd.Parameters.AddWithValue("@Exercise_Count1", d.Exercise_Count1);
                    }

                    if (ctcount == 2)
                    {

                        sql2 = "INSERT INTO Back_Info  VALUES (@Customer_Name , @Day_Name, @Date , @Exercise_Count1, @Exercise_Count2)";
                        cmd = new SqlCommand(sql2, conn);

                        cmd.Parameters.AddWithValue("@Exercise_Count1", d.Exercise_Count1);
                        cmd.Parameters.AddWithValue("@Exercise_Count2", d.Exercise_Count2);
                    }

                    if (ctcount == 3)
                    {
                        sql2 = "INSERT INTO Back_Info  VALUES (@Customer_Name , @Day_Name, @Date , @Exercise_Count1, @Exercise_Count2 , @Exercise_Count3)";
                        cmd = new SqlCommand(sql2, conn);

                        cmd.Parameters.AddWithValue("@Exercise_Count1", d.Exercise_Count1);
                        cmd.Parameters.AddWithValue("@Exercise_Count2", d.Exercise_Count2);
                        cmd.Parameters.AddWithValue("@Exercise_Count3", d.Exercise_Count3);
                    }

                    if (ctcount == 4)
                    {
                        sql2 = "INSERT INTO Back_Info  VALUES (@Customer_Name , @Day_Name, @Date , @Exercise_Count1, @Exercise_Count2, @Exercise_Count3, @Exercise_Count4)";
                        cmd = new SqlCommand(sql2, conn);

                        cmd.Parameters.AddWithValue("@Exercise_Count1", d.Exercise_Count1);
                        cmd.Parameters.AddWithValue("@Exercise_Count2", d.Exercise_Count2);
                        cmd.Parameters.AddWithValue("@Exercise_Count3", d.Exercise_Count3);
                        cmd.Parameters.AddWithValue("@Exercise_Count4", d.Exercise_Count4);
                    }

                    if (ctcount == 5)
                    {
                        sql2 = "INSERT INTO Back_Info  VALUES (@Customer_Name , @Day_Name, @Date ,@Exercise_Count1, @Exercise_Count2,@Exercise_Count3,@Exercise_Count4,@Exercise_Count5)";
                        cmd = new SqlCommand(sql2, conn);

                        cmd.Parameters.AddWithValue("@Exercise_Count1", d.Exercise_Count1);
                        cmd.Parameters.AddWithValue("@Exercise_Count2", d.Exercise_Count2);
                        cmd.Parameters.AddWithValue("@Exercise_Count3", d.Exercise_Count3);
                        cmd.Parameters.AddWithValue("@Exercise_Count4", d.Exercise_Count4);
                        cmd.Parameters.AddWithValue("@Exercise_Count5", d.Exercise_Count5);
                    }
                    if (ctcount == 6)
                    {
                        sql2 = "INSERT INTO Back_Info  VALUES (@Customer_Name , @Day_Name, @Date ,@Exercise_Count1, @Exercise_Count2,@Exercise_Count3,@Exercise_Count4,@Exercise_Count5,@Exercise_Count6)";
                        cmd = new SqlCommand(sql2, conn);

                        cmd.Parameters.AddWithValue("@Exercise_Count1", d.Exercise_Count1);
                        cmd.Parameters.AddWithValue("@Exercise_Count2", d.Exercise_Count2);
                        cmd.Parameters.AddWithValue("@Exercise_Count3", d.Exercise_Count3);
                        cmd.Parameters.AddWithValue("@Exercise_Count4", d.Exercise_Count4);
                        cmd.Parameters.AddWithValue("@Exercise_Count5", d.Exercise_Count5);
                        cmd.Parameters.AddWithValue("@Exercise_Count6", d.Exercise_Count6);
                    }
                    if (ctcount == 7)
                    {
                        sql2 = "INSERT INTO Back_Info  VALUES (@Customer_Name , @Day_Name, @Date ,@Exercise_Count1, @Exercise_Count2,@Exercise_Count3,@Exercise_Count4,@Exercise_Count5,@Exercise_Count6,@Exercise_Count7)";
                        cmd = new SqlCommand(sql2, conn);

                        cmd.Parameters.AddWithValue("@Exercise_Count1", d.Exercise_Count1);
                        cmd.Parameters.AddWithValue("@Exercise_Count2", d.Exercise_Count2);
                        cmd.Parameters.AddWithValue("@Exercise_Count3", d.Exercise_Count3);
                        cmd.Parameters.AddWithValue("@Exercise_Count4", d.Exercise_Count4);
                        cmd.Parameters.AddWithValue("@Exercise_Count5", d.Exercise_Count5);
                        cmd.Parameters.AddWithValue("@Exercise_Count6", d.Exercise_Count6);
                        cmd.Parameters.AddWithValue("@Exercise_Count7", d.Exercise_Count7);
                    }
                    if (ctcount == 8)
                    {
                        sql2 = "INSERT INTO Back_Info  VALUES (@Customer_Name , @Day_Name, @Date ,@Exercise_Count1, @Exercise_Count2,@Exercise_Count3,@Exercise_Count4,@Exercise_Count5,@Exercise_Count6,@Exercise_Count7,@Exercise_Count8)";
                        cmd = new SqlCommand(sql2, conn);

                        cmd.Parameters.AddWithValue("@Exercise_Count1", d.Exercise_Count1);
                        cmd.Parameters.AddWithValue("@Exercise_Count2", d.Exercise_Count2);
                        cmd.Parameters.AddWithValue("@Exercise_Count3", d.Exercise_Count3);
                        cmd.Parameters.AddWithValue("@Exercise_Count4", d.Exercise_Count4);
                        cmd.Parameters.AddWithValue("@Exercise_Count5", d.Exercise_Count5);
                        cmd.Parameters.AddWithValue("@Exercise_Count6", d.Exercise_Count6);
                        cmd.Parameters.AddWithValue("@Exercise_Count7", d.Exercise_Count7);
                        cmd.Parameters.AddWithValue("@Exercise_Count8", d.Exercise_Count8);
                    }
                    if (ctcount == 9)
                    {
                        sql2 = "INSERT INTO Back_Info  VALUES (@Customer_Name , @Day_Name, @Date ,@Exercise_Count1, @Exercise_Count2,@Exercise_Count3,@Exercise_Count4,@Exercise_Count5,@Exercise_Count6,@Exercise_Count7,@Exercise_Count8,@Exercise_Count9)";
                        cmd = new SqlCommand(sql2, conn);

                        cmd.Parameters.AddWithValue("@Exercise_Count1", d.Exercise_Count1);
                        cmd.Parameters.AddWithValue("@Exercise_Count2", d.Exercise_Count2);
                        cmd.Parameters.AddWithValue("@Exercise_Count3", d.Exercise_Count3);
                        cmd.Parameters.AddWithValue("@Exercise_Count4", d.Exercise_Count4);
                        cmd.Parameters.AddWithValue("@Exercise_Count5", d.Exercise_Count5);
                        cmd.Parameters.AddWithValue("@Exercise_Count6", d.Exercise_Count6);
                        cmd.Parameters.AddWithValue("@Exercise_Count7", d.Exercise_Count7);
                        cmd.Parameters.AddWithValue("@Exercise_Count8", d.Exercise_Count8);
                        cmd.Parameters.AddWithValue("@Exercise_Count9", d.Exercise_Count9);
                    }

                    if (ctcount == 10)
                    {
                        sql2 = "INSERT INTO Back_Info  VALUES (@Customer_Name , @Day_Name, @Date ,@Exercise_Count1, @Exercise_Count2,@Exercise_Count3,@Exercise_Count4,@Exercise_Count5,@Exercise_Count6,@Exercise_Count7,@Exercise_Count8,@Exercise_Count9,@Exercise_Count10)";
                        cmd = new SqlCommand(sql2, conn);

                        cmd.Parameters.AddWithValue("@Exercise_Count1", d.Exercise_Count1);
                        cmd.Parameters.AddWithValue("@Exercise_Count2", d.Exercise_Count2);
                        cmd.Parameters.AddWithValue("@Exercise_Count3", d.Exercise_Count3);
                        cmd.Parameters.AddWithValue("@Exercise_Count4", d.Exercise_Count4);
                        cmd.Parameters.AddWithValue("@Exercise_Count5", d.Exercise_Count5);
                        cmd.Parameters.AddWithValue("@Exercise_Count6", d.Exercise_Count6);
                        cmd.Parameters.AddWithValue("@Exercise_Count7", d.Exercise_Count7);
                        cmd.Parameters.AddWithValue("@Exercise_Count8", d.Exercise_Count8);
                        cmd.Parameters.AddWithValue("@Exercise_Count9", d.Exercise_Count9);
                        cmd.Parameters.AddWithValue("@Exercise_Count10", d.Exercise_Count10);
                    }



                }

                if (d.Focus.ToLower() == "triceps")
                {
                    if (ctcount == 1)
                    {
                        sql2 = "INSERT INTO Triceps_Info  VALUES (@Customer_Name , @Day_Name, @Date , @Exercise_Count1)";
                        cmd = new SqlCommand(sql2, conn);

                        cmd.Parameters.AddWithValue("@Exercise_Count1", d.Exercise_Count1);
                    }

                    if (ctcount == 2)
                    {

                        sql2 = "INSERT INTO Triceps_Info  VALUES (@Customer_Name , @Day_Name, @Date , @Exercise_Count1, @Exercise_Count2)";
                        cmd = new SqlCommand(sql2, conn);

                        cmd.Parameters.AddWithValue("@Exercise_Count1", d.Exercise_Count1);
                        cmd.Parameters.AddWithValue("@Exercise_Count2", d.Exercise_Count2);
                    }

                    if (ctcount == 3)
                    {
                        sql2 = "INSERT INTO Triceps_Info  VALUES (@Customer_Name , @Day_Name, @Date , @Exercise_Count1, @Exercise_Count2 , @Exercise_Count3)";
                        cmd = new SqlCommand(sql2, conn);

                        cmd.Parameters.AddWithValue("@Exercise_Count1", d.Exercise_Count1);
                        cmd.Parameters.AddWithValue("@Exercise_Count2", d.Exercise_Count2);
                        cmd.Parameters.AddWithValue("@Exercise_Count3", d.Exercise_Count3);
                    }

                    if (ctcount == 4)
                    {
                        sql2 = "INSERT INTO Triceps_Info  VALUES (@Customer_Name , @Day_Name, @Date , @Exercise_Count1, @Exercise_Count2, @Exercise_Count3, @Exercise_Count4)";
                        cmd = new SqlCommand(sql2, conn);

                        cmd.Parameters.AddWithValue("@Exercise_Count1", d.Exercise_Count1);
                        cmd.Parameters.AddWithValue("@Exercise_Count2", d.Exercise_Count2);
                        cmd.Parameters.AddWithValue("@Exercise_Count3", d.Exercise_Count3);
                        cmd.Parameters.AddWithValue("@Exercise_Count4", d.Exercise_Count4);
                    }

                    if (ctcount == 5)
                    {
                        sql2 = "INSERT INTO Triceps_Info  VALUES (@Customer_Name , @Day_Name, @Date ,@Exercise_Count1, @Exercise_Count2,@Exercise_Count3,@Exercise_Count4,@Exercise_Count5)";
                        cmd = new SqlCommand(sql2, conn);

                        cmd.Parameters.AddWithValue("@Exercise_Count1", d.Exercise_Count1);
                        cmd.Parameters.AddWithValue("@Exercise_Count2", d.Exercise_Count2);
                        cmd.Parameters.AddWithValue("@Exercise_Count3", d.Exercise_Count3);
                        cmd.Parameters.AddWithValue("@Exercise_Count4", d.Exercise_Count4);
                        cmd.Parameters.AddWithValue("@Exercise_Count5", d.Exercise_Count5);
                    }
                    if (ctcount == 6)
                    {
                        sql2 = "INSERT INTO Triceps_Info  VALUES (@Customer_Name , @Day_Name, @Date ,@Exercise_Count1, @Exercise_Count2,@Exercise_Count3,@Exercise_Count4,@Exercise_Count5,@Exercise_Count6)";
                        cmd = new SqlCommand(sql2, conn);

                        cmd.Parameters.AddWithValue("@Exercise_Count1", d.Exercise_Count1);
                        cmd.Parameters.AddWithValue("@Exercise_Count2", d.Exercise_Count2);
                        cmd.Parameters.AddWithValue("@Exercise_Count3", d.Exercise_Count3);
                        cmd.Parameters.AddWithValue("@Exercise_Count4", d.Exercise_Count4);
                        cmd.Parameters.AddWithValue("@Exercise_Count5", d.Exercise_Count5);
                        cmd.Parameters.AddWithValue("@Exercise_Count6", d.Exercise_Count6);
                    }
                    if (ctcount == 7)
                    {
                        sql2 = "INSERT INTO Triceps_Info  VALUES (@Customer_Name , @Day_Name, @Date ,@Exercise_Count1, @Exercise_Count2,@Exercise_Count3,@Exercise_Count4,@Exercise_Count5,@Exercise_Count6,@Exercise_Count7)";
                        cmd = new SqlCommand(sql2, conn);

                        cmd.Parameters.AddWithValue("@Exercise_Count1", d.Exercise_Count1);
                        cmd.Parameters.AddWithValue("@Exercise_Count2", d.Exercise_Count2);
                        cmd.Parameters.AddWithValue("@Exercise_Count3", d.Exercise_Count3);
                        cmd.Parameters.AddWithValue("@Exercise_Count4", d.Exercise_Count4);
                        cmd.Parameters.AddWithValue("@Exercise_Count5", d.Exercise_Count5);
                        cmd.Parameters.AddWithValue("@Exercise_Count6", d.Exercise_Count6);
                        cmd.Parameters.AddWithValue("@Exercise_Count7", d.Exercise_Count7);
                    }
                    if (ctcount == 8)
                    {
                        sql2 = "INSERT INTO Triceps_Info  VALUES (@Customer_Name , @Day_Name, @Date ,@Exercise_Count1, @Exercise_Count2,@Exercise_Count3,@Exercise_Count4,@Exercise_Count5,@Exercise_Count6,@Exercise_Count7,@Exercise_Count8)";
                        cmd = new SqlCommand(sql2, conn);

                        cmd.Parameters.AddWithValue("@Exercise_Count1", d.Exercise_Count1);
                        cmd.Parameters.AddWithValue("@Exercise_Count2", d.Exercise_Count2);
                        cmd.Parameters.AddWithValue("@Exercise_Count3", d.Exercise_Count3);
                        cmd.Parameters.AddWithValue("@Exercise_Count4", d.Exercise_Count4);
                        cmd.Parameters.AddWithValue("@Exercise_Count5", d.Exercise_Count5);
                        cmd.Parameters.AddWithValue("@Exercise_Count6", d.Exercise_Count6);
                        cmd.Parameters.AddWithValue("@Exercise_Count7", d.Exercise_Count7);
                        cmd.Parameters.AddWithValue("@Exercise_Count8", d.Exercise_Count8);
                    }
                    if (ctcount == 9)
                    {
                        sql2 = "INSERT INTO Triceps_Info  VALUES (@Customer_Name , @Day_Name, @Date ,@Exercise_Count1, @Exercise_Count2,@Exercise_Count3,@Exercise_Count4,@Exercise_Count5,@Exercise_Count6,@Exercise_Count7,@Exercise_Count8,@Exercise_Count9)";
                        cmd = new SqlCommand(sql2, conn);

                        cmd.Parameters.AddWithValue("@Exercise_Count1", d.Exercise_Count1);
                        cmd.Parameters.AddWithValue("@Exercise_Count2", d.Exercise_Count2);
                        cmd.Parameters.AddWithValue("@Exercise_Count3", d.Exercise_Count3);
                        cmd.Parameters.AddWithValue("@Exercise_Count4", d.Exercise_Count4);
                        cmd.Parameters.AddWithValue("@Exercise_Count5", d.Exercise_Count5);
                        cmd.Parameters.AddWithValue("@Exercise_Count6", d.Exercise_Count6);
                        cmd.Parameters.AddWithValue("@Exercise_Count7", d.Exercise_Count7);
                        cmd.Parameters.AddWithValue("@Exercise_Count8", d.Exercise_Count8);
                        cmd.Parameters.AddWithValue("@Exercise_Count9", d.Exercise_Count9);
                    }

                    if (ctcount == 10)
                    {
                        sql2 = "INSERT INTO Triceps_Info  VALUES (@Customer_Name , @Day_Name, @Date ,@Exercise_Count1, @Exercise_Count2,@Exercise_Count3,@Exercise_Count4,@Exercise_Count5,@Exercise_Count6,@Exercise_Count7,@Exercise_Count8,@Exercise_Count9,@Exercise_Count10)";
                        cmd = new SqlCommand(sql2, conn);

                        cmd.Parameters.AddWithValue("@Exercise_Count1", d.Exercise_Count1);
                        cmd.Parameters.AddWithValue("@Exercise_Count2", d.Exercise_Count2);
                        cmd.Parameters.AddWithValue("@Exercise_Count3", d.Exercise_Count3);
                        cmd.Parameters.AddWithValue("@Exercise_Count4", d.Exercise_Count4);
                        cmd.Parameters.AddWithValue("@Exercise_Count5", d.Exercise_Count5);
                        cmd.Parameters.AddWithValue("@Exercise_Count6", d.Exercise_Count6);
                        cmd.Parameters.AddWithValue("@Exercise_Count7", d.Exercise_Count7);
                        cmd.Parameters.AddWithValue("@Exercise_Count8", d.Exercise_Count8);
                        cmd.Parameters.AddWithValue("@Exercise_Count9", d.Exercise_Count9);
                        cmd.Parameters.AddWithValue("@Exercise_Count10", d.Exercise_Count10);
                    }



                }

                if (d.Focus.ToLower() == "biceps")
                {
                    if (ctcount == 1)
                    {
                        sql2 = "INSERT INTO Biceps_Info  VALUES (@Customer_Name , @Day_Name, @Date , @Exercise_Count1)";
                        cmd = new SqlCommand(sql2, conn);

                        cmd.Parameters.AddWithValue("@Exercise_Count1", d.Exercise_Count1);
                    }

                    if (ctcount == 2)
                    {

                        sql2 = "INSERT INTO Biceps_Info  VALUES (@Customer_Name , @Day_Name, @Date , @Exercise_Count1, @Exercise_Count2)";
                        cmd = new SqlCommand(sql2, conn);

                        cmd.Parameters.AddWithValue("@Exercise_Count1", d.Exercise_Count1);
                        cmd.Parameters.AddWithValue("@Exercise_Count2", d.Exercise_Count2);
                    }

                    if (ctcount == 3)
                    {
                        sql2 = "INSERT INTO Biceps_Info VALUES (@Customer_Name , @Day_Name, @Date , @Exercise_Count1, @Exercise_Count2 , @Exercise_Count3)";
                        cmd = new SqlCommand(sql2, conn);

                        cmd.Parameters.AddWithValue("@Exercise_Count1", d.Exercise_Count1);
                        cmd.Parameters.AddWithValue("@Exercise_Count2", d.Exercise_Count2);
                        cmd.Parameters.AddWithValue("@Exercise_Count3", d.Exercise_Count3);
                    }

                    if (ctcount == 4)
                    {
                        sql2 = "INSERT INTO Biceps_Info  VALUES (@Customer_Name , @Day_Name, @Date , @Exercise_Count1, @Exercise_Count2, @Exercise_Count3, @Exercise_Count4)";
                        cmd = new SqlCommand(sql2, conn);

                        cmd.Parameters.AddWithValue("@Exercise_Count1", d.Exercise_Count1);
                        cmd.Parameters.AddWithValue("@Exercise_Count2", d.Exercise_Count2);
                        cmd.Parameters.AddWithValue("@Exercise_Count3", d.Exercise_Count3);
                        cmd.Parameters.AddWithValue("@Exercise_Count4", d.Exercise_Count4);
                    }

                    if (ctcount == 5)
                    {
                        sql2 = "INSERT INTO Biceps_Info  VALUES (@Customer_Name , @Day_Name, @Date ,@Exercise_Count1, @Exercise_Count2,@Exercise_Count3,@Exercise_Count4,@Exercise_Count5)";
                        cmd = new SqlCommand(sql2, conn);

                        cmd.Parameters.AddWithValue("@Exercise_Count1", d.Exercise_Count1);
                        cmd.Parameters.AddWithValue("@Exercise_Count2", d.Exercise_Count2);
                        cmd.Parameters.AddWithValue("@Exercise_Count3", d.Exercise_Count3);
                        cmd.Parameters.AddWithValue("@Exercise_Count4", d.Exercise_Count4);
                        cmd.Parameters.AddWithValue("@Exercise_Count5", d.Exercise_Count5);
                    }
                    if (ctcount == 6)
                    {
                        sql2 = "INSERT INTO Biceps_Info  VALUES (@Customer_Name , @Day_Name, @Date ,@Exercise_Count1, @Exercise_Count2,@Exercise_Count3,@Exercise_Count4,@Exercise_Count5,@Exercise_Count6)";
                        cmd = new SqlCommand(sql2, conn);

                        cmd.Parameters.AddWithValue("@Exercise_Count1", d.Exercise_Count1);
                        cmd.Parameters.AddWithValue("@Exercise_Count2", d.Exercise_Count2);
                        cmd.Parameters.AddWithValue("@Exercise_Count3", d.Exercise_Count3);
                        cmd.Parameters.AddWithValue("@Exercise_Count4", d.Exercise_Count4);
                        cmd.Parameters.AddWithValue("@Exercise_Count5", d.Exercise_Count5);
                        cmd.Parameters.AddWithValue("@Exercise_Count6", d.Exercise_Count6);
                    }
                    if (ctcount == 7)
                    {
                        sql2 = "INSERT INTO Biceps_Info VALUES (@Customer_Name , @Day_Name, @Date ,@Exercise_Count1, @Exercise_Count2,@Exercise_Count3,@Exercise_Count4,@Exercise_Count5,@Exercise_Count6,@Exercise_Count7)";
                        cmd = new SqlCommand(sql2, conn);

                        cmd.Parameters.AddWithValue("@Exercise_Count1", d.Exercise_Count1);
                        cmd.Parameters.AddWithValue("@Exercise_Count2", d.Exercise_Count2);
                        cmd.Parameters.AddWithValue("@Exercise_Count3", d.Exercise_Count3);
                        cmd.Parameters.AddWithValue("@Exercise_Count4", d.Exercise_Count4);
                        cmd.Parameters.AddWithValue("@Exercise_Count5", d.Exercise_Count5);
                        cmd.Parameters.AddWithValue("@Exercise_Count6", d.Exercise_Count6);
                        cmd.Parameters.AddWithValue("@Exercise_Count7", d.Exercise_Count7);
                    }
                    if (ctcount == 8)
                    {
                        sql2 = "INSERT INTO Biceps_Info  VALUES (@Customer_Name , @Day_Name, @Date ,@Exercise_Count1, @Exercise_Count2,@Exercise_Count3,@Exercise_Count4,@Exercise_Count5,@Exercise_Count6,@Exercise_Count7,@Exercise_Count8)";
                        cmd = new SqlCommand(sql2, conn);

                        cmd.Parameters.AddWithValue("@Exercise_Count1", d.Exercise_Count1);
                        cmd.Parameters.AddWithValue("@Exercise_Count2", d.Exercise_Count2);
                        cmd.Parameters.AddWithValue("@Exercise_Count3", d.Exercise_Count3);
                        cmd.Parameters.AddWithValue("@Exercise_Count4", d.Exercise_Count4);
                        cmd.Parameters.AddWithValue("@Exercise_Count5", d.Exercise_Count5);
                        cmd.Parameters.AddWithValue("@Exercise_Count6", d.Exercise_Count6);
                        cmd.Parameters.AddWithValue("@Exercise_Count7", d.Exercise_Count7);
                        cmd.Parameters.AddWithValue("@Exercise_Count8", d.Exercise_Count8);
                    }
                    if (ctcount == 9)
                    {
                        sql2 = "INSERT INTO Biceps_Info  VALUES (@Customer_Name , @Day_Name, @Date ,@Exercise_Count1, @Exercise_Count2,@Exercise_Count3,@Exercise_Count4,@Exercise_Count5,@Exercise_Count6,@Exercise_Count7,@Exercise_Count8,@Exercise_Count9)";
                        cmd = new SqlCommand(sql2, conn);

                        cmd.Parameters.AddWithValue("@Exercise_Count1", d.Exercise_Count1);
                        cmd.Parameters.AddWithValue("@Exercise_Count2", d.Exercise_Count2);
                        cmd.Parameters.AddWithValue("@Exercise_Count3", d.Exercise_Count3);
                        cmd.Parameters.AddWithValue("@Exercise_Count4", d.Exercise_Count4);
                        cmd.Parameters.AddWithValue("@Exercise_Count5", d.Exercise_Count5);
                        cmd.Parameters.AddWithValue("@Exercise_Count6", d.Exercise_Count6);
                        cmd.Parameters.AddWithValue("@Exercise_Count7", d.Exercise_Count7);
                        cmd.Parameters.AddWithValue("@Exercise_Count8", d.Exercise_Count8);
                        cmd.Parameters.AddWithValue("@Exercise_Count9", d.Exercise_Count9);
                    }

                    if (ctcount == 10)
                    {
                        sql2 = "INSERT INTO Biceps_Info  VALUES (@Customer_Name , @Day_Name, @Date ,@Exercise_Count1, @Exercise_Count2,@Exercise_Count3,@Exercise_Count4,@Exercise_Count5,@Exercise_Count6,@Exercise_Count7,@Exercise_Count8,@Exercise_Count9,@Exercise_Count10)";
                        cmd = new SqlCommand(sql2, conn);

                        cmd.Parameters.AddWithValue("@Exercise_Count1", d.Exercise_Count1);
                        cmd.Parameters.AddWithValue("@Exercise_Count2", d.Exercise_Count2);
                        cmd.Parameters.AddWithValue("@Exercise_Count3", d.Exercise_Count3);
                        cmd.Parameters.AddWithValue("@Exercise_Count4", d.Exercise_Count4);
                        cmd.Parameters.AddWithValue("@Exercise_Count5", d.Exercise_Count5);
                        cmd.Parameters.AddWithValue("@Exercise_Count6", d.Exercise_Count6);
                        cmd.Parameters.AddWithValue("@Exercise_Count7", d.Exercise_Count7);
                        cmd.Parameters.AddWithValue("@Exercise_Count8", d.Exercise_Count8);
                        cmd.Parameters.AddWithValue("@Exercise_Count9", d.Exercise_Count9);
                        cmd.Parameters.AddWithValue("@Exercise_Count10", d.Exercise_Count10);
                    }



                }

                if (d.Focus.ToLower() == "legs")
                {
                    if (ctcount == 1)
                    {
                        sql2 = "INSERT INTO Cardio_Legs_Info  VALUES (@Customer_Name , @Day_Name, @Date , @Exercise_Count1)";
                        cmd = new SqlCommand(sql2, conn);

                        cmd.Parameters.AddWithValue("@Exercise_Count1", d.Exercise_Count1);
                    }

                    if (ctcount == 2)
                    {

                        sql2 = "INSERT INTO Cardio_Legs_Info  VALUES (@Customer_Name , @Day_Name, @Date , @Exercise_Count1, @Exercise_Count2)";
                        cmd = new SqlCommand(sql2, conn);

                        cmd.Parameters.AddWithValue("@Exercise_Count1", d.Exercise_Count1);
                        cmd.Parameters.AddWithValue("@Exercise_Count2", d.Exercise_Count2);
                    }

                    if (ctcount == 3)
                    {
                        sql2 = "INSERT INTO Cardio_Legs_Info VALUES (@Customer_Name , @Day_Name, @Date , @Exercise_Count1, @Exercise_Count2 , @Exercise_Count3)";
                        cmd = new SqlCommand(sql2, conn);

                        cmd.Parameters.AddWithValue("@Exercise_Count1", d.Exercise_Count1);
                        cmd.Parameters.AddWithValue("@Exercise_Count2", d.Exercise_Count2);
                        cmd.Parameters.AddWithValue("@Exercise_Count3", d.Exercise_Count3);
                    }

                    if (ctcount == 4)
                    {
                        sql2 = "INSERT INTO Cardio_Legs_Info  VALUES (@Customer_Name , @Day_Name, @Date , @Exercise_Count1, @Exercise_Count2, @Exercise_Count3, @Exercise_Count4)";
                        cmd = new SqlCommand(sql2, conn);

                        cmd.Parameters.AddWithValue("@Exercise_Count1", d.Exercise_Count1);
                        cmd.Parameters.AddWithValue("@Exercise_Count2", d.Exercise_Count2);
                        cmd.Parameters.AddWithValue("@Exercise_Count3", d.Exercise_Count3);
                        cmd.Parameters.AddWithValue("@Exercise_Count4", d.Exercise_Count4);
                    }

                    if (ctcount == 5)
                    {
                        sql2 = "INSERT INTO Cardio_Legs_Info VALUES (@Customer_Name , @Day_Name, @Date ,@Exercise_Count1, @Exercise_Count2,@Exercise_Count3,@Exercise_Count4,@Exercise_Count5)";
                        cmd = new SqlCommand(sql2, conn);

                        cmd.Parameters.AddWithValue("@Exercise_Count1", d.Exercise_Count1);
                        cmd.Parameters.AddWithValue("@Exercise_Count2", d.Exercise_Count2);
                        cmd.Parameters.AddWithValue("@Exercise_Count3", d.Exercise_Count3);
                        cmd.Parameters.AddWithValue("@Exercise_Count4", d.Exercise_Count4);
                        cmd.Parameters.AddWithValue("@Exercise_Count5", d.Exercise_Count5);
                    }
                    if (ctcount == 6)
                    {
                        sql2 = "INSERT INTO Cardio_Legs_Info VALUES (@Customer_Name , @Day_Name, @Date ,@Exercise_Count1, @Exercise_Count2,@Exercise_Count3,@Exercise_Count4,@Exercise_Count5,@Exercise_Count6)";
                        cmd = new SqlCommand(sql2, conn);

                        cmd.Parameters.AddWithValue("@Exercise_Count1", d.Exercise_Count1);
                        cmd.Parameters.AddWithValue("@Exercise_Count2", d.Exercise_Count2);
                        cmd.Parameters.AddWithValue("@Exercise_Count3", d.Exercise_Count3);
                        cmd.Parameters.AddWithValue("@Exercise_Count4", d.Exercise_Count4);
                        cmd.Parameters.AddWithValue("@Exercise_Count5", d.Exercise_Count5);
                        cmd.Parameters.AddWithValue("@Exercise_Count6", d.Exercise_Count6);
                    }
                    if (ctcount == 7)
                    {
                        sql2 = "INSERT INTO Cardio_Legs_Info VALUES (@Customer_Name , @Day_Name, @Date ,@Exercise_Count1, @Exercise_Count2,@Exercise_Count3,@Exercise_Count4,@Exercise_Count5,@Exercise_Count6,@Exercise_Count7)";
                        cmd = new SqlCommand(sql2, conn);

                        cmd.Parameters.AddWithValue("@Exercise_Count1", d.Exercise_Count1);
                        cmd.Parameters.AddWithValue("@Exercise_Count2", d.Exercise_Count2);
                        cmd.Parameters.AddWithValue("@Exercise_Count3", d.Exercise_Count3);
                        cmd.Parameters.AddWithValue("@Exercise_Count4", d.Exercise_Count4);
                        cmd.Parameters.AddWithValue("@Exercise_Count5", d.Exercise_Count5);
                        cmd.Parameters.AddWithValue("@Exercise_Count6", d.Exercise_Count6);
                        cmd.Parameters.AddWithValue("@Exercise_Count7", d.Exercise_Count7);
                    }
                    if (ctcount == 8)
                    {
                        sql2 = "INSERT INTO Cardio_Legs_Info VALUES (@Customer_Name , @Day_Name, @Date ,@Exercise_Count1, @Exercise_Count2,@Exercise_Count3,@Exercise_Count4,@Exercise_Count5,@Exercise_Count6,@Exercise_Count7,@Exercise_Count8)";
                        cmd = new SqlCommand(sql2, conn);

                        cmd.Parameters.AddWithValue("@Exercise_Count1", d.Exercise_Count1);
                        cmd.Parameters.AddWithValue("@Exercise_Count2", d.Exercise_Count2);
                        cmd.Parameters.AddWithValue("@Exercise_Count3", d.Exercise_Count3);
                        cmd.Parameters.AddWithValue("@Exercise_Count4", d.Exercise_Count4);
                        cmd.Parameters.AddWithValue("@Exercise_Count5", d.Exercise_Count5);
                        cmd.Parameters.AddWithValue("@Exercise_Count6", d.Exercise_Count6);
                        cmd.Parameters.AddWithValue("@Exercise_Count7", d.Exercise_Count7);
                        cmd.Parameters.AddWithValue("@Exercise_Count8", d.Exercise_Count8);
                    }
                    if (ctcount == 9)
                    {
                        sql2 = "INSERT INTO Cardio_Legs_Info VALUES (@Customer_Name , @Day_Name, @Date ,@Exercise_Count1, @Exercise_Count2,@Exercise_Count3,@Exercise_Count4,@Exercise_Count5,@Exercise_Count6,@Exercise_Count7,@Exercise_Count8,@Exercise_Count9)";
                        cmd = new SqlCommand(sql2, conn);

                        cmd.Parameters.AddWithValue("@Exercise_Count1", d.Exercise_Count1);
                        cmd.Parameters.AddWithValue("@Exercise_Count2", d.Exercise_Count2);
                        cmd.Parameters.AddWithValue("@Exercise_Count3", d.Exercise_Count3);
                        cmd.Parameters.AddWithValue("@Exercise_Count4", d.Exercise_Count4);
                        cmd.Parameters.AddWithValue("@Exercise_Count5", d.Exercise_Count5);
                        cmd.Parameters.AddWithValue("@Exercise_Count6", d.Exercise_Count6);
                        cmd.Parameters.AddWithValue("@Exercise_Count7", d.Exercise_Count7);
                        cmd.Parameters.AddWithValue("@Exercise_Count8", d.Exercise_Count8);
                        cmd.Parameters.AddWithValue("@Exercise_Count9", d.Exercise_Count9);
                    }

                    if (ctcount == 10)
                    {
                        sql2 = "INSERT INTO Cardio_Legs_Info VALUES (@Customer_Name , @Day_Name, @Date ,@Exercise_Count1, @Exercise_Count2,@Exercise_Count3,@Exercise_Count4,@Exercise_Count5,@Exercise_Count6,@Exercise_Count7,@Exercise_Count8,@Exercise_Count9,@Exercise_Count10)";
                        cmd = new SqlCommand(sql2, conn);

                        cmd.Parameters.AddWithValue("@Exercise_Count1", d.Exercise_Count1);
                        cmd.Parameters.AddWithValue("@Exercise_Count2", d.Exercise_Count2);
                        cmd.Parameters.AddWithValue("@Exercise_Count3", d.Exercise_Count3);
                        cmd.Parameters.AddWithValue("@Exercise_Count4", d.Exercise_Count4);
                        cmd.Parameters.AddWithValue("@Exercise_Count5", d.Exercise_Count5);
                        cmd.Parameters.AddWithValue("@Exercise_Count6", d.Exercise_Count6);
                        cmd.Parameters.AddWithValue("@Exercise_Count7", d.Exercise_Count7);
                        cmd.Parameters.AddWithValue("@Exercise_Count8", d.Exercise_Count8);
                        cmd.Parameters.AddWithValue("@Exercise_Count9", d.Exercise_Count9);
                        cmd.Parameters.AddWithValue("@Exercise_Count10", d.Exercise_Count10);
                    }



                }   


                cmd.Parameters.AddWithValue("@Customer_Name", d.Customer_Name);
                cmd.Parameters.AddWithValue("@Day_Name", d.Day_Name);
                cmd.Parameters.AddWithValue("@Date", d.Date);

                conn.Open();

                int rows = cmd.ExecuteNonQuery();

                if (rows > 0)
                {
                    isSuccess = true;
                }
                else
                {
                    isSuccess = false;
                }
            }
            catch (System.Data.SqlClient.SqlException sqlException)
            {
                System.Windows.Forms.MessageBox.Show(sqlException.Message);
            }

            finally
            {
                conn.Close();
            }
            return isSuccess;

        }
    }
}
