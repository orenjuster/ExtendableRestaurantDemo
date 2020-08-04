using ExtensibleRestaurant.Api;

namespace AdvertisingTeamPlugin
{
    public class AdvertisingTeamPlugin : IExtendableRestaurantPlugin
    {
        public void RegisterPlugins(IPluginRegistrater registrater)
        {
            registrater.RegisterItemAddedObserver<MessageBoxEvenPriceAdvertiser>();
        }
    }
}
