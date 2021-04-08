using System;
using System.Collections.Generic;




namespace Classes
{
    // All commands
    class CommandsAll
{
    public void Games(string comment5) // Games command
    {
                            Console.Clear();
                            Console.WriteLine("What type of game would you like to play?");
                            Console.WriteLine("PacSays");
                            Console.WriteLine("Text Adventure");
                            Console.Write("> ");
                            string no = Console.ReadLine(); // Asks for name of Game
                            if(string.IsNullOrWhiteSpace(no)) // If the user inputs nothing
                            {
                                    Console.ReadKey();
                                    Console.WriteLine("Do you want to exit the program?");
                                    Console.Write("> ");
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

                            }
                            else if(no == "PacSays") // PacSays
                            {
                                GamesAll c = new GamesAll();
                                c.PacSays();
                               
                                Console.Clear();
                                Console.WriteLine("Do you want to Exit?");
                                Console.Write("> ");
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

                            }else if(no == "Text Adventure") // Not Finished
                            {
                                Textadventure a = new Textadventure();
                                a.ExtraClass();
                                

                            }
    } 

    public void TerminalInfo(string comment) // TerminalInfo command
    {
        Console.Clear();
        Console.WriteLine("The driver version's are as follows : \nKernel versiom : vi.2\nDriver version : v.4\ncommands version : v.5\nOverall version : vi.9");
        Console.ReadKey();
        string s = Console.ReadLine();
        if(string.IsNullOrWhiteSpace(s)) // If the user doesn't input anything
        {
            Console.WriteLine("Do you want to exit the program?");
            Console.Write("> ");
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
    public void Exit(string comment1) // Exit command
    {
        Console.Clear();
        Console.WriteLine("The next update of TerminalX will be vi.5(The XriFeature Update)");
        Console.ReadKey();
        Console.WriteLine("For now, Cya!");
        Console.ReadKey();

        Console.Clear();
        Console.WriteLine("Do you want to exit?");
        Console.Write("> ");
        string c = Console.ReadLine();

        if(c == "Yes")
        {
            Console.WriteLine("Exiting ::");
            Console.ReadKey();
        

        }
        

    }
    public void ListMaker(string comment2) // ListMaker command
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
            Console.Write("> ");
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

    public void WriteConsolePad()
    {
        Console.Clear();
        Console.WriteLine("Welcome to WritePad!");
        Console.WriteLine("In this app you can write stuff");
        Console.ReadKey();
        Console.WriteLine("One second setting up");
        Console.WriteLine("Okay!");
        Console.ReadKey();
        Console.Clear();
        Console.Write(">");
        string firstLine = Console.ReadLine();
        Console.Write(">");
        string secondLine = Console.ReadLine();
        Console.Write(">");
        string ThirdLine = Console.ReadLine();
        Console.Write(">");
        string FourthLine = Console.ReadLine();
        Console.ReadKey();
        Console.Clear();
        Console.WriteLine("Printing written lines");
        Console.ReadKey();
        Console.WriteLine(firstLine);
        Console.WriteLine(secondLine);
        Console.WriteLine(ThirdLine);
        Console.WriteLine(FourthLine);
        Console.ReadKey();
        Console.Clear();
        Console.WriteLine("Do you want to exit?");
        Console.Write(">");
        string m = Console.ReadLine();
        if(m == "Yes")
        {
            Console.ReadKey();
            viOne v = new viOne();
            v.vi();
        }else if(m == "No")
        {
            Console.ReadKey();
            WriteConsolePad();
        }



        
    }


    public void Note() // Note feature(can only be accessed from the starting screen and from 'TheDebug' command)Not finished
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
            Console.WriteLine("Kindly input value");
            Console.ReadKey();
            Note();

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
                    Console.ReadKey();
                    Note();

                }else if(b == "No")
                {
                    Console.WriteLine("There is nothing more in this command");
                    Console.WriteLine("Kindly type exit");
                    string y = Console.ReadLine();
                    if(y == "Yes")
                    {
                        Console.ReadKey();
                        Note();
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
                    Console.ReadKey();
                    Note();
                }else if(check == "No")
                {
                    Console.WriteLine("This program doesn't have anything else");
                    Console.WriteLine("Do you want to exit?");
                    string h = Console.ReadLine();
                    if(h == "Yes")
                    {
                        Console.ReadKey();
                        Note();
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
            if(t == "Yes")
            {
                Console.ReadKey();
                Note();
            }

        }
        else if(readInput == "Exit")
        {
            kernel l = new kernel();
            l.KernelMain();

        }
        else if(readInput == "Copyright Info")
        {
            Console.Clear();
            Console.WriteLine("Copyright Re:Note(Method)");
            Console.ReadKey();
            Note();

        }

        
        
    }      

 }
}
