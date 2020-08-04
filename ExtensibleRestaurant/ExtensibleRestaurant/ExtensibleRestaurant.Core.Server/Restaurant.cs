using ExtensibleRestaurant.Api;
using System.Collections.Generic;

namespace ExtensibleRestaurant.Core.Server
{
    class Restaurant : IRestaurant
    {
        private readonly IEnumerable<ICustomAction> _customActions;
        private readonly IMenuItemProvider _menuItemProvider;
        private readonly IEnumerable<IItemAddedObserver> _itemAddedObservers;

        public Restaurant(IEnumerable<ICustomAction> customActions, IMenuItemProvider menuItemProvider, IEnumerable<IItemAddedObserver> itemAddedObservers)
        {
            _customActions = customActions;
            _menuItemProvider = menuItemProvider;
            _itemAddedObservers = itemAddedObservers;
        }

        public IEnumerable<ICustomAction> GetCustomActions()
        {
            return _customActions;
        }

        public IEnumerable<MenuItem> GetGetMenuItems()
        {
            return _menuItemProvider.Get();
        }

        public void NotifyItemAddedObservers(MenuItem menuItem)
        {
            foreach (var observer in _itemAddedObservers)
                observer.Notify(menuItem);
        }
    }
}
