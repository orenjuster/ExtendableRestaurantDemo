using ExtensibleRestaurant.Api;
using System.Collections.Generic;

namespace ExtensibleRestaurant.Core.Server
{
    public class ExtensibleRestaurantServer
    {
        private IRestaurant _restaurant;

        public ExtensibleRestaurantServer()
        {
            _restaurant = new RestaurantFactory().Create();
        }

        public IEnumerable<MenuItem> GetMenuItems()
        {
            return _restaurant.GetGetMenuItems();
        }

        public IEnumerable<ICustomAction> GetCustomActions()
        {
            return _restaurant.GetCustomActions();
        }

        public void NotifyItemAddedObservers(MenuItem menuItem)
        {
            _restaurant.NotifyItemAddedObservers(menuItem);
        }
    }
}