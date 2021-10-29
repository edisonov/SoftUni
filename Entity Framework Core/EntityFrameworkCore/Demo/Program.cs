using System;
using Microsoft.Data.SqlClient;

namespace Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            var connection = new SqlConnection("");
            connection.Open();
            var query = new SqlCommand("SELECT COUNT(*) FROM Employees");

        }
    }
}
