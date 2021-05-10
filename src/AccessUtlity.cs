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
                Console.WriteLine("Tyoe the project name(dont include file extensio)");
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
                    }
                    

                    }else if(Hjcommand == "2")
                    {
                        Console.WriteLine("Start typing");
                    string cone = Console.ReadLine();
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
                    }
                    

                    }else if(Hjcommand == "3")
                    {
                        Console.WriteLine("Start typing");
                    string cone = Console.ReadLine();
                    string ctwo = Console.ReadLine();
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
                    }
                    
                        
                    }else if(Hjcommand == "4")
                    {
                        Console.WriteLine("Start typing");
                    string cone = Console.ReadLine();
                    string ctwo = Console.ReadLine();
                    string cthree = Console.ReadLine();
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
                    }
                    
                        
                    }else if(Hjcommand == "5")
                    {
                        Console.WriteLine("Start typing");
                    string cone = Console.ReadLine();
                    string ctwo = Console.ReadLine();
                    string cthree = Console.ReadLine();
                    string cfour = Console.ReadLine();
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
                    }
                    
                        
                    }else if(Hjcommand == "6")
                    {
                        Console.WriteLine("Start typing");
                    string cone = Console.ReadLine();
                    string ctwo = Console.ReadLine();
                    string cthree = Console.ReadLine();
                    string cfour = Console.ReadLine();
                    string cfive = Console.ReadLine();
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
                    }
                    
                        
                    }else if(Hjcommand == "7")
                    {
                        Console.WriteLine("Start typing");
                    string cone = Console.ReadLine();
                    string ctwo = Console.ReadLine();
                    string cthree = Console.ReadLine();
                    string cfour = Console.ReadLine();
                    string cfive = Console.ReadLine();
                    string csix = Console.ReadLine();
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
                    }
                    
                        
                    }else if(Hjcommand == "8")
                    {
                        Console.WriteLine("Start typing");
                    string cone = Console.ReadLine();
                    string ctwo = Console.ReadLine();
                    string cthree = Console.ReadLine();
                    string cfour = Console.ReadLine();
                    string cfive = Console.ReadLine();
                    string csix = Console.ReadLine();
                    string cseven = Console.ReadLine();
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
                    }
                    
                        
                    }else if(Hjcommand == "9")
                    {
                        Console.WriteLine("Start typing");
                    string cone = Console.ReadLine();
                    string ctwo = Console.ReadLine();
                    string cthree = Console.ReadLine();
                    string cfour = Console.ReadLine();
                    string cfive = Console.ReadLine();
                    string csix = Console.ReadLine();
                    string cseven = Console.ReadLine();
                    string ceight = Console.ReadLine();
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
                    }
                    
                        
                    }else if(Hjcommand == "10")
                    {
                        Console.WriteLine("Start typing");
                    string cone = Console.ReadLine();
                    string ctwo = Console.ReadLine();
                    string cthree = Console.ReadLine();
                    string cfour = Console.ReadLine();
                    string cfive = Console.ReadLine();
                    string csix = Console.ReadLine();
                    string cseven = Console.ReadLine();
                    string ceight = Console.ReadLine();
                    string cnine = Console.ReadLine();
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
                        Thread.Sleep(100);
                        AccessProject(filePathY);
                    }
                        
                    }
                    

                }

        }
    }
}
}
