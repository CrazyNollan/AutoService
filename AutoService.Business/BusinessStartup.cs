using AutoService.Business.Database.Table.Managers;
using AutoService.Business.Interfaces;
using AutoService.Data;
using Microsoft.Extensions.DependencyInjection;

namespace AutoService.Business
{
    public static class BusinessStartup
    {
        public static void ConfigureServices(IServiceCollection services)
        {
            DataStartup.ConfigureServices(services, "Server=(localdb)\\MSSQLLocalDB;Database=AutoService;Integrated Security=true;");

            services.AddTransient<IUserManager, UserManager>(sp => new UserManager(sp.GetService<DatabaseContext>()));
            services.AddTransient<IAddressManager, AddressManager>(sp => new AddressManager(sp.GetService<DatabaseContext>()));
            services.AddTransient<IClientManager, ClientManager>(sp => new ClientManager(sp.GetService<DatabaseContext>()));
            services.AddTransient<IDriverLicenseManager, DriverLicenseManager>(sp => new DriverLicenseManager(sp.GetService<DatabaseContext>()));
            services.AddTransient<IFuelManager, FuelManager>(sp => new FuelManager(sp.GetService<DatabaseContext>()));
            services.AddTransient<IInspectionManager, InspectionManager>(sp => new InspectionManager(sp.GetService<DatabaseContext>()));
            services.AddTransient<ITransportCategoryManager, TransportCategoryManager>(sp => new TransportCategoryManager(sp.GetService<DatabaseContext>()));
            services.AddTransient<ITransportMakeManager, TransportMakeManager>(sp => new TransportMakeManager(sp.GetService<DatabaseContext>()));
            services.AddTransient<ITransportManager, TransportManager>(sp => new TransportManager(sp.GetService<DatabaseContext>()));
            services.AddTransient<ITransportModelManager, TransportModelManager>(sp => new TransportModelManager(sp.GetService<DatabaseContext>()));
        }
    }
}