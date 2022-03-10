using System;

namespace src
{
	class IndexList
	{
		public void EmptyMessage()
		{
			Indexer(12); // EmptyMessage is an early implementation of a empty termlib which just passes the arguments to the method
		}
		public void Indexer(int numberofitems) // This method is called first
		{
			numberofitems = 2;
                       string[] items = new string[numberofitems]; // Stores the files or names of docpages

		}
		public void Communicator(string fullstring, string[] stringarray) // Indexer calls this method and gives the arguments
		{
                var secondstring = fullstring.Split('G');
				var array = secondstring.ToString();
				for(int i=0;i <= stringarray.Length;i++)
				{
                      if(stringarray[i] == array)
					  {
                            
					  }
				}
		}

		
		


	}
}
