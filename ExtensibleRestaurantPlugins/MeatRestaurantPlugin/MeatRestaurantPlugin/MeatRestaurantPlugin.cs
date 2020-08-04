using ExtensibleRestaurant.Api;

namespace MeatRestaurantPlugin
{
    public class MeatRestaurantPlugin : IExtendableRestaurantPlugin
    {
        public void RegisterPlugins(IPluginRegistrater registrater)
        {
            registrater.RegisterMenuItemProvider<MeatRestaurantMenuItemProvider>();
            registrater.RegisterItemAddedObserver<MeatRestaurantItemAddedObserverLogWriter>();
            registrater.RegisterCustomAction<CustomActionA>();
            registrater.RegisterCustomAction<CustomActionB>();
        }
    }
}
