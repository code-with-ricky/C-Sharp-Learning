using System;
using System.IO;

namespace CSharp_Basics.File_Handling
{
    internal class FileHandlingDemo
    {
        public static void Run()
        {
            string text = "Hello World";
            File.WriteAllText("myfile.txt", text); // create file and write content in it

            string readText = File.ReadAllText("myfile.txt");
            Console.WriteLine(readText);
        }
    }
}
