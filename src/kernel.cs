using System;
using System.Diagnostics.Tracing;
using System.Diagnostics;

namespace Classes
{
    // This is the first class that loads when you run the program
    class kernel
    {
        public void KernelMain()
        {
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.Clear();
            Console.WriteLine("Welcome to a new version of TerminalX");
            Console.WriteLine("Do you want to read about TerminalX and its features?");
            Console.Write("> ");
            var c = Console.ReadLine();
            if(c == "Yes")
            {
                
                CommandsAll cp = new CommandsAll();
                cp.Note();

            }else if(c == "No")
            {
                ReKernel l = new ReKernel();
                l.Rek();

            }
                
            else{ 
                Console.WriteLine("wrong expression");
                Console.ReadKey();
                kernel k = new kernel();
                k.KernelMain();
            }
               
        }
    }
}
