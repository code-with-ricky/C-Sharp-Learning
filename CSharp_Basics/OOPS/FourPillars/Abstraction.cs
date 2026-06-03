using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Basics.OOPS.FourPillars
{
    /*
        --> Data abstraction is the process of hiding certain details and showing only essential information to the user.
        --> Abstraction can be achieved with either abstract classes or interfaces

        --> The abstract keyword is used for classes and methods:
            --> Abstract class: is a restricted class that cannot be used to create objects (to access it, it must be inherited from another class).
            --> Abstract method: can only be used in an abstract class, and it does not have a body. The body is provided by the derived class (inherited from).
     */
    // abstract class -> class which contains atleast one abstract method
    abstract class Animal2
    {
        // abstract method -> which has only declaration and no method body
        // method body must be defined by the deried classes
        public abstract void animalSound();
        public void sleep()
        {
            Console.WriteLine("Zzz");
        }
    }
        
    class Cat : Animal2
    {
        public override void animalSound()
        {
            Console.WriteLine("Meow");
        }
    }

    class Lion : Animal2
    {
        public override void animalSound()
        {
            Console.WriteLine("Roar");
        }
    }

    internal class Abstraction
    {
        public static void Run()
        {
            //Animal2 lion = new Lion();  // this gives error as Animal2 is abstract class and we cannot create instance of abstract class
            Lion lion = new Lion();
            Cat cat = new Cat();

            lion.animalSound();
            cat.animalSound();
        }
    }
}
