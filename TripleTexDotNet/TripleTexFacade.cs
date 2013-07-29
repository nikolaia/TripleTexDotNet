using System.Reflection;
using Autofac;
using TripleTexDotNet.Interfaces;
using TripleTexDotNet.Services;

namespace TripleTexDotNet
{
    public class TripleTexFacade : ITripleTexFacade
    {
        private readonly int _syncSystem;
        private readonly string _syncPassword;
        private readonly string _username;
        private readonly string _password;
        private readonly IContainer _container;
        
        public TripleTexFacade(int syncSystem, string syncPassword, string username, string password)
        {
            _syncSystem = syncSystem;
            _syncPassword = syncPassword;
            _username = username;
            _password = password;

            // Setup IoC and DI
            var builder = new ContainerBuilder();

            // The JsonService keeps the session cookie and has to have one instance per lifetime
            builder.RegisterType<JsonService>().As<IJsonService>().InstancePerLifetimeScope();

            //builder.RegisterAssemblyTypes()
            //       .Where(r => r.Name.EndsWith("Service"))
            //       .AsImplementedInterfaces();

            builder.RegisterType<SyncService>().As<ISyncService>();
            builder.RegisterType<CompanyService>().As<ICompanyService>();
            builder.RegisterType<OrderService>().As<IOrderService>();
            builder.RegisterType<ProductService>().As<IProductService>();

            _container = builder.Build();

            // Login
            _container.Resolve<ISyncService>().Login(_syncSystem, _syncPassword, _username, _password);
        }

        public ICompanyService GetCompanyService()
        {
            return _container.Resolve<ICompanyService>();
        }

        public IOrderService GetOrderService()
        {
            return _container.Resolve<IOrderService>();
        }

        public IProductService GetProductService()
        {
            return _container.Resolve<IProductService>();
        }

        public void Dispose()
        {
            _container.Resolve<ISyncService>().Logout();
        }
    }
}
