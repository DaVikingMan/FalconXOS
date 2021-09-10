using System;
using System.Diagnostics.Tracing;
using System.Diagnostics;
using System.Threading;
using System.IO;
using System.Collections.Generic;

/*
            This is the first class that starts when you run FalconXOS
*/

namespace src // Main namespace
{
    
    class Main // Starting class
    {
        public void MainStart() // Main Method
        {
            var signalverify = new SignalVerifier();
                Console.Title = "FalconXOS(UFT)"; // Sets the title
            
            Console.ForegroundColor = ConsoleColor.White; // Sets the colour to the specified colour
            Console.Clear(); // Clears the console
            
            Console.WriteLine("You can see the available commands by running '--help'"); // Run this command if you want to see the all the available commands
            Console.Write(">");
            string readFirstInput = Console.ReadLine(); // Waits for input
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
                Console.WriteLine("--d             Access the changelog         --access(Forward : ch(End))");
                
                Console.Write(">");
            


            string commandStart = Console.ReadLine();
            if(commandStart == "start -uft n" || commandStart == "/start") // This commands goes to the menu
            {
                
                viOne v = new viOne();
                v.Start(); 
            }else if(commandStart == "/command Exit") // This exits the UFT
            {
                Thread.Sleep(1000);

            }else if(commandStart == "/state note") // This goes to the class 'Note' 
            {
                Console.WriteLine("Starting class Note");
                Thread.Sleep(100);
                CommandsAll commandsAll = new CommandsAll();
                commandsAll.Note();
                
            }else if(commandStart == "/skip -debug") // Goes to debug
            {
                DebugManager manager = new DebugManager();
                manager.Debug();
                
            }else if(commandStart == "/skip shortcut") // Goes to shortcut
            {
                Shortcut shortcut = new Shortcut();
                shortcut.ShortcutPage();

            }else if(commandStart == "/skip submenu") // Goes to submenu(viOne.cs)
            {
                viOne v = new viOne();
                v.vi();

            }else if(commandStart == "/start terminal") // Starts powershell
            {
                close closeterminal = new close();
                closeterminal.closeCommand();
                

            }else if(commandStart == "--access ch")
            {
                var mainChangelog = new RunChangelog();
                mainChangelog.MainChangelog();
                MainStart();
            }else if(commandStart == "--dev")
            {
                var runch = new RunChangelog();
                runch.DevChangelog();
                MainStart();
            }
            else if(commandStart == "--internal version" || commandStart == "--i v")
            {
                Console.WriteLine("Version : .16.2-Windows");
                Console.WriteLine("Exiting::");
                Thread.Sleep(5000);
                MainStart();
            }else if(commandStart == "/clear" || commandStart == "--clear" || commandStart == "--sh=clear")
            {
                Console.Clear();
                MainStart();
            }
            
            else  // When the wrong command is executed
            {
                
                var gray = new Errortunnel();
                      gray.AddInfo("/", 20);
                      Console.ReadKey();
                      MainStart();
                Console.ReadKey();
                    MainStart();
                
                
            }
            }else if(readFirstInput == "--howTo") // This command explains how to read '--help' commands
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("start(forward : -uft, End : n)");
                Console.WriteLine("In this the first command is : start, the 'forward' means the next attribute and 'End' means the last attribute of the command");
                Console.WriteLine("Note : sometimes in the 'forward' attribute there will be '(End)'. \nThis means that the 'forward' attribute is also the last attribute");
                Console.WriteLine("Type '/Exit' to close");
                Console.Write(">");
                string gRead = Console.ReadLine();
                if(gRead == "/Exit") // This command is used to exit this command
                {
                    MainStart();
                }else // If the command is wrong
                {
                   var gray = new Errortunnel();
                      gray.AddInfo("/", 20);
                      Console.ReadKey();
                      MainStart();
                Console.ReadKey();
                    MainStart();
                }
            }else if(readFirstInput == "start -uft n" || readFirstInput == "/start") // When the listed command is executed
            {
                
                viOne v = new viOne();
                v.Start();
            }else if(readFirstInput == "/command Exit" || readFirstInput == "/Exit")
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
                

            }else if(readFirstInput == "--access ch")
            {
                var mainChangelog = new RunChangelog();
                mainChangelog.MainChangelog();
                MainStart();
            }else if(readFirstInput == "--dev")
            {
                var runch = new RunChangelog();
                runch.DevChangelog();
                MainStart();
            }
            else if(readFirstInput == "--internal version" || readFirstInput == "--i v")
            {
                Console.WriteLine("Version : .16.2-Windows(Falcon)");
                Console.WriteLine("Exiting::");
                Thread.Sleep(5000);
                MainStart();
            }else if(readFirstInput == "/clear" || readFirstInput == "--clear" || readFirstInput == "--sh=clear")
            {
                Console.Clear();
                MainStart();
            }else if(readFirstInput == "-d info")
            {
                  signalverify.Verify("Request debug info!", 0);
                  Thread.Sleep(2000);
                  Console.WriteLine("Do you want to exit?");
                  string read = Console.ReadLine();
                  if(read == "/exit" || read == "Exit" || read == "exit")
                  {
                      MainStart();
                  }else
                  {
                      var gray = new Errortunnel();
                      gray.AddInfo("/", 20);
                      Console.ReadKey();
                      MainStart();

                  }
            }
            else
            {
                var gray = new Errortunnel();
                      gray.AddInfo("/", 20);
                      Console.ReadKey();
                      MainStart();
                Console.ReadKey();
                    MainStart();
            }
          
        }


            
            

    }
}
