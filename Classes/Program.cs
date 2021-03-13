using System;
using System.Collections.Generic;



namespace Classes
{

    public class Program
    {
        public static void Main(string[] args)
        {
            
            
            
            
            kernel k = new kernel();

            k.KernelMain();
            
        }
    }
    class kernel
    {
        public void KernelMain()
        {
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.Clear();
            Console.WriteLine("Welcome to a new version of TerminalX(a new version of InfiDOSX)");
            Console.WriteLine("Do you want to read about TerminalX and its features?");
            var c = Console.ReadLine();
            if(c == "Yes")
            {
                
                CommandsAll cp = new CommandsAll();
                cp.Note();

            }else if(c == "No")
            {
                Console.Clear();
                Console.ReadKey();
                Console.WriteLine("This version includes many new features and some old algorithms such as /.Bait the system./");
                Console.WriteLine("The available versions are as follows : ");
                Console.WriteLine("vi.1");
                Console.ReadKey();
                Console.Clear();
                Console.WriteLine("What version do you want to start?");
                string vname = Console.ReadLine();
                viOne v = new viOne();
                    if(vname == "vi.1")
                    {
                       v.Start();

                    }else
                    {
                        Console.WriteLine("Kindly input version");
                        Console.ReadKey();

                        KernelMain();

                    }


            }else
            {
                Console.WriteLine("Kindly input value");
                Console.ReadKey();
                KernelMain();

            }
        }
    }
    class viOne{
        public void Start()
        {
            Console.Clear();
            DateTime date = DateTime.Now;
                        Console.WriteLine(date);
                        Console.ReadKey();
                        
                        Console.WriteLine("Welcome to the main system!");
                        Console.WriteLine("Kindly write your name : ");

                        string name = Console.ReadLine();
                        if(string.IsNullOrWhiteSpace(name)){
                            Console.WriteLine("Kindly input name");
                            Console.ReadKey();
                            Start();
                        }
                        
                        Console.Clear();
                        Console.WriteLine(name  + " huh?");
                        Console.ReadKey();
                        Console.WriteLine("Do you want to the command screen?");
                        string ans = Console.ReadLine();
                        if(ans == "Yes")
                        {
                            vi();
                        }else if(ans == "No")
                        {
                            Start();
                        }else if(string.IsNullOrWhiteSpace(ans))
                        {
                            Console.WriteLine("Kindly give Input");
                            Console.ReadKey();
                            Start();
                        }
        }
          public void vi()
          {

              Console.ForegroundColor = ConsoleColor.Cyan;
              
              
                    
                        Console.Clear();
                        
                        Console.WriteLine("Which command do you want to execute?");

                        List<commands> cm = ListManager.Manager();

                        foreach(var m in cm){
                            Console.WriteLine($"{m.command1}\n{m.command2}\n{m.command3}\n{m.command4}\nTheDebug");

                        }
                        Console.Write(">");
                        string commandRead = Console.ReadLine();
                        
                        
                        if(commandRead == "Exit")
                        {
                            CommandsAll commands = new CommandsAll();
                            commands.Exit("");
                            
                            



                        }


                        else if(commandRead == "TerminalInfo")
                        {
                            CommandsAll commands = new CommandsAll();
                            commands.TerminalInfo("");
                            

                        }
                        else if(commandRead == "Games")
                        {
                            CommandsAll commands = new CommandsAll();
                            commands.Games("");
                            

                        }
                        else if(commandRead == "ListMaker")
                        {
                            CommandsAll commands = new CommandsAll();
                            commands.ListMaker("");
                        }
                        else if(string.IsNullOrWhiteSpace(commandRead))
                        {
                            Console.WriteLine("Kindly input value");
                            Console.ReadKey();
                            vi();
                        }
                        else if(commandRead == "TheDebug")
                        {
                            Console.WriteLine("The debug is used to view Debug info");
                            Console.Clear();
                            Console.WriteLine("Name Info : NAN(return 0),Value(return 1),Special Name : (return +10)");
                            Console.WriteLine("CommandRead  : NAN(return), Value(1-5)");
                            Console.ReadKey();
                            Console.Clear();
                            Console.WriteLine("You can open the following States : ");
                            Console.ReadKey();
                            Console.WriteLine("Notes");
                            Console.WriteLine("Start");
                            Console.WriteLine("MainTerminal");
                            Console.ReadKey();
                            Console.Clear();
                            Console.Write("> ");
                            var Tread = Console.ReadLine();
                            if(Tread == "Notes")
                            {
                                CommandAllReplica c = new CommandAllReplica();
                                c.NotesRe();
                                Console.ReadKey();
                                Console.WriteLine("Do you want to exit?");
                                var cr = Console.ReadLine();
                                if(cr == "Yes" || cr == "yes")
                                {
                                    vi();
                                }


                            }
                            else if(Tread == "Start")
                            {

                            }
                            else if(Tread == "MainTerminal")
                            {

                            }
                            
                        }

                        
                        
            
            
                
                  

                  

        }

        
        
}

class CommandAllReplica
{
    public void NotesRe()
    {
        var c = new CommandsAll();
        c.Note();
        Console.ReadKey();
        Console.Clear();
        Console.WriteLine("Copyright virtual Note : v.r1");
        Console.WriteLine("This virtualization is process works under Re:Virtual tool");
        Console.ReadKey();
        Console.WriteLine("Exit : ");
        Console.ReadKey();

    }
    public void StartRe()
    {
        var m = new viOne();
        m.Start();
        Console.ReadKey();
        Console.WriteLine("Virtualization is carried by Re:Virtual");
        Console.WriteLine("");
        
    }

}

class CommandsAll
{
    public void Games(string comment5)
    {
                            Console.Clear();
                            Console.WriteLine("What type of game would you like to play?");

                            Console.ReadKey();
                            string no = Console.ReadLine();
                            if(string.IsNullOrWhiteSpace(no))
                            {
                                    Console.ReadKey();
                                    Console.WriteLine("Do you want to exit the program?");
                                    var Q = Console.ReadLine();
                                    if(Q == "Yes" || Q == "yes")
                                    {
                                        viOne kernel = new viOne();
                                        Console.ReadKey();
                                        kernel.vi();

                                    }else if(Q == "No" || Q == "no")
                                    {
                                        Console.WriteLine("Returning Back");
                                    
                                        Console.ReadKey();
                                        Games("Games method");
                                    }

                            }else if(no == "PacMan Says")
                            {
                                GamesAll c = new GamesAll();
                                c.PacSays();
                               
                                Console.Clear();
                                Console.WriteLine("Do you want to Exit?");
                                string ansres = Console.ReadLine();
                                if(ansres == "Yes")
                                {
                                    kernel k = new kernel();
                                    k.KernelMain();
                                }else if(ansres == "No")
                                {
                                    Games("");
                                    Console.ReadKey();

                                }

                            }else if(no == "Text Adventure")
                            {
                                Textadventure a = new Textadventure();
                                a.ExtraClass();
                                

                            }
    } 

