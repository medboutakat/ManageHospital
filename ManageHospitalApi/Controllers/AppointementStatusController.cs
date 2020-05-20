using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks; 
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;  
using ManageHospitalData;
using ManageHospitalData.Entities;
using AutoMapper; 
using ManageHospitalModels.Models;
using Microsoft.AspNetCore.Authorization;

namespace  ManageHospitalApi.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController] 
    public class AppointementStatusController : ControllerBase
    {
        private readonly ManageHospitalDBContext _context;
        private readonly IMapper _mapper;

        public AppointementStatusController(ManageHospitalDBContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        // GET: api/AppointementStatus
        [HttpGet]
        public IEnumerable<AppointementStatusModel> GetAll()
        {
            var data = _context.AppointementStatuss.AsEnumerable();
            var dataModel = _mapper.Map<IEnumerable<AppointementStatusModel>>(data);
            return dataModel; 
        }

        // GET: api/AppointementStatus/5
        [HttpGet("{Id}")]
        public async Task<IActionResult> GetObject([FromRoute] Guid Id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var obj = await _context.AppointementStatuss.FindAsync(Id);

            if (obj == null)
            {
                return NotFound();
            }
            var dataModel = _mapper.Map<AppointementStatusModel>(obj);
            return Ok(dataModel);
        }

        // PUT: api/AppointementStatus/5
        [HttpPut("{Id}")]
        public async Task<IActionResult> PutObject([FromRoute] Guid Id, [FromBody] AppointementStatusModel obj)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (Id != obj.Id)
            {
                return BadRequest();
            }
            var dataModel = _mapper.Map<AppointementStatus>(obj);

            _context.Entry(dataModel).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!Exists(Id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/AppointementStatus
        [HttpPost]
        public async Task<IActionResult> PostObject([FromBody] AppointementStatusModel obj)
        {


            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var dataModel = _mapper.Map<AppointementStatus>(obj);

            _context.AppointementStatuss.Add(dataModel);

            await _context.SaveChangesAsync();

            return CreatedAtAction("GetObject", new { Id = obj.Id }, dataModel);
        }

        // DELETE: api/AppointementStatus/5
        [HttpDelete("{Id}")]
        public async Task<IActionResult> DeleteObject([FromRoute] Guid Id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var obj = await _context.AppointementStatuss.FindAsync(Id);
            if (obj == null)
            {
                return NotFound();
            }

            _context.AppointementStatuss.Remove(obj);
            await _context.SaveChangesAsync();

            return Ok(obj);
        }

        private bool Exists(Guid Id)
        {
            return _context.AppointementStatuss.Any(e => e.Id == Id);
        }
    }
}