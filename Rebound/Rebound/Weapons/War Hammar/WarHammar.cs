using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Rebound.enum_types.Weapons;
using Rebound.Models;

namespace Rebound.Weapons.War_Hammar
{
    public class WarHammar : WeaponBase
    {
        public WarHammar() : base(new WeaponModel("Ancient War Hammar", "A thick oblong shaped hammer head with a slightly jagged flat side, and a sharp pointed tipped blade on the other side. The shaft is mostly decorated in gold and emeralds from long ago.", true,5,9,3,WeaponTypes.WarHammar))
        {
        }
    }
}
