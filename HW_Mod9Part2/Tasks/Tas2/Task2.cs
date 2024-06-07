namespace HW_Mod9Part2
{
    internal class Task2
    {
        public static void Tas2()
        {
            var backpack = new Backpack
            {
                Color = "Black",
                Brand = "Nike",
                Manufacturer = "Nike Inc.",
                Fabric = "Polyester",
                Weight = 1.2,
                Volume = 15.0
            };

            backpack.ItemAdded += (sender, e) =>
            {
                Console.WriteLine($"Item '{e.Item.Name}' added to the backpack.");
            };

            try
            {
                backpack.AddItem(new Item { Name = "Laptop", Volume = 5.0 });
                backpack.AddItem(new Item { Name = "Book", Volume = 1.0 });
                backpack.AddItem(new Item { Name = "Water Bottle", Volume = 2.0 });
                backpack.AddItem(new Item { Name = "Jacket", Volume = 8.0 });
            }
            catch (InvalidOperationException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
