namespace Car
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
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


    }
}
