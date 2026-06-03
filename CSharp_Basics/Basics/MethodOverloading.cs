using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Basics.Basics
{
    internal class MethodOverloading
    {
        static int area(int x, int y)
        {
            return x * y;
        }

        static double area(double radius)
        {
            return 3.14 * radius * radius;
        }
        public static void Run()
        {
            Console.WriteLine("Area of rectangle with length 5 and breadth 6: " + area(5, 6));
            Console.WriteLine("Area of circle of radius 4: " + area(4));
        }
    }
}
