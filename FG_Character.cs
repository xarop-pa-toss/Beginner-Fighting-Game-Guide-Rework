using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FG_beginner_guide_rework
{
    internal class FG_Character
    {
        public static void TK8_Characters()
        {
            string tk8_fighter = "";
            int tk8_option;
            List<String> tk8 = new List<String>();
            //easy to learn tekken 8 characters
            tk8.Add("Kuma");
            tk8.Add("Alisa");
            tk8.Add("Asuka");
            tk8.Add("Claudio");
            tk8.Add("Clive");
            tk8.Add("Jack-8");
            tk8.Add("Panda");
            tk8.Add("Lars");
            tk8.Add("Leroy");
            tk8.Add("Lili");
            tk8.Add("Dragunov");
            tk8.Add("Shaheen");

            //intermediate to learn tekken 8 characters
            tk8.Add("Azucena");
            tk8.Add("Eddy");
            tk8.Add("Feng");
            tk8.Add("Jun");
            tk8.Add("Leo");
            tk8.Add("Lidia");
            tk8.Add("Paul");
            tk8.Add("Raven");
            tk8.Add("Victor");
            tk8.Add("Zafina");

            //Advanced to learn tekken 8 characters
            tk8.Add("Jin");
            tk8.Add("Kazuya");
            tk8.Add("Reina");
            tk8.Add("Heihachi");
            tk8.Add("Lee");
            tk8.Add("DVJ (Devil Jin)");
            tk8.Add("Hwoarang");
            tk8.Add("King");
            tk8.Add("Xiaoyu");
            tk8.Add("Nina");
            tk8.Add("Steve");
            tk8.Add("Yoshimitsu");

            bool repeatcode = true;
            while (repeatcode)
            {
                Console.WriteLine("\nTekken 8 has 36 characters.");
                Console.WriteLine("Which Tekken 8 character would you like to learn?\n");
                Console.WriteLine("List of current TK8 Characters");
                foreach (String characters in tk8)
                {
                    Console.WriteLine(characters);
                }

                Console.WriteLine("\nInput: ");
                tk8_fighter = Console.ReadLine();
                tk8_fighter = tk8_fighter.ToUpper();

                bool repeatcharacter = true;
                while (repeatcharacter)
                {
                    switch (tk8_fighter)
                    {
                        //Easy to learn
                        case "KUMA":
                            Console.WriteLine("\nDifficulty: Easy");
                            Console.WriteLine("Kuma is the joke character of tekken 8 with good range, mixups, and gimmicks with their stances.");
                            Console.WriteLine("\nWhat would you like to learn about Kuma? \n1.Key Moves \n2.Basic Combos \n3.Strategy");
                            Console.WriteLine("\nInput: ");
                            if (Int32.TryParse(Console.ReadLine(), out tk8_option))
                            {
                                switch (tk8_option)
                                {
                                    case 1:
                                        Console.WriteLine("Kuma key moves:");
                                        Console.WriteLine("1. Bear jab: 1 which can lead to 1,1,1 combo launcher");
                                        Console.WriteLine("2. Anger hook: BF 2");
                                        Console.WriteLine("3. Bear Slash: B 1");
                                        Console.WriteLine("4. Falling Bear: FF 1+2");
                                        Console.WriteLine("5. Demon Uppercut: FF 2");
                                        Console.WriteLine("6. Bear Hopkick: UF 3 can also lead to UF 3,4,1+2 combo");
                                        Console.WriteLine("7. Rabid Bear: FFF 1+2");
                                        Console.WriteLine("8. Spinning Kuma: DB 4");
                                        Console.WriteLine("9. Kuma Musou: DB 1,2");
                                        Console.WriteLine("10. Grizzly Rampage: DF 1,2,1+2");
                                        repeatcode = false;
                                        repeatcharacter = false;
                                        break;

                                    case 2:
                                        Console.WriteLine("Kuma Basic Combos:");
                                        Console.WriteLine("1. DF+2,1 > B+2,2,1 > F 1+2,1+2");
                                        Console.WriteLine("2. F 1+2,1+2 > U+2 > B+2,2,1");
                                        Console.WriteLine("3. DF 2,1 > F+4 > B+2,1 > F 1+2,1+2 > U+2 > B+1");
                                        Console.WriteLine("4. DF 2,1 > B+2,2,1 > U+2 > QCF+2,1");
                                        Console.WriteLine("5. DF+2,1 > B+,2,2,1 > U+2 > HEAT > HEAT SMASH");
                                        repeatcode = false;
                                        repeatcharacter = false;
                                        break;

                                    case 3:
                                        Console.WriteLine("Salmon 3");
                                        repeatcode = false;
                                        repeatcharacter = false;
                                        break;

                                    default:
                                        Console.WriteLine("Please enter the correct option.");
                                        break;
                                }
                            }
                            else
                            {
                                Console.WriteLine("Please select the correct number!");
                            }
                            break;
                        case "ALISA":
                            Console.WriteLine("\nDifficulty: Easy");
                            Console.WriteLine("Alisa is a well rounded character with strong/simple poking and neutral.");
                            Console.WriteLine("\nWhat would you like to learn about Alisa? \n1.Key Moves \n2.Basic Combos \n3.Strategy");
                            Console.WriteLine("\nInput: ");
                            if (Int32.TryParse(Console.ReadLine(), out tk8_option))
                            {
                                switch (tk8_option)
                                {
                                    case 1:
                                        Console.WriteLine("Alisa key moves:");
                                        Console.WriteLine("1. Clockwork Spring Middle: WR+3,3/WR+3,D+3");
                                        Console.WriteLine("2. Transmission: B+1+2");
                                        Console.WriteLine("3. Hertz Blade - Diable: DS F+1+2");
                                        Console.WriteLine("4. Shredder: DS 1");
                                        Console.WriteLine("5. Hertz Blade: DS F+1");
                                        Console.WriteLine("6. Quick Trim: 3,2");
                                        Console.WriteLine("7. Thruster Drill: DBB 1+2");
                                        Console.WriteLine("8. Optimizer: D+4, 1+2");
                                        Console.WriteLine("9. Image Cutter: UF+2");
                                        Console.WriteLine("10. Dual Session: F+2,1");
                                        repeatcode = false;
                                        repeatcharacter = false;
                                        break;

                                    case 2:
                                        Console.WriteLine("Alisa Basic Combos:");
                                        Console.WriteLine("1. DF+2 > B+2,3 > F+4,1,4");
                                        Console.WriteLine("2. DF+2 > DF+1,1 > B+2,3 > B+4,3");
                                        Console.WriteLine("3. DF+2 > UF+1,F+4 > F+1");
                                        Console.WriteLine("4. UF+4,4 > WR+1,2,3 > UF+1,F+4 > F+1");
                                        Console.WriteLine("5. UF+4,4 > F+2 > DF+1,1 > B+2,3 > 1,2,2");
                                        repeatcode = false;
                                        repeatcharacter = false;
                                        break;

                                    case 3:
                                        Console.WriteLine("Salmon 3");
                                        repeatcode = false;
                                        repeatcharacter = false;
                                        break;

                                    default:
                                        Console.WriteLine("Please enter the correct option.");
                                        break;
                                }
                            }
                            else
                            {
                                Console.WriteLine("Please select the correct number!");
                            }
                            break;
                        case "ASUKA":
                            Console.WriteLine("\nDifficulty: Easy");
                            Console.WriteLine("Asuka has a strong keepout game along with strong and unique oki.");
                            Console.WriteLine("\nWhat would you like to learn about Asuka? \n1.Key Moves \n2.Basic Combos \n3.Strategy");
                            Console.WriteLine("\nInput: ");
                            if (Int32.TryParse(Console.ReadLine(), out tk8_option))
                            {
                                switch (tk8_option)
                                {
                                    case 1:
                                        Console.WriteLine("Auska key moves:");
                                        Console.WriteLine("1. Mist Palm Thrust: SS+2");
                                        Console.WriteLine("2. Swallow Vortex: DB+1+2");
                                        Console.WriteLine("3. Heart Stopper: B+4");
                                        Console.WriteLine("4. Sashiro: D+1+2");
                                        Console.WriteLine("5. White Mountain: DF+2+3");
                                        Console.WriteLine("6. Ryunntsui: 3+4");
                                        Console.WriteLine("7. Leaping Spin Kick: FF+4");
                                        Console.WriteLine("8. Double Lift Kicks: D+3+4");
                                        Console.WriteLine("9. Exorcisor: F+1+2");
                                        Console.WriteLine("10. Naniwa Gusto: U+1+2");
                                        repeatcharacter = false;
                                        repeatcode = false;
                                        break;

                                    case 2:
                                        Console.WriteLine("Asuka Basic Combos:");
                                        Console.WriteLine("1. F+2 > FF2+3 > DB+1,4 > FF+4 > FF+2,1+2 > 1+2");
                                        Console.WriteLine("2. UF+4 > FF+2,3 > DB+1,4 > FF+4 > FF+1,1+2 > 1+2");
                                        Console.WriteLine("3. WR+3 > FF+2,3 > DB+1,4 > FF+4 > FF+1,1+2 > 1+2");
                                        Console.WriteLine("4. DB+2 > FF+2,3 > DB+1,4 > FF+4 > FF+2,1+2 > 1+2");
                                        Console.WriteLine("5. DF+2 > FF+2,3 > DB+1,4 > FF+4 > FF+2,1+2 > 1+2");
                                        repeatcharacter = false;
                                        repeatcode = false;
                                        break;

                                    case 3:
                                        Console.WriteLine("Salmon 3");
                                        repeatcode = false;
                                        repeatcharacter = false;
                                        break;

                                    default:
                                        Console.WriteLine("Please select the correct option.");
                                        break;
                                }
                            }
                            else
                            {
                                Console.WriteLine("Please select the correct number!");
                            }
                            break;
                        case "CLAUDIO":
                            Console.WriteLine("\nDifficulty: Easy");
                            Console.WriteLine("Claudio is a unique install character with a strong hopkick option");
                            Console.WriteLine("\nWhat would you like to learn about Claudio? \n1.Key Moves \n2.Basic Combos \n3.Strategy");
                            Console.WriteLine("\nInput: ");
                            if (Int32.TryParse(Console.ReadLine(), out tk8_option))
                            {
                                switch (tk8_option)
                                {
                                    case 1:
                                        Console.WriteLine("Claudio key moves:");
                                        Console.WriteLine("1. Vanishing Storm: B+1");
                                        Console.WriteLine("2. Luxuria: SS+4");
                                        Console.WriteLine("3. Dispel Magic/Dispel Force: DF+3,1/DF+3,2");
                                        Console.WriteLine("4. Invidia: FF+4");
                                        Console.WriteLine("5. Sky Slash Nova: UF+4");
                                        Console.WriteLine("6. Sky's Arc: DF+1,2");
                                        Console.WriteLine("7. Cross Arm Impact Burst: F+1+2,1+2");
                                        Console.WriteLine("8. Chaos Fist: DF+2");
                                        Console.WriteLine("9. Acedia: DB+3");
                                        Console.WriteLine("10. Judgment Claw: Move_input");
                                        repeatcharacter = false;
                                        repeatcode = false;
                                        break;

                                    case 2:
                                        Console.WriteLine("Claudio Basic Combos:");
                                        Console.WriteLine("1. UF+4 > B+2 > FF+4 > B+3 > F+2 > B+4,2");
                                        Console.WriteLine("2. UF+4 > FF+4 > B+3 > DF+3,2 > B+4,4 > FFF+2");
                                        Console.WriteLine("3. DF+1,2 > FF+4 > B+3 > UF 3+4 > DB 1+2 > FFF+2");
                                        Console.WriteLine("4. UF+4 > FF+4 > B+3 > B+2 > FF+4 > 3,2");
                                        Console.WriteLine("5. UF+4 > FF+4 > B+3 > B+3 > UF 3+4 > DB 1+2 > FFF+2");
                                        repeatcharacter = false;
                                        repeatcode = false;
                                        break;

                                    case 3:
                                        Console.WriteLine("Salmon 3");
                                        repeatcode = false;
                                        repeatcharacter = false;
                                        break;

                                    default:
                                        Console.WriteLine("Please select the correct option.");
                                        break;
                                }
                            }
                            else
                            {
                                Console.WriteLine("Please select the correct number!");
                            }
                            break;
                        case "CLIVE":
                            Console.WriteLine("\nDifficulty: Easy");
                            Console.WriteLine("Clive is a guest character with good space control and final fantasy character");
                            Console.WriteLine("\nWhat would you like to learn about Clive? \n1.Key Moves \n2.Basic Combos \n3.Strategy");
                            Console.WriteLine("\nInput: ");
                            if (Int32.TryParse(Console.ReadLine(), out tk8_option))
                            {
                                switch (tk8_option)
                                {
                                    case 1:
                                        Console.WriteLine("Clive key moves:");
                                        Console.WriteLine("1. Body Jab: DF+1");
                                        Console.WriteLine("2. Prominence: F+1+2");
                                        Console.WriteLine("3. Flame Bash: 1+2");
                                        Console.WriteLine("4. Blue Bolt: B+1");
                                        Console.WriteLine("5. Cold Cyclone: DB+4");
                                        Console.WriteLine("6. Pile Driver: D+1+2");
                                        Console.WriteLine("7. Door Knocker: DF+4");
                                        Console.WriteLine("8. Stone Smite: SS+1+2");
                                        Console.WriteLine("9. Windup: B+1+2");
                                        Console.WriteLine("10. Tidal Surge: DB+1");
                                        repeatcharacter = false;
                                        repeatcode = false;
                                        break;

                                    case 2:
                                        Console.WriteLine("Clive Basic Combos:");
                                        Console.WriteLine("1. DF+2 > DB 1+2,1 > UF+2,2 > B+2F > PS 2,2");
                                        Console.WriteLine("2. DF+2 > DF+1,4 > DB 1+2,1 > UPD 22 > DASH DF+1,2F > PS 1");
                                        Console.WriteLine("3. DF+2 > DB 1+2,1 > UPD 3 > DASH DF+1,4,3 > WOL 2");
                                        Console.WriteLine("4. F+3 > D+1 > WR+4 > 1 > DASH DF+1,4,3 > WOL 2");
                                        Console.WriteLine("5. SS 1+2 > DF+1,4 > DB 1+2,1 > UPD 2,2 > DASH B+2F > PS 1,2");
                                        repeatcharacter = false;
                                        repeatcode = false;
                                        break;

                                    case 3:
                                        Console.WriteLine("Salmon 3");
                                        repeatcode = false;
                                        repeatcharacter = false;
                                        break;

                                    default:
                                        Console.WriteLine("Please select the correct option.");
                                        break;
                                }
                            }
                            else
                            {
                                Console.WriteLine("Please select the correct number!");
                            }
                            break;
                        case "JACK-8":
                            Console.WriteLine("\nDifficulty: Easy");
                            Console.WriteLine("Jack-8 has good range with his attacks and rushdown pressure as well.");
                            Console.WriteLine("\nWhat would you like to learn about Jack-8? \n1.Key Moves \n2.Basic Combos \n3.Strategy");
                            Console.WriteLine("\nInput: ");
                            if (Int32.TryParse(Console.ReadLine(), out tk8_option))
                            {
                                switch (tk8_option)
                                {
                                    case 1:
                                        Console.WriteLine("Jack-8 key moves:");
                                        Console.WriteLine("1. Jackhammer: FF+1");
                                        Console.WriteLine("2. Pinpoint Assault: F+2");
                                        Console.WriteLine("3. Jab Elbow Smash: 2,1 (doing 2,1,2 can be a launcher)");
                                        Console.WriteLine("4. Granite Stomping: FF+3");
                                        Console.WriteLine("5. Impact Driver: F+1,1");
                                        Console.WriteLine("6. Drilling Engine/Piston Gun Blaster: F+1,2,1/F+1,2,2");
                                        Console.WriteLine("7. F+3,2/F+3,1+2: Two-Step Die/Machine Press");
                                        Console.WriteLine("8. Machinegun Blast: DB+1");
                                        Console.WriteLine("9. Barrel Jacket Hammer: UB+1+2");
                                        Console.WriteLine("10. Rolling Death Crusher: F+1+2");
                                        repeatcharacter = false;
                                        repeatcode = false;
                                        break;

                                    case 2:
                                        Console.WriteLine("Jack-8 Basic Combos:");
                                        Console.WriteLine("1. DF+2 > DF+1,1 > B+3,2,2");
                                        Console.WriteLine("2. 1+2 > FF+2 > B+1 > B+3,2D > GAHL F+1");
                                        Console.WriteLine("3. DF+2 > B+4 > B+3,2 > F+1,2,1 > RUN F+1,2,1");
                                        Console.WriteLine("4. DF+2,1D > GAHL 2 > FF+2 > B+3,2D > GAHL F+1");
                                        Console.WriteLine("5. DF+2,1(Hold 1) > FF+2 > B+1 > F+1,2,1 ");
                                        repeatcharacter = false;
                                        repeatcode = false;
                                        break;

                                    case 3:
                                        Console.WriteLine("Salmon 3");
                                        repeatcode = false;
                                        repeatcharacter = false;
                                        break;

                                    default:
                                        Console.WriteLine("Please select the correct option.");
                                        break;
                                }
                            }
                            else
                            {
                                Console.WriteLine("Please select the correct number!");
                            }
                            break;
                        case "PANDA":
                            Console.WriteLine("\nDifficulty: Easy");
                            Console.WriteLine("Panda is the joke character of tekken 8 with good range, mixups, and gimmicks with their stances.");
                            Console.WriteLine("\nWhat would you like to learn about Panda? \n1.Key Moves \n2.Basic Combos \n3.Strategy");
                            Console.WriteLine("\nInput: ");
                            if (Int32.TryParse(Console.ReadLine(), out tk8_option))
                            {
                                switch (tk8_option)
                                {
                                    case 1:
                                        Console.WriteLine("Panda key moves:");
                                        Console.WriteLine("1. Bear jab: 1 which can lead to 1,1,1 combo launcher");
                                        Console.WriteLine("2. Anger hook: BF 2");
                                        Console.WriteLine("3. Bear Slash: B 1");
                                        Console.WriteLine("4. Falling Bear: FF 1+2");
                                        Console.WriteLine("5. Demon Uppercut: FF 2");
                                        Console.WriteLine("6. Bear Hopkick: UF 3 can also lead to UF 3,4,1+2 combo");
                                        Console.WriteLine("7. Rabid Bear: FFF 1+2");
                                        Console.WriteLine("8. Spinning Kuma: DB 4");
                                        Console.WriteLine("9. Kuma Musou: DB 1,2");
                                        Console.WriteLine("10. Grizzly Rampage: DF 1,2,1+2");
                                        repeatcharacter = false;
                                        repeatcode = false;
                                        break;

                                    case 2:
                                        Console.WriteLine("Panda Basic Combos:");
                                        Console.WriteLine("1. DF+2,1 > B+2,2,1 > F 1+2,1+2");
                                        Console.WriteLine("2. F 1+2,1+2 > U+2 > B+2,2,1");
                                        Console.WriteLine("3. DF 2,1 > F+4 > B+2,1 > F 1+2,1+2 > U+2 > B+1");
                                        Console.WriteLine("4. DF 2,1 > B+2,2,1 > U+2 > QCF+2,1");
                                        Console.WriteLine("5. DF+2,1 > B+,2,2,1 > U+2 > HEAT > HEAT SMASH");
                                        repeatcharacter = false;
                                        repeatcode = false;
                                        break;

                                    case 3:
                                        Console.WriteLine("Salmon 3");
                                        repeatcode = false;
                                        repeatcharacter = false;
                                        break;

                                    default:
                                        Console.WriteLine("Please select the correct option.");
                                        break;
                                }
                            }
                            else
                            {
                                Console.WriteLine("Please select the correct number!");
                            }
                            break;
                        case "LARS":
                            Console.WriteLine("\nDifficulty: Easy");
                            Console.WriteLine("Lars is a rushdown character with strong stance mixups");
                            Console.WriteLine("\nWhat would you like to learn about Lars? \n1.Key Moves \n2.Basic Combos \n3.Strategy");
                            Console.WriteLine("\nInput: ");
                            if (Int32.TryParse(Console.ReadLine(), out tk8_option))
                            {
                                switch (tk8_option)
                                {
                                    case 1:
                                        Console.WriteLine("Lars key moves:");
                                        Console.WriteLine("1. Ring Current: 2,1");
                                        Console.WriteLine("2. Bow Shock: DE+3");
                                        Console.WriteLine("3. Elbow Corona: FF+1+2");
                                        Console.WriteLine("4. Double Pulse: FF+4,3");
                                        Console.WriteLine("5. Shadow Cutter: DB+4");
                                        Console.WriteLine("6. Lighting Screw: UF+3");
                                        Console.WriteLine("7. Surge Blast: FF+2");
                                        Console.WriteLine("8. UF+4: Storm Axle");
                                        Console.WriteLine("9. Ark Blast: F+1+2");
                                        Console.WriteLine("10. X-Ray: 1+2");
                                        repeatcharacter = false;
                                        repeatcode = false;
                                        break;

                                    case 2:
                                        Console.WriteLine("Lars Basic Combos:");
                                        Console.WriteLine("1. UF+4 > DE+2 > DF+3,DFDE > F+2,1,SE 1+2 > F2,1,SE 3+4");
                                        Console.WriteLine("2. FB+2,1 > DE+2 > F+1,2,3 > 1 > SE+1+2 > F+3,2,UF > 4");
                                        Console.WriteLine("3. F+1+2 > DB2,1 > 2 > FF+4,2,DE+1 > SE+1+2 > FFF+2,1 > 1");
                                        Console.WriteLine("4. UF+3 > DF2 > DB+2,SE+1+2 > DF+1 > DF3,DF,DE,2,UF > 4");
                                        Console.WriteLine("5. WR+3 > FF+2 > FF+1,2,3,DE+1 > DE,SE+3+4");
                                        repeatcharacter = false;
                                        repeatcode = false;
                                        break;

                                    case 3:
                                        Console.WriteLine("Salmon 3");
                                        repeatcode = false;
                                        repeatcharacter = false;
                                        break;

                                    default:
                                        Console.WriteLine("Please select the correct option.");
                                        break;
                                }
                            }
                            else
                            {
                                Console.WriteLine("Please select the correct number!");
                            }
                            break;
                        case "LEROY":
                            Console.WriteLine("\nDifficulty: Easy");
                            Console.WriteLine("Leroy has good stance pressure/mixups and benefits from counter hits when players make a mistake");
                            Console.WriteLine("\nWhat would you like to learn about Leroy? \n1.Key Moves \n2.Basic Combos \n3.Strategy");
                            Console.WriteLine("\nInput: ");
                            if (Int32.TryParse(Console.ReadLine(), out tk8_option))
                            {
                                switch (tk8_option)
                                {
                                    case 1:
                                        Console.WriteLine("Leroy key moves:");
                                        Console.WriteLine("1. Jab: 1");
                                        Console.WriteLine("2. Body Jab: DF+1");
                                        Console.WriteLine("3. Outcast Arrow: B+1+2");
                                        Console.WriteLine("4. Hermit's Fist: B+1");
                                        Console.WriteLine("5. Feiche Xuan Feng Jiao: B+3");
                                        Console.WriteLine("6. Amputation Kick: DB+3");
                                        Console.WriteLine("7. Twin Snake Strike: D+3,2");
                                        Console.WriteLine("8. Floating Axe Drop: UF+4");
                                        Console.WriteLine("9. Zhuan Shen Jiao: B+4");
                                        Console.WriteLine("10. Snap Kick Knee: DF+4,3");
                                        repeatcharacter = false;
                                        repeatcode = false;
                                        break;

                                    case 2:
                                        Console.WriteLine("Leroy Basic Combos:");
                                        Console.WriteLine("1. DF+2,1+2 > QCF+2 > F+3 > D+3,2 > HRMT 2,3 > B+3+4");
                                        Console.WriteLine("2. DF+2,1+2 > F+2,3,4 > HRMT 2,3 > NMBL B+3 > HRMT 2,3");
                                        Console.WriteLine("3. DF+2,1+2 > QCF+2 > 2,2 > F+3,1+2,4 > DASH B+3 > HRMT 2,3");
                                        Console.WriteLine("4. DF+3+4 > QCF+2 > 2,2 > UF+3+4,1+2");
                                        Console.WriteLine("5. DB+2,3 > D > QCF+2 > 2 > DF+3,1 > DASH B+3+4");
                                        repeatcharacter = false;
                                        repeatcode = false;
                                        break;

                                    case 3:
                                        Console.WriteLine("Salmon 3");
                                        repeatcode = false;
                                        repeatcharacter = false;
                                        break;

                                    default:
                                        Console.WriteLine("Please select the correct option.");
                                        break;
                                }
                            }
                            else
                            {
                                Console.WriteLine("Please select the correct number!");
                            }
                            break;
                        case "LILI":
                            Console.WriteLine("\nDifficulty: Easy");
                            Console.WriteLine("Lili has good sidestepping tools along with applying pressure with her attacks.");
                            Console.WriteLine("\nWhat would you like to learn about Lili? \n1.Key Moves \n2.Basic Combos \n3.Strategy");
                            Console.WriteLine("\nInput: ");
                            if (Int32.TryParse(Console.ReadLine(), out tk8_option))
                            {
                                switch (tk8_option)
                                {
                                    case 1:
                                        Console.WriteLine("Lili key moves:");
                                        Console.WriteLine("1. Capricorn Kick: UF+3");
                                        Console.WriteLine("2. Submissive Heel: DF+3");
                                        Console.WriteLine("3. Thorn Whip: D+3");
                                        Console.WriteLine("4. Root of Evil: FF+4");
                                        Console.WriteLine("5. Orleans Sword: DF+2");
                                        Console.WriteLine("6. Heavy Languish: D+1,2");
                                        Console.WriteLine("7. BC)lier Attaque: F+4");
                                        Console.WriteLine("8. Kitty Claws: F+1+2");
                                        Console.WriteLine("9. Dominating Heel: DF+4,4");
                                        Console.WriteLine("10. Angel Heart: DGL 1+2");
                                        repeatcharacter = false;
                                        repeatcode = false;
                                        break;

                                    case 2:
                                        Console.WriteLine("Lili Basic Combos:");
                                        Console.WriteLine("1. UF+2 > B1,4 > 3,2,3");
                                        Console.WriteLine("2. DB+4 > 3,2 > 2 > D+2,2,3");
                                        Console.WriteLine("3. DF+2 > DF+2 > DF+3+4 > 1,2 > FF+3F > 1,4");
                                        Console.WriteLine("4. UF+3 > 4 > F+2,3 > DF+3+4 > 1,3 > FF+3F > 1,4");
                                        Console.WriteLine("5. UF+3 > DF+2 > F+2,3 > FF+3F > UF+3+4,3+4 > FF+3F > 1,4");
                                        repeatcharacter = false;
                                        repeatcode = false;
                                        break;

                                    case 3:
                                        Console.WriteLine("Salmon 3");
                                        repeatcode = false;
                                        repeatcharacter = false;
                                        break;

                                    default:
                                        Console.WriteLine("Please select the correct option.");
                                        break;
                                }
                            }
                            else
                            {
                                Console.WriteLine("Please select the correct number!");
                            }
                            break;
                        case "DRAGUNOV":
                            Console.WriteLine("\nDifficulty: Easy");
                            Console.WriteLine("Dragunov has strong pokes, rushdown and, throw game");
                            Console.WriteLine("\nWhat would you like to learn about Dragunov? \n1.Key Moves \n2.Basic Combos \n3.Strategy");
                            Console.WriteLine("\nInput: ");
                            if (Int32.TryParse(Console.ReadLine(), out tk8_option))
                            {
                                switch (tk8_option)
                                {
                                    case 1:
                                        Console.WriteLine("Dragunov key moves:");
                                        Console.WriteLine("1. Russian Hook Special: FFF+2");
                                        Console.WriteLine("2. Tundra Slash: B+4,3");
                                        Console.WriteLine("3. Tundra Strike to Ear Grab: B+4,2,1");
                                        Console.WriteLine("4. Tundra Strike to Ambush Tackle: B+4,2,1+2");
                                        Console.WriteLine("5. Ignition Switch: QCF+4");
                                        Console.WriteLine("6. Cocked Hammer: QCF+1");
                                        Console.WriteLine("7. Bunker-Buster Elbow: D+1");
                                        Console.WriteLine("8. Deadly Scorpion: DB+3+4");
                                        Console.WriteLine("9. Stinger Elbow: QCB+2");
                                        Console.WriteLine("10. Blizzard Hammer: B+1+2");
                                        repeatcharacter = false;
                                        repeatcode = false;
                                        break;

                                    case 2:
                                        Console.WriteLine("Dragunov Basic Combos:");
                                        Console.WriteLine("1. DF+2 > F+4,3 > FF+2");
                                        Console.WriteLine("2. DF+2 > F+4,4,3 > B+1,2 > DASH DF+3+4 > 3,1DF > SNK 1+2");
                                        Console.WriteLine("3. DF+2 > DF+1 > 4,4 > CR DF+1,4 > SNK2 > DASH DF+3+4 > 2,1DF > SNK4");
                                        Console.WriteLine("4. QCF+1 > SSL > QCF+3+4 > 4,4 > CR DF+1,4 > SNK2 > DASH > 2,1DF > SNK2");
                                        Console.WriteLine("5. QCB+2 > DASH > DF+3+4 > 4,4 > CR DF+1,4 > SNK4");
                                        repeatcharacter = false;
                                        repeatcode = false;
                                        break;

                                    case 3:
                                        Console.WriteLine("Salmon 3");
                                        repeatcode = false;
                                        repeatcharacter = false;
                                        break;

                                    default:
                                        Console.WriteLine("Please select the correct option.");
                                        break;
                                }
                            }
                            else
                            {
                                Console.WriteLine("Please select the correct number!");
                            }
                            break;
                        case "SHAHEEN":
                            Console.WriteLine("\nDifficulty: Easy");
                            Console.WriteLine("Shaheen has a simple poking game to force mistakes from opponents along with a strong slide/mixup game");
                            Console.WriteLine("\nWhat would you like to learn about Shaheen? \n1.Key Moves \n2.Basic Combos \n3.Strategy");
                            Console.WriteLine("\nInput: ");
                            if (Int32.TryParse(Console.ReadLine(), out tk8_option))
                            {
                                switch (tk8_option)
                                {
                                    case 1:
                                        Console.WriteLine("Shaheen key moves:");
                                        Console.WriteLine("1. Body Jab: DF+1");
                                        Console.WriteLine("2. Rising Falcon: DF+2");
                                        Console.WriteLine("3. Piercing Talon: F+4");
                                        Console.WriteLine("4. Achernar: B+1");
                                        Console.WriteLine("5. Elnath: B+3+4");
                                        Console.WriteLine("6. Whirlwind Kick: DF+3");
                                        Console.WriteLine("7. Antares: FFF+2");
                                        Console.WriteLine("8. Heel Strike: B+3");
                                        Console.WriteLine("9. Silent Rigel: D+3");
                                        Console.WriteLine("10. Vicious Stomp: D+4");
                                        repeatcharacter = false;
                                        repeatcode = false;
                                        break;

                                    case 2:
                                        Console.WriteLine("Shaheen Basic Combos:");
                                        Console.WriteLine("1. UF+4 > 4,1 > F+2,3 > UF+1");
                                        Console.WriteLine("2. UF+4 > 3DF+SHSP > DB+2DF > 1 > F+2,3 > DASH DB+2DF+3");
                                        Console.WriteLine("3. UF+4 > 3DF+2 > F+2,4,4 > FF+3 > DASH DB2+DF+3");
                                        Console.WriteLine("4. DB+4 > D+2 > D+2 > DB+2+DF > 1 > F+2,3 > DASH DB+2+DF+3");
                                        Console.WriteLine("5. FF+4 > DASH D+2 > DB+2+DF > 1 > DF+4,1,DF+3");
                                        repeatcharacter = false;
                                        repeatcode = false;
                                        break;

                                    case 3:
                                        Console.WriteLine("Salmon 3");
                                        repeatcode = false;
                                        repeatcharacter = false;
                                        break;

                                    default:
                                        Console.WriteLine("Please select the correct option.");
                                        break;
                                }
                            }
                            else
                            {
                                Console.WriteLine("Please select the correct number!");
                            }
                            break;

                        //Intermediate to learn
                        case "AZUCENA":
                            Console.WriteLine("\nDifficulty: Intermediate");
                            Console.WriteLine("Azucena, the Coffee Queen, has an aggressive rushdown playstyle along with float like a butterfly, sting like a bee offense with her stances.");
                            Console.WriteLine("\nWhat would you like to learn about Azucena? \n1.Key Moves \n2.Basic Combos \n3.Strategy");
                            Console.WriteLine("\nInput: ");
                            if (Int32.TryParse(Console.ReadLine(), out tk8_option))
                            {
                                switch (tk8_option)
                                {
                                    case 1:
                                        Console.WriteLine("Azucena key moves:");
                                        Console.WriteLine("1. Expresso Agression: FFF+3,2");
                                        Console.WriteLine("2. Grande Combo: DF+1");
                                        Console.WriteLine("3. Groovy Strike: 3");
                                        Console.WriteLine("4. High Mountain Combo: 1,1");
                                        Console.WriteLine("5. Taconees Drip: UF+4");
                                        Console.WriteLine("6. Aero Press Pegar: F+1+2");
                                        Console.WriteLine("7. Bitter Low Kick: DB+4");
                                        Console.WriteLine("8. Borassca Kick: DB+3");
                                        Console.WriteLine("9. Rhythmic Hook: U+2");
                                        Console.WriteLine("10. Hand Drip Hammer: D+1");
                                        repeatcharacter = false;
                                        repeatcode = false;
                                        break;

                                    case 2:
                                        Console.WriteLine("Azucena Basic Combos:");
                                        Console.WriteLine("1. DF+4,1 > F+3,2");
                                        Console.WriteLine("2. UF+4 > D+3,3,4 > B+4,3,4,3");
                                        Console.WriteLine("3. DF+2 > D+2,3 > LIB 4,1,2 > DASH F+2,1,4");
                                        Console.WriteLine("4. DF+2 > 4,3 > D+2,3 > LIB 1+2 > F+2,1,4");
                                        Console.WriteLine("5. DF+2 > 4,1 > 3 > LIB 4,1,2 > DASH F+2,1,4");
                                        repeatcharacter = false;
                                        repeatcode = false;
                                        break;

                                    case 3:
                                        Console.WriteLine("Salmon 3");
                                        repeatcode = false;
                                        repeatcharacter = false;
                                        break;

                                    default:
                                        Console.WriteLine("Please select the correct option.");
                                        break;
                                }
                            }
                            else
                            {
                                Console.WriteLine("Please select the correct number!");
                            }
                            break;
                        case "EDDY":
                            Console.WriteLine("\nDifficulty: Intermediate");
                            Console.WriteLine("Eddy Gordo, The Indomitable Flash, with his capoeria has some creative offense with his stances along with his attacks having 50/50 options.");
                            Console.WriteLine("\nWhat would you like to learn about Eddy? \n1.Key Moves \n2.Basic Combos \n3.Strategy");
                            Console.WriteLine("\nInput: ");
                            if (Int32.TryParse(Console.ReadLine(), out tk8_option))
                            {
                                switch (tk8_option)
                                {
                                    case 1:
                                        Console.WriteLine("Eddy key moves:");
                                        Console.WriteLine("1. Sincelo: 3,3");
                                        Console.WriteLine("2. Sismo: D+3");
                                        Console.WriteLine("3. Terremoto: FF+3");
                                        Console.WriteLine("4. Iemanja: NA 3+4");
                                        Console.WriteLine("5. Lunging Brush Fire: B+3+4");
                                        Console.WriteLine("6. Godeme Trovoada: FBA/BBA 1");
                                        Console.WriteLine("7. Travao: FFF+3");
                                        Console.WriteLine("8. Asfixiante: UF+3");
                                        Console.WriteLine("9. Gafanhoto: FC DF+3");
                                        Console.WriteLine("10. Faisca: SS 3+4");
                                        repeatcharacter = false;
                                        repeatcode = false;
                                        break;

                                    case 2:
                                        Console.WriteLine("Eddy Basic Combos:");
                                        Console.WriteLine("1. DF+3 > DF+1,3 > DB+4,4");
                                        Console.WriteLine("2. DF+3 > 3,3 > FBA/BBA 3,3,3 > NA 3,3");
                                        Console.WriteLine("3. DF+3 > 3,3 > FBA/BBA 3,3,3 > NA 1,4,4");
                                        Console.WriteLine("4. DF+3 > B+3,3 > NA 2 > B+1 > WR 1,4 > QCF+3 > DASH DB+4,4");
                                        Console.WriteLine("5. FF+4 > BA 2 > B+1 > WR 1,4 > QCF+3 > UF+4 > NA 3,3");
                                        repeatcharacter = false;
                                        repeatcode = false;
                                        break;

                                    case 3:
                                        Console.WriteLine("Salmon 3");
                                        repeatcode = false;
                                        repeatcharacter = false;
                                        break;

                                    default:
                                        Console.WriteLine("Please select the correct option.");
                                        break;
                                }
                            }
                            else
                            {
                                Console.WriteLine("Please select the correct number!");
                            }
                            break;
                        case "FENG":
                            Console.WriteLine("\nDifficulty: Intermediate");
                            Console.WriteLine("Feng Wei, the God Fist, is know for his well rounded playstyle and strong turn stealing tools to get back on offense.");
                            Console.WriteLine("\nWhat would you like to learn about Feng Wei? \n1.Key Moves \n2.Basic Combos \n3.Strategy");
                            Console.WriteLine("\nInput: ");
                            if (Int32.TryParse(Console.ReadLine(), out tk8_option))
                            {
                                switch (tk8_option)
                                {
                                    case 1:
                                        Console.WriteLine("Feng Wei key moves:");
                                        Console.WriteLine("1. Iron Palm: B+1");
                                        Console.WriteLine("2. Evading Palm Strike: UF+2");
                                        Console.WriteLine("3. Piercing Arrow: DB+3");
                                        Console.WriteLine("4. Chin Breaker: B+3");
                                        Console.WriteLine("5. Lift Kick: DF+3");
                                        Console.WriteLine("6. Pau Lau Stinger: DF+4");
                                        Console.WriteLine("7. Xuan Jiao Xiao Yan Shou: FC DF+4,1");
                                        Console.WriteLine("8. Fish Hook: B+4");
                                        Console.WriteLine("9. Landslide: QCF+1");
                                        Console.WriteLine("10. Ruinous Halberd: DF+3+4");
                                        repeatcharacter = false;
                                        repeatcode = false;
                                        break;

                                    case 2:
                                        Console.WriteLine("Feng Wei Basic Combos:");
                                        Console.WriteLine("1. UF+4 > F+3,4 > F+2,1,2");
                                        Console.WriteLine("2. DF+3 > F+3,4 > B+1+2");
                                        Console.WriteLine("3. UF+4 > F+3,2 > DF+4,2,1+2 > DASH UF+3 > 3,1+2");
                                        Console.WriteLine("4. UF+4 > DF+4,3 > DF+4,2,1+2 > DASH UF+3 > 3,1+2");
                                        Console.WriteLine("5. SS+4 > B+3 > 2 > DF+4,2,1+2");
                                        repeatcharacter = false;
                                        repeatcode = false;
                                        break;

                                    case 3:
                                        Console.WriteLine("Salmon 3");
                                        repeatcode = false;
                                        repeatcharacter = false;
                                        break;

                                    default:
                                        Console.WriteLine("Please select the correct option.");
                                        break;
                                }
                            }
                            else
                            {
                                Console.WriteLine("Please select the correct number!");
                            }
                            break;
                        case "JUN":
                            Console.WriteLine("\nDifficulty: Intermediate");
                            Console.WriteLine("Jun Kazama, The Light of Hope, is a well rounded character with strong poking game and punishing opponents for making mistakes.");
                            Console.WriteLine("\nWhat would you like to learn about Jun? \n1.Key Moves \n2.Basic Combos \n3.Strategy");
                            Console.WriteLine("\nInput: ");
                            if (Int32.TryParse(Console.ReadLine(), out tk8_option))
                            {
                                switch (tk8_option)
                                {
                                    case 1:
                                        Console.WriteLine("Jun key moves:");
                                        Console.WriteLine("1. Kagura: SS+4");
                                        Console.WriteLine("2. Tokkei - Misogi: FF+1+2");
                                        Console.WriteLine("3. Ayame: DB+2");
                                        Console.WriteLine("4. Leg Scythe: DB+3");
                                        Console.WriteLine("5. Saiuntsui: UF+3");
                                        Console.WriteLine("6. Sudare Nagashi: WR 1+2");
                                        Console.WriteLine("7. Getsukankyaku: F+4");
                                        Console.WriteLine("8. Saiuntsui: U+3+4");
                                        Console.WriteLine("9. Falling Rain: DB+1+2");
                                        Console.WriteLine("10. Grace: FC DF+2");
                                        repeatcharacter = false;
                                        repeatcode = false;
                                        break;

                                    case 2:
                                        Console.WriteLine("Jun Basic Combos:");
                                        Console.WriteLine("1. DF+2 > F+3,4 > FF+2,3");
                                        Console.WriteLine("2. UF+4,3 > MI F > GU 4 > B+2,1,4");
                                        Console.WriteLine("3. DF+2 > B+4,2 > DF+1 > F+3,2,IO,1,1 > DASH B+2,1F,GU 2");
                                        Console.WriteLine("4. F+2 > 4 > B+4,2 > FF+2B,IO 1 > F+3+4,GU 4 > FF2F,GU 2");
                                        Console.WriteLine("5. DF+2 > DF+4 > DASH F+4 > B+2,1 > F+3,2,IO,F+1+2");
                                        repeatcharacter = false;
                                        repeatcode = false;
                                        break;

                                    case 3:
                                        Console.WriteLine("Salmon 3");
                                        repeatcode = false;
                                        repeatcharacter = false;
                                        break;

                                    default:
                                        Console.WriteLine("Please select the correct option.");
                                        break;
                                }
                            }
                            else
                            {
                                Console.WriteLine("Please select the correct number!");
                            }
                            break;
                        case "LEO":
                            Console.WriteLine("\nDifficulty: Intermediate");
                            Console.WriteLine("Leo, The Seeker of Truth, with their basic stances can provide strong punishments for blocked attacks and whiff attacks too.");
                            Console.WriteLine("\nWhat would you like to learn about Leo? \n1.Key Moves \n2.Basic Combos \n3.Strategy");
                            Console.WriteLine("\nInput: ");
                            if (Int32.TryParse(Console.ReadLine(), out tk8_option))
                            {
                                switch (tk8_option)
                                {
                                    case 1:
                                        Console.WriteLine("Leo key moves:");
                                        Console.WriteLine("1. Heng Da Bai Tui: F+2,3");
                                        Console.WriteLine("2. Jin Ji Du Li: F+4");
                                        Console.WriteLine("3. Shuang Huan Da: DF+1,2");
                                        Console.WriteLine("4. Sheng Pao: DF+2");
                                        Console.WriteLine("5. Chuan Pao: DF+3");
                                        Console.WriteLine("6. Swallow Step: QCF+3+4");
                                        Console.WriteLine("7. Gui Xi: DF+2+3");
                                        Console.WriteLine("8. Lei Zhang: QCF+1");
                                        Console.WriteLine("9. Lighting Spear: QCF+2,1");
                                        Console.WriteLine("10. Lighting Skypiercer: QCF+2,4");
                                        repeatcharacter = false;
                                        repeatcode = false;
                                        break;

                                    case 2:
                                        Console.WriteLine("Leo Basic Combos:");
                                        Console.WriteLine("1. DF+2 > UF+1,1 > DB+2,4");
                                        Console.WriteLine("2. FF+4,3 > F+4 > JJDL 3,4 > FF+2,1+2");
                                        Console.WriteLine("3. DF+2 > F+2 > B+1,1+2D > 1,2 > DASH B+1+2,1+2, QCF+2");
                                        Console.WriteLine("4. UF+2,1 > QCF+3 > B+1,1+2D > 1,2 > DASH B+1+2,1+2, QCF+2");
                                        Console.WriteLine("5. DB+3 > F+3 > F+2 > B+1,1+2D > 1,2 > DASH B+1+2,1+2, QCF+2");
                                        repeatcharacter = false;
                                        repeatcode = false;
                                        break;

                                    case 3:
                                        Console.WriteLine("Salmon 3");
                                        repeatcode = false;
                                        repeatcharacter = false;
                                        break;

                                    default:
                                        Console.WriteLine("Please select the correct option.");
                                        break;
                                }
                            }
                            else
                            {
                                Console.WriteLine("Please select the correct number!");
                            }
                            break;
                        case "LIDIA":
                            Console.WriteLine("\nDifficulty: Intermediate");
                            Console.WriteLine("Lidia, The Warrior Prime Minister, focuses on opponents mistakes and punishing them for it as well with counter hits.");
                            Console.WriteLine("\nWhat would you like to learn about Lidia? \n1.Key Moves \n2.Basic Combos \n3.Strategy");
                            Console.WriteLine("\nInput: ");
                            if (Int32.TryParse(Console.ReadLine(), out tk8_option))
                            {
                                switch (tk8_option)
                                {
                                    case 1:
                                        Console.WriteLine("Lidia key moves:");
                                        Console.WriteLine("1. Stalwart Governance: B+1");
                                        Console.WriteLine("2. Chop: D+1");
                                        Console.WriteLine("3. Mid Left Hook Thrust: DF+1,1");
                                        Console.WriteLine("4. Mid Left Hook Thrust to Mid Left Sidekick: DF+1,3");
                                        Console.WriteLine("5. Lightning Seikenzuki: FF+2");
                                        Console.WriteLine("6. Political Storm: F+1+2,3,1+2");
                                        Console.WriteLine("7. Iron Lady: B+1+2");
                                        Console.WriteLine("8. Adjourning Sweep: DB+3");
                                        Console.WriteLine("9. Shin Splinter: DB+4");
                                        Console.WriteLine("10. Lame Duck: D+2");
                                        repeatcharacter = false;
                                        repeatcode = false;
                                        break;

                                    case 2:
                                        Console.WriteLine("Lidia Basic Combos:");
                                        Console.WriteLine("1. FF+4 > DF+4,2 > 1+2");
                                        Console.WriteLine("2. UF+4 > CATF > WOLF 2 > B+2,3 > QCF+2,2+1+2");
                                        Console.WriteLine("3. UF+4 > CATB > FFF+2 > HRS 2 > QCF+2,2,1+2");
                                        Console.WriteLine("4. 3,2 > F+3+4 > HRSF > WOLF 2 > B+2,3 > QCF+1+2,2 > WOLFF > B+3,4,QCF1+2");
                                        Console.WriteLine("5. 3,2 > F+3+4 > HRSF > WOLF2 > B+2,3 > F+4,3,4 > DASH > F+3+4 > HRS3 > FF+4,3");
                                        repeatcharacter = false;
                                        repeatcode = false;
                                        break;

                                    case 3:
                                        Console.WriteLine("Salmon 3");
                                        repeatcode = false;
                                        repeatcharacter = false;
                                        break;

                                    default:
                                        Console.WriteLine("Please select the correct option.");
                                        break;
                                }
                            }
                            else
                            {
                                Console.WriteLine("Please select the correct number!");
                            }
                            break;
                        case "LAW":
                            Console.WriteLine("\nDifficulty: Intermediate");
                            Console.WriteLine("Law, The Legendary Dragon, focuses on mostly counter hits and rushdown playstle.");
                            Console.WriteLine("\nWhat would you like to learn about Law? \n1.Key Moves \n2.Basic Combos \n3.Strategy");
                            Console.WriteLine("\nInput: ");
                            if (Int32.TryParse(Console.ReadLine(), out tk8_option))
                            {
                                switch (tk8_option)
                                {
                                    case 1:
                                        Console.WriteLine("Law key moves:");
                                        Console.WriteLine("1. Shaolin Spin Kicks: 4,3");
                                        Console.WriteLine("2. Tornado Claw: 1+2");
                                        Console.WriteLine("3. Shin Crusher: DB+3");
                                        Console.WriteLine("4. Dragon Storm: B+1,2,2");
                                        Console.WriteLine("5. Body Blow to Dragon Lift: D+2,3");
                                        Console.WriteLine("6. Low Crush: SS+3");
                                        Console.WriteLine("7. Dragon Raise: DF+2");
                                        Console.WriteLine("8. Construct Kick: D+4,3");
                                        Console.WriteLine("9. Dragon's Fury: UF+3");
                                        Console.WriteLine("10. Dragon Hammer: F+1+2");
                                        repeatcharacter = false;
                                        repeatcode = false;
                                        break;

                                    case 2:
                                        Console.WriteLine("Law Basic Combos:");
                                        Console.WriteLine("1. UF+4,3 > FF+2,1,3");
                                        Console.WriteLine("2. DF+2 > B+2,1 > 3+4,4");
                                        Console.WriteLine("3. DF+2 4,U+3 > B+2 > B+2,1 > DASH > 4,3F > DC F+4");
                                        Console.WriteLine("4. UF+4 > UF+1 > 4,U+3 > B+2,1 > DASH 4,3F > DC F+4");
                                        Console.WriteLine("5. UF+4 > 4,U+3 > FF+4 > 2 > FF4 > DASH > 1+2 > DASH > 4,3F > DC F+4");
                                        repeatcharacter = false;
                                        repeatcode = false;
                                        break;

                                    case 3:
                                        Console.WriteLine("Salmon 3");
                                        repeatcode = false;
                                        repeatcharacter = false;
                                        break;

                                    default:
                                        Console.WriteLine("Please select the correct option.");
                                        break;
                                }
                            }
                            else
                            {
                                Console.WriteLine("Please select the correct number!");
                            }
                            break;
                        case "PAUL":
                            Console.WriteLine("\nDifficulty: Intermediate");
                            Console.WriteLine("Paul Pheonix, the Hot-Blooded Destoryer & Strongest in the world, is known for his high damage attacks along with his 50/50 attacks to trick the opponents.");
                            Console.WriteLine("\nWhat would you like to learn about Paul? \n1.Key Moves \n2.Basic Combos \n3.Strategy");
                            Console.WriteLine("\nInput: ");
                            if (Int32.TryParse(Console.ReadLine(), out tk8_option))
                            {
                                switch (tk8_option)
                                {
                                    case 1:
                                        Console.WriteLine("Paul key moves:");
                                        Console.WriteLine("1. Phoenix Smasher: QCF+2");
                                        Console.WriteLine("2. Demoman: D+4,2,1+2");
                                        Console.WriteLine("3. Moonfall: ");
                                        Console.WriteLine("4. Stone Lion: ");
                                        Console.WriteLine("5. Kawaragoma: ");
                                        Console.WriteLine("6. Lion Roar: ");
                                        Console.WriteLine("7. Gengetsu: ");
                                        Console.WriteLine("8. Kurenai: ");
                                        Console.WriteLine("9. Phoenix Bone Breaker: ");
                                        Console.WriteLine("10. Enfolding Dragon: ");
                                        repeatcharacter = false;
                                        repeatcode = false;
                                        break;

                                    case 2:
                                        Console.WriteLine("Paul Basic Combos:");
                                        Console.WriteLine("1. DF+2 > B+1,2 > F+4");
                                        Console.WriteLine("2. UF+3,4 > DF+1B > SWAY 1+2 > 1+2");
                                        Console.WriteLine("3. DF+2 > 4 > DF+4 > 3,2B > SWAY 1+2 > DASH D+4,2,1+2");
                                        Console.WriteLine("4. DF+2 > 1 > DF+4 > 2 > DASH 3,2B > SWAY 1+2 > DASH 2 > FFF+2");
                                        Console.WriteLine("5. B+3 > 3,2 > 3,2B > SWAY 1+2 > D+4,2,1+2");
                                        repeatcharacter = false;
                                        repeatcode = false;
                                        break;

                                    case 3:
                                        Console.WriteLine("Salmon 3");
                                        repeatcode = false;
                                        repeatcharacter = false;
                                        break;

                                    default:
                                        Console.WriteLine("Please select the correct option.");
                                        break;
                                }
                            }
                            else
                            {
                                Console.WriteLine("Please select the correct number!");
                            }
                            break;
                        case "RAVEN":
                            Console.WriteLine("\nDifficulty: Intermediate");
                            Console.WriteLine("Raven, the Shadow Agent, has good mobility with his ninja attacks along with 50/50 attacks and unique options for pressure");
                            Console.WriteLine("\nWhat would you like to learn about Raven? \n1.Key Moves \n2.Basic Combos \n3.Strategy");
                            Console.WriteLine("\nInput: ");
                            if (Int32.TryParse(Console.ReadLine(), out tk8_option))
                            {
                                switch (tk8_option)
                                {
                                    case 1:
                                        Console.WriteLine("Raven key moves:");
                                        Console.WriteLine("1. Jackknife Elbow: WR+2");
                                        Console.WriteLine("2. Utsusemi Escape/Sixth Sense: B+1+3/F+1+2");
                                        Console.WriteLine("3. Basilisk Fang: D+4");
                                        Console.WriteLine("4. Stinging Low: D+3");
                                        Console.WriteLine("5. Shinobi Cyclone: DB+4");
                                        Console.WriteLine("6. Tornado Destruction: FC DF+3+4");
                                        Console.WriteLine("7. Tartaros: F+2,3");
                                        Console.WriteLine("8. Shinobi Cyclone: LBR D+3");
                                        Console.WriteLine("9. Deadly Talon: LBR 2,2,1+2");
                                        Console.WriteLine("10. Vermillion: LBR FF+3+4");
                                        repeatcharacter = false;
                                        repeatcode = false;
                                        break;

                                    case 2:
                                        Console.WriteLine("Raven Basic Combos:");
                                        Console.WriteLine("1. DF+2,3 > B+2,4,2 > F+2,3");
                                        Console.WriteLine("2. FF+3 > DB+2,1 > B+2,3,2 > FF+4");
                                        Console.WriteLine("3. DF+2 > F+3 > FF4 > DB+2,1D > SZ 3,2 > DASH B+2,4,2");
                                        Console.WriteLine("4. UF+3 > DF+2,3 > DB+2,1D > SZ 3,2 > DASH LBR > 2,1,F+3");
                                        Console.WriteLine("5. UF+3+4 > D+3 > DB+2,1 > B+2,4,2 > DASH B+2,4,2");
                                        repeatcharacter = false;
                                        repeatcode = false;
                                        break;

                                    case 3:
                                        Console.WriteLine("Salmon 3");
                                        repeatcode = false;
                                        repeatcharacter = false;
                                        break;

                                    default:
                                        Console.WriteLine("Please select the correct option.");
                                        break;
                                }
                            }
                            else
                            {
                                Console.WriteLine("Please select the correct number!");
                            }
                            break;
                        case "VICTOR":
                            Console.WriteLine("\nDifficulty: Intermediate");
                            Console.WriteLine("Victor, Agent of Refined Violence, is known for his counter hit playstyle and punishing opponents for being too aggressive or impatient.\nAlso with his fresh suits inspired by John Wick.");
                            Console.WriteLine("\nWhat would you like to learn about Victor? \n1.Key Moves \n2.Basic Combos \n3.Strategy");
                            Console.WriteLine("\nInput: ");
                            if (Int32.TryParse(Console.ReadLine(), out tk8_option))
                            {
                                switch (tk8_option)
                                {
                                    case 1:
                                        Console.WriteLine("Victor key moves:");
                                        Console.WriteLine("1. Asterism of Virtue: FFF+2");
                                        Console.WriteLine("2. Shangri-La: FC+1+2");
                                        Console.WriteLine("3. Failnaught: B+1+2");
                                        Console.WriteLine("4. Llawfrodedd: D+2");
                                        Console.WriteLine("5. Baguette Cut: WR+2");
                                        Console.WriteLine("6. Pearly Gates: WR+1+2");
                                        Console.WriteLine("7. Welcome Sweep: DB+4");
                                        Console.WriteLine("8. Fine Salute: D+4");
                                        Console.WriteLine("9. Eden: 1+2");
                                        Console.WriteLine("10. Durandal: F+1+2");
                                        repeatcharacter = false;
                                        repeatcode = false;
                                        break;

                                    case 2:
                                        Console.WriteLine("Victor Basic Combos:");
                                        Console.WriteLine("1. DF+2 > UF+1,1 > B+3,1");
                                        Console.WriteLine("2. DF+2 > DF+4,2 > IS+2 > 2,1F > PR+22 > IS+1,2,2");
                                        Console.WriteLine("3. DF+2 > DF+4,2 > IS+2 > DFWR+2 > DB+1,1F > PR+2,2 > IS+1,2,2");
                                        Console.WriteLine("4. DF+2 > DF+3,4 > 2,1F > PR+2,2,1 > FF+2 > DASH QCF+2 > IS+1,2,2");
                                        Console.WriteLine("5. FF+2 > DF+3,4 > DF+1+2F > PR+2,2,1 > FF+2 > DASHQCF+2 > IS+1,2,2");
                                        repeatcharacter = false;
                                        repeatcode = false;
                                        break;

                                    case 3:
                                        Console.WriteLine("Salmon 3");
                                        repeatcode = false;
                                        repeatcharacter = false;
                                        break;

                                    default:
                                        Console.WriteLine("Please select the correct option.");
                                        break;
                                }
                            }
                            else
                            {
                                Console.WriteLine("Please select the correct number!");
                            }
                            break;
                        case "ZAFINA":
                            Console.WriteLine("\nDifficulty: Intermediate");
                            Console.WriteLine("Zafina, the Mystic Stargazer, has a strong poking game and stong stances that can applying heavy pressure.");
                            Console.WriteLine("\nWhat would you like to learn about Zafina? \n1.Key Moves \n2.Basic Combos \n3.Strategy");
                            Console.WriteLine("\nInput: ");
                            if (Int32.TryParse(Console.ReadLine(), out tk8_option))
                            {
                                switch (tk8_option)
                                {
                                    case 1:
                                        Console.WriteLine("Zafina key moves:");
                                        Console.WriteLine("1. Left Right Combo: 1,2");
                                        Console.WriteLine("2. Anzu: 1,3");
                                        Console.WriteLine("3. Ecdysis: 1,4");
                                        Console.WriteLine("4. Bloody Saif - Execution: DF+1,2");
                                        Console.WriteLine("5. Ningishzida: D+1,1");
                                        Console.WriteLine("6. Earwig Pincer: D+3");
                                        Console.WriteLine("7. Acinaces: DB+3");
                                        Console.WriteLine("8. Iskur: D+4,3");
                                        Console.WriteLine("9. Euphrates Cannon: DB+4");
                                        Console.WriteLine("10. Kur: DB+1+2");
                                        repeatcharacter = false;
                                        repeatcode = false;
                                        break;

                                    case 2:
                                        Console.WriteLine("Zafina Basic Combos:");
                                        Console.WriteLine("1. DF+2 > DF+4,2 > F+2,3,4");
                                        Console.WriteLine("2. DF+2 > UF+1 > DF+1 > F+2,3 > SC DF+1 > DASH B+1,1+2");
                                        Console.WriteLine("3. DF+2 > UF+1 > DF+1 > F+2,3 > SC 4 > DASH 2,1,3");
                                        Console.WriteLine("4. DF+2 > FF+2 > DF+1 > F+2,3 > SC 4 > DASH UF+1 > B+1,1+2");
                                        Console.WriteLine("5. DF+2 > FF+2 > DF+1 > DASH DF+1 > F+2,3 > SC DF+1 > FFF+1+2 > TS DF+1");
                                        repeatcharacter = false;
                                        repeatcode = false;
                                        break;

                                    case 3:
                                        Console.WriteLine("Salmon 3");
                                        repeatcode = false;
                                        repeatcharacter = false;
                                        break;

                                    default:
                                        Console.WriteLine("Please select the correct option.");
                                        break;
                                }
                            }
                            else
                            {
                                Console.WriteLine("Please select the correct number!");
                            }
                            break;

                        //Advanced to learn
                        case "BYRAN":
                            Console.WriteLine("\nDifficulty: Advanced");
                            Console.WriteLine("Bryan Fury, The Harbinger of Chaos, has strong defense, high execution, and slow methodical playstyle plus taunt jet upper combos.");
                            Console.WriteLine("\nWhat would you like to learn about Byran? \n1.Key Moves \n2.Basic Combos \n3.Strategy");
                            Console.WriteLine("\nInput: ");
                            if (Int32.TryParse(Console.ReadLine(), out tk8_option))
                            {
                                switch (tk8_option)
                                {
                                    case 1:
                                        Console.WriteLine("Byran key moves:");
                                        Console.WriteLine("1. Cannonball Straight: QCB+1");
                                        Console.WriteLine("2. Knee Strike: F+3");
                                        Console.WriteLine("3. Orbital Heel Kick: UF+4");
                                        Console.WriteLine("4. Hatchet Kick: QCB+3");
                                        Console.WriteLine("5. Chopping Elbow: B+1");
                                        Console.WriteLine("6. Middle Side Kick: 3+4");
                                        Console.WriteLine("7. Mach Kick: FF+4");
                                        Console.WriteLine("8. Smash and Mach Kick: QCB+2,4");
                                        Console.WriteLine("9. High Knee Kick: WR+3");
                                        Console.WriteLine("10. Mach Breaker: FF+2");
                                        repeatcharacter = false;
                                        repeatcode = false;
                                        break;

                                    case 2:
                                        Console.WriteLine("Byran Basic Combos:");
                                        Console.WriteLine("1. UF+4 > D+3+4,2 > FF+2");
                                        Console.WriteLine("2. DF+3 > UF+3 > 3,3,4 ");
                                        Console.WriteLine("3. FB+2 > DASH > QCF+3,4 > B+2,4 > DASH > F+3+4 > B+2,1F > SSP 2,2");
                                        Console.WriteLine("4. UF+4 > 1+2,1 > 1 > B+2,1F > SSP 2,4 > DASH > B+3F > SSP 2,2");
                                        Console.WriteLine("5. DF+3 > DASH > 1+2,1 > 2 > B+2,1F > SSP 2,2");
                                        repeatcharacter = false;
                                        repeatcode = false;
                                        break;

                                    case 3:
                                        Console.WriteLine("Salmon 3");
                                        repeatcode = false;
                                        repeatcharacter = false;
                                        break;

                                    default:
                                        Console.WriteLine("Please select the correct option.");
                                        break;
                                }
                            }
                            else
                            {
                                Console.WriteLine("Please select the correct number!");
                            }
                            break;
                        case "JIN":
                            Console.WriteLine("\nDifficulty: Advanced");
                            Console.WriteLine("Jin Kazama, The Lighting of Fate, has a well rounded playstyle along with good mobility with wavedashing and good poking, counter hitting, and poking games.");
                            Console.WriteLine("\nWhat would you like to learn about Jin? \n1.Key Moves \n2.Basic Combos \n3.Strategy");
                            Console.WriteLine("\nInput: ");
                            if (Int32.TryParse(Console.ReadLine(), out tk8_option))
                            {
                                switch (tk8_option)
                                {
                                    case 1:
                                        Console.WriteLine("Jin key moves:");
                                        Console.WriteLine("1. Wind Hook Fist: FDDF+2");
                                        Console.WriteLine("2. Shun Masatsu: B+2");
                                        Console.WriteLine("3. Demon's Paw: FF+2");
                                        Console.WriteLine("4. Battery Heel: FF+4");
                                        Console.WriteLine("5. Front Thrust Kick: F+4");
                                        Console.WriteLine("6. Right Sweep: D+4");
                                        Console.WriteLine("7. Right Spinning Axe Kick: DF+4");
                                        Console.WriteLine("8. Left Axe Kick: FF+3");
                                        Console.WriteLine("9. Tanden Nidan-uchi: F+3,1");
                                        Console.WriteLine("10. Shun Masatsu: B+2,1");
                                        repeatcharacter = false;
                                        repeatcode = false;
                                        break;

                                    case 2:
                                        Console.WriteLine("Jin Basic Combos:");
                                        Console.WriteLine("1. UF+4 > B+1,2 > DB+2,2,3");
                                        Console.WriteLine("2. FF+3 > B+3F > ZN U+1 > DB+2,2,3");
                                        Console.WriteLine("3. UF+4 > DF+2,4 > 3,1F > ZEN 2 > B+3F > ZEN U+1 > F+3+4 > ZEN 1,3");
                                        Console.WriteLine("4. UF+4 > B+3 > 3,1,F+2 > DF+2,3 > B+3F > U+1 > B+3,2");
                                        Console.WriteLine("5. FF+3 > BSTP+2 > B+3,F+1 > BF+2,3F > U+1 > DASH 2,4F > ZEN+4");
                                        repeatcharacter = false;
                                        repeatcode = false;
                                        break;

                                    case 3:
                                        Console.WriteLine("Salmon 3");
                                        repeatcode = false;
                                        repeatcharacter = false;
                                        break;

                                    default:
                                        Console.WriteLine("Please select the correct option.");
                                        break;
                                }
                            }
                            else
                            {
                                Console.WriteLine("Please select the correct number!");
                            }
                            break;
                        case "KAZUYA":
                            Console.WriteLine("\nDifficulty: Advanced");
                            Console.WriteLine("Kazuya Mishima, The Cold-Blooded Oppressor, has a strong mixup playstyle along with mobility with wavedashing and hell sweep stance and is a high execution based character.");
                            Console.WriteLine("\nWhat would you like to learn about Kazuya? \n1.Key Moves \n2.Basic Combos \n3.Strategy");
                            Console.WriteLine("\nInput: ");
                            if (Int32.TryParse(Console.ReadLine(), out tk8_option))
                            {
                                switch (tk8_option)
                                {
                                    case 1:
                                        Console.WriteLine("Kazuya key moves:");
                                        Console.WriteLine("1. Wind God Fist: FDDF+2");
                                        Console.WriteLine("2. Abolishing Fist: DF+2");
                                        Console.WriteLine("3. Slaughter Hook/Slaughter High Kick: DF+1,2/DF+1,4");
                                        Console.WriteLine("4. Left Splits Kick: FF+3");
                                        Console.WriteLine("5. Parricide Fist: FDDF+1+2");
                                        Console.WriteLine("6. Goutsuiken: DB+1,2");
                                        Console.WriteLine("7. Right Splits Kick: F+4");
                                        Console.WriteLine("8. Flash Tornado: B+4");
                                        Console.WriteLine("9. Nejiri Uraken: D+1+2");
                                        Console.WriteLine("10. Stature Smash: DB+4");
                                        repeatcharacter = false;
                                        repeatcode = false;
                                        break;

                                    case 2:
                                        Console.WriteLine("Kazuya Basic Combos:");
                                        Console.WriteLine("1. FF+3 > DF+1,DF+2 > FF+2");
                                        Console.WriteLine("2. WGS+2 > F+2 > B+2,2,1+2");
                                        Console.WriteLine("3. FF+3 > 3,1,4 > DF+1,DF+2 > DASH 3,1DF > WGS 3");
                                        Console.WriteLine("4. FF+3 > SSR 3 > B+2,2 > DF+1,DF+2 > DASH 3,1DF > WGS 3");
                                        Console.WriteLine("5. WR+1,2 > DASH DF+1+2 > B+2,2 > B+2,2,1+2");
                                        repeatcharacter = false;
                                        repeatcode = false;
                                        break;

                                    case 3:
                                        Console.WriteLine("Salmon 3");
                                        repeatcode = false;
                                        repeatcharacter = false;
                                        break;

                                    default:
                                        Console.WriteLine("Please select the correct option.");
                                        break;
                                }
                            }
                            else
                            {
                                Console.WriteLine("Please select the correct number!");
                            }
                            break;
                        case "REINA":
                            Console.WriteLine("\nDifficulty: Advanced");
                            Console.WriteLine("Reina, The Purple Lighting, most like the other mishima characters has greay mobility with wavedashing along with strong poking and stance mixups with her own unique twist.");
                            Console.WriteLine("\nWhat would you like to learn about Reina? \n1.Key Moves \n2.Basic Combos \n3.Strategy");
                            Console.WriteLine("\nInput: ");
                            if (Int32.TryParse(Console.ReadLine(), out tk8_option))
                            {
                                switch (tk8_option)
                                {
                                    case 1:
                                        Console.WriteLine("Reina key moves:");
                                        Console.WriteLine("1. Flash Punch Combo: 1,1,2");
                                        Console.WriteLine("2. Muso Tensho: DF+1,1");
                                        Console.WriteLine("3. Kamadhatu Splits Kick: F+4");
                                        Console.WriteLine("4. Muso Basara: DF+1,2");
                                        Console.WriteLine("5. Sin Smiter: B+2");
                                        Console.WriteLine("6. Eisaimon: DB+2");
                                        Console.WriteLine("7. Ten Chuten-geri: FFF+3");
                                        Console.WriteLine("8. Un Tobi Kaijo-geri: FFF+4");
                                        Console.WriteLine("9. Wind God Fist: DF+3,2");
                                        Console.WriteLine("10. Stonehead: UF+1+2");
                                        repeatcharacter = false;
                                        repeatcode = false;
                                        break;

                                    case 2:
                                        Console.WriteLine("Reina Basic Combos:");
                                        Console.WriteLine("1. UF+4 > 2,2,2,2");
                                        Console.WriteLine("2. DF+3 > 2 > 3,2 > 2,2,2,2");
                                        Console.WriteLine("3. DF+2 > DF+2 > DF+1,1 > F+2,3F > SI 1+2 > HW 3,4");
                                        Console.WriteLine("4. DF+2 > B+2 > FF+3+4 > DF+1,1 > F+2,3F > DF+1F > SI 1,QCF+2");
                                        Console.WriteLine("5. UF+4 > FF+3+4 > DF+1,1 > F+2,3F > DF+1F > SI 1,QCF+2");
                                        repeatcharacter = false;
                                        repeatcode = false;
                                        break;

                                    case 3:
                                        Console.WriteLine("Salmon 3");
                                        repeatcode = false;
                                        repeatcharacter = false;
                                        break;

                                    default:
                                        Console.WriteLine("Please select the correct option.");
                                        break;
                                }
                            }
                            else
                            {
                                Console.WriteLine("Please select the correct number!");
                            }
                            break;
                        case "HEIHACHI":
                            Console.WriteLine("\nDifficulty: Advanced");
                            Console.WriteLine("Heihachi Mishima, The Resurrected King of Iron Fist, has high damage with his attacks and combos along with mixups from his hell sweep stance.");
                            Console.WriteLine("\nWhat would you like to learn about Heihachi? \n1.Key Moves \n2.Basic Combos \n3.Strategy");
                            Console.WriteLine("\nInput: ");
                            if (Int32.TryParse(Console.ReadLine(), out tk8_option))
                            {
                                switch (tk8_option)
                                {
                                    case 1:
                                        Console.WriteLine("Heihachi key moves:");
                                        Console.WriteLine("1. Right Splits Kick: F+4");
                                        Console.WriteLine("2. Wind God Fist: FDDF+2");
                                        Console.WriteLine("3. Demon God Fist: FF+2");
                                        Console.WriteLine("4. Left Splits Kick: FF+3");
                                        Console.WriteLine("5. Lightning Crush: F+3");
                                        Console.WriteLine("6. Iron Hand: QCF+2");
                                        Console.WriteLine("7. Hell Axle: UF+3,4");
                                        Console.WriteLine("8. Wind Slicer: UF+4");
                                        Console.WriteLine("9. Bone Splinter Kick: FDDF+3");
                                        Console.WriteLine("10. Indra's Kick: B+4");
                                        repeatcharacter = false;
                                        repeatcode = false;
                                        break;

                                    case 2:
                                        Console.WriteLine("Heihachi Basic Combos:");
                                        Console.WriteLine("1. FF+3 > 4 > UF+1");
                                        Console.WriteLine("2. FDDF+2 > F+3 > B+1,4 > FDDF+4,4,3");
                                        Console.WriteLine("3. FF+3 > FDDF+2 > F+3 > B+1,4 > UF+3,4 > UF+2,1");
                                        Console.WriteLine("4. UF+3,4 > F+3D > WGK DF+4,4,3 > F+3D > WGK 2 > DASH > B+2 HOLD > QCF+2");
                                        Console.WriteLine("5. CR DF+2 > F+3 > DF+1 > F+3D > WGK 2 > UF+3,4 > UF+2,1");
                                        repeatcharacter = false;
                                        repeatcode = false;
                                        break;

                                    case 3:
                                        Console.WriteLine("Salmon 3");
                                        repeatcode = false;
                                        repeatcharacter = false;
                                        break;

                                    default:
                                        Console.WriteLine("Please select the correct option.");
                                        break;
                                }
                            }
                            else
                            {
                                Console.WriteLine("Please select the correct number!");
                            }
                            break;
                        case "LEE":
                            Console.WriteLine("\nDifficulty: Advanced");
                            Console.WriteLine("Lee Chaolan, The Silver Haired-Demon, has a strong counter hitting game where he thrives in the mistakes the opponents make, amazing wall carry, and flashy combos.");
                            Console.WriteLine("\nWhat would you like to learn about Lee? \n1.Key Moves \n2.Basic Combos \n3.Strategy");
                            Console.WriteLine("\nInput: ");
                            if (Int32.TryParse(Console.ReadLine(), out tk8_option))
                            {
                                switch (tk8_option)
                                {
                                    case 1:
                                        Console.WriteLine("Lee key moves:");
                                        Console.WriteLine("1. Silver Heel: B+4");
                                        Console.WriteLine("2. Silver Uppercut: DF+2");
                                        Console.WriteLine("3. Pulse Blast: FF+3");
                                        Console.WriteLine("4. Silver Low: D+3");
                                        Console.WriteLine("5. Deadly Edge: FF+4");
                                        Console.WriteLine("6. Right Cross to Revolution Zwei: 2,2,3");
                                        Console.WriteLine("7. Fabulous Whip: DF+4,4");
                                        Console.WriteLine("8. Gut Polisher: D+2");
                                        Console.WriteLine("9. Spin Kick Somersault Combo: 4,3,4");
                                        Console.WriteLine("10. Jostle Wolf: FF+1");
                                        repeatcharacter = false;
                                        repeatcode = false;
                                        break;

                                    case 2:
                                        Console.WriteLine("Lee Basic Combos:");
                                        Console.WriteLine("1. UF+4 > F+4,1 > FF+3");
                                        Console.WriteLine("2. DF+2 > D,U+3 > B+2F > F+4,1 > FF+3");
                                        Console.WriteLine("3. DF+2 > B+2,4,3 > F+4,1 > DASH DF+3,2,3");
                                        Console.WriteLine("4. DF+2 > 4,U+3 > B2F > F+4,1 > DASH B+1,1+2");
                                        Console.WriteLine("5. DF+2 > B+2,4,3 > B+2F > F+4,1 > DASH DF+3,2,3");
                                        repeatcharacter = false;
                                        repeatcode = false;
                                        break;

                                    case 3:
                                        Console.WriteLine("Salmon 3");
                                        repeatcode = false;
                                        repeatcharacter = false;
                                        break;

                                    default:
                                        Console.WriteLine("Please select the correct option.");
                                        break;
                                }
                            }
                            else
                            {
                                Console.WriteLine("Please select the correct number!");
                            }
                            break;
                        case "DVJ":
                            Console.WriteLine("\nDifficulty: Advanced");
                            Console.WriteLine("Devil Jin, The Black Wings Of Ruin, has good space control along with mobility with his wings.");
                            Console.WriteLine("\nWhat would you like to learn about Devil Jin? \n1.Key Moves \n2.Basic Combos \n3.Strategy");
                            Console.WriteLine("\nInput: ");
                            if (Int32.TryParse(Console.ReadLine(), out tk8_option))
                            {
                                switch (tk8_option)
                                {
                                    case 1:
                                        Console.WriteLine("Devil Jin key moves:");
                                        Console.WriteLine("1. Wind God Fist: FDDF+2");
                                        Console.WriteLine("2. Wraith Kick: UF+4");
                                        Console.WriteLine("3. Reaper's Scythe: UF+3");
                                        Console.WriteLine("4. Double Lift Kick: D+3+4");
                                        Console.WriteLine("5. Broken Plate: D+3");
                                        Console.WriteLine("6. Malicious Mace: DB+2");
                                        Console.WriteLine("7. Spinning Demon Hellfire Beam: FDDF+4,1+2");
                                        Console.WriteLine("8. Bloody Glaive: DF+2");
                                        Console.WriteLine("9. Demon's Paw: FF+2");
                                        Console.WriteLine("10. Organ Wrecker: WR+3");
                                        repeatcharacter = false;
                                        repeatcode = false;
                                        break;

                                    case 2:
                                        Console.WriteLine("Devil Jin Basic Combos:");
                                        Console.WriteLine("1. D+3+4 > 3,1,2 > UF+1 > MC+4,2,1U");
                                        Console.WriteLine("2. D+3+4 > 3,1,2 > UF+1 > MC+4,2,1+2");
                                        Console.WriteLine("3. D+3+4 > B+2,1 > DASH > U+1+2 > UF+1 > MC+4,2,1+2");
                                        Console.WriteLine("4. U+4U > FLY+4 > B+2,1 > UF+1 > MC+4,2,1+2");
                                        Console.WriteLine("5. WS+2 > DASH > U+1+2 > 3,1 > BF+2,1,2");
                                        repeatcharacter = false;
                                        repeatcode = false;
                                        break;

                                    case 3:
                                        Console.WriteLine("Salmon 3");
                                        repeatcode = false;
                                        repeatcharacter = false;
                                        break;

                                    default:
                                        Console.WriteLine("Please select the correct option.");
                                        break;
                                }
                            }
                            else
                            {
                                Console.WriteLine("Please select the correct number!");
                            }
                            break;
                        case "HWOARANG":
                            Console.WriteLine("\nDifficulty: Advanced");
                            Console.WriteLine("Hwoarang, The Blood Talon, has flexible and creative offensive tools and attacks with his stances along with overwhelming rushdown as well.");
                            Console.WriteLine("\nWhat would you like to learn about Hwoarang? \n1.Key Moves \n2.Basic Combos \n3.Strategy");
                            Console.WriteLine("\nInput: ");
                            if (Int32.TryParse(Console.ReadLine(), out tk8_option))
                            {
                                switch (tk8_option)
                                {
                                    case 1:
                                        Console.WriteLine("Hwoarang key moves:");
                                        Console.WriteLine("1. Left Plasman Blade: B+3");
                                        Console.WriteLine("2. Nose Bleeder: B+4");
                                        Console.WriteLine("3. Ankle Biter: DB+4,4");
                                        Console.WriteLine("4. Right Hook Kick: F+4");
                                        Console.WriteLine("5. Double Claymore: DF+3,4");
                                        Console.WriteLine("6. Shark Step: QCF");
                                        Console.WriteLine("7. Right Stance: 3+4");
                                        Console.WriteLine("8. Left Flamingo: F+3");
                                        Console.WriteLine("9. Hunting Hawk: UF+3,4,3");
                                        Console.WriteLine("10. Air Raid: UF+4,4,4");
                                        repeatcharacter = false;
                                        repeatcode = false;
                                        break;

                                    case 2:
                                        Console.WriteLine("Hwoarang Basic Combos:");
                                        Console.WriteLine("1. DF+2 > U+3 > LF 2 > RS 3 > D+4,4 > DASH UF+3,4,3");
                                        Console.WriteLine("2. DF+2 > U+3 > LF 1 > U+3 > UF+3+4F > UF+4 > FF+3+4 > RS F+3 > LF 4,3");
                                        Console.WriteLine("3. DF+2 > F+4 > RF 3,4 > D+4,4 > DASH UF+3,4,3");
                                        Console.WriteLine("4. DF+2 > F+4 > 3,4 > UF+3+4F > LF UF+4 > F+3+4 > RS 3,4 > DASH UB+3");
                                        Console.WriteLine("5. B+3 > F+4 > B+3 > DASH 2,4 > 2,3 > DASH 3+4 > F+3 > 4,3");
                                        repeatcharacter = false;
                                        repeatcode = false;
                                        break;

                                    case 3:
                                        Console.WriteLine("Salmon 3");
                                        repeatcode = false;
                                        repeatcharacter = false;
                                        break;

                                    default:
                                        Console.WriteLine("Please select the correct option.");
                                        break;
                                }
                            }
                            else
                            {
                                Console.WriteLine("Please select the correct number!");
                            }
                            break;
                        case "KING":
                            Console.WriteLine("\nDifficulty: Advanced");
                            Console.WriteLine("King, The Anger of the Beast, has a excellent throw game that can overwhelm opponents along with being unorthodox with throw mixups and pressure");
                            Console.WriteLine("\nWhat would you like to learn about King? \n1.Key Moves \n2.Basic Combos \n3.Strategy");
                            Console.WriteLine("\nInput: ");
                            if (Int32.TryParse(Console.ReadLine(), out tk8_option))
                            {
                                switch (tk8_option)
                                {
                                    case 1:
                                        Console.WriteLine("King key moves:");
                                        Console.WriteLine("1. Lay Off: FF+1+2");
                                        Console.WriteLine("2. Jaguar Hook: FF+1");
                                        Console.WriteLine("3. Rolling Sobat: F+4");
                                        Console.WriteLine("4. Beast Elbow: FF+2");
                                        Console.WriteLine("5. Guillotine Drop: B+3,1+2");
                                        Console.WriteLine("6. Brain Chop: DB+2");
                                        Console.WriteLine("7. Front Kick to DDT: F+3,1+2");
                                        Console.WriteLine("8. Stomp: D+3");
                                        Console.WriteLine("9. Crouching Low Kick: DB+3");
                                        Console.WriteLine("10. Elbow Sting: DF+1,2");
                                        repeatcharacter = false;
                                        repeatcode = false;
                                        break;

                                    case 2:
                                        Console.WriteLine("King Basic Combos:");
                                        Console.WriteLine("1. UF+4 > 2+4 > F+2,1");
                                        Console.WriteLine("2. DB+2 > DF+4,3 > 2 > B+1,2 > FFF+2+4");
                                        Console.WriteLine("3. UF+4 > F+3 > DF+4,3 > B+1,2 > FFF+1+2");
                                        Console.WriteLine("4. D+1+2 > 4 > F+1+2 > DF+4,3 > B+1,2 > FFF+2+4");
                                        Console.WriteLine("5. UF+4 > 4 > DASH DF+4,3 > 1,2 > UF+3+4F > FFF+2+4");
                                        repeatcharacter = false;
                                        repeatcode = false;
                                        break;

                                    case 3:
                                        Console.WriteLine("Salmon 3");
                                        repeatcode = false;
                                        repeatcharacter = false;
                                        break;

                                    default:
                                        Console.WriteLine("Please select the correct option.");
                                        break;
                                }
                            }
                            else
                            {
                                Console.WriteLine("Please select the correct number!");
                            }
                            break;
                        case "XIAOYU":
                            Console.WriteLine("\nDifficulty: Advanced");
                            Console.WriteLine("Ling Xiaoyu, The Dancing Pheonix, is a stance heavy character that has strong poking tools and a lot of creativity with applying pressure.");
                            Console.WriteLine("\nWhat would you like to learn about Xiaoyu? \n1.Key Moves \n2.Basic Combos \n3.Strategy");
                            Console.WriteLine("\nInput: ");
                            if (Int32.TryParse(Console.ReadLine(), out tk8_option))
                            {
                                switch (tk8_option)
                                {
                                    case 1:
                                        Console.WriteLine("Xiaoyu key moves:");
                                        Console.WriteLine("1. Storming Flower: DB+1");
                                        Console.WriteLine("2. Seven Star Fist: B+2,2");
                                        Console.WriteLine("3. Bolting Rabbit: UF+3");
                                        Console.WriteLine("4. Cloud Kick: 3");
                                        Console.WriteLine("5. Moon Swallow: DB+2,3");
                                        Console.WriteLine("6. Phoenix Tail: DB+3");
                                        Console.WriteLine("7. Nutcracker: DB+4");
                                        Console.WriteLine("8. Peacock Kick: B+3");
                                        Console.WriteLine("9. Moonhare Palm: B+4,1");
                                        Console.WriteLine("10. From the Ashes: UB+3");
                                        repeatcharacter = false;
                                        repeatcode = false;
                                        break;

                                    case 2:
                                        Console.WriteLine("Xiaoyu Basic Combos:");
                                        Console.WriteLine("1. B+1+2 > F+3,2,4 > DB+1");
                                        Console.WriteLine("2. UF+3 > DF+2 > F+3,1 > RD 1,2 > FFF+3 > PX 1+2");
                                        Console.WriteLine("3. 3 > FF+3 > RD DF+4 > F+3,1,4 > DASH DF+2,3");
                                        Console.WriteLine("4. UF+3 > PX 1 > WR+2 > RD 1,2 > FFF+3 > PX 1+2");
                                        Console.WriteLine("5. B+1+2 > DB+2 > RD 1,2 > B+2 > RD 2,2 > 4");
                                        repeatcharacter = false;
                                        repeatcode = false;
                                        break;

                                    case 3:
                                        Console.WriteLine("Salmon 3");
                                        repeatcode = false;
                                        repeatcharacter = false;
                                        break;

                                    default:
                                        Console.WriteLine("Please select the correct option.");
                                        break;
                                }
                            }
                            else
                            {
                                Console.WriteLine("Please select the correct number!");
                            }
                            break;
                        case "NINA":
                            Console.WriteLine("\nDifficulty: Advanced");
                            Console.WriteLine("Nina Williams, The Silent Assassin, has insane rushdown methods along with being a execution character with her combos to her throws as well.");
                            Console.WriteLine("\nWhat would you like to learn about Nina? \n1.Key Moves \n2.Basic Combos \n3.Strategy");
                            Console.WriteLine("\nInput: ");
                            if (Int32.TryParse(Console.ReadLine(), out tk8_option))
                            {
                                switch (tk8_option)
                                {
                                    case 1:
                                        Console.WriteLine("Nina key moves:");
                                        Console.WriteLine("1. Biting Kiss Shot: 1,2,1,1+2");
                                        Console.WriteLine("2. Uppercut to Jab: DF+1,2");
                                        Console.WriteLine("3. Creeping Snake to Right High Kick: DF+3,2,4");
                                        Console.WriteLine("4. Creeping Snake to Geyser Cannon: DF+3,2,3");
                                        Console.WriteLine("5. Blonde Bomb: F+1+2");
                                        Console.WriteLine("6. Wipe the Floor: DF+4");
                                        Console.WriteLine("7. Siren's Kiss: F+3");
                                        Console.WriteLine("8. Head Ringer: 3,4");
                                        Console.WriteLine("9. Double Whip: F+4,4");
                                        Console.WriteLine("10. Hellbringer: QCF+1");
                                        repeatcharacter = false;
                                        repeatcode = false;
                                        break;

                                    case 2:
                                        Console.WriteLine("Nina Basic Combos:");
                                        Console.WriteLine("1. DF+2 > B+1,4 > F+1+2");
                                        Console.WriteLine("2. DF+2 > UF+4 > DF+3,2 > B+3+4,4 > DS 4,2,1+2");
                                        Console.WriteLine("3. DF+2 > UF+4 > UF+3 > DF+3,2 > B+3+4,3 > DS 4,3,1+2");
                                        Console.WriteLine("4. DF+2 > UF+4 > UF+3 > DF+3,2F > DF 1 > B+1+4 > DASH UF+4 > F+1+2");
                                        Console.WriteLine("5. DF+2 > UF+4 > UF+3 > DF+3,2B > SWAY DB+2 > F+2,1,3 > DASH DS 4,3,1+2");
                                        repeatcharacter = false;
                                        repeatcode = false;
                                        break;

                                    case 3:
                                        Console.WriteLine("Salmon 3");
                                        repeatcode = false;
                                        repeatcharacter = false;
                                        break;

                                    default:
                                        Console.WriteLine("Please select the correct option.");
                                        break;
                                }
                            }
                            else
                            {
                                Console.WriteLine("Please select the correct number!");
                            }
                            break;
                        case "STEVE":
                            Console.WriteLine("\nDifficulty: Advanced");
                            Console.WriteLine("Steve Fox, The Counter-Punching Paragon, thrives when an opponent makes a mistake with his excellent counter hitting offense and along with confusing opponents with his many stances.");
                            Console.WriteLine("\nWhat would you like to learn about Steve? \n1.Key Moves \n2.Basic Combos \n3.Strategy");
                            Console.WriteLine("\nInput: ");
                            if (Int32.TryParse(Console.ReadLine(), out tk8_option))
                            {
                                switch (tk8_option)
                                {
                                    case 1:
                                        Console.WriteLine("Steve key moves:");
                                        Console.WriteLine("1. Quick Hook: B+1");
                                        Console.WriteLine("2. Crescent Hook: DF+2");
                                        Console.WriteLine("3. Swaying Hook: FS B+2");
                                        Console.WriteLine("4. Dreadnought Uppercut: U+2");
                                        Console.WriteLine("5. Fly Swatter: FS 2");
                                        Console.WriteLine("6. Eraser: FFF+2");
                                        Console.WriteLine("7. Knee Blaster: D+1");
                                        Console.WriteLine("8. Patella Smash: PB D+1");
                                        Console.WriteLine("9. Bounty Hunter: UB+2");
                                        Console.WriteLine("10. Foot Stomp Right Hook: DB+3,2");
                                        repeatcharacter = false;
                                        repeatcode = false;
                                        break;

                                    case 2:
                                        Console.WriteLine("Steve Basic Combos:");
                                        Console.WriteLine("1. UF+2 > DI 1 > DF+1,2,1B > FS 1,2 > DASH DL 1,2 > LH 2");
                                        Console.WriteLine("2. UF+2 > F+3,1 > DF+1,2,1B > F+3DB+1 > F+2,2 > 2 > DASH 3,1,2 > 2");
                                        Console.WriteLine("3. DI 2 > DB+2 > F+3,1 > DF+1,2,1 > F+2,2 > 2 > DASH 3,1,2 > 2");
                                        Console.WriteLine("4. DI 2 > DI 2 > F+3,1 > DF+2,F+3,DB+1 > F+2,2 > 2 > DASH 3,1,2 > 2");
                                        Console.WriteLine("5. DI 2 > DI 2 > DF+2,2,1F > 1,2 > DASH 3,1,2 > 2");
                                        repeatcharacter = false;
                                        repeatcode = false;
                                        break;

                                    case 3:
                                        Console.WriteLine("Salmon 3");
                                        repeatcode = false;
                                        repeatcharacter = false;
                                        break;

                                    default:
                                        Console.WriteLine("Please select the correct option.");
                                        break;
                                }
                            }
                            else
                            {
                                Console.WriteLine("Please select the correct number!");
                            }
                            break;
                        case "YOSHIMITSU":
                            Console.WriteLine("\nDifficulty: Advanced");
                            Console.WriteLine("Yoshimitsu, The Mechanized Space Ninja, has an unorthodox and creative offensive with his many stances and unblockable moves.");
                            Console.WriteLine("\nWhat would you like to learn about Yoshimitsu? \n1.Key Moves \n2.Basic Combos \n3.Strategy");
                            Console.WriteLine("\nInput: ");
                            if (Int32.TryParse(Console.ReadLine(), out tk8_option))
                            {
                                switch (tk8_option)
                                {
                                    case 1:
                                        Console.WriteLine("Yoshimitsu key moves:");
                                        Console.WriteLine("1. Rising Knee: UF+3");
                                        Console.WriteLine("2. Basic Uppercut: DF+2");
                                        Console.WriteLine("3. Reverse Cartwheel: FF+3+4");
                                        Console.WriteLine("4. Toita Daoshi: F+4");
                                        Console.WriteLine("5. Kincho: 1+2");
                                        Console.WriteLine("6. Meditation: 3+4");
                                        Console.WriteLine("7. Flea: D+1+2");
                                        Console.WriteLine("8. Indian: D+3+4");
                                        Console.WriteLine("9. Mutou no Kiwami: B+1+2");
                                        Console.WriteLine("10. Manji Dragonfly: U+1+2");
                                        repeatcharacter = false;
                                        repeatcode = false;
                                        break;

                                    case 2:
                                        Console.WriteLine("Yoshimitsu Basic Combos:");
                                        Console.WriteLine("1. DF+2 > F+2,1 > D+2,2,2");
                                        Console.WriteLine("2. DF+2 > D+2,2F > DF+1 > D+2,2,2 > DASH MNK 3,2,1+2");
                                        Console.WriteLine("3. DF+2 > DASH 1+4 > D+2,2 > DF+1,2,1 > DASH 1+4 > DASH D+2,2");
                                        Console.WriteLine("4. UF+3 > 3,2 > MD 2 > MD 2,4 > DASH 1+4 > DASH D+2,2,2");
                                        Console.WriteLine("5. DF+2 > D+2,2F > DF+1,2,1 > DASH 3,2,1+2");
                                        repeatcharacter = false;
                                        repeatcode = false;
                                        break;

                                    case 3:
                                        Console.WriteLine("Salmon 3");
                                        repeatcode = false;
                                        repeatcharacter = false;
                                        break;

                                    default:
                                        Console.WriteLine("Please select the correct option.");
                                        break;
                                }
                            }
                            else
                            {
                                Console.WriteLine("Please select the correct number!");
                            }
                            break;
                        default:
                            Console.WriteLine("\nPlease type correct character name.");
                            repeatcode = true;
                            repeatcharacter = false;
                            break;
                    }
                    //break; //break for while (repeatcharacter) loop
                } //while (repeatcharacter)
                  //break; //break for while (repeatcode) loop
            } //while (repeatcode)
        }

        public static void SF6_Characters()
        {
            string sf6_fighter = "";
            int sf6_option;
            List<String> sf6 = new List<String>();
            //Easy to learn street fighter 6 Characters
            sf6.Add("Lily");
            sf6.Add("Marisa");

            //Intermediate to learn street fighter 6 Characters
            sf6.Add("Ryu");
            sf6.Add("Luke");
            sf6.Add("Jamie");
            sf6.Add("Guile");
            sf6.Add("Kimberly");
            sf6.Add("Ken");
            sf6.Add("Blanka");
            sf6.Add("E.Honda");
            sf6.Add("Deejay");
            sf6.Add("Manon");
            sf6.Add("Cammy");
            sf6.Add("Akuma");
            sf6.Add("Terry");
            sf6.Add("Mai");

            //Hard to learn street fighter 6 Characters
            sf6.Add("Chun Li");
            sf6.Add("Juri");
            sf6.Add("Dhalsim");
            sf6.Add("JP");
            sf6.Add("Zangief");
            sf6.Add("Rashid");
            sf6.Add("Aki");
            sf6.Add("Ed");
            sf6.Add("M.Bison");

            bool repeatcode = true;
            while (repeatcode)
            {
                Console.WriteLine("\nStreet Fighter 6 has 36 characters.");
                Console.WriteLine("Which Street Fighter 6 character would you like to learn?\n");
                Console.WriteLine("List of current SF6 Characters");
                foreach (String characters in sf6)
                {
                    Console.WriteLine(characters);
                }

                Console.WriteLine("\nInput: ");
                sf6_fighter = Console.ReadLine();
                sf6_fighter = sf6_fighter.ToUpper();

                bool repeatcharacter = true;
                while (repeatcharacter)
                {
                    switch (sf6_fighter)
                    {
                        //Easy to learn
                        case "LILY":
                            Console.WriteLine("\nDifficulty: Easy");
                            Console.WriteLine("Lily is a grappler character with good mid range and pressure.");
                            Console.WriteLine("\nWhat would you like to learn about Lily? \n1.Key Moves \n2.Special Moves/Super Arts \n3.Combos");
                            Console.WriteLine("\nInput: ");
                            if (Int32.TryParse(Console.ReadLine(), out sf6_option))
                            {
                                switch (sf6_option)
                                {
                                    case 1:
                                        Console.WriteLine("Lily Key Moves");
                                        Console.WriteLine("Crouching Strong: CR.MP");
                                        Console.WriteLine("Standing Strong: MP");
                                        Console.WriteLine("Standing Fierce: HP");
                                        Console.WriteLine("Crouching Fierce: CR.HP");
                                        Console.WriteLine("Standing Roundhouse: HK");
                                        Console.WriteLine("Crouching Roundhouse: CR.HK");
                                        Console.WriteLine("Ridge Thrust: DF+HP");
                                        Console.WriteLine("Horn Breaker: B+HP");
                                        Console.WriteLine("Desert Storm: F+HP > HP > HP");
                                        Console.WriteLine("Canyon Throw: F+LP+LK");
                                        Console.WriteLine("Falling Cliff: B+LP+LK");
                                        break;
                                    case 2:
                                        Console.WriteLine("Lily Special Moves/Super Arts");
                                        Console.WriteLine("Special Moves");
                                        Console.WriteLine("Condor Wind: QCB+P");
                                        Console.WriteLine("Condor Spire: QCF+K");
                                        Console.WriteLine("Tomahawk Buster: FDDF+P");
                                        Console.WriteLine("Condor Dive: PP");
                                        Console.WriteLine("OD Condor Dive: PPP");
                                        Console.WriteLine("Mexican Typhoon: 360 Motion+P");

                                        Console.WriteLine("\nSuper Arts");
                                        Console.WriteLine("LVL1 Breezing Hawk: QCFx2+P");
                                        Console.WriteLine("LVL2 Thunderbird/Soaring Thunderbird: QCFx2+K");
                                        Console.WriteLine("LVL3 Raging Typhoon: QCBx2+P");
                                        break;
                                    case 3:
                                        Console.WriteLine("Lily Combos");
                                        Console.WriteLine("1. LK/CR.LK > CR.LP > CR.LP > QCF+KK");
                                        Console.WriteLine("2. CR.LK > CR.LP > CR.LP > QCF+KK > LVL2 (QCFx2+K)");
                                        Console.WriteLine("3. CR.MP > LVL1 (QCFx2+P)");
                                        Console.WriteLine("4. MK/CR.MK > QCF+LK");
                                        Console.WriteLine("5. B+HP > LK > CR.LP > QCF+KK");
                                        Console.WriteLine("6. F+HP > QCF+HK");
                                        break;
                                    default:
                                        Console.WriteLine("Please enter the coorect option.");
                                        break;
                                }
                            }
                            else
                            {
                                Console.WriteLine("Please select the correct number!");
                            }
                            break;

                        case "MARISA":
                            Console.WriteLine("\nDifficulty: Easy");
                            Console.WriteLine("Marisa is hard hitting, rushdown character with high damage combos.");
                            Console.WriteLine("\nWhat would you like to learn about Marisa? \n1.Key Moves \n2.Special Moves/Super Arts \n3.Combos");
                            Console.WriteLine("\nInput: ");
                            if (Int32.TryParse(Console.ReadLine(), out sf6_option))
                            {
                                switch (sf6_option)
                                {
                                    case 1:
                                        Console.WriteLine("Marisa Key Moves");
                                        Console.WriteLine("Standing Strong: MP");
                                        Console.WriteLine("Standing Forward: MK");
                                        Console.WriteLine("Crouching Strong: CR.MP");
                                        Console.WriteLine("Standing Fierce: HP");
                                        Console.WriteLine("Standing Roundhouse: HK");
                                        Console.WriteLine("Crouching Fierce: CR.HP");
                                        Console.WriteLine("Marisa Style: HP or HK (Can be held down)");
                                        Console.WriteLine("Medium Two Hitter: MP > MP");
                                        Console.WriteLine("Magna Bunker: B+HP");
                                        Console.WriteLine("Novacula Swipe: F+MP > HP");
                                        Console.WriteLine("Novacula Thrust: F+MP > HK");
                                        Console.WriteLine("Malleus Breaker: DF+HP > DF+HP");
                                        Console.WriteLine("Mounted Grace: F+LP+LK");
                                        Console.WriteLine("Ponte Milvio: B+LP+LK");
                                        break;
                                    case 2:
                                        Console.WriteLine("Marisa Special Moves/Super Arts");
                                        Console.WriteLine("Special Moves");
                                        Console.WriteLine("Gladius: QCB+P");
                                        Console.WriteLine("Dimachaerus: QCB+P > F+P");
                                        Console.WriteLine("Phalanx: FDDF+P");
                                        Console.WriteLine("Quadriga: QCF+K");
                                        Console.WriteLine("Scutum: QCB+K");
                                        Console.WriteLine("- Tonitus: P > P (During Scutum)");
                                        Console.WriteLine("- Procella: K (During Scutum)");
                                        Console.WriteLine("- Enfold: LP+LK (During Scutum)");

                                        Console.WriteLine("\nSuper Arts");
                                        Console.WriteLine("LVL1 Javelin of Marisa: QCFx2+P");
                                        Console.WriteLine("LVL2 Meteorite: QCBx2+P");
                                        Console.WriteLine("LVL3 Goddess of the Hunt: QCBx2+K");
                                        break;
                                    case 3:
                                        Console.WriteLine("Marisa Combos");
                                        Console.WriteLine("1. CR.LK > CR.LP > CR.LP > QCB+LP,F+P");
                                        Console.WriteLine("2. CR.LK > CR.LP > QCB+LP > LVL3 (QCFx2+K)");
                                        Console.WriteLine("3. MP-MP > QCF+MP");
                                        Console.WriteLine("4. MP-MP > QCF+PP > LVL2 (QCBx2+P)");
                                        Console.WriteLine("5. B+HP > QCB+HP,F+P > QCF+LK");
                                        Console.WriteLine("6. B+HP (Hold) > B+HP > QCB+HP,F+P > QCF+LK > (LVL3?)");
                                        break;
                                    default:
                                        Console.WriteLine("Please enter the coorect option.");
                                        break;
                                }
                            }
                            else
                            {
                                Console.WriteLine("Please select the correct number!");
                            }
                            break;

                        //Intermediate to learn
                        case "RYU":
                            Console.WriteLine("\nDifficulty: Intermediate");
                            Console.WriteLine("Ryu is a all-rounder that focus on neutral and mid range attacks");
                            Console.WriteLine("\nWhat would you like to learn about Ryu? \n1.Key Moves \n2.Special Moves/Super Arts \n3.Combos");
                            Console.WriteLine("\nInput: ");
                            if (Int32.TryParse(Console.ReadLine(), out sf6_option))
                            {
                                switch (sf6_option)
                                {
                                    case 1:
                                        Console.WriteLine("Ryu Key Moves");
                                        Console.WriteLine("Collarbone Breaker: F+MP");
                                        Console.WriteLine("Solar Plexus Strike: F+HP");
                                        Console.WriteLine("Axe Kick: F+HK");
                                        Console.WriteLine("Crouching Fierce: CR+HP");
                                        Console.WriteLine("Standing Forward: MK");
                                        Console.WriteLine("Crouching Forward: CR+MK");
                                        Console.WriteLine("Shoulder Throw: F+LP+LK");
                                        Console.WriteLine("Somersault Throw: B+LP+LK");
                                        break;
                                    case 2:
                                        Console.WriteLine("Ryu Special Moves/Super Arts");
                                        Console.WriteLine("Special Moves");
                                        Console.WriteLine("Hadoken: QCF+P");
                                        Console.WriteLine("Shoryuken: FDDF+P");
                                        Console.WriteLine("Air Tatsumaki Senpu-kyaku/Tatsumaki Senpu-kyaku: QCB+K");
                                        Console.WriteLine("High Blade Kick: QCF+K");
                                        Console.WriteLine("Hashogeki: QCB+P");
                                        Console.WriteLine("Denjin Charge: DD+P");

                                        Console.WriteLine("\nSuper Arts");
                                        Console.WriteLine("LVL1 Shinku Hadoken: QCFx2+P");
                                        Console.WriteLine("LVL2 Shin Hashogeki: QCBx2+P (Can hold for more power)");
                                        Console.WriteLine("LVL3 Shin Shoryuken: QCFx2+K");
                                        break;
                                    case 3:
                                        Console.WriteLine("Ryu Combos");
                                        Console.WriteLine("1. CR.MP > CR.LP > CR.LP > QCB+MK");
                                        Console.WriteLine("2. CR.LK > CR.LP > QCF+PP > LVL1 (QCFx2+P)");
                                        Console.WriteLine("3. MP > CR.MP > QCB+MK");
                                        Console.WriteLine("4. MP > CR.MP > QCF+KK > LVL 2 (QCBx2+P)");
                                        Console.WriteLine("5. HK > CR.MK > QCF+HP");
                                        Console.WriteLine("6. F+HP > CR.MP > QCF+KK > B+HK > QCF+HP > LVL3 (QCFx2+P)");
                                        break;
                                    default:
                                        Console.WriteLine("Please enter the coorect option.");
                                        break;
                                }
                            }
                            else
                            {
                                Console.WriteLine("Please select the correct number!");
                            }
                            break;

                        case "LUKE":
                            Console.WriteLine("\nDifficulty: Intermediate");
                            Console.WriteLine("Character_Name and Character_info");
                            Console.WriteLine("\nWhat would you like to learn about Luke? \n1.Key Moves \n2.Special Moves/Super Arts \n3.Combos");
                            Console.WriteLine("\nInput: ");
                            if (Int32.TryParse(Console.ReadLine(), out sf6_option))
                            {
                                switch (sf6_option)
                                {
                                    case 1:
                                        Console.WriteLine("Luke Key Moves");
                                        Console.WriteLine("Suppressor: B+HP");
                                        Console.WriteLine("Outlaw Kick: B+HK");
                                        Console.WriteLine("Rawhide: F+MP");
                                        Console.WriteLine("Crouching Fierce: CR.HP");
                                        Console.WriteLine("Crouching Strong: CR.MP");
                                        Console.WriteLine("Standing Forward: MK");
                                        Console.WriteLine("Crouching Forward: CR.MK");
                                        Console.WriteLine("Sweeper: F+LP+LK");
                                        Console.WriteLine("Scrapper: B+LP+LK");
                                        break;
                                    case 2:
                                        Console.WriteLine("Luke Special Moves/Super Arts");
                                        Console.WriteLine("Special Moves");
                                        Console.WriteLine("Sand Blast: QCF+P");
                                        Console.WriteLine("- Fatal Shot PP (After OD Sand Blast)");
                                        Console.WriteLine("Flash Knuckle: QCB+P");
                                        Console.WriteLine("- DDT: PP (After OD Flash Knuckle)");
                                        Console.WriteLine("Aerial Flash Knuckle: QCB+P");
                                        Console.WriteLine("Avenger: QCF+K");
                                        Console.WriteLine("- No Chaser: P (During Avenger)");
                                        Console.WriteLine("- Impaler: K (During Avenger)");
                                        Console.WriteLine("Rising Uppercut: FDDF+P");
                                        Console.WriteLine("- Slam Dunk: PP (After OD Rising Uppercut)");

                                        Console.WriteLine("\nSuper Arts");
                                        Console.WriteLine("LVL1 Vulcan Blast: QCFx2+P");
                                        Console.WriteLine("LVL2 Eraser: QCBx2+P");
                                        Console.WriteLine("Pale Rider: QCFx2+K");
                                        break;
                                    case 3:
                                        Console.WriteLine("Luke Combos");
                                        Console.WriteLine("1. CR.LK > CR.LP > CR.LP > QCB+LP");
                                        Console.WriteLine("2. CR.LK > CR.LP > CR.LP > QCB+PP > LVL1/LVL2 (QCFx2+P/QCBx2+P)");
                                        Console.WriteLine("3. LP,MP,HP > QCB+PP > QCB+HP > LVL3 (QCFx2+K)");
                                        Console.WriteLine("4. CR.MP > LK > QCP+PP > QCB+MP");
                                        Console.WriteLine("5. CR.MK > QCB+PPxPP");
                                        Console.WriteLine("6. CR.HP > QCB+MP > QCB+LP > QCB+HP");
                                        break;
                                    default:
                                        Console.WriteLine("Please enter the coorect option.");
                                        break;
                                }
                            }
                            else
                            {
                                Console.WriteLine("Please select the correct number!");
                            }
                            break;

                        case "JAMIE":
                            Console.WriteLine("\nDifficulty: Intermediate");
                            Console.WriteLine("Jamie is a rush down character that gets cool new tricks when he drinks.");
                            Console.WriteLine("\nWhat would you like to learn about Jamie? \n1.Key Moves \n2.Special Moves/Super Arts \n3.Combos");
                            Console.WriteLine("\nInput: ");
                            if (Int32.TryParse(Console.ReadLine(), out sf6_option))
                            {
                                switch (sf6_option)
                                {
                                    case 1:
                                        Console.WriteLine("Jamie Key Moves");
                                        Console.WriteLine("Standing Strong: MP");
                                        Console.WriteLine("Falling Star Kick: F+MK");
                                        Console.WriteLine("Crouching Strong: CR.MP");
                                        Console.WriteLine("Crouching Fierce: CR.HP");
                                        Console.WriteLine("Standing Roundhouse: HK");
                                        Console.WriteLine("Tensei Kick D+HK,HK");
                                        Console.WriteLine("Phantom Sway: D+HK+HK+P");
                                        Console.WriteLine("Bitter Strikers: LP > LK > MP (Drink lvl 1 or higher)");
                                        Console.WriteLine("Back Shaver: F+LP+LK");
                                        Console.WriteLine("Wheel Punch: B+LP+LK");
                                        break;
                                    case 2:
                                        Console.WriteLine("Jamie Special Moves/Super Arts");
                                        Console.WriteLine("Special Moves");
                                        Console.WriteLine("The Devil Inside: DD+P (Increases Drink lvl)");
                                        Console.WriteLine("Freeflow Strikes: QCF+P,F+P,F+P (Changes at drink lvl 4)");
                                        Console.WriteLine("Swagger Step: QCB+P");
                                        Console.WriteLine("Arrow Kick: FDDF+K");
                                        Console.WriteLine("Luminous Dive Kick: QCB+F (Drink LVL 1 or higher)");
                                        Console.WriteLine("Bakkai: QCF+K (Drink LVL 2 or higher)");
                                        Console.WriteLine("Tenshin: HCB+K (Drink LVL 3 or higher)");
                                        Console.WriteLine("Swagger Hermit Punch: QCB+P,F+P (Drink LVL 4 or higher)");

                                        Console.WriteLine("\nSuper Arts");
                                        Console.WriteLine("LVL1 Breakin': QCFx2+K (Hold down to add drink lvl)");
                                        Console.WriteLine("LVL2 The Devil's Song: QCBx2+P");
                                        Console.WriteLine("LVL3 Getsuga Saiho: QCFx2+P");
                                        break;
                                    case 3:
                                        Console.WriteLine("Jamie Combos");
                                        Console.WriteLine("1. CR.LK > CR.LP > LK > QCF+LP,F+P,F+P/QCF+LP,F+K,F+K");
                                        Console.WriteLine("2. CR.LK > CR.LP > LK > LVL1 (QCFx2+K)");
                                        Console.WriteLine("3. MP > LK > QCF+LP,F+P,F+P/QCF+LP,F+K,F+K");
                                        Console.WriteLine("4. MP > LK > LP,LK,MP > QCF+LP,F+P,F+P > LVL1/LVL3 (QCFx2+K/QCFx2+P)");
                                        Console.WriteLine("5. CR.HP > QCB+HP");
                                        Console.WriteLine("6. CR.HP > QCF+HP,F+P > LVL1/LVL3 (QCFx2+K/QCFx2+P)");
                                        break;
                                    default:
                                        Console.WriteLine("Please enter the coorect option.");
                                        break;
                                }
                            }
                            else
                            {
                                Console.WriteLine("Please select the correct number!");
                            }
                            break;

                        case "GUILE":
                            Console.WriteLine("\nDifficulty: Intermediate");
                            Console.WriteLine("Guile is a defensive zoner that focuses on controlling spacing.");
                            Console.WriteLine("\nWhat would you like to learn about Guile? \n1.Key Moves \n2.Special Moves/Super Arts \n3.Combos");
                            Console.WriteLine("\nInput: ");
                            if (Int32.TryParse(Console.ReadLine(), out sf6_option))
                            {
                                switch (sf6_option)
                                {
                                    case 1:
                                        Console.WriteLine("Guile Key Moves");
                                        Console.WriteLine("Standing Strong: MP");
                                        Console.WriteLine("Crouching Strong: CR.MP");
                                        Console.WriteLine("Crouching Fierce: CR.HP");
                                        Console.WriteLine("Full Bullet Magnum: F+MP");
                                        Console.WriteLine("Standing Forward: MK");
                                        Console.WriteLine("Standing Roundhouse: HK");
                                        Console.WriteLine("Crouching Roundhouse: D+HK");
                                        Console.WriteLine("Spinning Back Knuckle: F+HP");
                                        Console.WriteLine("Knee Bazooka: B+LK");
                                        Console.WriteLine("Burning Straight: B+HP");
                                        Console.WriteLine("Rolling Sobat: F+MK/B+MK");
                                        Console.WriteLine("Drake Fang: D+MK > F+MP");
                                        Console.WriteLine("Dragon Suplex: F+LP+LK");
                                        Console.WriteLine("Judo Throw: B+LP+LK");
                                        Console.WriteLine("Flying Mare: F+LP+LK (During a jump)");
                                        Console.WriteLine("Flying Buster Drop: B+LP+LK (During a jump)");
                                        break;
                                    case 2:
                                        Console.WriteLine("Guile Special Moves/Super Arts");
                                        Console.WriteLine("Special Moves");
                                        Console.WriteLine("Sonic Boom: BF+P (Hold back for 2 seconds then F+P)");
                                        Console.WriteLine("Somersault Kick: DU+K (Hold down for 2 seconds then U+K)");
                                        Console.WriteLine("Sonic Blade: QCB+P");
                                        Console.WriteLine("- Sonic Cross: F+P");
                                        Console.WriteLine("- OD Sonic Cross: F+PP (During OD Sonic Blade)");
                                        Console.WriteLine("Sonic Break: PP");
                                        Console.WriteLine("- Sonic Break: P (During Solid Puncher/Sonic Boom/Sonic Break)");

                                        Console.WriteLine("\nSuper Arts");
                                        Console.WriteLine("LVL1 Sonic Hurricane: BFBF+P (Hold first back for 2 secs)");
                                        Console.WriteLine("LVL2 Solid Puncher: QCBx2+P");
                                        Console.WriteLine("LVL3 Crossfire Somersault: BFBF+K (Hold first back for 2 secs)");
                                        break;
                                    case 3:
                                        Console.WriteLine("Guile Combos");
                                        Console.WriteLine("1. CR.LP > CR.LP > DU+HK (Hold down for 2 secs then U+HK)");
                                        Console.WriteLine("2. CR.LK > CR.LP > DU+HK (Hold down for 2 secs then U+HK)");
                                        Console.WriteLine("3. CR.MP > DU+HK (Hold down for 2 secs then U+HK)");
                                        Console.WriteLine("4. MP > CR.MP > CR.MP > DU+HK (Hold down for 2 secs then U+HK)");
                                        Console.WriteLine("5. MP > CR.MP > DU+HK (Hold down for 2 secs then U+HK)");
                                        Console.WriteLine("6. MP > HP > DU+HK (Hold down for 2 secs then U+HK)");
                                        break;
                                    default:
                                        Console.WriteLine("Please enter the coorect option.");
                                        break;
                                }
                            }
                            else
                            {
                                Console.WriteLine("Please select the correct number!");
                            }
                            break;

                        case "KIMBERLY":
                            Console.WriteLine("\nDifficulty: Intermediate");
                            Console.WriteLine("Kimberly is a rushdown character that has tricky mixups");
                            Console.WriteLine("\nWhat would you like to learn about Kimberly? \n1.Key Moves \n2.Special Moves/Super Arts \n3.Combos");
                            Console.WriteLine("\nInput: ");
                            if (Int32.TryParse(Console.ReadLine(), out sf6_option))
                            {
                                switch (sf6_option)
                                {
                                    case 1:
                                        Console.WriteLine("Character_Name Key Moves");
                                        Console.WriteLine("Standing Forward: MK");
                                        Console.WriteLine("Crouching Forward: MK");
                                        Console.WriteLine("Standing Roundhouse: HK");
                                        Console.WriteLine("Standing Fierce: HP");
                                        Console.WriteLine("Crouching Fierce: D+HP");
                                        Console.WriteLine("Bushin Tiger Fangs: MP > HP");
                                        Console.WriteLine("Hisen Kick: F+HK");
                                        Console.WriteLine("Windmill Kick: B+HK");
                                        Console.WriteLine("Water Slicer Slide: DF+MK");
                                        Console.WriteLine("Ripcord Throw: F+LP+LK");
                                        Console.WriteLine("Bell Ringer: B+LP+LK");
                                        break;
                                    case 2:
                                        Console.WriteLine("Character_Name Special Moves/Super Arts");
                                        Console.WriteLine("Special Moves");
                                        Console.WriteLine("Air Bushin Senpukyaku/Bushin Senpukyaku: QCB+K");
                                        Console.WriteLine("Sprint: QCF+K");
                                        Console.WriteLine("- Emergency Stop: P");
                                        Console.WriteLine("- Torso Cleaver: LK");
                                        Console.WriteLine("- Shadow Slide: MK");
                                        Console.WriteLine("- Neck Hunter: HK");
                                        Console.WriteLine("- Arc Step: Happens automatically");
                                        Console.WriteLine(" - Bushin Izuna Otoshi: P");
                                        Console.WriteLine(" - Bushin Hojin Kick: K");
                                        Console.WriteLine("Vagabond Edge: QCF+P");
                                        Console.WriteLine("Hidden Variable: QCB+P");
                                        Console.WriteLine("Genius at Play: DD+P");
                                        Console.WriteLine("- Shuriken Bomb: DD+P");
                                        Console.WriteLine("- Shuriken Bomb Spread: DD+PP");
                                        Console.WriteLine("Nue Twister: QCF+P (During a jump)");

                                        Console.WriteLine("\nSuper Arts");
                                        Console.WriteLine("LVL1 Bushin Beats: QCFx2+K");
                                        Console.WriteLine("- Bushin Thunderous Beats: Keep pressing K (Need at least 1 Shuriken Bomb during Bushin Beats)");
                                        Console.WriteLine("LVL2 Bushin Scramble/Soaring Bushin Scramble: QCBx2+P");
                                        Console.WriteLine("LVL3 Bushin Ninjastar Cypher: QCFx2+P");
                                        break;
                                    case 3:
                                        Console.WriteLine("Character_Name Combos");
                                        Console.WriteLine("1. CR.LK > LP,MP,HP,HK");
                                        Console.WriteLine("2. CR.LK > LP > LK > QCF+LP > LVL3 (QCFx2+P)");
                                        Console.WriteLine("3. CR.MP > MP,HP > QCF+MP");
                                        Console.WriteLine("4. CR.MP > MP,HP > QCF+PP > J.MP > QCB+KK > LVL2 (QCBx2+P)");
                                        Console.WriteLine("5. HP > QCF+HP > J.QCF+HP");
                                        Console.WriteLine("6. HP > QCF+HP > LVL1/LVL2/LVL3");
                                        break;
                                    default:
                                        Console.WriteLine("Please enter the coorect option.");
                                        break;
                                }
                            }
                            else
                            {
                                Console.WriteLine("Please select the correct number!");
                            }
                            break;

                        case "KEN":
                            Console.WriteLine("\nDifficulty: Normal");
                            Console.WriteLine("Ken is a rushdown character that applies aggressive pressure");
                            Console.WriteLine("\nWhat would you like to learn about Ken? \n1.Key Moves \n2.Special Moves/Super Arts \n3.Combos");
                            Console.WriteLine("\nInput: ");
                            if (Int32.TryParse(Console.ReadLine(), out sf6_option))
                            {
                                switch (sf6_option)
                                {
                                    case 1:
                                        Console.WriteLine("Ken Key Moves");
                                        Console.WriteLine("Standing Strong: MP");
                                        Console.WriteLine("Standing Fierce: HP");
                                        Console.WriteLine("Crouching Fierce: D+HP");
                                        Console.WriteLine("Standing Roundhouse: HK");
                                        Console.WriteLine("Crouching Forward: D+MK");
                                        Console.WriteLine("Chin Buster: MP > HP");
                                        Console.WriteLine("Triple Flash Kicks: MK > MK > HK");
                                        Console.WriteLine("Knee Strikes: F+LP+LK");
                                        Console.WriteLine("Hell Wheel: LP+LK (During a Jump)");
                                        break;
                                    case 2:
                                        Console.WriteLine("Ken Special Moves/Super Arts");
                                        Console.WriteLine("Special Moves");
                                        Console.WriteLine("Hadoken: QCF+P");
                                        Console.WriteLine("Shoryuken: FDDF+P");
                                        Console.WriteLine("Air Tatsumaki Senpu-kyaku/Tatsumaki Senpu-kyaku: QCB+K");
                                        Console.WriteLine("Dragonlash Kick: FDDF+K");
                                        Console.WriteLine("Jinrai Kick: QCF+K");
                                        Console.WriteLine("- Kazekama Shin Kick (KSK): F+LK");
                                        Console.WriteLine("- Gorai Axe Kick (GAK): F+MK");
                                        Console.WriteLine("- Senka Snap Kick (SSK): F+HK");
                                        Console.WriteLine("Kasai Thrust Kick: F+K (During OD KSK,OD GAK,OD SSK)");
                                        Console.WriteLine("Quick Dash: KK");
                                        Console.WriteLine("- Emergency Stop: LK");
                                        Console.WriteLine("- Thunder Kick: MK");
                                        Console.WriteLine("- Forward Step Kick: HK");

                                        Console.WriteLine("\nSuper Arts");
                                        Console.WriteLine("LVL1 Dragonlash Flame: QCBx2+K");
                                        Console.WriteLine("LVL2 Shippu Jinrai-kyaku: QCFx2+K");
                                        Console.WriteLine("LVL3 Shinryu Reppa: QCFx2+P");
                                        break;
                                    case 3:
                                        Console.WriteLine("Ken Combos");
                                        Console.WriteLine("1. CR.LP > CR.LP > QCF+LK,F+HK");
                                        Console.WriteLine("2. CR.LK > CR.LP > LK > FDDF+HP");
                                        Console.WriteLine("3. MP > CR.LP > LK > FDDF+HP");
                                        Console.WriteLine("4. MP,HK > KK,HK > LVL2 (QCFx2+K)");
                                        Console.WriteLine("5. CR.HP > QCF+HK > LVL2 (QCFx2+K)");
                                        Console.WriteLine("6. CR.HP > QCF+HK > FDDF+KK > LVL3 (QCFx2+P)");
                                        break;
                                    default:
                                        Console.WriteLine("Please enter the coorect option.");
                                        break;
                                }
                            }
                            else
                            {
                                Console.WriteLine("Please select the correct number!");
                            }
                            break;

                        case "Blanka":
                            Console.WriteLine("\nDifficulty: Intermediate");
                            Console.WriteLine("Blanka is a wacky rushdown character that can confuse players with gimmicks and setups.");
                            Console.WriteLine("\nWhat would you like to learn about Blanka? \n1.Key Moves \n2.Special Moves/Super Arts \n3.Combos");
                            Console.WriteLine("\nInput: ");
                            if (Int32.TryParse(Console.ReadLine(), out sf6_option))
                            {
                                switch (sf6_option)
                                {
                                    case 1:
                                        Console.WriteLine("Blanka Key Moves");
                                        Console.WriteLine("Standing Roundhouse: HK");
                                        Console.WriteLine("Crouching Strong: CR.MP");
                                        Console.WriteLine("Standing Strong: MP");
                                        Console.WriteLine("Standing Fierce: HP");
                                        Console.WriteLine("Rock Crusher: F+MP");
                                        Console.WriteLine("Wild Edge: B+MK");
                                        Console.WriteLine("Amazon River Run: DF+HP");
                                        Console.WriteLine("Wild Fang: F+LP+LK");
                                        Console.WriteLine("Jungle Flip: B+LP+LK");
                                        Console.WriteLine("Wild Bites: LP+LK (During a jump)");
                                        break;
                                    case 2:
                                        Console.WriteLine("Blanka Special Moves/Super Arts");
                                        Console.WriteLine("Special Moves");
                                        Console.WriteLine("Electric Thunder: QCB+P");
                                        Console.WriteLine("Air Rolling Attack/Rolling Attack: BF+P (Hold back for 2 secs then F+P)");
                                        Console.WriteLine("Vertical Rolling Attack: DU+K (Hold down for 2 secs then U+K)");
                                        Console.WriteLine("Backstep Rolling Attack: HCB+K");
                                        Console.WriteLine("Wild Hunt: QCF+K");
                                        Console.WriteLine("Blanka-chan Bomb: DD+P");
                                        Console.WriteLine("Rolling Cannon: Any dirction+P (During Lighting Beast)");
                                        Console.WriteLine("Coward Crouch: DD+PP");
                                        Console.WriteLine("- Wild Lift: P (During Coward Crouch)");
                                        Console.WriteLine("- Raid Jump: K (During Coward Crouch)");
                                        Console.WriteLine("Surprise Forward Hop: F+KKK");
                                        Console.WriteLine("Surprise Back Hop: B+KKK");

                                        Console.WriteLine("\nSuper Arts");
                                        Console.WriteLine("LVL1 Shout of Earth: QCBx2+P");
                                        Console.WriteLine("LVL2 Lightning Beast: QCBx2+P");
                                        Console.WriteLine("LVL3 Ground Shave Cannonball: QCFx2+K");
                                        break;
                                    case 3:
                                        Console.WriteLine("Blanka Combos");
                                        Console.WriteLine("1. CR.LK > CR.LP > CR.LP > BF+MP (Hold back for 2 secs then F+P)");
                                        Console.WriteLine("2. CR.LK > CR.LP > CR.LP > LVL1 (QCBx2+P)");
                                        Console.WriteLine("3. CR.MK > LP > BF+MP (Hold back for 2 secs then F+P)");
                                        Console.WriteLine("4. F+MK > LK > CR.LP BF+MP (Hold back for 2 secs then F+P)");
                                        Console.WriteLine("5. HK > CR.LP > DU+LK (Hold down for 2 secs then U+K)");
                                        Console.WriteLine("6. HP > D+PP,P > DF+HP");
                                        break;
                                    default:
                                        Console.WriteLine("Please enter the coorect option.");
                                        break;
                                }
                            }
                            else
                            {
                                Console.WriteLine("Please select the correct number!");
                            }
                            break;

                        case "E.HONDA":
                            Console.WriteLine("\nDifficulty: Intermediate");
                            Console.WriteLine("E.Honda is a rushdown character that does big damage in sumo style.");
                            Console.WriteLine("\nWhat would you like to learn about E.Honda? \n1.Key Moves \n2.Special Moves/Super Arts \n3.Combos");
                            Console.WriteLine("\nInput: ");
                            if (Int32.TryParse(Console.ReadLine(), out sf6_option))
                            {
                                switch (sf6_option)
                                {
                                    case 1:
                                        Console.WriteLine("E.Honda Key Moves");
                                        Console.WriteLine("Crouching Forward: CR.MK");
                                        Console.WriteLine("Standing Roundhouse: HK");
                                        Console.WriteLine("Crouching Strong: MP");
                                        Console.WriteLine("Crouching Fierce: HP");
                                        Console.WriteLine("Standing Strong: MP");
                                        Console.WriteLine("Standing Fierce: HP");
                                        Console.WriteLine("Harai Kick: F+HK");
                                        Console.WriteLine("Power Stomp: DF+HK");
                                        Console.WriteLine("Double Slaps: LP > MP");
                                        Console.WriteLine("Saba Ori: F+LP+LK");
                                        Console.WriteLine("Tawara Throw: B+LP+LK");
                                        break;
                                    case 2:
                                        Console.WriteLine("Character_Name Special Moves/Super Arts");
                                        Console.WriteLine("Special Moves");
                                        Console.WriteLine("Hundred Hand Slap: QCB+P");
                                        Console.WriteLine("Sumo Headbutt: BF+P (Hold back for 2 secs then F+P)");
                                        Console.WriteLine("Sumo Smash: DU+K (Hold down for 2 secs then U+K)");
                                        Console.WriteLine("Oicho Throw: HCB+K");
                                        Console.WriteLine("Sumo Dash: QCF+K");
                                        Console.WriteLine("- Teppo Triple Slap: P>P (During Sumo Dash)");
                                        Console.WriteLine("- Taiho Cannon Lift: D+P (During Sumo Dash)");
                                        Console.WriteLine("Neko Damashi: DD+P");
                                        Console.WriteLine("Sumo Spirit: DD+K");

                                        Console.WriteLine("\nSuper Arts");
                                        Console.WriteLine("LVL1 Show of Force: QCFx2+P");
                                        Console.WriteLine("LVL2 Ultimate Killer Head Ram: BFBF+K (Hold first back for 2 secs)");
                                        Console.WriteLine("LVL3 The Final Bout: QCBx2+P");
                                        break;
                                    case 3:
                                        Console.WriteLine("Character_Name Combos");
                                        Console.WriteLine("1. CR.LK > CR.LP > CR.LP > QCB+LP");
                                        Console.WriteLine("2. LK > LP,MP > QCB+HP > LVL3 (QCBx2+P)");
                                        Console.WriteLine("3. MP > QCB+PP > CR.LP > QCB+LP");
                                        Console.WriteLine("4. MP > CR.LP > BF+MP (Hold back for 2 secs then F+P)");
                                        Console.WriteLine("5. HP > QCF+KK,D+P > DU+HK (Hold down for 2 secs then U+K)");
                                        Console.WriteLine("6. HP > QCB+PP > CR.LP > LVL3 (QCBx2+P)");
                                        break;
                                    default:
                                        Console.WriteLine("Please enter the coorect option.");
                                        break;
                                }
                            }
                            else
                            {
                                Console.WriteLine("Please select the correct number!");
                            }
                            break;

                        case "DEEJAY":
                            Console.WriteLine("\nDifficulty: Intermediate");
                            Console.WriteLine("Deejay is a rushdown character that has gimmicks and mixups with his feints and swal movements");
                            Console.WriteLine("\nWhat would you like to learn about Deejay? \n1.Key Moves \n2.Special Moves/Super Arts \n3.Combos");
                            Console.WriteLine("\nInput: ");
                            if (Int32.TryParse(Console.ReadLine(), out sf6_option))
                            {
                                switch (sf6_option)
                                {
                                    case 1:
                                        Console.WriteLine("Deejay Key Moves");
                                        Console.WriteLine("Standing Strong: MP");
                                        Console.WriteLine("Crouching Strong: CR.MP");
                                        Console.WriteLine("Standing Forward: MK");
                                        Console.WriteLine("Standing Roundhouse: HK");
                                        Console.WriteLine("Crouching Fierce: CR.HP");
                                        Console.WriteLine("Standing Fierce: HP");
                                        Console.WriteLine("Crouching Forward: CR.MK");
                                        Console.WriteLine("Crouching Roundhouse: CR.HK");
                                        Console.WriteLine("Knee Shot: D+LK (During forward jump)");
                                        Console.WriteLine("Face Breaker: B+HK");
                                        Console.WriteLine("Sunrise Heel: F+MK");
                                        Console.WriteLine("Dee Jay Special: MP > HP > HK");
                                        Console.WriteLine("Funky Dance: MP > MP > HP");
                                        Console.WriteLine("Funky Dance Feint: MP > MP > B+HP");
                                        Console.WriteLine("Diss Track: F+LP+LK");
                                        Console.WriteLine("Flip Throw: B+LP+LK");
                                        break;
                                    case 2:
                                        Console.WriteLine("Deejay Special Moves/Super Arts");
                                        Console.WriteLine("Special Moves");
                                        Console.WriteLine("Air Slasher: BF+P (Hold back for 2 secs then F+P)");
                                        Console.WriteLine("Jackknife Maximum: DU+K (Hold down for 2 secs then U+K)");
                                        Console.WriteLine("Roll Through Feint: QCF+LK");
                                        Console.WriteLine("Quick Rolling Sobat: QCF+MK");
                                        Console.WriteLine("Double Rolling Sobat: QCF+HK");
                                        Console.WriteLine("Machine Gun Uppercut: QCB+P");
                                        Console.WriteLine("Jus Cool: QCB+K");
                                        Console.WriteLine("- Funky Slicer: LK (During Jus Cool)");
                                        Console.WriteLine("- Waning Moon: MK (During Jus Cool)");
                                        Console.WriteLine("- Maximum Strike: HK (During Jus Cool)");
                                        Console.WriteLine("- Juggling Dash: F+P (During Jus Cool)");
                                        Console.WriteLine(" - Juggling Sway: B+P (During Juggling Dash)");

                                        Console.WriteLine("\nSuper Arts");
                                        Console.WriteLine("LVL1 The Greatest Sobat: QCFx2+K");
                                        Console.WriteLine("LVL2 Lowkey Sunrise Festival (LSF): QCFx2+LP>LP>MP>HP>LK>MK>HK");
                                        Console.WriteLine("LVL2 Marvelous Sunrise Festival (MSF): QCFx2+MP>LP>MP>HP>LK>MK>HK");
                                        Console.WriteLine("- Climactic Strike: HP (After MSF/HSF connects)");
                                        Console.WriteLine("- Encore Beat: HK (After MSF/HSF connects)");
                                        Console.WriteLine("LVL2 Headliner Sunrise Festival (HSF): QCFx2+HP>LP>MP>HP>LK>MK>HK");
                                        Console.WriteLine("- Climactic Strike: HP (After MSF/HSF connects)");
                                        Console.WriteLine("- Encore Beat: HK (After MSF/HSF connects)");
                                        Console.WriteLine("LVL3 Weekend Pleasure: QCBx2+P");
                                        break;
                                    case 3:
                                        Console.WriteLine("Deejay Combos");
                                        Console.WriteLine("1. CR.LK > CR.LP > QCF+MK");
                                        Console.WriteLine("2. CR.LK > CR.LP > QCF+MK > LVL3 (QCBx2+P)");
                                        Console.WriteLine("3. MP > LK > QCF MK/HK");
                                        Console.WriteLine("4. MP > HP > HK > LVL1 (QCFx2+K)");
                                        Console.WriteLine("5. CR.HP > CR.MP > DU+HK (Hold down for 2 secs then U+K)");
                                        Console.WriteLine("6. CR.HP > CR.MP > QCB+P > LVL3 (QCBx2+P)");
                                        break;
                                    default:
                                        Console.WriteLine("Please enter the coorect option.");
                                        break;
                                }
                            }
                            else
                            {
                                Console.WriteLine("Please select the correct number!");
                            }
                            break;

                        case "MANON":
                            Console.WriteLine("\nDifficulty: Intermediate");
                            Console.WriteLine("Manon is a grappler character that focuses on elegance and beauty");
                            Console.WriteLine("\nWhat would you like to learn about Manon? \n1.Key Moves \n2.Special Moves/Super Arts \n3.Combos");
                            Console.WriteLine("\nInput: ");
                            if (Int32.TryParse(Console.ReadLine(), out sf6_option))
                            {
                                switch (sf6_option)
                                {
                                    case 1:
                                        Console.WriteLine("Manon Key Moves");
                                        Console.WriteLine("Standing Strong: MP");
                                        Console.WriteLine("Crouching Strong: CR.MP");
                                        Console.WriteLine("Standing Forward: MK");
                                        Console.WriteLine("Standing Roundhouse: HK");
                                        Console.WriteLine("Standing Fierce: HP");
                                        Console.WriteLine("Crouching Fierce: CR.HP");
                                        Console.WriteLine("Crouching Forward: CR.MK");
                                        Console.WriteLine("Reverence: B+HP");
                                        Console.WriteLine("A Terre: MP > MK");
                                        Console.WriteLine("Temps Lie: HP > HP");
                                        Console.WriteLine("Allonge: D+HP > HP");
                                        Console.WriteLine("Ouchi Gari: F+LP+LK");
                                        Console.WriteLine("Uchi Mata: B+LP+LK");
                                        break;
                                    case 2:
                                        Console.WriteLine("Manon Special Moves/Super Arts");
                                        Console.WriteLine("Special Moves");
                                        Console.WriteLine("Manege Dore: HCB+P");
                                        Console.WriteLine("Rond-point: QCF+K");
                                        Console.WriteLine("Degage: QCB+K");
                                        Console.WriteLine("Renverse: QCF+P");
                                        Console.WriteLine("- Grand Fouette: K (During Renverse)");

                                        Console.WriteLine("\nSuper Arts");
                                        Console.WriteLine("LVL1 Arabesque: QCFx2+K");
                                        Console.WriteLine("LVL2 Etoile: QCBx2+K");
                                        Console.WriteLine("LVL3 Pas de Deux: QCFx2+P");
                                        break;
                                    case 3:
                                        Console.WriteLine("Character_Name Combos");
                                        Console.WriteLine("1. CR.LK > CR.LP > QCF+MK");
                                        Console.WriteLine("2. CR.LK > CR.LP > QCF+KK > LVL2 (QCBx2+K)");
                                        Console.WriteLine("3. B+MK,MK > QCF+KK > QCB+MK");
                                        Console.WriteLine("4. B+MK,MK > QCB+MK");
                                        Console.WriteLine("5. B+HP > QCB+KK > LK > QCF+MK");
                                        Console.WriteLine("6. B+HP > QCB+KK > CR.MP > QCF+MK");
                                        break;
                                    default:
                                        Console.WriteLine("Please enter the coorect option.");
                                        break;
                                }
                            }
                            else
                            {
                                Console.WriteLine("Please select the correct number!");
                            }
                            break;

                        case "CAMMY":
                            Console.WriteLine("\nDifficulty: Intermediate");
                            Console.WriteLine("Cammy is a rushdown with aggressive pressure with her divekick and love for cats");
                            Console.WriteLine("\nWhat would you like to learn about Cammy? \n1.Key Moves \n2.Special Moves/Super Arts \n3.Combos");
                            Console.WriteLine("\nInput: ");
                            if (Int32.TryParse(Console.ReadLine(), out sf6_option))
                            {
                                switch (sf6_option)
                                {
                                    case 1:
                                        Console.WriteLine("Cammy Key Moves");
                                        Console.WriteLine("Standing Strong: MP");
                                        Console.WriteLine("Standing Forward: MK");
                                        Console.WriteLine("Crouching Strong: CR.MP");
                                        Console.WriteLine("Standing Fierce: HP");
                                        Console.WriteLine("Standing Roundhouse: HK");
                                        Console.WriteLine("Crouching Fierce: CR.HP");
                                        Console.WriteLine("Crouching Roundhouse: CR.HK");
                                        Console.WriteLine("Lift Uppercut: B+MP");
                                        Console.WriteLine("Delayed Ripper: F+HK");
                                        Console.WriteLine("Assault Blade: B+HK");
                                        Console.WriteLine("Lift Combination: B+MP > HK");
                                        Console.WriteLine("Swing Combination: HP > HK");
                                        Console.WriteLine("Rough Landing: F+LP+LK");
                                        Console.WriteLine("Delta Throw: B+LP+LK");
                                        Console.WriteLine("Leg Scissors Choke: LP+LK (During a jump)");
                                        break;
                                    case 2:
                                        Console.WriteLine("Character_Name Special Moves/Super Arts");
                                        Console.WriteLine("Special Moves");
                                        Console.WriteLine("Spiral Arrow: QCF+K");
                                        Console.WriteLine("Canon Spike: FDDF+K");
                                        Console.WriteLine("Quick Spin Knuckle: QCB+P");
                                        Console.WriteLine("Cannon Strike: QCB+K (During forward jump)");
                                        Console.WriteLine("Hooligan Combination (HC): QCF+P");
                                        Console.WriteLine("- Razor's Edge Sliver: Don't press any button (During HC)");
                                        Console.WriteLine("- Cannon Strike: K (During HC)");
                                        Console.WriteLine("- Reverse Edge: D+K (During HC)");
                                        Console.WriteLine("- Fatal Leg Twister: LP+LK (During HC)");
                                        Console.WriteLine("- Silent Step: P (During HC)");

                                        Console.WriteLine("\nSuper Arts");
                                        Console.WriteLine("LVL1 Spin Drive Smasher: QCFx2+K");
                                        Console.WriteLine("LVL2 Air Killer Bee Spin/Killer Bee Spin: QCBx2+P");
                                        Console.WriteLine("LVL3 Delta Red Assault: QCFx2+P");
                                        break;
                                    case 3:
                                        Console.WriteLine("Character_Name Combos");
                                        Console.WriteLine("1. CR.LK > CR.LP > DP.HK");
                                        Console.WriteLine("2. CR.LK > CR.LP > CR.LP > LVL1 (QCFx2+K)");
                                        Console.WriteLine("3. MP > LK > QCF+MK");
                                        Console.WriteLine("4. MP > B+MP,HK > J.MP > QCB+KK > LVL1/LVL3 (QCFx2+k/QCFx2+P)");
                                        Console.WriteLine("5. CR.HP > CR.MP > QCF+HK/FDDF+HK");
                                        Console.WriteLine("6. HP,HK > QCB+KK > LVL1 (QCFx2+K)");
                                        break;
                                    default:
                                        Console.WriteLine("Please enter the coorect option.");
                                        break;
                                }
                            }
                            else
                            {
                                Console.WriteLine("Please select the correct number!");
                            }
                            break;

                        case "AKUMA":
                            Console.WriteLine("\nDifficulty: Intermediate");
                            Console.WriteLine("Akuma is a shoto style character that searches for a worthy battle");
                            Console.WriteLine("\nWhat would you like to learn about Akuma? \n1.Key Moves \n2.Special Moves/Super Arts \n3.Combos");
                            Console.WriteLine("\nInput: ");
                            if (Int32.TryParse(Console.ReadLine(), out sf6_option))
                            {
                                switch (sf6_option)
                                {
                                    case 1:
                                        Console.WriteLine("Akuma Key Moves");
                                        Console.WriteLine("Crouching Fierce: CR.HP");
                                        Console.WriteLine("Crouching Forward: CR.MK");
                                        Console.WriteLine("Standing Roundhouse: HK");
                                        Console.WriteLine("Skull Splitter: F+MP");
                                        Console.WriteLine("Resso Snap Kick: F+MK");
                                        Console.WriteLine("Rago High Kick: B+HK");
                                        Console.WriteLine("Viscera Piercer: MP > MP");
                                        Console.WriteLine("Tenmaku Blade Kick: D+MK (During forward jump)");
                                        Console.WriteLine("Goshoha: F+LP+LK");
                                        Console.WriteLine("Shuretto: B+LP+LK");
                                        break;
                                    case 2:
                                        Console.WriteLine("Akuma Special Moves/Super Arts");
                                        Console.WriteLine("Special Moves");
                                        Console.WriteLine("Gou Hadoken: QCF+P");
                                        Console.WriteLine("Zanku Hadoken: QCF+P (During forward jump)");
                                        Console.WriteLine("Gou Shoryuken: FDDF+P");
                                        Console.WriteLine("Air Tatsumaki Zanku-kyaku/Tatsumaki Zanku-kyaku: QCB+K");
                                        Console.WriteLine("Adamant Flame: QCB+P > F+P");
                                        Console.WriteLine("Demon Raid: QCF+K");
                                        Console.WriteLine("- Demon Low Slash: No input (During Demon Raid)");
                                        Console.WriteLine("- Demon Guillontine: P (During Demon Raid)");
                                        Console.WriteLine("- Demon Blade Kick: K (During Demon Raid)");
                                        Console.WriteLine("- Demon Swoop: Hold Down (During Demon Raid)");
                                        Console.WriteLine("- Demon Gou Zanku: QCF+P (During OD Demon Raid)");
                                        Console.WriteLine("- Demon Gou Rasen: QCB+K (During OD Demon Raid)");
                                        Console.WriteLine("Ashura Senku: F+KKK/B+KKK");
                                        Console.WriteLine("Oboro Thow: F+KKK > LP+LK");

                                        Console.WriteLine("\nSuper Arts");
                                        Console.WriteLine("LVL1 Messatsu Gohado/Tenma Gozanku: QCFx2+P/QCFx2+K (During Jump)");
                                        Console.WriteLine("LVL2 Empyrean's End: QCBx2+P");
                                        Console.WriteLine("LVL3 Sip of Calamity: QCFx2+K");
                                        Console.WriteLine("LVL3 Shun Goku Satsu: LP > LP > F+LK > HP (health is 25% or lower)");
                                        break;
                                    case 3:
                                        Console.WriteLine("Akuma Combos");
                                        Console.WriteLine("1. CR.LK > CR.LP > QCB+LK > FDDF+HP");
                                        Console.WriteLine("2. CR.LK > CR.LP > CR.LP > QCF+LP,F+P > LVL3 (QCFx2+K)");
                                        Console.WriteLine("3. MP > CR.LP > QCB+LK > FDDF+HP");
                                        Console.WriteLine("4. CR.MP > MP,MP > QCB+PP,F+P > LVL2 (QCBx2+P)");
                                        Console.WriteLine("5. F+HP > CR.LP > LK > QCB+LK > CR.HK");
                                        Console.WriteLine("6. HK > CR.MP > CR.MP > QCF+PP,F+P");
                                        break;
                                    default:
                                        Console.WriteLine("Please enter the coorect option.");
                                        break;
                                }
                            }
                            else
                            {
                                Console.WriteLine("Please select the correct number!");
                            }
                            break;

                        case "TERRY":
                            Console.WriteLine("\nDifficulty: Intermediate");
                            Console.WriteLine("Terry is a rushdown all rounder character that travelled from Florida to throw hands");
                            Console.WriteLine("\nWhat would you like to learn about Terry? \n1.Key Moves \n2.Special Moves/Super Arts \n3.Combos");
                            Console.WriteLine("\nInput: ");
                            if (Int32.TryParse(Console.ReadLine(), out sf6_option))
                            {
                                switch (sf6_option)
                                {
                                    case 1:
                                        Console.WriteLine("Terry Key Moves");
                                        Console.WriteLine("Standing Roundhouse: HK");
                                        Console.WriteLine("Standing Fierce: HP");
                                        Console.WriteLine("Standing Forward: MK");
                                        Console.WriteLine("Standing Strong: MP");
                                        Console.WriteLine("Crouching Strong: CR.MP");
                                        Console.WriteLine("Crouching Forward: CR.MK");
                                        Console.WriteLine("Hammer Punch: F+HP");
                                        Console.WriteLine("Power Shoot: MP > HK");
                                        Console.WriteLine("Power Dunk: MP > HK > HK");
                                        Console.WriteLine("Passing Sway: MP > MK");
                                        Console.WriteLine("- Jumping Lariat: MP (After Passing Sway connects)");
                                        Console.WriteLine("- Jumping Knee: MK (After Passing Sway connects)");
                                        Console.WriteLine("Fire Kick: D+MK > D+HK");
                                        Console.WriteLine("Grasping Upper: F+LP+LK");
                                        Console.WriteLine("Buster Throw: B+LP+LK");
                                        break;
                                    case 2:
                                        Console.WriteLine("Terry Special Moves/Super Arts");
                                        Console.WriteLine("Special Moves");
                                        Console.WriteLine("Power Wave: QCF+LP/QCF+MP");
                                        Console.WriteLine("Round Wave: QCF+HP");
                                        Console.WriteLine("Quick Burn: QCB+LP");
                                        Console.WriteLine("Burning Knuckle: QCB+MP/QCB+HP");
                                        Console.WriteLine("Power Charge: QCF+K");
                                        Console.WriteLine("Crack Shoot: QCB+K");
                                        Console.WriteLine("Rising Tackle: FDDF+P");

                                        Console.WriteLine("\nSuper Arts");
                                        Console.WriteLine("LVL1 Buster Wolf: QCFx2+K");
                                        Console.WriteLine("LVL2 Power Geyser: QCBx2+P");
                                        Console.WriteLine("- Twin Geyser: PP (After Power Geyser connects)");
                                        Console.WriteLine(" - Triple Geyser: PP (After Twin Geyser connects)");
                                        Console.WriteLine("LVL3 Rising Fang: QCFx2+P");
                                        break;
                                    case 3:
                                        Console.WriteLine("Terry Combos");
                                        Console.WriteLine("1. CR.LK > CR.LP > QCF+LP/QCF+LK");
                                        Console.WriteLine("2. CR.LK > LP > LP > LVL1/LVL2/LVL3 (QCFx2+K/QCBx2+P/QCFx2+P)");
                                        Console.WriteLine("3. MK > LK > QCF+LK > CR.LP > LP > FDDF+HP");
                                        Console.WriteLine("4. CR.MK,HK > QCB+MK > LVL1 (QCFx2+K)");
                                        Console.WriteLine("5. HP > QCF+HK > QCB+HK > FDDF+HP");
                                        Console.WriteLine("6. HP > QCF+HK > QCB+KK > FDDF+LP > LVL3 (QCFx2+P)");
                                        break;
                                    default:
                                        Console.WriteLine("Please enter the coorect option.");
                                        break;
                                }
                            }
                            else
                            {
                                Console.WriteLine("Please select the correct number!");
                            }
                            break;

                        case "MAI":
                            Console.WriteLine("\nDifficulty: Intermediate");
                            Console.WriteLine("Mai is a rushdown character that's shows her ninja skills");
                            Console.WriteLine("\nWhat would you like to learn about Mai? \n1.Key Moves \n2.Special Moves/Super Arts \n3.Combos");
                            Console.WriteLine("\nInput: ");
                            if (Int32.TryParse(Console.ReadLine(), out sf6_option))
                            {
                                switch (sf6_option)
                                {
                                    case 1:
                                        Console.WriteLine("Mai Key Moves");
                                        Console.WriteLine("Crouching Forward: CR.MK");
                                        Console.WriteLine("Standing Strong: MP");
                                        Console.WriteLine("Standing Forward: MK");
                                        Console.WriteLine("Standing Fierce: HP");
                                        Console.WriteLine("Standing Roundhouse: HK");
                                        Console.WriteLine("Senkotsu Uchi: F+MP");
                                        Console.WriteLine("Hien Ren Kyaku: LK > LK > LK");
                                        Console.WriteLine("Shiranui Gourin: F+LP+LK");
                                        Console.WriteLine("Fuusha Kuzushi: B+LP+LK");
                                        Console.WriteLine("Yume Zakura: LP+LK (During a jump)");
                                        break;
                                    case 2:
                                        Console.WriteLine("Mai Special Moves/Super Arts");
                                        Console.WriteLine("Special Moves");
                                        Console.WriteLine("Kachousen: QCF+P");
                                        Console.WriteLine("- Midare Kachousen: F+P");
                                        Console.WriteLine("Ryuuenbu: QCB+P");
                                        Console.WriteLine("Hissatsu Shinobi Bachi: QCF+K");
                                        Console.WriteLine("Hishou Ryuuenjin: FDDF+K");
                                        Console.WriteLine("Musasabi no Mai: QCB+P");

                                        Console.WriteLine("\nSuper Arts");
                                        Console.WriteLine("LVL1 Kagerou no Mai: QCFx2+P");
                                        Console.WriteLine("LVL2 Chou Hissatsu Shinobu Bachi: QCF+K");
                                        Console.WriteLine("LVL3 Shiranui Ryuu: Enbu Ada Zakura: QCBx2+P");
                                        break;
                                    case 3:
                                        Console.WriteLine("Mai Combos");
                                        Console.WriteLine("1. CR.LP > CR.LP > CR.LP > QCF+LK");
                                        Console.WriteLine("2. LP > LP > LP > QCB+PP > FDDF+HK");
                                        Console.WriteLine("3. CR.MP > QCF+KK > MP > QCB+PP > LVL2 (QCFx2+K)");
                                        Console.WriteLine("4. CR.MP > QCB+PP > LVL1 (QCFx2+P)");
                                        Console.WriteLine("5. HP > QCB+HP > QCF+LK");
                                        Console.WriteLine("6. CR.HP > LP > QCF+KK > MP > QCB+P");
                                        break;
                                    default:
                                        Console.WriteLine("Please enter the coorect option.");
                                        break;
                                }
                            }
                            else
                            {
                                Console.WriteLine("Please select the correct number!");
                            }
                            break;

                        //Hard to learn characters
                        case "CHUN LI":
                            Console.WriteLine("\nDifficulty: Hard");
                            Console.WriteLine("Chun Li is a footise based character that looks opponents mistakes and counters them for it.");
                            Console.WriteLine("\nWhat would you like to learn about Chun Li? \n1.Key Moves \n2.Special Moves/Super Arts \n3.Combos");
                            Console.WriteLine("\nInput: ");
                            if (Int32.TryParse(Console.ReadLine(), out sf6_option))
                            {
                                switch (sf6_option)
                                {
                                    case 1:
                                        Console.WriteLine("Chun Li Key Moves");
                                        Console.WriteLine("Standing Fierce: HP");
                                        Console.WriteLine("Crouching Strong: CR.MP");
                                        Console.WriteLine("Crouching Fierce: CR.HP");
                                        Console.WriteLine("Standing Forward: MK");
                                        Console.WriteLine("Standing Roundhouse: HK");
                                        Console.WriteLine("Crouching Forward: CR.MK");
                                        Console.WriteLine("Swift Thurst: B+MP/F+MP");
                                        Console.WriteLine("Hakkei: B+HP");
                                        Console.WriteLine("Water Lotus Fist: DF+HP");
                                        Console.WriteLine("Yokusen Kick: F+HK");
                                        Console.WriteLine("Yoso Kick: D+MK (During a jump)");
                                        Console.WriteLine("Koshuto: F+LP+LK");
                                        Console.WriteLine("Taiji Fan: B+LP+LK");
                                        Console.WriteLine("Ryuseiraku: LP+LP (During a jump)");
                                        break;
                                    case 2:
                                        Console.WriteLine("Character_Name Special Moves/Super Arts");
                                        Console.WriteLine("Special Moves");
                                        Console.WriteLine("Kikoken: BF+P (Hold Back for 2 secs then F+P)");
                                        Console.WriteLine("Air Hundred Lighting Kicks/Hundred Lighting Kicks (HLK): QCF+K");
                                        Console.WriteLine("- Lighting Kick Barrage: KK (After OD HLK)");
                                        Console.WriteLine("Spinning Bird Kick: DU+K (Hold down for 2 secs then U+K)");
                                        Console.WriteLine("Hazanshu: QCB+K");
                                        Console.WriteLine("Tensho Kicks: DD+K");
                                        Console.WriteLine("Serenity Stream: QCB+P");
                                        Console.WriteLine("- Orchid Palm: LP (During Serenity Stream)");
                                        Console.WriteLine("- Snake Strike MP (During Serenity Stream)");
                                        Console.WriteLine("- Lotus Fist: HP (During Serenity Stream)");
                                        Console.WriteLine("- Forward Strike: LK (During Serenity Stream)");
                                        Console.WriteLine("- Senpu Kick: MK (During Serenity Stream)");
                                        Console.WriteLine("- Tenku Kick: HK (During Serenity Stream)");

                                        Console.WriteLine("\nSuper Arts");
                                        Console.WriteLine("LVL1 Air Kikosho/Kikosho: QCFx2+P");
                                        Console.WriteLine("LVL2 Hoyoku-sen: QCFx2+K");
                                        Console.WriteLine("LVL3 Soten Ranka: QCBx2+K");
                                        break;
                                    case 3:
                                        Console.WriteLine("Chun Li Combos");
                                        Console.WriteLine("1. CR.LK > LP > LK > QCF+MK");
                                        Console.WriteLine("2. LP > MP > CR.MP > DU+KK > QCF+LK > LVL3 (QCBx2+K)");
                                        Console.WriteLine("3. MP > CR.MP > DU+MK (Hold down for 2 secs and pres U+MK)");
                                        Console.WriteLine("4. MK > QCB+P,HK > J.HP,HP > LVL1 (QCFx2+P)");
                                        Console.WriteLine("5. B+HP > QCF+HK > LVL1 (QCFx2+P)");
                                        Console.WriteLine("6. HK > QCB+P,MK > BF+PP > LK > QCF+MK");
                                        break;
                                    default:
                                        Console.WriteLine("Please enter the coorect option.");
                                        break;
                                }
                            }
                            else
                            {
                                Console.WriteLine("Please select the correct number!");
                            }
                            break;

                        case "JURI":
                            Console.WriteLine("\nDifficulty: Hard");
                            Console.WriteLine("Juri is a crazy thrillseeker that focuses on pressure and overwhelming you.");
                            Console.WriteLine("\nWhat would you like to learn about Juri? \n1.Key Moves \n2.Special Moves/Super Arts \n3.Combos");
                            Console.WriteLine("\nInput: ");
                            if (Int32.TryParse(Console.ReadLine(), out sf6_option))
                            {
                                switch (sf6_option)
                                {
                                    case 1:
                                        Console.WriteLine("Juri Key Moves");
                                        Console.WriteLine("Standing Strong: MP");
                                        Console.WriteLine("Standing Fierce: HP");
                                        Console.WriteLine("Standing Forward: MK");
                                        Console.WriteLine("Standing Roundhouse: HK");
                                        Console.WriteLine("Crouching Strong: CR.MP");
                                        Console.WriteLine("Crouching Fierce: CR.HP");
                                        Console.WriteLine("Crouching Forward: CR.MK");
                                        Console.WriteLine("Crouching Roundhouse: CR.HK");
                                        Console.WriteLine("Kyosesho: F+MP");
                                        Console.WriteLine("Senkai Kick: F+MK");
                                        Console.WriteLine("Renko Kicks: F+HP");
                                        Console.WriteLine("Korenzan: B+HK");
                                        Console.WriteLine("Death Crest: MP > B+HP > HP");
                                        Console.WriteLine("Spider Fang Throw: F+LP+LK");
                                        Console.WriteLine("Shadow Kick Throw: B+LP+LK");
                                        Console.WriteLine("Zanka-sen: LP+LK (During a jump)");
                                        break;
                                    case 2:
                                        Console.WriteLine("Juri Special Moves/Super Arts");
                                        Console.WriteLine("Special Moves");
                                        Console.WriteLine("Fuhajin: QCB+K");
                                        Console.WriteLine("Saihasho: QCF+LK (LK to activate)");
                                        Console.WriteLine("Ankensatsu: QCF+MK (MK to activate)");
                                        Console.WriteLine("Go Ohsatsu: QCF+HK (HK to activate)");
                                        Console.WriteLine("Tensenrin: FDDF+P");
                                        Console.WriteLine("Shiku-sen: QCB+K (During a forward jump)");
                                        Console.WriteLine("- Shiren-sen: K (After Shiku-sen)");

                                        Console.WriteLine("\nSuper Arts");
                                        Console.WriteLine("LVL1 Sakkai Fuhazan: QCFx2+K");
                                        Console.WriteLine("LVL2 Feng Shui Engine: QCBx2+P");
                                        Console.WriteLine("LVL3 Kaisen Dankai Raku: QCBx2+K");
                                        break;
                                    case 3:
                                        Console.WriteLine("Juri Combos");
                                        Console.WriteLine("1. CR.LK > LP > LK > FDDF+HP");
                                        Console.WriteLine("2. LP > MK > QCB+HK > LVL1 (QCFx2+K)");
                                        Console.WriteLine("3. MP > CR.MP > FDDF+LP");
                                        Console.WriteLine("4. CR.MP > MK > QCF+MK > F+MP > QCF+MK,HK > LVL1 (QCFx2+K)");
                                        Console.WriteLine("5. HP > QCB+HK > FDDF+HP");
                                        Console.WriteLine("6. F+HP > QCF+MK > F+MP > QCF+MK,HK");
                                        break;
                                    default:
                                        Console.WriteLine("Please enter the coorect option.");
                                        break;
                                }
                            }
                            else
                            {
                                Console.WriteLine("Please select the correct number!");
                            }
                            break;

                        case "DHALSIM":
                            Console.WriteLine("\nDifficulty: Hard");
                            Console.WriteLine("Dhalsim is a zoning character that thrives on long range along with yoga as well.");
                            Console.WriteLine("\nWhat would you like to learn about Dhalsim? \n1.Key Moves \n2.Special Moves/Super Arts \n3.Combos");
                            Console.WriteLine("\nInput: ");
                            if (Int32.TryParse(Console.ReadLine(), out sf6_option))
                            {
                                switch (sf6_option)
                                {
                                    case 1:
                                        Console.WriteLine("Dhalsim Key Moves");
                                        Console.WriteLine("Standing Strong: MP");
                                        Console.WriteLine("Standing Fierce: HP");
                                        Console.WriteLine("Crouching Strong: CR.MP");
                                        Console.WriteLine("Crouching Fierce: CR.HP");
                                        Console.WriteLine("Standing Short: LK");
                                        Console.WriteLine("Standing Forward: MK");
                                        Console.WriteLine("Standing Roundhouse: HK");
                                        Console.WriteLine("Crouching Short: CR.LK");
                                        Console.WriteLine("Crouching Forward: CR.MK");
                                        Console.WriteLine("Crouching Roundhouse: CR.HK");
                                        Console.WriteLine("Yoga Uppercut: B+MP");
                                        Console.WriteLine("Yoga Lance: B+HP");
                                        Console.WriteLine("Nirvana Punch: DB+HP");
                                        Console.WriteLine("Diving Kick: B+MK");
                                        Console.WriteLine("Yoga Mountain: B+HK");
                                        Console.WriteLine("Yoga Mummy: D+LP (During a jump)");
                                        Console.WriteLine("Drill Kick: D+K (During a jump)");
                                        Console.WriteLine("Thrust Kick: DB+MK");
                                        Console.WriteLine("Yoga Smash: F+LP+LK");
                                        Console.WriteLine("Yoga Throw: B+LP+LK");
                                        Console.WriteLine("Yoga Splash: D+LP+LK");
                                        break;
                                    case 2:
                                        Console.WriteLine("Dhalsim Special Moves/Super Arts");
                                        Console.WriteLine("Special Moves");
                                        Console.WriteLine("Yoga Fire: QCF+P");
                                        Console.WriteLine("Yoga Arch: QCF+K");
                                        Console.WriteLine("Yoga Flame: HCB+P");
                                        Console.WriteLine("Yoga Blast: HCB+K");
                                        Console.WriteLine("Yoga Comet: HCB+P (During a jump)");
                                        Console.WriteLine("Aerial Yoga Float/Yoga Float: D+KK/DF+KK");
                                        Console.WriteLine("Aerial Yoga Teleport/Yoga Teleport: F+PPP/B+PPP/F+KKK/B+KKK");

                                        Console.WriteLine("\nSuper Arts");
                                        Console.WriteLine("LVL1 Yoga Inferno: QCFx2+P");
                                        Console.WriteLine("LVL2 Yoga Sunburst: QCBx2+K");
                                        Console.WriteLine("LVL3 Merciless Yoga: QCFx2+K");
                                        break;
                                    case 3:
                                        Console.WriteLine("Dhalsim Combos");
                                        Console.WriteLine("1. LP > CR.LP > QCF+PP");
                                        Console.WriteLine("2. DB+LK > CR.LP > CR.LP > LVL1 (QCFx2+P)");
                                        Console.WriteLine("3. CR.MP/DB+MK > HCB+LP");
                                        Console.WriteLine("4. CR.MP > HCB+PP > LVL1 (QCFx2+P)");
                                        Console.WriteLine("5. DB+MK > HCB+PP > CR.HK");
                                        Console.WriteLine("6. DB+MK > HCB+PP > HK > LVL1 (QCFx2+P)");
                                        break;
                                    default:
                                        Console.WriteLine("Please enter the coorect option.");
                                        break;
                                }
                            }
                            else
                            {
                                Console.WriteLine("Please select the correct number!");
                            }
                            break;

                        case "JP":
                            Console.WriteLine("\nDifficulty: Hard");
                            Console.WriteLine("JP with his gentleman attire, focus on trying to keep the opponent in far range.");
                            Console.WriteLine("\nWhat would you like to learn about JP? \n1.Key Moves \n2.Special Moves/Super Arts \n3.Combos");
                            Console.WriteLine("\nInput: ");
                            if (Int32.TryParse(Console.ReadLine(), out sf6_option))
                            {
                                switch (sf6_option)
                                {
                                    case 1:
                                        Console.WriteLine("JP Key Moves");
                                        Console.WriteLine("Standing Strong: MP");
                                        Console.WriteLine("Standing Fierce: HP");
                                        Console.WriteLine("Crouching Strong: CR.MP");
                                        Console.WriteLine("Crouching Fierce: CR.HP");
                                        Console.WriteLine("Standing Forward: MK");
                                        Console.WriteLine("Standing Roundhouse: HK");
                                        Console.WriteLine("Crouching Forward: CR.MK");
                                        Console.WriteLine("Guillotinna: F+MK");
                                        Console.WriteLine("Malice: DF+HP");
                                        Console.WriteLine("Bylina: F+HK");
                                        Console.WriteLine("Grom Strelka: B+MP > MP");
                                        Console.WriteLine("Zilant: HK > HP");
                                        Console.WriteLine("Ravina: F+LP+LK");
                                        Console.WriteLine("Uragan: B+LP+LK");
                                        Console.WriteLine("Tornado: LP+LP (During a jump)");
                                        break;
                                    case 2:
                                        Console.WriteLine("JP Special Moves/Super Arts");
                                        Console.WriteLine("Special Moves");
                                        Console.WriteLine("Triglav: DD+P");
                                        Console.WriteLine("Stribog: QCF+P");
                                        Console.WriteLine("Departure: QCB+P");
                                        Console.WriteLine("- Departure-Window: QCB+LP/QCB+MP (While Departure is out)");
                                        Console.WriteLine("- Departure-Shadow: QCB+HP (While Departure is out)");
                                        Console.WriteLine("Amnesia: DD+K");
                                        Console.WriteLine("Torbalan: QCF+K");
                                        Console.WriteLine("Embrace: QCB+K");

                                        Console.WriteLine("\nSuper Arts");
                                        Console.WriteLine("LVL1 Chornobog: QCFx2+P");
                                        Console.WriteLine("LVL2 Lovushka: QCBx2+P");
                                        Console.WriteLine("LVL3 Interdiction: QCFx2+K");
                                        break;
                                    case 3:
                                        Console.WriteLine("JP Combos");
                                        Console.WriteLine("1. CR.LK > CR.LP > LP > QCF+LP");
                                        Console.WriteLine("2. CR.LK > CR.LP > LP > QCF+LP > LVL1/LVL3 (QCFx2+P/QCFx2+K)");
                                        Console.WriteLine("3. B+MP > CR.LP > LP > QCF+LP");
                                        Console.WriteLine("4. B+MP,MP > QCF+PP > DD+MP > LVL3 (QCFx2+K)?");
                                        Console.WriteLine("5. HK > CR.MP > QCF+MP");
                                        Console.WriteLine("6. F+HK > QCF+MK > LVL3 (QCFx2+K)");
                                        break;
                                    default:
                                        Console.WriteLine("Please enter the coorect option.");
                                        break;
                                }
                            }
                            else
                            {
                                Console.WriteLine("Please select the correct number!");
                            }
                            break;

                        case "ZANGEIF":
                            Console.WriteLine("\nDifficulty: Hard");
                            Console.WriteLine("Zangief is close range grappler where his main focus is to put the graps on you for muscle power.");
                            Console.WriteLine("\nWhat would you like to learn about Zangief? \n1.Key Moves \n2.Special Moves/Super Arts \n3.Combos");
                            Console.WriteLine("\nInput: ");
                            if (Int32.TryParse(Console.ReadLine(), out sf6_option))
                            {
                                switch (sf6_option)
                                {
                                    case 1:
                                        Console.WriteLine("Zangief Key Moves");
                                        Console.WriteLine("Standing Strong: MP");
                                        Console.WriteLine("Standing Fierce: HP");
                                        Console.WriteLine("Crouching Strong: CR.MP");
                                        Console.WriteLine("Crouching Fierce: CR.HP");
                                        Console.WriteLine("Standing Forward: MK");
                                        Console.WriteLine("Standing Roundhouse: HK");
                                        Console.WriteLine("Crouching Forward: CR.MK");
                                        Console.WriteLine("Crouching Roundhouse: CR.HK");
                                        Console.WriteLine("Hellstab: DF+MP");
                                        Console.WriteLine("Knee Hammer: F+MK");
                                        Console.WriteLine("Headbutt: F+HP");
                                        Console.WriteLine("Cyclone Wheel Kick: F+HK");
                                        Console.WriteLine("Smetana Dropkick: DF+HK");
                                        Console.WriteLine("Machine Gun Chops: MP > MP > MP");
                                        Console.WriteLine("Power Stomps: DD+MK > MK > MK");
                                        Console.WriteLine("Bodyslam: LP+LK");
                                        Console.WriteLine("Capture Suplex: B+LP+LK");
                                        Console.WriteLine("German Suplex: F+LP+LK");
                                        Console.WriteLine("Spinebuster: DF+LP+LK");
                                        Console.WriteLine("Russian Drop: DB+LP+LK");
                                        Console.WriteLine("Brain Buster: D+LP+LK");
                                        break;
                                    case 2:
                                        Console.WriteLine("Zangief Special Moves/Super Arts");
                                        Console.WriteLine("Special Moves");
                                        Console.WriteLine("Double Lariat: PP");
                                        Console.WriteLine("Screw Piledriver: 360 Motion+P");
                                        Console.WriteLine("Borscht Dynamite: 360 Motion+K (During a jump)");
                                        Console.WriteLine("Russian Suplex: HCB+K");
                                        Console.WriteLine("Siberian Express: HCB+K (When far from opponent)");
                                        Console.WriteLine("Tundra Storm: DD+HK");

                                        Console.WriteLine("\nSuper Arts");
                                        Console.WriteLine("LVL1 Air Russian Slam: QCFx2+K");
                                        Console.WriteLine("LVL2 Cyclone Lariat: QCFx2+P");
                                        Console.WriteLine("LVL3 Bolshoi Storm Buster: 360 Motionx2+P");
                                        break;
                                    case 3:
                                        Console.WriteLine("Zangief Combos");
                                        Console.WriteLine("1. CR.LK > CR.LP > PP");
                                        Console.WriteLine("2. CR.LK > CR.LP > PPP > LVL2 (QCFx2+P)");
                                        Console.WriteLine("3. CR.MP + PP");
                                        Console.WriteLine("4. DD+MK > CR.LK > CR.LP > PPP");
                                        Console.WriteLine("5. F+HP > PP");
                                        Console.WriteLine("6. F+HP > CR.LP > PPP");
                                        break;
                                    default:
                                        Console.WriteLine("Please enter the coorect option.");
                                        break;
                                }
                            }
                            else
                            {
                                Console.WriteLine("Please select the correct number!");
                            }
                            break;

                        case "RASHID":
                            Console.WriteLine("\nDifficulty: Hard");
                            Console.WriteLine("Rashid is a rushdown/setup character that expresses his pressure and mixups with his wind and parkout");
                            Console.WriteLine("\nWhat would you like to learn about Rashid? \n1.Key Moves \n2.Special Moves/Super Arts \n3.Combos");
                            Console.WriteLine("\nInput: ");
                            if (Int32.TryParse(Console.ReadLine(), out sf6_option))
                            {
                                switch (sf6_option)
                                {
                                    case 1:
                                        Console.WriteLine("Rashid Key Moves");
                                        Console.WriteLine("Standing Strong: MP");
                                        Console.WriteLine("Standing Fierce: HP");
                                        Console.WriteLine("Standing Forward: MK");
                                        Console.WriteLine("Standing Roundhouse: HK");
                                        Console.WriteLine("Crouching Strong: CR.MP");
                                        Console.WriteLine("Crouching Fierce: CR.HP");
                                        Console.WriteLine("Crouching Forward: CR.MK");
                                        Console.WriteLine("Flapping Spin: F+MP");
                                        Console.WriteLine("Beak Assault: F+HP");
                                        Console.WriteLine("Rising Kick: MP > HK");
                                        Console.WriteLine("Riding Glider: F+LP+LK");
                                        Console.WriteLine("Sunset Drop: B+LP+LK");
                                        Console.WriteLine("Desert Slider: LP+LK");
                                        break;
                                    case 2:
                                        Console.WriteLine("Rashid Special Moves/Super Arts");
                                        Console.WriteLine("Special Moves");
                                        Console.WriteLine("Spinning Mixer: QCF+P");
                                        Console.WriteLine("Eagle Spike: QCB+K");
                                        Console.WriteLine("Whirlwind Shot: QCF+K");
                                        Console.WriteLine("Arabian Cyclone: QCB+P");
                                        Console.WriteLine("- Wing Stroke: B+K (During Arabian Cyclone)");
                                        Console.WriteLine("- Rolling Assault: F+K (During Arabian Cyclone)");
                                        Console.WriteLine(" - Nail Assault: K (During Rolling Assault)");
                                        Console.WriteLine("Arabian Skyhigh: QCB+K (During a forward jump)");
                                        Console.WriteLine("Run: FF (Hold Second F)");
                                        Console.WriteLine("- Backup: F+P (During Run)");
                                        Console.WriteLine("- Tempest Moon: F+K (During Run)");
                                        Console.WriteLine("Side Flip: F+KK");
                                        Console.WriteLine("- Front Flip: F+PP/B+PP");

                                        Console.WriteLine("\nSuper Arts");
                                        Console.WriteLine("LVL1 Super Rashid Kick: QCFx2+K");
                                        Console.WriteLine("LVL2 Ysaar: QCBx2+K");
                                        Console.WriteLine("LVL3 Altair: QCFx2+P");
                                        break;
                                    case 3:
                                        Console.WriteLine("Rashid Combos");
                                        Console.WriteLine("1. CR.LK > CR.LP > LP > QCF+LP/QCF+MP");
                                        Console.WriteLine("2. CR.LK > LP > LP > LVL1 (QCFx2+K)");
                                        Console.WriteLine("3. CR.MP > LK > QCB+LK");
                                        Console.WriteLine("4. MP,HK > QCB+HP,B+K > J.MP > LVL1 (QCFx2+K)");
                                        Console.WriteLine("5. HP > QCB+MK");
                                        Console.WriteLine("6. HP > QCB+PP,F+K,K > LVL3 (QCFx2+P)");
                                        break;
                                    default:
                                        Console.WriteLine("Please enter the coorect option.");
                                        break;
                                }
                            }
                            else
                            {
                                Console.WriteLine("Please select the correct number!");
                            }
                            break;

                        case "AKI":
                            Console.WriteLine("\nDifficulty: Hard");
                            Console.WriteLine("AKI as cool as she looks, inflicits poisons with her rushdown and setups.");
                            Console.WriteLine("\nWhat would you like to learn about AKI? \n1.Key Moves \n2.Special Moves/Super Arts \n3.Combos");
                            Console.WriteLine("\nInput: ");
                            if (Int32.TryParse(Console.ReadLine(), out sf6_option))
                            {
                                switch (sf6_option)
                                {
                                    case 1:
                                        Console.WriteLine("AKI Key Moves");
                                        Console.WriteLine("Standing Strong: MP");
                                        Console.WriteLine("Standing Fierce: HP");
                                        Console.WriteLine("Standing Forward: MK");
                                        Console.WriteLine("Standing Roundhouse: HK");
                                        Console.WriteLine("Crouching Strong: CR.MP");
                                        Console.WriteLine("Crouching Fierce: CR.HP");
                                        Console.WriteLine("Crouching Forward: CR.MK");
                                        Console.WriteLine("Crouching Roundhouse: CR.HK");
                                        Console.WriteLine("Pu Lao: DF+MP");
                                        Console.WriteLine("Chi Wen: F+HP");
                                        Console.WriteLine("Qiu Niu: F+HK");
                                        Console.WriteLine("Hun Dun: LP > LP");
                                        Console.WriteLine("Qiong Qi: HP > HP");
                                        Console.WriteLine("Whisper: F+LP+LK");
                                        Console.WriteLine("Gluttony: B+LP+LK");
                                        break;
                                    case 2:
                                        Console.WriteLine("Character_Name Special Moves/Super Arts");
                                        Console.WriteLine("Special Moves");
                                        Console.WriteLine("Nightshade Pulse: QCB+LP");
                                        Console.WriteLine("- Nightshade Chaser: F+P (During Nightshade Pulse)");
                                        Console.WriteLine("Orchide Spring: QCB+MP");
                                        Console.WriteLine("Toxic Wreath: QCB+HP");
                                        Console.WriteLine("Serpent Lash: QCF+P");
                                        Console.WriteLine("Cruel Fate: QCB+K");
                                        Console.WriteLine("Snake Step: QCF+K");
                                        Console.WriteLine("Sinister Slide: D+PP");
                                        Console.WriteLine("- Venomous Fang: P (During Sinister Slide)");
                                        Console.WriteLine("- Heel Strike: K (During Sinister Slide)");
                                        Console.WriteLine("- Entrapment: LP+LK (During Sinister Slide)");

                                        Console.WriteLine("\nSuper Arts");
                                        Console.WriteLine("LVL1 Deadly Implication: QCFx2+K");
                                        Console.WriteLine("LVL2 Tainted Talons: QCBx2+P");
                                        Console.WriteLine("LVL3 Claws of Ya Zi: QCFx2+P");
                                        break;
                                    case 3:
                                        Console.WriteLine("Character_Name Combos");
                                        Console.WriteLine("1. LK > CR.LP > CR.LP > QCB+HP");
                                        Console.WriteLine("2. CR.LK > CR.LP > CR.LP > QCF+HP > LVL3 (QCFx2+P)");
                                        Console.WriteLine("3. MK > MP > QCB+LP,F+LP");
                                        Console.WriteLine("4. MK > MP > QCB+PP,F+P > LVL 2 (QCBx2+P)");
                                        Console.WriteLine("5. F+HK > CR.LP > CR.LP > QCF+HP");
                                        Console.WriteLine("6. HP,HP > QCF+PP > QCF+HP > LVL1/LVL2/LVL3 (QCFx2+K/QCBx2+P/QCFx2P)");
                                        break;
                                    default:
                                        Console.WriteLine("Please enter the coorect option.");
                                        break;
                                }
                            }
                            else
                            {
                                Console.WriteLine("Please select the correct number!");
                            }
                            break;

                        case "ED":
                            Console.WriteLine("\nDifficulty: Hard");
                            Console.WriteLine("Ed trained by Balrog and leader of Neo-Shadaloo, controls spacing along with applying pressure.");
                            Console.WriteLine("\nWhat would you like to learn about Ed? \n1.Key Moves \n2.Special Moves/Super Arts \n3.Combos");
                            Console.WriteLine("\nInput: ");
                            if (Int32.TryParse(Console.ReadLine(), out sf6_option))
                            {
                                switch (sf6_option)
                                {
                                    case 1:
                                        Console.WriteLine("Ed Key Moves");
                                        Console.WriteLine("Psycho Knuckle: Hold HP");
                                        Console.WriteLine("Cobra Punch: F+HP");
                                        Console.WriteLine("Flicker Combination: LK + LK + LK");
                                        Console.WriteLine("Body Blow Combination: MP > HP");
                                        Console.WriteLine("Hitman Combination: MK > MK > HP");
                                        Console.WriteLine("Low Smash Combination: D+HK > HP");
                                        Console.WriteLine("Face Buster: F+LP+LK");
                                        Console.WriteLine("Rib Crusher: B+LP+LK");
                                        break;
                                    case 2:
                                        Console.WriteLine("Ed Special Moves/Super Arts");
                                        Console.WriteLine("Special Moves");
                                        Console.WriteLine("Psycho Spark: QCF+P");
                                        Console.WriteLine("- Psycho Shoot: F+P (During Spark)");
                                        Console.WriteLine("Psycho Uppercut: FDDF+P");
                                        Console.WriteLine("Psycho Blitz: QCB+P");
                                        Console.WriteLine("Psycho Flicker: QCF+K");
                                        Console.WriteLine("Kill Rush (Forward) (KRF): F+KK");
                                        Console.WriteLine("- Kill Switch Break: F+P (During first half of KRF)");
                                        Console.WriteLine("- Kill Switch Chaser: F+P (During latter of KRF)");
                                        Console.WriteLine("Kill Rush (Backward): B+KK");

                                        Console.WriteLine("\nSuper Arts");
                                        Console.WriteLine("LVL1 Psycho Storm: QCFx2+K");
                                        Console.WriteLine("LVL2 Psycho Cannon: QCBx2+P");
                                        Console.WriteLine("LVL3 Psycho Chamber: QCFx2+P");
                                        break;
                                    case 3:
                                        Console.WriteLine("Ed Combos");
                                        Console.WriteLine("1. CR.LP > LP > LP > QCB+MP");
                                        Console.WriteLine("2. CR.LP > LP > LP > QCB+MP > LVL3 (QCFx2+P)");
                                        Console.WriteLine("3. CR.MK > MP,HP > QCB+HP/FDDF+HP");
                                        Console.WriteLine("4. CR.MK > MP,HK > QCF+KK > FDDF+LP > QCB+LP");
                                        Console.WriteLine("5. HP > CR.LK > FDDF+MP");
                                        Console.WriteLine("6. HP (HOLD) > HP > QCF+KK > FDDF+HP > QCB+HP > LVL3 (QCFx2+P)");
                                        break;
                                    default:
                                        Console.WriteLine("Please enter the coorect option.");
                                        break;
                                }
                            }
                            else
                            {
                                Console.WriteLine("Please select the correct number!");
                            }
                            break;

                        case "M.BISON":
                            Console.WriteLine("\nDifficulty: Hard");
                            Console.WriteLine("M.Bison the former head of Shadaloo with amnesia, focuses on defensive and applying pressure.");
                            Console.WriteLine("\nWhat would you like to learn about M.Bison? \n1.Key Moves \n2.Special Moves/Super Arts \n3.Combos");
                            Console.WriteLine("\nInput: ");
                            if (Int32.TryParse(Console.ReadLine(), out sf6_option))
                            {
                                switch (sf6_option)
                                {
                                    case 1:
                                        Console.WriteLine("M.Bison Key Moves");
                                        Console.WriteLine("Standing Strong: MP");
                                        Console.WriteLine("Standing Fierce: HP");
                                        Console.WriteLine("Standing Forward: MK");
                                        Console.WriteLine("Standing Roundhouse: HK");
                                        Console.WriteLine("Crouching Strong: CR.MP");
                                        Console.WriteLine("Crouching Fierce: CR.HP");
                                        Console.WriteLine("Crouching Forward: CR.MK");
                                        Console.WriteLine("Crouching Roundhouse: CR.HK");
                                        Console.WriteLine("Psycho Hammer: F+HP");
                                        Console.WriteLine("Evil Knee: B+HK");
                                        Console.WriteLine("Hover Kick: DF+HK");
                                        Console.WriteLine("Shadow Hammer: MP > F+HP");
                                        Console.WriteLine("Deadly Throw: F+LP+LK");
                                        Console.WriteLine("Death Tower: B+LP+LK");
                                        break;
                                    case 2:
                                        Console.WriteLine("M.Bison Special Moves/Super Arts");
                                        Console.WriteLine("Special Moves");
                                        Console.WriteLine("Psycho Crusher Attack: BF+P (Hold back for 2 secs then F+P)");
                                        Console.WriteLine("Double Knee Press: QCF+K");
                                        Console.WriteLine("Backfist Combo: QCB+P");
                                        Console.WriteLine("Shadown Rise: DU+K (Hold down for secs then U+K)");
                                        Console.WriteLine("- Head Press: K (During Shadow Rise)");
                                        Console.WriteLine(" - Somersault Skull Diver: P (After Head Press connects)");
                                        Console.WriteLine("- Devil Reverse (During Shadow Rise)");

                                        Console.WriteLine("\nSuper Arts");
                                        Console.WriteLine("LVL1 Knee Press Nightmare: QCFx2+K");
                                        Console.WriteLine("LVL2 Psycho Punisher: QCBx2+K");
                                        Console.WriteLine("LVL3 Unlimited Psycho Crusher: QCFx2+P");
                                        break;
                                    case 3:
                                        Console.WriteLine("M.Bison Combos");
                                        Console.WriteLine("1. CR.LK > CR.LP > LP/CR.LP > QCF+LK");
                                        Console.WriteLine("2. CR.LK > CR.LP > LP/CR.LP > QCB+PP > LVL2 (QCBx2+K)");
                                        Console.WriteLine("3. MP > CR.MP > BF+MP (Hold Back for 2 secs then F+MP)");
                                        Console.WriteLine("4. CR.MP/CR.MK > QCB+MP/QCF+MK");
                                        Console.WriteLine("5. HP > LK > QCB+LP");
                                        Console.WriteLine("6. B+HK > LK > QCB+LP/QCF+LK");
                                        break;
                                    default:
                                        Console.WriteLine("Please enter the coorect option.");
                                        break;
                                }
                            }
                            else
                            {
                                Console.WriteLine("Please select the correct number!");
                            }
                            break;
                    }
                    break;
                }
                break;
            }
        }

        /*public static void MK1_Characters()
    	{
    
    	}
    	*/
    }
}

