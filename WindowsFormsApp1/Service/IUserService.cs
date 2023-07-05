using System;
using System.Collections.Generic;
using WindowsFormsApp1.Models;

namespace WindowsFormsApp1.Service
{
    public interface IUserService
    {
        void InsertDataInUserTable(object toSave);
        void UpdateDataInUserTable(object toSave);
        List<User> GetAllData();
        string Encrypt(string value);
        bool AuthenticateUser(string username, string password);
        int? getUserId(string username, string password);

        int gerRoleId(string username, string password);
        List<User> searchUsers(string searchString);
        string findUserRoleName(int id);
    }
}
