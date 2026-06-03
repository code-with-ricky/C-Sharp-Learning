using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Basics.OOPS.Others
{
    enum Level { 
        LOW,     // 0
        MEDIUM,  // 1
        HIGH     // 2
    }

    internal class EnumsDemo
    {
        public static void Run()
        {
            Level level = Level.MEDIUM;
            Console.WriteLine(level);  // MEDIUM
            Console.WriteLine((int)level);   // enum value

            switch(level)
            {
                case Level.LOW:
                    Console.WriteLine("Low Level");
                    break;

                case Level.MEDIUM:
                    Console.WriteLine("Medium Level");
                    break;

                case Level.HIGH:
                    Console.WriteLine("High Level");
                    break;
            }
        }
    }
}
