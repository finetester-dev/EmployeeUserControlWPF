using EmployeeUserControlWPF.DataAccess;
using EmployeeUserControlWPF.Model;
using EmployeeUserControlWPF.Repository.Interface;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace EmployeeUserControlWPF.Repository
{
    public class EFDepartmentRepository : IDepartmentRepository
    {

        private readonly ApplicationDataContext _applicationDataContext;

        public EFDepartmentRepository(ApplicationDataContext applicationDataContext)
        {
            _applicationDataContext = applicationDataContext;
        }

        public async Task AddDepartment(DepartmentModel model)
        {
            await _applicationDataContext.departments.AddAsync(model);
            await _applicationDataContext.SaveChangesAsync();
        }

        public async Task<DepartmentModel?> GetDeparment(int id)
        {
            return await _applicationDataContext.departments.FirstOrDefaultAsync(x => x.DepartmentId == id);
        }

        public async Task<List<DepartmentModel>> GetDeparments()
        {
            return await _applicationDataContext.departments.ToListAsync();
        }
    }
}
