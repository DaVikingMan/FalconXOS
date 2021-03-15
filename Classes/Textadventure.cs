using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Classes
{
    public class Textadventure
    {
        public void ExtraClass()
        {
            Console.Clear();
            MainMenu();
            Console.ReadKey();
            Console.Clear();
            TextAdventure();

            
        }

        public void MainMenu()
        {
            Console.WriteLine("Welcome to Text Adventures of Different scenerios");
            Console.ReadKey();
            Console.WriteLine("Some rules");
            Console.WriteLine("Kindly type 'Option num'instead of writing writing the option name");
        }

        

        void TextAdventure()
        {
            Console.WriteLine("What is the Player's name?");
            string c = Console.ReadLine();
            Console.WriteLine(c + " gets out of his bed?What should he do?");
            Console.WriteLine("Brush his teeth");
            Console.WriteLine("Sleep");
            Console.WriteLine("Go outside for a walk");
            Console.WriteLine("Go outside and kill sone monsters");
            Console.ReadKey();
            Console.Write(">");
            string n = Console.ReadLine();
            if(n == "Option 1")
            {
                Console.WriteLine(c, " gets up from his bed and goes to the bathroom");
                Console.WriteLine("He picks up the sword-shaped toothbrush and starts brushing");
                Console.ReadKey();
                Console.WriteLine(c , " finishes brushing\n", Console.ReadKey(), "\nYour stamina goes down by .5 and now is 9.5");
                Console.WriteLine("All other stats are the same");
                Console.ReadKey();
                Console.Clear();
                Console.ReadKey();
                Console.WriteLine("What do you want to do now?");
                Console.ReadKey();
                Console.WriteLine("Take a bath(decreases stamina by 1 and increases hygiene by 2)");
                Console.WriteLine("Go outside for a walk(stamina decreased by 2 and strength increased by 4)");
                Console.WriteLine("Go outside for killing monsters(decreases stamina by 5 and increases strength by 7 and increases XP by 4)");
                Console.WriteLine("Eat food(increases stamina by 4 and decreases hunger by 4)");
                Console.ReadKey();
                Console.Write(">");
                string nextMove = Console.ReadLine();

                // switch statement for nextMove
               switch (nextMove)
               {
                   
                   case "Option 1":
                   Console.WriteLine("You take a bath");
                   Console.WriteLine("Your stamina decreased by 1 and hygiene increased increased by 2");
                   Console.ReadKey();
                   Console.WriteLine("Your current stats are : stamina : 8.5, strength : 2, hygiene : 12, hunger : 7");
                   Console.ReadKey();
                   Console.Clear();
                   Console.WriteLine("Do you want to Exit?");
                   Console.Write(">");
                   string r = Console.ReadLine();
                   switch (r)
                   {
                       
                       case "Yes":
                       Console.WriteLine("Exiting::");
                       viOne v = new viOne();
                       v.vi();
                       break;

                       case "No":
                       Console.WriteLine("Okay!");
                       Console.WriteLine("Returning Back");
                       Console.ReadKey();
                       TextAdventure();
                       break;
                   }


                   break;

                   case "Option 2":
                   Console.WriteLine("You open the door and go for a walk");
                   Console.WriteLine("Your stamina is decreased by 2 and strength increased by 4");
                   Console.ReadKey();
                   Console.WriteLine("Your current stats are : stamina : 7.5, strength : 6, hunger : 2, hygiene : 8");
                   

                   string rc = Console.ReadLine();
                   switch (rc)
                   {
                       
                       case "Yes":
                       Console.WriteLine("Exiting::");
                       viOne v = new viOne();
                       v.vi();
                       break;

                       case "No":
                       Console.WriteLine("Okay!");
                       Console.WriteLine("Returning Back");
                       Console.ReadKey();
                       TextAdventure();
                       break;
                   }
                   break;

                   case "Option 3":
                   Console.WriteLine("You grab your sword and go outside");
                   Console.WriteLine("You realize it's raining");
                   Console.WriteLine("Do you still want to kill monsters?");
                   string na = Console.ReadLine();
                      switch (na){
                          case "Yes":
                          Console.WriteLine("Okay");
                          Console.Clear();
                          Console.WriteLine("You go outside without an umbrella");
                          Console.WriteLine("After some time.................");
                          Console.WriteLine("You found a monster!");
                          Console.WriteLine("Do you want to kill it or run");
                          string m = Console.ReadLine();
                          switch (m)
                          {
                              
                              case "Kill":
                              Console.WriteLine("You bravely swing your sword and kill the monster!");
                              Console.WriteLine("You aquired slime, gelatin, XP and strength");
                              break;
                              case "Run":
                              Console.WriteLine("You ran away from the monster");
                              Console.WriteLine("You didn't gain anything and lost 2 stamina");
                              break;
                          }
                          break;
                      }
                   
                   string rh = Console.ReadLine();
                   switch (rh)
                   {
                       
                       case "Yes":
                       Console.WriteLine("Exiting::");
                       viOne v = new viOne();
                       v.vi();
                       break;

                       case "No":
                       Console.WriteLine("Okay!");
                       Console.WriteLine("Returning Back");
                       Console.ReadKey();
                       TextAdventure();
                       break;
                   }
                   break;
               }

            }
            else if(n == "Option 3")
            {
                Console.WriteLine("You open the door and go for a walk");
                   Console.WriteLine("Your stamina is decreased by 2 and strength increased by 4");
                   Console.ReadKey();
                   Console.WriteLine("Your current stats are : stamina : 7.5, strength : 6, hunger : 2, hygiene : 8");
                   Console.ReadKey();
                   string r = Console.ReadLine();
                   switch (r)
                   {
                       
                       case "Yes":
                       Console.WriteLine("Exiting::");
                       viOne v = new viOne();
                       v.vi();
                       break;

                       case "No":
                       Console.WriteLine("Okay!");
                       Console.WriteLine("Returning Back");
                       Console.ReadKey();
                       TextAdventure();
                       break;
                   }

            }
            else if(n == "Option 4")
            {
                Console.WriteLine("You grab your sword and go outside");
                   Console.WriteLine("You realize it's raining");
                   Console.WriteLine("Do you still want to kill monsters?");
                   string na = Console.ReadLine();
                      switch (na)
                        {
                          case "Yes":
                          Console.WriteLine("Okay");
                          Console.Clear();
                          Console.WriteLine("You go outside without an umbrella");
                          Console.WriteLine("After some time.................");
                          Console.WriteLine("You found a monster!");
                          Console.WriteLine("Do you want to kill it or run");
                          string m = Console.ReadLine();
                          switch (m)
                          {
                              
                              case "Kill":
                              Console.WriteLine("You bravely swing your sword and kill the monster!");
                              Console.WriteLine("You aquired slime, gelatin, XP and strength");
                              break;
                              case "Run":
                              Console.WriteLine("You ran away from the monster");
                              Console.WriteLine("You didn't gain anything and lost 2 stamina");
                              break;
                            }
                          
                            string r = Console.ReadLine();
                            switch (r)
                            {
                                
                                case "Yes":
                                Console.WriteLine("Exiting::");
                                viOne v = new viOne();
                                v.vi();
                                break;

                                case "No":
                                Console.WriteLine("Okay!");
                                Console.WriteLine("Returning Back");
                                Console.ReadKey();
                                TextAdventure();
                                break;
                            }
                            break;
                        }
                          
            }
            else if(n == "Option 2")
            {
                Console.WriteLine("You slept");
                Console.WriteLine("Game Over!");
                Console.ReadKey();
                string r = Console.ReadLine();
                   switch (r)
                   {
                       
                       case "Yes":
                       Console.WriteLine("Exiting::");
                       viOne v = new viOne();
                       v.vi();
                       break;

                       case "No":
                       Console.WriteLine("Okay!");
                       Console.WriteLine("Returning Back");
                       Console.ReadKey();
                       TextAdventure();
                       break;
                   }

            }
        }

        
    
    }
}

