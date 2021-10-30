using System;

namespace TermLibs
{
	class fileadd
	{
		public void AddToString(string filename, string specialstring)
		{
                        string completefullpath = $"{Environment.CurrentDirectory}/{filename}";
						var filereader = new filereader();
						filereader.read(completefullpath, specialstring);
		}
			
	}
}
