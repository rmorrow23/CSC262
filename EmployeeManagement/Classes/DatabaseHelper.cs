using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

namespace EmployeeManagement
{
    public static class DatabaseHelper
    {
        public static readonly string strConnString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFileName=C:\Users\randa\source\repos\CSC262\EmployeeManagement\Employees.mdf;Integrated Security=True;Connect Timeout=30;";

        public static DataTable GetManagers()
        {
            string strQuery = "SELECT * FROM ManagerTable";

            //opens the connection to the database
            using (SqlConnection connection = new SqlConnection(strConnString))
            {
                connection.Open();

                //sets up query with resources automatically managed for us
                using (SqlCommand cmd = new SqlCommand())
                {
                    //data adapter so the data can be used
                    SqlDataAdapter adapter = new SqlDataAdapter(strQuery, strConnString);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    return dataTable;
                }
                connection.Close();
            }
        }

        public static DataTable GetTeamMembers()
        {
            string strQuery = "SELECT * FROM TeamMemberTable";

            //opens the connection to the database
            using (SqlConnection connection = new SqlConnection(strConnString))
            {
                connection.Open();

                //sets up query with resources automatically managed for us
                using (SqlCommand cmd = new SqlCommand())
                {
                    //data adapter so the data can be used
                    SqlDataAdapter adapter = new SqlDataAdapter(strQuery, strConnString);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    return dataTable;
                }
                connection.Close();
            }
        }
        public static DataTable GetUsers()
        {
            string strQuery = "SELECT * FROM UserTable";

            //opens the connection to the database
            using (SqlConnection connection = new SqlConnection(strConnString))
            {
                connection.Open();

                //sets up query with resources automatically managed for us
                using (SqlCommand cmd = new SqlCommand())
                {
                    //data adapter so the data can be used
                    SqlDataAdapter adapter = new SqlDataAdapter(strQuery, strConnString);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    return dataTable;
                }
                connection.Close();
            }
        }
        public static void InsertTeamMembers(string name, string assignedteam, string worklocation, int salary)
        {
            string strQuery = @"INSERT INTO TeamMemberTable 
                                (name,team, location, salary)
                                VALUES (@name, @team, @location, @salary)";

            //opens the connection to the database
            using (SqlConnection connection = new SqlConnection(strConnString))
            {
                

                
                using (SqlCommand cmd = new SqlCommand(strQuery,connection))
                {
                    //commands for adding parameters to the insert query
                    cmd.Parameters.AddWithValue("@name", name);
                    cmd.Parameters.AddWithValue("@team", assignedteam);
                    cmd.Parameters.AddWithValue("@location", worklocation);
                    cmd.Parameters.AddWithValue("@salary", salary);

                    //opens connection to database
                    connection.Open();
                    //inserts new data
                    cmd.ExecuteNonQuery();
                    //closes connection to database
                    connection.Close();
                }
                
            }
        }
        public static void InsertManagers(string name, int salary, int experience, bool bonus)
        {
            string strQuery = @"INSERT INTO ManagerTable 
                                (name, salary, experience, bonus)
                                VALUES (@name, @salary, @experience, @bonus)";

            //opens the connection to the database
            using (SqlConnection connection = new SqlConnection(strConnString))
            {



                using (SqlCommand cmd = new SqlCommand(strQuery, connection))
                {
                    //commands for adding parameters to the insert query
                    cmd.Parameters.AddWithValue("@name", name);
                    cmd.Parameters.AddWithValue("@salary", salary);
                    cmd.Parameters.AddWithValue("@experience", experience);
                    cmd.Parameters.AddWithValue("@bonus", bonus);

                    //opens connection to database
                    connection.Open();
                    //inserts new data
                    cmd.ExecuteNonQuery();
                    //closes connection to database
                    connection.Close();
                }

            }
        }
    }
}
