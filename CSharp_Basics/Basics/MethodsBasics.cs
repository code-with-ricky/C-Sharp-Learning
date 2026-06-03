using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Basics.Basics
{
    internal class MethodsBasics
    {
        // static -> Class member, so no object needed
        // void -> function doesnot return any value
        static void greetings()
        {
            Console.WriteLine("Hello World");
        }

        // function definition (paramaters passed)
        static void sum(int num1, int num2)
        {
            Console.WriteLine("Sum = " + (num1 + num2));
        }

        // default value of parameters
        static void login(string username = "User")
        {
            Console.WriteLine(username + " is logged in!");
        }

        // return values
        // int return type --> function return int type data
        static int product(int num1, int num2)
        {
            return num1 * num2;
        }

        static void printEmpDetails(string name, string empId, float salary)
        {
            Console.WriteLine("Employee ID: " + empId);
            Console.WriteLine("Employee Name: " + name);
            Console.WriteLine("Salary: " + salary);
        }

        public static void Run()
        {
            // function call
            greetings();
            greetings();

            // function call (passing arguments)
            sum(1, 2);

            login("Amrik");
            login();

            int prod = product(2, 3);
            Console.WriteLine("Product of 2 and 3 = " + prod);

            //Named argument
            printEmpDetails(empId: "INTERN-00671", name: "Amrik Bhadra", salary: 30000);
        }
    }
}
