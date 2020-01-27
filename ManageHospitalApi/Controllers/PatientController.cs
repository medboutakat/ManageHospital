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
    public class PatientController : ControllerBase
    {
        private readonly ManageHospitalDBContext _context;

        public PatientController(ManageHospitalDBContext context)
        {
            _context = context;
        }

        // GET: api/Patients
        [HttpGet]
        public IEnumerable<Patient> GetPatients()
        {
            return _context.Patients;
        }

        // GET: api/Patients/5
        [HttpGet("{Id}")]
        public async Task<IActionResult> GetPatients([FromRoute] Guid Id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var obj = await _context.Patients.FindAsync(Id);

            if (obj == null)
            {
                return NotFound();
            }

            return Ok(obj);
        }

        // PUT: api/Patientss/5
        [HttpPut("{Id}")]
        public async Task<IActionResult> PutPatients([FromRoute] Guid Id, [FromBody] Patient obj)
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

        // POST: api/Patientss
        [HttpPost]
        public async Task<IActionResult> PostPatients([FromBody] Patient obj)
        {


            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.Patients.Add(obj);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetPatients", new { Id = obj.Id }, obj);
        }

        // DELETE: api/Patientss/5
        [HttpDelete("{Id}")]
        public async Task<IActionResult> DeletePatients([FromRoute] Guid Id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var obj = await _context.Patients.FindAsync(Id);
            if (obj == null)
            {
                return NotFound();
            }

            _context.Patients.Remove(obj);
            await _context.SaveChangesAsync();

            return Ok(obj);
        }

        private bool Exists(Guid Id)
        {
            return _context.Patients.Any(e => e.Id == Id);
        }
    }
}