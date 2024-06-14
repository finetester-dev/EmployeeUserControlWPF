using EmployeeUserControlWPF.Model;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace EmployeeUserControlWPF.Repository.Interface
{
    public interface IEmployeeRepository
    {
        Task AddEmployee(EmployeeModel model);

        Task<EmployeeModel?> GetEmployee(int id);

        Task<List<EmployeeModel>> GetEmployees();
    }
}
