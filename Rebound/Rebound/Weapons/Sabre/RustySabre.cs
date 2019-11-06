using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Rebound.enum_types.Weapons;
using Rebound.Models;

namespace Rebound.Weapons.Sabre
{
    public class RustySabre : WeaponBase
    {
        public RustySabre() : base(new WeaponModel("Rusty Barbed Sabre", "A fairly long, narrow, barbed blade made of rusted iron. It's held by a grip wrapped in very old, deep orange scaled leather and topped off with a small pommel engraved with the sword maker's symbol.",false,2,6,5, WeaponTypes.Sabre))
        {
        }
    }
}
