using System;
using System.Linq;

namespace CSharp_Basics.Basics
{
    internal class Arrays
    {
        public static void Run()
        {
            // Create array
            int[] nums = { 10, 20, 30, 40, 50 };

            // indexing starts from 0
            // access elements in array using index
            Console.WriteLine(nums[0]);

            // change array element
            nums[2] = 300;

            // find length of array --> number of elements in the array
            Console.WriteLine(nums.Length);


            // other ways to create array:
            // 1. Create array of 4 elements and add elements later
            string[] arr1 = new string[4];

            // 2. Create an array of 4 elements and add values right away
            string[] arr2 = new string[4] { "aman", "raman", "naman", "chaman" };

            // 3. create array of 4 elements without specifying
            int[] arr3 = new int[] { 1, 2, 3, 4 };

            // 4. create array of 4 elements without using new keyword
            double[] arr4 = { 3.41, 98.88, 45.431, 9.884872 };


            // Declare array
            string[] cars;
            // add values, using new
            cars = new string[] { "Volvo", "BMW", "Ford" };


            // Loop through an array
            for (int i = 0; i < cars.Length; i++)
            {
                Console.Write(cars[i] + " ");
            }Console.WriteLine("");

            // foreach loop
            foreach(string name in arr2)
            {
                Console.Write(name + " ");
            }


            // Sort an Array in ascending order
            Array.Sort(cars);
            Console.Write("Sorted cars list: ");
            foreach(string car in cars)
            {
                Console.Write(car + " ");
            }
            Console.WriteLine("");


            /*
                Other imp array methods are found in System.Linq Namespace
                --> Min
                --> Max
                --> Sum
            */
            int[] myNum = new int[5] { 23, 54, 12, 89, 90 };
            int sum = myNum.Sum();
            int maxEle = myNum.Max();
            int minEle = myNum.Min();
            Console.WriteLine("Sum: " + sum);
            Console.WriteLine("Max ele in myNum: " + maxEle);
            Console.WriteLine("Min ele in myNum: " + minEle);
        }
    }
}
