namespace vehicleCatalogue
{
    internal class Program
    {

        public class Truck
        {
            public string Brand { get; set; }

            public string Model { get; set; }

            public int Weight { get; set; }

            public Truck(string brand, string model, int weight)
            {
                Brand = brand;
                Model = model;
                Weight = weight;
            }
        }

        public class Car
        {
            public string Brand { get; set; }

            public string Model { get; set; }

            public int HorsePower { get; set; }

            public Car(string brand, string model, int horsePower)
            {
                Brand = brand;
                Model = model;
                HorsePower = horsePower;
            }
        }

        public class Catalogue
        {
            public List<Car> Cars { get; set; }

            public List<Truck> Trucks { get; set; }

            public Catalogue()
            {
                Cars = new List<Car>();
                Trucks = new List<Truck>();
            }
        }

        static void Main(string[] args)
        {
        
            Catalogue catalogue = new Catalogue();

            while (true)
            {
                string[] input = Console.ReadLine().Split("/");

                string vehicle = input[0];

                if (vehicle == "end")
                {
                    break;
                }

                string brand = input[1];
                string model = input[2];
                int technicalData = int.Parse(input[3]);

                if (vehicle == "Car")
                {
                    Car car = new Car(brand, model, technicalData);
                    catalogue.Cars.Add(car);
                }
                else if (vehicle == "Truck")
                {
                    Truck truck = new Truck(brand, model, technicalData);
                    catalogue.Trucks.Add(truck);
                }

            }

            List<Car> orderedCarList = catalogue.Cars.OrderBy(x => x.Brand).ToList();
            List<Truck> orderedTruckList = catalogue.Trucks.OrderBy(x => x.Brand).ToList();                      
            
            if (orderedCarList.Any())
            {
                Console.WriteLine("Cars:");

                foreach (Car car in orderedCarList)
                {
                    Console.WriteLine($"{car.Brand}: {car.Model} - {car.HorsePower}hp");
                }
            }

            if (orderedTruckList.Any())
            {
                Console.WriteLine("Trucks:");

                foreach (Truck truck in orderedTruckList)
                {
                    Console.WriteLine($"{truck.Brand}: {truck.Model} - {truck.Weight}kg");
                }
            }
        }
    }
}

