using System;

namespace TermLibs
{
	class fileadd
	{
		public void AddToString(string filename, string specialstring)
		{
                        string completefullpath = $"{Environment.CurrentDirectory}/{filename}";
						var markdownreader = new markdownreader();
						markdownreader.read(completefullpath, specialstring);
		}
			
	}
}
