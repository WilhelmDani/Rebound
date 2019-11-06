using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Rebound.enum_types.Weapons;
using Rebound.Models;

namespace Rebound.Weapons.Great_Sword
{
    public class GreatSword : WeaponBase
    {
        public GreatSword() : base(new WeaponModel("Moonlight Great Sword", "A long, thick blade made of some sort of refined teal crystal. It's incredibly sharp and heavy. The hilt has gold vines wrapped all the way down to the pommel where a house sigil you don't reconize sits.",true,4,9,3,WeaponTypes.GreatSword))
        {
        }
    }
}
