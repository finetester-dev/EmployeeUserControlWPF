using EmployeeUserControlWPF.Repository.Interface;
using EmployeeUserControlWPF.ServiceProvider;
using Microsoft.Extensions.DependencyInjection;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace EmployeeUserControlWPF.Views
{
    /// <summary>
    /// Interaction logic for ListDepartmentView.xaml
    /// </summary>
    public partial class ListDepartmentView : UserControl
    {
        private readonly IDepartmentRepository _departmentRepository;
        public ListDepartmentView()
        {
            _departmentRepository = ServiceProviderHelper.ServiceProvider.GetRequiredService<IDepartmentRepository>();
            InitializeComponent();
            SetGridData();
        }

        private void SetGridData()
        {
            var result = Task.Run(async () => await _departmentRepository.GetDeparments()).GetAwaiter().GetResult();
            GridDepartment.ItemsSource = result;
        }
    }
}
