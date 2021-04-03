using System.IO;
using System;
using DependencyInjectionWorkshop.Contracts;

namespace DependencyInjectionWorkshop.Loggers
{
    public class FileLogger : ILogger
    {
        public void Log(string message)
        {
            using (StreamWriter write = new StreamWriter
                ("../../../logs.txt", true))
            {
                write.WriteLine(message);
            }
        }
    }
}