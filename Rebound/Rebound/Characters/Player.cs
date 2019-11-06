using System;
using Rebound.Models;
using Rebound.Weapons;

namespace Rebound.Characters
{
    public class Player : AllCharacters
    {
        public Player(AllCharactersModel character, WeaponBase weapon) : base(character, weapon)
        {

        }

        public void PlayerOnlyThing()
        { }
    }
}
