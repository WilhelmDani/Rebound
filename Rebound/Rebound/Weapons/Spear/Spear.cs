using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Rebound.enum_types.Weapons;
using Rebound.Models;

namespace Rebound.Weapons.Spear
{
    public class Spear : WeaponBase
    {
        public Spear() : base(new WeaponModel("Glaive Spear", "A thick, short blade with a secondary pointed tip attached to a long pole. The shaft itself is made of some sort of sturdy, ancient wood and a thick red threaded cord hangs from the end, but otherwise it's very plain.", true,3,7,4,WeaponTypes.Spear))
        {
        }
    }
}
