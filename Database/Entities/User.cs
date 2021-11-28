using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database.Entities
{
    public class User
    {
        public enum UserTypeEnum
        {
            Admin,
            Manager,
            Chef
        }
        public string UserId { get; set; }
        public string Password { get; set; }
        public int UserType { get; set; }

        public User(string userId, string password, int userType)
        {
            UserId = userId;
            Password = password;
            UserType = userType;
        }
    }
}
