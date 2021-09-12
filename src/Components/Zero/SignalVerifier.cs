using System;
using System.Diagnostics;

/*
       '#' means the signal is unsigned.
       If you want to sign a signal, add a '!', this means that the signal is signed
       Although this is the default rules for signed and unsigned signals, you can add your own rules for signing signals in SignalSign

       The feature signed signals and unsigned signals was added to differ between signals you want to use or are complete and unsigned signals indicate that the signal is a new signal made by a user or is not complete.
       For example, if you are working on a signal and think that it is not complete you can add a '#' symbol for making it unsigned.
       Unsigned signals also don't display messages and are not reported by Shiro  if any errors are there.
       This allows you to develop a new error system for your signals more easily
      
      It is recommended to either sign or unsign the signal.
      By default, the signals which are neither signed or unsigned are not accepted by FalconXOS
*/

namespace src
{
    class SignalVerifier
    {
        
        public void Verify(string stringtoverify)
        {
            var zero = new ZeroSignal();
            var signal = new SignalReceiver();
            if(stringtoverify.Contains('#'))
            {
                // Add code for creating your own error handling system
            }else if(stringtoverify.Contains('!'))
            {
                zero.ReceiveSignal(stringtoverify);

                
            }else
            {
                Console.WriteLine("Error : The signal is neither signed nor unsigned");
                Console.WriteLine("Not acceptable signal, force exiting FalconXOS");
                Environment.Exit(0);           
            }
        }
        public void SignalSign(int signedstring)
        {
            
                 // This method can be used to add your own rules for signing signals
        }
        public void SignalErrorMaintainer(uint unsignedstring)
        {
                // This is to send a signal to 'Shiro' for error handling
        }

    }
}