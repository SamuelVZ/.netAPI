using dotnetAPI.DTO;
using dotnetAPI.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace dotnetAPI.Controllers {
    [ApiController]
    [Route("[controller]")] //route needed to call this controller ex http://localhost:4200/regions
    public class RegionsController : Controller {
        private readonly RegionRepository regionRepository;

        public RegionsController(RegionRepository regionRepository) {
            this.regionRepository = regionRepository;
        }
        [HttpGet]
        public IActionResult GetRegions() {
            var regions = regionRepository.GetAll();
            var regionsDto = new List<RegionDto>();

            regions.ToList().ForEach(region => {
                var regionDto = new RegionDto() {
                    Id = region.Id,
                    Code = region.Code,
                    Name = region.Name,
                    Area = region.Area,
                    Lat = region.Lat,
                    Long = region.Long,
                    Population = region.Population

                };

                regionsDto.Add(regionDto);

            });
            return Ok(regionsDto);



        }
    }
}
