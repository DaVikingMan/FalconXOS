using System;
using System.IO;

namespace src
{
	public class InputWrite
	{ 
		public InputWrite(string stringtowrite)
		{
					  var originalpath = @$"{Environment.CurrentDirectory}\data\TempInputstream\main.inputstream";
					  File.WriteAllText(originalpath, stringtowrite); // This works in non-parallel mode, parallel mode is when multiple text can be written into the file
					  Console.ReadKey();
        }

	}
}
