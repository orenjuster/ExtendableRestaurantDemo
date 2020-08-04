using ExtensibleRestaurant.Api;
using System;

namespace MeatRestaurantPlugin
{
    internal class MeatRestaurantItemAddedObserverLogWriter : IItemAddedObserver
    {
        private readonly ILogger _logger;

        public MeatRestaurantItemAddedObserverLogWriter(ILogger logger)
        {
            _logger = logger;
        }
        public void Notify(MenuItem menuItem)
        {
            _logger.Log($"[{DateTime.Now}] Menu item added {menuItem}");
        }
    }
}