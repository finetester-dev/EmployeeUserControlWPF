using System.Collections.Generic;
using System.Windows.Documents;

namespace EmployeeUserControlWPF.Model
{
    public class DepartmentModel
    {
        public int DepartmentId { get; set; }

        public string Name { get; set; }

        public List<EmployeeDepartmentModel> Employees { get; set; }

        public DepartmentModel()
        {
            Employees = new List<EmployeeDepartmentModel>();
        }
    }
}
