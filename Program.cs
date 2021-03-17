using System;
using System.Threading.Tasks;
using Microsoft.CodeAnalysis.CSharp.Scripting;

namespace ConsoleApp1
{
    internal class Program
    {
        private static async Task Main(string[] args)
        {
            Console.Write("Enter your script:");

            var script = Console.ReadLine();

            try
            {
                var result = await CSharpScript.EvaluateAsync(script);

                Console.WriteLine($"Result={result}");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            Console.WriteLine("Done!");
        }
    }
}
