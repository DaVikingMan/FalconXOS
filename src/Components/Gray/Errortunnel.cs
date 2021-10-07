/*
All error checks pass through this component
This is where all the errors are marked as errors or not errors and interact with other components accordingly.
If the error is serious, first Gray will report it to Shiro and then when the signal from Shiro comes to invoke or not invoke Kuroi.
If the Shiro reports a error that needs Kuroi, Kuroi will be invoked.
If the Shiro decided that there is no need to invoke Kuroi, the signal will be again sent to Shiro in ASCII format and will report the issue
*/
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
        public void CheckInfo(string invokesignal, int errorsignal, string actualsignal)
        {
            var shiroreceiver = new ShiroReceiver();
            // Determines which parts of Shiro to invoke

            string fullinvokecommand = "Send " + invokesignal; // A invoke command, will be used in the next version
            if(invokesignal.Contains(';'))
            {
                Console.WriteLine("Signed by Kuroi"); // Signed by Kuroi means that is not a error.Kuroi's main use in the outer is to invoke when serious errors but technically behind the scenes, Kuroi is just signing errors to check.
                
                
                
            }else if(invokesignal.Contains('/'))
            {
                
                shiroreceiver.ErrorSignalReceiver("Kuroi not invoked", errorsignal, actualsignal);
            }
        }
    }
}