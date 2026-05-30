using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Basics.Basics
{
    internal class MultiDimensionalArray
    {
        public static void Run()
        {
            // 2D array
            int[,] twoDimArray = { { 1, 2, 3 }, { 4, 5, 6 } };  // rows = 2, columns = 3

            // accesing 2D array element
            // array_name[row_index,col_index]
            Console.WriteLine(twoDimArray[0,2]);

            // change array element
            twoDimArray[1, 0] = 40;

            // Loop through 2D array
            foreach(int i in twoDimArray)
            {
                Console.WriteLine(i);
            }

            // other way of looping
            for(int i = 0; i < twoDimArray.GetLength(0); i++)
            {
                for(int j = 0; j < twoDimArray.GetLength(1); j++)
                {
                    Console.Write(twoDimArray.GetValue(i, j) + " "); // or twoDimArray[i,j]
                }
                Console.WriteLine();
            }


            // 3D array
            int[,,] threeDimArray = { { { 1, 2, 3 }, { 4, 5, 6 }, { 6, 7, 8 } } };
        }
    }
}
