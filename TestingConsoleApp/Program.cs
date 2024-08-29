using Ga.Personal.BackgroundTasks.ClassLibrary;
using System;
using System.Configuration;

namespace Ga.Personal.BackgroundTasks.TestingConsoleApp
{
    internal class Program
    {
        static void Main()
        {
            var s = ConfigurationManager.ConnectionStrings["BackgroundTasksConnectionString"].ConnectionString;
            Console.WriteLine($"s: {s}");
            Console.ReadKey();
        }
    }
}
