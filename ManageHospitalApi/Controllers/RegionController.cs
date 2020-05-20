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
using Microsoft.AspNetCore.Authorization;

namespace  ManageHospitalApi.Controllers
{ 
    [Route("api/[controller]")]
    [ApiController] 
    public class RegionController : ControllerBase
    {
        private readonly ManageHospitalDBContext _context;
        private readonly IMapper _mapper;

        public RegionController(ManageHospitalDBContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        // GET: api/Region
        [HttpGet]
        public IEnumerable<RegionModel> GetAll()
        {
            var data = _context.Regions.AsEnumerable();
            var dataModel = _mapper.Map<IEnumerable<RegionModel>>(data);
            return dataModel; 
        }

        // GET: api/Region/5
        [HttpGet("{Id}")]
        public async Task<IActionResult> GetObject([FromRoute] int Id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var obj = await _context.Regions.FindAsync(Id);

            if (obj == null)
            {
                return NotFound();
            }
            var dataModel = _mapper.Map<RegionModel>(obj);
            return Ok(dataModel);
        }  
    }
}