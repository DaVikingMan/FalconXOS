using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Threading;

namespace src
{
    // All commands
    class CommandsAll
{
    

    public void TerminalInfo(string comment) // Lists the Operating Shell version and other details
    {
        Console.Clear();
        Console.WriteLine("The driver version's are as follows : \nApp versiom : v.2\nUtility version : v.4\nCommands version : v.5\nOverall version : vi.9");
        
           Thread.Sleep(1000);
           Console.WriteLine("Type Exit or Stay");
           string ReadV = Console.ReadLine();
           if(ReadV == "Exit")
           {
               viOne v = new viOne();
               v.vi();

           }else if(ReadV == "Stay")
           {
               TerminalInfo("Info");

           }else
           {
               Console.WriteLine("Wrong command");
               Thread.Sleep(100);
               TerminalInfo("Terminal Info");
           }
        
        

    }
    
    
    public void ListMaker(string comment2) // command used for creating lists
    {
        Console.WriteLine("This command is now replaced by the Project Manager command(which is located in the start menu)");
        Console.WriteLine("If you still want to run the ListMaker then we do have an earlier version of it\nType '/command Version'");
        string cRead = Console.ReadLine();
        if(cRead == "/command Version")
        {
            ProcessHandler handler = new ProcessHandler();
            handler.ProcessHandle();
            Thread.Sleep(1000);
            Console.WriteLine("Type Exit");
            Console.Write(">");
            string Read = Console.ReadLine();
            if(Read == "Exit")
            {
                Console.WriteLine("Exiting");
                Thread.Sleep(100);
                viOne v = new viOne();
                v.vi();
            }

        }else if(cRead == "/command Reject")
        {
            Console.WriteLine("Exiting ");
            Thread.Sleep(100);
            viOne v = new viOne();
            v.vi();
        }else 
        {
            Console.WriteLine("Wrong command");
            ListMaker("Make list");
        }
        

        
        
    }
        

    public void WriteConsolePad() // 
    {
        Console.Clear();
        Console.WriteLine("Which Writing Software do you want to open?");
        string commandOpen = Console.ReadLine();
        if(commandOpen == "/command Exit")
        {
            viOne v = new viOne();
            v.vi();
        }
        ProcessStartInfo startInfo = new ProcessStartInfo();
        startInfo.Arguments = $@"/C {commandOpen}";
        startInfo.UseShellExecute = true;
        Process.Start(startInfo);
        Thread.Sleep(2000);
        Console.WriteLine("Type Exit or Stay");
        string rcommand = Console.ReadLine();
        if(rcommand == "Exit")
        {
            viOne v = new viOne();
            v.vi();

        }else if(rcommand == "Stay")
        {
            WriteConsolePad();
        }else
        {
            Console.WriteLine("Wrong command");
            Thread.Sleep(100);
            WriteConsolePad();
        }

    }

    public void RunCommand()
    {
        Console.Clear();
        Console.WriteLine("Type the exe file name of the file which you want to run");
        Console.Write(">");
        string Fie = Console.ReadLine();
        Process.Start(Fie);
        Thread.Sleep(2000);
        Console.WriteLine("Do you want to Exit or Stay");
        string ansj = Console.ReadLine();
        if(ansj == "Exit")
        {
            viOne b = new viOne();
            b.vi();            
        }else if(ansj == "Stay")
        {
            RunCommand();

        }else
        {
            Console.WriteLine("Wrong command");
            Thread.Sleep(100);
            RunCommand();
        }
    }


    public void Note() // Note feature(can only be accessed from the starting screen and from 'TheDebug' command)Not finished
    {
        Console.Clear();
        Console.WriteLine("Welcome to Note! The place where you can learn how to use TerminalXOS");
        
        Console.WriteLine("What Note do you want to read?");
        Console.WriteLine("TerminalInfo");
        Console.WriteLine("CommandsInfo");
        Console.WriteLine("Exit");
        Console.WriteLine("Copyright Info");
        Thread.Sleep(1000);
        Console.Write("> ");
        var readInput = Console.ReadLine();
        if(string.IsNullOrWhiteSpace(readInput))
        {
            Console.WriteLine("Kindly input value");
            Console.ReadKey();
            Note();

        }
        else if(readInput == "TerminalInfo")
        {
            Console.Clear();
            Console.WriteLine("This note is about TerminalXOS");
            Console.WriteLine("TerminalXOS is built using C# and vscode");
            Thread.Sleep(100);
            Console.WriteLine("Do you want to see some rules?");
            dynamic check = Console.ReadLine();
            if(check == "Yes")
            {
                Thread.Sleep(100);
                Console.Clear();
                Console.WriteLine("The rules are :-");
                Thread.Sleep(100);
                Console.WriteLine("Only type 'Yes' or 'No' not 'no' or 'yes'.");
                Console.WriteLine("Only type when the '>' symbol appears.");
                Console.WriteLine("If some features don't work as intended please write them in the issues section.");
                
                Console.WriteLine("Do you want to exit?");
                string b = Console.ReadLine();
                if(b == "Yes")
                {
                    Thread.Sleep(100);
                    Note();

                }else if(b == "No")
                {
                    Console.WriteLine("There is nothing more in this command");
                    Console.WriteLine("Exiting");
                    Note();
                    
                    
                }else
                {
                    Console.WriteLine("Wrong command");
                    Thread.Sleep(100);
                    Note();

                }
                
            }else if(check == "No")
            {
                
                Console.WriteLine("Exiting");
                Thread.Sleep(100);
                Note();
                

                
            }

        }
        else if(readInput == "CommandsInfo")
        {
            Console.Clear();
            Console.WriteLine("The commands are written in the form of either different classes or different methods");
            Console.WriteLine("Commands perform different functions");
            Console.WriteLine("If you want to execute a command then you can write the command when you are prompted to");
            Console.WriteLine("Type Yes to exit");
            string t = Console.ReadLine();
            if(t == "Yes")
            {
                Console.ReadKey();
                Note();
            }else
            {
                Console.WriteLine("Wrong command");
                Console.WriteLine("Exiting");
                Thread.Sleep(100);
                Note();
            }

        }
        else if(readInput == "Exit")
        {
            kernel l = new kernel();
            l.KernelMain();

        }
        else if(readInput == "Copyright Info")
        {
            Console.Clear();
            Console.WriteLine("Copyright Re:Note(Method)");
            Thread.Sleep(100);
            Note();

        }else
        {
            Console.WriteLine("Wrong command");
            Thread.Sleep(100);
            Note();
        }

        

        
        
    }      

 }
}
