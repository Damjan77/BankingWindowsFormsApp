﻿using System;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
using System.Linq;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;
using System.Data.Entity;

namespace WindowsFormsApp1.Service.ServiceImpl
{
    internal class UserServiceImpl : IUserService
    {
        SqlConnection con = new SqlConnection("data source=(localdb)\\MSSqlLocalDb;initial catalog=BankingDataBase;integrated security=True;MultipleActiveResultSets=True;App=EntityFramework");
        
        public List<User> GetAllData(string procedure)
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
            try
            {
                User usr = toSave as User;
                con.Open();
                SqlCommand sqlCommand = new SqlCommand("Users_InsertUser", con);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.AddWithValue("userId", usr.userId);
                sqlCommand.Parameters.AddWithValue("name", usr.name);
                sqlCommand.Parameters.AddWithValue("surname", usr.surname);
                sqlCommand.Parameters.AddWithValue("isActive", usr.isActive);
                sqlCommand.Parameters.AddWithValue("username", usr.username);
                sqlCommand.Parameters.AddWithValue("password", usr.password);
                sqlCommand.ExecuteNonQuery();
                MessageBox.Show("Data saved Successfull");
                con.Close();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
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