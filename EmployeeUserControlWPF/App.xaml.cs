using EmployeeUserControlWPF.ServiceProvider;
using Microsoft.Extensions.DependencyInjection;
using System.Windows;

namespace EmployeeUserControlWPF
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);

            ServiceProviderHelper.ConfigureServices();


            //var mainWindow = ServiceProviderHelper.ServiceProvider.GetRequiredService<MainWindow>();
            //mainWindow.Show();
        }
    }
}
