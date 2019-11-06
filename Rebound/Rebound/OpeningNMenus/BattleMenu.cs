using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Rebound.Characters;

namespace Rebound.OpeningNMenus
{
   public class BattleMenu
    {
        public static void GetBattleMenu(Player player, AllMonsters monster)
        {
            bool roomDone = false;
            do
            {
                Console.WriteLine("Choose Your Action:\n" +
                              "1) Attack\n" +
                              "2) Check Stats\n" + 
                              "3) Examine Monster\n" +
                              "X) Flee from the Room\n");

            ConsoleKey userBattleChoice = Console.ReadKey().Key;
            Console.Clear();

            switch (userBattleChoice)
            {
                case ConsoleKey.D1:
                case ConsoleKey.NumPad1:
                    Combat.DoCombat(player, monster);
                    if (monster.Character.Life < 1 )
                    {
                        roomDone = true;
                        Console.Clear();
                    }
                    else if (monster.WillFlee())
                    {
                        Combat.DoCombat(player, monster, true);
                        //add that number thing
                        roomDone = true;
                        Console.Clear();
                    }
                    else
                    {
                        Combat.DoCombat(monster,player);
                    }
                    
                    break;

                    case ConsoleKey.D2:
                case ConsoleKey.NumPad2:
                        Console.WriteLine(player.GetInfo());
                    break;

                case ConsoleKey.D3:
                case ConsoleKey.NumPad3:
                    Console.WriteLine(monster.GetInfo());
                    break;

                case ConsoleKey.X:
                    roomDone = true;
                    Console.WriteLine("Fleeing for your pathetic life, you make a dash for the door!\n");
                    Console.WriteLine($"{monster} tries to attack while your back is turned!");
                    Combat.DoCombat(monster, player, true);
                    break;

                default:
                    Console.WriteLine("Tis not an option, my dear. Try again.");
                    break;
            }
            } while (!roomDone);
            
        }
    }
}
