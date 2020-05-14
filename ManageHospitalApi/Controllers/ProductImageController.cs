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
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Authorization;

namespace ManageHospitalApi.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class ProductImageController : ControllerBase
    {
        private readonly ManageHospitalDBContext _context;
        private readonly IMapper _mapper;
        private readonly IWebHostEnvironment _webHostEnvironment;

        public ProductImageController(ManageHospitalDBContext context, IMapper mapper, IWebHostEnvironment webHostEnvironment)
        {
            _context = context;
            _mapper = mapper;
            _webHostEnvironment = webHostEnvironment;
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
        public async Task<IActionResult> PostProductCategorie([FromBody] ProductImageModelForm obj)
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
         

        [HttpPut("UpdateImages/{proudctId}")]
        public async Task<IActionResult> UpdateImages([FromRoute] Guid proudctId, [FromForm]ProductImageModelForm obj)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var time = DateTime.Now.Ticks.ToString();

            var product = _context.Products.FirstOrDefault(e => e.Id == proudctId);
            if (product == null)
                product = new Product();

            //Getting Image
            var imageCover = obj.ImageCoverForm;
            //Saving Image on Server

            var imagePath = Path.Combine(_webHostEnvironment.WebRootPath, @"images");
            var fullPathName = "";
            if (imageCover != null)
            {

                var fileName = "img" + time + imageCover?.FileName;
                string fullPath = Path.Combine(imagePath, fileName);
                fullPathName = Path.Combine(@"images", fileName);
                var imageId = Guid.NewGuid();
                using (var fileStream = new FileStream(fullPath, FileMode.Create))
                {
                    ProductImage productImage = new ProductImage
                    {
                        Id = imageId,
                        Path = fullPathName
                    };

                    product.ProductImages.Add(productImage);

                }
            }


            _context.Entry(product).State = EntityState.Modified; 
            await _context.SaveChangesAsync();

            return Ok(fullPathName);


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