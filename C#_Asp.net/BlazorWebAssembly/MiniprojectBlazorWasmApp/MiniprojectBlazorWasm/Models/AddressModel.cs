using System.ComponentModel.DataAnnotations;

namespace MiniprojectBlazorWasm.Models;

public class AddressModel
{
    [Required]
    public string StreetAddress { get; set; }
    [Required]
    public string City { get; set; }
    [Required]
    [StringLength(10,MinimumLength =3)]
    public string State { get; set; }
    [Required]
    [StringLength(10,MinimumLength =6)]
    public string ZipCode { get; set; }

}
