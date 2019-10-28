using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagement.Models
{
    public class SQLEmployeeRepository : IEmployeeRepository
    {
        private readonly AppDbContext context;
        private readonly ILogger<SQLEmployeeRepository> logger;

        public SQLEmployeeRepository(AppDbContext context,ILogger<SQLEmployeeRepository> logger )
        {
            this.context = context;
            this.logger = logger;
        }
        public Employee Add(Employee employee)
        {
            context.Employees.Add(employee);
            context.SaveChanges();
            return employee;
        }

        public Employee Delete(int id)
        {
            Employee employee = context.Employees.FirstOrDefault(e => e.ID == id);
            if (employee != null)
            {
                context.Employees.Remove(employee);
                context.SaveChanges();

            }
            return employee;
        }

        public IEnumerable<Employee> GetAllEmployees()
        {
            return context.Employees;
        }

        public Employee GetEmployee(int Id)
        {
            logger.LogTrace("Log Trace");
            logger.LogDebug("Log Debug");
            logger.LogInformation("Log Information");
            logger.LogWarning("Log Warning");
            logger.LogError("Log Error");
            logger.LogCritical("Log Critical");

            return context.Employees.Find(Id);
        }

        public Employee Update(Employee employeeChange)
        {
            var employee = context.Employees.Attach(employeeChange);
            employee.State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            context.SaveChanges();
            return employeeChange;
        }
    }
}
