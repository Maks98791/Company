using Company.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Company.DataAccess
{
    public class AppDbContext : IdentityDbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Employee> Employees { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Employee>().HasData(
                new Employee { Id = 1, Name = "Adam", Surname = "Jackson", Email = "adam123@gmail.com", Department = Department.HR },
                new Employee { Id = 2, Name = "Ann", Surname = "Ornah", Email = "ann765@gmail.com", Department = Department.IT },
                new Employee { Id = 3, Name = "Noah", Surname = "Ming", Email = "noah7654@gmail.com", Department = Department.None },
                new Employee { Id = 4, Name = "Steven", Surname = "Sparrow", Email = "steven6543@gmail.com", Department = Department.HR },
                new Employee { Id = 5, Name = "Michael", Surname = "Anthony", Email = "michael5432@gmail.com", Department = Department.IT }
            );
        }
    }
}
