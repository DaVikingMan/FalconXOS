using System;
using System.Collections.Generic;

namespace src // The default namespace
{
    class ComponentInteractor // Interacts with other components of FalconXOS.Only sends signals doesn't receive them.Although, FalconXOS can interact with its components directly by using Gray, it isn't efficient to send them from a part of FalconXOS which isn't a component to a component which use is to exchange signals.
    {
        public void MainInteractor(string interactsignal, string invokesignalsymbol, int errorinteger)
        {
             var signalreceive = new SignalReceiver(); // Zero Component
             signalreceive.sendsignal(interactsignal, invokesignalsymbol, errorinteger); // Sends signal to SignalReceiver.cs
             // Note : ComponentInteractor is a part of FalconXOS's UFT(User-Friendly Terminal)
        }
    }
}