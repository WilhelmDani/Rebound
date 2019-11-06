using System;
using Rebound.Models;
using Rebound.Weapons;

namespace Rebound.Characters
{
    public class AllCharacters
    {
        private Random random;
        public AllCharactersModel Character { get; set; }
        public WeaponBase Weapon { get; set; }

        public AllCharacters(AllCharactersModel character, WeaponBase weapon)
        {
            random = new Random();
            Character = character;
            Weapon = weapon;
        }

        public virtual int CalculateHitChance => Character.HitChance;
        public virtual int CalculateBlockChance => Character.BlockChance;

        public virtual int GetBlock()
        {
            var baseBlock = CalculateBlockChance;
            return baseBlock;
        }

        public int Roll() => random.Next(1, 21);

        public virtual (int Hit, int Damage) GetHitAndDamage()
        {
            var roll = Roll();
            if (roll == 1)
            {
                return (0, 0);
            }

            var baseHit = CalculateHitChance;
            var baseDamage = Weapon.GetWeaponDamage();

            if ( roll == 20)
            {
                var criticalDamage = baseDamage + 5;

            }

            return (baseHit, baseDamage);
        }





        public string GetInfo()
        {
            return $@"Name: {Character.Name}
Description:
{Character.Description}

Stats:
Health: {Character.Life} / {Character.MaxLife}
Block Chance: {Character.BlockChance}
Hit Chance: {Character.HitChance}

Weapon:{Weapon.GetInfo() }";
        }
    }
}
