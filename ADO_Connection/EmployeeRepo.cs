using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace ADO_Connection
{
    internal class EmployeeRepo
    {
        /// <summary>
        /// given connection from the SQL localServer
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            
            string ConnectionString = @" Data Source=DESKTOP-LM9061V;Initial Catalog=PayRollService;Integrated Security=True;";
            SqlConnection connection = new SqlConnection(ConnectionString);
            var sql = "select * from EmployeePayRoll";
           
            SqlCommand command = new SqlCommand(sql, connection);
            command.CommandType = System.Data.CommandType.Text;
            connection.Open();
            var reader = command.ExecuteReader();
            List<EmployeeModel> employee = new List<EmployeeModel>();
            while (reader.Read())
            {
                var iid = reader["ID"].ToString();
                var id = reader.GetInt32(0);
                var name = reader.GetString(1);
                var salary = reader.GetInt32(2);
                var StartDate = reader.GetDateTime(3);
                employee.Add(new EmployeeModel
                {
                    EmployeeID = id,
                    EmployeeName=name,
                    Salary=salary,
                    StartDate=StartDate

                });
            }
            reader.Close();
        }
    }
}
