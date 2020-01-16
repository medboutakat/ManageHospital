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
    public class RoomCategoryController : ControllerBase
    {
        private readonly ManageHospitalDBContext _context;

        public RoomCategoryController(ManageHospitalDBContext context)
        {
            _context = context;
        }

        // GET: api/RoomCategories
        [HttpGet]
        public IEnumerable<RoomCategory> GetRoomCategories()
        {
            return _context.RoomCategories;
        }

        // GET: api/RoomCategories/5
        [HttpGet("{Id}")]
        public async Task<IActionResult> GetRoomCategories([FromRoute] int Id)
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

        // PUT: api/RoomCategories/5
        [HttpPut("{Id}")]
        public async Task<IActionResult> PutRoomCategories([FromRoute] int Id, [FromBody] RoomCategory obj)
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

        // POST: api/RoomCategories
        [HttpPost]
        public async Task<IActionResult> PostRoomCategories([FromBody] RoomCategory obj)
        {


            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.RoomCategories.Add(obj);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetRoomCategories", new { Id = obj.Id }, obj);
        }

        // DELETE: api/RoomCategories/5
        [HttpDelete("{Id}")]
        public async Task<IActionResult> DeleteRoomCategories([FromRoute] int Id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var obj = await _context.RoomCategories.FindAsync(Id);
            if (obj == null)
            {
                return NotFound();
            }

            _context.RoomCategories.Remove(obj);
            await _context.SaveChangesAsync();

            return Ok(obj);
        }

        private bool Exists(int Id)
        {
            return _context.RoomCategories.Any(e => e.Id == Id);
        }
    }
}