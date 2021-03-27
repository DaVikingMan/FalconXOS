using System;




namespace Classes
{
    // This is the first class that loads when you run the program
    class kernel
    {
        public void KernelMain()
        {
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.Clear();
            Console.WriteLine("Welcome to a new version of TerminalX");
            Console.WriteLine("Do you want to read about TerminalX and its features?");
            Console.Write("> ");
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
                Console.Write("> ");
                string vname = Console.ReadLine();
                viOne v = new viOne();
                    if(vname == "vi.1")
                    {
                       v.Start();

                    }else // If the user doesn't input anything
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
}
