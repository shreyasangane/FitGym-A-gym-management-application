using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FITZONE.Classes
{
    class BMI_Exercise_Info_Class
    {
        public string Body_Part1 { get; set; }

        public string Body_Part2 { get; set; }

        public string BMIClass { get; set; }

        public string Day_Name { get; set; }

        static string myconnstrng = ConfigurationManager.ConnectionStrings["connstrng"].ConnectionString;

        public bool Update(BMI_Exercise_Info_Class c)
        {
            bool isSuccess = true;

            SqlConnection conn = new SqlConnection(myconnstrng);
            try
            {
                //  string sql = "INSERT INTO Customer_Info(Customer_Name,Address,Phone_No,Email_Id,Gender,Age,Biceps_Size,Calf_Size,Chest_Size,Hip_Size,Weight,Height,Fat_Percent,Package,Personal_Trainer,Time_Preference,BMI) VALUES(@Customer_Name, @Address, @Phone_No, @Email_Id, @Gender, @Age, @Biceps_Size, @Calf_Size, @Chest_Size, @Hip_Size,@Weight,@Height,@Fat_Percent,@Package,@Personal_Trainer,@Time_Preference,@BMI)";
                string sql = "UPDATE BMI_Exercise_Info SET Body_Part1= @Body_Part1  WHERE BMIClass=@BMIClass and Day_Name=@Day_Name ";
                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@Body_Part1", c.Body_Part1);               
                cmd.Parameters.AddWithValue("@BMIClass", c.BMIClass );
                cmd.Parameters.AddWithValue("@Day_Name", c.Day_Name);

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
