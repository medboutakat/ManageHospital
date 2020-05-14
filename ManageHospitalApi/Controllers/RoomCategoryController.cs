using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks; 
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore; 
using Microsoft.AspNetCore.Cors;
using ManageHospitalData;
using ManageHospitalData.Entities;
using AutoMapper;
using ManageHospitalModels.Models;
using Microsoft.AspNetCore.Authorization;

namespace  ManageHospitalApi.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController] 
    public class RoomCategoryController : ControllerBase
    {
        private readonly ManageHospitalDBContext _context;
        private readonly IMapper _mapper;

        public RoomCategoryController(ManageHospitalDBContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        // GET: api/RoomCategories
        [HttpGet]
        public IEnumerable<RoomCategoryModel> GetRoomCategories()
        {
            return _mapper.Map<IEnumerable<RoomCategoryModel>>(_context.RoomCategories);  
        }

        // GET: api/RoomCategories/5
        [HttpGet("{Id}")]
        public async Task<IActionResult> GetRoomCategories([FromRoute] Guid Id)
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
            var dataModel = _mapper.Map<RoomCategoryModel>(obj);
            return Ok(dataModel); 
        }

        // PUT: api/RoomCategories/5
        [HttpPut("{Id}")]
        public async Task<IActionResult> PutRoomCategories([FromRoute] Guid Id, [FromBody] RoomCategory obj)
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
        public async Task<IActionResult> DeleteRoomCategories([FromRoute] Guid Id)
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

        private bool Exists(Guid Id)
        {
            return _context.RoomCategories.Any(e => e.Id == Id);
        }
    }
}