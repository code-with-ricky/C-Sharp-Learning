using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Basics.OOPS.ClassesAndObjects
{
    class Car
    {
        public string model;
        public string color;

        // Constructor -->  called when object is created
        // its non parameterised
        // initalises fields with default values
        public Car()
        {
            model = "Mustang";
            color = "Red";
        }

        // create a class constructor with paramter
        public Car(string model, string color)
        {
            this.model = model;
            this.color = color;
        }


        /*
            About Constructors:
            --> must match the class name
            --> cannot have a return type (like void or int etc)
            --> constructor is called when object is created

            --> all classes have a constructors by default if you do not create a class constructor yourself
            --> C# automatically creates it and assign default values to field based on the data type
            --> then you are not able to set the initial values of your own for field
         */
    }
}
