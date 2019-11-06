using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Rebound.enum_types.Weapons;
using Rebound.Models;

namespace Rebound.Weapons.Monster_Weapons
{
    public class SharpClaws : WeaponBase
    {
        public SharpClaws() : base(new WeaponModel("Deadly Sharp Claws", "Thick dark keratin ending in a razor-tipped point; they'll cut pretty deep.",false,4,8,5,WeaponTypes.Unarmed,WeaponUserType.Monster))
        {
        }
    }
}
