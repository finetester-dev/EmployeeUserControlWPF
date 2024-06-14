using EmployeeUserControlWPF.DataAccess;
using EmployeeUserControlWPF.Model;
using EmployeeUserControlWPF.Repository.Interface;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace EmployeeUserControlWPF.Repository
{
    public class EFEmployeeRepository : IEmployeeRepository
    {
        private readonly ApplicationDataContext _applicationDataContext;

        public EFEmployeeRepository(ApplicationDataContext applicationDataContext)
        {
            _applicationDataContext = applicationDataContext;
        }

        public async Task AddEmployee(EmployeeModel model)
        {
            await _applicationDataContext.AddAsync(model);
            await _applicationDataContext.SaveChangesAsync();
        }

        public async Task<EmployeeModel?> GetEmployee(int id)
        {
            return await _applicationDataContext.employees.FirstOrDefaultAsync(x => x.EmployeeId == id);
        }

        public async Task<List<EmployeeModel>> GetEmployees()
        {
            var result = await _applicationDataContext.employees.Include(x => x.Departments).ToListAsync();

            return result;
        }
    }
}