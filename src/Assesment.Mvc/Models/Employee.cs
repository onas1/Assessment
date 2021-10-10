using System;
using System.ComponentModel.DataAnnotations;

namespace HiresHoldingsAssesment.Models
{
    public class Employee
    {
        public string Id { get; set; } = Guid.NewGuid().ToString();
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Display(Name = "Date Of Birth")]
        public DateTime DateOfBirth { get; set; }

        [Display(Name = "Department")]
        public string Department { get; set; }
    }
}
