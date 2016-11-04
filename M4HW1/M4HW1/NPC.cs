using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M4HW1
{
    class NPC : MobileObject
    {
        public bool thanked = true;

        public NPC()
        {
            health = 100;
            attackDamage = 0;
            canAttack = false;
        }
    }
}
