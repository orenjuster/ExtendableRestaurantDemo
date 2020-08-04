using ExtensibleRestaurant.Api;
using System.Runtime.InteropServices;

namespace ExtensibleRestaurant.DefaultPlugin
{
    public class DefaultPlugin : IExtendableRestaurantPlugin
    {
        public void RegisterPlugins(IPluginRegistrater registrater)
        {
            registrater.RegisterMenuItemProvider<DefaultMenuItemProvider>();
            registrater.RegisterItemAddedObserver<DefaultItemAddedObserver>();
            registrater.RegisterCustomAction<DefaultCustomAction>();
        }
    }
}
