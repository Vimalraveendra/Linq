using System;

namespace Linq
{
    class Program
    {

        static string getName()
        {
            return "John";
        }
        static void printName()
        {
            var name = getName();
            Console.WriteLine(name);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            printName();
        }
    }
}
