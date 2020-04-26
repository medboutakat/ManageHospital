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
using System.IO;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Hosting;

namespace ManageHospitalApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HospitalController : ControllerBase
    {
        private readonly ManageHospitalDBContext _context;
        private readonly IMapper _mapper;
        private readonly IWebHostEnvironment _webHostEnvironment;

        public HospitalController(ManageHospitalDBContext context, IMapper mapper, IWebHostEnvironment webHostEnvironment)
        {
            _context = context;
            _mapper = mapper;
            _webHostEnvironment = webHostEnvironment;
        }

        // GET: api/OperationCategories
        [HttpGet]
        public IEnumerable<HospitalModel> GetObjects()
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
        public async Task<IActionResult> PutObject([FromRoute] Guid Id, [FromBody] HospitalModel obj)
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
        public async Task<IActionResult> PostObject([FromBody]HospitalModel model)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var data = _mapper.Map<Hospital>(model);

            _context.Hospitals.Add(data);

            await _context.SaveChangesAsync();

            var dataModel = _mapper.Map<HospitalModel>(model);

            return CreatedAtAction("GetObject", new { Id = model.Id }, dataModel);
        }

        [HttpPut("UpdateImages/{Id}")]
        public async Task<IActionResult> UpdateImages([FromRoute] Guid id, [FromForm]HospitalImages obj)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var time = DateTime.Now.Ticks.ToString();

            var hosp = _context.Hospitals.FirstOrDefault(e => e.Id == id);
            if (hosp == null)
                hosp = new Hospital();

            //Getting Image
            var imageCover = obj.ImageCoverForm;
            var imageProfile = obj.ImageProfileForm;
            //Saving Image on Server

            var imagePath = Path.Combine(_webHostEnvironment.WebRootPath, @"images");

            if (imageCover != null)
            {

                var fileName = "img" + time + imageCover?.FileName;
                string fullPath = Path.Combine(imagePath, fileName); 
                using (var fileStream = new FileStream(fullPath, FileMode.Create))
                {
                    hosp.CovePath = Path.Combine(@"images", fileName);
                }
            }
            if (imageProfile != null)
            {
                var fileName = "img" + time + imageProfile?.FileName;
                string fullPath = Path.Combine(imagePath, fileName); 
                using (var fileStream = new FileStream(fullPath, FileMode.Create))
                {
                    hosp.PictureProfilePath = Path.Combine(@"images", fileName);
                }
            }


            _context.Entry(hosp).State = EntityState.Modified;

            await _context.SaveChangesAsync();

            var dataModel = _mapper.Map<HospitalModel>(hosp);

            return CreatedAtAction("GetObject", new { Id = hosp.Id }, dataModel);
        }


        // DELETE: api/OperationCategories/5
        [HttpDelete("{Id}")]
        public async Task<IActionResult> DeleteObject([FromRoute] Guid Id)
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