using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Basics.OOPS.ClassesAndObjects
{
    /*
        Inheritance: 
        --> useful for code reusability
        --> reuse fields and methods of an existing class when your create a new class
        
        We have Parent and Chid class

        sealed class --> class which cannot be inherited
   
     */


    // Parent class (base class)
    class Vehicle
    {
        public string brand = "Kawasaki";  // Vehicle field
        public void honk() // Vehicle method
        {
            Console.WriteLine("Tuut, tuut!");
        }
    }

    // Child class (derieved class)
    class Bike : Vehicle
    {
        public string modelName = "ZX10R"; // Bike field
    }
}
