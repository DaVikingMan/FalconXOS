using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace config
{
	class configc
	{
		public void MainConfig(bool passon)
		{
			bool configstring = passon;
			if(configstring == true)
			{
				Console.WriteLine("------Config Console------");
				Console.WriteLine(">Config settings");
				Console.WriteLine("User settings");
				Console.WriteLine("Color settings");
				Console.WriteLine("Advanced(for editing .configc files directly)");
				Console.WriteLine("Under extreme developement : Not completed, under construction");
				Console.WriteLine("Codename : Lion's Leash");
				Environment.Exit(0);

			}
		}
		public void ChangeInput(string fileofinput)
		{
            List<string> p = File.ReadAllLines(fileofinput).ToList();
			Console.WriteLine(p[0]);
		}

	}

		
}

