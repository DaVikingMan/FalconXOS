using System;
using System.Diagnostics;

/*
      This command is used to execute commands to run 'MainMaker.java' and 'WritePad.java'
*/

namespace src{

    class ProcessHandler
    {
        
        public void ProcessHandle() // Runs MainMaker.java
        {
           
            ProcessStartInfo startInfo = new ProcessStartInfo();    
            

            Process proc = new Process();
           startInfo.WorkingDirectory = $"{Environment.CurrentDirectory}/apps"; // Defines where MainMaker is located
            startInfo.CreateNoWindow = true;  // Creates no Window
            startInfo.UseShellExecute = false; // Tells the command to not use shell execute

            startInfo.FileName = "/bin/bash"; // Tells to run the sepcified command in CMD(Command Prompt) 
            
           
            startInfo.Arguments = "-c \"java MainMaker.java\""; // Specifies which command to run

            

            
            
            
            
           Process.Start(startInfo); // Runs the command
        }
        public void ProcessWritePadUI() // Used for running WritePad.java
        {
            ProcessStartInfo startInfo = new ProcessStartInfo();

            startInfo.FileName = "/bin/bash";
            startInfo.WorkingDirectory = $"{Environment.CurrentDirectory}/apps";
            startInfo.Arguments = "-c  \"java WritePad.java\"";

            startInfo.CreateNoWindow = true;
            startInfo.UseShellExecute = false;
            Process.Start(startInfo);
        }
    }

}
