﻿using AutoMapper;
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
        public IActionResult GetRegions() {
            var regions = regionRepository.GetAll();

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
    }
}
