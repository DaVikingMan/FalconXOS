using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading;

// If errornum = 0, no error,
// If any num matches the num of the unsigned integers in the list, that is an error
// Checks if the signal is signed or unsigned

namespace src
{
    class SignalReceiver
    {
        public void sendsignal(string signedstring, string sendstring, object errornum)
        {
            List<DetailErrorList> detailerror = ErrorInit.ErrorInitialize();
            
            var zero = new ZeroSignal();
            string stringsend = sendstring;
            if(signedstring == "Signed")
            {
                    Console.WriteLine("Sending Signal to 'Zero'");
                   
                    
            }else if(signedstring == "Unsigned")
            {
                
                Console.WriteLine("Sending a unsigned signal to 'Zero'");
                zero.ReceiveSignal(sendstring);
            }else
            {
                Console.WriteLine("FalconXOS doesn't accept signals which are neither signed or unsigned");
                Console.WriteLine("Kindly sign or unsign the signal by adding either '!' or '#'");
                Console.WriteLine("If you want to accept signals which are neither signed or unsigned, you can add rules for that in the RulesAdd() method in SignalVerifier and implement that rule in SignalReceiver.cs");
                Thread.Sleep(5000);
                Environment.Exit(0);

            }
            
        }
    }
}