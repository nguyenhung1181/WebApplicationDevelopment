using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplicationDevelopment.Models
{
    public class Employee
    {
        [Required]
        [StringLength(50)]
        public string EmployeeID { get; set; }
        [Required]
        [StringLength(50)]
        public string EmployeeName { get; set; }
        [StringLength(50)]
        public string Department { get; set; }
        [Range(0, 99999999)]
        public int Salary { get; set; }

    }
}
