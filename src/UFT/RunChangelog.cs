using System;
using System.Diagnostics;

namespace src
{
    class RunChangelog
    {
        public void MainChangelog()
        {
            ProcessStartInfo startInfo = new ProcessStartInfo();           
                startInfo.WorkingDirectory = $@"{Environment.CurrentDirectory}/src";
                startInfo.FileName = "/bin/bash";
		        startInfo.Arguments = "-c \"node changelog.js\"";
                startInfo.UseShellExecute = true;
                startInfo.CreateNoWindow = true;
                Process.Start(startInfo);
               
                
        }
        public void DevChangelog()
        { 
                ProcessStartInfo startInfo = new ProcessStartInfo();           
                startInfo.WorkingDirectory = $@"{Environment.CurrentDirectory}/src";
                startInfo.FileName = $"/bin/bash";
		        startInfo.Arguments = "-c \"node devchangelog.js\"";
                startInfo.UseShellExecute = true;
                startInfo.CreateNoWindow = true;
                Process.Start(startInfo);
        }
    }
}
