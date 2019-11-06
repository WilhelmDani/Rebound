using Rebound.enum_types.Weapons;

namespace Rebound.Models
{
    public class WeaponModel
    {
        public WeaponModel(string name, string description, bool twoHanded, int minDamage, int maxDamage, int hitChance, WeaponTypes type, WeaponUserType userType = WeaponUserType.All)
        {
            Name = name;
            Description = description;
            TwoHanded = twoHanded;
            MinDamage = minDamage;
            MaxDamage = maxDamage;
            HitChance = hitChance;
            Type = type;
            UserType = userType;
        }


        public string Name { get; set; }
        public string Description { get; set; }
        public bool TwoHanded { get; set; }
        public int MinDamage { get; set; }
        public int MaxDamage { get; set; }
        public int HitChance { get; set; }
        public WeaponTypes Type { get; set; }
        public WeaponUserType UserType { get; set; }

    }

   
}