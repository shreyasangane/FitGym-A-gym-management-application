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
    class Exercise_Info_Class
    {
        public string Body_Parts { get; set; }
        public string Exercise { get; set; }
        public string UPDExercise { get; set; }
        public string Daily_Expected_Count { get; set; }
        public string UPDDaily_Expected_Count { get; set; }
        
        static string myconnstrng = ConfigurationManager.ConnectionStrings["connstrng"].ConnectionString;
        string sql2;
        SqlCommand cmd2;

        public DataTable Select(Exercise_Info_Class d)
        {
            SqlConnection conn = new SqlConnection(myconnstrng);
            DataTable dt = new DataTable();
            
             try
            {
                //  string sql = "INSERT INTO Exercise_Info(Customer_Name,Address,Phone_No,Email_Id,Gender,Age,Biceps_Size,Calf_Size,Chest_Size,Hip_Size,Weight,Height,Fat_Percent,Package,Personal_Trainer,Time_Preference,BMI) VALUES(@Customer_Name, @Address, @Phone_No, @Email_Id, @Gender, @Age, @Biceps_Size, @Calf_Size, @Chest_Size, @Hip_Size,@Weight,@Height,@Fat_Percent,@Package,@Personal_Trainer,@Time_Preference,@BMI)";
                string sql = "Select Exercise , Daily_Expected_Count FROM Exercise_Info WHERE Body_Parts= @Body_Parts "; 
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

        public bool Insert(Exercise_Info_Class c)
        {
            bool isSuccess = true;

            SqlConnection conn = new SqlConnection(myconnstrng);
            try
            {
                
               

                //  string sql = "INSERT INTO Exercise_Info(Customer_Name,Address,Phone_No,Email_Id,Gender,Age,Biceps_Size,Calf_Size,Chest_Size,Hip_Size,Weight,Height,Fat_Percent,Package,Personal_Trainer,Time_Preference,BMI) VALUES(@Customer_Name, @Address, @Phone_No, @Email_Id, @Gender, @Age, @Biceps_Size, @Calf_Size, @Chest_Size, @Hip_Size,@Weight,@Height,@Fat_Percent,@Package,@Personal_Trainer,@Time_Preference,@BMI)";
                string sql = "INSERT INTO Exercise_Info(Body_Parts,Exercise,Daily_Expected_Count) VALUES(@Body_Parts , @Exercise, @Daily_Expected_Count)";

               
                SqlCommand cmd = new SqlCommand(sql, conn);
               

                cmd.Parameters.AddWithValue("@Body_Parts", c.Body_Parts);
                cmd.Parameters.AddWithValue("@Exercise", c.Exercise);
                cmd.Parameters.AddWithValue("@Daily_Expected_Count", c.Daily_Expected_Count);

               //---------------------------------------------------------

             
                if (c.Body_Parts.ToLower() == "shoulder")
                {
                   // sql2 = " 'ALTER TABLE Shoulder_Info ADD '+' @Exercise'+' VARCHAR(4)'";
                    sql2 = "EXEC ('ALTER TABLE Shoulder_Info ADD ' + @Exercise + ' NUMERIC(18,0) NULL ')";
                    cmd2 = new SqlCommand(sql2, conn);
                    cmd2.Parameters.AddWithValue("@Exercise", c.Exercise);
                }
                if (c.Body_Parts.ToLower() == "chest")
                {
                    // sql2 = " 'ALTER TABLE Shoulder_Info ADD '+' @Exercise'+' VARCHAR(4)'";
                    sql2 = "EXEC ('ALTER TABLE Chest_Info ADD ' + @Exercise + ' NUMERIC(18,0) NULL ')";
                    cmd2 = new SqlCommand(sql2, conn);
                    cmd2.Parameters.AddWithValue("@Exercise", c.Exercise);
                }
                if (c.Body_Parts.ToLower() == "back")
                {
                    // sql2 = " 'ALTER TABLE Shoulder_Info ADD '+' @Exercise'+' VARCHAR(4)'";
                    sql2 = "EXEC ('ALTER TABLE Back_Info ADD ' + @Exercise + ' NUMERIC(18,0) NULL ')";
                    cmd2 = new SqlCommand(sql2, conn);
                    cmd2.Parameters.AddWithValue("@Exercise", c.Exercise);
                }

                if (c.Body_Parts.ToLower() == "biceps")
                {
                    // sql2 = " 'ALTER TABLE Shoulder_Info ADD '+' @Exercise'+' VARCHAR(4)'";
                    sql2 = "EXEC ('ALTER TABLE Biceps_Info ADD ' + @Exercise + ' NUMERIC(18,0) NULL ')";
                    cmd2 = new SqlCommand(sql2, conn);
                    cmd2.Parameters.AddWithValue("@Exercise", c.Exercise);
                }
                if (c.Body_Parts.ToLower() == "triceps")
                {
                    // sql2 = " 'ALTER TABLE Shoulder_Info ADD '+' @Exercise'+' VARCHAR(4)'";
                    sql2 = "EXEC ('ALTER TABLE Triceps_Info ADD ' + @Exercise + ' NUMERIC(18,0) NULL ')";
                    cmd2 = new SqlCommand(sql2, conn);
                    cmd2.Parameters.AddWithValue("@Exercise", c.Exercise);
                }
                if (c.Body_Parts.ToLower() == "legs")
                {
                    // sql2 = " 'ALTER TABLE Shoulder_Info ADD '+' @Exercise'+' VARCHAR(4)'";
                    sql2 = "EXEC ('ALTER TABLE Cardio_Legs_Info ADD ' + @Exercise + ' NUMERIC(18,0) NULL ')";
                    cmd2 = new SqlCommand(sql2, conn);
                    cmd2.Parameters.AddWithValue("@Exercise", c.Exercise);
                }
               
                

                //--------------------------------------------------------

                conn.Open();
                int rows = cmd.ExecuteNonQuery();
                cmd2.ExecuteNonQuery();
                                                            
               
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
      
        public bool Update(Exercise_Info_Class  c)
        {
            bool isSuccess = true;

            SqlConnection conn = new SqlConnection(myconnstrng);
            try
            {
                //  string sql = "INSERT INTO Customer_Info(Customer_Name,Address,Phone_No,Email_Id,Gender,Age,Biceps_Size,Calf_Size,Chest_Size,Hip_Size,Weight,Height,Fat_Percent,Package,Personal_Trainer,Time_Preference,BMI) VALUES(@Customer_Name, @Address, @Phone_No, @Email_Id, @Gender, @Age, @Biceps_Size, @Calf_Size, @Chest_Size, @Hip_Size,@Weight,@Height,@Fat_Percent,@Package,@Personal_Trainer,@Time_Preference,@BMI)";
                string sql = "UPDATE Exercise_Info SET  Daily_Expected_Count=@Daily_Expected_Count  WHERE Exercise=@UPDExercise ";
                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@Exercise", c.Exercise);
                cmd.Parameters.AddWithValue("@UPDExercise", c.UPDExercise);
                cmd.Parameters.AddWithValue("@Daily_Expected_Count", c.Daily_Expected_Count);

                //----------------------------------------------------------------------------

                
                
                conn.Open();
                Console.WriteLine(sql);
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

        public bool Delete(Exercise_Info_Class c)
        {
            bool isSuccess = false;

            SqlConnection conn = new SqlConnection(myconnstrng);

            try
            {
               

                if (c.Body_Parts.ToLower() == "shoulder")
                {
                    // sql2 = " 'ALTER TABLE Shoulder_Info ADD '+' @Exercise'+' VARCHAR(4)'";
                    sql2 = "EXEC ('ALTER TABLE Shoulder_Info DROP COLUMN ' + @Exercise )";
                    cmd2 = new SqlCommand(sql2, conn);
                    cmd2.Parameters.AddWithValue("@Exercise", c.Exercise);
                }
                if (c.Body_Parts.ToLower() == "chest")
                {
                    // sql2 = " 'ALTER TABLE Shoulder_Info ADD '+' @Exercise'+' VARCHAR(4)'";
                    sql2 = "EXEC ('ALTER TABLE Chest_Info DROP COLUMN ' + @Exercise )";
                    cmd2 = new SqlCommand(sql2, conn);
                    cmd2.Parameters.AddWithValue("@Exercise", c.Exercise);
                }
                if (c.Body_Parts.ToLower() == "biceps")
                {
                    // sql2 = " 'ALTER TABLE Shoulder_Info ADD '+' @Exercise'+' VARCHAR(4)'";
                    sql2 = "EXEC ('ALTER TABLE Biceps_Info DROP COLUMN ' + @Exercise )";
                    cmd2 = new SqlCommand(sql2, conn);
                    cmd2.Parameters.AddWithValue("@Exercise", c.Exercise);
                }
                if (c.Body_Parts.ToLower() == "triceps")
                {
                    // sql2 = " 'ALTER TABLE Shoulder_Info ADD '+' @Exercise'+' VARCHAR(4)'";
                    sql2 = "EXEC ('ALTER TABLE Triceps_Info DROP COLUMN ' + @Exercise )";
                    cmd2 = new SqlCommand(sql2, conn);
                    cmd2.Parameters.AddWithValue("@Exercise", c.Exercise);
                }
                if (c.Body_Parts.ToLower() == "back")
                {
                    // sql2 = " 'ALTER TABLE Shoulder_Info ADD '+' @Exercise'+' VARCHAR(4)'";
                    sql2 = "EXEC ('ALTER TABLE Back_Info DROP COLUMN ' + @Exercise )";
                    cmd2 = new SqlCommand(sql2, conn);
                    cmd2.Parameters.AddWithValue("@Exercise", c.Exercise);
                }
                if (c.Body_Parts.ToLower() == "legs")
                {
                    // sql2 = " 'ALTER TABLE Shoulder_Info ADD '+' @Exercise'+' VARCHAR(4)'";
                    sql2 = "EXEC ('ALTER TABLE Cardio_Legs_Info DROP COLUMN ' + @Exercise )";
                    cmd2 = new SqlCommand(sql2, conn);
                    cmd2.Parameters.AddWithValue("@Exercise", c.Exercise);
                }
              
                string sql = "DELETE FROM Exercise_Info WHERE Exercise=@Exercise";

                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@Exercise", c.Exercise);

                conn.Open();
                int rows = cmd.ExecuteNonQuery();
                cmd2.ExecuteNonQuery();

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
