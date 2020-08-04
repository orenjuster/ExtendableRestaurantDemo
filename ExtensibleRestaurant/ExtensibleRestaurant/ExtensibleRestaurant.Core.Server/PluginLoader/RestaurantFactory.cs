using Castle.Windsor;
using Castle.MicroKernel.Registration;
using Castle.MicroKernel.Resolvers.SpecializedResolvers;
using ExtensibleRestaurant.Api;

namespace ExtensibleRestaurant.Core.Server
{
    internal class RestaurantFactory
    {
        public IRestaurant Create()
        {
            var container = new WindsorContainer();
            container.Kernel.Resolver.AddSubResolver(new CollectionResolver(container.Kernel));
            container.Register(Component.For<ILogger>().ImplementedBy<CoreLogger>());
            container.Register(Component.For<IRestaurant>().ImplementedBy<Restaurant>());
            var pluginLoader = new PluginLoader();
            pluginLoader.Load(container);
            return container.Resolve<IRestaurant>();
        }
    }
}
