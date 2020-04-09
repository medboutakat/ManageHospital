using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Cors;
using ManageHospitalData;
using ManageHospitalData.Entities;
using AutoMapper;
using ManageHospitalModels.Models;

namespace ManageHospital.WebUI.Controllers
{
    [Route("api/[controller]")]
    [ApiController] 
    public class CityController : ControllerBase
    {
        private readonly ManageHospitalDBContext _context;
        private readonly IMapper _mapper;

        public CityController(ManageHospitalDBContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        // GET: api/City
        [HttpGet]
        public IEnumerable<CityModel> GetObjects()
        {
            var data = _context.Cities.AsEnumerable();
            var dataModel = _mapper.Map<IEnumerable<CityModel>>(data);
            return dataModel;
        }

        // GET: api/City/5
        [HttpGet("{Id}")]
        public async Task<IActionResult> GetObject([FromRoute] int Id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var obj = await _context.Cities.FindAsync(Id);

            if (obj == null)
            {
                return NotFound();
            }
            var dataModel = _mapper.Map<CityModel>(obj);
            return Ok(dataModel);
        }
        // GET: api/City/5
        [HttpGet("Region/{regionId}")]
        public IEnumerable<CityModel> GetObjectByRegion([FromRoute] int regionId)
        {
            var data = _context.Cities.Where(x => x.RegionId == regionId);
            var dataModel = _mapper.Map<IEnumerable<CityModel>>(data);

            return dataModel;
        }
    }
}