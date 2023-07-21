using System.ComponentModel.DataAnnotations;

namespace MiniprojectBlazorWasm.Models;

public class PersonModel
{
    [Required]
    public string FirstName { get; set; }
    [Required]
    public string LastName { get; set; }

}
