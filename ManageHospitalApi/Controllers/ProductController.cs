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

namespace ManageHospitalApi.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly ManageHospitalDBContext _context;
        private readonly IMapper _mapper;


        public ProductController(ManageHospitalDBContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        // GET: api/Patients
        [HttpGet]
        public IEnumerable<ProductModel> GetPatients()
        {
            return _mapper.Map<IEnumerable<ProductModel>>(_context.Products);
        }

        // GET: api/Patients/5
        [HttpGet("{Id}")]
        public async Task<IActionResult> GetById([FromRoute] Guid Id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var obj = await _context.Products.FindAsync(Id);

            if (obj == null)
            {
                return NotFound();
            }
            var dataModel = _mapper.Map<ProductModel>(obj);
            return Ok(dataModel);
        }
        // GET: api/Patients/5
        [HttpGet("name/{name}")]
        public async Task<IActionResult> GetByName([FromRoute] string name)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var sqlQuery = string.Format("Select * from Products where name like'%{0}%'", name);
            var objs = _context.Products.FromSqlRaw(sqlQuery) ;

            if (objs == null)
            {
                return NotFound();
            }

            var dataModels = _mapper.Map<IEnumerable<ProductModel>>(objs);
            var result =await Task.FromResult(dataModels);

            return Ok(result);
        }
        // PUT: api/Productss/5
        [HttpPut("{Id}")]
        public async Task<IActionResult> PutProducts([FromRoute] Guid Id, [FromBody] Product obj)
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

        // POST: api/Productss
        [HttpPost]
        public async Task<IActionResult> PostProducts([FromBody] Product obj)
        {


            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.Products.Add(obj);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetById", new { Id = obj.Id }, obj);
        }


        // DELETE: api/Productss/5
        [HttpDelete("{Id}")]
        public async Task<IActionResult> DeleteProducts([FromRoute] Guid Id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var obj = await _context.Products.FindAsync(Id);
            if (obj == null)
            {
                return NotFound();
            }

            _context.Products.Remove(obj);
            await _context.SaveChangesAsync();

            return Ok(obj);
        }

        private bool Exists(Guid Id)
        {
            return _context.Products.Any(e => e.Id == Id);
        }
    }
}