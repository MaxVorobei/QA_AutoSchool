using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Points
{
    class Program
    {
        static void Main()
        {

            Point dot1 = new Point();
            dot1.RandomCoordinates();
            Console.WriteLine(dot1.GetInfo());


            Point dot2 = new Point();
            dot2.RandomCoordinates();
            Console.WriteLine(dot2.GetInfo());

            static double BetweenLength(Point dot1, Point dot2)
            {
                return Math.Sqrt(Math.Pow(dot2.x - dot1.x, 2) + Math.Pow(dot2.y - dot1.y, 2));
            }
            Console.WriteLine(BetweenLength(dot1, dot2));
        }
    }
}
