using System;

namespace DemoInheritance
{
    class Program : Inheritance
    {
        static void Main(string[] args)
        {
            int add1 = 10;
            int add2 = 10;

            Inheritance newInheritanceClass = new Inheritance();

            int answer = newInheritanceClass.Addition(add1, add2);

            Console.WriteLine("The result of your addition is " + answer);

            Console.ReadLine();
        }
    }
}
