using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Basics.OOPS.ClassesAndObjects
{
    internal class ClassesAndObjectDemo
    {
        public static void Run()
        {
            Student s1 = new Student();
            s1.studentId = "S101";
            s1.studentName = "Amrik Bhadra";
            s1.studentBranch = "Computer Engineering";
            s1.DisplayDetails();


            // Constructors file --> Car.cs
            Car car = new Car(); // Create an object of the Car Class (this will call the constructor)
            Console.WriteLine("Car Model: " + car.model);
            Console.WriteLine("Car Color: " + car.color);

            Car car2 = new Car("BMW", "M5");
            Console.WriteLine("Car Model: " + car2.model);
            Console.WriteLine("Car Color: " + car2.color);


            /*
                Access Modifiers:  (used to control the visibility of class members)
                1. public --> code is accessible for all classes
                2. private --> code is accessible within the same class
                3. protected --> code is accessible within the same class, or in a class that is inherited from that class
                4. internal --> code is accessible only within its own assembly, but nor from another assembly

                There are two combinations:
                1. protected internal
                2. private protected
             */

            // Encapsulation
            Person person = new Person();
            person.Name = "Amrik"; // set value to property
            person.Age = 23;
            Console.WriteLine(person.Name + " is of age " + person.Age); // get value to property


            // Inheritance
            Vehicle v = new Vehicle();
            Bike b = new Bike();
            v.honk(); // call the honk method in the vehicle class
            b.honk(); // call the honk method from obtained from vehicle class
        }
    }
}
