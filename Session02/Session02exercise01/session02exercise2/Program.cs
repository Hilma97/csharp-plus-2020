using System;

namespace session02exercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("do you want to enter your name? (y/n)?");
            var key = Console.ReadKey();

            if (key.KeyChar == 'n')
                return;

            Console.WriteLine("Enter your name:");
            var name = Console.ReadLine();

            Console.WriteLine("Hello, " + name);
            Console.ReadKey();

        }
    }
}
