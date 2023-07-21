using System.ComponentModel.DataAnnotations;

namespace CascadingUsingJQuery.Models
{
    public class AllCascadingData
    {
        [Key]
        public int Record { get; set; }
        public int CountryId { get; set; }
        public string CountryName { get; set; }
        public string StateName { get; set; }
        public string CityName { get; set; }
    }
}
