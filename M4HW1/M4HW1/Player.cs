using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M4HW1
{
    class Player : MobileObject
    {
        private int rebelRep = 0;
        private int empireRep = 0;
        private int unaffilliatedRep = 0;
        private int gold = 0;
        private bool receivedLoot = false;

        public Player()
        {
            health = 100;
            attackDamage = 25;
            canAttack = true;

            rebelRep = rebel;
            empireRep = empire;
            unaffilliatedRep = unaff;

            receivedLoot = received;
        }

        public int rebel { get { return rebelRep; } set { rebelRep = value; } }
        public int empire { get { return empireRep; } set { empireRep = value; } }
        public int unaff { get { return unaffilliatedRep; } set { unaffilliatedRep = value; } }
        public bool received { get { return receivedLoot; } set { receivedLoot = value; } } 

        public Rooms currentLocation { get; set; }
        public Items currentItemInvetory { get; set; }

        public string factionRep()
        {
            string output = "Rebel Repuation = " + rebelRep + "\n" +
                            "Empire Reputation = " + empireRep + "\n" +
                            "Unaffiliated Reputation = " + unaffilliatedRep + "\n";

            return output;
        }
    }
}
