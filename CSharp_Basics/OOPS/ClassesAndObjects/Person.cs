using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Basics.OOPS.ClassesAndObjects
{
    class Person
    {
        /*
            Encapsulation:
            --> make sure, sensitive data is hidden from users
            --> to achieve it:
                --> declare fields/variables as private
                --> provide public get and set methods, through properties, to access and update the value of a private field


            Property:
            --> combination of a variable and a method
            --> it has two methods: get and set
         */
        private string name; // field

        public string Name  // property
        {
            // returns value of the variable
            get { return name; }  // get method (getter)

            // value keyword represents value we assign to the property
            set { name = value; } // set method (setter)
        }


        // short hand -> automatic properties
        public int Age { get; set; }
    }
}
