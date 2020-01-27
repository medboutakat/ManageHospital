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
    public class MaterialCategoryController : ControllerBase
    {
        private readonly ManageHospitalDBContext _context;

        public MaterialCategoryController(ManageHospitalDBContext context)
        {
            _context = context;
        }

        // GET: api/Materials
        [HttpGet]
        public IEnumerable<MaterialCategory> GetMaterials()
        {
            return _context.MaterialCategories;
        }

        // GET: api/Materials/5
        [HttpGet("{Id}")]
        public async Task<IActionResult> GetProductCategorie([FromRoute] Guid Id)
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

        // PUT: api/Materials/5
        [HttpPut("{Id}")]
        public async Task<IActionResult> PutProductCategorie([FromRoute] Guid Id, [FromBody] MaterialCategory obj)
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

        // POST: api/Materials
        [HttpPost]
        public async Task<IActionResult> PostProductCategorie([FromBody] MaterialCategory obj)
        {


            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.MaterialCategories.Add(obj);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetMaterials", new { Id = obj.Id }, obj);
        }

        // DELETE: api/Materials/5
        [HttpDelete("{Id}")]
        public async Task<IActionResult> DeleteProductCategorie([FromRoute] Guid Id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var obj = await _context.MaterialCategories.FindAsync(Id);
            if (obj == null)
            {
                return NotFound();
            }

            _context.MaterialCategories.Remove(obj);
            await _context.SaveChangesAsync();

            return Ok(obj);
        }

        private bool Exists(Guid Id)
        {
            return _context.MaterialCategories.Any(e => e.Id == Id);
        }
    }
}