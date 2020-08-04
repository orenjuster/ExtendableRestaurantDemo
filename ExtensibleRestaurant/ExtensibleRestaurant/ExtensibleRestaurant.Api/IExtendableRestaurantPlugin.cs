namespace ExtensibleRestaurant.Api
{
    public interface IExtendableRestaurantPlugin
    {
        void RegisterPlugins(IPluginRegistrater registrater);
    }
}
