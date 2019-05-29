using DataLibrary.DBAccess;
using DataLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLibrary.Logic
{
    public static class UserDB
    {
        public static void createUser(int age, string name, string surname, string email, string password)
        {
            UsersModel user = new UsersModel
            {
                age = age,
                name = name,
                surname = surname,
                email = email,
                password = password
            };

            string sql = @"INSERT INTO dbo.Users (age, name, surname, email, password)
                        VALUES(@age, @name, @surname, @email, @password)";

            SqlWorkFlow.saveData(sql, user);
        }
        public static List<UsersModel> loadUsers()
        {
            string sql = @"SELECT * FROM dbo.Users";
            return SqlWorkFlow.loadData<UsersModel>(sql);
        }
    }
}
