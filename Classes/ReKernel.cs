using System;




namespace Classes
{
    class ReKernel
    {
        public void Rek()
        {
             Console.Clear();
                Console.ReadKey();
                Console.WriteLine("This version includes many new features and some old algorithms such as /.Bait the system./");
                Console.WriteLine("The available versions are as follows : ");
                Console.WriteLine("vi.1");
                Console.ReadKey();
                Console.Clear();
                Kernel();
               


            

        }
        public void Kernel()
        {
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
                        Kernel();
                        

                    }

        }
    }
}
