using System;
using System.Threading;
using System.Diagnostics;

namespace dev
{
    class DevConsole
    {
         public void MainConsole()
         {
             Console.WriteLine("Input :: ????");
             Console.WriteLine("InputStream Chosen : readonly-edit::");
             Console.WriteLine("Done :: Opened Console:Dev, Console:Input, Receive:Input");
             Thread.Sleep(2000);
             Console.Clear();
             Console.WriteLine(">> ");
         }
    }
}