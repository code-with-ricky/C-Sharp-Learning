using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Basics.Basics
{
    internal class UserInput
    {
        public static void Run()
        {
            Console.Write("Enter username: ");

            // Create a string variable and get user input from the keyboard and store it in the variable
            string username = Console.ReadLine();

            Console.WriteLine("Username is: " + username);


            // NOTE: Console.ReadLine() --> returns string type
            // so if you want to take integer, double or any other type value input
            // then you have to explicity typecast it from string
            Console.Write("Enter age: ");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Age: " + age);
        }
    }
}
