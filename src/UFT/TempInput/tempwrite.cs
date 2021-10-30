using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;

namespace Inputstream
{
	class TempWrite
	{
		public void WriteTemp(string readwrite, bool ifwritepermanent)
		{
                         string read = readwrite;
						 if(ifwritepermanent == true)
						 {
                               File.AppendAllText($"{Environment.CurrentDirectory}/data/TempInputstream/main.inputstream", read);
						 }else if(ifwritepermanent == false)
						 {
							 File.AppendAllText($"{Environment.CurrentDirectory}/data/TempInputstream/main.inputstream", read);
							 

						 }
                         
						 
			 
		}
		public void TempSignal(bool istrue)
		{
			if(istrue == true)
			{
				File.WriteAllText("../FalconXOS/data/TempInputstream/main.inputstream", null);
				List<string> all = File.ReadAllLines($"{Environment.CurrentDirectory}/data/config/config.configc").ToList();
				File.AppendAllText($"{Environment.CurrentDirectory}/data/PermanentInputStream/permainput.inputstream", "Done:Note");
			}else if(istrue == false)
			{
				
			}
		}

	}
}
