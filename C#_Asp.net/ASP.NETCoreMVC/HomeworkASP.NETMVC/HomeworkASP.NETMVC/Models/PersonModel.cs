using System.ComponentModel.DataAnnotations;

namespace HomeworkASP.NETMVC.Models
{
    public class PersonModel
    {
        [Required]
        [Display(Name="Enter First Name")]
        public string FirstName { get; set; }
        [Required]
        [Display(Name = "Enter Last Name")]
        public string LastName { get; set; }
    }
}
