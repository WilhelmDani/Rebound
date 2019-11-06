using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using Rebound.Characters;
using Rebound.OpeningNMenus.OddShopMenus;

namespace Rebound.OpeningNMenus
{
   public class OddShop
    {
        public static void GetShopMenu(Player player)
        {

            bool continueOn = false;

            Console.WriteLine("You decide to head over to the 'Odd Shop' that's sticking out like a sore thumb. You only call it that because of the large hand-painted sign that hangs above the tiny building. Each letter is on it's own block of scrap wood, all but the 'S' at the end of the word 'Odd' which had fallen off at some point." +
                                   "As you get approach, the creature that had been beckoning you over ducks back into the window and snaps it shut; leaving you to walk up to the nicely placed mat in front of the door and awkwardly stand there. \n\n");
            
            do
            {
             
                Console.WriteLine("What do you do? \n" +
                              "1.) Knock politely\n" +
                              "2.) Just walk inside\n" +
                              "3.) Call out \"Hello?\"\n" +
                              "4.) Never mind, go back to fighting\n");

            ConsoleKey frontDoorChoice = Console.ReadKey().Key;
            Console.Clear();

                switch (frontDoorChoice)
            {
                case ConsoleKey.D1:
                case ConsoleKey.NumPad1:
                        Console.WriteLine("You decide to give a few good knocks on the almost obnoxiously bright yellow door, taking note of the child-like patterns decorating the surface in blue paint. \n" +
                                 "\"Whoooo iss it~?\" A slightly nasally and high-pitched voice sang back innocently from the other side. Was this creature playing games with you now? You swear it had been flailing its arms out that window to get your attention. But now that you were here, it wants to pretend like its oblivious of your presence? \n\n" +
                                 " There's a click and the window slides open again. You wait but for a few beats nothing happens, until the hint of two black and fuzzy tips peeks out of the open space. " +
                                 "They twitch, as if also waiting, before the rest of the creature suddenly springs up, it's arms thrown up in the air in a way that strangely reminds you of a woman popping out of a cake. It looks quite proud of itself as it hangs back out the window where you originally saw it." +
                                 "You take in the almost cartoon-like cat creature staring back at you, it's large green eyes crinkled with mischief. It looks like a normal cat in almost every aspect, except for the large, brown, human-workers gloves on it's front paws....Does that mean it has human hands under there? " +
                                 "\n\n \"Kidding, kidding! Odd knows who YOU are, yes! So glad you came to Odd's Shop! Most other's have been ignoring Odd, yes...\" It's large eyes look past you and narrow almost accusingly. You glance over your shoulder but you don't see anyone else in the Main Hall. It's just you and this weird cat. \n\n");

                        Console.WriteLine("\" What the hell are you? What is this?\" The word vomit spills from your mouth before you can stop it.\n");

                        Console.WriteLine("The creature's ears flatten down and it gives you a deadpan stare. \"Odd will not release valuable information about himself out in the open like some dolt.\" Wow, okay. " +
                                          "\n\nThe cat's deadly serious demeanor quickly shifts back to something more happy and upbeat as it's ears pop back up. \"Maybe if you come inside, Odd would enjoy talking more, yes.\" \n\n");

                        Console.WriteLine("You're not given a chance to say much else before the cat ducks back inside and slams the window closed in your face...\n");
                        
                        break;

                case ConsoleKey.D2:
                case ConsoleKey.NumPad2:
                    Console.WriteLine("\n");
                    break;

                case ConsoleKey.D3:
                case ConsoleKey.NumPad3:
                    Console.WriteLine("\"Hello!!\" A slightly nasally and high-pitched voice muffled back from the other side of the door but otherwise you get no other response.\n");
                    break;

                case ConsoleKey.D4:
                case ConsoleKey.NumPad4:
                    continueOn = true;
                        break;


                default:
                    Console.WriteLine($"\"Invalid response. Try that again. {player.Character.Name}\"");
                    break;
            }
            } while (!continueOn);
           
        }
    }
}
