using System.Collections.Generic;




namespace src
{
    // All commands are created here
    public class ListManager
    {
        public static List<commands> Manager() // Manages the list which contains the commands in the 'Apps and utilities tab'
        {

            List<commands> c = new List<commands>(); // Creates a new instance of the 'commands' class

            c.Add(new commands{command1 = "TerminalInfo", command2 = "ListMaker", command3 = "WritePad", command4 = "Run" , command5 = "Debug", command6 = "Exit"});

            return c;

        }
    
}
}
