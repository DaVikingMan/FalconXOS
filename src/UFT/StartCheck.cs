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
                Console.WriteLine("Welcome to FalconXOS's User-Friendly Terminal");
                Console.WriteLine("FalconXOS is currently in Alpha stages and under extreme developement");
                Console.WriteLine("If you want to contribute to FalconXOS, then it is recommended to read the contributing guidelines prior to contributing\n\n");
                Console.WriteLine("Press any key to continue to start screen");
                Console.ReadKey();
                var main = new Main();
                main.MainStart();
                
            }
            
        }
       
      
            
            
        
    }
}