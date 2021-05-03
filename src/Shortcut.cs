using System;
using System.Diagnostics;
using System.IO;
using System.Linq;

namespace src
{
    class Shortcut
    {
        public void ShortcutPage()
        {
            Console.Clear();
            Console.WriteLine("Type 'scc --new' for a new instance of shortcut or type 'scc --runload' for running a created shortcut\nRun scc --o for adding shortcuts\nTypr Exit to exit");
            
            Console.Write(">");
            string Kcommand = Console.ReadLine();
            if(Kcommand == "scc --new")
            {

                     ShortcutInteface();
            }else if(Kcommand == "Exit")
            {
                Menu m = new Menu();
                m.MenuMain();
                   
            }else if(Kcommand == "scc --runload")
            {
                
                 AlSharp();
            }else if(Kcommand == "scc --o")
            {
                e();
            }
        }
        public void ShortcutInteface()
        {
            Console.Clear();
            Console.WriteLine("Type the path where you want to store the directory(C:/exampleuser/exampledir)");
            string secondaryDirectory = Console.ReadLine();
            Console.WriteLine("Creating Directory for storing shortcuts....");
            string dirs = $@"{secondaryDirectory}\Shortcuts";
            if(Directory.Exists(dirs))
            {

            }else if(!Directory.Exists(dirs))
            {
                Directory.CreateDirectory(dirs);
            }
            

            Console.Clear();
            Console.WriteLine("Creating file for storing shortcuts");
            string dirfile = $@"{dirs}\shortcuts.txt";            
            
            
            
            FileStream stream12 = new FileStream(dirfile , FileMode.OpenOrCreate);
            stream12.Close();


            Console.WriteLine("Type Exit");
            Console.Write(">");
            string Lcomamnd = Console.ReadLine();
            if(Lcomamnd == "Exit")
            {
                ShortcutPage();
                
                    
                
                

            }
            

            

            

        }
        
