using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Rebound.enum_types;

namespace Rebound.OpeningNMenus
{
    public static class NewPlayerPrompts
    {

        public static string Playername()
        {

            Console.WriteLine(@"

            █▄▄▄▄ ▄███▄   ███   ████▄   ▄      ▄   ██▄   
            █  ▄▀ █▀   ▀  █  █  █   █    █      █  █  █  
            █▀▀▌  ██▄▄    █ ▀ ▄ █   █ █   █ ██   █ █   █ 
            █  █  █▄   ▄▀ █  ▄▀ ▀████ █   █ █ █  █ █  █  
              █   ▀███▀   ███         █▄ ▄█ █  █ █ ███▀  
             ▀                         ▀▀▀  █   ██       

                                                                                                                    
                                                                                                                                                   
                                                                                                                       
                                                                                                
                                        ....                                   
                                       ....,.                                  
                                      ...    .                                 
                                      .   .; .                                
                                      ..    ..                                 
                                   .......  ..                                 
                                  ..,.....   ..                                
                                  .........  ...                               
                                 ................                              
                                 ..........*.....                              
                                 ................                              
                                ..............,..                              
                                .................                              
                                ............. ....                             
                               .............. ....                             
                                ............. .....                            
                               .............. .....                            
                              ...............  ....                            
                              ...............  .....                           
                             ................. .....                           
                             ................. ......                          
                             .................  .....                          
                             .................  .....                          
                             .................  ......                         
                            ..................   .....                         
                           ...................   ......                        
                          .....................  ......                        
                         ......................   ......                       
                        .......................   .......                      
                        ........................  ......                       
                      ..........................   ....                        
                        .......................                                
                                 ...                                                                   
                                                                                                            ");

            
            

            Console.WriteLine("[Press any key to start...]");
           ConsoleKey userResponse = Console.ReadKey().Key;

            Console.Clear();
            Console.WriteLine("	You awake to complete darkness surrounding you..... \n " +
                              "The distant sounds of water dripping from high above and the infrequent screeching of something far off the only things you can pick out." +
                              " As you somehow find your footing and raise to stand, you ponder where you are or how you got here. \n\n " +
                              "The last you remembered was the feeling of fatigue and the flex of your arm as you swung your weapon. " +
                              " A white-hot pain in the center of your back unfortunately stopped you short; " +
                              "pushed through the front of your chest and quickly spread to the rest of your body as your weapon clattered to the ground." +
                              " It felt as if time slowed down as a blade retracted back out of the hole it created in your torso; leaving a warm wet feeling on your hand when you touched the spot." +
                              " When you pulled away to look at your wet palm, you vaguely remember it being stained the color red before your world swallowed you up into this darkness. \n\n " +
                              "Touching the same spot on your chest, you only just now realize you're not wearing your usual armor but what feels like a tattered peasant garb wrapped in a cloak. \n\n" +
                              "Wait.... Did you die? \n\n");

            Console.WriteLine("[Press any key to continue...]");
            ConsoleKey userResponse2 = Console.ReadKey().Key;

            Console.Clear();
            Console.WriteLine(" \"Indeed,\" a soft voice answers, startling you. It appears to echo from all around you, " +
                              "but at the same time it sounds like it was coming from inside your own head." +
                              " \"What is your name, you poor creature?\" \n\n " +
                              "You feel hesitant to answer but....");

           
            Console.Write("Your Name is: ");
            string userName = Console.ReadLine();
            Console.Clear();
            Console.WriteLine($"\"Hm, {userName} is it? ....I see. Well {userName}, you are correct to assume you have died. Quite gruesomely I might add. No surviving from that one, I'm afraid...\" \n\n" +
                              $"What's left of your heart sinks in dread...and soon after panic takes over. If you died, then where are you now? \n\n" +
                              $"\"Ah, that's the real question, isn't it? I believe your kind call it many things; you might recognize it as 'Purgatory'. \n\n");


            Console.WriteLine("1.) \"I'm in purgatory?\" \n2.) \"I have no idea what that is.\" ");
            ConsoleKey userResponse3 = Console.ReadKey().Key;
            Console.Clear();

            if (userResponse3 == ConsoleKey.D1 || userResponse3 == ConsoleKey.NumPad1)
            {
                Console.WriteLine($"\"Indeed ...and a treacherous place it is, my dear {userName}.\" " +
                                  $" As if on cue, another indistinguishable squeal of something from far off in the darkness startles you. The itch to check over your shoulder constantly starts to become insistent.\n");
            }
            else if (userResponse3 == ConsoleKey.D2 || userResponse3 == ConsoleKey.NumPad2)
            {
                Console.WriteLine("\"Oh-! Hmm, my human terminology is a bit rusty it seems.\" And as if the voice forgot you could hear it, it mumbled more quietly to itself; \"Or human's " +
                                  " have regressed quite a bit...\" \n\n" +
                                  " It gave a loud \"AHEM!\" before continuing, causing you to squint in pained annoyance. \"Perhaps 'Limbo' is more familiar to you, yes? 'Netherworld'? 'The Abyss'? 'Gehenna'? Any of these ringing a bell?\"\n ");
            }

            Console.WriteLine("1.) \"Okay, so is there a way out of here?\" \n2.) \"Yeah, I still don't know what you're trying to get at.\" ");
            ConsoleKey userResponse4 = Console.ReadKey().Key;
            Console.Clear();

            if (userResponse4 == ConsoleKey.D1 || userResponse4 == ConsoleKey.NumPad1)
            {
                Console.WriteLine($"\" It's nice to see a lost soul so eager after learning of their demise; normally its a lot of crying and denial at first. This attitude will help you greatly down here, {userName}.\" \n\n");
            }
            else if (userResponse4 == ConsoleKey.D2 || userResponse4 == ConsoleKey.NumPad2)
            {
                Console.WriteLine("A loud annoyed sigh seems to vibrate even the thick darkness around you, making you cover your ears in pain. It's drawn out and a little over-exaggerated. \n\n" +
                                  "\"UUUGGGHHHHH- Purgatory, you poor simple creature, is a plane of existence for naughty little sinners like YOU when they DIE. You were cursed here for being too impure in your previous living state. Understand now?\"" +
                                  " \n\nYou open your mouth to answer but the voice continues before you even get the chance to say anything.\n\n");
            }

            Console.WriteLine("\"In Purgatory you are given the chance to redeem your soul and return to the land of the living... but to do that you must collect at least 100 lesser souls to recreate your own.\"" +
                              $"\n\n\"You look a bit perplexed by this, {userName}. Perhaps You have a question you'd like to ask?\" \n");

            bool continueOn = false;

            do
            {
                Console.WriteLine("1.) \"What the heck are lesser souls?\" " +
                              "\n2.) \"Why do I need 100 souls?\"" +
                              "\n3.) \"What's Purgatory again?\"" +
                              "\n4.) \"Wait, who are you exactly?\"" + 
                              "\n5.) \"Nope. No questions. Kill stuff and extract the souls. Got it.\" ");

            ConsoleKey userResponse5 = Console.ReadKey().Key;
            Console.Clear();

                switch (userResponse5)
            {
                    case ConsoleKey.D1:
                    case ConsoleKey.NumPad1:
                        Console.WriteLine("\"Others that have been banished to Purgatory and have squandered their own chance at life. You might have heard their cries when you first awoke? " +
                                          "Poor lost souls turned monstrous from their defeat. That very well could happen to you if you're not mindful.\" \n\n" +
                                          "\"...Oh. You probably didn't realize you can die again while down here, did you? Indeed; and if it does happen, your soul will deform further and you will join the literal monstrosities trapped here!\" " +
                                          "\n\n ....Was it just you, or did the voice sound a little excited of the possibility of you failing?\n");

                        break;
                    case ConsoleKey.D2:
                    case ConsoleKey.NumPad2:
                        Console.WriteLine("\"It's a good rounded number, don't you think? I mean-\" \n\n" +
                                          "\"A human soul requires a great deal of energy to put together a body. After humans are banished to Purgatory, their soul degrades into something more twisted and thus becomes less worthy of redemption. " +
                                          "If defeated while in Purgatory, there is no hope for redemption. " +
                                          "But if you were to succeed and extract enough of these lesser souls without being killed yourself, one human soul can be made whole again and you can leave!\" \n\n" +
                                          "\"Easy enough, right?\" \n\n" +
                                          "You squint suspiciously into the darkness, but it's not like you have much of a choice....\n");
                        break;

                    case ConsoleKey.D3:
                    case ConsoleKey.NumPad3:
                        Console.WriteLine(" \"...\" \n\n Nearly a minute goes by where you almost think the voice didn't hear you. You go to repeat your question when it suddenly cuts you off. \n\n \"No.\" Is all it responds with in a stern tone of finality and you close your mouth.\n");
                        break;

                    case ConsoleKey.D4:
                    case ConsoleKey.NumPad4:
                        Console.WriteLine($"\"Who, me? Why my dear {userName}, I am simply but a humble disembodied, god-like voice in your head. Here to give you the little push you need so you're not just wondering in eternal damnation!\" \n\n" +
                                          $"\"No need to thank me, of course.\" \n");
                        break;

                    case ConsoleKey.D5:
                    case ConsoleKey.NumPad5:
                        continueOn = true;
                        break;

                    default:
                        Console.WriteLine($"\"Could you repeat yourself, {userName}?\"");
                        break;
            }

            } while (!continueOn);

            Console.Clear();
            Console.WriteLine("\"Ah-Ha, there we go! That's the spirit.\" Seemingly satisfied with your understanding of the situation, the voice lets out an almost haunting chuckle.\n\n");
            Console.WriteLine("In a flash of light that makes your unadjusted eyes water, torches lining the stone walls around you flicker to life all at once.\n\n" +
                              "You appear to be standing in some sort of uncomfortably warm cave opening deep underground. Water continuously drips from cracks above and pool into shallow puddles. " +
                              "Turning around, you spot the only tunnel leading out of the cave opening. Lit with more torches, it seems to bend around a corner. \n\n " +
                              $"\"Good luck, dear {userName},\" the voice hummed out approvingly as you ventured forth through the lit opening. \n\n" +
                              $"At the end of the tunnel, carved into the dim maroon stone, is a very out-of-place wooden door. As you approach, you note there isn't a traditional door handle, but a simple rusted ring to pull on. Giving the ring a good tug, the door creaks loudly as it swings open. " +
                              $"\n\nTrying to prepare yourself for whatever could be on the other side, you take in a deep breath before pushing onwards...\n");

            Console.WriteLine("[Press any key to continue...]");
            ConsoleKey userResponse6 = Console.ReadKey().Key;
            Console.Clear();

            Console.WriteLine("It's slightly dimmer as you come out on the other side. Not at all amazed, you find another long hallway but this time the torches were spaced out about ten feet or so, positioned directly above more strangely placed wooden doors. " +
                              "The hallway stretches on for quite a ways with a door on either side, so there had to be at least 30 doors leading to other rooms from what you can tell. " +
                              "If you listen, you can hear the sounds of snarling and screeching coming from behind each door, creating a sort of terrifying cacophony echoing off the stone walls." +
                              " Squinting, you notice something move at the very end of the hallway that was different from the rest of the copy and pasted doors. \n\n" +
                              "What looked like a mock pop-up storefront, complete with a creature trying to eagerly wave you over from a open window, was cut perfectly into the stone and completely out of place. \n");


            return userName;
        }

    }
}
