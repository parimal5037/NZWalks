using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Infrastructure;
using Microsoft.IdentityModel.Tokens;
using NZWalks.Api.Models.Domain;
using NZWalks.Api.Repositories;

namespace NZWalks.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class RegionsController : Controller
    {
        private readonly IRegionRepository _regionrepository;
        private readonly IMapper mapper;
        public RegionsController(IRegionRepository regionRepository,IMapper mapper)
        {
            this._regionrepository= regionRepository;
            this.mapper=mapper;
        }
        [HttpGet(Name = "GetllRegions")]
        public IActionResult GetllRegions()
            
        {

          var regions =   _regionrepository.Getallsync();

            //var regionsDTO = new List<Models.DTO.Regions>();
            //regions.ToList().ForEach(region =>
            //{
            //    var regionDTO = new Models.DTO.Regions()
            //    {
            //        Id = region.Id,
            //        code = region.code,
            //        Name = region.Name,
            //        Area = region.Area,
            //        lat = region.lat,
            //        Long = region.Long,
            //        population = region.population,
            //    };
            //    regionsDTO.Add(regionDTO);
            //});
           
          var regionsDTO =  mapper.Map<List<Models.DTO.Regions>>(regions);
          return Ok(regionsDTO);
         }

        }
    }
