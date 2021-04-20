using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace Classes
{
    // Main class
    class viOne{
        public void Start()
        {
            Console.Clear();
            DateTime date = DateTime.Now;
                        Console.WriteLine(date);
                        Console.ReadKey();
                        
                        Console.WriteLine("Welcome to the main system!");
                        Console.WriteLine("Kindly write your name : ");
                        Console.Write("> ");
                        string name = Console.ReadLine();
                        if(string.IsNullOrWhiteSpace(name)){
                            Console.WriteLine("Kindly input name");
                            Console.ReadKey();
                            Start();
                        }
                        
                        Console.Clear();
                        Console.WriteLine(name  + " huh?");
                        Console.ReadKey();
                        Console.WriteLine("Do you want to the command screen?");
                        Console.Write("> ");
                        string ans = Console.ReadLine();
                        if(ans == "Yes")
                        {
                            // Opens the command screen
                            vi();
                        }else if(ans == "No") // If the User says No
                        {
                            Start();
                        }else if(string.IsNullOrWhiteSpace(ans)) // If the user doesn't input anything
                        {
                            Console.WriteLine("Kindly give Input");
                            Console.ReadKey();
                            Start();
                        }
        }
          // Command Class
          public void vi()
          {

              Console.ForegroundColor = ConsoleColor.Cyan;
              
              
                    
                        Console.Clear();
                        
                        Console.WriteLine("Which command do you want to execute?");
                        

                        List<commands> cm = ListManager.Manager();

                        foreach(var m in cm){
                            Console.WriteLine($"{m.command1}\n{m.command2}\n{m.command3}\n{m.command4}\nDebug\nWritePad");

                        }
                        Console.Write("> ");
                        string commandRead = Console.ReadLine();
                        
                        
                        if(commandRead == "Exit")
                        {
                            CommandsAll commands = new CommandsAll();
                            commands.Exit("");
                            
                            



                        }


                        else if(commandRead == "TerminalInfo") // If the user types the following command
                        {
                            CommandsAll commands = new CommandsAll();
                            commands.TerminalInfo("");
                            

                        }
                        else if(commandRead == "Games")
                        {
                            CommandsAll commands = new CommandsAll();
                            commands.Games("");
                            

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
                        else if(commandRead == "Debug") // TheDebug command is used to go to a certain class(Not completed)
                        {
                            DebugMethod();

                        }
                        else if(commandRead == "WritePad")
                        {
                            CommandsAll v = new CommandsAll();
                            v.WriteConsolePad();

                        }

                        
                        
            
            
                
                  

                  

        }

        private void DebugMethod()
        {
            Console.WriteLine("The debug is used to view Debug info");
            Console.Clear();
            Console.WriteLine("Name Info : NAN(return 0),Value(return 1),Special Name : (return +10)");
            Console.WriteLine("CommandRead  : NAN(return), Value(1-5)");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("Do you want to open Alpha builds or open different states?");
            Console.WriteLine("Type Alpha for Alpha builds or States for opening states");
            string ans = Console.ReadLine();
            if (ans == "Alpha")
            {
                ProcessHandler handler = new ProcessHandler();
                handler.ProcessHandle();
                Console.ReadKey();
                Console.WriteLine("Do you want to exit?");
                string ansd = Console.ReadLine();
                if (ansd == "Yes")
                {
                    viOne v = new viOne();
                    v.vi();
                }
                else if (ansd == "No")
                {
                         DebugMethod();
                }

            }
            else if (ans == "States")
            {
                Console.WriteLine("You can open the following States : ");
                Console.ReadKey();
                Console.WriteLine("Notes"); // About TerminalX(Not complete)
                Console.WriteLine("Start"); // Start Menu(Not complete)
                Console.WriteLine("MainTerminal"); // Starting of the program(Not complete)
                Console.ReadKey();
                Console.Clear();
                Console.Write("> ");
                var Tread = Console.ReadLine();
                if (Tread == "Notes")
                {
                    CommandAllReplica c = new CommandAllReplica();
                    c.NotesRe();
                    Console.ReadKey();
                    Console.WriteLine("Do you want to exit?");
                    var cr = Console.ReadLine();
                    if (cr == "Yes" || cr == "yes")
                    {
                        vi();
                    }


                }
                else if (Tread == "Start")
                {
                    CommandAllReplica c = new CommandAllReplica();
                    c.StartRe();

                }
                else if (Tread == "MainTerminal")
                {
                    CommandAllReplica l = new CommandAllReplica();
                    l.MainTerminalRe();

                }

            }
        }


    }
}
