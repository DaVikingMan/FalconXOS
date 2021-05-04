using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;


namespace src
{
    // All commands
    class CommandsAll
{
    

    public void TerminalInfo(string comment) // Lists the Operating Shell version and other details
    {
        Console.Clear();
        Console.WriteLine("The driver version's are as follows : \nApp versiom : v.2\nUtility version : v.4\nCommands version : v.5\nOverall version : vi.9");
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
    
    
    public void ListMaker(string comment2) // command used for creating lists
    {
        Console.Clear();
        Console.WriteLine("Do you want to open the UI version or the \nterminal version(type Terminal for terminal version or UI for UI versiom)");
        string anscommand = Console.ReadLine();
        if(anscommand == "UI")
        {
            ProcessHandler handler = new ProcessHandler();

            handler.ProcessHandle();
            Console.ReadKey();
            Console.WriteLine("Type Exit or Stay");
            string Ycommand = Console.ReadLine();
            if(Ycommand == "Exit")
            {
                viOne i = new viOne();
                i.vi();

            }else if(Ycommand == "Stay")
            {
                ListMaker("Make List");
            }

        }else if(anscommand == "Terminal")
        {
            Console.WriteLine("Do you want to store the list in a file?");
        Console.Write(">");
        var created = Console.ReadLine();

        if(created == "Yes")
        {
        
        Console.Clear();
        Console.WriteLine("Welcome to the list interface");
        Console.WriteLine("Kindly type the directory where the file should be stored");
        
        Console.WriteLine("Kindly type the path where you want to store the List");
        DateTime dateOfCreation = DateTime.Now;
        
        string filePath = Console.ReadLine();
        if(string.IsNullOrWhiteSpace(filePath))
        {
            ListMaker("List");
        }
        string ListfilePath = $@"{filePath}";
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
            Console.Clear();
            Console.WriteLine("Generating file");
            var ConversionOfdateTime = Convert.ToString(dateOfCreation);
            string[] Lists = new string[]{ConversionOfdateTime ," ", nameList , " " ,listList[0], listList[1], listList[2], listList[3] };
            FileStream sc = new FileStream(ListfilePath , FileMode.OpenOrCreate);

            sc.Close();
            File.WriteAllLines(ListfilePath, Lists);
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("Reading lines");
            var f = File.ReadAllText(ListfilePath);
            Console.WriteLine(f);
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
        }else if(created == "No")
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
            Console.Clear();
                    Console.ReadKey();
            Console.Clear();
           
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

    }

        }
        

    public void WriteConsolePad() // 
    {
        Console.Clear();
        Console.WriteLine("Which Writing Software do you want to open?");
        string commandOpen = Console.ReadLine();
        ProcessStartInfo startInfo = new ProcessStartInfo();
        startInfo.Arguments = $@"/C {commandOpen}";
        startInfo.UseShellExecute = true;
        Process.Start(startInfo);
        Console.ReadKey();
        Console.WriteLine("Type Exit or Stay");
        string rcommand = Console.ReadLine();
        if(rcommand == "Exit")
        {
            viOne v = new viOne();
            v.vi();

        }else if(rcommand == "Stay")
        {
            WriteConsolePad();
        }

    }

    public void RunCommand()
    {
        Console.Clear();
        Console.WriteLine("Type the exe file name of the file which you want to run");
        Console.Write(">");
        string Fie = Console.ReadLine();
        Process.Start(Fie);
        Console.ReadKey();
        Console.WriteLine("Do you want to Exit or Stay");
        string ansj = Console.ReadLine();
        if(ansj == "Exit")
        {
            viOne b = new viOne();
            b.vi();            
        }else if(ansj == "Stay")
        {
            RunCommand();

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
            Console.WriteLine("This note is about TerminalXOS");
            Console.WriteLine("This TerminalXOS is built using C# and vscode");
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
