using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FITZONE.Classes
{
    class Employee_Info_Class
    {
        public string Employee_Name { get; set; }
        public string Address { get; set; }
        public string Phone_No { get; set; }
        public string Email_Id { get; set; }
        public string Salary { get; set; }
        public string Shift_Time { get; set; }
        public string Gender { get; set; }
        public string Age { get; set; }
       

        static string myconnstrng = ConfigurationManager.ConnectionStrings["connstrng"].ConnectionString;

        //Inserting Customer Data Into Database
        public bool Insert(Employee_Info_Class c)
        {
            bool isSuccess = true;

            SqlConnection conn = new SqlConnection(myconnstrng);
            try
            {
                //  string sql = "INSERT INTO Customer_Info(Customer_Name,Address,Phone_No,Email_Id,Gender,Age,Biceps_Size,Calf_Size,Chest_Size,Hip_Size,Weight,Height,Fat_Percent,Package,Personal_Trainer,Time_Preference,BMI) VALUES(@Customer_Name, @Address, @Phone_No, @Email_Id, @Gender, @Age, @Biceps_Size, @Calf_Size, @Chest_Size, @Hip_Size,@Weight,@Height,@Fat_Percent,@Package,@Personal_Trainer,@Time_Preference,@BMI)";
                string sql = "INSERT INTO Employee_Info(Employee_Name,Address,Phone_No,Email_Id,Salary,Shift_Time,Gender,Age) VALUES(@Employee_Name, @Address, @Phone_No, @Email_Id, @Salary, @Shift_Time, @Gender, @Age)";
                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@Employee_Name", c.Employee_Name);
                cmd.Parameters.AddWithValue("@Address", c.Address);
                cmd.Parameters.AddWithValue("@Phone_No", c.Phone_No);
                cmd.Parameters.AddWithValue("@Email_Id", c.Email_Id);
                cmd.Parameters.AddWithValue("@Salary",c.Salary);
                cmd.Parameters.AddWithValue("@Shift_Time", c.Shift_Time);
                cmd.Parameters.AddWithValue("@Gender", c.Gender);
                cmd.Parameters.AddWithValue("@Age", c.Age);                

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
