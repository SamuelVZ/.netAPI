using AutoMapper;
using dotnetAPI.DTO;
using dotnetAPI.model;

namespace dotnetAPI.Profiles {
    //Mapper to convert to DTO
    public class RegionProfile: Profile {
        public RegionProfile() {
            //maps same name attributes
            CreateMap<Region, RegionDto>();
            CreateMap<Region, AddRegion>().ReverseMap();



            //this option is in case you map attributes have different names example with regionId on Region and Id on the DTO
            //CreateMap<Region, RegionDto>().ForMember(dest => dest.Id, options => options.MapFrom(src => src.RegionId) );

            //to convert from DTO to the domain models
            //CreateMap<Region, RegionDto>().ReverseMap();
        }
    }
}
