using HiresHoldingsAssesment.Infrasctures;
using HiresHoldingsAssesment.Models;
using HiresHoldingsAssesment.Repositories.Abstractions;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace HiresHoldingsAssesment.Repositories.Implementations
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly AppDataContext _ctx;

        public EmployeeRepository(AppDataContext ctx)
        {
            _ctx = ctx;
        }
        public async Task<bool> AddEmployeeAsync(Employee model)
        {
            await _ctx.Employees.AddAsync(model);
            return await _ctx.SaveChangesAsync() > 1;
        }

        public async Task<List<Employee>> GetEmployeesAsync()
        {
            return await _ctx.Employees.ToListAsync();
        }
    }
}
