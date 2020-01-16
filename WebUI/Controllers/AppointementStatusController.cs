using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks; 
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore; 
using Microsoft.AspNetCore.Cors;
using ManageHospitalData;
using ManageHospitalData.Entities;

namespace ManageHospital.WebUI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [DisableCors]
    public class AppointementStatusController : ControllerBase
    {
        private readonly ManageHospitalDBContext _context;

        public AppointementStatusController(ManageHospitalDBContext context)
        {
            _context = context;
        }

        // GET: api/AppointementStatus
        [HttpGet]
        public IEnumerable<AppointementStatus> GetAppointementStatus()
        {
            return _context.AppointementStatuss;
        }

        // GET: api/AppointementStatus/5
        [HttpGet("{Id}")]
        public async Task<IActionResult> GetProductCategorie([FromRoute] int Id)
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

            return Ok(obj);
        }

        // PUT: api/AppointementStatus/5
        [HttpPut("{Id}")]
        public async Task<IActionResult> PutProductCategorie([FromRoute] int Id, [FromBody] AppointementStatus obj)
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

        // POST: api/AppointementStatus
        [HttpPost]
        public async Task<IActionResult> PostProductCategorie([FromBody] AppointementStatus obj)
        {


            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.AppointementStatuss.Add(obj);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetAppointementStatus", new { Id = obj.Id }, obj);
        }

        // DELETE: api/AppointementStatus/5
        [HttpDelete("{Id}")]
        public async Task<IActionResult> DeleteProductCategorie([FromRoute] int Id)
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

        private bool Exists(int Id)
        {
            return _context.AppointementStatuss.Any(e => e.Id == Id);
        }
    }
}