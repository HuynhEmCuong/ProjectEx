using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Web_API.IIstaller;
using Web_API.Models;
using Web_API.Repository;

namespace Web_API.IInstaller
{
    public class RepositoryInstaller : IInstall
    {
        public void IInstallService(IConfiguration configuration, IServiceCollection services)
        {

            //Repository
            services.AddScoped<IRepository<User>, Repository<User>>();
            services.AddScoped<IRepository<Building>, Repository<Building>>();
            services.AddScoped<IRepository<PDC>, Repository<PDC>>();
        }
    }
}
