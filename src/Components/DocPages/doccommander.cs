using System;
using System.Diagnostics;

namespace src
{
	class docconsole
	{
		public void MainReader(string filetoread)
		{
		 
                	ProcessStartInfo start = new ProcessStartInfo();
start.Arguments = $"-c \"cat {Environment.CurrentDirectory}/src/Components/DocPages/docpages/{filetoread}.docpage\"";
         		start.FileName = "/bin/bash";
		        start.UseShellExecute = true;
                	// start.CreateNoWindow = false;
			Process.Start(start);
			var devconsole = new dev.DevConsole();
			Console.ReadKey();
         		devconsole.MainConsole();
		    
		}
	}
}
