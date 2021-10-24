using System;
using System.Diagnostics;
using System.IO;
using System.Linq;

namespace TermLibs
{
          class markdownreader
          {
                    public virtual void read(string filename, string specialstring)
                    {
                        
                        
                        if(specialstring == "read")
                        {
                            Console.ForegroundColor = ConsoleColor.Gray;
                            Console.WriteLine("MD READER CONSOLE");
                            Console.WriteLine("Type --help to see available commands or type read --sh=<filepath> to start a read");
                            Console.Write(">");
                            string readstring = Console.ReadLine();
                            if(readstring == "read Version")
                            {
                                      File.ReadAllLines($"{Environment.CurrentDirectory}/VersionOverview.md");
                                      read(filename, specialstring);
                            }else if(readstring == "clear")
                            {
                                Console.Clear();
                                read(filename, specialstring);
                            }
                        }else if(specialstring == "None" || specialstring == "none")
                        {
                            Console.WriteLine("Md reader : version 9.1");
                            ProcessStartInfo start = new ProcessStartInfo();
                            start.FileName = "/bin/bash";
                            start.Arguments = $"-c cat {filename}";
                            Process.Start(start);
                            Console.ReadKey();
                            
                            readVoid(filename, specialstring);
                            // File.ReadAllBytes(filename);
                        }
                        
                        

                    }
                    public void readVoid(string filename, string specialstring)
                    {
                        Console.WriteLine("Leave blank if you want to see another file or exit");
                        Console.Write(">");
                        string reader = Console.ReadLine();
                        if(reader == "exit")
                        {
                              var devconsole = new dev.DevConsole();
                              devconsole.NonStartConsole();
                        }else if(string.IsNullOrWhiteSpace(reader))
                        {
                            read(filename, specialstring);
                        }
                    }
          }

}
