using System;
using System.Diagnostics.Tracing;
using System.Diagnostics;
using System.Threading;
using System.IO;


namespace src // Main namespace
{
    
    class Main // Starting class
    {
        public void MainStart() // Main Method
        {
            
                Console.Title = "FalconXOS"; // Sets the title
            
            Console.ForegroundColor = ConsoleColor.White; // Sets the colour to the specified colour
            Console.Clear(); // Clears the console
            
            
            Console.Write(">");
            string readFirstInput = Console.ReadLine();
            if(readFirstInput == "--help")  // If the command is '--help'
            {
                
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Mode                Description                       Command\n\n");
                Console.WriteLine("--s             Starts UFT                   start(forward : -uft, End : n)");
                Console.WriteLine("--d             Exits the UFT                /command(forward : Exit(End))");
                Console.WriteLine("--d             Go to 'note'                 /state(Forward : note(End))");
                Console.WriteLine("--d             Skip to debug                /skip(Forward : -debug(End))");
                Console.WriteLine("--d             Skip to 'shortcut'           /skip(Forward : shortcut(End))");
                Console.WriteLine("--d             Skip to submenu              /skip(Forward : submenu(End))");
                Console.WriteLine("--d             Start Terminal(Powershell)   /start(Forward : terminal(End))");
                
                Console.Write(">");
            


            string commandStart = Console.ReadLine();
            if(commandStart == "start -uft n") // When the listed command is executed
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

            }else if(commandStart == "/start terminal")
            {
                close closeterminal = new close();
                closeterminal.closeCommand();
                

            }
            
            else  // When the wrong command is executed
            {
                Console.WriteLine("Wrong command");
                Thread.Sleep(100); // Waits for 100 milliseconds
                MainStart();
            }
            }else if(readFirstInput == "--howTo")
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("start(forward : -uft, End : n)");
                Console.WriteLine("In this the first command is : start, the 'forward' means the next attribute and 'End' means the last attribute of the command");
                Console.WriteLine("Note : sometimes in the 'forward' attribute there will be '(End)'. \nThis means that the 'forward' attribute is also the last attribute");
                Console.WriteLine("Type '/Exit' to close");
                Console.Write(">");
                string gRead = Console.ReadLine();
                if(gRead == "/Exit")
                {
                    MainStart();
                }else
                {
                    Console.WriteLine("wrong command");
                    Thread.Sleep(100);
                    MainStart();
                }
            }else if(readFirstInput == "start -uft n") // When the listed command is executed
            {
                
                viOne v = new viOne();
                v.Start();
            }else if(readFirstInput == "/command Exit")
            {
                Thread.Sleep(1000);

            }else if(readFirstInput == "/state note")
            {
                Console.WriteLine("Starting class Note");
                Thread.Sleep(100);
                CommandsAll commandsAll = new CommandsAll();
                commandsAll.Note();
                
            }else if(readFirstInput == "/skip -debug")
            {
                DebugManager manager = new DebugManager();
                manager.Debug();
                
            }else if(readFirstInput == "/skip shortcut")
            {
                Shortcut shortcut = new Shortcut();
                shortcut.ShortcutPage();

            }else if(readFirstInput == "/skip submenu")
            {
                viOne v = new viOne();
                v.vi();

            }else if(readFirstInput == "start /terminal")
            {
                close closeterminal = new close();
                closeterminal.closeCommand();
                

            }
            else
            {
                Console.WriteLine("Wrong command");
                Thread.Sleep(100);
                MainStart();
            }
          
        }


            
            

    }
}
