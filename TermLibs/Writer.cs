using System;
using System.IO;
using System.Linq;

namespace src
{
	class Writer
	{
		public void Write(string whattowrite, string permaortemp, Boolean debug, string filepath)
		{
			var listoffile = File.ReadAllLines(filepath).ToList();
			
				// File.WriteAllText(filepath, "");
				Console.WriteLine("Writing to InputStream temp");
				Console.WriteLine("Adding EOF");
				Console.WriteLine("No need for SOF : false");
				Console.WriteLine("Verifying if the text is written");
				File.AppendAllText(filepath, "Start of Input");

				var temp = new Inputstream.TempWrite();
				temp.WriteTemp(whattowrite, false);
				File.AppendAllText(filepath, "\nEnd of Input");
			

		}
	}
}
