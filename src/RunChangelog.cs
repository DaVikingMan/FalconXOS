using System;
using System.Diagnostics;

namespace src
{
    class RunChangelog
    {
        public void MainChangelog()
        {
            ProcessStartInfo startInfo = new ProcessStartInfo();
            Console.WriteLine(Environment.CurrentDirectory);
            Console.ReadKey();
                startInfo.WorkingDirectory = $@"{Environment.CurrentDirectory}/Changelog";
                startInfo.FileName = "CMD.exe";
		        startInfo.Arguments = "/C node changelog.js";
                startInfo.UseShellExecute = true;
                startInfo.CreateNoWindow = true;
                Process.Start(startInfo);
               
                
        }
    }
}
