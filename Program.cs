using static System.Linq.Enumerable;
using System;
using System.Collections.Generic;

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
            var dice = new RandomDieGenerator();
            foreach (var digit in generator.Generate(6))
            {
                // Console.WriteLine(digit);
            }

            var results = new Dictionary<int, int>();
            foreach (var index in Range(1, 6))
            {
                results.Add(index, 0);
            };

            foreach (var index in Range(0, 1000))
            {
                int rolled = dice.Roll();
                results[rolled]++;
            }
            results.Select(i => $"{i.Key}: {i.Value}").ToList().ForEach(Console.WriteLine);
        }
    }
}