using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading;

namespace src
{
    class Shortcut
    {
        public void ShortcutPage() // Start for the Shortcuts command
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Clear();
            Console.WriteLine("Type 'scc --new' for creating a new shortcut file or type 'scc --runload' for running a created shortcut\nRun scc --o for adding shortcuts\nType '/command Exit' to exit");
            
            Console.Write(">");
            string Kcommand = Console.ReadLine();
            if(Kcommand == "scc --new") // Goes to the specified class
            {

                     ShortcutInteface();
              
            }else if(Kcommand == "scc --runload") // Goes to the specified class
            {
                
                 AlSharp();
            }else if(Kcommand == "scc --o") // Goes to the specified class
            {
                e();
            }else if(Kcommand == "/command Exit") // Exits the command
            {
                Thread.Sleep(100);
                Menu m = new Menu();
                m.MenuMain();

            }else{ // if the command is wrong
                Console.WriteLine("Wrong command");
                Thread.Sleep(100);
                ShortcutPage();
            }
        }
        public void ShortcutInteface() // Creates a 'shortcut' file
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Clear(); // Clears the console
            
            
            
            
            
                
            
            
            string secondaryDirectory = $"{Environment.CurrentDirectory}/data/Shortcuts"; // Specifies where to store the file
            Console.WriteLine("Type the name of the file which you want to create(dont include file extension)");
            Console.Write(">"); // Prompt to write the name of the file which you want to create 
            string secondaryFile = Console.ReadLine();
            Console.WriteLine("Creating File for storing shortcuts....");
            string dirs = $@"{secondaryDirectory}\{secondaryFile}.txt"; // Path for the created file
            if(File.Exists(dirs)) // If this file already exists
            {
                Console.WriteLine("The file of this name already exists");
                Console.WriteLine("Returning back");
                Thread.Sleep(1000);
                ShortcutInteface();


            }else if(!File.Exists(dirs)) // If the file doesn't exist
            {
                FileStream stream = new FileStream(dirs, FileMode.Create);
                stream.Close();
                Console.WriteLine("Do you want to add shortcuts now?");
                Console.Write(">");
                string read = Console.ReadLine();
                if(read == "Yes")
                {
                       e();
                }else
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("No such command exists");
                    Thread.Sleep(100);
                    ShortcutInteface();
                }
            }
            

            Console.Clear();
                        
            
            
            
            


            Console.WriteLine("Type Exit");
            Console.Write(">");
            string Lcomamnd = Console.ReadLine();
            if(Lcomamnd == "Exit")
            {
                ShortcutPage();
                
                    
                
                

            }else // If the command is wrong
            {
                Console.WriteLine("Wrong command");
                Console.WriteLine("Exiting as nothing exists after this in this utility");
                Thread.Sleep(100);
                ShortcutPage();
            }
            
                
            }




            
            

            

            

        
        
        public void AlSharp() // If you want to run the shortcuts in a shortcut file
        {
            
            Console.Clear();
            Console.WriteLine("Type the filename");
            Console.Write(">"); 
            var f = Console.ReadLine(); // Asks to type the name of the shortcut file
            if(f == "/command Exit")
            {
                ShortcutPage();
            }
            string filePath = $@"{Environment.CurrentDirectory}/data/Shortcuts/{f}.txt"; // Specifies the path for the specified file
            if(!File.Exists(filePath)) // If the file doesn't exist
            {
                Console.WriteLine("File doesn't exist");
                Console.WriteLine(
                    "Returning"
                );
                Thread.Sleep(1000);
                AlSharp();
            }
            // If the file exists
            var h = File.ReadAllText(filePath).ToArray();
            Console.WriteLine(h);
            if(h.Length == 1) // If the number of shortcuts in a file is 1
            {
                
                   Console.WriteLine(h[0]);
            }else if(h.Length == 2) // If the number of shortcuts in a file is 2
            {
                Console.WriteLine(h[0]);
                Console.WriteLine(h[1]);

            }else if(h.Length == 3) // If the number of shortcuts in a file is 3
            {
                Console.WriteLine(h[0]);
                Console.WriteLine(h[1]);
                
                Console.WriteLine(h[2]);
                Console.WriteLine(h[3]);
                
            }else if(h.Length == 4) // If the number of shortcuts in a file is 4
            {
                Console.WriteLine(h[0]);
                Console.WriteLine(h[1]);
                
                Console.WriteLine(h[2]);
                Console.WriteLine(h[3]);
                Console.WriteLine(h[4]);

                
            }else if(h.Length == 5) // If the number of shortcuts in a file is 5
            {
                Console.WriteLine(h[0]);
                Console.WriteLine(h[1]);
                
                Console.WriteLine(h[2]);
                Console.WriteLine(h[3]);
                Console.WriteLine(h[4]);
                Console.WriteLine(h[5]);
                
            }else if(h.Length == 6) // If the number of shortcuts in a file is 6
            {
                Console.WriteLine(h[0]);
                Console.WriteLine(h[1]);
                
                Console.WriteLine(h[2]);
                Console.WriteLine(h[3]);
                Console.WriteLine(h[4]);
                Console.WriteLine(h[5]);
                Console.WriteLine(h[6]);
                
            }else if(h.Length == 7) // If the number of shortcuts in a file is 7
            {
                Console.WriteLine(h[0]);
                Console.WriteLine(h[1]);
                
                Console.WriteLine(h[2]);
                Console.WriteLine(h[3]);
                Console.WriteLine(h[4]);
                Console.WriteLine(h[5]);
                Console.WriteLine(h[6]);
                Console.WriteLine(h[7]);
                
            }else if(h.Length == 8) // If the number of shortcuts in a file is 8
            {
                Console.WriteLine(h[0]);
                Console.WriteLine(h[1]);
                Console.WriteLine("");
                Console.WriteLine(h[2]);
                Console.WriteLine(h[3]);
                Console.WriteLine("");
                Console.WriteLine(h[4]);
                Console.WriteLine(h[5]);
                Console.WriteLine("");
                Console.WriteLine(h[6]);
                Console.WriteLine(h[7]);
                Console.WriteLine("");
                Console.WriteLine(h[8]);
                
            }else if(h.Length == 9) // If the number of shortcuts in a file is 9
            {
                Console.WriteLine(h[0]);
                Console.WriteLine(h[1]);
                Console.WriteLine("");
                Console.WriteLine(h[2]);
                Console.WriteLine(h[3]);
                Console.WriteLine("");
                Console.WriteLine(h[4]);
                Console.WriteLine(h[5]);
                Console.WriteLine("");
                Console.WriteLine(h[6]);
                Console.WriteLine(h[7]);
                Console.WriteLine("");
                Console.WriteLine(h[8]);
                Console.WriteLine(h[9]);
                
            }else if(h.Length == 10) // If the number of shortcuts in a file is 10
            {
                Console.WriteLine(h[0]);
                Console.WriteLine(h[1]);
                Console.WriteLine("");
                Console.WriteLine(h[2]);
                Console.WriteLine(h[3]);
                Console.WriteLine("");
                Console.WriteLine(h[4]);
                Console.WriteLine(h[5]);
                Console.WriteLine("");
                Console.WriteLine(h[6]);
                Console.WriteLine(h[7]);
                Console.WriteLine("");
                Console.WriteLine(h[8]);
                Console.WriteLine(h[9]);
                Console.WriteLine("");
                Console.WriteLine(h[10]);
                
            }
            Console.WriteLine("Type run n<num>");
            string v = Console.ReadLine(); // Prompts you to tell which shortcut you want to run

            if(v == "run n<1>") // If you want to run the first shortcut
            {
                var g = File.ReadAllLines(filePath).Skip(1).Take(1).First();
                ProcessStartInfo p = new ProcessStartInfo();
                p.UseShellExecute = true;
                p.FileName = g;
                Process.Start(g);
                Console.ReadKey();
                Console.WriteLine("Type Exit or Stay");
                Console.Write(">");
                string command = Console.ReadLine();
                if(command == "Exit")
                {
                    ShortcutPage();
                }else if(command == "Stay")
                {
                    AlSharp();
                }else
                {
                    Console.WriteLine("Wrong command");
                    Thread.Sleep(100);
                    AlSharp();
                }

            }else if(v == "run n<2>") // If you want to run the first shortcut
            {
                var g = File.ReadAllLines(filePath).Skip(3).Take(1).First();
                ProcessStartInfo o = new ProcessStartInfo();
                o.UseShellExecute = true;
                o.FileName = g;
                Process.Start(g);
                
                Console.ReadKey();
                Console.WriteLine("Type Exit or Stay");
                Console.Write(">");
                string command = Console.ReadLine();
                if(command == "Exit")
                {
                    ShortcutPage();
                }else if(command == "Stay")
                {
                    AlSharp();
                }else
                {
                    Console.WriteLine("Wrong command");
                    Thread.Sleep(100);
                    AlSharp();
                }
                
            }else if(v == "run n<3>") // If you want to run the first shortcut
            {
                var g = File.ReadAllLines(filePath).Skip(5).Take(1).First();
                ProcessStartInfo info = new ProcessStartInfo();
                info.UseShellExecute = true;
                info.FileName = g;
                Process.Start(g);
                
                Console.ReadKey();
                Console.WriteLine("Type Exit or Stay");
                Console.Write(">");
                string command = Console.ReadLine();
                if(command == "Exit")
                {
                        ShortcutPage();
                }else if(command == "Stay")
                {
                    AlSharp();
                }else
                {
                    Console.WriteLine("Wrong command");
                    Thread.Sleep(100);
                    AlSharp();
                }
                
            }else if(v == "run n<4>") // If you want to run the first shortcut
            {
                var g = File.ReadAllLines(filePath).Skip(7).Take(1).First();
                ProcessStartInfo u = new ProcessStartInfo();
                u.UseShellExecute = true;
                u.FileName = g;
                Process.Start(g);
                
                Console.ReadKey();
                Console.WriteLine("Type Exit or Stay");
                Console.Write(">");
                string command = Console.ReadLine();
                if(command == "Exit")
                {
                        ShortcutPage();
                }else if(command == "Stay")
                {
                    AlSharp();
                }else
                {
                    Console.WriteLine("Wrong command");
                    Thread.Sleep(100);
                    AlSharp();
                }
                
            }else if(v == "run n<5>") // If you want to run the fifth shortcut
            {
                var g = File.ReadAllLines(filePath).Skip(9).Take(1).First();
                ProcessStartInfo z = new ProcessStartInfo();
                z.UseShellExecute = true;
                z.FileName = g;
                Process.Start(g);
                
                Console.ReadKey();
                Console.WriteLine("Type Exit or Stay");
                Console.Write(">");
                string command = Console.ReadLine();
                if(command == "Exit")
                {
                        ShortcutPage();
                }else if(command == "Stay")
                {
                    AlSharp();
                }else
                {
                    Console.WriteLine("Wrong command");
                    Thread.Sleep(100);
                    AlSharp();
                }
                
            }else if(v == "run n<6>") // If you want to run the sixth shortcut
            {
                var g = File.ReadAllLines(filePath).Skip(11).Take(1).First();
                ProcessStartInfo w = new ProcessStartInfo();
                w.UseShellExecute = true;
                w.FileName = g;
                Process.Start(g);
                
                Console.ReadKey();
                Console.WriteLine("Type Exit or Stay");
                Console.Write(">");
                string command = Console.ReadLine();
                if(command == "Exit")
                {
                        ShortcutPage();
                }else if(command == "Stay")
                {
                    AlSharp();
                }else
                {
                    Console.WriteLine("Wrong command");
                    Thread.Sleep(100);
                    AlSharp();
                }
                
            }else if(v == "run n<7>") // If you want to run the seventh shortcut
            {
                var g = File.ReadAllLines(filePath).Skip(13).Take(1).First();
                ProcessStartInfo n = new ProcessStartInfo();
                n.UseShellExecute = true;
                n.FileName = g;
                Process.Start(g);
                
                Console.ReadKey();
                Console.WriteLine("Type Exit or Stay");
                Console.Write(">");
                string command = Console.ReadLine();
                if(command == "Exit")
                {
                        ShortcutPage();
                }else if(command == "Stay")
                {
                    AlSharp();
                }else
                {
                    Console.WriteLine("Wrong command");
                    Thread.Sleep(100);
                    AlSharp();
                }
            }else if(v == "run n<8>") // If you want to run the eighth shortcut
            {
                var g = File.ReadAllLines(filePath).Skip(15).Take(1).First();
                ProcessStartInfo x = new ProcessStartInfo();
                x.UseShellExecute = true;
                x.FileName = g;
                Process.Start(g);
                
                Console.ReadKey();
                Console.WriteLine("Type Exit or Stay");
                Console.Write(">");
                string command = Console.ReadLine();
                if(command == "Exit")
                {
                        ShortcutPage();
                }else if(command == "Stay")
                {
                    AlSharp();
                }else
                {
                    Console.WriteLine("Wrong command");
                    Thread.Sleep(100);
                    AlSharp();
                }
            }else if(v == "run n<9>") // If you want to run the ninth shortcut
            {
                var g = File.ReadAllLines(filePath).Skip(17).Take(1).First();
                ProcessStartInfo K = new ProcessStartInfo();
                K.UseShellExecute = true;
                K.FileName = g;
                Process.Start(g);
                
                Console.ReadKey();
                Console.WriteLine("Type Exit or Stay");
                Console.Write(">");
                string command = Console.ReadLine();
                if(command == "Exit")
                {
                        ShortcutPage();
                }else if(command == "Stay")
                {
                    AlSharp();
                }else
                {
                    Console.WriteLine("Wrong command");
                    Thread.Sleep(100);
                    AlSharp();
                }
            }else if(v == "run n<10>") // If you want to run the tenth shortcut
            {
                var g = File.ReadAllLines(filePath).Skip(19).Take(1).First();
                ProcessStartInfo l = new ProcessStartInfo();
                l.UseShellExecute = true;
                l.FileName = g;
                Process.Start(g);
                
                Console.ReadKey();
                Console.WriteLine("Type Exit");
                Console.Write(">");
                string command = Console.ReadLine();
                if(command == "Exit")
                {
                    ShortcutPage();
                }else if(command == "Stay")
                {
                    AlSharp();
                }else
                {
                    Console.WriteLine("Wrong command");
                    Thread.Sleep(100);
                    AlSharp();
                }
            }else if(v == "/command Exit") // If you want to exit the command
            {
                ShortcutPage();

            }else // If the command is wrong
            {
                
                Console.WriteLine("Wrong command");
                Console.WriteLine("Returning back to start");
                Thread.Sleep(100);
                AlSharp();
            }
            
            
            
            
            
            
            
            
            
        }
        public void e() // Is used to add or view the shortcuts
        {
            
            Console.Clear();
            Console.WriteLine("Type the file name : ");
            Console.Write(">");
            string c = Console.ReadLine();
            string filePath1 = $@"{Environment.CurrentDirectory}/data/Shortcuts/{c}.txt";
            
            Console.Write(">");
            string y = Console.ReadLine();
            
                Console.WriteLine("Type -ss to see all the text in file or type -add to add");
                Console.Write(">");
                string v = Console.ReadLine();
                if(v == "-add")
                {
                    Console.WriteLine("How many shortcuts do you want to add?");
                    Console.Write(">");
                    string yInt = Console.ReadLine();
                    for(int i=0; i <= Convert.ToInt32(yInt);i++)
                    {
                        
                        Console.WriteLine("Type the name which you want to add");
                        Console.Write(">");
                        string n = Console.ReadLine();
                        Console.WriteLine("Type the exe file : ");
                        Console.Write(">");
                        string l = Console.ReadLine();
                        string[] a = 
                        {
                            n,
                            l
                        };
                        
                        File.AppendAllLinesAsync(filePath1, a);
                        
                        
                        
                        

                    
                    }
                    
                    Console.WriteLine("Type Exit");
                    Console.Write(">");                         
                    string r = Console.ReadLine();
                    if(r == "Exit")
                    {
                        ShortcutPage();
                    }else
                    {
                        Console.WriteLine("Wrong command");
                        Thread.Sleep(100);
                        e();
                    }

                }else if(v == "-ss")
                {
                    string b = File.ReadAllText(filePath1);
                    Console.WriteLine(b);
                    Thread.Sleep(100);
                    Console.WriteLine("Type Exit or Stay");
                    Console.Write(">");
                    string n = Console.ReadLine();
                    if(n == "Exit")
                    {
                        ShortcutPage();   
                    }else if(n == "Stay")
                    {
                        e();
                    }
                    else
                    {
                        Console.WriteLine("Wrong command");
                        Thread.Sleep(100);
                        e();
                    }

                    

                }else if(v == "/command Exit")
                {
                    ShortcutPage();

                }else
                {
                    Console.WriteLine("Wrong command");
                    Thread.Sleep(100);
                    e();
                }
            
        
            


        }

        
    }
    
}