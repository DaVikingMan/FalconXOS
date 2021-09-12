using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace src
{
    class ErrorInfo
    {
        public void ErrorInfoContainer(int erroruint, string signal)
        {
            List<DetailErrorList> errorLists = ErrorInit.ErrorInitialize();
            Console.ForegroundColor = ConsoleColor.Red;
            
           
               // This class seems empty because it hasn't been finshed, it should be completed in the next release
             foreach(var c in errorLists)
             {
             if(erroruint == c.Erroruint)
             {
                 
                  Console.WriteLine("The input stream couldn't find a text that matches your input");
                  
                  
           
             }else if(erroruint == c.Error)
             {
                 Console.WriteLine("CS10 : The error occured due to a key-interrupt");
             }
             else
             {
                 
                 var errorreceiver = new ErrorReceiver();
                 errorreceiver.MainReceiver("no", signal);
             }
             }
             

                         
        }
    }
}