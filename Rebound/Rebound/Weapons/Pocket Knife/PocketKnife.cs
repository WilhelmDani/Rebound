using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Rebound.enum_types.Weapons;
using Rebound.Models;

namespace Rebound.Weapons.Pocket_Knife
{
    public class PocketKnife : WeaponBase
    {
        public PocketKnife() : base( new WeaponModel("Drop-Point Pocket Knife", "A rather small pocket knife with a fairly thick blade made of black steel. There is a bear design on the handle with an eye made of a tiny red jewel. It looks like it might have been very personal to someone.",false,1,4,8, WeaponTypes.PocketKnife))
        {
        }
    }
}
