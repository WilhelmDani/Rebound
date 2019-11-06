using Rebound.Characters;
using Rebound.Models;
using Rebound.OpeningNMenus;
using Rebound.Weapons.Fists;

namespace Rebound
{
    class MainApplication
    {
        static void Main(string[] args)
        {

            var playerName = NewPlayerPrompts.Playername();

            var player = new Player(new AllCharactersModel(playerName, "You still feel like you, but something is slightly off.", 50, 100, 2, 3), new BareFists());

            MainMenue.MainMenu(player);

        }
    }
}
