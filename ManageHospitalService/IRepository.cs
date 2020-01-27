using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ManageHospitalService
{

    public interface IRepository<T>
    {
        Task<List<T>> GetAll();
        Task<T> GetAsync(Guid id);
        Task<bool> IsClanExistsAsync(string clanName);
        Task<T> AddAsync(T clan);
        Task<T> UpdateAsync(T clan);
        Task<T> DeleteAsync(Guid id);
    }
}
