
using System.Collections.Generic;
using System;
using FG_beginner_guide_rework;

class FG_Beginner_Guide
{
    static void Main()
    {
        string pick;
        // No need to have a variable to keep track of the while loop. Just use continue or break
        // bool repeatcode = true;
        while (true)
        {
            List<String> games = new List<String>();
            games.Add("1.Tekken 8");
            games.Add("2.Street Fighter 6");
            games.Add("3.Mortal Kombat 1");

            int choice;
            Console.WriteLine("\nWelcome to the Fighting Game Beginner Guide" +
                              "\nAre you new to fighting games? \n1. Yes \n2. No \n" + "\nInput: ");

        // Missing error handling?
            if (int.TryParse(Console.ReadLine(), out choice))
            {

            };

            // To avoid nesting and make the execution cleared, I would pass the "choice equals 2" and "choice not 1 or 2" to the top and get those verifications out of the way
            // Testing for failure first saves time and makes code clearer imo 
            if (choice == 2) {
                Console.WriteLine("\nSorry, this guide is for people who are new to fighting games and want to learn.");
                return;
            } else if (choice != 1) {
                Console.WriteLine("Please enter the correct input");
                continue;
            }
            
            // Now that all failure states have been asserted, there is no need for "if choice == 1"
            // The problem here now is that we are going into a "new" menu and if the choice of the user is invalid, we can't restart just this game selection menu
            // To fix that you have to segment each menu into its own thing with its own While True loop
            Console.WriteLine("\nWhat fighting game would you like to learn?");
            Console.WriteLine("Type the number for the game option.\n");
            
            foreach (String game in games) {
                Console.WriteLine(game);
            }

            Console.WriteLine("\nInput: ");
            
            // This next line blows up if the user inputs a string that is a non-valid. Use TryParse instead or use a try catch block.
            // If you need to get int inputs from the user multiple times during runtime, its a good idea to creaTe a helper function that sanitizes that input.
            // For example a function that takes a string (question to be asked) andx then takes the input and converts to int. If it cant convert, it asks again or gives option to exit.
            // That way, you just call that function and can trust that the result is in fact either an int or a null, or even a custom made exceptiuon to handle "user wants to interrupt"
            // this works fine though -> int.TryParse(Console.ReadLine(), out gamechoice);
            int gamechoice = Convert.ToInt32(Console.ReadLine());
            
            
            // This whole following section has a big problem. You can't scale it without coming back here and adding dozens of line of samey code
            // Instead of have the whole text here in multiple WriteLines follow by the same three if statements that all lead to the same classes. You can make gamechoice call a new base class (FG_base) for example that handles this
            // I asked ChatGPT to come up with some mock code that shows what I have in mind. I have made a couple of changes but it should be clear. Check the GameChoice.md file
            switch (gamechoice)
            {
                case 1:
                    Console.WriteLine("\nTekken 8 is 3D fighting game that focus on movement.");
                    Console.WriteLine("Tekken 8 has a good tutorial that teaches you about movement & mechanics");
                    Console.WriteLine("\nWhat would you like to learn about Tekken 8?");
                    Console.WriteLine("1.Movement \n2.Picking a Character \n3.Combos \n");
                    Console.WriteLine("Input: ");
                    // Same as above
                    int fg_info = Convert.ToInt32(Console.ReadLine());
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
                    if (fg_info == 2)
                    {
                        FG_Character.SF6_Characters();
                    }
                    if (fg_info == 3)
                    {
                        FG_Combos.SF6_Combos();
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
            

            // Creating a keepasking variable here is unnecessary.
            // bool keepasking = true;
            // while (keepasking)
            while(true){
                Console.WriteLine("\nWould you like to go through the guide again?");
                Console.WriteLine("Type yes to repeat or no to end guide");
                Console.WriteLine("Input: ");
                // You can string these together and its not confusing.
                // pick = Console.ReadLine();
                // pick = pick.ToUpper();
                pick = Console.ReadLine().ToUpper();
                
                // There is no way for the user to escape this unless they answer yes or no
                switch (pick)
                {
                    case "YES":
                        // repeatcode = true;
                        // keepasking = false;
                        break;
                    case "NO":
                        Console.WriteLine("\nThank you for using the fighting guide. Go to the lab and get to practicing.");
                        // repeatcode = false;
                        // keepasking = false;
                        break;
                    default:
                        Console.WriteLine("Please choose the correct option.");
                        // keepasking = true;
                        continue;
                }
            }
        }
    }
}
