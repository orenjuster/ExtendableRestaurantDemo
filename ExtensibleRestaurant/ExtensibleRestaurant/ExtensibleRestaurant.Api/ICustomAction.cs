using System;

namespace ExtensibleRestaurant.Api
{
    public interface ICustomAction
    {
        string Name { get; }

        void Execute(object sender, EventArgs e);
    }
}
