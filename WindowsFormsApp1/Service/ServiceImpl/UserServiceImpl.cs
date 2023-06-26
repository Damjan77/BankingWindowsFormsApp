using System;
using System.Data;
using System.Windows.Forms;
using System.Linq;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using WindowsFormsApp1.Models;
using System.Data.Entity;
using System.Runtime.Remoting.Contexts;

namespace WindowsFormsApp1.Service.ServiceImpl
{
    internal class UserServiceImpl : IUserService
    {
        //SqlConnection con = new SqlConnection("data source=(localdb)\\MSSqlLocalDb;initial catalog=BankingDataBase;integrated security=True;MultipleActiveResultSets=True;App=EntityFramework");
        public List<User> GetAllData()
        {
            using (var myDb = new Model1())
            {
                var userProperties = myDb.Users.Select(user => new
                {
                    user.userId,
                    user.name,
                    user.surname,
                    user.isActive,
                    user.username,
                    user.password
                }).ToList();

                List<User> myUsers = userProperties.Select(userProp => new User
                {
                    userId = userProp.userId,
                    name = userProp.name,
                    surname = userProp.surname,
                    isActive = userProp.isActive,
                    username = userProp.username,
                    password = userProp.password
                }).ToList();

                return myUsers;
            }
        }

        //public void GetAllUsers(object sender, EventArgs e)
        //{
        //    GetAllData("Users_GetAll");
        //}

        public void InsertDataInUserTable(object toSave)
        {
            //try
            //{
            //    User usr = toSave as User;
            //    con.Open();
            //    SqlCommand sqlCommand = new SqlCommand("Users_InsertUser", con);
            //    sqlCommand.CommandType = CommandType.StoredProcedure;
            //    sqlCommand.Parameters.AddWithValue("userId", usr.userId);
            //    sqlCommand.Parameters.AddWithValue("name", usr.name);
            //    sqlCommand.Parameters.AddWithValue("surname", usr.surname);
            //    sqlCommand.Parameters.AddWithValue("isActive", usr.isActive);
            //    sqlCommand.Parameters.AddWithValue("username", usr.username);
            //    sqlCommand.Parameters.AddWithValue("password", usr.password);
            //    sqlCommand.ExecuteNonQuery();
            //    MessageBox.Show("Data saved Successfull");
            //    con.Close();
            //}
            //catch (Exception ex)
            //{
            //    throw new Exception(ex.Message);//message box
            //}

            try
            {
                User usr = toSave as User;

                using (var myDb = new Model1())
                {
                    // Create a new User entity
                    User newUser = new User
                    {
                        userId = usr.userId,
                        name = usr.name,
                        surname = usr.surname,
                        isActive = usr.isActive,
                        username = usr.username,
                        password = usr.password
                    };
  
                    // Add the new User entity to the DbContext
                    myDb.Users.Add(newUser); //Prasanje zosto UNIQUE constraint ne go prikazuva ?

                    // Save changes to the database
                    myDb.SaveChanges();
                    MessageBox.Show("Data saved successfully");                 
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Data saved unsuccessfully");
            }
        }

        public void UpdateDataInUserTable(object toSave)
        {
            User usr = toSave as User;

            try
            {
                using (var myDb = new Model1())
                {
                    User existingUser = myDb.Users.Find(usr.userId);

                    if (existingUser != null)
                    {
                        // Update
                        existingUser.name = usr.name;
                        existingUser.surname = usr.surname;
                        existingUser.isActive = usr.isActive;
                        existingUser.username = usr.username;
                        existingUser.password = usr.password;
                   
                        myDb.SaveChanges();
                        MessageBox.Show("Data updated successfully");                     
                    }
                    else
                    {
                        MessageBox.Show("User not found");
                    }
                }
            }
            catch (Exception ex)
            {
                //throw new Exception(ex.Message);
                MessageBox.Show("Data updated unsuccessfully " + ex.Message);
            }
        }

        public string Encrypt(string value)
        {
            using (MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider())
            {
                UTF8Encoding utf8 = new UTF8Encoding();
                byte[] data = md5.ComputeHash(utf8.GetBytes(value));
                return Convert.ToBase64String(data);
            }
        }

        public bool AuthenticateUser(string username, string password)
        {
            using (var myDb = new Model1())
            {
                string encryptedPassword = Encrypt(password);
                var user = myDb.Users.FirstOrDefault(u => u.username == username && u.password == encryptedPassword);
                return user != null;
            }
        }

        public int? getUserId(string username, string password)
        {
            using (var myDb = new Model1())
            {
                string encryptedPassword = Encrypt(password);
                var user = myDb.Users.FirstOrDefault(u => u.username == username && u.password == encryptedPassword);
                return user.userId;
            }
        }

        public List<User> searchUsers(string searchString)
        {
            using (var myDb = new Model1())
            {
                var searchResults = myDb.Users
                .Where(u => u.name.Contains(searchString) || u.surname.Contains(searchString) || u.username.Contains(searchString))
                .ToList();

                List<User> myUsers = searchResults.Select(userProp => new User
                {
                    userId = userProp.userId,
                    name = userProp.name,
                    surname = userProp.surname,
                    isActive = userProp.isActive,
                    username = userProp.username,
                    password = userProp.password
                }).ToList();

                return myUsers;
            }
        }

        //public string Encrypt(string value)
        //{
        //    byte[] data = UTF8Encoding.UTF8.GetBytes(value);
        //    using (MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider())
        //    {
        //        vyte[] keys = md5.ComputeHash(UTF8Encoding.UTF8.GetBytes(hash)); 

        //        UTF8Encoding utf8 = new UTF8Encoding();
        //        byte[] data = md5.ComputeHash(utf8.GetBytes(value));
        //        return Convert.ToBase64String(data);
        //    }
        //}

        //public string Decrypt(string value)
        //{
        //    byte[] data = Convert.FromBase64String(value);

        //    using (MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider())
        //    {
        //        UTF8Encoding utf8 = new UTF8Encoding();
        //        byte[] data = md5.ComputeHash(utf8.GetBytes(value));
        //        return Convert.ToBase64String(data);
        //    }
        //}
    }
}
