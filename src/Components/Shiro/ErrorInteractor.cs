using System;

namespace src
{
    class ErrorInteractor
    {
        public void VerifyError(string errorsignal, int errornum, string zerosignal)
        {
              if(errorsignal.Contains('/'))
              {
                  var gray = new Errortunnel();
                  gray.CheckInfo("/", errornum, zerosignal);
              }else if(errorsignal.Contains(';'))
              {
                  Console.WriteLine("Not a recongnized symbol, throw new error");
                  Environment.Exit(0);
                  // This symbol isn't supported and throws a new error, exiting FalconXOS
              }
        }
    }
}