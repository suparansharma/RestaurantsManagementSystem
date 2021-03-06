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

        public Employee GetAllEmployeeByUserId(string userId)
        {
            string query = "Select  * FROM tblEmployees where userId = '" + userId + "' ";
            SqlCommand commandd = GetCommand(query);
            DataTable dt = Execute(commandd);
            if (dt.Rows.Count > 0)
            {
                var fname = dt.Rows[0].Field<string>("firstName");
                var lastName = dt.Rows[0].Field<string>("lastName");
                var gender = dt.Rows[0].Field<string>("gender");
                var phoneNumber = dt.Rows[0].Field<string>("phoneNumber");
                var email = dt.Rows[0].Field<string>("email");
                var joinDate = dt.Rows[0].Field<string>("joinDate");
                var salary = dt.Rows[0].Field<int>("salary");
                var userType = dt.Rows[0].Field<int>("userType");
                var timeShedule = dt.Rows[0].Field<string>("timeShedule");

                Employee employee = new Employee(userId, fname, lastName, gender, phoneNumber, email, joinDate, salary, userType, timeShedule);
                return employee;
            }
            else
            {
                return null;
            }
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
        //public int GetFoodPrice(string foodName, string size)
        //{
        //    string query = "Select price FROM TblFood where  foodName = '"+foodName+"' and Size = '"+size+"' ";
        //    SqlCommand commandd = GetCommand(query);
        //    SqlDataAdapter sda = new SqlDataAdapter(query, commandd.Connection);

        //    DataTable dt = new DataTable();
        //    if (dt.Rows.Count > 0)
        //    {
        //        var price = dt.Rows[0].Field<int>("Price");
        //        return price;
        //    }
        //    else
        //    {
        //        return -1;
        //    }

        //}
        public Food GetFoodById(int foodId)
        {
            string query = "Select * FROM TblFood where Id  = '" + foodId + "' ";
            SqlCommand command = GetCommand(query);

            DataTable dt = Execute(command);
            if (dt.Rows.Count > 0)
            {
                var foodName = dt.Rows[0].Field<string>("foodName");
                var size = dt.Rows[0].Field<string>("Size");
                var price = dt.Rows[0].Field<int>("Price");
                var foodType = dt.Rows[0].Field<string>("foodType");
                var description = dt.Rows[0].Field<string>("description");
                Food food = new Food(foodId, foodName, size, price, foodType, description);
                return food;
            }
            else
            {
                return null;
            }

        }
        public void GetFoodCombo(ComboBox comboBox, string foodType)
        {
            DataRow dr;
            string sql = "select * from TblFood where foodType = '"+ foodType +"' ";
            SqlCommand command = GetCommand(sql);
            SqlDataAdapter sda = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dr = dt.NewRow();
            dr.ItemArray = new Object[] { 0, "--Select Food Name--" };
            dt.Rows.InsertAt(dr, 0);
            comboBox.ValueMember = "id";
            comboBox.DisplayMember = "foodName";
            comboBox.DataSource = dt;
        }
        public bool InsertOrrder(string details, int total)
        {
            string sql = string.Format("insert into tblOrder (details,totalPrice,dateTime)" +
                "Values('{0}', '{1}', '{2}')", details, total, DateTime.Now.ToString());
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


        public void GetAllOrder(DataGridView dataGridView)
        {
            string query = "Select  * FROM tblOrder  ";
            SqlCommand commandd = GetCommand(query);
            SqlDataAdapter sda = new SqlDataAdapter(query, commandd.Connection);

            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView.DataSource = dt;
        }
    }
}
