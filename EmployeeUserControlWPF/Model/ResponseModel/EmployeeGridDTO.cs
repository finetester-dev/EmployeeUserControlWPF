using System.Collections.Generic;
using System;

namespace EmployeeUserControlWPF.Model.ResponseModel
{
    public class EmployeeGridDTO
    {
        public int EmployeeId { get; set; }

        public string Name { get; set; }

        public DateTime DOB { get; set; }

        public string Departments { get; set; }

        public string Salary { get; set; }
    }
}
