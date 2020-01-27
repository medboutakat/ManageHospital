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

    class HospitalRepository: IHospitalRepository
    {
        private readonly IManageHospitalDBContext _manageHospitalDBContext;

        public HospitalRepository(IManageHospitalDBContext manageHospitalDBContext)
        {
            _manageHospitalDBContext = manageHospitalDBContext;
        }
        public Task<Hospital> AddAsync(Hospital hospital)
        {
            _manageHospitalDBContext.Hospitals.Add(hospital);

            return Task.FromResult(hospital);
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
