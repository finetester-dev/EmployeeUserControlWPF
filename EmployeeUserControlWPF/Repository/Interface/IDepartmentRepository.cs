using EmployeeUserControlWPF.Model;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace EmployeeUserControlWPF.Repository.Interface
{
    public interface IDepartmentRepository
    {
        Task AddDepartment(DepartmentModel model);

        Task<DepartmentModel?> GetDeparment(int id);

        Task<List<DepartmentModel>> GetDeparments();
    }
}
