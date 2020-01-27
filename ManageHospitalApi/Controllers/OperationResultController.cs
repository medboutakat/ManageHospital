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
    public class OperationResultController : ControllerBase
    {
        private readonly ManageHospitalDBContext _context;

        public OperationResultController(ManageHospitalDBContext context)
        {
            _context = context;
        }

        // GET: api/OperationResults
        [HttpGet]
        public IEnumerable<OperationResult> GetOperationResults()
        {
            return _context.OperationResults;
        }

        // GET: api/OperationResults/5
        [HttpGet("{Id}")]
        public async Task<IActionResult> GetOperationResults([FromRoute] Guid Id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var obj = await _context.OperationResults.FindAsync(Id);

            if (obj == null)
            {
                return NotFound();
            }

            return Ok(obj);
        }

        // PUT: api/OperationResultss/5
        [HttpPut("{Id}")]
        public async Task<IActionResult> PutOperationResults([FromRoute] Guid Id, [FromBody] OperationResult obj)
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

        // POST: api/OperationResultss
        [HttpPost]
        public async Task<IActionResult> PostOperationResults([FromBody] OperationResult obj)
        {


            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.OperationResults.Add(obj);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetOperationResults", new { Id = obj.Id }, obj);
        }

        // DELETE: api/OperationResultss/5
        [HttpDelete("{Id}")]
        public async Task<IActionResult> DeleteOperationResults([FromRoute] Guid Id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var obj = await _context.OperationResults.FindAsync(Id);
            if (obj == null)
            {
                return NotFound();
            }

            _context.OperationResults.Remove(obj);
            await _context.SaveChangesAsync();

            return Ok(obj);
        }

        private bool Exists(Guid Id)
        {
            return _context.OperationResults.Any(e => e.Id == Id);
        }
    }
}