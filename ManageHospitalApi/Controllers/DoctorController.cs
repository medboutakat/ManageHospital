using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks; 
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore; 
using Microsoft.AspNetCore.Cors;
using ManageHospitalData;
using ManageHospitalData.Entities;

namespace ManageHospitalApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [DisableCors]
    public class DoctorController : ControllerBase
    {
        private readonly ManageHospitalDBContext _context;

        public DoctorController(ManageHospitalDBContext context)
        {
            _context = context;
        }

        // GET: api/Doctors
        [HttpGet]
        public IEnumerable<Doctor> GetDoctors()
        {
            return _context.Doctors;
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

            return Ok(obj);
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