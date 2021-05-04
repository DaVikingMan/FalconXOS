using System;
using System.IO;

namespace src{
    class ProjectView
    {
        public void View()
        {
            Console.Clear();
            Console.WriteLine("Type scc -- view");
            Console.Write(">");
            string Bcommand = Console.ReadLine();
            if(Bcommand == "scc --view")
            {
               Console.WriteLine("Type the filePath where your project to-do list is stored");
               Console.Write(">");
               string yCommand = Console.ReadLine();
               string filePath = $@"{yCommand}";
               Console.Clear();
               var t = File.ReadAllText(filePath);
               Console.WriteLine(t);
               Console.WriteLine("This was your list's to-do");
               Console.WriteLine("Type Exit or Stay");
               string hcommand = Console.ReadLine();
               if(hcommand == "Exit")
               {
                   Utility m = new Utility();
                   m.VirtualUtility();
               }else if(hcommand == "Stay")
               {
                   View();
               }
                  
            }
        }
    }
}