using System;
using System.Diagnostics;

namespace src
{
    class ShiroError // This is the receiver for Shiro , all checks for rules happen here
    {
        public void ErrorReceiver(char receiveerrorstring)
        {
            Console.WriteLine("Sending signal to Zero");
        }
        public void ErrorSystem(string errorstring, int errorsymbol)
        {
            string fullerrorstring = errorstring +  " !!";
            Console.WriteLine("String received : ", fullerrorstring);
            var zero = new ZeroSignal();
            var error = new ErrorContainer();
            error.Container(errorstring, errorsymbol); // Send an errorsignal to Gray

        }
    }
}