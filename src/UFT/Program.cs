using System;
using System.IO;
using System.Linq;

namespace src // default namespace
{

    public class Program // The first class that is executed when running FalconXOS's UFT(User-Friendly Terminal)
    {
        public static void Main(string[] args) // string args is not used
        {
            string file = $"{Environment.CurrentDirectory}/data/TempInputstream/main.inputstream";
            var readlist = File.ReadAllLines(file).ToList();
            var startup = new StartCheck();
            startup.StartUpCheck();
            
            
           
            
        }
    }
}
