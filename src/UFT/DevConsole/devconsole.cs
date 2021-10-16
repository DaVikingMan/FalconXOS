using System;
using System.Threading;
using System.Diagnostics;
using System.Collections.Generic;

namespace dev
{
    class DevConsole
    {
         public void MainConsole()
         {
             Console.WriteLine("devconsole :: Ignore debug for now, all debug messages are for when inputstream will be implemented");
             Console.WriteLine("Input :: ????");
             Console.WriteLine("InputStream Chosen : readonly-edit::");
             Console.WriteLine("Done :: Opened Console:Dev, Console:Input, Receive:Input");
             Thread.Sleep(2000);
             Console.Clear();
             Console.Write(">> ");
	     string consoleread = Console.ReadLine();
	     if(consoleread == "view @" || consoleread == "view news")
	     {
             List<string> commandslist = new List<string>();
         
             commandslist.Add("-c \"cat mainnews.md\"");
               var startinfo = new ProcessStartInfo();
               startinfo.WorkingDirectory = $"{Environment.CurrentDirectory}/Dashboard";
               startinfo.Arguments = commandslist[0];   
               
               	startinfo.FileName = "/bin/bash";
                   var read = Process.Start(startinfo);
                //    read.Start();
              
                   read.Close();
                   
                   Console.ReadKey();
                  NonStartConsole();
     
	     }else if(consoleread == "::exit" || consoleread == "exit" || consoleread == "devconsole::exit")
         {
              var Mainc = new src.Main();
              Mainc.MainStart();
         }

         }
         public void NonStartConsole()
         {
             Console.Clear();
              Console.Write(">> ");
	     string consoleread = Console.ReadLine();
	     if(consoleread == "view @" || consoleread == "view news")
	     {
             List<string> commandslist = new List<string>();
         
             commandslist.Add("-c \"cat mainnews.md\"");
               var startinfo = new ProcessStartInfo();
               startinfo.WorkingDirectory = $"{Environment.CurrentDirectory}/Dashboard";
               startinfo.Arguments = commandslist[0];   
               
               	startinfo.FileName = "/bin/bash";
                   var read = Process.Start(startinfo);
                //    read.Start();
              
                   read.Close();
                   
                   Console.ReadKey();
                   MainConsole();
     
	     }else if(consoleread == "::exit" || consoleread == "exit" || consoleread == "devconsole::exit")
         {
              var Mainc = new src.Main();
              Mainc.MainStart();
         }
         }
    }
}
