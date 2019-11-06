using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Rebound.enum_types.Weapons;
using Rebound.Models;
using Rebound.Weapons;

namespace Rebound.Weapons.Axe
{
    public class DaneAxe : WeaponBase
    {
        public DaneAxe() : base(new WeaponModel("Dane Axe",
            "A sturdy, long handle made of smooth wood, wrapped in decorative leather and topped with a surprisingly sharp axe head. It appears to be of Viking descent.",
            true, 3, 8, 4, WeaponTypes.Axe))
        {
        }

}
}
