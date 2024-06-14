using System;
using System.Collections.Generic;

namespace EmployeeUserControlWPF.Model
{
    public class EmployeeModel
    {
        public int EmployeeId { get; set; }

        public string Name { get; set; }

        public DateTime DOB { get; set; }

        public List<EmployeeDepartmentModel> Departments { get; set; }

        public string Salary { get; set; }

        public EmployeeModel()
        {
            Departments = new List<EmployeeDepartmentModel>();
        }
    }
}