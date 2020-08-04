using Castle.Windsor;
using Castle.MicroKernel.Registration;
using ExtensibleRestaurant.Api;

namespace ExtensibleRestaurant.Core.Server
{
    class CastleWindsorRegistrar : IPluginRegistrater
    {
        private readonly WindsorContainer _windsorContainer;

        public CastleWindsorRegistrar(WindsorContainer windsorContainer)
        {
            _windsorContainer = windsorContainer;
        }

        public void RegisterCustomAction<T>() where T : ICustomAction
        {
            _windsorContainer.Register(Component.For<ICustomAction>().ImplementedBy<T>());
        }

        public void RegisterItemAddedObserver<T>() where T : IItemAddedObserver
        {
            _windsorContainer.Register(Component.For<IItemAddedObserver>().ImplementedBy<T>());
        }

        public void RegisterMenuItemProvider<T>() where T : IMenuItemProvider
        {
            _windsorContainer.Register(Component.For<IMenuItemProvider>().ImplementedBy<T>());
        }
    }
}