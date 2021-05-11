using System;
using System.Diagnostics;
using System.IO;
using System.Threading;

namespace src
{
    public class DebugManager
    {
        public void Debug()
        {
            Console.Clear();
            Console.WriteLine("Checking :: ");
            if(File.Exists(@$"{Environment.CurrentDirectory}\src\Test.cs"))
            {
                Console.WriteLine("'Test.cs' Exists");

            }else 
            {
                Console.WriteLine("Doesnt exist");
            }
            Thread.Sleep(1000);
            Console.WriteLine("This method launches the Test class");
            Console.WriteLine("Add all the classes which you want to run in the test class(if you want to run an app of a different programming language then you can try the 'Process' method in C#)");
            Console.WriteLine("Initializing and building 'Test.cs'");
            Thread.Sleep(2000);
            Test test = new Test();
            test.TestMethod();

        }
    }
}