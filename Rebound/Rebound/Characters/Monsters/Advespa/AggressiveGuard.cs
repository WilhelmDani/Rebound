using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Rebound.Models;
using Rebound.Weapons;
using Rebound.Weapons.Monster_Weapons;

namespace Rebound.Characters.Monsters.Advespa
{
    class AggressiveGuard : AllMonsters
    {
        public AggressiveGuard(WeaponBase model) : base(new AllCharactersModel("Agressive Advespa Guard", "The loud humming sound above is what gets your attention first. Hovering above you with two sets of translucent wings is a 6ft bug creature, bobbing angrily once it notices your presences and starts inspecting you. \n\n It resembled a hornet in color and shape; but where there would normally be two large, black compound-eyes and mandibles, is a deformed woman's face staring back at you. What's left of her lips are pulled back in a permanent sneer, stretched painfully wide due to the miniature mandibles growing from the gums in her mouth. One of her eyes still appears normal, although blown out and wild looking; the other seems to be in the middle of deforming into a more bug like orb. A pair of antennae have forced their way through her forehead just along her hairline, the skin long since peeled back and left to hang and fall off.", 30, 30, 6, 5), new StingerArrows(), true)
        {
        }
    }
}
