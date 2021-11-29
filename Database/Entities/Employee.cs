using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database.Entities
{
    public class Employee
    {
        public string UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Gender { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string JoinDate { get; set; }
        public int Salary { get; set; }
        public int UserType { get; set; }
        public string TimeShedule { get; set; }

        public Employee(string userId, string firstName, string lastName, string gender, string phoneNumber, string email, string joinDate, int salary, int userType, string timeShedule)
        {
            UserId = userId;
            FirstName = firstName;
            LastName = lastName;
            Gender = gender;
            PhoneNumber = phoneNumber;
            Email = email;
            JoinDate = joinDate;
            Salary = salary;
            UserType = userType;
            TimeShedule = timeShedule;
        }
    }
}
