using System;
using System.Diagnostics;

namespace src{

class ChangelogRun
{
     public void RunChangelog()
     {
                   Process process = new Process();
                   ProcessStartInfo s = new ProcessStartInfo();
                   s.CreateNoWindow = true;
                   s.WorkingDirectory = $"{Environment.CurrentDirectory}/src";
                   s.FileName = "/bin/bash";
                   s.Arguments = $"-c ./startjs.sh";
                   s.UseShellExecute = true;

                   var startprocess = Process.Start(s);
     }
}
}
