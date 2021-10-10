using System;
using System.Diagnostics;
using System.Threading;
using System.Collections.Generic;

/*
            This is the first class that Program.cs starts when you run FalconXOS
*/



namespace src // Main namespace(this includes all the compoents and everything in the src folder(basicallly all the files that are programmed in C#))
{
    
    
    class Main // Starting class
    {
         
        public void MainStart() // Main Method
        {
            var componentInteractor = new ComponentInteractor();
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
                Console.WriteLine("Description                       Command\n\n");
                Console.WriteLine("Starts UFT                   start(forward : -uft, End : n)");
                Console.WriteLine("Exits the UFT                /command(forward : Exit(End))");
                Console.WriteLine("Go to 'note'                 /state(Forward : note(End))");
                Console.WriteLine("Skip to debug                /skip(Forward : -debug(End))");
                Console.WriteLine("Skip to 'shortcut'           /skip(Forward : shortcut(End))");
                Console.WriteLine("Skip to submenu              /skip(Forward : submenu(End))");
                Console.WriteLine("Start Terminal(Powershell)   /start(Forward : terminal(End))");
                Console.WriteLine("Access the changelog         --access(Forward : ch(End))");
                
                Console.Write(">");
            


            Boolean devstatus = false;
            string commandStart = Console.ReadLine();
            if(commandStart == "--devmode" || commandStart == "-sh=developer" || commandStart == "-sh=dev")
            {
                   devstatus = true;
            }

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
                


            }else if(commandStart == "--access ch" || commandStart == "-sh=oldch")
            {
                componentInteractor.MainInteractor("Access Changelog!", "/", 0);
                MainStart();
            }else if(commandStart == "--runch" || commandStart == "-sh=ch") 

            {
                componentInteractor.MainInteractor("Dev Changelog!", "/", 0);
                MainStart();
            }
            else if(commandStart == "--internal version" || commandStart == "--i v")
            {
                var signalreceiver = new SignalReceiver();
                componentInteractor.MainInteractor("Give version!", "/", 0);
                MainStart();
            }else if(commandStart == "/clear" || commandStart == "--clear" || commandStart == "--sh=clear")
            {
                Console.Clear();
                MainStart();
            }else if(commandStart == "-d info")
            {
                  var signalreceiver = new SignalReceiver();
                  componentInteractor.MainInteractor("Request debug info!", "/", 0); // For now error-handling is manual, as you have to add the errornum for the error. In the next release, the error-handling should be automatic
                  MainStart();

            }else if(commandStart == "--devconsole")
            {
                   var devconsole = new dev.DevConsole();
                   devconsole.MainConsole();

            }
            
            else  // When the wrong command is executed
            {
                
                var gray = new Errortunnel();
                      gray.CheckInfo("/", 20, "None");
                      
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
                      gray.CheckInfo("/", 20, "None");
                      
                      MainStart();
                
                }
            }else if(readFirstInput == "start -uft n" || readFirstInput == "/start" || readFirstInput == "/Start" || readFirstInput == "/Menu") // When the listed command is executed
            {
                
                viOne v = new viOne();
                v.Start();
            }else if(readFirstInput == "/command Exit" || readFirstInput == "/Exit")
            {
                var zero = new ZeroSignal();
                signalverify.Verify("Exit!");

            }else if(readFirstInput == "/state note")
            {

                Console.WriteLine("Starting FalconXOS Note");

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
                


            }else if(readFirstInput == "--access ch" || readFirstInput == "-sh=oldch")
            {
                componentInteractor.MainInteractor("Access Changelog!", "/", 0);
                MainStart();
            }else if(readFirstInput == "--runch" || readFirstInput == "-sh=ch")

            {
                componentInteractor.MainInteractor("Dev Changelog!", "/", 0);
                MainStart();
            }

            else if(readFirstInput == "--internal version" || readFirstInput == "--i v" || readFirstInput == "version")

            {
                
                componentInteractor.MainInteractor("Give version!", "/", 0);
                MainStart();
            }else if(readFirstInput == "/clear" || readFirstInput == "--clear" || readFirstInput == "--sh=clear")
            {
                Console.Clear();
                MainStart();
            }else if(readFirstInput == "-d info")
            {
                  var signalreceiver = new SignalReceiver();
                  signalreceiver.sendsignal("Request debug info!", "/", 0);
                  Thread.Sleep(2000);
                  Console.WriteLine("\nDo you want to exit?");
                  string read = Console.ReadLine();
                  if(read == "/exit" || read == "Exit" || read == "exit")
                  {
                      MainStart();
                  }else
                  {
                      var errorinteractor = new ErrorInteractor();
                      errorinteractor.VerifyError("/", 20, "None");
                      
                      MainStart();

                  }

            }else if(readFirstInput == "--devconsole")
            {
                   var devconsole = new dev.DevConsole();
                   devconsole.MainConsole();
            } 

            else
            {
                var gray = new Errortunnel();
                      gray.CheckInfo("/", 20, "None");
                     
                      MainStart();
                
            }
          
        }


            
            

    }
}
