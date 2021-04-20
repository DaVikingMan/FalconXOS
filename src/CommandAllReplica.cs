using System;




namespace Classes
{
    // Used by the TheDebug command
    class CommandAllReplica
{
    public void NotesRe() // Notes Replica
    {
        Console.Clear();
        Console.WriteLine("Welcome to Note! The place where you can learn how to use TerminalX");
        
        Console.WriteLine("What Note do you want to read?");
        Console.WriteLine("TerminalInfo");
        Console.WriteLine("CommansdInfo");
        Console.WriteLine("Exit");
        Console.WriteLine("Copyright Info");
        Console.ReadKey();
        Console.Write("> ");
        var readInput = Console.ReadLine();
        if(string.IsNullOrWhiteSpace(readInput))
        {
            var t = new CommandsAll();
            Console.WriteLine("Kindly input value");
            Console.ReadKey();
            t.Note();

        }
        else if(readInput == "TerminalInfo")
        {
            Console.Clear();
            Console.WriteLine("This note is about this TerminalOS");
            Console.WriteLine("This TerminalOS is built using C# and vscode");
            Console.ReadKey();
            Console.WriteLine("Do you want to see some rules?");
            dynamic check = Console.ReadLine();
            if(check == "Yes")
            {
                Console.ReadKey();
                Console.Clear();
                Console.WriteLine("The rules are :-");
                Console.ReadKey();
                Console.WriteLine("Only type 'Yes' or 'No' not 'no' or 'yes'.");
                Console.WriteLine("Only type when the '>' symbol appears.");
                Console.WriteLine("If some features don't work as intended please write them in the issues section.");
                Console.WriteLine("If the '>' symbol doesn't appear that means you have to press a key.");

                Console.WriteLine("Do you want to exit?");
                string b = Console.ReadLine();
                if(b == "Yes")
                {
                    var t = new CommandsAll();
                    Console.ReadKey();
                    t.Note();

                }else if(b == "No")
                {
                    Console.WriteLine("There is nothing more in this command");
                    Console.WriteLine("Kindly type exit");
                    string y = Console.ReadLine();
                    if(y == "Yes")
                    {
                        var t = new CommandsAll();
                        Console.ReadKey();
                        t.Note();
                    }
                }
                Console.ReadKey();
            }else if(check == "No")
            {
                Console.ReadKey();
                Console.WriteLine("Do you want to exit?");
                string m = Console.ReadLine();
                if(m == "Yes")
                {
                    var t = new CommandsAll();
                    Console.ReadKey();
                    t.Note();
                }else if(check == "No")
                {
                    Console.WriteLine("This program doesn't have anything else");
                    Console.WriteLine("Do you want to exit?");
                    string h = Console.ReadLine();
                    if(h == "Yes")
                    {
                        var t = new CommandsAll();
                        Console.ReadKey();
                        t.Note();
                    }
                }

                
            }

        }
        else if(readInput == "CommandsInfo")
        {
            Console.Clear();
            Console.WriteLine("The commands are written in the form of either different classes or different methods");
            Console.WriteLine("Commands perform different functions");
            Console.WriteLine("If you want to execute a command then you can write the command when you are prompted to");
            Console.WriteLine("Type Yes to exit");
            string t = Console.ReadLine();
            
        }
        else if(readInput == "Exit")
        {
            Console.ReadKey();
            
        }
        else if(readInput == "Copyright Info")
        {
            var t = new CommandsAll();
            Console.Clear();
            Console.WriteLine("Copyright Re:Note(Method)");
            Console.ReadKey();
            

        }


        Console.ReadKey();
        Console.Clear();
        Console.WriteLine("Copyright virtual Note : v.r1");
        Console.WriteLine("This virtualization is process works under Re:Virtual tool");
        Console.ReadKey();
        Console.WriteLine("Exit : ");
        viOne l = new viOne();
        Console.ReadKey();
        l.vi();

    }
    public void StartRe() // Start Replica
    {
        Console.Clear();
            DateTime date = DateTime.Now;
                        Console.WriteLine(date);
                        Console.ReadKey();
                        
                        Console.WriteLine("Welcome to the main system!");
                        Console.WriteLine("Kindly write your name : ");
                        Console.Write("> ");
                        string name = Console.ReadLine();
                        if(string.IsNullOrWhiteSpace(name)){
                            Console.WriteLine("Kindly input name");
                            Console.ReadKey();
                            StartRe();
                        }
                        
                        Console.Clear();
                        Console.WriteLine(name  + " huh?");
                        Console.ReadKey();
                        
        Console.ReadKey();
        Console.WriteLine("Virtualization is carried by Re:Virtual");
        Console.WriteLine("");
        Console.ReadKey();
        Console.WriteLine("Kindly type Exit");
        Console.Write(">");
        string n = Console.ReadLine();
        if(n == "Exit")
        {
            viOne v = new viOne();
            v.vi();


        }

        
    }
    public void MainTerminalRe()
    {
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.Clear();
            Console.WriteLine("Welcome to a new version of TerminalX");
            Console.WriteLine("Do you want to read about TerminalX and its features?");
            Console.Write("> ");
            var c = Console.ReadLine();
            if(c == "Yes")
            {
                
                NotesRe();
                Console.ReadKey();
        Console.WriteLine("Virtualization is carried by Re:Virtual");
        Console.WriteLine("");
        Console.ReadKey();
        Console.WriteLine("Kindly type Exit");
        Console.Write(">");
        string n = Console.ReadLine();
        if(n == "Exit")
        {
                  viOne m = new viOne();
                  m.vi();

        }

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
                Console.ReadKey();
        Console.WriteLine("Virtualization is carried by Re:Virtual");
        Console.WriteLine("");
        Console.ReadKey();
        Console.WriteLine("Kindly type Exit");
        Console.Write(">");
        string n = Console.ReadLine();
        if(n == "Exit")
        {
                 viOne a = new viOne();
                 a.vi();

        }
            }
    }

}
}
