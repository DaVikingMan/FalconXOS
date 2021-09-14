using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading;

// If errornum = 0, no error,
// If any num matches the num of the integers in the list, that is an error
// This is where the error signal to Gray and signal to Zero goes
// If error is less than 20, it is not an error

namespace src
{
    class SignalReceiver
    {
        public void sendsignal(string signal, string graysignal ,int errorstring)
        {
            
            var errorInteractor = new ErrorInteractor();
            var verifier = new SignalVerifier();
            
            
                    
                    errorInteractor.VerifyError(graysignal,errorstring, signal); // Checks the signal if it has an error then it is given to 'Shiro' and if no error is detected, the signal is given to 'Zero'
                    
                    

                    
            
            
        }
    }
}
