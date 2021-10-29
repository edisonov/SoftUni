using System;
using CodeFirstDemo.Models;

namespace CodeFirstDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            var db = new ApplicationDbContext();
            db.Database.EnsureCreated();
        }
    }
}
