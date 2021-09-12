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
                  gray.AddInfo("/", errornum, zerosignal);
              }else if(errorsignal.Contains(';'))
              {
                  Console.WriteLine("Not a recongnized symbol, throw new error");
                  Environment.Exit(0);
                  // This means that the error is not signed by Gray nor Kuroi and should be reported to the issues tab in Github
              }
        }
    }
}