
using System.Collections.Generic;
using System;
using FG_beginner_guide_rework;

class FG_Beginner_Guide
{
    static void Main()
    {
        bool repeatcode = true;
        string pick;
        while (repeatcode)
        {
            int gamechoice;
            int fg_info;
            List<String> games = new List<String>();
            games.Add("1.Tekken 8");
            games.Add("2.Street Fighter 6");
            games.Add("3.Mortal Kombat 1");

            int choice;
            Console.WriteLine("\nWelcome to the Fighting Game Beginner Guide");
            Console.WriteLine("Are you new to fighting games? \n1. Yes \n2. No \n");
            Console.WriteLine("Input: ");
            choice = Convert.ToInt32(Console.ReadLine());

            if (choice == 1)
            {
                Console.WriteLine("\nWhat fighting game would you like to learn?");
                Console.WriteLine("Type the number for the game option.\n");
                foreach (String game in games)
                {

                    Console.WriteLine(game);

                }

                Console.WriteLine("\nInput: ");
                gamechoice = Convert.ToInt32(Console.ReadLine());

                switch (gamechoice)
                {
                    case 1:
                        Console.WriteLine("\nTekken 8 is 3D fighting game that focus on movement.");
                        Console.WriteLine("Tekken 8 has a good tutorial that teaches you about movement & mechanics");
                        Console.WriteLine("\nWhat would you like to learn about Tekken 8?");
                        Console.WriteLine("1.Movement \n2.Picking a Character \n3.Combos \n");
                        Console.WriteLine("Input: ");
                        fg_info = Convert.ToInt32(Console.ReadLine());
                        if (fg_info == 1)
                        {
                            FG_Movement.Tekken_8();
                        }
                        if (fg_info == 2)
                        {
                            FG_Character.TK8_Characters();
                        }
                        if (fg_info == 3)
                        {
                            FG_Combos.TK8_Combos();
                        }
                        break;
                    case 2:
                        Console.WriteLine("\nStreet Fighter 6 is 2D fighting game that focus on movement.");
                        Console.WriteLine("Street Fighter 6 has a good tutorial that teaches you about movement & mechanics");
                        Console.WriteLine("\nWhat would you like to learn about Street Fighter 6?");
                        Console.WriteLine("1.Movement \n2.Picking a Character \n3.Combos \n");
                        Console.WriteLine("Input: ");
                        fg_info = Convert.ToInt32(Console.ReadLine());
                        if (fg_info == 1)
                        {
                            FG_Movement.SF6();
                        }
                        break;
                    case 3:
                        Console.WriteLine("\nMortal Kombat 1 is 2D fighting game that focus on movement.");
                        Console.WriteLine("Mortal Kombat 1 has a good tutorial that teaches you about movement & mechanics");
                        Console.WriteLine("\nWhat would you like to learn about Mortal Kombat 1?");
                        Console.WriteLine("1.Movement \n2.Picking a Character \n3.Combos \n");
                        Console.WriteLine("Input: ");
                        fg_info = Convert.ToInt32(Console.ReadLine());
                        if (fg_info == 1)
                        {
                            FG_Movement.MK1();
                        }
                        break;
                }
            }
            if (choice == 2)
            {
                Console.WriteLine("\nSorry, this guide is for people who are new to fighting games and wanting to learn.");
                return;
            }
            Console.WriteLine("\nWould you like to go through the guide again?");
            Console.WriteLine("Type yes to repeat or no to end guide");
            Console.WriteLine("Input: ");
            pick = Console.ReadLine();
            pick = pick.ToUpper();

            switch (pick)
            {
                case "YES":
                    repeatcode = true;
                    break;

                case "NO":
                    Console.WriteLine("\nThank you for using the fighting guide. Go to the lab and get to practicing.");
                    repeatcode = false;
                    break;
            }
        }
    }
}
