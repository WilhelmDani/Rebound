using System;
using Rebound.Models;

namespace Rebound.Weapons
{
    public class WeaponBase
    {
        private Random _randomNum; 
        protected WeaponModel Weapon { get; } 


        public WeaponBase(WeaponModel weapon)
        {
            _randomNum = new Random();
            Weapon = weapon;
        }

        public virtual int GetWeaponMinDamage() => Weapon.MinDamage;
        public virtual int GetWeaponMaxDamage() => Weapon.MaxDamage <= Weapon.MinDamage ? Weapon.MinDamage + 1 : Weapon.MaxDamage;
        public virtual int GetWeaponDamage() => _randomNum.Next(GetWeaponMinDamage(), GetWeaponMaxDamage() + 1);

        public string GetInfo()
        {
            return $@"Name: {Weapon.Name}
                    Description:
                    {Weapon.Description}

                    Stats:
                    Type: {(Weapon.TwoHanded ? "Two-handed" : "One-handed")} {Weapon.Type}
                    Damage: {Weapon.MinDamage} - {Weapon.MaxDamage}";
        }
    }
}
