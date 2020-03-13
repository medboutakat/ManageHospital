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

namespace  ManageHospital.WebUI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [DisableCors]
    public class RequestStatusController : ControllerBase
    {
        private readonly ManageHospitalDBContext _context;
        private readonly IMapper _mapper;

        public RequestStatusController(ManageHospitalDBContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        // GET: api/DoctorCategories
        [HttpGet]
        public IEnumerable<RequestStatusModel> GetAll()
        {
            return _mapper.Map<IEnumerable<RequestStatusModel>>(_context.DoctorCategories); 
        }

        // GET: api/DoctorCategories/5
        [HttpGet("{Id}")]
        public async Task<IActionResult> GetById([FromRoute] Guid Id)
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
            var dataModel = _mapper.Map<RequestStatusModel>(obj);
            return Ok(dataModel); 
        }

        // PUT: api/DoctorCategories/5
        [HttpPut("{Id}")]
        public async Task<IActionResult> Put([FromRoute] Guid Id, [FromBody] DoctorCategory obj)
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

        // POST: api/DoctorCategories
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] RequestStatusModel obj)
        {


            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var dataModel = _mapper.Map<DoctorCategory>(obj);
            _context.DoctorCategories.Add(dataModel);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetById", new { Id = obj.Id }, dataModel);
        }

        // DELETE: api/DoctorCategories/5
        [HttpDelete("{Id}")]
        public async Task<IActionResult> Delete([FromRoute] Guid Id)
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

        private bool Exists(Guid Id)
        {
            return _context.DoctorCategories.Any(e => e.Id == Id);
        }
    }
}