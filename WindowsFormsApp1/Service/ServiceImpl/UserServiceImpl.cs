using System;
using System.Data;
using System.Windows.Forms;
using System.Linq;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;
using WindowsFormsApp1.Models;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace WindowsFormsApp1.Service.ServiceImpl
{
    internal class UserServiceImpl : IUserService
    {
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
                    user.password,
                    user.roleId
                }).ToList();

                List<User> myUsers = userProperties.Select(userProp => new User
                {
                    userId = userProp.userId,
                    name = userProp.name,
                    surname = userProp.surname,
                    isActive = userProp.isActive,
                    username = userProp.username,
                    password = userProp.password,
                    roleId = userProp.roleId
                    
                }).ToList();

                return myUsers;
            }
        }

        public void InsertDataInUserTable(object toSave)
        {
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
                        password = usr.password,
                        roleId = usr.roleId
                    };
  
                    // Add the new User entity to the DbContext
                    myDb.Users.Add(newUser);

                    // Save changes to the database
                    myDb.SaveChanges();
                    MessageBox.Show("Data saved successfully");                 
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Data saved unsuccessfully. " + ex.Message);
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
                        if (UserSession.roleid == 2) //Admin
                        {
                            // Update
                            existingUser.name = usr.name;
                            existingUser.surname = usr.surname;
                            existingUser.isActive = usr.isActive;
                            existingUser.username = usr.username;
                            existingUser.password = usr.password;
                            existingUser.roleId = usr.roleId;

                            myDb.SaveChanges();
                            MessageBox.Show("Data updated successfully");
                        }
                        else if (UserSession.roleid == 1 && UserSession.UserId == existingUser.userId) //Basic
                        {
                            // Update
                            existingUser.name = usr.name;
                            existingUser.surname = usr.surname;
                            existingUser.isActive = usr.isActive;
                            existingUser.username = usr.username;
                            existingUser.password = usr.password;
                            existingUser.roleId = existingUser.roleId; //Basic User can't update role to himself

                            myDb.SaveChanges();
                            MessageBox.Show("Data updated successfully");
                        }
                        else
                        {
                            MessageBox.Show("You don't have permission for this action!");
                        }                                        
                    }
                    else
                    {
                        MessageBox.Show("User not found");
                    }
                }
            }
            catch (Exception ex)
            {
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

        public int gerRoleId(string username, string password)
        {
            using (var myDb = new Model1())
            {
                string encryptedPassword = Encrypt(password);
                var user = myDb.Users.FirstOrDefault(u => u.username == username && u.password == encryptedPassword);
                return user.roleId;
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
                    password = userProp.password,
                    roleId = userProp.roleId
                }).ToList();

                return myUsers;
            }
        }

        public string findUserRoleName(int id)
        {
            using (var context = new Model1())
            {
                var role = context.UserRoles.FirstOrDefault(r => r.roleId == id);
                return role.roleName;
            }
        }
    }
}
