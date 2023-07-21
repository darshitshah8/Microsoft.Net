using System.ComponentModel.DataAnnotations;

namespace MiniprojectBlazorServer.Models
{
    public class AddressModel
    {
        [Required]
        public string StreetAddress { get; set; }
        [Required]
        public string City { get; set; }
        [Required]
        public string State { get; set; }
        [Required]
        public string ZipCode { get; set; }
    }
}
