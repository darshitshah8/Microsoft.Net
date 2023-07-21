using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NZWalks.Api.Data;
using NZWalks.Api.Models;
using static NZWalks.Api.Exceptions.GlobalException;
using static NZWalks.Api.Models.regionDTO;

namespace NZWalks.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [ApiVersion("1.0")]

    public class NZWalksController : ControllerBase
    {
        private readonly NzWalksDbContext _dbContext;

        public NZWalksController(NzWalksDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        [HttpGet]
        //[MapToApiVersion("1")]
        public IActionResult GetRegions()
        {
            var regionsDomain = _dbContext.Regions.ToList();

            var regionDto = new List<RegionDto>();
            if (regionsDomain == null)
            {
                throw new NotFoundException("Data Not Found");
            }
            foreach (var regionDomain in regionsDomain)
            {
                regionDto.Add(new RegionDto()
                {
                    Id = regionDomain.Id,
                    Code = regionDomain.Code,
                    Name = regionDomain.Name,
                    RegionImageUrl = regionDomain.RegionImageUrl

                });
            }
            return Ok(regionDto);
        }

        [HttpGet]
        [Route("{id:Guid}")]
        public IActionResult GetRegion([FromRoute] Guid id) 
        {
            var regionDomain = _dbContext.Regions.FirstOrDefault(x => x.Id == id);
            if(regionDomain == null)
            {
                throw new NotFoundException("Not found ");
            }
            var regionDto = new RegionDto()
            {
                Id = regionDomain.Id,
                Code = regionDomain.Code,
                Name = regionDomain.Name,
                RegionImageUrl = regionDomain.RegionImageUrl
            };
            return Ok(regionDto);  
        }
        [HttpPost]
        public IActionResult AddRegion([FromBody] AddRegionRequestDto addRegionRequestDto)
        {
            var regionDomainModel = new Region
            {
                Code = addRegionRequestDto.Code,
                Name = addRegionRequestDto.Name,
                RegionImageUrl = addRegionRequestDto.RegionImageUrl
            };
            _dbContext.Add(regionDomainModel);
            _dbContext.SaveChanges();

            var regionDto = new RegionDto
            {
                Id = regionDomainModel.Id,
                Code = regionDomainModel.Code,
                Name = regionDomainModel.Name,
                RegionImageUrl = regionDomainModel.RegionImageUrl
            };

            return CreatedAtAction(nameof(GetRegion), new {id =  regionDomainModel.Id}, regionDto);

        }
    }
}
