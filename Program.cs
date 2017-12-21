using System;

namespace extensionmethods
{
    class Program
    {
        static void Main(string[] args)
        {
            mathematics obj = new mathematics();
            Console.WriteLine("From AN, Hello World!");
            Console.WriteLine("The output for addition is: " + obj.addition(1,2) );
            System.Console.WriteLine("The output for subtraction is: "+obj.subtraction(1,2));
            Console.ReadLine();
        }
    }
}
