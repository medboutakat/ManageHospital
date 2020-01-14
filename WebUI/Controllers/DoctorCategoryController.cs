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
    public class DoctorCategoryController : ControllerBase
    {
        private readonly ManageHospitalDBContext _context;

        public DoctorCategoryController(ManageHospitalDBContext context)
        {
            _context = context;
        }

        // GET: api/ProductCategories
        [HttpGet]
        public IEnumerable<DoctorCategory> GetProductCategories()
        {
            return _context.DoctorCategories;
        }

        // GET: api/ProductCategories/5
        [HttpGet("{Id}")]
        public async Task<IActionResult> GetProductCategorie([FromRoute] int Id)
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
        public async Task<IActionResult> PutProductCategorie([FromRoute] int Id, [FromBody] DoctorCategory obj)
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
        public async Task<IActionResult> PostProductCategorie([FromBody] DoctorCategory obj)
        {


            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.DoctorCategories.Add(obj);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetProductCategories", new { Id = obj.Id }, obj);
        }

        // DELETE: api/ProductCategories/5
        [HttpDelete("{Id}")]
        public async Task<IActionResult> DeleteProductCategorie([FromRoute] int Id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var obj = await _context.DoctorCategories.FindAsync(Id);
            if (obj == null)
            {
                return NotFound();
            }

            _context.DoctorCategories.Remove(obj);
            await _context.SaveChangesAsync();

            return Ok(obj);
        }

        private bool Exists(int Id)
        {
            return _context.DoctorCategories.Any(e => e.Id == Id);
        }
    }
}