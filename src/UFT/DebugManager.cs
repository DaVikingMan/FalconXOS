using System;
using System.Diagnostics;
using System.IO;
using System.Threading;

namespace src
{
    public class DebugManager // This class is executed when you run the Debug command in the submenu
    {
        public void Debug()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Clear();
            Console.WriteLine("Checking :: "); // Checks if Test.cs exists
            if(File.Exists(@$"{Environment.CurrentDirectory}\debug\Test.cs")) 
            {
                Console.WriteLine("Test.cs Exists"); // Displays this if the file exists

            }else 
            {
                Console.WriteLine("Doesnt exist"); // If the file doesn't exist
            }
            Thread.Sleep(1000);
            Console.WriteLine("This method launches the Test class");
            Console.WriteLine("Add all the classes which you want to run in the test class(Test.cs)(if you want to run an app of a different programming language then you can try the 'Process' method in C#)");
            Console.WriteLine("Running 'Test.cs'");
            
            Thread.Sleep(2000);
            Test test = new Test();
            test.TestMethod();

        }
        public void JsDebug()
        {
            Console.WriteLine("Checking if Test.js exists in 'debug' folder");
            
            var env = $"{Environment.CurrentDirectory}/debug/Test.js";
            Thread.Sleep(2000);
            if(File.Exists(env))
            {
                Console.WriteLine("File Exists : ");
                Console.WriteLine("Starting");
                ProcessStartInfo start = new ProcessStartInfo();
                start.WorkingDirectory = $"{Environment.CurrentDirectory}/debug";
                start.Arguments = $"-c \"node Test.js\" ";
                start.FileName = "/bin/bash";
                start.UseShellExecute = true;
                start.CreateNoWindow = true;
                Process.Start(start);
                var m = new Menu();
                m.MenuMain();
            }
        }
    }
}

