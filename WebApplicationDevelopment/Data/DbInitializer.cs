using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplicationDevelopment.Models;

namespace WebApplicationDevelopment.Data
{
    public static class DbInitializer
    {
        public static void Initialize(EmployeeContext context)
        {
            context.Database.EnsureCreated();

            // Look for any students.
            if (context.Employee.Any())
            {
                return;   // DB has been seeded
            }

            var employees = new Employee[]
            {
            new Employee{EmployeeID="011",EmployeeName="Nguyen Nam",Department="V",Salary=4390000},
            new Employee{EmployeeID="012",EmployeeName="Manh Quan",Department="A",Salary=7600000},
            new Employee{EmployeeID="013",EmployeeName="Minh Duc",Department="B",Salary=2435000},
            new Employee{EmployeeID="014",EmployeeName="Nguyen Hien",Department="C",Salary=3253200},

            };
            foreach (Employee s in employees)
            {
                context.Employee.Add(s);
            }
            context.SaveChanges();


        }
    }
}
