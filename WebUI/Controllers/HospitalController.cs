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
using ManageHospital.WebUI.Models;
using System.IO;

namespace ManageHospital.WebUI.Controllers
{
    [Route("api/[controller]")]
    [ApiController] 
    public class HospitalController : ControllerBase
    {
        private readonly ManageHospitalDBContext _context;
        private readonly IMapper _mapper;

        public HospitalController(ManageHospitalDBContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        // GET: api/OperationCategories
        [HttpGet]
        public IEnumerable<HospitalModel> GetOperationCategories()
        {
            return _mapper.Map<IEnumerable<HospitalModel>>(_context.Hospitals);
        }

        // GET: api/OperationCategories/5
        [HttpGet("{Id}")]
        public async Task<IActionResult> GetObject([FromRoute] Guid Id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var obj = await _context.Hospitals.FindAsync(Id);
            if (obj != null)
            {
                obj.HospitalCategory = await _context.HospitalCategories.FindAsync(obj.HospitalCategoryId);
                obj.Contact = await _context.Contacts.FindAsync(obj.ContactId);
            }
             
            if (obj == null)
            {
                return NotFound();
            }

            var dataModel = _mapper.Map<HospitalModel>(obj);
            return Ok(dataModel);
        }

        // PUT: api/OperationCategories/5
        [HttpPut("{Id}")]
        public async Task<IActionResult> PutProductCategorie([FromRoute] Guid Id, [FromBody] HospitalModel obj)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var data = _mapper.Map<Hospital>(obj);

            if (Id != data.Id)
            {
                return BadRequest();
            }

            _context.Entry(data).State = EntityState.Modified;

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
        public async Task<IActionResult> PostProductCategorie([FromBody] HospitalModel obj)
        {


            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            // Getting Image
            var imageCover = obj.ImageCover;
            var imageProfile = obj.ImageProfile;
            // Saving Image on Server
            if (imageCover?.Length > 0)
            {
                using (var fileStream = new FileStream(imageCover.FileName, FileMode.Create))
                {
                    imageCover.CopyTo(fileStream);
                }
            }
            if (imageProfile?.Length > 0)
            {
                using (var fileStream = new FileStream(imageProfile.FileName, FileMode.Create))
                {
                    imageProfile.CopyTo(fileStream);
                }
            }
            var data = _mapper.Map<Hospital>(obj);

            _context.Hospitals.Add(data);

            await _context.SaveChangesAsync();

            var dataModel = _mapper.Map<HospitalModel>(obj);
            //, dataModel
            return CreatedAtAction("GetProductCategorie", new { Id = obj.Id }, obj);
        }

        // DELETE: api/OperationCategories/5
        [HttpDelete("{Id}")]
        public async Task<IActionResult> DeleteProductCategorie([FromRoute] Guid Id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var obj = await _context.Hospitals.FindAsync(Id);
            if (obj == null)
            {
                return NotFound();
            }

            _context.Hospitals.Remove(obj);
            await _context.SaveChangesAsync();

            return Ok(obj);
        }

        private bool Exists(Guid Id)
        {
            return _context.Hospitals.Any(e => e.Id == Id);
        }
    }
}