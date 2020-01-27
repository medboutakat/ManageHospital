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
    public class MaterialController : ControllerBase
    {
        private readonly ManageHospitalDBContext _context;

        public MaterialController(ManageHospitalDBContext context)
        {
            _context = context;
        }

        // GET: api/OperationCategories
        [HttpGet]
        public IEnumerable<Material> GetMaterials()
        {
            return _context.Materials;
        }

        // GET: api/OperationCategories/5
        [HttpGet("{Id}")]
        public async Task<IActionResult> GetMaterials([FromRoute] Guid Id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var obj = await _context.Materials.FindAsync(Id);

            if (obj == null)
            {
                return NotFound();
            }

            return Ok(obj);
        }

        // PUT: api/OperationCategories/5
        [HttpPut("{Id}")]
        public async Task<IActionResult> PutMaterials([FromRoute] Guid Id, [FromBody] Material obj)
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

        // POST: api/OperationCategories
        [HttpPost]
        public async Task<IActionResult> PostMaterials([FromBody] Material obj)
        {


            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.Materials.Add(obj);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetMaterials", new { Id = obj.Id }, obj);
        }

        // DELETE: api/OperationCategories/5
        [HttpDelete("{Id}")]
        public async Task<IActionResult> DeleteMaterials([FromRoute] Guid Id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var obj = await _context.Materials.FindAsync(Id);
            if (obj == null)
            {
                return NotFound();
            }

            _context.Materials.Remove(obj);
            await _context.SaveChangesAsync();

            return Ok(obj);
        }

        private bool Exists(Guid Id)
        {
            return _context.Materials.Any(e => e.Id == Id);
        }
    }
}