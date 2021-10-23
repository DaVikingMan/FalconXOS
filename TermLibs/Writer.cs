using System;

namespace src
{
	class Writer
	{
		public void Write(string whattowrite, string permaortemp, Boolean debug)
		{
			if(debug == true)
			{
				Console.WriteLine("Writing to InputStream temp");
				Console.WriteLine("Adding EOF");
				Console.WriteLine("No need for SOF");
				Console.WriteLine("Verifying if the text is written");

				var temp = new Inputstream.TempWrite();
				temp.WriteTemp(whattowrite, false);
			}

		}
	}
}
