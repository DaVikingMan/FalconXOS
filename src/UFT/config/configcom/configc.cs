using System;

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


	}

		
}

