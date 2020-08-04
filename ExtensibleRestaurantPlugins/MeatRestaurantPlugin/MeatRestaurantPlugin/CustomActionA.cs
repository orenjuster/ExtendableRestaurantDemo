using ExtensibleRestaurant.Api;
using System;

namespace MeatRestaurantPlugin
{
    class CustomActionA : ICustomAction
    {
        private readonly ILogger _logger;

        public string Name => "Meat Restaurant CustomAction A";

        public CustomActionA(ILogger logger)
        {
            _logger = logger;
        }        

        public void Execute(object sender, EventArgs e)
        {
            _logger.Log("Executing CustomAction A !!!!!!");
        }
    }
}