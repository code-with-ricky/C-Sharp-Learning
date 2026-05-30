using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Basics.Basics
{
    internal class Conditionals
    {
        public static void Run()
        {
            // if statement
            int num = 10;
            if (num > 0)
            {
                Console.WriteLine("Positive Number");
            }


            // if-else
            int age = 18;
            if (age >= 18)
            {
                Console.WriteLine("Adult");
            }
            else
            {
                Console.WriteLine("Minor");
            }

            // if else if statement
            if(num > 0)
            {
                Console.WriteLine("Positive Number");
            }else if(num < 0)
            {
                Console.WriteLine("Negative Number");
            }else
            {
                Console.WriteLine("Zero");
            }

            // Ternary operator
            int time = 20;
            string result = time < 18 ? "Good Day." : "Good Evening.";
            Console.WriteLine(result);
        }
    }
}
