using Rebound.Models;
using Rebound.Weapons;

namespace Rebound.Characters
{
    public class AllMonsters : AllCharacters
    {
        public bool IsHardHeaded { get; set; }

        public AllMonsters(AllCharactersModel character, WeaponBase weapon, bool isHardHeaded) : base(character, weapon)
        {
            IsHardHeaded = isHardHeaded;
        }

        public bool WillFlee()
        {
            if (IsHardHeaded == false && Character.Life / Character.MaxLife < 0.1)
            {
                return true;
            }

            return false;
        }
    }
}
