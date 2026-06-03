using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Basics.Exception_Handling
{
    internal class ThrowDemo
    {
        static void checkAge(int age)
        {
            if (age < 18)
            {
                throw new ArithmeticException("Access denied - You must be atleast 18 years old.");
            }
            else
            {
                Console.WriteLine("Access granted - You are old enough!");
            }
        }
        public static void Run()
        {
            try
            {
                checkAge(20);
            } catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
