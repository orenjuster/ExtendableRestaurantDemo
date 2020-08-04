namespace ExtensibleRestaurant.Api
{
    public interface IPluginRegistrater
    {
        void RegisterCustomAction<T>() where T : ICustomAction;

        void RegisterItemAddedObserver<T>() where T : IItemAddedObserver;

        void RegisterMenuItemProvider<T>() where T : IMenuItemProvider;        
    }
}