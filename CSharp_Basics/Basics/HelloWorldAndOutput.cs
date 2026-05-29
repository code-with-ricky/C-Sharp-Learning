using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Basics.Basics
{
    internal class HelloWorldAndOutput
    {
        public static void Run()
        {
            // Console is class of the System namespace
            // Console has a WriteLine() method -> used to output/print
            Console.WriteLine("Hello World! Welcome to Journey of C#");

            // if removed using System;  then we have to write as below:
            // System.Console.WriteLine("Hello World");


            // Write() method --> same as WriteLine() just not insert a new line at end of the output
            Console.Write("Sentence 1");
            Console.Write("Sentence 2");
            Console.WriteLine("");

            // C# comments
            // Single line comments
            /* 
                This is a multi line comment
                can add more than one line etc
             */
        }
    }
}
