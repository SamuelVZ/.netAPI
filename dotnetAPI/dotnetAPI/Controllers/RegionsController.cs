using AutoMapper;
using dotnetAPI.DTO;
using dotnetAPI.model;
using dotnetAPI.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace dotnetAPI.Controllers {
    [ApiController]
    [Route("[controller]")] //route needed to call this controller ex http://localhost:4200/regions
    public class RegionsController : Controller {
        private readonly RegionRepository regionRepository;
        private readonly IMapper mapper;

        public RegionsController(RegionRepository regionRepository, IMapper mapper) {
            this.regionRepository = regionRepository;
            this.mapper = mapper;
        }
        [HttpGet]
        public async Task<IActionResult> GetRegions() {
            var regions = await regionRepository.GetAll();

            //var regionsDto = new List<RegionDto>();

            //regions.ToList().ForEach(region => {
            //    var regionDto = new RegionDto() {
            //        Id = region.Id,
            //        Code = region.Code,
            //        Name = region.Name,
            //        Area = region.Area,
            //        Lat = region.Lat,
            //        Long = region.Long,
            //        Population = region.Population

            //    };

            //    regionsDto.Add(regionDto);

            //});


            var regionsDto = mapper.Map<List<Region>>(regions);

            return Ok(regionsDto);



        }

        [HttpGet]
        [Route("{id:int}")]
        [ActionName("GetRegionById")]
        public async Task<IActionResult> GetRegionById(int id) {
            var region = await regionRepository.GetById(id);

            if (region == null) {
                return NotFound();
            }

            var regionDto = mapper.Map<Region, RegionDto>(region);
            return Ok(regionDto);
        }


        [HttpPost]
        public async Task<IActionResult> AddRegion(AddRegion addRegion) {
            var region = mapper.Map<AddRegion, Region>(addRegion);

             region = await regionRepository.AddRegion(region);

             var regionDto = mapper.Map<Region, RegionDto>(region); 
            
            return CreatedAtAction(nameof(GetRegionById), new {id = regionDto.Id}, regionDto);
            //option to introduce the Actionname but it is better to call the method with nameof(method)
            //return CreatedAtAction("GetRegionById", new {id = regionDto.Id}, regionDto);
        }

        [HttpDelete]
        [Route("{id:int}")]
        public async Task<IActionResult> DeleteRegion(int id) {
            var deleted = await regionRepository.DeleteRegion(id);
            return deleted ? Ok() : NotFound();
        }

        [HttpPut]
        [Route("{id:int}")]
        public async Task<IActionResult> UpdateRegion([FromRoute] int id,[FromBody] AddRegion updateRegion) {

            var region = mapper.Map<AddRegion, Region>(updateRegion);
            region.Id= id;
            var result = await regionRepository.UpdateRegion(region);

            if(result == null)  return NotFound(); 

            return Ok(result);
        }
    }
}


//print an object

//foreach (PropertyDescriptor descriptor in TypeDescriptor.GetProperties(regionDto)) {
//    string name = descriptor.Name;
//    object value = descriptor.GetValue(regionDto);
//    Console.WriteLine("{0}={1}", name, value);
//}