using System;
using Isen.DotNet.Library;

namespace Isen.DotNet.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var world = Hello.World;
            Console.WriteLine(world);
            var greet = Hello.Greet("Kall");
            Console.WriteLine(greet);
            var greetUpper = Hello.GreetUpper("Kall");
            Console.WriteLine(greetUpper);
        }
    }
}
