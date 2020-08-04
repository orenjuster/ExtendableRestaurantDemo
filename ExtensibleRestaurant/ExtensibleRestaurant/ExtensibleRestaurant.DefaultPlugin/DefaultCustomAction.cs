using ExtensibleRestaurant.Api;
using System;

namespace ExtensibleRestaurant.DefaultPlugin
{
    internal class DefaultCustomAction : ICustomAction
    {
        public string Name => "Default";

        public void Execute(object sender, EventArgs e)
        {
            
        }
    }
}