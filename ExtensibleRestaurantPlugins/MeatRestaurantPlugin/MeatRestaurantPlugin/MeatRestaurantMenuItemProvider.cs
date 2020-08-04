using ExtensibleRestaurant.Api;
using System.Collections.Generic;

namespace MeatRestaurantPlugin
{
    internal class MeatRestaurantMenuItemProvider : IMenuItemProvider
    {
        public IEnumerable<MenuItem> Get()
        {
            yield return new MenuItem("Steak", 4);
            yield return new MenuItem("Chicken", 11);
            yield return new MenuItem("Vegan Mushroom burger", 10);
            yield return new MenuItem("Pork", 9);
            yield return new MenuItem("Duck", 20);
            yield return new MenuItem("Cat", 33);
            yield return new MenuItem("Fried Spider", 18);
            yield return new MenuItem("Bacon", 17);
            yield return new MenuItem("Person", 72);
        }
    }
}