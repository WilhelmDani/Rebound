using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Rebound.enum_types.Weapons;
using Rebound.Models;

namespace Rebound.Weapons.Fists
{
    public class BareFists : WeaponBase
    {
        public BareFists() : base(new WeaponModel("Bare Unarmed", "Five fingers and a thumb curled into a tight fist, what did you expect?", false,1,4,8,WeaponTypes.Unarmed))
        {
        }
    }
}
