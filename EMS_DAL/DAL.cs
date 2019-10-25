using EMS_DAL.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EMS_DAL
{
    public static class DAL
    { static string connString = ConfigurationManager.ConnectionStrings["SqlConnString"].ToString(); 
        public static bool AddEmployee(Employee employee)
        {
            try
            {
                using (SqlConnection connection=new SqlConnection(connString))
                {
                    var query = $"INSERT INTO Employees(name,salary,commission,dateofjoining,dateofbirth,departmentno,jobtitle,reportingto,email,phone,gender)VALUES('{employee.name}', {employee.salary},{employee.commission},'{employee.dateofjoining.ToString("yyyy-MM-dd")}','{employee.dateofbirth.ToString("yyyy-MM-dd")}',{employee.departmentno},'{employee.jobtitle}', {employee.reportingto}, '{employee.email}',{employee.phone}, '{employee.gender}')";
                    SqlCommand command = new SqlCommand(query, connection);
                    connection.Open();
                    int result=command.ExecuteNonQuery();
                    if (result==1)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            catch (Exception ex)
            {

                return false;

            }
            

        }

        public static bool Login(string username, string password)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connString))
                {
                    var query = $"select Username from Users where username='{username}' and Password='{password}'";
                    SqlCommand command = new SqlCommand(query, connection);
                    DataSet ds = new DataSet();
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    adapter.Fill(ds);
                    if (ds.Tables[0].Rows.Count>0)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                   
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public static bool RegisterUser(string username, string password)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connString))
                {
                    var query = $"INSERT INTO users(Username,Password)VALUES('{username}', '{password}')";
                    SqlCommand command = new SqlCommand(query, connection);
                    connection.Open();
                    int result = command.ExecuteNonQuery();
                    if (result == 1)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            catch (Exception ex)
            {

                return false;

            }
        }

        public static DataSet GetEmployeeByDept(int deptId)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connString))
                {
                    string query = $"select e.Number, e.name,e.dateofbirth,e.dateofjoining,e.email,e.gender,e.salary,e.commission,e.phone,d.name as [Dept Name],e.jobtitle,isnull(m.name, 'No Manager') as [Manager] from Employees e left join Employees m on e.reportingto=m.Number join Departments d on e.departmentno=d.Departmentid where e.departmentno={deptId}";

                    SqlCommand command = new SqlCommand(query, connection);

                    DataSet ds = new DataSet();
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    adapter.Fill(ds);
                    return ds;
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public static bool DeleteEmployee(int empId)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connString))
                {
                    var query = $"delete Employees where Number={empId}";
                    SqlCommand command = new SqlCommand(query, connection);
                    connection.Open();
                    int result = command.ExecuteNonQuery();
                    if (result == 1)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            catch (Exception ex)
            {

                return false;

            }
        }

        public static DataSet GetEmployeeById(int empId)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connString))
                {
                    SqlCommand command = new SqlCommand($"select * from Employees where Number={empId}", connection);

                    DataSet ds = new DataSet();
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    adapter.Fill(ds);
                    return ds;
                }
            }
            catch (Exception ex)
            {
                throw;

            }
        }

        public static DataSet GetEmployeeList()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connString))
                {

                    string query = "select e.Number, e.name,e.dateofbirth,e.dateofjoining,e.email,e.gender,e.salary,e.commission,e.phone,d.name as [Dept Name],e.jobtitle,isnull(m.name, 'No Manager') as [Manager] from Employees e left join Employees m on e.reportingto=m.Number join Departments d on e.departmentno=d.Departmentid";                          
                    SqlCommand command = new SqlCommand(query, connection);
                    DataSet ds = new DataSet();
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    adapter.Fill(ds);
                    return ds;
                }
            }
            catch (Exception ex)
            {
                throw;

            }
        }
        public static DataSet GetDepartments()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connString))
                {
                    SqlCommand command = new SqlCommand("select Departmentid,name from Departments",connection);

                    DataSet ds = new DataSet();
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    adapter.Fill(ds);
                    return ds;
                }
            }
            catch (Exception ex )
            {
                throw;
                
            }

        }

        public static bool UpdateEmployee(Employee employee)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connString))
                {
                    var query = $"UPDATE Employees set name='{employee.name}',salary={employee.salary},commission={employee.commission},dateofjoining='{employee.dateofjoining.ToString("yyyy-MM-dd")}',dateofbirth='{employee.dateofbirth.ToString("yyyy-MM-dd")}',departmentno={employee.departmentno},jobtitle='{employee.jobtitle}',reportingto={employee.reportingto},email='{employee.email}',phone={employee.phone},gender='{employee.gender}' where Number = { employee.Number }";
                    SqlCommand command = new SqlCommand(query, connection);
                    connection.Open();
                    int result = command.ExecuteNonQuery();
                    if (result == 1)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            catch (Exception ex)
            {

                return false;

            }
        }

        public static DataSet GetEmployeeIdAndName()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connString))
                {
                    SqlCommand command = new SqlCommand("select Number,name from Employees", connection);

                    DataSet ds = new DataSet();
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    adapter.Fill(ds);
                    return ds;
                }
            }
            catch (Exception ex)
            {

                throw;
            }
        }
    }
    
}
