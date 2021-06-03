using DemoInheritance;
using System;

namespace DemoAbstractClasses
{
    class Program : DemoInheritance.Inheritance
    {
        static void Main(string[] args)
        {
            int add1 = 10;
            int add2 = 10;

            Inheritance newInheritanceClass = new Inheritance();

            int answer = newInheritanceClass.Subtraction(add1, add2);

            Console.WriteLine("The result of your subtraction is " + answer);

            Console.ReadLine();
        }
    }
}
