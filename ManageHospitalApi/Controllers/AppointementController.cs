using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks; 
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore; 
using Microsoft.AspNetCore.Cors;
using ManageHospitalData;
using ManageHospitalData.Entities;
using ManageHospitalApi.Models;
using AutoMapper;

namespace ManageHospitalApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [DisableCors]
    public class AppointementController : ControllerBase
    {
        private readonly ManageHospitalDBContext _context;
        private readonly IMapper _mapper;
        public AppointementController(ManageHospitalDBContext context , IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        // GET: api/ProductCategories
        [HttpGet]
        public IEnumerable<AppointementModel> GetAppointements()
        {
            var appi = _context.Appointements.AsEnumerable(); 
            var appointements = _mapper.Map<IEnumerable<AppointementModel>>(appi);

            return appointements;
        }

        // GET: api/ProductCategories/5
        [HttpGet("{Id}")]
        public async Task<IActionResult> GetAppointements([FromRoute] Guid Id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var obj = await _context.Appointements.FindAsync(Id);

            if (obj == null)
            {
                return NotFound();
            }

            return Ok(obj);
        }

        // PUT: api/ProductCategories/5
        [HttpPut("{Id}")]
        public async Task<IActionResult> PutAppointements([FromRoute] Guid Id, [FromBody] Appointement obj)
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

        // POST: api/ProductCategories
        [HttpPost]
        public async Task<IActionResult> PostAppointements([FromBody] Appointement obj)
        {


            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.Appointements.Add(obj);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetAppointements", new { Id = obj.Id }, obj);
        }

        // DELETE: api/ProductCategories/5
        [HttpDelete("{Id}")]
        public async Task<IActionResult> DeleteAppointements([FromRoute] Guid Id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var obj = await _context.Appointements.FindAsync(Id);
            if (obj == null)
            {
                return NotFound();
            }

            _context.Appointements.Remove(obj);
            await _context.SaveChangesAsync();

            return Ok(obj);
        }

        private bool Exists(Guid Id)
        {
            return _context.Appointements.Any(e => e.Id == Id);
        }
    }
}