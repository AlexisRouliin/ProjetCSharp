using System;
using ISEN.DotNet.Library;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var greet = Hello.Greet("wesh");
            Console.WriteLine(greet);
            var greetUpper = Hello.GreetUpper("Kall");
            Console.WriteLine(greetUpper);
        }
    }
}
