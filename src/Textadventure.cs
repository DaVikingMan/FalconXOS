using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace src
{
    public class Textadventure
    {
        public void ExtraClass()
        {
            MainMenu();
            Console.ReadKey();
            Console.Clear();
            TextAdventure();

            
        }

        public void MainMenu()
        {
            Console.WriteLine("Welcome to Text Adventures of Different scenerios");
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
            string n = Console.ReadLine();
            if(n == "Brush his Teeth")
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

            }
            else if(n == "Sleep")
            {

            }
            else if(n == "Go outside for a walk")
            {

            }
            else if(n == "Go outside and kill some monsters")
            {

            }
        }

        
    }
}
