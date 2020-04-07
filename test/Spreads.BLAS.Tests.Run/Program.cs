using System;
using System.Diagnostics;

namespace Spreads.Tests.Run
{
    internal class ConsoleListener : TraceListener
    {
        public override void Write(string message)
        {
            Console.Write(message);
        }

        public override void WriteLine(string message)
        {
            Console.WriteLine(message);
        }
    }

    internal class Program
    {
        private static unsafe void Main(string[] args)
        {
            var test = new Spreads.Tests.OpenBLASTests();
            test.SgemmBenchmark();
            
            Console.WriteLine();
            Console.WriteLine("Finished, press enter to exit...");
            Console.ReadLine();
        }
    }
}
