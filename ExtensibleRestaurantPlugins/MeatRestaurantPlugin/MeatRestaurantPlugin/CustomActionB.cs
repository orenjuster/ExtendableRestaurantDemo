using ExtensibleRestaurant.Api;
using System;
using System.Linq;

namespace MeatRestaurantPlugin
{
    class CustomActionB : ICustomAction
    {
        private readonly ILogger _logger;
        private readonly IMenuItemProvider _menuItemProvider;

        public string Name => "Meat Restaurant CustomAction B";

        public CustomActionB(ILogger logger, IMenuItemProvider menuItemProvider)
        {
            _logger = logger;
            _menuItemProvider = menuItemProvider;
        }

        public void Execute(object sender, EventArgs e)
        {
            _logger.Log("Executing CustomAction B !!!!!!");
            _logger.Log(_menuItemProvider.Get().First().ToString());
        }
    }
}