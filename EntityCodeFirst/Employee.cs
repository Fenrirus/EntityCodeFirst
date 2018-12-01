using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;

namespace EntityCodeFirst
{[Table("tblEmployee")]
    public class Employee
    {
        public int Id { get; set; }
        [Column("First_name")]
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Gender { get; set; }
        public int Salary { get; set; }
        public int DepartmentID { get; set; }
        [ForeignKey("DepartmentID")]
        public Department Department { get; set; }
        public string JobTitle { get; set; }
    }
}