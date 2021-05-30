using System;
using System.IO;
using System.Diagnostics;
using System.Threading;


namespace src
{
    class FileSystem
    {
        public void system(string takePath)
        {
            Console.WriteLine("How many filepaths do you want to write?");
            Console.Write(">");
            
            
            string numH = Console.ReadLine();
            if(numH == "1")
            {
                Console.Clear();
                Console.WriteLine("You can start typing when the '>' symbol appears");
                Thread.Sleep(2000);
                Console.Clear();
                Console.Write(">");
                string readms = Console.ReadLine();

                string[] listFile = 
                {
                    "",
                    "Files",
                    readms

                };

                File.AppendAllLines(takePath, listFile);
                

            }else if(numH == "2")
            {
                Console.Clear();
                Console.WriteLine("You can start typing when the '>' symbol appears");
                Thread.Sleep(2000);
                Console.Clear();
                Console.Write(">");
                string readms = Console.ReadLine();
                Console.Write(">");
                string readmj = Console.ReadLine();

                string[] listFile = 
                {
                    "",
                    "Files",
                    readms,
                    readmj

                };

                File.AppendAllLines(takePath, listFile);
                

                
            }else if(numH == "3")
            {
                Console.Clear();
                Console.WriteLine("You can start typing when the '>' symbol appears");
                Thread.Sleep(2000);
                Console.Clear();
                Console.Write(">");
                string readms = Console.ReadLine();
                Console.Write(">");
                string fileread = Console.ReadLine();
                Console.Write(">");
                string Filereadtwo = Console.ReadLine();

                string[] listFile = 
                {
                    "",
                    "Files",
                    readms,
                    fileread,
                    Filereadtwo

                };

                File.AppendAllLines(takePath, listFile);
                

                
            }else if(numH == "4")
            {
                Console.Clear();
                Console.WriteLine("You can start typing when the '>' symbol appears");
                Thread.Sleep(2000);
                Console.Clear();
                Console.Write(">");
                string readms = Console.ReadLine();
                Console.Write(">");
                string readk = Console.ReadLine();
                Console.Write(">");
                string readl = Console.ReadLine();
                Console.Write(">");
                string readmgh = Console.ReadLine();

                string[] listFile = 
                {
                    "",
                    "Files",
                    readms,
                    readk,
                    readl,
                    readmgh

                };

                File.AppendAllLines(takePath, listFile);
                

                
            }else if(numH == "5")
            {
                Console.Clear();
                Console.WriteLine("You can start typing when the '>' symbol appears");
                Thread.Sleep(2000);
                Console.Clear();
                Console.Write(">");
                string readms = Console.ReadLine();
                Console.Write(">");
                string readmsc = Console.ReadLine();
                Console.Write(">");
                string readmq = Console.ReadLine();
                Console.Write(">");
                string filek = Console.ReadLine();
                Console.Write(">");
                string readml = Console.ReadLine();

                string[] listFile = 
                {
                    "",
                    "Files",
                    readms,
                    readmsc,
                    readmq,
                    filek,
                    readml

                };

                File.AppendAllLines(takePath, listFile);
                

                
            }else if(numH == "6")
            {
                Console.Clear();
                Console.WriteLine("You can start typing when the '>' symbol appears");
                Thread.Sleep(2000);
                Console.Clear();
                Console.Write(">");
                string readms = Console.ReadLine();
                Console.Write(">");
                string readmstwo = Console.ReadLine();
                Console.Write(">");
                string readmsthree = Console.ReadLine();
                Console.Write(">");
                string readmsfour = Console.ReadLine();
                Console.Write(">");
                string readmsfive = Console.ReadLine();
                Console.Write(">");
                string readmssix = Console.ReadLine();


                string[] listFile = 
                {
                    "",
                    "Files",
                    readms,
                    readmstwo,
                    readmsthree,
                    readmsfour,
                    readmsfive,
                    readmssix
                    

                };

                File.AppendAllLines(takePath, listFile);
                

                
            }else if(numH == "7")
            {
                Console.Clear();
                Console.WriteLine("You can start typing when the '>' symbol appears");
                Thread.Sleep(2000);
                Console.Clear();
                string readms = Console.ReadLine();
                Console.Write(">");
                string readmstwo = Console.ReadLine();
                Console.Write(">");
                string readmsthree = Console.ReadLine();
                Console.Write(">");
                string readmsfour = Console.ReadLine();
                Console.Write(">");
                string readmsfive = Console.ReadLine();
                Console.Write(">");
                string readmssix = Console.ReadLine();
                Console.Write(">");
                string readmsseven = Console.ReadLine();



                string[] listFile = 
                {
                    "",
                    "Files",
                    readms,
                    readmstwo,
                    readmsthree,
                    readmsfour,
                    readmsfive,
                    readmssix,
                    readmsseven
                    

                };

                File.AppendAllLines(takePath, listFile);
                

                
            }else if(numH == "8")
            {
                Console.Clear();
                Console.WriteLine("You can start typing when the '>' symbol appears");
                Thread.Sleep(2000);
                Console.Clear();
                string readms = Console.ReadLine();
                Console.Write(">");
                string readmstwo = Console.ReadLine();
                Console.Write(">");
                string readmsthree = Console.ReadLine();
                Console.Write(">");
                string readmsfour = Console.ReadLine();
                Console.Write(">");
                string readmsfive = Console.ReadLine();
                Console.Write(">");
                string readmssix = Console.ReadLine();
                Console.Write(">");
                string readmsseven = Console.ReadLine();
                Console.Write(">");
                string readmseight = Console.ReadLine();





                string[] listFile = 
                {
                    "",
                    "Files",
                    readms,
                    readmstwo,
                    readmsthree,
                    readmsfour,
                    readmsfive,
                    readmssix,
                    readmsseven,
                    readmseight
                    

                };


                File.AppendAllLines(takePath, listFile);
                
                

                
            }else if(numH == "/command Exit")
            {
                Console.WriteLine("Exiting");
                Thread.Sleep(100);
                Utility u = new Utility();
                u.VirtualUtility();
            }
            else
            {
                Console.WriteLine("String not recognized");
                Console.WriteLine("Value error");
                Thread.Sleep(100);
                Console.WriteLine("Returning");
                system(takePath);
            }

        }
    }
}