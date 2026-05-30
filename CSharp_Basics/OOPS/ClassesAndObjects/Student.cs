using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Basics.OOPS.ClassesAndObjects
{
    internal class Student
    {   
        // variables inside the class is called Field
        // public is access modifiers
        // public variable can be accessible from outside the Student class also.
        public string studentId;     // field
        public string studentName;   // field
        public string studentBranch; // field

        // member method
        public void DisplayDetails()  // method
        {
            Console.WriteLine("Student Id: " + studentId);
            Console.WriteLine("Student Name: " + studentName);
            Console.WriteLine("Student Branch: " + studentBranch);
        }
    }
}
