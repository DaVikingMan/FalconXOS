using System;
using System.Diagnostics;

namespace Classes
{
    public class GamesAll : GamesProperty
    {
        public void ExtraClass()
        {
            while(true)
            {
                Console.Clear();
                Console.WriteLine("Simon says Right");
                string readFirst = Console.ReadLine();
                if(readFirst == "Right")
                {
                    Console.WriteLine("Simon says Left");
                    string h = Console.ReadLine();
                    if(h == "Left")
                    {
                        Console.WriteLine("PacMan says Up_UP");
                        string m = Console.ReadLine();
                        if(m == "Up_UP")
                        {
                            Console.WriteLine("PacMan says Juggle");
                            string b = Console.ReadLine();
                            if(b == "Juggle")
                            {
                                Console.WriteLine("Game Over");
                                Console.ReadKey();
                                Console.WriteLine("You have to only write directions");
                                Console.ReadKey();
                                Console.Clear();
                                PacSays();

                            }
                            else if(string.IsNullOrWhiteSpace(b))
                            {
                                Console.WriteLine("Good!");
                                Console.ReadKey();

                            }else{
                    
                              Console.WriteLine("Game Over!");
                              Console.ReadKey();
                              PacSays();
                            }
                        }else
                        {
                            Console.WriteLine("Game Over!");
                            Console.ReadKey();
                        
                        }
                        
                    
                    }
                    else
                    {
                        Console.WriteLine("Game Over!");
                        Console.ReadKey();
                        PacSays();
                    }
                    
                }
                else
                    {
                        Console.WriteLine("Game Over!");
                        Console.ReadKey();
                        
                    }

            }
            
        


        }

        public void MainMenu()
        {
            throw new NotImplementedException();
        }

        public void PacSays()
        {
            
            Console.ReadKey();
            Console.WriteLine("Welcome to PacSays!");
            Console.WriteLine("Do you want to start the Game?");
            var read = Console.ReadLine();
            if(read == "Yes" || read == "yes")
            {
                ExtraClass();

            }
                
            else if(read == "No" || read == "no")
            {
                Console.WriteLine("Okay! One second Ending Task");
                Console.ReadKey();
                viOne l = new viOne();
                l.vi();



            }
            
          
        }

        public void TextAdventure()
        {
            throw new NotImplementedException();
        }
    }
}
