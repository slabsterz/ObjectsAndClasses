namespace storeBoxes
{
    internal class Program
    {

        public class Item
        {
            public string Name { get; set; }

            public decimal Price { get; set; }

            public Item(string name, decimal price)
            {
                Name = name;
                Price = price;
            }

        }

        public class  Box 
        {
            public string SerialNumber { get ; set; }

            public Item Item { get; set; }

            public int Quantity { get; set; }

            public decimal PriceForABox { get; set; }

            public Box(string serialNumber, Item item, int quantity)
            {
                SerialNumber = serialNumber;
                Item = item;
                Quantity = quantity;               
                PriceForABox = quantity * item.Price;
            }
        }
        static void Main(string[] args)
        {
            List<Box> boxes = new List<Box>();  

            while (true)
            {
                string[] input = Console.ReadLine().Split();

                string serialNumber = input[0];

                if (serialNumber == "end")
                {
                    break;
                }

                string itemName = input[1];
                int quantity = int.Parse(input[2]);
                decimal priceItem = decimal.Parse(input[3]);

                Item item = new Item(itemName, priceItem);
                Box box = new Box(serialNumber, item, quantity);

                boxes.Add(box);
            }

            List<Box> descending = boxes.OrderByDescending(x => x.PriceForABox).ToList();

            foreach (Box box in descending)
            {
                Console.WriteLine($"{box.SerialNumber}");
                Console.WriteLine($"-- {box.Item.Name} - ${box.Item.Price:F2}: {box.Quantity}");
                Console.WriteLine($"-- ${box.PriceForABox:F2}");
            }
        }
    }
}