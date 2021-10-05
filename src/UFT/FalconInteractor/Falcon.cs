using System;

namespace Falcon
{
	class Falcon
	{ 
		public static readonly Falcon obj1 = new Falcon(); // Note this is for readonly
		public static readonly Falcon obj2 = new Falcon();

           public static string input;
          public void MainInput()
		  {
                Falcon o = Falcon.obj1;
				input = Console.ReadLine();
				input = Convert.ToString(o); // Convert Falcon type to string as the input is a string
		  }		
	}
	class InputStream:Falcon
	{
		public static void MainInput()
		{
			Console.WriteLine(input);
		}
	}
	

}

