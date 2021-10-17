using System;
using System.Collections.Generic;


namespace src
{
    class ErrorInit
    {
        public static List<DetailErrorList> ErrorInitialize()
        {
                var errorlist = new List<DetailErrorList>();
                
                errorlist.Add(new DetailErrorList{Erroruint = 20, Error = 40, ErrorSignal = 41, Error4 = 91, ErrorLk = 100, ErrorConsole = 900, ErrorRandom = 1000 , FalconError = 10000});
                return errorlist;
        }
    }
}