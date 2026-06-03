using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Basics.OOPS.FourPillars
{
    class Animal
    {
        public virtual void makeSound()
        {
            Console.WriteLine("Animal makes sound");
        }
    }

    class Pig : Animal
    {
        public override void makeSound()
        {
            Console.WriteLine("Pig make sound!");
        }
    }

    class Dog : Animal
    {
        public override void makeSound()
        {
            Console.WriteLine("Dog make sound");
        }
    }

    internal class Polymorphism
    {
        public static void Run()
        {
            Animal animal = new Animal();
            Animal pig = new Pig();
            Animal dog = new Dog();

            animal.makeSound();
            pig.makeSound();
            dog.makeSound();

            /*
                Note:
                --> if in base class method virtual keyword and in in the derived class methods override 
                    keyword is not used then the base class method overrides the derived class methods 
                    and the output of the base class will only be obtained for each

                --> therefore for method overiding use virtual and override keywords
             */
        }
    }
}
