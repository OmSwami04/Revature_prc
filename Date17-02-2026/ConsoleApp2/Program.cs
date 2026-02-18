using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AppDbContext _context = new AppDbContext();

            // SELECT STUDENTS
            var students = _context.Students
                .Where(s => s.Age > 20)
                .ToList();

            // INSERT NEW STUDENT
            _context.Students.Add(new Student
            {
                Name = "Om",
                Age = 25
            });

            _context.SaveChanges();

            foreach (var s in students)
            {
                Console.WriteLine($"{s.Id} {s.Name} {s.Age}");
            }
        }
    }

    // ================= STUDENT TABLE =================
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
    }

    // ================= CUSTOMER TABLE =================
    public class Customer
    {
        public int CustomerID { get; set; }
        public string CustomerName { get; set; }

        // One Customer → Many Orders
        public List<Order> Orders { get; set; }
    }

    // ================= ORDER TABLE =================
    public class Order
    {
        public int OrderID { get; set; }

        // Foreign Key
        public int CustomerID { get; set; }

        // Navigation Property
        public Customer Customer { get; set; }
    }

    // ================= DB CONTEXT =================
    public class AppDbContext : DbContext
    {
        public DbSet<Student> Students { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Order> Orders { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connectionString =
            "server=localhost;port=3306;database=mig;user=root;password=Swamiom11@;";

            optionsBuilder.UseMySql(
                connectionString,
                ServerVersion.AutoDetect(connectionString)
            );
        }
    }
}