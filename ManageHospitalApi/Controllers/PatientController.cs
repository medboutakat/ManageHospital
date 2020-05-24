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
    public class PatientController : ControllerBase
    {
        private readonly ManageHospitalDBContext _context; 
        private readonly IMapper _mapper;


        public PatientController(ManageHospitalDBContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        // GET: api/Patients
        [HttpGet]
        public IEnumerable<PatientModel> GetAll()
        {
            return _mapper.Map<IEnumerable<PatientModel>>(_context.Patients); 
        }

        // GET: api/Patients/5
        [HttpGet("{Id}")]
        public async Task<IActionResult> GetById([FromRoute] Guid Id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var obj = await _context.Patients.FindAsync(Id);

            if (obj == null)
            {
                return NotFound();
            }
            var dataModel = _mapper.Map<PatientModel>(obj);
            return Ok(dataModel); 
        }

        // PUT: api/Patientss/5
        [HttpPut("{Id}")]
        public async Task<IActionResult> Edit([FromRoute] Guid Id, [FromBody] Patient obj)
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

        // POST: api/Patientss
        [HttpPost]
        public async Task<IActionResult> Add([FromBody] Patient obj)
        {


            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.Patients.Add(obj);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetById", new { Id = obj.Id }, obj);
        }

        // DELETE: api/Patientss/5
        [HttpDelete("{Id}")]
        public async Task<IActionResult> Delete([FromRoute] Guid Id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var obj = await _context.Patients.FindAsync(Id);
            if (obj == null)
            {
                return NotFound();
            }

            _context.Patients.Remove(obj);
            await _context.SaveChangesAsync();

            return Ok(obj);
        }

        private bool Exists(Guid Id)
        {
            return _context.Patients.Any(e => e.Id == Id);
        }
    }
}