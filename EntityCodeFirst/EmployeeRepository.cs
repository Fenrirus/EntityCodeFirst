using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EntityCodeFirst
{
    public class EmployeeRepository
    {
        public List<Department> GetDepartments()
        {
            EmployeeDbContext employeeDbContext = new EmployeeDbContext();
            return employeeDbContext.Departments.Include("Employees").ToList();
        }
    }
}