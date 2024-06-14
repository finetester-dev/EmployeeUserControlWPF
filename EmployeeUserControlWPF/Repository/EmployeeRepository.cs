using EmployeeUserControlWPF.Model;
using EmployeeUserControlWPF.Repository.Interface;
using System.Collections.Generic;
using System.Linq;

namespace EmployeeUserControlWPF.Repository
{
    public class EmployeeRepository //: IEmployeeRepository
    {
        private readonly List<EmployeeModel> _employeeModels;

        public EmployeeRepository(List<EmployeeModel> employees)
        {
            _employeeModels = employees;
        }

        public void AddEmployee(EmployeeModel model)
        {
            model.EmployeeId= _employeeModels.Count + 1;
            _employeeModels.Add(model);
        }

        public EmployeeModel? GetEmployee(int id)
        {
            return _employeeModels.FirstOrDefault(x => x.EmployeeId == id);
        }

        public List<EmployeeModel> GetEmployees()
        {
            return _employeeModels;
        }
    }
}
