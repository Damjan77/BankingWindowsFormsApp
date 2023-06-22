using System;
using System.Collections.Generic;

namespace WindowsFormsApp1.Service
{
    public interface IUserService
    {
        void InsertDataInUserTable(object toSave);
        void UpdateDataInUserTable(object toSave);
        List<User> GetAllData(string procedure);
        string Encrypt(string value);
        bool AuthenticateUser(string username, string password);
        int? getUserId(string username, string password);

    }
}
