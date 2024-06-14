using EmployeeUserControlWPF.ViewModels;
using EmployeeUserControlWPF.Views;
using System.Windows;

namespace EmployeeUserControlWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            var model = new DashboardViewModel();
            DataContext = model;
        }

        private void Dashboard_Click(object sender, RoutedEventArgs e)
        {
            var model = new DashboardViewModel();
            DataContext = model;
        }

        private void Employee_Click(object sender, RoutedEventArgs e)
        {
            var model = new EmployeeViewModel();
            DataContext = model;
        }

        private void Department_Click(object sender, RoutedEventArgs e)
        {
            var model = new DepartmentViewModel();
            DataContext = model;
        }

        private void ListOfDep_Click(object sender, RoutedEventArgs e)
        {
            var model = new ListDepartmentViewModel();
            DataContext = model;
        }

        private void ListOfEmp_Click(object sender, RoutedEventArgs e)
        {
            var model = new ListEmployeeViewModel();
            DataContext = model;
        }
    }
}
