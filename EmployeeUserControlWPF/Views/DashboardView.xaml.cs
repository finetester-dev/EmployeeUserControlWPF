using AutoMapper;
using EmployeeUserControlWPF.Model.ResponseModel;
using EmployeeUserControlWPF.Repository.Interface;
using EmployeeUserControlWPF.ServiceProvider;
using Microsoft.Extensions.DependencyInjection;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace EmployeeUserControlWPF.Views
{
    /// <summary>
    /// Interaction logic for DashboardView.xaml
    /// </summary>
    public partial class DashboardView : UserControl
    {
        private readonly IDepartmentRepository _departmentRepository;
        private readonly IEmployeeRepository _employeeRepository;
        private readonly IMapper _mapper;

        public DashboardView()
        {
            _departmentRepository = ServiceProviderHelper.ServiceProvider.GetRequiredService<IDepartmentRepository>();
            _employeeRepository = ServiceProviderHelper.ServiceProvider.GetRequiredService<IEmployeeRepository>();
            _mapper = ServiceProviderHelper.ServiceProvider.GetRequiredService<IMapper>();
            InitializeComponent();
            SetDataGrid();
        }

        public void SetDataGrid()
        {
            var result = Task.Run(async () => await _departmentRepository.GetDeparments()).GetAwaiter().GetResult();
            GridDepartment.ItemsSource = result;

            var employee = Task.Run(async () => await _employeeRepository.GetEmployees()).GetAwaiter().GetResult();
            GridEmployeeList.ItemsSource = _mapper.Map<List<EmployeeGridDTO>>(employee);
        }
    }
}
