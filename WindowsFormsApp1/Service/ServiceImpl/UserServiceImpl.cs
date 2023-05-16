using System;
using System.Data.SqlClient;
using System.Data;

using System.Windows.Forms;

namespace WindowsFormsApp1.Service.ServiceImpl
{
    internal class UserServiceImpl : UserService
    {
        SqlConnection con = new SqlConnection("data source=(localdb)\\MSSqlLocalDb;initial catalog=BankingDataBase;integrated security=True;MultipleActiveResultSets=True;App=EntityFramework");

        public void InsertDataInUserTable(object toSave)
        {
           
            try
            {
                User usr = toSave as User;
                con.Open();
                SqlCommand sqlCommand = new SqlCommand("Users_InsertUser", con);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.AddWithValue("name", usr.name);
                sqlCommand.Parameters.AddWithValue("surname", usr.surname);
                sqlCommand.Parameters.AddWithValue("isActive", usr.isActive);
                sqlCommand.ExecuteNonQuery();
                MessageBox.Show("Data saved Successfull");
                con.Close();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
