using HiresHoldingsAssesment.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace HiresHoldingsAssesment.Repositories.Abstractions
{
    public interface IEmployeeRepository
    {
        public Task<bool> AddEmployeeAsync(Employee model);
        public Task<List<Employee>> GetEmployeesAsync();
    }
}
