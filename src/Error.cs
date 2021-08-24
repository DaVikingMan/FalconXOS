using System;
using System.Collections.Generic;
using System.Linq;

namespace src
{
	class Error
	{
		public void MainErrorDetection(string error)
		{
			
			List<error> newerror = ErrorList.MainList(); // Create a new instance of ErrorList.MainList();
            foreach(var v in newerror)
			{
				if(error == v.Error1)
				{
					Console.ForegroundColor = ConsoleColor.DarkRed;
					Console.WriteLine(v.Error1, "If could not be fixed try to report it in the errors section");
				}else if(error == v.Error2)
				{
					Console.ForegroundColor = ConsoleColor.DarkRed;
					Console.WriteLine(v.Error2, "If could not be fixed try to report it in the errors section");
				}else if(error == v.Error3)
				{
					Console.ForegroundColor = ConsoleColor.DarkRed;
					Console.WriteLine(v.Error3, "If could not be fixed try to report it in the errors section");
				}else if(error == v.Error4)
				{
					Console.ForegroundColor = ConsoleColor.DarkRed;
					Console.WriteLine(v.Error4, "If could not be fixed try to report it in the errors section");
				}else if(error == v.FalconError)
				{
					Console.ForegroundColor = ConsoleColor.DarkRed;
					Console.WriteLine(v.FalconError , "FalconError's are usually associated with FalconXOS errors therefore this might be a bug.If you have found a FalconError, kindly report it in the issues tab with the error no.");
				}
			}


	}

}
}

