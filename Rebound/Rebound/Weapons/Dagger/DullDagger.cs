using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Rebound.enum_types.Weapons;
using Rebound.Models;

namespace Rebound.Weapons.Dagger
{
    public class DullDagger : WeaponBase
    {
        public DullDagger() : base(new WeaponModel("Dull Dagger", "A small, narrow, worn blade made of folded steel and held by a grip wrapped in dark deerskin. If you squint, you notice odd writting carved into the grip in between the deerskin. " +
                                                                  "The dagger has a wide pommel decorated with a fairly common green gem.", false,1,5,7,WeaponTypes.Dagger))
        {
        }
    }
}
