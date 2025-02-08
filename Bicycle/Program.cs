using System.Reflection.Metadata.Ecma335;

namespace Bicycle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Bicycle bicycle1 = new Bicycle(LockType.U_lock, Color.Red, 56, Bike.Normal, 100);
            Console.WriteLine(bicycle1.Print());
        }
    }

    enum Bike
    {
        Normal,
        Electric
    }

    enum LockType
    {
        None,
        Chain,
        Frame,
        U_lock
    }

    enum Color
    {
        Black,
        Red,
        Blue,
        Yellow,
        Grey
    }

    class Bicycle
    {
        private LockType _lock;
        private Color _color;
        private Bike _bike;
        private int _frameHeight;
        private string _status = "Locked";
        private double _range = 0;

        public LockType Lock { get => _lock; set => _lock = value; }
        public Color Color { get => _color; set => _color = value; }
        public Bike Bike { get => _bike; set => _bike = value; }
        public int FrameHeight { get => _frameHeight; }
        public string Status { get => _status; set => _status = value; }
        public double Range { get => _range; set => _range = value; }
        public double RangeMiles { get => _range * 0.621_371_192; }

        public Bicycle()
        {
            _lock = LockType.None;
            _color = Color.Red;
            _bike = Bike.Normal;
            _frameHeight = 56;
            _range = 100;
        }

        public Bicycle(LockType lockType, Color color, int FrameHeight, Bike bike, double range)
        {
            _lock = lockType;
            _color = color;
            _frameHeight = FrameHeight;
            _bike = bike;
            _range = range;

        }

        public void LockBike()
        {
            Status = "Locked";
        }

        public void UnlockBike()
        {
            Status = "Unlocked";
        }

        public string Print()
        {
            return $"Your bike has the following specifications:\n Locktype: {Lock} \n Color: {Color} \n Frameheight: {FrameHeight} \n Type of bike: {Bike} \n The range of your bike: {Range} km, and in miles {RangeMiles} miles \n and your bike is {Status}!";
        }
    }

}

