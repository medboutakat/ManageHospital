using ManageHospitalData;
using ManageHospitalData.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ManageHospitalService.Repositories
{
    interface IHospitalRepository : IRepository<Hospital>
    {

    }

    class MyClass : IHospitalRepository
    {
        private readonly IManageHospitalDBContext _manageHospitalDBContext;

        public MyClass(IManageHospitalDBContext manageHospitalDBContext)
        {
            _manageHospitalDBContext = manageHospitalDBContext;
        }
        public Task<Hospital> AddAsync(Hospital hospital)
        {
            _manageHospitalDBContext.Hospitals.Add(hospital);
            throw new NotImplementedException();
        }

        public Task<Hospital> DeleteAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<List<Hospital>> GetAll()
        {
            return _manageHospitalDBContext.Hospitals.ToListAsync();
        }

        public Task<Hospital> GetAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> IsClanExistsAsync(string clanName)
        {
            throw new NotImplementedException();
        }

        public Task<Hospital> UpdateAsync(Hospital clan)
        {
            throw new NotImplementedException();
        }
    }
}
