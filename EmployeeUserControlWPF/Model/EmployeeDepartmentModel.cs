using System.Collections.Generic;
using System.Windows.Documents;

namespace EmployeeUserControlWPF.Model
{
    public class EmployeeDepartmentModel
    {
        public int EmployeeDepartmentId { get; set; }

        public int EmployeeId { get; set; }

        public int DepartmentId { get; set; }

        public EmployeeModel Employee { get; set; }

        public DepartmentModel Department { get; set; }
    }
}
