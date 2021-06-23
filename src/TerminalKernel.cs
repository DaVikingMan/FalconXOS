using System.Diagnostics;
using System;
using System.Collections.Generic;

namespace src
{
    class TerminalKernel // Opens the specified App
    {
        public void TerminalHandler()
        {
            Console.WriteLine("Define Starting Directory(full path)");
            string w = Console.ReadLine(); // Defines in which directory to open the terminal
            ProcessStartInfo m = new ProcessStartInfo();
            
            m.WorkingDirectory = w;
            m.UseShellExecute = true;
            m.CreateNoWindow = false;
            m.FileName = "powershell.exe"; // Opens the specified terminal in working directory 'w'
            Process.Start(m);

            
        }
    }
    
}