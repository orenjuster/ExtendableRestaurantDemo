using ExtensibleRestaurant.Api;
using System.Collections.Generic;

namespace ExtensibleRestaurant.Core.Server
{
    interface IRestaurant
    {
        IEnumerable<MenuItem> GetGetMenuItems();

        IEnumerable<ICustomAction> GetCustomActions();

        void NotifyItemAddedObservers(MenuItem menuItem);
    }
}
