using Ga.Personal.BackgroundTasks.ClassLibrary;
using System;

namespace Ga.Personal.BackgroundTasks.TestingConsoleApp
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine(
                Configuration
                    .GetConnectionStringByName("Ga.Personal.BackgroundTasks.TestingConsoleApp.ConnectionStringName1") ?? "null"
            );

            Console.ReadKey();
        }
    }
}
