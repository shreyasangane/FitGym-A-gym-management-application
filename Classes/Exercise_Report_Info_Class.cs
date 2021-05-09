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
    class Exercise_Report_Info_Class
    {
        public string Customer_Name { get; set; }
        
        public DateTime Last_Report_Date { get; set; }
        public DateTime Today_Date { get; set; }
                

        static string myconnstrng = ConfigurationManager.ConnectionStrings["connstrng"].ConnectionString;

        public DataTable LastReport_Select(Exercise_Report_Info_Class d)
        {
            SqlConnection conn = new SqlConnection(myconnstrng);
            DataTable dt = new DataTable();

            try
            {

                Console.WriteLine(d.Last_Report_Date);
                Console.WriteLine(d.Today_Date);
                //  string sql = "INSERT INTO Exercise_Info(Customer_Name,Address,Phone_No,Email_Id,Gender,Age,Biceps_Size,Calf_Size,Chest_Size,Hip_Size,Weight,Height,Fat_Percent,Package,Personal_Trainer,Time_Preference,BMI) VALUES(@Customer_Name, @Address, @Phone_No, @Email_Id, @Gender, @Age, @Biceps_Size, @Calf_Size, @Chest_Size, @Hip_Size,@Weight,@Height,@Fat_Percent,@Package,@Personal_Trainer,@Time_Preference,@BMI)";
                string sql = "select Biceps_Size,Triceps_Size,Chest_Size,Back_Size,Shoulder_Size,Legs_Size,Height,Weight,Fat_percent,BMI from Monthly_Report_Info where Customer_Name=@Customer_Name AND Report_Date=@Last_Report_Date";//  Customer_Name='+ @Customer_Name + ' and Date Between ' +@Last_Report_Date + ' and '+ @Today_Date  )";

                SqlCommand cmd = new SqlCommand(sql, conn);


                cmd.Parameters.AddWithValue("@Customer_Name", d.Customer_Name);
                cmd.Parameters.AddWithValue("@Last_Report_Date", d.Last_Report_Date);
               

                Console.WriteLine(cmd);
                Console.WriteLine(sql);

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);


                Console.WriteLine(adapter);

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
       
        public DataTable Legs_Select(Exercise_Report_Info_Class d)
        {
            SqlConnection conn = new SqlConnection(myconnstrng);
            DataTable dt = new DataTable();

            try
            {
               
                Console.WriteLine(d.Last_Report_Date);
                Console.WriteLine(d.Today_Date);
                //  string sql = "INSERT INTO Exercise_Info(Customer_Name,Address,Phone_No,Email_Id,Gender,Age,Biceps_Size,Calf_Size,Chest_Size,Hip_Size,Weight,Height,Fat_Percent,Package,Personal_Trainer,Time_Preference,BMI) VALUES(@Customer_Name, @Address, @Phone_No, @Email_Id, @Gender, @Age, @Biceps_Size, @Calf_Size, @Chest_Size, @Hip_Size,@Weight,@Height,@Fat_Percent,@Package,@Personal_Trainer,@Time_Preference,@BMI)";
                string sql = " select  SUM(Free_Squats), SUM(Weighted_Squats), SUM(Free_Lunges), SUM(Weighted_Lunges) , SUM(Leg_Press), SUM(Leg_Curls_Front) , SUM(Leg_Curls_Back) , SUM(Free_Calf_Raise) , SUM(Weighted_Calf_Raise)   from Cardio_Legs_Info where Customer_Name=@Customer_Name and Date Between @Last_Report_Date  and  @Today_Date";//  Customer_Name='+ @Customer_Name + ' and Date Between ' +@Last_Report_Date + ' and '+ @Today_Date  )";
               
                SqlCommand cmd = new SqlCommand(sql, conn);

                
                cmd.Parameters.AddWithValue("@Customer_Name", d.Customer_Name);
                cmd.Parameters.AddWithValue("@Last_Report_Date", d.Last_Report_Date);
                cmd.Parameters.AddWithValue("@Today_Date", d.Today_Date);

                Console.WriteLine(cmd);
                Console.WriteLine(sql);

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);


                Console.WriteLine(adapter);

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

        public DataTable Chest_Select(Exercise_Report_Info_Class d)
        {
            SqlConnection conn = new SqlConnection(myconnstrng);
            DataTable dt = new DataTable();

            try
            {

                Console.WriteLine(d.Last_Report_Date);
                Console.WriteLine(d.Today_Date);
                //  string sql = "INSERT INTO Exercise_Info(Customer_Name,Address,Phone_No,Email_Id,Gender,Age,Biceps_Size,Calf_Size,Chest_Size,Hip_Size,Weight,Height,Fat_Percent,Package,Personal_Trainer,Time_Preference,BMI) VALUES(@Customer_Name, @Address, @Phone_No, @Email_Id, @Gender, @Age, @Biceps_Size, @Calf_Size, @Chest_Size, @Hip_Size,@Weight,@Height,@Fat_Percent,@Package,@Personal_Trainer,@Time_Preference,@BMI)";
                string sql = " select  SUM(Barbell_Bench_Press), SUM(Flat_Bench_Dumbell_Press), SUM(Low_Incline_Barbell_Press), SUM(Machine_Decline_Press) , SUM(Seated_Machine_Chest_Press), SUM(Incline_Dumbell_Press) , SUM(Push_Ups) , SUM(Incline_Bench_Cable_Fly) , SUM(Incline_Dumbell_Pullover), SUM(Peck_Deck_Machine)   from Chest_Info where Customer_Name=@Customer_Name and Date Between @Last_Report_Date  and  @Today_Date";//  Customer_Name='+ @Customer_Name + ' and Date Between ' +@Last_Report_Date + ' and '+ @Today_Date  )";

                SqlCommand cmd = new SqlCommand(sql, conn);


                cmd.Parameters.AddWithValue("@Customer_Name", d.Customer_Name);
                cmd.Parameters.AddWithValue("@Last_Report_Date", d.Last_Report_Date);
                cmd.Parameters.AddWithValue("@Today_Date", d.Today_Date);

                Console.WriteLine(cmd);
                Console.WriteLine(sql);

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);


                Console.WriteLine(adapter);

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

        public DataTable Shoulder_Select(Exercise_Report_Info_Class d)
        {
            SqlConnection conn = new SqlConnection(myconnstrng);
            DataTable dt = new DataTable();

            try
            {

                Console.WriteLine(d.Last_Report_Date);
                Console.WriteLine(d.Today_Date);
                //  string sql = "INSERT INTO Exercise_Info(Customer_Name,Address,Phone_No,Email_Id,Gender,Age,Biceps_Size,Calf_Size,Chest_Size,Hip_Size,Weight,Height,Fat_Percent,Package,Personal_Trainer,Time_Preference,BMI) VALUES(@Customer_Name, @Address, @Phone_No, @Email_Id, @Gender, @Age, @Biceps_Size, @Calf_Size, @Chest_Size, @Hip_Size,@Weight,@Height,@Fat_Percent,@Package,@Personal_Trainer,@Time_Preference,@BMI)";
                string sql = " select  SUM(Barbell_Push_Press), SUM(Dumbell_Press), SUM(Dumbell_Incline_Row), SUM(Seated_Overhead_Dumbell_Press) , SUM(Seated_Overhead_Barbell_Press), SUM(Upright_Row) , SUM(Arnold_Press) , SUM(Lateral_Raise) , SUM(Front_Raise) from Shoulder_Info where Customer_Name=@Customer_Name and Date Between @Last_Report_Date  and  @Today_Date";//  Customer_Name='+ @Customer_Name + ' and Date Between ' +@Last_Report_Date + ' and '+ @Today_Date  )";

                SqlCommand cmd = new SqlCommand(sql, conn);


                cmd.Parameters.AddWithValue("@Customer_Name", d.Customer_Name);
                cmd.Parameters.AddWithValue("@Last_Report_Date", d.Last_Report_Date);
                cmd.Parameters.AddWithValue("@Today_Date", d.Today_Date);

                Console.WriteLine(cmd);
                Console.WriteLine(sql);

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);


                Console.WriteLine(adapter);

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


        public DataTable Triceps_Select(Exercise_Report_Info_Class d)
        {
            SqlConnection conn = new SqlConnection(myconnstrng);
            DataTable dt = new DataTable();

            try
            {

                Console.WriteLine(d.Last_Report_Date);
                Console.WriteLine(d.Today_Date);
                //  string sql = "INSERT INTO Exercise_Info(Customer_Name,Address,Phone_No,Email_Id,Gender,Age,Biceps_Size,Calf_Size,Chest_Size,Hip_Size,Weight,Height,Fat_Percent,Package,Personal_Trainer,Time_Preference,BMI) VALUES(@Customer_Name, @Address, @Phone_No, @Email_Id, @Gender, @Age, @Biceps_Size, @Calf_Size, @Chest_Size, @Hip_Size,@Weight,@Height,@Fat_Percent,@Package,@Personal_Trainer,@Time_Preference,@BMI)";
                string sql = " select  SUM(Close_Grip_Bench_Press), SUM(Rope_Triceps_Push_Down), SUM(Tricep_Dips), SUM(Overhead_Triceps_Extension) , SUM(Skullcrusher), SUM(Diamond_Pressup) from Triceps_Info where Customer_Name=@Customer_Name and Date Between @Last_Report_Date  and  @Today_Date";//  Customer_Name='+ @Customer_Name + ' and Date Between ' +@Last_Report_Date + ' and '+ @Today_Date  )";

                SqlCommand cmd = new SqlCommand(sql, conn);


                cmd.Parameters.AddWithValue("@Customer_Name", d.Customer_Name);
                cmd.Parameters.AddWithValue("@Last_Report_Date", d.Last_Report_Date);
                cmd.Parameters.AddWithValue("@Today_Date", d.Today_Date);

                Console.WriteLine(cmd);
                Console.WriteLine(sql);

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);


                Console.WriteLine(adapter);

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

        public DataTable Back_Select(Exercise_Report_Info_Class d)
        {
            SqlConnection conn = new SqlConnection(myconnstrng);
            DataTable dt = new DataTable();

            try
            {

                Console.WriteLine(d.Last_Report_Date);
                Console.WriteLine(d.Today_Date);
                //  string sql = "INSERT INTO Exercise_Info(Customer_Name,Address,Phone_No,Email_Id,Gender,Age,Biceps_Size,Calf_Size,Chest_Size,Hip_Size,Weight,Height,Fat_Percent,Package,Personal_Trainer,Time_Preference,BMI) VALUES(@Customer_Name, @Address, @Phone_No, @Email_Id, @Gender, @Age, @Biceps_Size, @Calf_Size, @Chest_Size, @Hip_Size,@Weight,@Height,@Fat_Percent,@Package,@Personal_Trainer,@Time_Preference,@BMI)";
                string sql = " select  SUM(Deadlift), SUM(Pullups), SUM(Bentrows), SUM(Chinup) , SUM(Tbar_Standing),SUM(Seated_Row), SUM(Reverse_Grip_Machine_Row), SUM(Pulldown), SUM(Deline_Dumbell_Pullover) , SUM(Single_Arm_Dumbell_Row) from Back_Info where Customer_Name=@Customer_Name and Date Between @Last_Report_Date  and  @Today_Date";//  Customer_Name='+ @Customer_Name + ' and Date Between ' +@Last_Report_Date + ' and '+ @Today_Date  )";

                SqlCommand cmd = new SqlCommand(sql, conn);


                cmd.Parameters.AddWithValue("@Customer_Name", d.Customer_Name);
                cmd.Parameters.AddWithValue("@Last_Report_Date", d.Last_Report_Date);
                cmd.Parameters.AddWithValue("@Today_Date", d.Today_Date);

                Console.WriteLine(cmd);
                Console.WriteLine(sql);

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);


                Console.WriteLine(adapter);

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

        public DataTable Biceps_Select(Exercise_Report_Info_Class d)
        {
            SqlConnection conn = new SqlConnection(myconnstrng);
            DataTable dt = new DataTable();

            try
            {

                Console.WriteLine(d.Last_Report_Date);
                Console.WriteLine(d.Today_Date);
                //  string sql = "INSERT INTO Exercise_Info(Customer_Name,Address,Phone_No,Email_Id,Gender,Age,Biceps_Size,Calf_Size,Chest_Size,Hip_Size,Weight,Height,Fat_Percent,Package,Personal_Trainer,Time_Preference,BMI) VALUES(@Customer_Name, @Address, @Phone_No, @Email_Id, @Gender, @Age, @Biceps_Size, @Calf_Size, @Chest_Size, @Hip_Size,@Weight,@Height,@Fat_Percent,@Package,@Personal_Trainer,@Time_Preference,@BMI)";
                string sql = " select  SUM(Biceps_Curl), SUM(Machine_Curls_Super_Set), SUM(Biceps_Curls_Rod_Press), SUM(Hammer_Curls) , SUM(Wide_Grip_Standing_Barbel), SUM(Overhead_Cable_Curl) from Biceps_Info where Customer_Name=@Customer_Name and Date Between @Last_Report_Date  and  @Today_Date";//  Customer_Name='+ @Customer_Name + ' and Date Between ' +@Last_Report_Date + ' and '+ @Today_Date  )";

                SqlCommand cmd = new SqlCommand(sql, conn);


                cmd.Parameters.AddWithValue("@Customer_Name", d.Customer_Name);
                cmd.Parameters.AddWithValue("@Last_Report_Date", d.Last_Report_Date);
                cmd.Parameters.AddWithValue("@Today_Date", d.Today_Date);

                Console.WriteLine(cmd);
                Console.WriteLine(sql);

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);


                Console.WriteLine(adapter);

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

    }
}
