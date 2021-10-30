using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace startfi
{
    class readonlyinput // Alternate name for writefi//memory
    {
        public void StartRemove(string[] filestring, bool isplanned)
        {
            List<string> file = File.ReadAllLines($"{Environment.CurrentDirectory}/data/debuglogs/debug.log").ToList();
            List<string> filelist = filestring.ToList();
            string filestringlist = filestring.ToString();
            if(!file.Contains(filestringlist))
            {
                    File.WriteAllLines($"{Environment.CurrentDirectory}/data/debuglogs/debug.log", filestring);
                    Console.WriteLine("Written to log : expected to be written to temp inputstream");
                    
                    if(isplanned == true)
                    Console.WriteLine("It seems like this hasn't been implemented yet, see planned features in /plannedfeatures.doc to see if this implementation is planned to release in this release(Just a note, yes this is being released to FalconXOS)");
                    else
                    {
                        Console.WriteLine("It seems like this hasn't been implemented yet, see planned features in /plannedfeatures.doc to see if this implementation is planned to release in this release");
                        Console.WriteLine("Ended writefi//memory");
                    }
            }else
            {
                Console.WriteLine("Log already written");
                
            }
           
            
        }
    }
}