        public void AlSharp()
        {
            Console.Clear();
            Console.Clear();
            Console.WriteLine("Type the path : ");
            
            var f = Console.ReadLine();
            string filePath = $@"{f}";
            var h = File.ReadAllText(filePath).ToArray();
            Console.WriteLine(h);
            if(h.Length == 1)
            {
                
                   Console.WriteLine(h[0]);
            }else if(h.Length == 2)
            {
                Console.WriteLine(h[0]);
                Console.WriteLine(h[1]);

            }else if(h.Length == 3)
            {
                Console.WriteLine(h[0]);
                Console.WriteLine(h[1]);
                
                Console.WriteLine(h[2]);
                Console.WriteLine(h[3]);
                
            }else if(h.Length == 4)
            {
                Console.WriteLine(h[0]);
                Console.WriteLine(h[1]);
                
                Console.WriteLine(h[2]);
                Console.WriteLine(h[3]);
                Console.WriteLine(h[4]);

                
            }else if(h.Length == 5)
            {
                Console.WriteLine(h[0]);
                Console.WriteLine(h[1]);
                
                Console.WriteLine(h[2]);
                Console.WriteLine(h[3]);
                Console.WriteLine(h[4]);
                Console.WriteLine(h[5]);
                
            }else if(h.Length == 6)
            {
                Console.WriteLine(h[0]);
                Console.WriteLine(h[1]);
                
                Console.WriteLine(h[2]);
                Console.WriteLine(h[3]);
                Console.WriteLine(h[4]);
                Console.WriteLine(h[5]);
                Console.WriteLine(h[6]);
                
            }else if(h.Length == 7)
            {
                Console.WriteLine(h[0]);
                Console.WriteLine(h[1]);
                
                Console.WriteLine(h[2]);
                Console.WriteLine(h[3]);
                Console.WriteLine(h[4]);
                Console.WriteLine(h[5]);
                Console.WriteLine(h[6]);
                Console.WriteLine(h[7]);
                
            }else if(h.Length == 8)
            {
                Console.WriteLine(h[0]);
                Console.WriteLine(h[1]);
                
                Console.WriteLine(h[2]);
                Console.WriteLine(h[3]);
                Console.WriteLine(h[4]);
                Console.WriteLine(h[5]);
                Console.WriteLine(h[6]);
                Console.WriteLine(h[7]);
                Console.WriteLine(h[8]);
                
            }else if(h.Length == 9)
            {
                Console.WriteLine(h[0]);
                Console.WriteLine(h[1]);
                
                Console.WriteLine(h[2]);
                Console.WriteLine(h[3]);
                Console.WriteLine(h[4]);
                Console.WriteLine(h[5]);
                Console.WriteLine(h[6]);
                Console.WriteLine(h[7]);
                Console.WriteLine(h[8]);
                Console.WriteLine(h[9]);
                
            }else if(h.Length == 10)
            {
                Console.WriteLine(h[0]);
                Console.WriteLine(h[1]);
                
                Console.WriteLine(h[2]);
                Console.WriteLine(h[3]);
                Console.WriteLine(h[4]);
                Console.WriteLine(h[5]);
                Console.WriteLine(h[6]);
                Console.WriteLine(h[7]);
                Console.WriteLine(h[8]);
                Console.WriteLine(h[9]);
                Console.WriteLine(h[10]);
                
            }
            Console.WriteLine("Type run n<num>");
            string v = Console.ReadLine();

            if(v == "run n<1>")
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
                    viOne m = new viOne();
                    m.vi();
                }else if(command == "Stay")
                {
                    ShortcutPage();
                }

            }
            if(v == "run n<2>")
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
                    viOne m = new viOne();
                    m.vi();
                }else if(command == "Stay")
                {
                    ShortcutPage();
                }
                
            }
            if(v == "run n<3>")
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
                    viOne m = new viOne();
                    m.vi();
                }else if(command == "Stay")
                {
                    ShortcutPage();
                }
                
            }
            if(v == "run n<4>")
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
                    viOne m = new viOne();
                    m.vi();
                }else if(command == "Stay")
                {
                    ShortcutPage();
                }
                
            }
            if(v == "run n<5>")
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
                    viOne m = new viOne();
                    m.vi();
                }else if(command == "Stay")
                {
                    ShortcutPage();
                }
                
            }
            if(v == "run n<6>")
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
                    viOne m = new viOne();
                    m.vi();
                }else if(command == "Stay")
                {
                    ShortcutPage();
                }
                
            }
            if(v == "run n<7>")
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
                    viOne m = new viOne();
                    m.vi();
                }else if(command == "Stay")
                {
                    ShortcutPage();
                }
            }
            if(v == "run n<8>")
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
                    viOne m = new viOne();
                    m.vi();
                }else if(command == "Stay")
                {
                    ShortcutPage();
                }
            }
            if(v == "run n<9>")
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
                    viOne m = new viOne();
                    m.vi();
                }else if(command == "Stay")
                {
                    ShortcutPage();
                }
            }
            if(v == "run n<10>")
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
                }
            }
            
            
            
            
            
            
            
            
            
        }
        public void e()
        {
            Console.Clear();
            Console.Clear();
            Console.WriteLine("Type the file path : ");
            string c = Console.ReadLine();
            string filePath1 = $@"{c}";
            Console.WriteLine("type run -add");
            string y = Console.ReadLine();
            if(y == "run -add")
            {
                Console.WriteLine("Type -ss to see all the text in file or type -add to add");
                string v = Console.ReadLine();
                if(v == "-add")
                {
                    Console.WriteLine("Type the name which you want to add");
                    string n = Console.ReadLine();
                    Console.WriteLine("Type the exe file : ");
                    string l = Console.ReadLine();
                    string[] a = 
                    {
                        n,
                        l
                    };
                    File.AppendAllLines(filePath1, a);
                    Console.WriteLine("Type Exit");
                    string r = Console.ReadLine();
                    if(r == "Exit")
                    {
                        ShortcutPage();
                    }

                }else if(v == "-ss")
                {
                    string b = File.ReadAllText(filePath1);
                    Console.WriteLine(b);
                    Console.ReadKey();
                    Console.WriteLine("Type Exit or Stay");
                    string n = Console.ReadLine();
                    if(n == "Exit")
                    {
                        ShortcutPage();   
                    }

                    

                }
            }


        }

        
    }
    
}