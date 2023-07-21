using System.ComponentModel.DataAnnotations;

namespace MiniProjectMVC.Models
{
    public class AddressModel
    {
        [Required]
        [Display(Name ="Street Address")]
        public string StreetAddress { get; set; }

        [Required]
        [Display(Name = "City")]
        public string City { get; set; }

        [Required]
        [Display(Name = "State")]
        public string State { get; set; }

        [Required]
        [Display(Name = "Zipcode")]
        [StringLength(6 , MinimumLength =4)]
        public string ZipCode { get; set; }
    }
}
