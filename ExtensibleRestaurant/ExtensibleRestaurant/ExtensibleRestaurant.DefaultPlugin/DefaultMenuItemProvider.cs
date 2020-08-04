using ExtensibleRestaurant.Api;
using System.Collections.Generic;
using System.Linq;

namespace ExtensibleRestaurant.DefaultPlugin
{
    internal class DefaultMenuItemProvider : IMenuItemProvider
    {
        public IEnumerable<MenuItem> Get()
        {
            return Enumerable.Empty<MenuItem>();
        }
    }
}