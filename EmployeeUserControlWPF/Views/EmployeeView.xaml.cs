using EmployeeUserControlWPF.Model;
using EmployeeUserControlWPF.Repository.Interface;
using EmployeeUserControlWPF.ServiceProvider;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace EmployeeUserControlWPF.Views
{
    /// <summary>
    /// Interaction logic for EmployeeView.xaml
    /// </summary>
    public partial class EmployeeView : UserControl
    {
        private readonly IEmployeeRepository _employeeRepository;
        private readonly IDepartmentRepository _departmentRepository;

        public EmployeeView()
        {
            InitializeComponent();
            _employeeRepository = ServiceProviderHelper.ServiceProvider.GetRequiredService<IEmployeeRepository>();
            _departmentRepository = ServiceProviderHelper.ServiceProvider.GetRequiredService<IDepartmentRepository>();

            SetDepartmentData();
        }

        private void btnSubmit_Click(object sender, RoutedEventArgs e)
        {
            var name = txtName.Text;
            var dob = dpDob.Text;
            var salary = ltSalary.Text;
            var department = (DepartmentModel)ltDepartment.SelectedItem;

            EmployeeModel employeeModel = new EmployeeModel()
            {
                Name = name,
                DOB = DateTime.Parse(dob),
                Salary = salary,
                Departments = new List<EmployeeDepartmentModel>
                {
                    new EmployeeDepartmentModel
                    {
                        DepartmentId = department.DepartmentId
                    }
                }
            };

            _employeeRepository.AddEmployee(employeeModel);
            MessageBox.Show("Data Added Successfully");
            ClearExistingData();
        }

        private void ClearExistingData()
        {
            txtName.Text = "";
            dpDob.Text = "";
            ltSalary.Text = "";
            ltDepartment.SelectedIndex = -1;
        }

        private void SetDepartmentData()
        {
            var departments = Task.Run(async () => await _departmentRepository.GetDeparments()).GetAwaiter().GetResult();

            ltDepartment.DisplayMemberPath = "Name";
            ltDepartment.SelectedValuePath = "Id";
            ltDepartment.ItemsSource = departments;
            ltDepartment.SelectedIndex = -1;
        }
    }
}