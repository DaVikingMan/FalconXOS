using System;
using System.IO;

namespace src{
    class ProjectView
    {
        public void View(string dirFile)
        {
            Console.Clear();
            Console.WriteLine("Type scc -- view");
            Console.Write(">");
            string Bcommand = Console.ReadLine();
            if(Bcommand == "scc --view")
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
               string hcommand = Console.ReadLine();
               if(hcommand == "Exit")
               {
                   Utility m = new Utility();
                   m.VirtualUtility(dirFile);
               }else if(hcommand == "Stay")
               {
                   View(dirFile);
               }
                  
            }
        }
    }
}