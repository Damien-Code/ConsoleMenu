namespace Car
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car car1 = new Car();
            Car car2 = new Car("Lambo", "Supercar", "Yellow", "me", 2024, 54321);
            
            car1.DisplayInfo();
            car2.DisplayInfo();
            Garage garage = new Garage();
            garage.AddCar(car1);
            garage.AddCar(car2);
            garage.DisplayList();

            Console.WriteLine("Sorted list");
            List<Car> list = new List<Car>();
            garage.SortList();
            
            
            
        }
    }

    class Car
    {
        private string _brand;
        private string _type;
        private string _color;
        private string _owner;
        private int _year;
        private int _vin;

        public Car()
        {
            _brand = "Ferrari";
            _type = "Supercar";
            _color = "red";
            _owner = "me";
            _year = 2025;
            _vin = 12345;
        }
        public Car(string brand, string type, string color, string owner, int year, int vin)
        {
            _brand = brand;
            _type = type;
            _color = color;
            _owner = owner;
            _year = year;
            _vin = vin;
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"Your car: {_brand} \n Your type: {_type} \n The color of your car: {_color} \n The owner: {_owner} \n The buildyear {_year} \n The VIN number {_vin}");
        }


    }

    class Garage
    {

        List<Car> _cars = [];

        public void AddCar(Car car)
        {
            _cars.Add(car);
        }

        public void RemoveCar(Car car)
        {
            _cars.Remove(car);
        }

        public void DisplayList()
        {
            foreach (Car car in _cars)
            {
                car.DisplayInfo();
            }
        }

        // cannot seem to find out the let the sort work
        // Will ask students of teachers for explanation
        public void SortList()
        {
            _cars.Sort();
            foreach (Car car in _cars)
            {
                car.DisplayInfo();
            }
        }
    }
}
