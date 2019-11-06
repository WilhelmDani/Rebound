using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Rebound.enum_types.Weapons;
using Rebound.Models;

namespace Rebound.Weapons.Club
{
    public class BoneClub : WeaponBase
    {
        public BoneClub() : base(new WeaponModel("Bone Club", "It looks to be the femur bone of a large creature wrapped in fabric and odd smelling leathers", true,
            2,7,5,WeaponTypes.Club))
        {
        }
    }
}
