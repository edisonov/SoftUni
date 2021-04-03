using System;
using DependencyInjectionWorkshop.Contracts;
using DependencyInjectionWorkshop.Loggers;

namespace DependencyInjectionWorkshop
{
    class Program
    {
        static void Main(string[] args)
        {
            ILogger logger = new ConsoleLogger();
            Engine engine = new Engine(logger);

            engine.Start();
            engine.End();
        }
    }
}
