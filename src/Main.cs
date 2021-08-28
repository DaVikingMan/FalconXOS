using System;
using System.Diagnostics.Tracing;
using System.Diagnostics;
using System.Threading;
using System.IO;
using System.Collections.Generic;

/*
*         
*           Function : To start FalconXOS
*           Main.cs is the first class which Program.cs loads
*           This is also sometimes referred to as the starting screen
*
*           
*    */

namespace src // src is the namespace used for all .cs files
{

    class Main // Starting class
    {
        public void MainStart() // Main Method
        {
 
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
            if(commandStart == "start -uft n") // This commands goes to the menu
            {

                viOne v = new viOne();
                v.Start();
            }else if(commandStart == "/command Exit" || commandStart == "/exit") // This exits the UFT
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


            }else if(commandStart == "--internal version" || commandStart == "--i ver")
	    {
		    Console.ForegroundColor = ConsoleColor.Green;
		    Console.WriteLine("FalconXOS : version.16.2-Falcon");
		    Console.ForegroundColor = ConsoleColor.White;
		    Console.WriteLine("Exiting");
		    Thread.Sleep(4000);
		    MainStart();
		    

	    

            }else if(commandStart == "/clear" || commandStart == "--clear" || commandStart == "-=sh=clear")
	    {
		    Console.Clear();
		    MainStart();
	    }
	  
            else  // When the wrong command is executed
            {

                Console.ForegroundColor = ConsoleColor.Red;
                List<errorProperty> error = ErrorList.MainList();
	        foreach(var errorc in error)
		{
			Console.WriteLine(errorc.Error1);
		}
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
                if(gRead == "/exit") // This command is used to exit this command
                {
                    MainStart();
                }else // If the command is wrong
                {

                Console.ForegroundColor = ConsoleColor.Red;
                    List<errorProperty> error = ErrorList.MainList();
		    foreach(var c in error)
		    {
			    Console.WriteLine(c.Error2);
		    }

                    Console.ReadKey();
		    MainStart();
                    
                }
            }else if(readFirstInput == "start -uft n") // When the listed command is executed
            {

                viOne v = new viOne();
                v.Start();
            }else if(readFirstInput == "/command Exit" || readFirstInput == "/exit")
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


            }else if(readFirstInput == "--internal version" || readFirstInput == "--i v")
	    {
		    Console.ForegroundColor = ConsoleColor.Green;
		    Console.WriteLine("FalconXOS : version.16.2(Falcon)");
		    Console.ForegroundColor = ConsoleColor.White;
		    Console.WriteLine("Exiting");
		    Thread.Sleep(4000);
		    MainStart();

	     }else if(readFirstInput == "/clear" ||readFirstInput == "--clear" || readFirstInput == "-=sh=clear")
            {
                    Console.Clear();
		    MainStart();
            }


            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                List<errorProperty> errorb = ErrorList.MainList();
		foreach(var k in errorb)
		{
			Console.WriteLine(k.Error1);
		}
                Console.ReadKey();
                MainStart();
            }

        }





    }
}
