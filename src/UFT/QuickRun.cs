using System;
using System.Diagnostics;

namespace src{
    class QuickRun
    {
        public void QuickRunMethod()
        {
            Console.Clear();
            Console.WriteLine("Type the name of a runnable file or the path of it");
            Console.Write(">");
            string readRunnable = Console.ReadLine();
            if(readRunnable == "/command Exit")
            {
                var m = new Menu();
                m.MenuMain();
                QuickRunMethod();
            }
            else{
                RunFile(readRunnable);
                QuickRunMethod();
            }
            
            
        }
        public void RunFile(string path)
        {
            var start = new ProcessStartInfo();

            start.Arguments = $"/c {path}";
            start.UseShellExecute = true;
            start.FileName = "powershell.exe";
            start.CreateNoWindow = true;
            Process.Start(start);
        }
    }

}

