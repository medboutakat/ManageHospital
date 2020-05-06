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

namespace  ManageHospitalApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController] 
    public class ProductImageController : ControllerBase
    {
        private readonly ManageHospitalDBContext _context;
        private readonly IMapper _mapper;

        public ProductImageController(ManageHospitalDBContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        // GET: api/OperationCategories
        [HttpGet]
        public IEnumerable<ProductImageModel> GetOperationCategories()
        {
            return _mapper.Map<IEnumerable<ProductImageModel>>(_context.ProductImages); 
        }

        // GET: api/OperationCategories/5
        [HttpGet("{Id}")]
        public async Task<IActionResult> GetById([FromRoute] Guid Id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var obj = await _context.ProductImages.FindAsync(Id);

            if (obj == null)
            {
                return NotFound();
            }
            var dataModel = _mapper.Map<ProductImageModel>(obj);
            return Ok(dataModel);
        }

        // PUT: api/OperationCategories/5
        [HttpPut("{Id}")]
        public async Task<IActionResult> PutProductCategorie([FromRoute] Guid Id, [FromBody] ProductImageModel obj)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (Id != obj.Id)
            {
                return BadRequest();
            }

            var dataModel = _mapper.Map<ProductImageModel>(obj);

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

        // POST: api/OperationCategories
        [HttpPost]
        public async Task<IActionResult> PostProductCategorie([FromBody] ProductImageModel obj)
        {


            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var dataModel = _mapper.Map<ProductImage>(obj);
            _context.ProductImages.Add(dataModel);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetById", new { Id = obj.Id }, obj);
        }

        // DELETE: api/OperationCategories/5
        [HttpDelete("{Id}")]
        public async Task<IActionResult> DeleteProductCategorie([FromRoute] Guid Id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var obj = await _context.ProductImages.FindAsync(Id);
            if (obj == null)
            {
                return NotFound();
            }

            _context.ProductImages.Remove(obj);
            await _context.SaveChangesAsync();

            return Ok(obj);
        }

        private bool Exists(Guid Id)
        {
            return _context.ProductImages.Any(e => e.Id == Id);
        }
    }
}