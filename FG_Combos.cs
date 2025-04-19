using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FG_beginner_guide_rework
{
    internal class FG_Combos
    {
        public static void TK8_Combos()
        {
            bool repeatcode = true;
            while (repeatcode)
            {
                int tk8_character_option;

                Console.WriteLine("\nCombos for Tekken 8 are usually short and simple with some moments where longer combos can provide more damage or wall carry potential.");
                Console.WriteLine("Tekken 8 combo structure is usually a launcher, attack strings to extend the combo, tornado, and a combo ender or wall carry that can end with a wall combo.");
                Console.WriteLine("\nWould you like to learn chracter specific beginner combos,key moves,and strategy? \n1.Yes \n2.No");
                Console.WriteLine("\nInput:");
                tk8_character_option = Convert.ToInt32(Console.ReadLine());
                if (tk8_character_option == 1)
                {
                    FG_Character.TK8_Characters();
                }
                if (tk8_character_option == 2)
                {
                    Console.WriteLine("Head out to practice mode and lab out some chracters");
                }
                else
                {
                    Console.WriteLine("Please choose the correct option.");
                    repeatcode = true;
                }
            }

        }

        public static void SF6_Combos()
        {

        }

        public static void MK1_Combos()
        {

        }
    }
}
