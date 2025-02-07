using System.Reflection.Metadata.Ecma335;

namespace Bicycle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Bicycle bicycle1 = new Bicycle(LockType.U_lock, Color.Red, 56);
            Console.WriteLine(bicycle1.Print());
        }
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
        private int _frameHeight;
        private string _status = "Locked";

        public LockType Lock { get => _lock; set => _lock = value; }
        public Color Color { get => _color; set => _color = value; }
        public int FrameHeight { get => _frameHeight; }
        public string Status { get => _status; set => _status = value; }

        public Bicycle()
        {
            _lock = LockType.None;
            _color = Color.Red;
            _frameHeight = 56;
        }

        public Bicycle(LockType lockType, Color color, int FrameHeight)
        {
            _lock = lockType;
            _color = color;
            _frameHeight = FrameHeight;
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
            return $"Your bike has the following specifications: Locktype: {Lock} \n Color: {Color} \n Frameheight: {FrameHeight} \n and your bike is {Status}";
        }
    }

}

