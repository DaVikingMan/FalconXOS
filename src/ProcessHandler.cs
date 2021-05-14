using System;
using System.Diagnostics;

namespace src{

    class ProcessHandler
    {
        
        public void ProcessHandle()
        {
           
            ProcessStartInfo startInfo = new ProcessStartInfo();    
            

            Process proc = new Process();
           startInfo.WorkingDirectory = $"{Environment.CurrentDirectory}/src";
            startInfo.CreateNoWindow = true;
            startInfo.UseShellExecute = false;
            startInfo.FileName = "CMD.exe";
            
           
            startInfo.Arguments = "/c java MainMaker.java";
            

            
            
            
            
           Process.Start(startInfo);
        }
        public void ProcessWritePadUI()
        {
            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.FileName = "CMD.exe";
            startInfo.WorkingDirectory = $"{Environment.CurrentDirectory}/src";
            startInfo.Arguments = "/c java WritePad.java";
            startInfo.CreateNoWindow = true;
            startInfo.UseShellExecute = false;
            Process.Start(startInfo);
        }
    }
}