namespace NZWalks.Api.Models
{
    public class regionDTO
    {
        public class ModelsDto
        {
            public Guid Id { get; set; }
            public string Name { get; set; }
        }
        public class DifficultyDto : ModelsDto
        {

        }
        public class RegionDto : Models
        {
            public string Code { get; set; }
            public string? RegionImageUrl { get; set; }
        }
        public class WalkDto : ModelsDto
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
}
