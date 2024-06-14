using EmployeeUserControlWPF.DataAccess;
using EmployeeUserControlWPF.Model;
using EmployeeUserControlWPF.Repository;
using EmployeeUserControlWPF.Repository.Interface;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Configuration;

namespace EmployeeUserControlWPF.ServiceProvider
{
    internal class ServiceProviderHelper
    {
        public static IServiceProvider ServiceProvider { get; private set; }

        public static void ConfigureServices()
        {
            var serviceCollection = new ServiceCollection();

            // Register services, view models, and other dependencies here
            serviceCollection.AddTransient<IDepartmentRepository, EFDepartmentRepository>();
            serviceCollection.AddTransient<IEmployeeRepository, EFEmployeeRepository>();
            serviceCollection.AddSingleton<List<EmployeeModel>>();
            serviceCollection.AddSingleton<List<DepartmentModel>>();
            serviceCollection.AddAutoMapper(typeof(App).Assembly);
            var config = ConfigurationManager.ConnectionStrings["Connection"].ConnectionString;
            serviceCollection.AddDbContext<ApplicationDataContext>(options => options.UseSqlServer(config));

            ServiceProvider = serviceCollection.BuildServiceProvider();
        }
    }
}
