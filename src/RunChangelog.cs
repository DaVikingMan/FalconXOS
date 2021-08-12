using System;
using System.Diagnostics;

namespace src
{
    class RunChangelog
    {
        public void MainChangelog()
        {
            ProcessStartInfo startInfo = new ProcessStartInfo();
                startInfo.WorkingDirectory = $"{Environment.CurrentDirectory}/Changelog";
                startInfo.Arguments = "/C node changelog.js";
                startInfo.FileName = "CMD.exe";
                startInfo.UseShellExecute = true;
                startInfo.CreateNoWindow = false;
                Process.Start(startInfo);
                Console.WriteLine("Exiting  : ");
                MainChangelog();
        }
    }
}