using System;

namespace Hello
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length > 0)
            {
                Console.WriteLine($"{args[0]} learn about 'fwd-i-search'!");
            }
            else
            {
                Console.WriteLine("Console WriteLine will not run in new class");
                Console.WriteLine("and template used dir name as namespace, REMEMBER");

            }

            var generator = new FibonacciGenerator();
            foreach (var digit in generator.Generate(15))
            {
                Console.WriteLine(digit);
            }
        }
    }
}