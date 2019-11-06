using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Rebound.enum_types.Weapons;
using Rebound.Models;

namespace Rebound.Weapons.Monster_Weapons
{
    public class StingerArrows : WeaponBase
    {
        public StingerArrows() : base(new WeaponModel("Stinger Arrows", "From the bottom of the creature's abdomen, a sharp arrowhead is produced. It pushes it's way out, aiming up it's shot, and pointed right at you. One good push and it'll fire at you like a gunshot before being replaced with another.",false,4,8,6,WeaponTypes.Unarmed,WeaponUserType.Monster))
        {
        }
    }
}
