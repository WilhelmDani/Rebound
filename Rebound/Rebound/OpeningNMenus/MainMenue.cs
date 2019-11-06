using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Rebound.Characters;
using Rebound.Characters.Monsters.Advespa;
using Rebound.Weapons.Fists;
using Rebound.OpeningNMenus.OddShopMenus;

namespace Rebound.OpeningNMenus
{
    public class MainMenue
    {
        public static void MainMenu(Player player)
        {

            bool exit = false;
            do
            {
                Console.WriteLine("Choose Your Action:\n" +
                                  "1.)Go to a new room\n" +
                                  "2.)Go to Odd Shop\n" +
                                  "X.)Exit Game");
                ConsoleKey userChoice = Console.ReadKey().Key;
                Console.Clear();

                switch (userChoice)
                {
                    case ConsoleKey.D1:
                    case ConsoleKey.NumPad1:
                        Console.WriteLine(RoomGenerator.GetRoom());
                        // select random monster here
                        BattleMenu.GetBattleMenu(player, new AggressiveGuard(new BareFists()));
                        break;

                    case ConsoleKey.D2:
                    case ConsoleKey.NumPad2:
                        OddShop.GetShopMenu(player);
                        break;

                    case ConsoleKey.X:
                        exit = true;
                        break;

                    default:
                        Console.WriteLine("Mmmm, no. Invalid Option. Try again.");
                        break;
                }
            } while (!exit);
        }
    }
}
