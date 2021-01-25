using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Web_API.IIstaller;
using Web_API.Service.Interface;
using Web_API.Service.Service;

namespace Web_API.IInstaller
{
    public class ServiceInstaller : IInstall
    {
        public void IInstallService(IConfiguration configuration, IServiceCollection services)
        {
            //Service
            services.AddScoped<IUserService, UserService>();
            services.AddScoped<IBuildingService, BuildingService>();
            services.AddScoped<IPDCService, PDCService>();

        }
    }
}
