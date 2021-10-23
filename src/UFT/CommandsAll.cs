using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Threading;

/*
        This class contains all the commands which are found in the submenu
*/

namespace src
{
    // All commands
    class CommandsAll
{
    

    public void TerminalInfo(string comment) // Lists the UFT version and other details
    {
        Console.Clear();
        Console.WriteLine("The UFT component's versions are as follows : \nUFT versiom : 1.2\nUtility version : 1.4\nCommands version : 1.5\nOverall version : 3.9");
        
           Thread.Sleep(100);
           Console.WriteLine("Type Exit or Stay");
           Console.Write("> ");
           string ReadV = Console.ReadLine();
           if(ReadV == "Exit") // When you run 'Exit'
           {
               viOne v = new viOne();
               v.vi();

           }else if(ReadV == "Stay")
           {
               TerminalInfo("Info");

           }else // If the command is wrong
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
        if(cRead == "/command Version") // If you want to run the old version of this app
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

        }else if(cRead == "/command Reject" || cRead == "/Exit" || cRead == "exit" || cRead == "Exit" || cRead == "-state=down") // If you want to exit
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
        

    public void WriteConsolePad() 
    {
        Console.Clear();
        Console.WriteLine("Do you want to start the old version or Normal version('Normal' for normal and '/version old' for old version)");
        Console.Write(">");
        string commandOpen = Console.ReadLine();
        if(commandOpen == "/command Exit")
        {
            viOne v = new viOne();
            v.vi();
        }else if(commandOpen == "/version old") // If you want to run the old version
        {
            Console.WriteLine("Opening");
            Thread.Sleep(1000);
            ProcessHandler handler = new ProcessHandler();
            handler.ProcessWritePadUI();
            Console.WriteLine("Exiting");
            Thread.Sleep(1000);
            viOne n = new viOne();
            n.vi();
            

            
        }else if(commandOpen == "Normal"){ // If you want to run the normal version
        Console.WriteLine("What writing software do you want to open?");
        Console.WriteLine(">");
        string readApp = Console.ReadLine();
        ProcessStartInfo startInfo = new ProcessStartInfo();
        startInfo.Arguments = $@"-c {readApp}";
        startInfo.UseShellExecute = true;
        Process.Start(startInfo);
        Thread.Sleep(2000);
        Console.WriteLine("Type Exit or Stay");
        Console.Write(">");
        string rcommand = Console.ReadLine();
        if(rcommand == "Exit")
        {
            viOne v = new viOne();
            v.vi();

        }else if(rcommand == "Stay")
        {
            WriteConsolePad();
        }
        else
        {
            Console.WriteLine("Wrong command");
            Thread.Sleep(100);
            WriteConsolePad();
        }
        }

	else if(commandOpen == "/version dev")
	{
		Console.WriteLine("In developemnt");
		Console.WriteLine("Writing to the input stream");
		Thread.Sleep(100);
		Console.WriteLine("Opening a edit::access input stream in Falcon::input-edit");
		Thread.Sleep(1000);
		Console.WriteLine("Write ':goto' to start Falcon::Input-edit or type '/Exit' to exit");
		string commandWrite = Console.ReadLine();
		if(commandWrite == ":goto")
		{
			
		}else if(commandWrite == "/Exit")
		{
			var back = new viOne();
			back.vi();

		}


	}

        else
        {
            Console.WriteLine(
                "Wrong command"
            );
            Thread.Sleep(100);
            WriteConsolePad();
        }
        

    }

    


    public void Note() // Notes all the features of UFT
    {
        Console.Clear();

        Console.WriteLine("Welcome to Note! The place where you can learn how to use FalconXOS");

        
        Console.WriteLine("What Note do you want to read?");
        Console.WriteLine("UFTInfo");
        Console.WriteLine("CommandsInfo");

	Console.WriteLine("License");
	Console.WriteLine("readme(file)");
        Console.WriteLine("Exit");
        
        Thread.Sleep(1000);
        Console.Write("> ");
        var readInput = Console.ReadLine();
        if(string.IsNullOrWhiteSpace(readInput)) // If the input's value is null
        {
            Console.WriteLine("Kindly input value");
            Console.ReadKey();
            Note();

        }
        else if(readInput == "UFTInfo") 
        {
            Console.Clear();
            Console.WriteLine("This note is about FalconXOS's UFT");
            Console.WriteLine("FalconXOS's UFT is built using C# and vscode");
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
                Console.Write(">");
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
                    
                    
                }else // If the wrong command is executes
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
        else if(readInput == "CommandsInfo") // This command lets you view the notes about 'commands'
        {
            Console.Clear();
            Console.WriteLine("The commands are written in the form of either different classes or different methods");
            Console.WriteLine("Commands perform different functions");
            Console.WriteLine("If you want to execute a command then you can write the command when you are prompted to");
            Console.WriteLine("Type Yes to exit");
            Console.Write(">");
            string t = Console.ReadLine();
            if(t == "Yes") // IF you execute the 'Yes' command
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
	else if(readInput == "readme")
	{
             ProcessStartInfo start = new ProcessStartInfo();
             start.Arguments = $"-c \"cat {Environment.CurrentDirectory}/README.md\"";
             start.UseShellExecute = true;
             start.FileName = "/bin/bash";
             start.CreateNoWindow = true;
            
             var h = Process.Start(start);
             Console.ReadKey();
            h.Kill();
                 Console.WriteLine("Type exit");
                 Console.Write(">");
                 string read = Console.ReadLine();
                 if(read == "exit")
                 {
                     Note();
                 }
        }

	else if(readInput == "License")
	{
		Console.WriteLine("FalconXOS is licensed under the MIT license, for the entire license you can check https://github.com/DaVikingMan/FalconXOS/blob/master/LICENSE");
		Thread.Sleep(1000);
		Console.WriteLine("Type exit");
		Console.Write(">");
		string response = Console.ReadLine();
		if(response == "exit")
		{
                Note();
		}
	}
        else if(readInput == "Exit" || readInput == "exit" || readInput == "/command Exit" || readInput == "-sh=exit") // This command exits the 'note' and goes to the start screen

        {
            Main l = new Main();
            l.MainStart();

        }
        else
        {
            Console.WriteLine("Wrong command");
            Thread.Sleep(100);
            Note();
        }

        

        
        
    }      

 }
}
