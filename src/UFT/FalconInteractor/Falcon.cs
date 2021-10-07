using System;

namespace Inputstream
{
	class Falcon
	{ 
		public static readonly Falcon obj1 = new Falcon(); // Note this is for readonly
		public static readonly Falcon obj2 = new Falcon();
		public static Falcon obj3 = new Falcon(); // Edit stream
		public static Falcon obj4 = new Falcon();

           public static string input;
                  public void ReadonlyMainInput()
		  {
                                Falcon o = Falcon.obj1;
				input = Console.ReadLine();
				input = Convert.ToString(o); // Convert Falcon type to string as the input is a string
		  }
		  public void EditInputstream()
		  {
			  InputStream input = new InputStream();
			  input.EditInputstream();
		  }
	}
	class RedirectInput:Falcon
	{
		public static void MainInput()
		{
			Console.WriteLine(input);
		}
		public virtual void EditInput()
		{
                       input = Console.ReadLine();
					   var b = Convert.ToString(obj3);
		       b = Convert.ToString(input);
		       var inputstream = new InputStream();
		       inputstream.InputEdit(b);
		}
		

	}
	

}

