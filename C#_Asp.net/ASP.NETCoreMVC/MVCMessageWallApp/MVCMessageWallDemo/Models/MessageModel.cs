using System.ComponentModel.DataAnnotations;

namespace MVCMessageWallDemo.Models
{
    public class MessageModel
    {
        [Required]
        [StringLength(10, MinimumLength = 5)]
        [Display(Name = "Enter messages")]
        public string Message { get; set; }
    }
}
