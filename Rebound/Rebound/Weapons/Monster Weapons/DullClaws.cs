using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Rebound.enum_types.Weapons;
using Rebound.Models;

namespace Rebound.Weapons.Monster_Weapons
{
    class DullClaws : WeaponBase
    {
        public DullClaws() : base(new WeaponModel("Dull Claws", "They're disfigured and gnarly, but not that sharp.", false,2,5, 4,WeaponTypes.Unarmed, WeaponUserType.Monster))
        {
        }
    }
}
