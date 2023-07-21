namespace NZWalks.Api.Models
{
    public class Models
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
    }
    public class Difficulty : Models
    {

    }
    public class Region : Models
    {
        public string Code { get; set; }
        public string? RegionImageUrl { get; set; }
    }
    public class Walk : Models
    {
        public string Description { get; set; }
        public double LengthInKm { get; set; }
        public string? WalkImageUrl { get; set; }
        public Guid DIfficultyId { get; set; }
        public Guid RegionId { get; set; }
        public Difficulty Difficulty { get; set; } // Navigation Property
        public Region Region { get; set; }
    }
}
