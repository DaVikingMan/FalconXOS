using System;
using System.IO;
using System.Threading;

namespace src
{
    class AccessUtlity
    {
        public void AccessProject(string FileK)
        {
            Console.Clear();
            Console.WriteLine("Type scp -access");
            Console.Write(">");
            string terminalcommand = Console.ReadLine();
            if(terminalcommand == "scp -access")
            {
                Console.WriteLine("Type the project name(dont include file extensions)");
                Console.Write(">");
                string yUCommand = Console.ReadLine();
                string filePathY = $@"{FileK}/{yUCommand}.txt";
                
                Thread.Sleep(100);
                Console.WriteLine("Adding a to-do list");
                
                string hcommand = "Yes";
                if(hcommand == "Yes")
                {
                    
                    Console.WriteLine("How many items do you want in the list(min : 1, max : 10)");
                    Console.Write(">");
                    string Hjcommand = Console.ReadLine();
                    if(Hjcommand == "1")
                    {
                        Console.WriteLine("Start typing");
                        Console.Write(">");
                    string cone = Console.ReadLine();

                    string[] a = 
                    {
                        "To-Do",
                        cone
                        
                    };
                    File.WriteAllLines(filePathY, a);

                    Console.WriteLine("Type Exit");
                    Console.Write(">");
                    string mcommand = Console.ReadLine();
                    if(mcommand == "Exit")
                    {
                        Utility l =new Utility();
                        l.VirtualUtility(FileK);
                    }else
                    {
                        Console.WriteLine("Wrong command");
                        Console.WriteLine("Returning");
                        Thread.Sleep(1000);

                        AccessProject(FileK);
                    }
                    

                    }else if(Hjcommand == "2")
                    {
                        Console.WriteLine("Start typing");
                        Console.Write(">");
                    string cone = Console.ReadLine();
                    Console.Write(">");
                    string ctwo = Console.ReadLine();
                    string[] a = 
                    {
                        "To-Do",
                        cone,
                        ctwo

                    };
                    File.WriteAllLines(filePathY, a);

                    Console.WriteLine("Type Exit");
                    Console.Write(">");
                    string mcommand = Console.ReadLine();
                    if(mcommand == "Exit")
                    {
                        Utility l =new Utility();
                        l.VirtualUtility(FileK);
                    }else
                    {
                        Console.WriteLine("Wrong command");
                        Console.WriteLine("Returning");
                        Thread.Sleep(1000);

                        AccessProject(FileK);
                    }
                    

                    }else if(Hjcommand == "3")
                    {
                        Console.WriteLine("Start typing");
                        Console.Write(">");
                    string cone = Console.ReadLine();
                    Console.Write(">");
                    string ctwo = Console.ReadLine();
                    Console.Write(">");
                    string cthree = Console.ReadLine();
                    string[] a = 
                    {
                        "To-Do",
                        cone,
                        ctwo,
                        cthree
                        
                    };
                    File.WriteAllLines(filePathY, a);

                    Console.WriteLine("Type Exit");
                    Console.Write(">");
                    string mcommand = Console.ReadLine();
                    if(mcommand == "Exit")
                    {
                        Utility l =new Utility();
                        l.VirtualUtility(FileK);
                    }else
                    {
                        Console.WriteLine("Wrong command");
                        Console.WriteLine("Returning");
                        Thread.Sleep(1000);

                        AccessProject(FileK);
                    }
                    
                        
                    }else if(Hjcommand == "4")
                    {
                        Console.WriteLine("Start typing");
                        Console.Write(">");
                    string cone = Console.ReadLine();
                    Console.Write(">");
                    string ctwo = Console.ReadLine();
                    Console.Write(">");
                    string cthree = Console.ReadLine();
                    Console.Write(">");
                    string cfour = Console.ReadLine();

                    string[] a = 
                    {
                        "To-Do",
                        cone,
                        ctwo,
                        cthree,
                        cfour
                        
                    };
                    File.WriteAllLines(filePathY, a);

                    Console.WriteLine("Type Exit");
                    Console.Write(">");
                    string mcommand = Console.ReadLine();
                    if(mcommand == "Exit")
                    {
                        Utility l =new Utility();
                        l.VirtualUtility(FileK);
                    }else
                    {
                        Console.WriteLine("Wrong command");
                        Console.WriteLine("Returning");
                        Thread.Sleep(1000);

                        AccessProject(FileK);
                    }
                    
                        
                    }else if(Hjcommand == "5")
                    {
                        Console.WriteLine("Start typing");
                        Console.Write(">");
                    string cone = Console.ReadLine();
                    Console.Write(">");
                    string ctwo = Console.ReadLine();
                    Console.Write(">");
                    string cthree = Console.ReadLine();
                    Console.Write(">");
                    string cfour = Console.ReadLine();
                    Console.Write(">");
                    string cfive = Console.ReadLine();

                    string[] a = 
                    {
                        "To-Do",
                        cone,
                        ctwo,
                        cthree,
                        cfour,
                        cfive
                    };
                    File.WriteAllLines(filePathY, a);

                    Console.WriteLine("Type Exit");
                    Console.Write(">");
                    string mcommand = Console.ReadLine();
                    if(mcommand == "Exit")
                    {
                        Utility l =new Utility();
                        l.VirtualUtility(FileK);
                    }else
                    {
                        Console.WriteLine("Wrong command");
                        Console.WriteLine("Returning");
                        Thread.Sleep(1000);

                        AccessProject(FileK);
                    }
                    
                        
                    }else if(Hjcommand == "6")
                    {
                        Console.WriteLine("Start typing");
                        Console.Write(">");
                    string cone = Console.ReadLine();
                    Console.Write(">");
                    string ctwo = Console.ReadLine();
                    Console.Write(">");
                    string cthree = Console.ReadLine();
                    Console.Write(">");
                    string cfour = Console.ReadLine();
                    Console.Write(">");
                    string cfive = Console.ReadLine();
                    Console.Write(">");
                    string csix = Console.ReadLine();
                    string[] a = 
                    {
                        "To-Do",
                        cone,
                        ctwo,
                        cthree,
                        cfour,
                        cfive,
                        csix
                    };
                    File.WriteAllLines(filePathY, a);

                    Console.WriteLine("Type Exit");
                    Console.Write(">");
                    string mcommand = Console.ReadLine();
                    if(mcommand == "Exit")
                    {
                        Utility l =new Utility();
                        l.VirtualUtility(FileK);
                    }else
                    {
                        Console.WriteLine("Wrong command");
                        Console.WriteLine("Returning");
                        Thread.Sleep(1000);

                        AccessProject(FileK);
                    }
                    
                        
                    }else if(Hjcommand == "7")
                    {
                        Console.WriteLine("Start typing");
                        Console.Write(">");
                    string cone = Console.ReadLine();
                    Console.Write(">");
                    string ctwo = Console.ReadLine();
                    Console.Write(">");
                    string cthree = Console.ReadLine();
                    Console.Write(">");
                    string cfour = Console.ReadLine();
                    Console.Write(">");
                    string cfive = Console.ReadLine();
                    Console.Write(">");
                    string csix = Console.ReadLine();
                    Console.Write(">");
                    string cseven = Console.ReadLine();

                    string[] a = 
                    {
                        "To-Do",
                        cone,
                        ctwo,
                        cthree,
                        cfour,
                        cfive, 
                        csix,
                        cseven
                    };
                    File.WriteAllLines(filePathY, a);

                    Console.WriteLine("Type Exit");
                    Console.Write(">");
                    string mcommand = Console.ReadLine();
                    if(mcommand == "Exit")
                    {
                        Utility l =new Utility();
                        l.VirtualUtility(FileK);
                    }else
                    {
                        Console.WriteLine("Wrong command");
                        Console.WriteLine("Returning");
                        Thread.Sleep(1000);

                        AccessProject(FileK);
                    }
                    
                        
                    }else if(Hjcommand == "8")
                    {
                        Console.WriteLine("Start typing");
                        Console.Write(">");
                    string cone = Console.ReadLine();
                    Console.Write(">");
                    string ctwo = Console.ReadLine();
                    Console.Write(">");
                    string cthree = Console.ReadLine();
                    Console.Write(">");
                    string cfour = Console.ReadLine();
                    Console.Write(">");
                    string cfive = Console.ReadLine();
                    Console.Write(">");
                    string csix = Console.ReadLine();
                    Console.Write(">");
                    string cseven = Console.ReadLine();
                    Console.Write(">");
                    string ceight = Console.ReadLine();

                    string[] a = 
                    {
                        "To-Do",
                        cone,
                        ctwo,
                        cthree,
                        cfour,
                        cfive,
                        csix,
                        cseven, 
                        ceight
                    };
                    File.WriteAllLines(filePathY, a);

                    Console.WriteLine("Type Exit");
                    Console.Write(">");
                    string mcommand = Console.ReadLine();
                    if(mcommand == "Exit")
                    {
                        Utility l =new Utility();
                        l.VirtualUtility(FileK);
                    }else
                    {
                        Console.WriteLine("Wrong command");
                        Console.WriteLine("Returning");
                        Thread.Sleep(1000);

                        AccessProject(FileK);
                    }
                    
                        
                    }else if(Hjcommand == "9")
                    {
                        Console.WriteLine("Start typing");
                        Console.Write(">");
                    string cone = Console.ReadLine();
                    Console.Write(">");
                    string ctwo = Console.ReadLine();
                    Console.Write(">");
                    string cthree = Console.ReadLine();
                    Console.Write(">");
                    string cfour = Console.ReadLine();
                    Console.Write(">");
                    string cfive = Console.ReadLine();
                    Console.Write(">");
                    string csix = Console.ReadLine();
                    Console.Write(">");
                    string cseven = Console.ReadLine();
                    Console.Write(">");
                    string ceight = Console.ReadLine();
                    Console.Write(">");
                    string cnine = Console.ReadLine();
                    string[] a = 
                    {
                        "To-Do",
                        cone,
                        ctwo,
                        cthree,
                        cfour,
                        cfive,
                        csix, 
                        cseven,
                        ceight,
                        cnine
                    };
                    File.WriteAllLines(filePathY, a);

                    Console.WriteLine("Type Exit");
                    Console.Write(">");
                    string mcommand = Console.ReadLine();
                    if(mcommand == "Exit")
                    {
                        Utility l =new Utility();
                        l.VirtualUtility(FileK);
                    }else
                    {
                        Console.WriteLine("Wrong command");
                        Console.WriteLine("Returning");
                        Thread.Sleep(1000);

                        AccessProject(FileK);
                    }
                    
                        
                    }else if(Hjcommand == "10")
                    {
                        Console.WriteLine("Start typing");
                        Console.Write(">");
                    string cone = Console.ReadLine();
                    Console.Write(">");
                    string ctwo = Console.ReadLine();
                    Console.Write(">");
                    string cthree = Console.ReadLine();
                    Console.Write(">");
                    string cfour = Console.ReadLine();
                    Console.Write(">");
                    string cfive = Console.ReadLine();
                    Console.Write(">");
                    string csix = Console.ReadLine();
                    Console.Write(">");
                    string cseven = Console.ReadLine();
                    Console.Write(">");
                    string ceight = Console.ReadLine();
                    Console.Write(">");
                    string cnine = Console.ReadLine();
                    Console.Write(">");
                    string cten = Console.ReadLine();
                    string[] a = 
                    {
                        "To-Do",
                        cone,
                        ctwo,
                        cthree,
                        cfour,
                        cfive,
                        csix,
                        cseven,
                        ceight,
                        cnine,
                        cten
                    };
                    File.WriteAllLines(filePathY, a);

                    Console.WriteLine("Type Exit");
                    Console.Write(">");
                    string mcommand = Console.ReadLine();
                    if(mcommand == "Exit")
                    {
                        Utility l =new Utility();
                        l.VirtualUtility(FileK);
                    }else
                    {
                        Console.WriteLine("Wrong command");
                        Console.WriteLine("Returning");
                        Thread.Sleep(100);
                        

                        AccessProject(FileK);
                    }
                        
                    }
                    

            }else if(hcommand == "/command Exit")
            {
                Console.WriteLine("Exiting");
                Thread.Sleep(100);
                AccessProject(FileK);

            }else
            {
                Console.WriteLine("Wrong command");
                Console.WriteLine("Returning");
                Thread.Sleep(100);
                AccessProject(FileK);
            }

        }
    }
}
}
