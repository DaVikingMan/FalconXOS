using System;
using System.IO;
using System.Threading;

namespace src{
    class ProjectManager // Executes when running Project Manager in the menu
    {
        public void Manager(string Zcommand) // Main method of this class
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Clear();
            Console.WriteLine("Type scp -new for creating a new project(This is used to add the projects for better organization of the projects which you have created)");
            Console.Write(">");
            string n = Console.ReadLine();
            if(n == "scp -new") // If you want to create a new Project Manager file
            {
                Console.WriteLine("Type the project's name : ");
                string h = Console.ReadLine();
                Console.WriteLine("Adding Project-Manager object");
                
                string k = "Yes";
                if(k == "Yes")
                {
                    Console.WriteLine("Okay!\nAdding");
                    
                    string filePath = $@"{Zcommand}/{h}.txt";
                    FileStream fileStream = new FileStream(filePath, FileMode.OpenOrCreate);
                    fileStream.Close();
                    Console.WriteLine("Do you want to add a file system(which will store file paths of your projects)?");
                    string nread = Console.ReadLine();
                    if(nread == "Yes")
                    {
                        Console.WriteLine("Initializing");
                        Thread.Sleep(1000);
                        Console.WriteLine("Adding object");
                        Thread.Sleep(1000);
                        Console.Clear();
                        FileSystem filetake = new FileSystem();
                        filetake.system(filePath); 

                        
                        
                        
                        
                    }else if(nread == "No")
                    {
                        Console.WriteLine("Exiting");
                        Thread.Sleep(100);
                        Utility kUtlity = new Utility();
                        kUtlity.VirtualUtility();


                    }else
                    {
                        Console.WriteLine("Wrong command");
                        Console.WriteLine("Returning back");
                        Manager(Zcommand);
                    } 
                    Console.WriteLine("Type Exit for finshing the request");
                    Console.Write(">");
                    string u = Console.ReadLine();
                    if(u == "Exit")
                    {
                        Utility kUtlity = new Utility();
                        kUtlity.VirtualUtility();
                    }else
                    {
                        Console.WriteLine("Wrong command");

                        Thread.Sleep(100);
                        Console.WriteLine("Exiting the utility as no state exists after this");
                        Thread.Sleep(100);
                        Utility utility = new Utility();
                        utility.VirtualUtility();
                    }
                    
                }
                
            }else if(n == "/command Exit")
            {
                   var k = new Utility();
                   k.VirtualUtility();
            }else
            {
                Console.WriteLine("Wrong command");
                Thread.Sleep(100);
                Manager(Zcommand);
            }
        }
    }
}