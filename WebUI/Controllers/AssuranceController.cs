﻿using System;
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
    public class AssuranceController : ControllerBase
    {
        private readonly ManageHospitalDBContext _context;

        public AssuranceController(ManageHospitalDBContext context)
        {
            _context = context;
        }

        // GET: api/Assurances
        [HttpGet]
        public IEnumerable<Assurance> GetAssurances()
        {
            return _context.Assurances;
        }

        // GET: api/Assurances/5
        [HttpGet("{Id}")]
        public async Task<IActionResult> GetProductCategorie([FromRoute] int Id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var obj = await _context.Assurances.FindAsync(Id);

            if (obj == null)
            {
                return NotFound();
            }

            return Ok(obj);
        }

        // PUT: api/Assurances/5
        [HttpPut("{Id}")]
        public async Task<IActionResult> PutProductCategorie([FromRoute] int Id, [FromBody] Assurance obj)
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

        // POST: api/Assurances
        [HttpPost]
        public async Task<IActionResult> PostProductCategorie([FromBody] Assurance obj)
        {


            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.Assurances.Add(obj);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetAssurances", new { Id = obj.Id }, obj);
        }

        // DELETE: api/Assurances/5
        [HttpDelete("{Id}")]
        public async Task<IActionResult> DeleteProductCategorie([FromRoute] int Id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var obj = await _context.Assurances.FindAsync(Id);
            if (obj == null)
            {
                return NotFound();
            }

            _context.Assurances.Remove(obj);
            await _context.SaveChangesAsync();

            return Ok(obj);
        }

        private bool Exists(int Id)
        {
            return _context.Assurances.Any(e => e.Id == Id);
        }
    }
}