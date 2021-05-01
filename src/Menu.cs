using System;

namespace src{
    class Menu
    {
        public void MenuMain()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Apps and other commands(type Apps for running this command)");
            Console.WriteLine("Shortcuts");
            Console.WriteLine("Terminal");
            Console.WriteLine("Exit");
            Console.Write(">");
            string y = Console.ReadLine();
            if(y == "Apps")
            {
                viOne b = new viOne();
                b.vi();

            }else if(y == "Shortcuts")
            {
                Shortcut s = new Shortcut();
                s.ShortcutPage();
            }else if(y == "Terminal")
            {
                 TerminalKernel l = new TerminalKernel();
                 l.TerminalHandler();
                 Console.WriteLine("Type Exit");
                 Console.Write(">");
                 string v = Console.ReadLine();
                 if(v == "Exit")
                 {
                     MenuMain();
                 }

            }else if(y == "Exit")
            {
                Console.WriteLine("Cya!");
                Console.ReadKey();
            }
        }
    }

    
}