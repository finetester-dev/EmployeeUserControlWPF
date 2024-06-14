using EmployeeUserControlWPF.Model;
using EmployeeUserControlWPF.Repository.Interface;
using System.Collections.Generic;
using System.Linq;

namespace EmployeeUserControlWPF.Repository
{
    public class DepartmentRepository //: IDepartmentRepository
    {
        private readonly List<DepartmentModel> _departmentModels;

        public DepartmentRepository(List<DepartmentModel> departments)
        {
            _departmentModels = departments;
        }

        public void AddDepartment(DepartmentModel model)
        {
            model.DepartmentId = _departmentModels.Count + 1;

            _departmentModels.Add(model);
        }

        public DepartmentModel? GetDeparment(int id)
        {
            return _departmentModels.FirstOrDefault(x => x.DepartmentId == id);
        }

        public List<DepartmentModel> GetDeparments()
        {
            return _departmentModels;
        }
    }
}
