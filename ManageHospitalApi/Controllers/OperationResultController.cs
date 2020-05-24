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
    public class OperationResultController : ControllerBase
    {
        private readonly ManageHospitalDBContext _context;
        private readonly IMapper _mapper;


        public OperationResultController(ManageHospitalDBContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        // GET: api/OperationResults
        [HttpGet]
        public IEnumerable<OperationResultModel> GetAll()
        {
            return _mapper.Map<IEnumerable<OperationResultModel>>(_context.OperationResults);
        }

        // GET: api/OperationResults/5
        [HttpGet("{Id}")]
        public async Task<IActionResult> GetById([FromRoute] Guid Id)
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
            var dataModel = _mapper.Map<OperationResultModel>(obj);
            return Ok(dataModel);
        }

        // PUT: api/OperationResultss/5
        [HttpPut("{Id}")]
        public async Task<IActionResult> Edit([FromRoute] Guid Id, [FromBody] OperationResult obj)
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
        public async Task<IActionResult> Add([FromBody] OperationResult obj)
        {


            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.OperationResults.Add(obj);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetById", new { Id = obj.Id }, obj);
        }

        // DELETE: api/OperationResultss/5
        [HttpDelete("{Id}")]
        public async Task<IActionResult> Delete ([FromRoute] Guid Id)
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