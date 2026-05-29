using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Basics.Basics
{
    internal class Operators
    {
        public static void Run()
        {
            // Arithematic Operators: +, -, *, /, %, ++, --
            int sum1 = 100 + 50;
            int sum2 = sum1 + 200;
            int sum3 = sum1 + sum2;
            Console.WriteLine("Sum1: " + sum1);
            Console.WriteLine("Sum2: " + sum2);
            Console.WriteLine("Sum3: " + sum3);

            int diff = sum1 - sum2;
            int prod = sum1 * 2;
            int div = sum3 / 4;  // gives quotient
            int remainder = sum3 % 4; // gives remainder

        }
    }
}
