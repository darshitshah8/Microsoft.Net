using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Library.Models
{
    public class StateModel
    {
        [Key]
        public int StateId { get; set; }
        public int CountryId { get; set; }
        public string StateName { get; set; }
    }


}
