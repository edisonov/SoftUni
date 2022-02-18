using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicWebServer.Server.Common
{
    public interface IServiceCollection
    {
        IServiceCollection Add<TService, TImpementation>()
            where TService : class
            where TImpementation : TService;

        IServiceCollection Add<TService>()
            where TService : class;

        IServiceCollection Get<TService>()
            where TService: class;

        object CreateIstannce(Type serviceType);
    }
}
