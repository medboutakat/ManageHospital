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
    public class MaterialController : ControllerBase
    {
        private readonly ManageHospitalDBContext _context;
        private readonly IMapper _mapper;

        public MaterialController(ManageHospitalDBContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        // GET: api/OperationCategories
        [HttpGet]
        public IEnumerable<MaterialModel> GetAll()
        {
            return _mapper.Map<IEnumerable<MaterialModel>>(_context.Materials); 
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
            var dataModel = _mapper.Map<MaterialModel>(obj);
            return Ok(dataModel); 
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