using System;
using System.Collections.Generic;
using System.Diagnostics.SymbolStore;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Basics.Basics
{
    internal class VariablesAndDataType
    {
        /*
           Variables: containers for storing data, having some name
           Following are data types:
           1. int:
               --> stores whole numbers
               --> without decimals
               --> both positive and negative. Example 123 or -123
               --> Size: 4 bytes
               --> Stores whole numbers from -2,147,483,648 to 2,147,483,647

           2. long:
                --> stores large whole numbers
                --> size: 8 bytes
                --> Stores whole numbers from -9,223,372,036,854,775,808 to 9,223,372,036,854,775,807

            3. float:
                --> size: 4 bytes
                --> Stores fractional numbers. Sufficient for storing 6 to 7 decimal digits
           
            4. double:
               --> stores floating point numbers
               --> with decimals
               --> positive and negative both
               --> example: 19.88 or -19.45
               --> Size: 8 bytes
               --> Stores fractional numbers. Sufficient for storing 15 decimal digits

           3. char:
               --> stores single characters
               --> values surrounded by single quotes
               --> example: 'a' or 'B' etc
               --> Size: 2 bytes

           4. string:
               --> stores text, such as "Hello World"
               --> values surrounded by double quotes
               --> Size: 2 bytes per character

           5. bool:
               --> stores two states
               --> true or false
               --> Size: 1 byte
        */

        /* 
            Declaring (Creating) variables
            type variableName = value;
         */
        public static void Run()
        {
            int myNum = 20;
            Console.WriteLine(myNum);

            double price;
            price = 23.52;
            Console.WriteLine("Price: " + price);

            myNum = 45; // myNum is now 45
            Console.WriteLine(myNum);

            char gender = 'M';
            Console.WriteLine(gender);

            bool isAdult = false;
            Console.WriteLine(isAdult);

            string myFavBook = "Phsycology of Money";
            Console.WriteLine(myFavBook);

            /*
                C# Constants:
                --> const keyword is used
                --> value of variable cannot be changed once a value is assigned
                --> Note: const field requires a value to be provided
             */
            const double PI = 3.14;
            //const double eulerNumber; // cant leave it like this


            /*
                C# Multiple Variables declaration (of same data type)
             */
            int x = 5, y = 6, z = 50;
            Console.WriteLine(x + y + z);

            int a, b, c;
            a = b = c = 50;
            Console.WriteLine(a + b + c);

            /*
                C# Identifiers:
                --> All C# variables must be identified with unique names.
                --> These unique names are called identifiers.
             */

            /*
                General Rules of naming variables:
                --> Names can contain letters, digits and the underscore character (_)
                --> Names must begin with a letter or underscore
                --> Names should start with a lowercase letter, and cannot contain whitespace
                --> Names are case-sensitive ("myVar" and "myvar" are different variables)
                --> Reserved words (like C# keywords, such as int or double) cannot be used as names
             */

            /*
                C# Type Casting:
                
                1. Implicit Casting (automatically)
                    --> smaller type to larger type size
                    --> char --> int --> long --> float --> double

                2. Explicit Casting (manually)
                    --> larger type to a smaller size type
                    --> double -> float -> long -> int -> char
             */

            int myInt = 9;
            double myDouble = myInt;  // Automatic casting: int to double; Implicit casting

            Console.WriteLine(myInt);      // Outputs 9
            Console.WriteLine(myDouble);   // Outputs 9

            double myDouble2 = 9.79;
            int myInt2 = (int) myDouble2; // Manual casting: double to int; Explicit Casting

            Console.WriteLine(myDouble);   // Outputs 9.78
            Console.WriteLine(myInt);      // Outputs 9

            /* 
                Type Conversion Methods (built in methods):
                --> Convert.ToBoolean
                --> Convert.ToDouble
                --> Convert.ToString
                --> Convert.ToInt32 (int)
                --> Convert.ToInt64 (long)

             */
            int myInt3 = 10;
            double myDouble3 = 5.25;
            bool myBool = true;

            Console.WriteLine(Convert.ToString(myInt3));    // convert int to string
            Console.WriteLine(Convert.ToDouble(myInt3));    // convert int to double
            Console.WriteLine(Convert.ToInt32(myDouble3));  // convert double to int
            Console.WriteLine(Convert.ToString(myBool));   // convert bool to string
        }
    }
}
