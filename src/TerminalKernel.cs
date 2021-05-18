using System.Diagnostics;
using System;
using System.Collections.Generic;

namespace src
{
    class TerminalKernel
    {
        public void TerminalHandler()
        {
            Console.WriteLine("Define Starting Directory(full path)");
            string w = Console.ReadLine();
            ProcessStartInfo m = new ProcessStartInfo();
            
            m.WorkingDirectory = w;
            m.UseShellExecute = true;
            m.CreateNoWindow = false;
            m.FileName = "powershell.exe";
            Process.Start(m);

            
        }
    }
    
}