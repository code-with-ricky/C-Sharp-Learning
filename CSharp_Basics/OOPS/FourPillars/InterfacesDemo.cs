using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Basics.OOPS.FourPillars
{
    // An interface is a completely "abstract class", which can only contain abstract methods and properties (with empty bodies)
    // other way to achieve abstraction
    interface IPayment
    {
        void pay();
    }

    class UPIPayment : IPayment
    {
        public void pay()
        {
            Console.WriteLine("Provide UPI id and pin");
        }
    }

    class CardPayment : IPayment
    {
        public void pay()
        {
            Console.WriteLine("Provide Card Number and PIN");
        }
    }

    internal class InterfacesDemo
    {
        public static void Run()
        {
            UPIPayment upi = new UPIPayment();
            CardPayment card = new CardPayment();

            upi.pay();
            card.pay();
        }
    }

    /*
        Note:
        --> interfaces cannot be used to create objects
        --> interface can contain methods and properties but no fields/variables
        --> interface methods are all abstract and no concrete methods
        --> interface members are by default abstract and public
        --> interface cannot have constructor (as it cannot be used to create objects)

        Why to use Interface?
        1. To achieve security - hide certain details and only show the important details of an object (interface).
        2. C# does not support "multiple inheritance" (a class can only inherit from one base class). 
            However, it can be achieved with interfaces, because the class can implement multiple interfaces.
     */
}
