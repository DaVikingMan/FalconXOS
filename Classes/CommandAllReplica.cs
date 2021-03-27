using System;




namespace Classes
{
    // Used by the TheDebug command
    class CommandAllReplica
{
    public void NotesRe() // Notes Replica
    {
        var c = new CommandsAll();
        Console.Clear();
        Console.WriteLine("Welcome to Note! The place where you can learn how to use TerminalX");
        
        Console.WriteLine("What Note do you want to read?");
        Console.WriteLine("Exit");
        Console.Write("> ");
        var readInput = Console.ReadLine();

        Console.ReadKey();
        Console.Clear();
        Console.WriteLine("Copyright virtual Note : v.r1");
        Console.WriteLine("This virtualization is process works under Re:Virtual tool");
        Console.ReadKey();
        Console.WriteLine("Exit : ");
        Console.ReadKey();

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
