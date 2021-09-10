using System;
using System.Diagnostics;
using System.Threading;

// The signal when checked gets sent to ReceiveSignal method in Zero

namespace src
{
    class ZeroSignal
    {
        public void ReceiveSignal(string receivestring)
        {
                if(receivestring == "Exit!")
                {
                    Console.WriteLine("Received , " + receivestring, " as a signal");
                    Console.WriteLine("Exiting :: ");
                    Thread.Sleep(2000);
                    Environment.Exit(0);
                }else if(receivestring == "Give version")
                {
                    Console.WriteLine("Received ", receivestring);
                        Console.WriteLine("Version : .16.2-Windows(Falcon)");
                        Console.WriteLine("Exiting :: ");
                        Thread.Sleep(5000);
                }else if(receivestring == "Request debug info!")
                {
                    Console.WriteLine("The following debug info is available");
                    long MemoryWrite = GC.GetTotalMemory(true);
                    Console.WriteLine("Memory used : ");
                    Console.Write(MemoryWrite);
                }
        }
        public void SendSignal(string sendstring, string optionstring) // This is not necessary
        {
               Convert.ToString(sendstring);
               Convert.ToString(optionstring); 
               sendstring = "Report : A signal has been sent to Menu.cs";
               optionstring = "This is to inform all crows that the signal is verified and ready to be sent to 'Zero'";
               

        }
    }
}