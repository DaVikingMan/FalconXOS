using System;
using System.Threading;

namespace src{
    class Menu
    {
        public void MenuMain() // TerminalXOS's Menu
        {
            
            Console.Clear(); // Clears the console
            Console.ForegroundColor = ConsoleColor.Cyan; // Sets the foregrounColor
            Console.WriteLine("Apps and other commands(type Apps for running this command)");
            Console.WriteLine("Shortcuts");
            Console.WriteLine("Debug");
            Console.WriteLine("Terminal");
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
                     Console.WriteLine("Wrong command");
                     Thread.Sleep(100);
                     MenuMain();
                 }

            }else if(y == "Exit") // When executing the 'Exit' command
            {
                
                Thread.Sleep(1000);
            }else if(y == "Project Manager")
            {
               Utility m = new Utility();
               
               m.VirtualUtility();    
            }else if(y == "/close menu")
            {
                Main k = new Main();
                k.MainStart();
            }else if(y == "Debug")
            {
                  var debug = new DebugManager();
                  debug.Debug(); 
            }else if(y == "--help")
            {
                Console.WriteLine("Mode                Description                       Command\n\n");
                Console.WriteLine("--s             Starts UFT                   /close(forward : menu(End))");
               
            }
            
            else{                                    // When the wrong command is executed
                Console.WriteLine("Wrong command");
                Thread.Sleep(100);
                MenuMain();
            }
        }
    }

    
}