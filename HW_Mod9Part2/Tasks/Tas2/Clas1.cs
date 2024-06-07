namespace HW_Mod9Part2
{
    public class Backpack
    {
        public string Color { get; set; }
        public string Brand { get; set; }
        public string Manufacturer { get; set; }
        public string Fabric { get; set; }
        public double Weight { get; set; }
        public double Volume { get; set; }
        public List<Item> Contents { get; private set; }

        public event EventHandler<ItemEventArgs> ItemAdded;

        public Backpack()
        {
            Contents = new List<Item>();
        }

        public void AddItem(Item item)
        {
            double totalVolume = 0;
            foreach (var i in Contents)
            {
                totalVolume += i.Volume;
            }

            if (totalVolume + item.Volume > Volume)
            {
                throw new InvalidOperationException("Adding this item would exceed the backpack's volume.");
            }

            Contents.Add(item);
            ItemAdded?.Invoke(this, new ItemEventArgs { Item = item });
        }
    }
}

