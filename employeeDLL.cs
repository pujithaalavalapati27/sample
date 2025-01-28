using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EmpDTO;

namespace EmpDLL
{
    public class employeeDLL
    {
        private string connectionString = "server=10.10.0.56;user=valetuser;password=Password@123;database=DBMani;"; // Use your DB connection string

        public List<employeeDTO> GetAllEmployees()
        {
            var employees = new List<employeeDTO>();

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT ID, Name, Email, Country,ProjectID,ManagerName FROM Employee";
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var employee = new employeeDTO
                            {
                                ID = Convert.ToInt32(reader["ID"]),
                                Name = reader["Name"].ToString(),
                                Email = reader["Email"].ToString(),
                                Country = reader["Country"].ToString(),
                                ProjectID = Convert.ToInt32(reader["ProjectID"]),
                                ManagerName = reader["ManagerName"].ToString(),
                            };
                            employees.Add(employee);
                        }
                    }
                }
            }

            return employees;
        }

        public employeeDTO GetEmployeeById(int id)
        {
            employeeDTO employee = null;

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT ID, Name, Email, Country,ProjectID,ManagerName FROM Employee WHERE ID = @ID";
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@ID", id);
                    MySqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        employee = new employeeDTO
                        {
                            ID = Convert.ToInt32(reader["ID"]),
                            Name = reader["Name"].ToString(),
                            Email = reader["Email"].ToString(),
                            Country = reader["Country"].ToString(),
                            ProjectID = Convert.ToInt32(reader["ProjectID"]),
                            ManagerName = reader["ManagerName"].ToString(),
                        };
                    }
                }
            }

            return employee;
        }

        public bool AddEmployee(employeeDTO employee)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = "INSERT INTO Employee(Name, Email, Country,ProjectID,ManagerName) VALUES (@Name, @Email, @Country,@ProjectID,@ManagerName)";
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Name", employee.Name);
                    cmd.Parameters.AddWithValue("@Email", employee.Email);
                    cmd.Parameters.AddWithValue("@Country", employee.Country);
                    cmd.Parameters.AddWithValue("@ProjectID", employee.ProjectID);
                    cmd.Parameters.AddWithValue("@ManagerName", employee.ManagerName);
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }

        public bool UpdateEmployee(employeeDTO employee)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = "UPDATE Employee SET Name = @Name, Email = @Email,Country=@Country, ManagerName = @ManagerName WHERE ID = @ID";
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@ID", employee.ID);
                    cmd.Parameters.AddWithValue("@Name", employee.Name);
                    cmd.Parameters.AddWithValue("@Email", employee.Email);
                    cmd.Parameters.AddWithValue("@Country", employee.Country);
                   
                    cmd.Parameters.AddWithValue("@ManagerName", employee.ManagerName);

                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }

        public bool DeleteEmployee(int id)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = "DELETE FROM Employee WHERE ID = @ID";
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@ID", id);

                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }
        public List<employeeDTO> GetAllJoinedEmployee()
        {
            var employees = new List<employeeDTO>();

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT e.ID, e.Name, e.Email, e.Country, e.ProjectID, e.ManagerName,d.Employee_Role,d.Employee_Salary FROM Employee e INNER JOIN Employee_Designation d ON e.ID=d.EmployeeID;";
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var employee = new employeeDTO
                            {
                                ID = Convert.ToInt32(reader["ID"]),
                                Name = reader["Name"].ToString(),
                                Email = reader["Email"].ToString(),
                                Country = reader["Country"].ToString(),
                                ProjectID = Convert.ToInt32(reader["ProjectID"]),
                                ManagerName = reader["ManagerName"].ToString(),
                                Employee_Salary= Convert.ToInt32(reader["Employee_Salary"]),
                                Employee_Role = reader["Employee_Role"].ToString(),
                            };
                            employees.Add(employee);
                        }
                    }
                }
            }

            return employees;
        }
    }


}
