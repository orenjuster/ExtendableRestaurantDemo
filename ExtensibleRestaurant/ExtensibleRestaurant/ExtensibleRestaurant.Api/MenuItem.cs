namespace ExtensibleRestaurant.Api
{
    public class MenuItem
    {
        public string Name { get; }

        public int Price { get; }
        
        public MenuItem(string name, int price)
        {
            Name = name;
            Price = price;
        }

        public override string ToString()
        {
            return $"{Name} - {Price}";
        }
    }
}