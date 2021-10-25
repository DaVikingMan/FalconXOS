/*
                This class sends input to inputstreams
				This class doesn't interact with the inputstreams for exchanging inputs,
				For the class which exchanges inputs, see inputsend.cs(/FalconXOS/src/Components/InputBat/inputsend.cs)
*/

using System;
using System.IO;

namespace src
{
	class inputinteractor
	{
		public void inputinteract(string input, string define, bool debug, string filepath)
		{
			var writer = new Writer();
			writer.Write(input, define, debug, filepath);
			var tempwrite = new Inputstream.TempWrite();
			tempwrite.TempSignal(false);
			WriteDebug(input, define, debug, filepath);
			
		}
		public void WriteDebug(string input, string define, bool debug, string filepath)
		{
			string filepathlog = $"{Environment.CurrentDirectory}/data/debug/debug.log";
			if(File.Exists(filepathlog))
			{
                File.AppendAllText(filepathlog, $"Date of log : {DateTime.UtcNow}");
				File.AppendAllText(filepathlog, $"Written inputstream to {input}, {define}, {debug} to {filepathlog}");
				File.AppendAllText(filepathlog, "Added EOF and SOF also(before step)");
				File.AppendAllText(filepathlog, "Done : complete inputstream debug log");
			}
		}
	}
}


