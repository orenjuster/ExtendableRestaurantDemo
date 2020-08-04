using System.Collections.Generic;

namespace ExtensibleRestaurant.Api
{
    public interface IMenuItemProvider
    {
        IEnumerable<MenuItem> Get();
    }
}