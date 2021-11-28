using Database.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database
{
    public class DataAccess
    {
        string ConnectionString;

        public DataAccess()
        {
            ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Restaurants_Management_System\RestaurantsManagementSystem\Database\rms.mdf;Integrated Security=True;Connect Timeout=30";
        }

        public SqlCommand GetCommand(string sqlQuery)
        {
            SqlConnection conn = new SqlConnection(ConnectionString);
            SqlCommand sqlCmd = new SqlCommand(sqlQuery, conn);
            return sqlCmd;

        }
        public DataTable Execute(string sql)
        {
            SqlCommand cmd = GetCommand(sql);
            DataTable dt = Execute(cmd);
            return dt;
        }
        public DataTable Execute(SqlCommand command)
        {
            DataTable dt = new DataTable();
            command.Connection.Open();
            dt.Load(command.ExecuteReader());
            command.Connection.Close();
            return dt;
        }

        private int ExecuteComand(string sql)
        {
            SqlCommand command = GetCommand(sql);
            command.Connection.Open();
            int rowsAffected = command.ExecuteNonQuery();
            return rowsAffected;
        }

        public User LoginAccess(string userId, string password)
        {
            string sql = "select * " +
               " from [dbo].[tblUsers] where userId='" + userId
               + "' and password='" + password + "'";
            SqlCommand command = GetCommand(sql);

            DataTable dt = Execute(command);
            if (dt.Rows.Count > 0)
            {
                var users = dt.Rows[0].Field<string>("userId");
                var pass = dt.Rows[0].Field<string>("password");
                var userType = dt.Rows[0].Field<int>("userType");
                User user = new User(users, pass, userType);
                return user;
            }
            else
            {
                return null;
            }

        }

        public bool InsertUser(string userId, string password, int userType)
        {
            string sql = string.Format("insert into tblUsers(userId,password,userType)" +
                "Values('{0}', '{1}', '{2}')", userId, password, userType);
            int rowsAffected = ExecuteComand(sql);
            if (rowsAffected > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }



        public bool InsertEmployee(string userId, string firstName, string lastName, string gender, string phoneNumber, string email, string joinDate, int salary, int userType, string timeShedule)
        {
            string sql = string.Format("insert into tblEmployees(userId,firstName,lastName,gender,phoneNumber,email,joinDate,salary,userType,timeShedule)" +
                "Values('{0}', '{1}', '{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}')", userId, firstName, lastName, gender, phoneNumber, email, joinDate, salary, userType, timeShedule);
            int rowsAffected = ExecuteComand(sql);
            if (rowsAffected > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


    }
}
