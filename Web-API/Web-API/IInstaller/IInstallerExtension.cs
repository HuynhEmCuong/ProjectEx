using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;
using Web_API.IIstaller;

namespace Web_API.IInstaller
{
    public static class IInstallerExtension
    {
        public static void InstallServicesInAssembly(this IServiceCollection services, IConfiguration configuration)
        {
            var installers = typeof(Startup).Assembly.ExportedTypes.Where(x =>
           typeof(IInstall).IsAssignableFrom(x) && !x.IsInterface && !x.IsAbstract).Select(Activator.CreateInstance).Cast<IInstall>().ToList();
            installers.ForEach(installer => installer.IInstallService(configuration, services));
        }
    }
}
