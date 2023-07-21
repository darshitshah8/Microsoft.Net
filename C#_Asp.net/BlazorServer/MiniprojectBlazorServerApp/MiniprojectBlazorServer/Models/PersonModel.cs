using System.ComponentModel.DataAnnotations;

namespace MiniprojectBlazorServer.Models
{
    public class PersonModel
    {
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }        
        public bool IsActive { get; set; }
    }
}
