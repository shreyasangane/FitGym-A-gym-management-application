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
    class Expected_Count_Info_Class
    {

        static string myconnstrng = ConfigurationManager.ConnectionStrings["connstrng"].ConnectionString;

        public DataTable Legs_Count(Expected_Count_Info_Class a)

        {
            SqlConnection conn = new SqlConnection(myconnstrng);
            DataTable dt = new DataTable();

            try
            {

                
                //  string sql = "INSERT INTO Exercise_Info(Customer_Name,Address,Phone_No,Email_Id,Gender,Age,Biceps_Size,Calf_Size,Chest_Size,Hip_Size,Weight,Height,Fat_Percent,Package,Personal_Trainer,Time_Preference,BMI) VALUES(@Customer_Name, @Address, @Phone_No, @Email_Id, @Gender, @Age, @Biceps_Size, @Calf_Size, @Chest_Size, @Hip_Size,@Weight,@Height,@Fat_Percent,@Package,@Personal_Trainer,@Time_Preference,@BMI)";
                string sql = " select Daily_Expected_Count  from Exercise_Info where Body_Parts='Legs' ";//  Customer_Name='+ @Customer_Name + ' and Date Between ' +@Last_Report_Date + ' and '+ @Today_Date  )";

                SqlCommand cmd = new SqlCommand(sql, conn);

             
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

        public DataTable Chest_Count(Expected_Count_Info_Class a)
        {
            SqlConnection conn = new SqlConnection(myconnstrng);
            DataTable dt = new DataTable();

            try
            {


                //  string sql = "INSERT INTO Exercise_Info(Customer_Name,Address,Phone_No,Email_Id,Gender,Age,Biceps_Size,Calf_Size,Chest_Size,Hip_Size,Weight,Height,Fat_Percent,Package,Personal_Trainer,Time_Preference,BMI) VALUES(@Customer_Name, @Address, @Phone_No, @Email_Id, @Gender, @Age, @Biceps_Size, @Calf_Size, @Chest_Size, @Hip_Size,@Weight,@Height,@Fat_Percent,@Package,@Personal_Trainer,@Time_Preference,@BMI)";
                string sql = " select Daily_Expected_Count  from Exercise_Info where Body_Parts='Chest' ";//  Customer_Name='+ @Customer_Name + ' and Date Between ' +@Last_Report_Date + ' and '+ @Today_Date  )";

                SqlCommand cmd = new SqlCommand(sql, conn);


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

        public DataTable Shoulder_Count(Expected_Count_Info_Class a)
        {
            SqlConnection conn = new SqlConnection(myconnstrng);
            DataTable dt = new DataTable();

            try
            {


                //  string sql = "INSERT INTO Exercise_Info(Customer_Name,Address,Phone_No,Email_Id,Gender,Age,Biceps_Size,Calf_Size,Chest_Size,Hip_Size,Weight,Height,Fat_Percent,Package,Personal_Trainer,Time_Preference,BMI) VALUES(@Customer_Name, @Address, @Phone_No, @Email_Id, @Gender, @Age, @Biceps_Size, @Calf_Size, @Chest_Size, @Hip_Size,@Weight,@Height,@Fat_Percent,@Package,@Personal_Trainer,@Time_Preference,@BMI)";
                string sql = " select Daily_Expected_Count  from Exercise_Info where Body_Parts='Shoulder' ";//  Customer_Name='+ @Customer_Name + ' and Date Between ' +@Last_Report_Date + ' and '+ @Today_Date  )";

                SqlCommand cmd = new SqlCommand(sql, conn);


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

        public DataTable Triceps_Count(Expected_Count_Info_Class a)
        {
            SqlConnection conn = new SqlConnection(myconnstrng);
            DataTable dt = new DataTable();

            try
            {


                //  string sql = "INSERT INTO Exercise_Info(Customer_Name,Address,Phone_No,Email_Id,Gender,Age,Biceps_Size,Calf_Size,Chest_Size,Hip_Size,Weight,Height,Fat_Percent,Package,Personal_Trainer,Time_Preference,BMI) VALUES(@Customer_Name, @Address, @Phone_No, @Email_Id, @Gender, @Age, @Biceps_Size, @Calf_Size, @Chest_Size, @Hip_Size,@Weight,@Height,@Fat_Percent,@Package,@Personal_Trainer,@Time_Preference,@BMI)";
                string sql = " select Daily_Expected_Count  from Exercise_Info where Body_Parts='Triceps' ";//  Customer_Name='+ @Customer_Name + ' and Date Between ' +@Last_Report_Date + ' and '+ @Today_Date  )";

                SqlCommand cmd = new SqlCommand(sql, conn);


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

        public DataTable Back_Count(Expected_Count_Info_Class a)
        {
            SqlConnection conn = new SqlConnection(myconnstrng);
            DataTable dt = new DataTable();

            try
            {


                //  string sql = "INSERT INTO Exercise_Info(Customer_Name,Address,Phone_No,Email_Id,Gender,Age,Biceps_Size,Calf_Size,Chest_Size,Hip_Size,Weight,Height,Fat_Percent,Package,Personal_Trainer,Time_Preference,BMI) VALUES(@Customer_Name, @Address, @Phone_No, @Email_Id, @Gender, @Age, @Biceps_Size, @Calf_Size, @Chest_Size, @Hip_Size,@Weight,@Height,@Fat_Percent,@Package,@Personal_Trainer,@Time_Preference,@BMI)";
                string sql = " select Daily_Expected_Count  from Exercise_Info where Body_Parts='Back' ";//  Customer_Name='+ @Customer_Name + ' and Date Between ' +@Last_Report_Date + ' and '+ @Today_Date  )";

                SqlCommand cmd = new SqlCommand(sql, conn);


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

        public DataTable Biceps_Count(Expected_Count_Info_Class a)
        {
            SqlConnection conn = new SqlConnection(myconnstrng);
            DataTable dt = new DataTable();

            try
            {


                //  string sql = "INSERT INTO Exercise_Info(Customer_Name,Address,Phone_No,Email_Id,Gender,Age,Biceps_Size,Calf_Size,Chest_Size,Hip_Size,Weight,Height,Fat_Percent,Package,Personal_Trainer,Time_Preference,BMI) VALUES(@Customer_Name, @Address, @Phone_No, @Email_Id, @Gender, @Age, @Biceps_Size, @Calf_Size, @Chest_Size, @Hip_Size,@Weight,@Height,@Fat_Percent,@Package,@Personal_Trainer,@Time_Preference,@BMI)";
                string sql = " select Daily_Expected_Count  from Exercise_Info where Body_Parts='Back' ";//  Customer_Name='+ @Customer_Name + ' and Date Between ' +@Last_Report_Date + ' and '+ @Today_Date  )";

                SqlCommand cmd = new SqlCommand(sql, conn);


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
    }
}
