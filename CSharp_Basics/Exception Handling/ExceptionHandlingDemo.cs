using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Basics.Exception_Handling
{
    internal class ExceptionHandlingDemo
    {
        public static void Run()
        {
            try
            {
                int[] nums = { 10, 20, 40 };
                Console.WriteLine(nums[10]);
            } catch(Exception e)
            {
                Console.WriteLine(e.Message);
            } finally
            {
                Console.WriteLine("This block always execute");
            }
        }
    }
}
