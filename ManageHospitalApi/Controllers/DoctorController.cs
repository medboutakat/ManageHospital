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

namespace  ManageHospitalApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController] 
    public class DoctorController : ControllerBase
    {
        private readonly ManageHospitalDBContext _context;
        private readonly IMapper _mapper;

        public DoctorController(ManageHospitalDBContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        // GET: api/Doctors
        [HttpGet]
        public IEnumerable<DoctorModel> GetDoctors()
        {
            return _mapper.Map<IEnumerable<DoctorModel>>(_context.Doctors); 
        }

        // GET: api/Doctors/5
        [HttpGet("{Id}")]
        public async Task<IActionResult> GetDoctors([FromRoute] Guid Id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var obj = await _context.Doctors.FindAsync(Id);

            if (obj == null)
            {
                return NotFound();
            }
            var dataModel = _mapper.Map<DoctorModel>(obj);
            return Ok(dataModel); 
        }

        // PUT: api/Doctors/5
        [HttpPut("{Id}")]
        public async Task<IActionResult> PutDoctors([FromRoute] Guid Id, [FromBody] Doctor obj)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (Id != obj.Id)
            {
                return BadRequest();
            }

            _context.Entry(obj).State = EntityState.Modified;

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

        // POST: api/Doctors
        [HttpPost]
        public async Task<IActionResult> PostDoctors([FromBody] Doctor obj)
        {


            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.Doctors.Add(obj);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetDoctors", new { Id = obj.Id }, obj);
        }

        // DELETE: api/Doctors/5
        [HttpDelete("{Id}")]
        public async Task<IActionResult> DeleteDoctors([FromRoute] Guid Id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var obj = await _context.Doctors.FindAsync(Id);
            if (obj == null)
            {
                return NotFound();
            }

            _context.Doctors.Remove(obj);
            await _context.SaveChangesAsync();

            return Ok(obj);
        }

        private bool Exists(Guid Id)
        {
            return _context.Doctors.Any(e => e.Id == Id);
        }
    }
}