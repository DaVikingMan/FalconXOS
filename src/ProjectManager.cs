using System;
using System.IO;

namespace src{
    class ProjectManager
    {
        public void Manager()
        {
            Console.WriteLine("Type scp -new for creating a new project(This is used to add the projects for better organization of the projects which you have created)");
            Console.Write(">");
            string n = Console.ReadLine();
            if(n == "scp -new")
            {
                Console.WriteLine("Type your project name : ");
                string h = Console.ReadLine();
                Console.WriteLine("Adding Project-Manager object, press a key to continue");
                
                string k = "Yes";
                if(k == "Yes")
                {
                    Console.WriteLine("Okay!\nAdding");
                    Console.WriteLine("Type your file which you want to create which will store the projects info");
                    Console.Write(">");
                    string j = Console.ReadLine();
                    string filePath = $@"{j}";
                    FileStream fileStream = new FileStream(filePath, FileMode.OpenOrCreate);
                    fileStream.Close();
                    Console.WriteLine("Type Exit for finshing the request");
                    Console.Write(">");
                    string u = Console.ReadLine();
                    if(u == "Exit")
                    {
                        Utility kUtlity = new Utility();
                        kUtlity.VirtualUtility();
                    }
                    
                }
                
            }
        }
    }
}