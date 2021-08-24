/*
             This class has the errors which can reported.
             The detection work is done by the 'Error.cs' class
             For more info on different errors go to 'Main.md'
*/

using System;
using System.Collections.Generic;

namespace src
{
    class ErrorList
    {
              public static List<error> MainList()
              {
                  var c = new List<error>();

                  c.Add(new error{Error1 = "Expected :: Input of command 1, 2, 3, 4(See Error : 0102)", Error2 = "Not available command, Try a different one(See error : 0323-e)", Error3 = "Error :: 0102(Not able to provide enough info, See info-error 0102-internal)", Error4 = "Incorrect path(refer to error 02302internal)", FalconError = "FalconXOS :: throw new error, not expected :: refer to internal error internal102 or external error n102p for more information"});
               
                  return c;
              
              }
        
    }
}