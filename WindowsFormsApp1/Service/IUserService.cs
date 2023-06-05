using System;
using System.Collections.Generic;

namespace WindowsFormsApp1.Service
{
    internal interface IUserService
    {
        void InsertDataInUserTable(object toSave);
        //void GetAllUsers(object sender, EventArgs e);
        List<User> GetAllData(string procedure);
        string Encrypt(string value);
        bool AuthenticateUser(string username, string password);
    }
}
