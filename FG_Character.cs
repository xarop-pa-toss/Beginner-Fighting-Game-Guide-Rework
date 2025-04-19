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
            bool repeatcode = true;
            bool repeatcharacter = true;
            bool repeatinfo = true;
            while (repeatcode)
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

                while (repeatcharacter)
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

                    while (repeatinfo)
                    {
                        switch (tk8_fighter)
                        {
                            //Easy to learn
                            case "KUMA":
                                Console.WriteLine("\nDifficulty: Easy");
                                Console.WriteLine("Kuma is the joke character of tekken 8 with good range, mixups, and gimmicks with their stances.");
                                Console.WriteLine("\nWhat would you like to learn about Kuma? \n1.Key Moves \n2.Basic Combos \n3.Strategy");
                                Console.WriteLine("\nInput: ");
                                tk8_option = Convert.ToInt32(Console.ReadLine());
                                if (tk8_option == 1)
                                {
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
                                    return;
                                }
                                if (tk8_option == 2)
                                {
                                    Console.WriteLine("Kuma Basic Combos:");
                                    Console.WriteLine("1. DF+2,1 > B+2,2,1 > F 1+2,1+2");
                                    Console.WriteLine("2. F 1+2,1+2 > U+2 > B+2,2,1");
                                    Console.WriteLine("3. DF 2,1 > F+4 > B+2,1 > F 1+2,1+2 > U+2 > B+1");
                                    Console.WriteLine("4. DF 2,1 > B+2,2,1 > U+2 > QCF+2,1");
                                    Console.WriteLine("5. DF+2,1 > B+,2,2,1 > U+2 > HEAT > HEAT SMASH");
                                    return;
                                }
                                if (tk8_option == 3)
                                {
                                    Console.WriteLine("\nLook for whiff punishes that players throw out and punish them with DF+2,1");
                                    Console.WriteLine("Also be careful not to throw unsafe moves since kuma has moves that takes a while to recover and leaves them open.");
                                    return;
                                }
                                else
                                {
                                    Console.WriteLine("Please pick the correct option");
                                    repeatinfo = true;
                                }
                                break;
                            case "ALISA":
                                Console.WriteLine("\nDifficulty: Easy");
                                Console.WriteLine("Alisa is a well rounded character with strong/simple poking and neutral.");
                                Console.WriteLine("\nWhat would you like to learn about Alisa? \n1.Key Moves \n2.Basic Combos \n3.Strategy");
                                Console.WriteLine("\nInput: ");
                                tk8_option = Convert.ToInt32(Console.ReadLine());
                                if (tk8_option == 1)
                                {
                                    Console.WriteLine("Alisa key moves:");
                                    /*Console.WriteLine("1. Bear jab: 1 which can lead to 1,1,1 combo launcher");
                                    Console.WriteLine("2. Anger hook: BF 2");
                                    Console.WriteLine("3. Bear Slash: B 1");
                                    Console.WriteLine("4. Falling Bear: FF 1+2");
                                    Console.WriteLine("5. Demon Uppercut: FF 2");
                                    Console.WriteLine("6. Bear Hopkick: UF 3 can also lead to UF 3,4,1+2 combo");
                                    Console.WriteLine("7. Rabid Bear: FFF 1+2");
                                    Console.WriteLine("8. Spinning Kuma: DB 4");
                                    Console.WriteLine("9. Kuma Musou: DB 1,2");
                                    Console.WriteLine("10. Grizzly Rampage: DF 1,2,1+2");*/
                                    return;
                                }
                                if (tk8_option == 2)
                                {
                                    Console.WriteLine("Alisa Basic Combos:");
                                    /*Console.WriteLine("1. DF+2,1 > B+2,2,1 > F 1+2,1+2");
                                    Console.WriteLine("2. F 1+2,1+2 > U+2 > B+2,2,1");
                                    Console.WriteLine("3. DF 2,1 > F+4 > B+2,1 > F 1+2,1+2 > U+2 > B+1");
                                    Console.WriteLine("4. DF 2,1 > B+2,2,1 > U+2 > QCF+2,1");
                                    Console.WriteLine("5. DF+2,1 > B+,2,2,1 > U+2 > HEAT > HEAT SMASH");*/
                                    return;
                                }
                                if (tk8_option == 3)
                                {
                                    Console.WriteLine("\nLook for whiff punishes that players throw out and punish them with DF+2,1");
                                    Console.WriteLine("Also be careful not to throw unsafe moves since kuma has moves that takes a while to recover and leaves them open.");
                                    return;
                                }
                                else
                                {
                                    Console.WriteLine("Please pick the correct option");
                                    repeatinfo = true;
                                }
                                break;
                            case "ASUKA":
                                Console.WriteLine("\nDifficulty: Easy");
                                Console.WriteLine("Asuka has a strong keepout game along with strong and unique oki.");
                                Console.WriteLine("\nWhat would you like to learn about Asuka? \n1.Key Moves \n2.Basic Combos \n3.Strategy");
                                Console.WriteLine("\nInput: ");
                                tk8_option = Convert.ToInt32(Console.ReadLine());
                                if (tk8_option == 1)
                                {
                                    Console.WriteLine("Asuka key moves:");
                                    /*Console.WriteLine("1. Bear jab: 1 which can lead to 1,1,1 combo launcher");
                                    Console.WriteLine("2. Anger hook: BF 2");
                                    Console.WriteLine("3. Bear Slash: B 1");
                                    Console.WriteLine("4. Falling Bear: FF 1+2");
                                    Console.WriteLine("5. Demon Uppercut: FF 2");
                                    Console.WriteLine("6. Bear Hopkick: UF 3 can also lead to UF 3,4,1+2 combo");
                                    Console.WriteLine("7. Rabid Bear: FFF 1+2");
                                    Console.WriteLine("8. Spinning Kuma: DB 4");
                                    Console.WriteLine("9. Kuma Musou: DB 1,2");
                                    Console.WriteLine("10. Grizzly Rampage: DF 1,2,1+2");*/
                                    return;
                                }
                                if (tk8_option == 2)
                                {
                                    Console.WriteLine("Asuka Basic Combos:");
                                    /*Console.WriteLine("1. DF+2,1 > B+2,2,1 > F 1+2,1+2");
                                    Console.WriteLine("2. F 1+2,1+2 > U+2 > B+2,2,1");
                                    Console.WriteLine("3. DF 2,1 > F+4 > B+2,1 > F 1+2,1+2 > U+2 > B+1");
                                    Console.WriteLine("4. DF 2,1 > B+2,2,1 > U+2 > QCF+2,1");
                                    Console.WriteLine("5. DF+2,1 > B+,2,2,1 > U+2 > HEAT > HEAT SMASH");*/
                                    return;
                                }
                                if (tk8_option == 3)
                                {
                                    Console.WriteLine("\nLook for whiff punishes that players throw out and punish them with DF+2,1");
                                    Console.WriteLine("Also be careful not to throw unsafe moves since kuma has moves that takes a while to recover and leaves them open.");
                                    return;
                                }
                                else
                                {
                                    Console.WriteLine("Please pick the correct option");
                                    repeatinfo = true;
                                }
                                break;
                            case "CLAUDIO":
                                Console.WriteLine("\nDifficulty: Easy");
                                Console.WriteLine("Claudio is a unique install character with a strong hopkick option");
                                Console.WriteLine("\nWhat would you like to learn about Alisa? \n1.Key Moves \n2.Basic Combos \n3.Strategy");
                                Console.WriteLine("\nInput: ");
                                tk8_option = Convert.ToInt32(Console.ReadLine());
                                if (tk8_option == 1)
                                {
                                    Console.WriteLine("Alisa key moves:");
                                    /*Console.WriteLine("1. Bear jab: 1 which can lead to 1,1,1 combo launcher");
                                    Console.WriteLine("2. Anger hook: BF 2");
                                    Console.WriteLine("3. Bear Slash: B 1");
                                    Console.WriteLine("4. Falling Bear: FF 1+2");
                                    Console.WriteLine("5. Demon Uppercut: FF 2");
                                    Console.WriteLine("6. Bear Hopkick: UF 3 can also lead to UF 3,4,1+2 combo");
                                    Console.WriteLine("7. Rabid Bear: FFF 1+2");
                                    Console.WriteLine("8. Spinning Kuma: DB 4");
                                    Console.WriteLine("9. Kuma Musou: DB 1,2");
                                    Console.WriteLine("10. Grizzly Rampage: DF 1,2,1+2");*/
                                    return;
                                }
                                if (tk8_option == 2)
                                {
                                    Console.WriteLine("Alisa Basic Combos:");
                                    /*Console.WriteLine("1. DF+2,1 > B+2,2,1 > F 1+2,1+2");
                                    Console.WriteLine("2. F 1+2,1+2 > U+2 > B+2,2,1");
                                    Console.WriteLine("3. DF 2,1 > F+4 > B+2,1 > F 1+2,1+2 > U+2 > B+1");
                                    Console.WriteLine("4. DF 2,1 > B+2,2,1 > U+2 > QCF+2,1");
                                    Console.WriteLine("5. DF+2,1 > B+,2,2,1 > U+2 > HEAT > HEAT SMASH");*/
                                    return;
                                }
                                if (tk8_option == 3)
                                {
                                    Console.WriteLine("\nLook for whiff punishes that players throw out and punish them with DF+2,1");
                                    Console.WriteLine("Also be careful not to throw unsafe moves since kuma has moves that takes a while to recover and leaves them open.");
                                    return;
                                }
                                else
                                {
                                    Console.WriteLine("Please pick the correct option");
                                    repeatinfo = true;
                                }
                                break;
                            case "CLIVE":
                                Console.WriteLine("\nDifficulty: Easy");
                                Console.WriteLine("Clive is a guest character with good space control and final fantasy character");
                                break;
                            case "JACK-8":
                                Console.WriteLine("\nDifficulty: Easy");
                                Console.WriteLine("Jack-8 has good range with his attacks and rushdown pressure as well.");
                                break;
                            case "PANDA":
                                Console.WriteLine("\nDifficulty: Easy");
                                Console.WriteLine("Panda is the joke character of tekken 8 with good range, mixups, and gimmicks with their stances.");
                                break;
                            case "LARS":
                                Console.WriteLine("\nDifficulty: Easy");
                                Console.WriteLine("Lars is a rushdown character with strong stance mixups");
                                break;
                            case "LEROY":
                                Console.WriteLine("\nDifficulty: Easy");
                                Console.WriteLine("Leroy has good stance pressure/mixups and benefits from counter hits when players make a mistake");
                                break;
                            case "LILI":
                                Console.WriteLine("\nDifficulty: Easy");
                                Console.WriteLine("Lili has good sidestepping tools along with applying pressure with her attacks.");
                                break;
                            case "DRAGUNOV":
                                Console.WriteLine("\nDifficulty: Easy");
                                Console.WriteLine("Dragunov has strong pokes, rushdown and, throw game");
                                break;
                            case "SHAHEEN":
                                Console.WriteLine("\nDifficulty: Easy");
                                Console.WriteLine("Shaheen has a simple poking game to force mistakes from opponents along with a strong slide/mixup game");
                                break;

                            //Intermediate to learn
                            case "AZUCENA":
                                Console.WriteLine("\nDifficulty: Intermediate");
                                Console.WriteLine("Azucena, the Coffee Queen, has an aggressive rushdown playstyle along with float like a butterfly, sting like a bee offense with her stances.");
                                break;
                            case "EDDY":
                                Console.WriteLine("\nDifficulty: Intermediate");
                                Console.WriteLine("Eddy Gordo, The Indomitable Flash, with his capoeria has some creative offense with his stances along with his attacks having 50/50 options.");
                                break;
                            case "FENG":
                                Console.WriteLine("\nDifficulty: Intermediate");
                                Console.WriteLine("Feng Wei, the God Fist, is know for his well rounded playstyle and strong turn stealing tools to get back on offense.");
                                break;
                            case "JUN":
                                Console.WriteLine("\nDifficulty: Intermediate");
                                Console.WriteLine("Jun Kazama, The Light of Hope, is a well rounded character with strong poking game and punishing opponents for making mistakes.");
                                break;
                            case "LEO":
                                Console.WriteLine("\nDifficulty: Intermediate");
                                Console.WriteLine("Leo, The Seeker of Truth, with their basic stances can provide strong punishments for blocked attacks and whiff attacks too.");
                                break;
                            case "LIDIA":
                                Console.WriteLine("\nDifficulty: Intermediate");
                                Console.WriteLine("Lidia, The Warrior Prime Minister, focuses on opponents mistakes and punishing them for it as well with counter hits.");
                                break;
                            case "LAW":
                                Console.WriteLine("\nDifficulty: Intermediate");
                                Console.WriteLine("Law, The Legendary Dragon, focuses on mostly counter hits and rushdown playstle.");
                                break;
                            case "PAUL":
                                Console.WriteLine("\nDifficulty: Intermediate");
                                Console.WriteLine("Paul Pheonix, the Hot-Blooded Destoryer & Strongest in the world, is known for his high damage attacks along with his 50/50 attacks to trick the opponents.");
                                break;
                            case "RAVEN":
                                Console.WriteLine("\nDifficulty: Intermediate");
                                Console.WriteLine("Raven, the Shadow Agent, has good mobility with his ninja attacks along with 50/50 attacks and unique options for pressure");
                                break;
                            case "VICTOR":
                                Console.WriteLine("\nDifficulty: Intermediate");
                                Console.WriteLine("Victor, Agent of Refined Violence, is known for his counter hit playstyle and punishing opponents for being too aggressive or impatient.\nAlso with his fresh suits inspired by John Wick.");
                                break;
                            case "ZAFINA":
                                Console.WriteLine("\nDifficulty: Intermediate");
                                Console.WriteLine("Zafina, the Mystic Stargazer, has a strong poking game and stong stances that can applying heavy pressure.");
                                break;

                            //Advanced to learn
                            case "JIN":
                                Console.WriteLine("\nDifficulty: Advanced");
                                Console.WriteLine("Jin Kazama, The Lighting of Fate, has a well rounded playstyle along with good mobility with wavedashing and good poking, counter hitting, and poking games.");
                                break;
                            case "KAZUYA":
                                Console.WriteLine("\nDifficulty: Advanced");
                                Console.WriteLine("Kazuya Mishima, The Cold-Blooded Oppressor, has a strong mixup playstyle along with mobility with wavedashing and hell sweep stance and is a high execution based character.");
                                break;
                            case "REINA":
                                Console.WriteLine("\nDifficulty: Advanced");
                                Console.WriteLine("Reina, The Purple Lighting, most like the other mishima characters has greay mobility with wavedashing along with strong poking and stance mixups with her own unique twist.");
                                break;
                            case "HEIHACHI":
                                Console.WriteLine("\nDifficulty: Advanced");
                                Console.WriteLine("Heihachi Mishima, The Resurrected King of Iron Fist, has high damage with his attacks and combos along with mixups from his hell sweep stance.");
                                break;
                            case "LEE":
                                Console.WriteLine("\nDifficulty: Advanced");
                                Console.WriteLine("Lee Chaolan, The Silver Haired-Demon, has a strong counter hitting game where he thrives in the mistakes the opponents make, amazing wall carry, and flashy combos.");
                                break;
                            case "DVJ":
                                Console.WriteLine("\nDifficulty: Advanced");
                                Console.WriteLine("Devil Jin, The Black Wings Of Ruin, has good space control along with mobility with his wings.");
                                break;
                            case "HWOARANG":
                                Console.WriteLine("\nDifficulty: Advanced");
                                Console.WriteLine("Hwoarang, The Blood Talon, has flexible and creative offensive tools and attacks with his stances along with overwhelming rushdown as well.");
                                break;
                            case "KING":
                                Console.WriteLine("\nDifficulty: Advanced");
                                Console.WriteLine("King, The Anger of the Beast, has a excellent throw game that can overwhelm opponents along with being unorthodox with throw mixups and pressure");
                                break;
                            case "XIAOYU":
                                Console.WriteLine("\nDifficulty: Advanced");
                                Console.WriteLine("Ling Xiaoyu, The Dancing Pheonix, is a stance heavy character that has strong poking tools and a lot of creativity with applying pressure.");
                                break;
                            case "NINA":
                                Console.WriteLine("\nDifficulty: Advanced");
                                Console.WriteLine("Nina Williams, The Silent Assassin, has insane rushdown methods along with being a execution character with her combos to her throws as well.");
                                break;
                            case "STEVE":
                                Console.WriteLine("\nDifficulty: Advanced");
                                Console.WriteLine("Steve Fox, The Counter-Punching Paragon, thrives when an opponent makes a mistake with his excellent counter hitting offense and along with confusing opponents with his many stances.");
                                break;
                            case "YOSHIMITSU":
                                Console.WriteLine("\nDifficulty: Advanced");
                                Console.WriteLine("Yoshimitsu, The Mechanized Space Ninja, has an unorthodox and creative offensive with his many stances and unblockable moves.");
                                break;
                            default:
                                Console.WriteLine("\nPlease type correct character name.");
                                repeatcharacter = true;
                                break;
                        }
                    }
                    switch (tk8_fighter)
                    {
                        //Easy to learn
                        case "KUMA":
                            Console.WriteLine("\nDifficulty: Easy");
                            Console.WriteLine("Kuma is the joke character of tekken 8 with good range, mixups, and gimmicks with their stances.");
                            Console.WriteLine("\nWhat would you like to learn about Kuma? \n1.Key Moves \n2.Basic Combos \n3.Strategy");
                            Console.WriteLine("\nInput: ");
                            tk8_option = Convert.ToInt32(Console.ReadLine());
                            if (tk8_option == 1)
                            {
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
                            }
                            if (tk8_option == 2)
                            {
                                Console.WriteLine("Kuma Basic Combos:");
                                Console.WriteLine("1. DF+2,1 > B+2,2,1 > F 1+2,1+2");
                                Console.WriteLine("2. F 1+2,1+2 > U+2 > B+2,2,1");
                                Console.WriteLine("3. DF 2,1 > F+4 > B+2,1 > F 1+2,1+2 > U+2 > B+1");
                                Console.WriteLine("4. DF 2,1 > B+2,2,1 > U+2 > QCF+2,1");
                                Console.WriteLine("5. DF+2,1 > B+,2,2,1 > U+2 > HEAT > HEAT SMASH");
                            }
                            if (tk8_option == 3)
                            {
                                Console.WriteLine("Salmon 3");
                            }
                            else
                            {
                                Console.WriteLine("Please pick the correct option");
                                repeatcode = true;
                            }
                            break;
                        case "ALISA":
                            Console.WriteLine("\nDifficulty: Easy");
                            Console.WriteLine("Alisa is a well rounded character with strong/simple poking and neutral.");
                            break;
                        case "ASUKA":
                            Console.WriteLine("\nDifficulty: Easy");
                            Console.WriteLine("Asuka has a strong keepout game along with strong and unique oki.");
                            break;
                        case "CLAUDIO":
                            Console.WriteLine("\nDifficulty: Easy");
                            Console.WriteLine("Claudio is a unique install character with a strong hopkick option");
                            break;
                        case "CLIVE":
                            Console.WriteLine("\nDifficulty: Easy");
                            Console.WriteLine("Clive is a guest character with good space control and final fantasy character");
                            break;
                        case "JACK-8":
                            Console.WriteLine("\nDifficulty: Easy");
                            Console.WriteLine("Jack-8 has good range with his attacks and rushdown pressure as well.");
                            break;
                        case "PANDA":
                            Console.WriteLine("\nDifficulty: Easy");
                            Console.WriteLine("Panda is the joke character of tekken 8 with good range, mixups, and gimmicks with their stances.");
                            break;
                        case "LARS":
                            Console.WriteLine("\nDifficulty: Easy");
                            Console.WriteLine("Lars is a rushdown character with strong stance mixups");
                            break;
                        case "LEROY":
                            Console.WriteLine("\nDifficulty: Easy");
                            Console.WriteLine("Leroy has good stance pressure/mixups and benefits from counter hits when players make a mistake");
                            break;
                        case "LILI":
                            Console.WriteLine("\nDifficulty: Easy");
                            Console.WriteLine("Lili has good sidestepping tools along with applying pressure with her attacks.");
                            break;
                        case "DRAGUNOV":
                            Console.WriteLine("\nDifficulty: Easy");
                            Console.WriteLine("Dragunov has strong pokes, rushdown and, throw game");
                            break;
                        case "SHAHEEN":
                            Console.WriteLine("\nDifficulty: Easy");
                            Console.WriteLine("Shaheen has a simple poking game to force mistakes from opponents along with a strong slide/mixup game");
                            break;

                        //Intermediate to learn
                        case "AZUCENA":
                            Console.WriteLine("\nDifficulty: Intermediate");
                            Console.WriteLine("Azucena, the Coffee Queen, has an aggressive rushdown playstyle along with float like a butterfly, sting like a bee offense with her stances.");
                            break;
                        case "EDDY":
                            Console.WriteLine("\nDifficulty: Intermediate");
                            Console.WriteLine("Eddy Gordo, The Indomitable Flash, with his capoeria has some creative offense with his stances along with his attacks having 50/50 options.");
                            break;
                        case "FENG":
                            Console.WriteLine("\nDifficulty: Intermediate");
                            Console.WriteLine("Feng Wei, the God Fist, is know for his well rounded playstyle and strong turn stealing tools to get back on offense.");
                            break;
                        case "JUN":
                            Console.WriteLine("\nDifficulty: Intermediate");
                            Console.WriteLine("Jun Kazama, The Light of Hope, is a well rounded character with strong poking game and punishing opponents for making mistakes.");
                            break;
                        case "LEO":
                            Console.WriteLine("\nDifficulty: Intermediate");
                            Console.WriteLine("Leo, The Seeker of Truth, with their basic stances can provide strong punishments for blocked attacks and whiff attacks too.");
                            break;
                        case "LIDIA":
                            Console.WriteLine("\nDifficulty: Intermediate");
                            Console.WriteLine("Lidia, The Warrior Prime Minister, focuses on opponents mistakes and punishing them for it as well with counter hits.");
                            break;
                        case "LAW":
                            Console.WriteLine("\nDifficulty: Intermediate");
                            Console.WriteLine("Law, The Legendary Dragon, focuses on mostly counter hits and rushdown playstle.");
                            break;
                        case "PAUL":
                            Console.WriteLine("\nDifficulty: Intermediate");
                            Console.WriteLine("Paul Pheonix, the Hot-Blooded Destoryer & Strongest in the world, is known for his high damage attacks along with his 50/50 attacks to trick the opponents.");
                            break;
                        case "RAVEN":
                            Console.WriteLine("\nDifficulty: Intermediate");
                            Console.WriteLine("Raven, the Shadow Agent, has good mobility with his ninja attacks along with 50/50 attacks and unique options for pressure");
                            break;
                        case "VICTOR":
                            Console.WriteLine("\nDifficulty: Intermediate");
                            Console.WriteLine("Victor, Agent of Refined Violence, is known for his counter hit playstyle and punishing opponents for being too aggressive or impatient.\nAlso with his fresh suits inspired by John Wick.");
                            break;
                        case "ZAFINA":
                            Console.WriteLine("\nDifficulty: Intermediate");
                            Console.WriteLine("Zafina, the Mystic Stargazer, has a strong poking game and stong stances that can applying heavy pressure.");
                            break;

                        //Advanced to learn
                        case "JIN":
                            Console.WriteLine("\nDifficulty: Advanced");
                            Console.WriteLine("Jin Kazama, The Lighting of Fate, has a well rounded playstyle along with good mobility with wavedashing and good poking, counter hitting, and poking games.");
                            break;
                        case "KAZUYA":
                            Console.WriteLine("\nDifficulty: Advanced");
                            Console.WriteLine("Kazuya Mishima, The Cold-Blooded Oppressor, has a strong mixup playstyle along with mobility with wavedashing and hell sweep stance and is a high execution based character.");
                            break;
                        case "REINA":
                            Console.WriteLine("\nDifficulty: Advanced");
                            Console.WriteLine("Reina, The Purple Lighting, most like the other mishima characters has greay mobility with wavedashing along with strong poking and stance mixups with her own unique twist.");
                            break;
                        case "HEIHACHI":
                            Console.WriteLine("\nDifficulty: Advanced");
                            Console.WriteLine("Heihachi Mishima, The Resurrected King of Iron Fist, has high damage with his attacks and combos along with mixups from his hell sweep stance.");
                            break;
                        case "LEE":
                            Console.WriteLine("\nDifficulty: Advanced");
                            Console.WriteLine("Lee Chaolan, The Silver Haired-Demon, has a strong counter hitting game where he thrives in the mistakes the opponents make, amazing wall carry, and flashy combos.");
                            break;
                        case "DVJ":
                            Console.WriteLine("\nDifficulty: Advanced");
                            Console.WriteLine("Devil Jin, The Black Wings Of Ruin, has good space control along with mobility with his wings.");
                            break;
                        case "HWOARANG":
                            Console.WriteLine("\nDifficulty: Advanced");
                            Console.WriteLine("Hwoarang, The Blood Talon, has flexible and creative offensive tools and attacks with his stances along with overwhelming rushdown as well.");
                            break;
                        case "KING":
                            Console.WriteLine("\nDifficulty: Advanced");
                            Console.WriteLine("King, The Anger of the Beast, has a excellent throw game that can overwhelm opponents along with being unorthodox with throw mixups and pressure");
                            break;
                        case "XIAOYU":
                            Console.WriteLine("\nDifficulty: Advanced");
                            Console.WriteLine("Ling Xiaoyu, The Dancing Pheonix, is a stance heavy character that has strong poking tools and a lot of creativity with applying pressure.");
                            break;
                        case "NINA":
                            Console.WriteLine("\nDifficulty: Advanced");
                            Console.WriteLine("Nina Williams, The Silent Assassin, has insane rushdown methods along with being a execution character with her combos to her throws as well.");
                            break;
                        case "STEVE":
                            Console.WriteLine("\nDifficulty: Advanced");
                            Console.WriteLine("Steve Fox, The Counter-Punching Paragon, thrives when an opponent makes a mistake with his excellent counter hitting offense and along with confusing opponents with his many stances.");
                            break;
                        case "YOSHIMITSU":
                            Console.WriteLine("\nDifficulty: Advanced");
                            Console.WriteLine("Yoshimitsu, The Mechanized Space Ninja, has an unorthodox and creative offensive with his many stances and unblockable moves.");
                            break;
                        default:
                            Console.WriteLine("\nPlease type correct character name.");
                            repeatcharacter = true;
                            break;
                    }
                }

            }

        }

        /*public static void SF6_Characters()
        {
            
        }
         
        public static void MK1_Characters()
        {
            
        }
        */
    }
}
