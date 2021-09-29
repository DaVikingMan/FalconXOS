using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading;

/*
         This command contains the submenu
*/

namespace src
{
    // Main class
    // Vione is also a component of FalconXOS(codename : 'Old Gin(japanese for 'silver')')
    /*
      It maintains all the things related to FalconXOS's menu.
      Although the main class for viOne doesn't have much code, it is one of the most important.
      ViOne is pronounced as 'We one', as this component's work is not to support to FalconXOS but to unify it so that better communication with other components can be there.
    */
    class viOne{
        public void Start()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            // This is the first method which runs when you open the submenu
                Console.Clear();
                Menu mk = new Menu();
                mk.MenuMain();
        }
          // Command Class
          public void vi()
          {

              Console.ForegroundColor = ConsoleColor.Cyan; // Sets the colour of text to the colour specified
              
              
                    
                        Console.Clear();
                        
                        Console.WriteLine("Which command do you want to execute?");
                        

                        List<commands> cm = ListManager.Manager();

                        foreach(var m in cm){
                            Console.WriteLine($"{m.command1}\n{m.command2}\n{m.command3}\n{m.command4}"); // Lists the command from 'ListManager.cs'

                        }
                        Console.Write("> ");
                        string commandRead = Console.ReadLine();
                        
                        
                        if(commandRead == "Exit")
                        {
                            Menu commands = new Menu();
                            commands.MenuMain();
                            
                            



                        }


                        else if(commandRead == "UFT Info") // If the user types the following command
                        {
                            CommandsAll commands = new CommandsAll();
                            commands.TerminalInfo("");
                            

                        }
                        
                        else if(commandRead == "ListMaker")
                        {
                            CommandsAll commands = new CommandsAll();
                            commands.ListMaker("");
                        }
                        else if(string.IsNullOrWhiteSpace(commandRead))
                        {
                            Console.WriteLine("Kindly input value");
                            Console.ReadKey();
                            vi();
                        }
                        
                        else if(commandRead == "WritePad")
                        {
                            CommandsAll v = new CommandsAll();
                            v.WriteConsolePad();

                        }else
                        {
                            Console.WriteLine("Wrong command");
                            Thread.Sleep(100);
                            viOne v = new viOne();
                            v.vi();
                        }
                        

                        
                        
            
            
                
                  

                  

        }



    }
}
