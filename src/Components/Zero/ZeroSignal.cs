using System;
using System.Diagnostics;
using System.Threading;
using System.IO;
using System.Linq;
using System.Collections.Generic;

// C:\Github\FalconXOS\data\PermanentInputStream\permainput.inputstream
// The signal when checked gets sent to ReceiveSignal method in Zero

namespace src
{
    class ZeroSignal
    {
        public void ReceiveSignal(string receivestring)
        {
            Console.ForegroundColor = ConsoleColor.Yellow; // Color displayed when giving output to FalconXOS for the signal received
                if(receivestring == "Exit!") // Exit signal is used for exiting FalconXOS
                {
                  
                    Console.WriteLine("Exiting :: ");
                    Thread.Sleep(500);
                    Console.Clear();
                    var tempwrite = new Inputstream.TempWrite();
                    List<string> filename = File.ReadAllLines($"{Environment.CurrentDirectory}/data/PermanentInputStream/permainput.inputstream").ToList();
                    if(!File.Exists($"{Environment.CurrentDirectory}/data/PermanentInputStream/permainput.inputstream"))
                    {
                         File.Create($"{Environment.CurrentDirectory}/data/PermanentInputStream/permainput.inputstream");
                    }
                   
		    if(filename.Count == 1)
            {

            
                    
                     // Removes all data from temp input stream  
                    Environment.Exit(0);
            }
		    else if(filename.Count == 0)
            {
                tempwrite.TempSignal(false);
                string[] a = {""};
                File.WriteAllLines($"{Environment.CurrentDirectory}/data/TempInputStream/main.inputstream", a);
                    Environment.Exit(0);
            }
                    

                    
                    
                }else if(receivestring == "Give version!") // This signal outputs the version of FalconXOS 
                {
                    
                        Console.WriteLine("Version : .21.19-Windows(Falcon)");
                        Console.WriteLine("Version codename : Black Snow");
                        Console.WriteLine("Dev version : .21.19.9");
                        Console.ReadKey();
                        Thread.Sleep(5000);
                }else if(receivestring == "Request debug info!") // This signal is used for showing debug info
                {
                    Console.WriteLine("The following debug info is available");
                    long MemoryWrite = GC.GetTotalMemory(true);
                    Console.WriteLine("Memory used : ");
                    Console.Write(MemoryWrite);
                    Console.ReadKey();
                }else if(receivestring == "Access Changelog!") // This signals runs the changelog
                {
                    var changelog = new RunChangelog();
                    changelog.MainChangelog();
                }else if(receivestring == "Dev Changelog!") // This signal runs the developement changelog
                {
                    var changelog = new RunChangelog();
                    changelog.DevChangelog();
                }
        }
        
    }
}
