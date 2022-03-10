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
              Console.Clear();

            List<string> templist = File.ReadAllLines($"{Environment.CurrentDirectory}/data/TempInputstream/main.inputstream").ToList();
            List<string> permalist = File.ReadAllLines($@"{Environment.CurrentDirectory}/data/PermanentInputStream/permainput.inputstream").ToList();
            List<string> configlist = File.ReadAllLines($@"{Environment.CurrentDirectory}/data/config/config.configc").ToList();
            
            
            if(permalist.Count == 0)
            {
                    
                string[] a = {"Delete:Stream", "Write:Note"};
                File.WriteAllLines($"{Environment.CurrentDirectory}/data/PermanentInputStream/permainput.inputstream", a);
                StartUpCheck();
                
            }else if(permalist.Count > 0)
            {
                List<string> listconfig = File.ReadAllLines($@"{Environment.CurrentDirectory}/data/config/config.configc").ToList();
                if(listconfig.Contains("Done:Note"))
                {

                }else
                {
                    var conver = new src.convert();
                    conver.convertClass();
                }
                
            }

            List<string> afterconfiglist = File.ReadAllLines($@"{Environment.CurrentDirectory}/data/config/config.configc").ToList();
            
                
                
                
            
           
            if(afterconfiglist.Count != 0)
            {
                    if(afterconfiglist[0] == "Delete:Stream" && afterconfiglist.Contains("Done:Note"))
                    {
                        Console.WriteLine("Done!");
                        

                    }else if(afterconfiglist[0] == "Delete:Stream" && afterconfiglist[1] == "Write:Note")
                    {
                        
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Clear();
                        Console.WriteLine("Welcome to FalconXOS's User-Friendly Terminal, a user-friendly terminal");
                        Console.WriteLine("Important : As you know, FalconXOS has been in developement for 6 months and many of the main features have not been released");
                        Console.WriteLine("As I am working alone the features take time to release.So if you know someone who is interested in contributing or if you are interested in contributing, Thanks a lot!This will help release features more faster and efficiently.\nAlso it is recommended to read the README to see where FalconXOS is and what it aims to be.");
                        Console.WriteLine("\n\nFalconXOS is currently in Alpha stages and under extreme developement");
                        Console.ReadKey();
                        
                        
                                    
                
                    }else
                    {
                        Console.WriteLine("Error inside block logic");
                        Console.ReadKey();
                    }
            }
            
            else
            {
                Console.WriteLine("Something's not right");
                Console.ReadKey();
            }
            
        }
       
      
            
            
        
    }
}