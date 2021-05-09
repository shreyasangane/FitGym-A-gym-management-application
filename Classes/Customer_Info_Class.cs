using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FITZONE.Classes
{
    class Customer_Info_Class
    {
        public string Customer_Name { get; set; }
        public string Address { get; set; }
        public string Phone_No { get; set; }
        public string Email_Id { get; set; }
        public string Gender { get; set; }
        public string Age { get; set; }
        public string Biceps_Size { get; set; }
        public string Back_Size { get; set; }
        public string Triceps_Size { get; set; }
        public string Chest_Size { get; set; }
        public string Shoulder_Size { get; set; }
        public string Legs_Size { get; set; }
        public string Weight { get; set; }
        public string Height { get; set; }
        public string Fat_Percent { get; set; }
        public string Package { get; set; }
        public string Personal_Trainer { get; set; }
        public string Time_Preference { get; set; }
        public string BMI { get; set; }
        public string Fees { get; set; }
        public DateTime Joining_Date { get; set; }

        static string myconnstrng = ConfigurationManager.ConnectionStrings["connstrng"].ConnectionString;

        //Inserting Customer Data Into Database
        public bool Insert(Customer_Info_Class c)
        {
            bool isSuccess = true;

            SqlConnection conn = new SqlConnection(myconnstrng);
            try
            {
              //  string sql = "INSERT INTO Customer_Info(Customer_Name,Address,Phone_No,Email_Id,Gender,Age,Biceps_Size,Calf_Size,Chest_Size,Hip_Size,Weight,Height,Fat_Percent,Package,Personal_Trainer,Time_Preference,BMI) VALUES(@Customer_Name, @Address, @Phone_No, @Email_Id, @Gender, @Age, @Biceps_Size, @Calf_Size, @Chest_Size, @Hip_Size,@Weight,@Height,@Fat_Percent,@Package,@Personal_Trainer,@Time_Preference,@BMI)";
                string sql = "INSERT INTO Customer_Info(Customer_Name,Address,Phone_No,Email_Id,Gender,Age,Biceps_Size,Back_Size,Chest_Size,Triceps_Size,Shoulder_Size,Legs_Size,Weight,Height,Fat_Percent,Package,Personal_Trainer,Time_Preference,BMI,Fees,Joining_Date) VALUES(@Customer_Name, @Address, @Phone_No, @Email_Id, @Gender, @Age, @Biceps_Size, @Back_Size, @Chest_Size, @Triceps_Size, @Shoulder_Size, @Legs_Size, @Weight, @Height, @Fat_Percent , @Package, @Personal_Trainer, @Time_Preference, @BMI,@Fees,@Joining_Date)";              
                SqlCommand cmd = new SqlCommand(sql, conn);
                
                cmd.Parameters.AddWithValue("@Customer_Name",c.Customer_Name);
                cmd.Parameters.AddWithValue("@Address",c.Address);
                 cmd.Parameters.AddWithValue("@Phone_No",c.Phone_No);
                   cmd.Parameters.AddWithValue("@Email_Id",c.Email_Id);
                   cmd.Parameters.AddWithValue("@Gender",c.Gender);
                      cmd.Parameters.AddWithValue("@Age",c.Age);
                    cmd.Parameters.AddWithValue("@Biceps_Size",c.Biceps_Size);
                    cmd.Parameters.AddWithValue("@Back_Size",c.Back_Size);
                    cmd.Parameters.AddWithValue("@Chest_Size",c.Chest_Size);
                    cmd.Parameters.AddWithValue("@Triceps_Size",c.Triceps_Size);
                    cmd.Parameters.AddWithValue("@Shoulder_Size", c.Shoulder_Size);
                    cmd.Parameters.AddWithValue("@Legs_Size", c.Legs_Size);
                      cmd.Parameters.AddWithValue("@Weight",c.Weight);
                          cmd.Parameters.AddWithValue("@Height",c.Height);
                          cmd.Parameters.AddWithValue("@Fat_Percent",c.Fat_Percent);
                           cmd.Parameters.AddWithValue("@Package",c.Package);
                         cmd.Parameters.AddWithValue("@Personal_Trainer",c.Personal_Trainer);
                         cmd.Parameters.AddWithValue("@Time_Preference",c.Time_Preference);
                         cmd.Parameters.AddWithValue("@BMI", c.BMI);
                         cmd.Parameters.AddWithValue("@Fees", c.Fees);
                 cmd.Parameters.AddWithValue("@Joining_Date", c.Joining_Date);

                         

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


        public bool Insert2(Customer_Info_Class c)
        {
            bool isSuccess = true;

            SqlConnection conn = new SqlConnection(myconnstrng);
            try
            {
                //  string sql = "INSERT INTO Customer_Info(Customer_Name,Address,Phone_No,Email_Id,Gender,Age,Biceps_Size,Calf_Size,Chest_Size,Hip_Size,Weight,Height,Fat_Percent,Package,Personal_Trainer,Time_Preference,BMI) VALUES(@Customer_Name, @Address, @Phone_No, @Email_Id, @Gender, @Age, @Biceps_Size, @Calf_Size, @Chest_Size, @Hip_Size,@Weight,@Height,@Fat_Percent,@Package,@Personal_Trainer,@Time_Preference,@BMI)";

                string sql = "INSERT INTO Monthly_Report_Info(Customer_Name,Report_Date,BMI,Biceps_Size,Triceps_Size,Chest_Size,Back_Size,Shoulder_Size,Legs_Size,Height,Weight,Fat_Percent) VALUES(@Customer_Name,@Joining_Date,@BMI,@Biceps_Size,@Triceps_Size,@Chest_Size,@Back_Size,@Shoulder_Size,@Legs_Size,@Height,@Weight,@Fat_Percent)";
                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@Customer_Name", c.Customer_Name);
                cmd.Parameters.AddWithValue("@Biceps_Size", c.Biceps_Size);
                cmd.Parameters.AddWithValue("@Back_Size", c.Back_Size);
                cmd.Parameters.AddWithValue("@Chest_Size", c.Chest_Size);
                cmd.Parameters.AddWithValue("@Triceps_Size", c.Triceps_Size);
                cmd.Parameters.AddWithValue("@Shoulder_Size", c.Shoulder_Size);
                cmd.Parameters.AddWithValue("@Legs_Size", c.Legs_Size);
                cmd.Parameters.AddWithValue("@Weight", c.Weight);
                cmd.Parameters.AddWithValue("@Height", c.Height);
                cmd.Parameters.AddWithValue("@Fat_Percent", c.Fat_Percent);
                cmd.Parameters.AddWithValue("@BMI", c.BMI);               
                cmd.Parameters.AddWithValue("@Joining_Date", c.Joining_Date);



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
