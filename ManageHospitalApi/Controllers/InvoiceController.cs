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

namespace  ManageHospitalApi.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController] 
    public class InvoiceController : ControllerBase
    {
        private readonly ManageHospitalDBContext _context;
        private readonly IMapper _mapper;

        public InvoiceController(ManageHospitalDBContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        // GET: api/Invoice
        [HttpGet]
        public IEnumerable<InvoiceModel> GetObjects()
        {
            var data = _context.Invoices.AsEnumerable();
            var dataModel = _mapper.Map<IEnumerable<InvoiceModel>>(data);
            return dataModel; 
        }

        // GET: api/Invoice/5
        [HttpGet("{Id}")]
        public async Task<IActionResult> GetObject([FromRoute] Guid Id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var obj = await _context.Invoices.FindAsync(Id);
            var details = await _context.InvoiceDetails.Where(x=>x.InvoiceId==Id).ToListAsync();
            obj.InvoiceDetails = details;

            if (obj == null)
            {
                return NotFound();
            }
            var dataModel = _mapper.Map<InvoiceModel>(obj); 

            return Ok(dataModel);
        }

        // PUT: api/Invoice/5
        [HttpPut("{Id}")]
        public async Task<IActionResult> PutObject([FromRoute] Guid Id, [FromBody] InvoiceModel obj)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (Id != obj.Id)
            {
                return BadRequest();
            }
            var dataModel = _mapper.Map<Invoice>(obj);

            _context.Entry(dataModel).State = EntityState.Modified;

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

        // POST: api/Invoice
        [HttpPost]
        public async Task<IActionResult> PostObject([FromBody] InvoiceModel obj)
        {


            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var dataModel = _mapper.Map<Invoice>(obj);

            _context.Invoices.Add(dataModel);

            await _context.SaveChangesAsync();

            return CreatedAtAction("GetObject", new { Id = obj.Id }, dataModel);
        }

        // DELETE: api/Invoice/5
        [HttpDelete("{Id}")]
        public async Task<IActionResult> DeleteObject([FromRoute] Guid Id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var obj = await _context.Invoices.FindAsync(Id);
            if (obj == null)
            {
                return NotFound();
            }

            _context.Invoices.Remove(obj);
            await _context.SaveChangesAsync();

            return Ok(obj);
        }

        private bool Exists(Guid Id)
        {
            return _context.Invoices.Any(e => e.Id == Id);
        }
    }
}