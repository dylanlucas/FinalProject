using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M4HW1
{
    enum Faction { REBEL, EMPIRE, UNAFFILIATED };
    class MobileObject
    {
        private int _HealthPoints;
        private int _AttackDamage;
        private bool _CanAttack = false;

        public int health { get { return _HealthPoints; } set { _HealthPoints = value; } }
        public int attackDamage { get { return _AttackDamage; } set { _AttackDamage = value; } }
        public bool canAttack { get { return _CanAttack; } set { _CanAttack = value; } }

        public void onSpawn()
        {
            health = 100;
            attackDamage = _AttackDamage;
            canAttack = true;
        }

        public void onDeath()
        {
            health = 0;
            attackDamage = _AttackDamage;
            canAttack = false;
        }

        public int onCombatStart()
        {
            Random rand = new Random();

            int result;

            result = rand.Next(_AttackDamage) + 1;
            return result;

        }

        public string getNPCFaction()
        {
            Random random = new Random();
            Faction npcFaction = new Faction();

            int result;
            result = random.Next(9);
            if (result == 1 || result == 2 || result == 3)
            {
                npcFaction = Faction.REBEL;
            }
            else if (result == 4 || result == 5 || result == 6)
            {
                npcFaction = Faction.EMPIRE;
            }
            else
            {
                npcFaction = Faction.UNAFFILIATED;
            }

            return npcFaction.ToString();
        }

        public string getMOBFaction()
        {
            Random rand = new Random();
            Faction monsterFaction = new Faction();

            int result;
            result = rand.Next(3);
            if (result == 1)
            {
                monsterFaction = Faction.REBEL;
            }
            else if (result == 2)
            {
                monsterFaction = Faction.EMPIRE;
            }
            else
            {
                monsterFaction = Faction.UNAFFILIATED;
            }

            return monsterFaction.ToString();
        }

                public string getMoney()
        {
            Random random = new Random();

            int result;
            result = random.Next(500);

            return result.ToString();
        }
    }
}
