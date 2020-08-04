namespace ExtensibleRestaurant.Api
{
    public interface IItemAddedObserver
    {
        void Notify(MenuItem menuItem);
    }
}
