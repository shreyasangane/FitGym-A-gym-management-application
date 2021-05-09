using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FITZONE.Classes
{
    class Bodyparts_Info_Class
    {
        public string Body_Parts { get; set; }
        public string OB { get; set; }
        string sql2;
        
        static string myconnstrng = ConfigurationManager.ConnectionStrings["connstrng"].ConnectionString;

        public bool Create(Bodyparts_Info_Class c)
        {
            bool isSuccess = true;

            SqlConnection conn = new SqlConnection(myconnstrng);

            try
            {
                
                //  string sql = "INSERT INTO Exercise_Info(Customer_Name,Address,Phone_No,Email_Id,Gender,Age,Biceps_Size,Calf_Size,Chest_Size,Hip_Size,Weight,Height,Fat_Percent,Package,Personal_Trainer,Time_Preference,BMI) VALUES(@Customer_Name, @Address, @Phone_No, @Email_Id, @Gender, @Age, @Biceps_Size, @Calf_Size, @Chest_Size, @Hip_Size,@Weight,@Height,@Fat_Percent,@Package,@Personal_Trainer,@Time_Preference,@BMI)";

                if (c.Body_Parts == "Back")
                {
                     sql2 = "CREATE TABLE Back_Exercise_Info (Customer_Name varchar(50),Day varchar(10),Date varchar(20))";
                }

                if (c.Body_Parts == "Legs")
                {
                     sql2 = "CREATE TABLE Legs_Exercise_Info (Customer_Name varchar(50),Day varchar(10),Date varchar(20))";
                }

                SqlCommand cmd2 = new SqlCommand(sql2, conn);



                cmd2.Parameters.AddWithValue("@Body_Parts", c.Body_Parts);



                conn.Open();

                int rows2 = cmd2.ExecuteNonQuery();



                if (rows2 > 0)
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


        public bool Insert(Bodyparts_Info_Class c)
        {
            bool isSuccess = true;

            SqlConnection conn = new SqlConnection(myconnstrng);
            try
            {
                //  string sql = "INSERT INTO Customer_Info(Customer_Name,Address,Phone_No,Email_Id,Gender,Age,Biceps_Size,Calf_Size,Chest_Size,Hip_Size,Weight,Height,Fat_Percent,Package,Personal_Trainer,Time_Preference,BMI) VALUES(@Customer_Name, @Address, @Phone_No, @Email_Id, @Gender, @Age, @Biceps_Size, @Calf_Size, @Chest_Size, @Hip_Size,@Weight,@Height,@Fat_Percent,@Package,@Personal_Trainer,@Time_Preference,@BMI)";
                string sql = "INSERT INTO Bodyparts_Info(Body_Parts) VALUES(@Body_Parts)";
                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@Body_Parts", c.Body_Parts);
     


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

        public bool Update(Bodyparts_Info_Class c)
        {
            bool isSuccess = true;

            SqlConnection conn = new SqlConnection(myconnstrng);
            try
            {
                //  string sql = "INSERT INTO Customer_Info(Customer_Name,Address,Phone_No,Email_Id,Gender,Age,Biceps_Size,Calf_Size,Chest_Size,Hip_Size,Weight,Height,Fat_Percent,Package,Personal_Trainer,Time_Preference,BMI) VALUES(@Customer_Name, @Address, @Phone_No, @Email_Id, @Gender, @Age, @Biceps_Size, @Calf_Size, @Chest_Size, @Hip_Size,@Weight,@Height,@Fat_Percent,@Package,@Personal_Trainer,@Time_Preference,@BMI)";
                string sql = "UPDATE Bodyparts_Info SET Body_Parts= @Body_Parts WHERE Body_Parts=@OB ";
                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@Body_Parts", c.Body_Parts);
                cmd.Parameters.AddWithValue("@OB", c.OB);

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

        public bool Delete(Bodyparts_Info_Class d)
        {
            bool isSuccess = false;

            SqlConnection conn = new SqlConnection(myconnstrng);

            try
            {
                string sql = "DELETE FROM Bodyparts_Info WHERE Body_Parts=@Body_Parts";

                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@Body_Parts", d.Body_Parts);

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
        public bool TableDelete(Bodyparts_Info_Class d)
        {
            bool isSuccess = false;

            SqlConnection conn = new SqlConnection(myconnstrng);

            try
            {
                if (d.Body_Parts == "Back")
                {
                    sql2 = "DROP TABLE  Back_Exercise_Info";
                    
                }
                

                SqlCommand cmd = new SqlCommand(sql2, conn);
                

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
