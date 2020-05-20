using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ManageHospitalData;
using ManageHospitalData.Entities;
using AutoMapper;
using ManageHospitalModels.Models;
using Microsoft.AspNetCore.Authorization;

namespace ManageHospitalApi.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class SettingsController : ControllerBase
    {
        private readonly ManageHospitalDBContext _context;
        private readonly IMapper _mapper;

        public SettingsController(ManageHospitalDBContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        // GET: api/Doctors
        [HttpGet]
        public IEnumerable<SettingsModel> GetAll()
        {
            return _mapper.Map<IEnumerable<SettingsModel>>(_context.Settings);
        }

        // GET: api/Doctors/5
        [HttpGet("{Id}")]
        public async Task<IActionResult> getObject([FromRoute] Guid Id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var obj = await _context.Settings.FindAsync(Id);

            if (obj == null)
            {
                return NotFound();
            }
            var dataModel = _mapper.Map<SettingsModel>(obj);
            return Ok(dataModel);
        }

        // GET: api/Doctors/5
        [HttpGet("{group}")]
        public IEnumerable<SettingsModel> GetByGroup([FromRoute] string group)
        { 
            return _mapper.Map<IEnumerable<SettingsModel>>(_context.Settings.Where(x => x.Group == group));
        }


        // PUT: api/Doctors/5
        [HttpPut("{Id}")]
        public async Task<IActionResult> PutDoctors([FromRoute] Guid Id, [FromBody] Settings obj)
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

        // POST: api/Doctors
        [HttpPost]
        public async Task<IActionResult> PostDoctors([FromBody] Settings obj)
        {


            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.Settings.Add(obj);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetObject", new { Id = obj.Id }, obj);
        }

        // DELETE: api/Doctors/5
        [HttpDelete("{Id}")]
        public async Task<IActionResult> DeleteDoctors([FromRoute] Guid Id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var obj = await _context.Settings.FindAsync(Id);
            if (obj == null)
            {
                return NotFound();
            }

            _context.Settings.Remove(obj);
            await _context.SaveChangesAsync();

            return Ok(obj);
        }

        private bool Exists(Guid Id)
        {
            return _context.Settings.Any(e => e.Id == Id);
        }
    }
}