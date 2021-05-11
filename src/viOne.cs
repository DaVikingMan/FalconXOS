using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading;

namespace src
{
    // Main class
    class viOne{
        public void Start()
        {
            
                Console.Clear();
                Menu mk = new Menu();
                mk.MenuMain();
        }
          // Command Class
          public void vi()
          {

              Console.ForegroundColor = ConsoleColor.Cyan; // Sets the colour of the text to the colour specified
              
              
                    
                        Console.Clear();
                        
                        Console.WriteLine("Which command do you want to execute?");
                        

                        List<commands> cm = ListManager.Manager();

                        foreach(var m in cm){
                            Console.WriteLine($"{m.command1}\n{m.command2}\n{m.command3}\n{m.command4}\n{m.command5}\n{m.command6}");

                        }
                        Console.Write("> ");
                        string commandRead = Console.ReadLine();
                        
                        
                        if(commandRead == "Exit")
                        {
                            Menu commands = new Menu();
                            commands.MenuMain();
                            
                            



                        }


                        else if(commandRead == "TerminalInfo") // If the user types the following command
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
                        else if(commandRead == "Debug") // Debug command is used for testing your own projects -- for adding your test add it in the test class
                        {
                            DebugMethod();

                        }
                        else if(commandRead == "WritePad")
                        {
                            CommandsAll v = new CommandsAll();
                            v.WriteConsolePad();

                        }else if(commandRead == "Run")
                        {
                            CommandsAll b = new CommandsAll();
                            b.RunCommand();
                        }else
                        {
                            Console.WriteLine("Wrong command");
                            Thread.Sleep(100);
                            viOne v = new viOne();
                            v.vi();
                        }
                        

                        
                        
            
            
                
                  

                  

        }

        public void DebugMethod()
        {
            Thread.Sleep(1000);
            DebugManager manager = new DebugManager();
            manager.Debug();


            

            
        }


    }
}
