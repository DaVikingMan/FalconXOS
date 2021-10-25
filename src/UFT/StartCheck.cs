using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace src
{
    class StartCheck
    {
        public void StartUpCheck()
        {
            
              var writer = new Writer();
              string writestring = "\nDisplay welcome screen";
              Console.Clear();
            List<string> templist = File.ReadAllLines($"{Environment.CurrentDirectory}/data/TempInputstream/main.inputstream").ToList();
            List<string> permalist = File.ReadAllLines($@"{Environment.CurrentDirectory}\data\PermanentInputStream\permainput.inputstream").ToList();
            if(permalist.Count == 1)
            {
                
                var Main = new Main();
                Main.MainStart();
                

            }else if(permalist.Count == 0)
            {
                writer.Write(writestring, "Temp" , true, $"{Environment.CurrentDirectory}/data/TempInputstream/main.inputstream");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Clear();
                Console.WriteLine("Welcome to FalconXOS's User-Friendly Terminal, a user-friendly terminal");
                Console.WriteLine("Important : As you know, FalconXOS has been in developement for 6 months and many of the main features have not been released");
                Console.WriteLine("As I am working alone the features take time to release.So if you know someone who is interested in contributing or if you are interested in contributing, Thanks a lot!This will help release features more faster and efficiently.\nAlso it is recommended to read the README to see where FalconXOS is and what it aims to be.");
                Console.WriteLine("\n\nFalconXOS is currently in Alpha stages and under extreme developement");
                
                Console.WriteLine("Press any key to continue to start screen");
                Console.ReadKey();
                var main = new Main();
                main.MainStart();
                
            }
            
        }
       
      
            
            
        
    }
}