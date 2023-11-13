using System.Numerics;

namespace HelloWorld2023b
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            for (var i = 0; i <args.Length; i++) {
                Console.WriteLine(args[i]);
            }
        }
    }
}