using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace M4HW1
{
    public partial class Form1 : Form
    {
        //Create Player Object
        Player playerOne = new M4HW1.Player();

        //Create an Opponent Object
        Monster opponent = new Monster();

        //Create NPC object
        NPC npc = new NPC();

        int playerResult, opponentResult, npcResult;

        public Form1()
        {
            InitializeComponent();

            //Initialize the back color of the display rich text box
            displayRTB.BackColor = Color.White;

            //Initialize the back color and other things of the faction reputation rich text box
            playerStatusRTB.BackColor = Color.White;
            playerStatusRTB.Text = playerOne.factionRep() + "\n" + playerOne.goldAmt() + "\n";


            //Display Player Stats
            healthDisplayLabel.Text = playerOne.health.ToString();
            attackDamageDisplayLabel.Text = playerOne.attackDamage.ToString();

            //Display Opponent Stats
            oppHealthLabel.Text = opponent.health.ToString();
            oppADLabel.Text = opponent.attackDamage.ToString();
            oppFDLabel.Text = opponent.getMOBFaction();

            //Display NPC Stats
            npcHealthDisplay.Text = npc.health.ToString();
            npcADLabel.Text = npc.attackDamage.ToString();
            npcFDDisplay.Text = npc.getNPCFaction();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            
            playerResult = playerOne.onCombatStart();
            opponentResult = opponent.onCombatStart();


            if (playerOne.health > 0 && playerOne.health <= 100)
            {
                displayRTB.Text += "Player One attacked Opponent for " + playerResult.ToString() + "\n";
                playerOne.health = playerOne.health - opponentResult;
                healthDisplayLabel.Text = playerOne.health.ToString();
            }

            if (playerOne.health <= 0)
            {
                healthDisplayLabel.Text = "0";
                displayRTB.Text += "Player One had died.\n";
                attackDamageDisplayLabel.Text = "0";
                playerOne.onDeath();
                displayRTB.Text += "The game is now over.\n";
                attackButton.Visible = false;
                displayRTB.Text += "Please close the game.\n";
            }

            if (opponent.health > 0 && opponent.health <= 100)
            {
                displayRTB.Text += "Opponent attacked Player One for " + opponentResult.ToString() + "\n";
                opponent.health = opponent.health - playerResult;
                oppHealthLabel.Text = opponent.health.ToString();
            }

            if (opponent.health <= 0)
            {
                oppHealthLabel.Text = "0";

                attackButton.Enabled = false;

                if (oppFDLabel.Text == Faction.REBEL.ToString())
                {
                    playerOne.rebel -= 100;
                    playerOne.empire += 100;
                    playerOne.unaff += 50;
                    playerStatusRTB.Text = playerOne.factionRep() + "\n";

                    if (playerOne.rebel <= -500)
                    {
                        opponent.attackDamage = 50;
                    }
                    else if (playerOne.empire <= -500)
                    {
                        opponent.attackDamage = 50;
                    }
                    else if (playerOne.unaff <= -500)
                    {
                        opponent.attackDamage = 50;
                    }
                }
                else if (oppFDLabel.Text == Faction.EMPIRE.ToString())
                {
                    playerOne.empire -= 100;
                    playerOne.rebel += 100;
                    playerOne.unaff += 50;
                    playerStatusRTB.Text = playerOne.factionRep() + "\n";

                    if (playerOne.rebel <= -500)
                    {
                        opponent.attackDamage = 50;
                    }
                    else if (playerOne.empire <= -500)
                    {
                        opponent.attackDamage = 50;
                    }
                    else if (playerOne.unaff <= -500)
                    {
                        opponent.attackDamage = 50;
                    }
                }
                else if (oppFDLabel.Text == Faction.UNAFFILIATED.ToString())
                {
                    playerOne.unaff -= 100;
                    playerOne.empire += 50;
                    playerOne.rebel -= 50;
                    playerStatusRTB.Text = playerOne.factionRep() + "\n";

                    if (playerOne.rebel <= -500)
                    {
                        opponent.attackDamage = 50;
                    }
                    else if (playerOne.empire <= -500)
                    {
                        opponent.attackDamage = 50;
                    }
                    else if (playerOne.unaff <= -500)
                    {
                        opponent.attackDamage = 50;
                    }
                }

                oppADLabel.Text = "";
                oppFDLabel.Text = "";
                opponent.onDeath();

                displayRTB.Text += "Opponent has died. \n";
            }

            if (attackButton.Enabled == false)
            {
                // Restore values / create new objects
                displayRTB.Text += "Let's you heal you up after that intense battle.\n";

                //Player One health
                playerOne.health = 100;
                healthDisplayLabel.Text = playerOne.health.ToString();

                displayRTB.Text += "A NEW OPPONENT HAS APPROACHED YOU!\n";

                //Create an Opponent Object
                opponent.onSpawn();

                //Display Opponent Stats
                oppHealthLabel.Text = opponent.health.ToString();
                oppADLabel.Text = opponent.attackDamage.ToString();
                oppFDLabel.Text = opponent.getMOBFaction();

                attackButton.Enabled = true;
            }

            displayRTB.SelectionStart = displayRTB.Text.Length;
            displayRTB.ScrollToCaret();
        }
    }
}
