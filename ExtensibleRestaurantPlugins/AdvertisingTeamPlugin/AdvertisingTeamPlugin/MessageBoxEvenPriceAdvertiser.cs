using ExtensibleRestaurant.Api;
using System.Windows.Forms;

namespace AdvertisingTeamPlugin
{
    internal class MessageBoxEvenPriceAdvertiser : IItemAddedObserver
    {
        public void Notify(MenuItem menuItem)
        {
            if (!IsEven(menuItem.Price)) return;

            string advertisement = $"There is a sale on {menuItem.Name}. ${menuItem.Price - 1} instead of ${menuItem.Price}";

            MessageBox.Show(advertisement, "Advertisement Team Plugin");
        }

        private static bool IsEven(int price)
        {
            return price % 2 == 0;
        }
    }
}