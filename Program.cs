using System;
namespace LOPVADOITUONG
{
    public class Fan
    {
        public const int SLOW = 1;
        public const int MEDIUM = 2;
        public const int FAST = 3;
        private int speed;
        public int Speed
        {
            get { return speed; }
            set { speed = value; }
        }
        private bool on;
        public bool onOrOff
        {
            get { return on; }
            set { on = value; }
        }
        private double radius;
        public double R
        {
            get { return radius; }
            set { radius = value; }
        }
        private string color;
        public string Color
        {
            get { return color; }
            set { color = value; }
        }
        public Fan()
        {
            speed = SLOW;
            on = false;
            radius = 5;
            color = "blue";
        }
        public string ToString()
        {
            if (on) return $"Speed : {speed}\nColor : {color}\nRadius : {radius}\nFan is on";
            else return $"Color : {color}\nRadius : {radius}\nFan is off";
        }
    }
    public class ThucThiLop
    {
        public static void Main(string[] args)
        {
            Fan fan1 = new Fan();
            fan1.Speed = Fan.FAST;
            fan1.R = 10;
            fan1.Color = "yellow";
            fan1.onOrOff = true;
            Fan fan2 = new Fan();
            fan2.Speed = Fan.MEDIUM;
            Console.WriteLine("Fan 1 :\n" + fan1.ToString());
            Console.WriteLine("Fan 2 :\n" + fan2.ToString());
        }
    }
}