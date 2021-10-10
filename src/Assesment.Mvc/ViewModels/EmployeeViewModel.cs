using System;
using System.ComponentModel.DataAnnotations;

namespace HiresHoldingsAssesment.ViewModels
{
    public class EmployeeViewModel
    {
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Display(Name = "Date Of Birth")]
        public DateTime DateOfBirth { get; set; }
        public string Department { get; set; }
    }
}
