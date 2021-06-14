using System;
using System.IO;
using System.Diagnostics.Tracing;
using System.Threading;
using System.Diagnostics;
using System.Timers;

namespace src{
    class ProjectView
    {
        public void View(string dirFile)
        {
            
            Console.Clear();
            Console.WriteLine("Type sc --view for viewing the file");
            
            Console.Write(">");
            string Bcommand = Console.ReadLine();
            if(Bcommand == "sc --view")
            {
               Console.WriteLine("Type the project's name");
               Console.Write(">");
               string yCommand = Console.ReadLine();
               string filePath = $@"{dirFile}/{yCommand}.txt";
               Console.Clear();
               var t = File.ReadAllText(filePath);
               Console.WriteLine(t);
               Console.WriteLine("This was your list's to-do");
               Console.WriteLine("Type Exit or Stay");
               Console.Write(">");
               string hcommand = Console.ReadLine();
               if(hcommand == "Exit")
               {
                   Utility m = new Utility();
                   m.VirtualUtility();
               }else if(hcommand == "Stay")
               {
                   View(dirFile);
               }else
               {
                   
                   
                   
                   Console.WriteLine("Wrong command");
                   Thread.Sleep(100);
                   View(dirFile);
                   
                   
                    
                    
                   
               }
                  
            }else{
                Console.WriteLine("Wrong command");
                Thread.Sleep(1000);
                View(dirFile);
            }
        }
    }
}