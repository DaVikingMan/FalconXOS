using System;
using System.Diagnostics;

namespace src
{
	class Processor
	{
         public void MainProcessor(ProcessStartInfo processorname)
	     {
				processorname.Arguments = "-c cat ../fileext/altreadme.md";
				Process.Start(processorname);    
	     }
	}
}
