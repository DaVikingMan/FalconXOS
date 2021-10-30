using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace src
{
    class convert
    {
        public void convertClass()
        {
            string _path = $@"{Environment.CurrentDirectory}\data\config\config.configc";
            List<string> readpath = File.ReadAllLines($"{Environment.CurrentDirectory}/data/PermanentInputStream/permainput.inputstream").ToList();

            File.WriteAllLines(_path , readpath);
        }
    }
}