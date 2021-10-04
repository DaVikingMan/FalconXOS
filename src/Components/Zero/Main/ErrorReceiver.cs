using System;
using System.Diagnostics;

namespace src
{
    class ErrorReceiver
    {
        public void MainReceiver(string correctsignal, string signalverify)
        {
                if(correctsignal == "no")
                {
                    var signal = new SignalVerifier();
                    signal.Verify(signalverify);
                }
        }
    }
}