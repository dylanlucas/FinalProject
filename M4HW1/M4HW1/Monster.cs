using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M4HW1
{
    class Monster : MobileObject
    {
        private bool isDead;

        public Monster()
        {
            health = 100;
            attackDamage = 20;
            canAttack = true;

            isDead = dead;
        }

        public bool dead { get { return isDead; } set { isDead = value; } }
    }
}
