using System;
using System.Diagnostics;
using System.Threading;

namespace src
{
    class close
    {
        public void closeCommand()
        {
            Console.WriteLine("Define Starting Directory(full path)");
            string w = Console.ReadLine();
            ProcessStartInfo m = new ProcessStartInfo();
            
            m.WorkingDirectory = w;
            m.UseShellExecute = true;
            m.CreateNoWindow = false;
            m.FileName = "powershell.exe";
            Process.Start(m);
            Thread.Sleep(1000);
            Console.WriteLine("Exiting:");
            Menu menu = new Menu();
            menu.MenuMain();

        }
    }
}