    public void TerminalInfo(string comment)
    {
        Console.Clear();
        Console.WriteLine("The driver version's are as follows : \nKernel versiom : vi.1\nDriver version : v.2\ncommands version : v.2\nOverall version : vi.4");
        Console.ReadKey();
        string s = Console.ReadLine();
        if(string.IsNullOrWhiteSpace(s))
        {
            Console.WriteLine("Do you want to exit the program?");
            var v = Console.ReadLine();
            if(v == "Yes" || v == "yes")
            {
                Console.ReadKey();
                viOne n = new viOne();
                n.vi();

            }else if(v == "No" || v == "no")
            {
                Console.ReadKey();
                TerminalInfo("Terminal Info");

            }

        }

    }
    public void Exit(string comment1)
    {
        Console.Clear();
        Console.WriteLine("The next update of TerminalX will be vi.5(The XriFeature Update)");
        Console.ReadKey();
        Console.WriteLine("For now, Cya!");
        Console.ReadKey();

        Console.Clear();
        Console.WriteLine("Do you want to exit?");
        string c = Console.ReadLine();

        if(c == "Yes")
        {
            Console.WriteLine("Exiting ::");
            Console.ReadKey();
        

        }
        

    }
    public void ListMaker(string comment2)
    {
        Console.Clear();
        Console.WriteLine("Welcome to the list interface");
        Console.WriteLine("Kindly give your List a title");
        Console.Write("> ");
        string nameList = Console.ReadLine();
        Console.WriteLine("Your list's name is " + nameList);
        Console.ReadKey();
        Console.Clear();
        Console.WriteLine("Okay Lets start creating the list " + nameList);
        Console.ReadKey();
        
        string commandName = Console.ReadLine();
        
        
            Console.WriteLine("Start typing : ");
            string line1 = Console.ReadLine();
            string line2 = Console.ReadLine();
            string line3 = Console.ReadLine();
            string line4 = Console.ReadLine();

            Console.Clear();
            Console.WriteLine("Creating List : ");
            Console.ReadKey();
            List<string> listList  = new List<string>();
            listList.Add(line1);
            listList.Add(line2);
            listList.Add(line3);
            listList.Add(line4);
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("The list are as follows : ");
            Console.WriteLine(listList[0]);
            Console.WriteLine(listList[1]);
            Console.WriteLine(listList[2]);
            Console.WriteLine(listList[3]);
            Console.ReadKey();
            Console.WriteLine("Type Exit or Stay");
            string v = Console.ReadLine();
            if(v == "Exit")
            {
                    viOne p = new viOne();
                    p.vi();
                    
                   


            }
            else if(v == "Stay")
            {
                ListMaker("");
            }

    }


    public void Note()
    {
        Console.Clear();
        Console.WriteLine("Welcome to Note! The place where you can learn how to use TerminalX");
        
        Console.WriteLine("What Note do you want to read?");
        var readInput = Console.ReadLine();
        if(string.IsNullOrWhiteSpace(readInput))
        {
            Console.WriteLine("Kindly input value");
            Console.ReadKey();
            Note();

        }
        else if(readInput == "TerminalInfo")
        {

        }
        else if(readInput == "CommandsInfo")
        {

        }
        else if(readInput == "Exit")
        {
            kernel l = new kernel();
            l.KernelMain();

        }
        else if(readInput == "Copyright Info")
        {

        }

        
        
    }      

 }


    
    
    public class commands{
       
            public string command1 { get; set; }
            public string command2 { get; set; }
            public string command3 { get; set; }
            public string command4 { get; set; }
            
            

        
    
    }
    public class ListManager
    {
        public static List<commands> Manager()
        {

            List<commands> c = new List<commands>();

            c.Add(new commands{command1 = "TerminalInfo", command2 = "Games" , command3 = "ListMaker", command4 = "Exit"});

            return c;

        }
    
}
}