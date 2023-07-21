using System.ComponentModel.DataAnnotations;

namespace CascadingUsingJQuery.Models;

public class UserModel
{
    public int UserId { get; set; }

    //[Required(ErrorMessage = "Username is required.")]
    public string UserName { get; set; }

    //[Required(ErrorMessage = "Password is required.")]
    public string Password { get; set; }
 
    //[Required(ErrorMessage = "Email address is required.")]
    //[EmailAddress(ErrorMessage = "Invalid email address.")]
    public string Email { get; set; }
}
