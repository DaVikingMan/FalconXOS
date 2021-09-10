using System;
using System.Diagnostics;

namespace src
{
    class ErrorContainer
    {
        public void Container(string signal, int errorsignal)
        {
            Console.WriteLine("Received signal");
            Console.WriteLine("Forwarding signal to one of Gray's interactor ShiroReceiver for invoking Crowned and Kuroi(if serious)");
            var gray = new Errortunnel();
            gray.AddInfo(signal, errorsignal);
        }
    }
}