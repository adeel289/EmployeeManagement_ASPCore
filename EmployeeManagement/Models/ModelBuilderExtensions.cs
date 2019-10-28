using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagement.Models
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>().HasData(
               new Employee
               {
                   ID = 1,
                   Name = "Marry",
                   Department = Dept.IT,
                   Email = "Marry@gmail.com"

               },
               new Employee
               {
                   ID = 2,
                   Name = "Jane",
                   Department = Dept.HR,
                   Email = "jane@gmail.com"

               }
               );
        }
    }
}
