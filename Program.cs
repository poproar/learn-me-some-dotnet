using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Text;
using Microsoft.AspNetCore.Blazor.Hosting;
using Microsoft.Extensions.DependencyInjection;
using static System.Linq.Enumerable;
using Generators;
using Blazored.Toast;

namespace learn_me_some_dotnet
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("app");

            builder.Services.AddBlazoredToast();

            await builder.Build().RunAsync();
        }

        static void Old(string[] args)
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

            if (args.Contains("runTest"))
            {
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
}