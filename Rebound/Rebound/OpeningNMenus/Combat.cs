using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Rebound.Characters;

namespace Rebound.OpeningNMenus
{
   public class Combat
    {
        public static void DoCombat(AllCharacters attacker, AllCharacters defender, bool isFleeing = false)
        {
            int block = defender.GetBlock();
            var attack = attacker.GetHitAndDamage();

            if (!isFleeing && block >= attack.Hit )
            {
                Console.WriteLine("The attack was blocked!\n");
            }
            else
            {
                defender.Character.Life -= attack.Damage;
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"{attacker.Character.Name} hits {defender.Character.Name} for {attack.Damage}");
                Console.ResetColor();
            }
          
          
        }
    }
}
