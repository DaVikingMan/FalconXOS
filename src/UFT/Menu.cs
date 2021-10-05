using System;
using System.Threading;
using System.Diagnostics;

namespace src{
    class Menu
    {
        public void MenuMain() // FalconXOS's Menu
        {
            var componentinteractor = new ComponentInteractor();
            var sendsignal = new SignalVerifier();
            
            
            Console.Clear(); // Clears the console
            Console.ForegroundColor = ConsoleColor.Cyan; // Sets the foregrounColor
            
            
            Console.WriteLine("Apps and other commands(type Apps for running this command)");
            Console.WriteLine("Shortcuts");
            Console.WriteLine("Debug.cs");
            Console.WriteLine("Debug.js");
            Console.WriteLine("QuickRun('run')");
            Console.WriteLine("Terminal(default)");
            Console.WriteLine("Project Manager");
            Console.WriteLine("Exit");
            Console.Write(">");
            string y = Console.ReadLine();
            if(y == "Apps") // When executimg the 'Apps' command
            {
                viOne b = new viOne();
                b.vi();

            }else if(y == "Shortcuts") // When executing the 'Shortcuts' command
            {
                Shortcut s = new Shortcut();
                s.ShortcutPage();
            }else if(y == "Terminal") // When executing the 'Terminal' command
            {
                 TerminalKernel l = new TerminalKernel();
                 l.TerminalHandler();
                 Thread.Sleep(100);
                 Console.WriteLine("Type Exit");
                 Console.Write(">");
                 string v = Console.ReadLine();
                 if(v == "Exit")
                 {
                     MenuMain();
                 }else
                 {
                     var gray = new Errortunnel();
                     gray.CheckInfo("/", 20, "None");
                     MenuMain();
                 }

            }else if(y == "Exit" || y == "exit" || y == "/Exit" || y == "/exit") // When executing the 'Exit' command
            {
                
                componentinteractor.MainInteractor("Exit!", "/", 0);
            }else if(y == "Project Manager")
            {
               Utility m = new Utility();
               
               m.VirtualUtility();    
            }else if(y == "/close menu")
            {
                Main k = new Main();
                k.MainStart();
            }else if(y == "Debug.cs")
            {
                  var debug = new DebugManager();
                  debug.Debug(); 
            }else if(y == "Debug.js")
            {
                var d = new DebugManager();
                d.JsDebug();
                
            }
            else if(y == "--help")
            {
                Console.WriteLine("Description                       Command\n\n");
                Console.WriteLine("Goes back to the Main Menu     /close(forward : menu(End))");
               
            }else if(y == "run")
            {
               var run = new QuickRun();
               run.QuickRunMethod();   
            }else if(y == "--access ch" || y == "-=sh=oldch") 
            {
                componentinteractor.MainInteractor("Access Changelog!", "/", 0);
                MenuMain();
            }else if(y == "--dev")
            {
                componentinteractor.MainInteractor("Dev Changelog!", "/", 0);
                MenuMain();
            }
            else if(y == "--internal version" || y == "--i v")
            {
                var signalreceiver = new SignalReceiver();
                componentinteractor.MainInteractor("Give version!", "/", 0);
                MenuMain();
            }else if(y == "/clear" || y == "--clear" || y == "--sh=clear")
            {
                Console.Clear();
                MenuMain();
            }else if(y == "-d info")
            {
                componentinteractor.MainInteractor("Request debug info!", "/", 0);
                MenuMain();
                
            
            }
            
            
            else{                                    // When the wrong command is executed
                var gray = new Errortunnel();
                gray.CheckInfo("/", 20, "None");
                
                MenuMain();
            }
        }
    }

    
}
