using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks; 
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore; 
using Microsoft.AspNetCore.Cors;
using ManageHospitalData;
using ManageHospitalData.Entities;

namespace  ManageHospital.WebUI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [DisableCors]
    public class RoomController : ControllerBase
    {
        private readonly ManageHospitalDBContext _context;

        public RoomController(ManageHospitalDBContext context)
        {
            _context = context;
        }

        // GET: api/Rooms
        [HttpGet]
        public IEnumerable<Room> GetRooms()
        {
            return _context.Rooms;
        }

        // GET: api/Rooms/5
        [HttpGet("{Id}")]
        public async Task<IActionResult> GetRooms([FromRoute] Guid Id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var obj = await _context.Rooms.FindAsync(Id);

            if (obj == null)
            {
                return NotFound();
            }

            return Ok(obj);
        }

        // PUT: api/Roomss/5
        [HttpPut("{Id}")]
        public async Task<IActionResult> PutRooms([FromRoute] Guid Id, [FromBody] Room obj)
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

        // POST: api/Roomss
        [HttpPost]
        public async Task<IActionResult> PostRooms([FromBody] Room obj)
        {


            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.Rooms.Add(obj);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetRooms", new { Id = obj.Id }, obj);
        }

        // DELETE: api/Roomss/5
        [HttpDelete("{Id}")]
        public async Task<IActionResult> DeleteRooms([FromRoute] Guid Id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var obj = await _context.Rooms.FindAsync(Id);
            if (obj == null)
            {
                return NotFound();
            }

            _context.Rooms.Remove(obj);
            await _context.SaveChangesAsync();

            return Ok(obj);
        }

        private bool Exists(Guid Id)
        {
            return _context.Rooms.Any(e => e.Id == Id);
        }
    }
}