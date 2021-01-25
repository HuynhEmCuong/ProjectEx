using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Web_API.IIstaller
{
    public interface IInstall
    {
        void IInstallService (IConfiguration configuration, IServiceCollection services);
    }
}
