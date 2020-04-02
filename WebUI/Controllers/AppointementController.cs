using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Cors;
using ManageHospitalData;
using ManageHospitalData.Entities;
using ManageHospital.WebUI.Models;
using AutoMapper;

namespace ManageHospital.WebUI.Controllers
{
    [Route("api/[controller]")]
    [ApiController] 
    public class AppointementController : ControllerBase
    {
        private readonly ManageHospitalDBContext _context;
        private readonly IMapper _mapper;
        public AppointementController(ManageHospitalDBContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        [HttpGet]
        [Route("GetAndSort")]
        public List<Appointement> Index(string sortField, string currentSortField, string currentSortOrder, string currentFilter, string SearchString, int? pageNo)
        {
            var appi = _context.Appointements.ToList();
            if (SearchString != null)
            {
                pageNo = 1;
            }
            else
            {
                SearchString = currentFilter;
            }
            if (!String.IsNullOrEmpty(SearchString))
            {
                appi = appi.Where(s => s.IdentityNo.Contains(SearchString)).ToList();
            }
            int pageSize = 10;
            var apiQUiry = appi.AsQueryable<Appointement>();
            var data = PagingList<Appointement>.CreateAsync(apiQUiry, pageNo ?? 1, pageSize);
           
            var dt = this.SortAppointement(data , sortField, currentSortField, currentSortOrder);
            return dt;
        }
        private List<Appointement> SortAppointement(List<Appointement> employees, string sortField, string currentSortField, string currentSortOrder)
        {
            var sortOrder = "";
            var _sortField = "";
            if (string.IsNullOrEmpty(sortField))
            {
                _sortField = "Id";
                sortOrder = "Asc";
            }
            else
            {
                if (currentSortField == sortField)
                {
                    sortOrder = currentSortOrder == "Asc" ? "Desc" : "Asc"; 
                }
                else
                {
                    sortOrder = "Asc";
                }
                _sortField = sortField;
            }
            var propertyInfo = typeof(Appointement).GetProperty(sortField);
            if (sortOrder == "Asc")
            {
                employees = employees.OrderBy(s => propertyInfo.GetValue(s, null)).ToList();
            }
            else
            {
                employees = employees.OrderByDescending(s => propertyInfo.GetValue(s, null)).ToList();
            }
            return employees;
        }
        // GET: api/ProductCategories
        [HttpGet]
        public IEnumerable<AppointementModel> GetAppointements()
        {
            var appi = _context.Appointements.AsEnumerable();
            var appointements = _mapper.Map<IEnumerable<AppointementModel>>(appi);

            return appointements;
        }

        // GET: api/ProductCategories/5
        [HttpGet("{Id}")]
        public async Task<IActionResult> GetAppointements([FromRoute] Guid Id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var obj = await _context.Appointements.FindAsync(Id);


            if (obj == null)
            {
                return NotFound();
            }

            var dataModel = _mapper.Map<AppointementModel>(obj);

            return Ok(dataModel);
        }

        // PUT: api/ProductCategories/5
        [HttpPut("{Id}")]
        public async Task<IActionResult> PutAppointements([FromRoute] Guid Id, [FromBody] AppointementModel obj)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (Id != obj.Id)
            {
                return BadRequest();
            }

            var dataModel = _mapper.Map<Appointement>(obj);
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

        // POST: api/ProductCategories
        [HttpPost]
        public async Task<IActionResult> PostAppointements([FromBody] AppointementModel obj)
        {


            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var dataModel = _mapper.Map<Appointement>(obj);
            _context.Appointements.Add(dataModel);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetAppointements", new { Id = obj.Id }, obj);
        }

        // DELETE: api/ProductCategories/5
        [HttpDelete("{Id}")]
        public async Task<IActionResult> DeleteAppointements([FromRoute] Guid Id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var obj = await _context.Appointements.FindAsync(Id);
            if (obj == null)
            {
                return NotFound();
            }

            _context.Appointements.Remove(obj);
            await _context.SaveChangesAsync();

            return Ok(obj);
        }

        private bool Exists(Guid Id)
        {
            return _context.Appointements.Any(e => e.Id == Id);
        }
    }
}