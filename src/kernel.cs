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
            Console.Clear();
            
            Console.WriteLine("Type start -oss n to start a Operating Shell session");
            Console.Write(">");
            string commandStart = Console.ReadLine();
            if(commandStart == "start -oss n")
            {
                viOne v = new viOne();
                v.Start();
            }else 
            {
                Console.WriteLine("Wrong command");
                Console.ReadKey();
                KernelMain();
            }
          
        }
    }
}
