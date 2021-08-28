using System;
using System.Diagnostics;
using System.Collections.Generic;

namespace src
{
    class ErrorList
    {
        public static List<errorProperty> MainList()
        {
             var errorList = new List<errorProperty>();
	         errorList.Add(new errorProperty{Error1 = "Expected command pre-defined but got new defination", Error2 = "Different input stream expected", Error3 = "Error could not provide enough info, kindly refer to error-li12", Error4 = "At [none], path is not defined or incorrect", FalconError = "FalconXOS error : Whole I/O stream wrong, problem cannot be fixed"});

		 return errorList;
        } 
    }
}   
