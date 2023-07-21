using System.ComponentModel.DataAnnotations;

namespace CustomAuthentication.Models
{
    public class UserRolesModel
    {
        [Key]
        public int RoleId { get; set; }
        public int UserId { get; set; }
        public string Name { get; set; }
    }
}
