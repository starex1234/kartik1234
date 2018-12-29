using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
namespace Student_Portal.Models
{
    public class EmployeeDetail
    {
        [Key]
        public int EmpId { get; set; }

        [Required(ErrorMessage ="Field  is required")]
        public string EmpName { get; set; }

        [Required(ErrorMessage = "Field is required")]
        public string EmpEmail { get; set; }

        [Required(ErrorMessage = "Field is required")]
        public string EmpDep { get; set; }

        [Required(ErrorMessage = "Field is required")]
        public string EmpCompany { get; set; }

       
    }
}