using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wpfmysql
{
    internal class EmployeeService
    {
        MySqlConnection connection;
        public EmployeeService() 
        {
            MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder();
            builder.Server = "localhost";
            builder.Port = 3306;
            builder.UserID = "root";
            builder.Password = "";
            builder.Database = "dolgozok";

            connection = new MySqlConnection(builder.ConnectionString);
        }

        //CRUD

        public bool Create()
        {
            throw new NotImplementedException();
        }

        public List<Employee> GetAll()
        {
            List<Employee> employees = new List<Employee>();
            OpenConnection();
            string sql = "SELECT * FROM dolgozok";
            MySqlCommand command = connection.CreateCommand();
            command.CommandText = sql;
            using (MySqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read()) 
                {
                    Employee employee = new Employee();
                    employee.Id = reader.GetInt32("id");
                    employee.Name = reader.GetString("nev");
                    employee.Gender = reader.GetString("nem");
                    employee.Age = reader.GetInt32("kor");
                    employee.Salary = reader.GetInt32("fizetes");
                    employees.Add(employee);
                }
            }
                CloseConnection();
            return employees;
        }


		public bool Update() 
        {
            throw new NotImplementedException(); 
        }

        public bool Delete()
        {
            throw new NotImplementedException();
        }

        public void OpenConnection()
        {
            if (connection.State != System.Data.ConnectionState.Open)
            {
                connection.Open();
            }
        }
        public void CloseConnection()
        {
            throw new NotImplementedException();
        }
    }
}
