using System.Collections.Generic;




namespace Classes
{
    // All commands are created here
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
