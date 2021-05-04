using System;
using System.Diagnostics.Tracing;
using System.Diagnostics;

namespace src
{
    // This is the first class that loads when you run the program
    class kernel
    {
        public void KernelMain()
        {

            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.Clear(); // Clears the console
            
            Console.WriteLine("Type start -oss n to start a Operating Shell session");
            Console.Write(">");
            string commandStart = Console.ReadLine();
            if(commandStart == "start -oss n") // When the listed command is executed
            {
                viOne v = new viOne();
                v.Start();
            }else  // When the wrong command is executed
            {
                Console.WriteLine("Wrong command");
                Console.ReadKey();
                KernelMain();
            }
          
        }
    }
}
