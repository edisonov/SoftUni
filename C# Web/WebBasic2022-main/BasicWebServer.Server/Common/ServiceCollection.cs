using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicWebServer.Server.Common
{
    public class ServiceCollection : IServiceCollection
    {
        private readonly Dictionary<Type, Type> services;

        public ServiceCollection()
        {
            services = new Dictionary<Type, Type>();
        }

        public IServiceCollection Add<TService, TImpementation>()
            where TService : class
            where TImpementation : TService
        {
            services[typeof(TService)] = typeof(TImpementation);

            return this;
        }

        public IServiceCollection Add<TService>() 
            where TService : class
        {
            return Add<TService, TService>();
        }

        public object CreateIstannce(Type serviceType)
        {
            if (services.ContainsKey(serviceType))
            {
                serviceType = services[serviceType];
            }
            else if (serviceType.IsInterface)
            {
                throw new InvalidOperationException($"Service {serviceType.FullName} is not registered");
            }

            var constructors = serviceType.GetConstructors();

            if (constructors.Length > 1)
            {
                throw new InvalidOperationException("Multiple constructors are not supported");
            }

            var constructor = constructors[0];
            var parameters = constructor.GetParameters();
            var parameterValues = new object[parameters.Length];

            for (int i = 0; i < parameterValues.Length; i++)
            {
                var parameterType = parameters[i].ParameterType;
                var parameterValue = CreateIstannce(parameterType);

                parameterValues[i] = parameterValue;
            }

            return constructor.Invoke(parameterValues);
        }

        public IServiceCollection Get<TService>()
            where TService : class
        {
            var serviceType = typeof(TService);

            if (!services.ContainsKey(serviceType))
            {
                return null;
            }

            var service = services[serviceType];

            return (IServiceCollection)CreateIstannce(service);
        }
    }
}
