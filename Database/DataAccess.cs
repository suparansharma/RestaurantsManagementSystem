using Database.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
        public bool DeleteUser(string userId)
        {
            string query = "DELETE FROM tblUsers  where userId ='" + userId + "' ";
            int rowsAffected = ExecuteComand(query);
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


        public void GetAllEmployee(DataGridView dataGridView)
        {
            string query = "Select  * FROM tblEmployees  ";
            SqlCommand commandd = GetCommand(query);
            SqlDataAdapter sda = new SqlDataAdapter(query, commandd.Connection);

            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView.DataSource = dt;
        }
        public bool UpdateEmploye(string userId, string firstName, string lastName, string gender, string phoneNumber, string email,int salary)
        {
            string query = "UPDATE tblEmployees SET firstName= '" + firstName + "', lastName= '" + lastName + "', gender= '" + gender + "',phoneNumber= '" + phoneNumber + "', email= '" + email + "',salary= '" + salary + "' WHERE userId ='" + userId + "' ";
            int rowsAffected = ExecuteComand(query);
            if (rowsAffected > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool DeleteEmployee(string userId)
        {
            string query = "DELETE FROM tblEmployees  WHERE userId ='" + userId + "' ";
            int rowsAffected = ExecuteComand(query);
            if (rowsAffected > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public void GetAllEmployeeByUserType(DataGridView dataGridView, int userType)
        {
            string query = "Select  * FROM tblEmployees where userType = '"+ userType+ "' ";
            SqlCommand commandd = GetCommand(query);
            SqlDataAdapter sda = new SqlDataAdapter(query, commandd.Connection);

            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView.DataSource = dt;
        }


        public bool InsertFood(string foodName, string size, int price,string foodType, string description)
        {
            string sql = string.Format("insert into tblFood(foodName,size,price,foodType,description)" +
                "Values('{0}', '{1}', '{2}','{3}','{4}')", foodName, size, price, foodType, description);
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


        public bool UpdateFood(int id, string foodName, string Size, int Price, string foodType, string description)
        {
            string query = "UPDATE TblFood SET  foodName= '" + foodName + "', Size= '" + Size + "', price= '" + Price + "',foodType= '" + foodType + "', description= '" + description + "' WHERE id ='" + id + "' ";
            int rowsAffected = ExecuteComand(query);
            if (rowsAffected > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }



        public void GetAllFood(DataGridView dataGridView)
        {
            string query = "Select  * FROM TblFood  ";
            SqlCommand commandd = GetCommand(query);
            SqlDataAdapter sda = new SqlDataAdapter(query, commandd.Connection);

            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView.DataSource = dt;
        }


        public bool DeleteFood(int id)
        {
            string query = "DELETE FROM TblFood  WHERE id ='" + id + "' ";
            int rowsAffected = ExecuteComand(query);
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
