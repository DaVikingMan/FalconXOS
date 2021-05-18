using System;
using System.Diagnostics.Tracing;
using System.Diagnostics;
using System.Threading;

namespace src // Main namespace
{
    
    class kernel // Starting class
    {
        public void KernelMain() // Main class
        {
            Console.Title = "TerminalXOS"; // Sets the title

            Console.ForegroundColor = ConsoleColor.DarkCyan; // Sets the colour to the specified colour
            Console.Clear(); // Clears the console
            
            Console.WriteLine("Type start -oss n to start the Operating Shell");
            Console.Write(">");
            string commandStart = Console.ReadLine();
            if(commandStart == "start -oss n") // When the listed command is executed
            {
                
                viOne v = new viOne();
                v.Start();
            }else if(commandStart == "/command Exit")
            {
                Thread.Sleep(1000);

            }else if(commandStart == "/state note")
            {
                Console.WriteLine("Starting class Note");
                Thread.Sleep(100);
                CommandsAll commandsAll = new CommandsAll();
                commandsAll.Note();
                
            }else if(commandStart == "/skip -debug")
            {
                DebugManager manager = new DebugManager();
                manager.Debug();
                
            }else if(commandStart == "/skip shortcut")
            {
                Shortcut shortcut = new Shortcut();
                shortcut.ShortcutPage();

            }else if(commandStart == "/skip submenu")
            {
                viOne v = new viOne();
                v.vi();

            }else if(commandStart == "start /terminal")
            {
                close closeterminal = new close();
                closeterminal.closeCommand();
                

            }
            
            else  // When the wrong command is executed
            {
                Console.WriteLine("Wrong command");
                Thread.Sleep(100); // Waits for 100 milliseconds
                KernelMain();
            }
          
        }
    }
}
