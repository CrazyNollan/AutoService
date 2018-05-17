using AutoService.Business;
using AutoService.Business.Interfaces;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Windows.Forms;

namespace AutoService.Shell.Forms
{
    public static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        public static void Main()
        {
            IServiceCollection services = new ServiceCollection();
            BusinessStartup.ConfigureServices(services);

            IServiceProvider provider = services.BuildServiceProvider();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new LoginForm(provider.GetService<IUserManager>(), new MainForm(provider.GetService<IAddressManager>(), provider.GetService<IClientManager>(), provider.GetService<IDriverLicenseManager>(),
                                         provider.GetService<IFuelManager>(), provider.GetService<IInspectionManager>(), provider.GetService<ITransportCategoryManager>(),
                                         provider.GetService<ITransportMakeManager>(), provider.GetService<ITransportManager>(), provider.GetService<ITransportModelManager>(),
                                         new AboutForm())));
        }
    }
}