// This is where all the errors of Shiro are placed, all errors go through this tunnel
// Created by Kuroi is just a mark of whether it can interact with Kuroi
// Created by user means that it is created by user
// Created by DaVikingMan means that the error can be accessed by all parts of FalconXOS

using System;
using System.Diagnostics;

namespace src
{
    class Errortunnel
    {
        public void ErrorRules(string receiveerrorstring) // Not currently being used by FalconXOS
        {
            if(receiveerrorstring.Contains('!'))
            {
                string errostatus = "Signed - Created by Kuroi";
            }else if(receiveerrorstring.Contains('#'))
            {
                string errostatus = "Signed - Created by User";       // Ignore the ErrorRules class for now, it will be used in the next version
            }else if(receiveerrorstring.Contains('-'))
            {
                string errostatus = "Not created by Kuroi";
            }
        }
        public void AddInfo(string invokesignal, int errorsignal, string actualsignal)
        {
            var shiroreceiver = new ShiroReceiver();
            // Determines which parts of Shiro to invoke

            string fullinvokecommand = "Send " + invokesignal; // A invoke command, will be used in the next version
            if(invokesignal.Contains(';'))
            {
                Console.WriteLine("Signed by Kuroi"); // Signed by Kuroi means that is not a error
                
                
            }else if(invokesignal.Contains('/'))
            {
                
                shiroreceiver.ErrorSignalReceiver("Kuroi not invoked", errorsignal, actualsignal);
            }
        }
    }
}