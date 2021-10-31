using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading;

namespace startfi
{
    class startfi{
         public virtual void FalconFirmware( string specialtext )
         {
             Console.Clear();   
             Console.WriteLine(specialtext);
             Console.WriteLine("Loading some areas of FalconXOS : no implementation found of this pattern found : dev build : .221.4/Half-Ogre");
             Thread.Sleep(10);
             Console.WriteLine("Starting StartupCheck :: ");
             var startup = new src.StartCheck();
             startup.StartUpCheck();
             bool start = false;
             bool writetolog = true;
             if(start == false && writetolog == true)
             {
                 Thread.Sleep(10);
                 Console.WriteLine("You have specified that variable start is false, the command of class Startup will not be ran");
                 Thread.Sleep(10);
                 Console.WriteLine("Writing to this.log, see list of log mirrors in /docs/listofdebugs.doc(not .md)");
                 Thread.Sleep(10);
                 var writefi = new readonlyinput();
                 object[] debuglog = {
                     DateTime.UtcNow,
                     "Started Startfi : 1",
                     "Started StartupCheck : 1",
                     "Started readonlyinput : 1",
                     "Finished all inputs : 1",
                     "All done! Waiting for next : user input(1)"
                 };
                 writefi.StartRemove(debuglog, true);
                 Console.Clear();
                 Console.WriteLine("Jumped to debug console : turbulent terminal");
                 Console.Write(">> ");
                 string input = Console.ReadLine();
                 if(input == "--help")
		 {
                       Console.WriteLine("Input 1 : --devconsole");
                       Console.WriteLine("Input 2 : default");
                       Console.WriteLine("Input 2 : --set=default=<devconsole || uft>");
                       NonAddStart();

                 }else if(input == "default")
                 {
                     Console.Clear();
                     var main = new src.Main();
                     main.MainStart();
                 }else if(input == "--devconsole")
                 {
                     var dev = new dev.DevConsole();
                     dev.MainConsole();
                 }else if(input == "check")
                 {
                     Console.WriteLine("Checking inputstreams : temp and permanent");
                     List<string> offile = File.ReadAllLines($"{Environment.CurrentDirectory}/data/TempInputStream/main.inputstream").ToList();
                     List<string> ofperma = File.ReadAllLines($"{Environment.CurrentDirectory}/data/PermanentInputStream/permainput.inputstream").ToList();
                     Console.WriteLine($"{offile.Count} and {ofperma.Count}");
                     NonAddStart();
                 }else if(input == "clear")
                 {
                     Console.Clear();
                     NonAddStart();
                 }else if(input == "exit")
                 {
                     var signalverify = new src.SignalVerifier();
                     signalverify.Verify("Exit!");
                     Environment.ExitCode = 0;
                     Console.WriteLine("FalconXOS exited with : " +  Environment.ExitCode);
                     
                     Environment.Exit(0);
                     
                 }else if(input == "version" || input == "--v")
                 {
                   Console.WriteLine("FalconXOS User-Friendly Terminal version : .71.9");
                   Console.WriteLine("FalconXOS version : .27.9/Cold Sun");
                   Console.WriteLine("Startfi/Half-Ogre and Ogre components version : .24.5/Beast");
                   
                   NonAddStart();
                 }else if(input == "time")
                 {
                     DateTime date = DateTime.Now;
                     DateTime unixdate = DateTime.UnixEpoch;
                     Console.WriteLine(unixdate + " UnixEpoch");
                     Console.WriteLine(date + " Utc");
                     NonAddStart();
                 }
                 else
                 {
                      Console.WriteLine("Startfi checking modern inputstreams and errors");
                      Console.WriteLine("Using old error system");
                      Thread.Sleep(10);
                      Console.WriteLine("Violation of ogre components : no list of strings found which match this input typed");
                      Console.ReadKey();
                      NonAddStart();
                 }

            }
                 
         }
        public void NonAddStart()
        {
            Console.ResetColor();
            Console.WriteLine("Turbulent Terminal : At /start/volume/FalconFirmware");
               Console.Write(">> ");
                 string input = Console.ReadLine();
                 if(input == "--help")
                 {
                       Console.WriteLine("Input 1 : --devconsole");
                       Console.WriteLine("Input 2 : default");
                       Console.WriteLine("Input 2 : --set=default=<devconsole || uft>");
                       NonAddStart();

                 }else if(input == "default")
                 {
                     Console.Clear();
                     var main = new src.Main();
                     main.MainStart();
                 }else if(input == "--devconsole")
                 {
                     var dev = new dev.DevConsole();
                     dev.MainConsole();
                 }else if(input == "check")
                 {
                     Console.WriteLine("Checking inputstreams : temp and permanent");
                     List<string> offile = File.ReadAllLines($"{Environment.CurrentDirectory}/data/TempInputStream/main.inputstream").ToList();
                     List<string> ofperma = File.ReadAllLines($"{Environment.CurrentDirectory}/data/PermanentInputStream/permainput.inputstream").ToList();
                     Console.WriteLine($"{offile.Count} and {ofperma.Count}");
                    NonAddStart();
                 }else if(input == "clear")
                 {
                     Console.Clear();
                     NonAddStart();
                 }else if(input == "exit")
                 {
                     var signalverify = new src.SignalVerifier();
                     signalverify.Verify("Exit!");
                     Environment.ExitCode = 0;
                     Console.WriteLine("FalconXOS exited with : " +  Environment.ExitCode);
                     
                     Environment.Exit(0);
                 }else if(input == "version" || input == "--v")
                 {
                   Console.WriteLine("FalconXOS User-Friendly Terminal version : .71.9");
                   Console.WriteLine("FalconXOS version : .27.9/Cold Sun");
                   Console.WriteLine("Startfi/Half-Ogre and Ogre components version : .24.5/Beast");
                   NonAddStart();
                 }else if(input == "time")
                 {
                     
                     DateTime date = DateTime.Now;
                     DateTime unixdate = DateTime.UnixEpoch;
                     Console.WriteLine(unixdate + " UnixEpoch");
                     Console.WriteLine(date + " Utc");
                     NonAddStart();
                 }
                 else
                 {
                      Console.WriteLine("Startfi checking modern inputstreams and errors");
                      Console.WriteLine("Using old error system");
                      Thread.Sleep(10);
                      Console.WriteLine("Violation of ogre components : no list of strings found which match this input typed");
                      NonAddStart();
                 }  
        }
    }
}
