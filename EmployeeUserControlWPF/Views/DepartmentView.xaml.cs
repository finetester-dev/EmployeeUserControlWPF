using EmployeeUserControlWPF.Model;
using EmployeeUserControlWPF.Repository.Interface;
using EmployeeUserControlWPF.ServiceProvider;
using Microsoft.Extensions.DependencyInjection;
using System.Windows;
using System.Windows.Controls;

namespace EmployeeUserControlWPF.Views
{
    /// <summary>
    /// Interaction logic for DepartmentView.xaml
    /// </summary>
    public partial class DepartmentView : UserControl
    {
        private readonly IDepartmentRepository _departmentRepository;
        public DepartmentView()
        {
            InitializeComponent();
            _departmentRepository = ServiceProviderHelper.ServiceProvider.GetRequiredService<IDepartmentRepository>();
        }

        private void btnSubmit_Click(object sender, RoutedEventArgs e)
        {
            var name = tbName.Text;

            var department = new DepartmentModel { Name = name };
            _departmentRepository.AddDepartment(department);

            MessageBox.Show("Data Added Successfully");
            
            ClearExistingData();
        }

        private void ClearExistingData()
        {
            tbName.Clear();
        }
    }
}