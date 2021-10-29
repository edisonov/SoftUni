using System;
using System.Linq;
using OrmFundamental.Models;

namespace OrmFundamental
{
    // Microsoft.EntityFrameworkCore.SqlServer
    // Microsoft.EntityFrameworkCore.Design
    // dotnet ef dbcontext scaffold "Server=.;Integrated Security=true;Database=SoftUni"
    // Microsoft.EntityFrameworkCore.SqlServer -o Models

    class Program
    {

        static void Main(string[] args)
        {
            var db = new SoftUniContext();

            Console.WriteLine(db.Employees.Count());
        }
    }
}
