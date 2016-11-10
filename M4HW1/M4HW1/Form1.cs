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

        //Create MOB Object
        Monster opponent = new Monster();

        //Create NPC object
        NPC npc = new NPC();

        //Create World object
        Rooms nightmare = new Rooms();
        Rooms r1 = new Rooms();
        Rooms r2 = new Rooms();
        Rooms r3 = new Rooms();
        Rooms r4 = new Rooms();
        Rooms r5 = new Rooms();
        Rooms r6 = new Rooms();
        Rooms r7 = new Rooms();
        Rooms r8 = new Rooms();
        Rooms r9 = new Rooms();
        Rooms r10 = new Rooms();
        Rooms r11 = new Rooms();
        Rooms r12 = new Rooms();
        Rooms r13 = new Rooms();
        Rooms r14 = new Rooms();
        Rooms r15 = new Rooms();

        //Create Item objects
        Items sword = new Items();
        Items potion = new Items();
        Items bottle = new Items();
        Items excalibur = new Items();
        Items questlog = new Items();
        Items scroll = new Items();
        Items document = new Items();
        Items oppHead = new Items();

        int playerResult, opponentResult;

        public Form1()
        {
            InitializeComponent();

            //Initialize the back color of the display rich text box
            displayRTB.BackColor = Color.White;

            //Initialize the back color and other things of the faction reputation rich text box
            playerStatusRTB.BackColor = Color.White;
            playerStatusRTB.Text = playerOne.factionRep();

            //Initialize the back color of the location rich text box
            locationRTB.BackColor = Color.White;

            //Initialize the back color of the npc rich text box
            npcRTB.BackColor = Color.White;

            //Display Player Stats
            healthDisplayLabel.Text = playerOne.health.ToString();
            attackDamageDisplayLabel.Text = playerOne.attackDamage.ToString();

            //Display NPC Stats
            npcHealthDisplay.Text = npc.health.ToString();
            npcADLabel.Text = npc.attackDamage.ToString();
            npcFDDisplay.Text = npc.getNPCFaction();

            //Initialize Rooms

            //ROOM NIGHTMARE (Dream room before default location)
            nightmare.roomName = "A dark spooky scary place.\n";
            nightmare.roomDescription = "You see a floor under you but darkness everywhere else....\n";
            nightmare.roomDescription += "There is something in this room that you must attack.\n";
            nightmare.northExit = false;
            nightmare.eastExit = false;
            nightmare.southExit = false;
            nightmare.westExit = false;

            playerOne.currentLocation = nightmare;

            //ROOM ONE              
            r1.roomName = "Town Square\n";
            r1.roomDescription = "The center of the entire town that you live in.\n";
            r1.northExit = true;
            r1.eastExit = true;
            r1.southExit = true;
            r1.westExit = true;

            //ROOM TWO              DEFAULT LOCATION
            r2.roomName = "Home\n";
            r2.roomDescription = "Your home, where you sleep and eat.\n";
            r2.roomDescription += "You see a note left beside your bed.. it tells you to gather your things and head to the Quest Hall.\n";
            r2.northExit = true;
            r2.eastExit = false;
            r2.southExit = false;
            r2.westExit = false;

            lootButton.Enabled = true;

            //ROOM THREE
            r3.roomName = "Town Market\n";
            r3.roomDescription = "A place where you can buy weapons and potions!\n";
            r3.roomDescription += "You see an NPC in this room! (Click the load button)\n";
            r3.northExit = false;
            r3.eastExit = false;
            r3.southExit = false;
            r3.westExit = true;

            //ROOM FOUR
            r4.roomName = "Quest Hall\n";
            r4.roomDescription = "Where the young adventurer can receive quests if any exist!\n";
            r4.roomDescription += "You see a NPC in this room! (Click the load button)\n";
            r4.roomDescription += "If you have the Mob Head or the Document push talk!";
            r4.northExit = false;
            r4.eastExit = true;
            r4.southExit = false;
            r4.westExit = false;

            //ROOM FIVE
            r5.roomName = "Town Exit\n";
            r5.roomDescription = "The entrance and exit to the town.\n";
            r5.northExit = true;
            r5.eastExit = false;
            r5.southExit = true;
            r5.westExit = false;

            //ROOM SIX
            r6.roomName = "Woods\n";
            r6.roomDescription = "The player find's themselves in the woods... Very tall trees... closely packed together.....\n";
            r6.northExit = true;
            r6.eastExit = true;
            r6.southExit = true;
            r6.westExit = true;

            //ROOM SEVEN
            r7.roomName = "Gnome Hut\n";
            r7.roomDescription = "You come across a little hut and see a gnome in it. The gnome has something to ask you!\n";
            r7.northExit = false;
            r7.eastExit = false;
            r7.southExit = false;
            r7.westExit = true;

            //ROOM EIGHT
            r8.roomName = "Pond\n";
            r8.roomDescription = "You find a nice little quiet pond in the woods.\n";
            r8.northExit = false;
            r8.eastExit = true;
            r8.southExit = false;
            r8.westExit = false;

            //ROOM NINE
            r9.roomName = "Clearing\n";
            r9.roomDescription = "You've finally escaped the woods and are in a giant plains area.\n";
            r9.roomDescription += "Click load mobs\n";
            r9.northExit = true;
            r9.eastExit = false;
            r9.southExit = true;
            r9.westExit = false;

            //ROOM TEN
            r10.roomName = "The Castle\n";
            r10.roomDescription = "You've found an old castle\n";
            r10.roomDescription += "Click load mobs\n";
            r10.northExit = true;
            r10.eastExit = false;
            r10.southExit = true;
            r10.westExit = false;

            //ROOM ELEVEN
            r11.roomName = "The Castle Foyer\n";
            r11.roomDescription = "You're now inside the castle and see lots of rooms you could go into!\n";
            r11.roomDescription += "Click load mobs\n";
            r11.northExit = true;
            r11.eastExit = true;
            r11.westExit = true;
            r11.southExit = true;

            //ROOM TWELEVE
            r12.roomName = "The Living Room\n";
            r12.roomDescription = "You have found what looks like to be a living room.\n";
            r12.roomDescription += "Click load mobs\n";
            r12.northExit = false;
            r12.eastExit = false;
            r12.southExit = false;
            r12.westExit = true;

            //ROOM THIRTEEN
            r13.roomName = "The Kitchen\n";
            r13.roomDescription = "You have found what looks like to be a kitchen.\n";
            r13.roomDescription += "Click load mobs\n";
            r13.northExit = false;
            r13.eastExit = true;
            r13.southExit = false;
            r13.westExit = false;

            //ROOM FOURTEEN
            r14.roomName = "Hallway\n";
            r14.roomDescription = "You are now in a long dark hallway with only two exits, the one you came through and the one infront of you.\n";
            r14.northExit = true;
            r14.eastExit = false;
            r14.southExit = true;
            r14.westExit = false;

            //ROOM FIFTEEN
            r15.roomName = "Boss Room\n";
            r15.roomDescription = "The final fight room... will you survive?\n";
            r15.northExit = false;
            r15.eastExit = false;
            r15.southExit = false;
            r15.westExit = false;

            //Setup player location
            locationRTB.Text += "Current Location : " + playerOne.currentLocation;

            //Initialize Items
            playerInventoryListBox.Items.Add("Sword");

            //NPC SET UP
            label10.Visible = false;
            label11.Visible = false;
            label13.Visible = false;
            npcHealthDisplay.Visible = false;
            npcADLabel.Visible = false;
            npcFDDisplay.Visible = false;

            displayRTB.SelectionStart = displayRTB.Text.Length;
            displayRTB.ScrollToCaret();

            //ROOM INITIALIZATION SET UP
            if (playerOne.currentLocation == nightmare)
            {
                opponent.health = 100;
                opponent.attackDamage = 30;
                opponent.canAttack = true;

                oppHealthLabel.Text = opponent.health.ToString();
                oppADLabel.Text = opponent.attackDamage.ToString();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void lootButton_Click(object sender, EventArgs e)
        {
            if (playerOne.currentLocation == r2)
            {
                if (playerOne.received == false)
                {
                    playerInventoryListBox.Items.Add("Potion");
                    MessageBox.Show("You have looted the potion");
                    playerInventoryListBox.Items.Add("Bottle");
                    playerOne.received = true;
                    MessageBox.Show("You have looted the empty bottle");
                }
                else
                {
                    MessageBox.Show("You have already received this item.");
                }
            }

            if (opponent.dead == true)
            {
                if (playerOne.received == true)
                {
                    lootButton.Enabled = false;
                }
                else
                {
                    playerOne.received = true;
                }
            }
            else
            {
                lootButton.Enabled = false;
            }
        }

        private void npcADLabel_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (playerOne.currentLocation == r1)
            {
                playerOne.currentLocation = r3;
                locationRTB.Text += "Player One has moved East.\n\n";
                locationRTB.Text += playerOne.currentLocation.ToString();
            }
            else if (playerOne.currentLocation == r4)
            {
                playerOne.currentLocation = r1;
                locationRTB.Text += "Player One has moved East.\n\n";
                locationRTB.Text += playerOne.currentLocation.ToString();
            }
            else if (playerOne.currentLocation == r6)
            {
                playerOne.currentLocation = r7;
                locationRTB.Text += "Player One has moved East.\n\n";
                locationRTB.Text += playerOne.currentLocation.ToString();
            }
            else if (playerOne.currentLocation == r8)
            {
                playerOne.currentLocation = r6;
                locationRTB.Text += "Player One has moved East.\n\n";
                locationRTB.Text += playerOne.currentLocation.ToString();
            }
            else if (playerOne.currentLocation == r11)
            {
                playerOne.currentLocation = r12;
                locationRTB.Text += "Player One has moved East.\n\n";
                locationRTB.Text += playerOne.currentLocation.ToString();
            }
            else if (playerOne.currentLocation == r13)
            {
                playerOne.currentLocation = r11;
                locationRTB.Text += "Player One has moved Easth.\n\n";
                locationRTB.Text += playerOne.currentLocation.ToString();
            }
            else
            {
                MessageBox.Show("There is no East exit.");
            }

            locationRTB.SelectionStart = locationRTB.Text.Length;
            locationRTB.ScrollToCaret();  
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (playerOne.currentLocation == r2)
            {
                playerOne.currentLocation = r1;
                locationRTB.Text += "Player One has moved North.\n\n";
                locationRTB.Text += playerOne.currentLocation.ToString();
            }
            else if (playerOne.currentLocation == r1)
            {
                playerOne.currentLocation = r5;
                locationRTB.Text += "Player One has moved North.\n\n";
                locationRTB.Text += playerOne.currentLocation.ToString();
            }
            else if (playerOne.currentLocation == r5)
            {
                playerOne.currentLocation = r6;
                locationRTB.Text += "Player One has moved North.\n\n";
                locationRTB.Text += playerOne.currentLocation.ToString();
            }
            else if (playerOne.currentLocation == r6)
            {
                playerOne.currentLocation = r9;
                locationRTB.Text += "Player One has moved North.\n\n";
                locationRTB.Text += playerOne.currentLocation.ToString();
            }
            else if (playerOne.currentLocation == r9)
            {
                playerOne.currentLocation = r10;
                locationRTB.Text += "Player One has moved North.\n\n";
                locationRTB.Text += playerOne.currentLocation.ToString();
            }
            else if (playerOne.currentLocation == r10)
            {
                playerOne.currentLocation = r11;
                locationRTB.Text += "Player One has moved North.\n\n";
                locationRTB.Text += playerOne.currentLocation.ToString();
            }
            else if (playerOne.currentLocation == r11)
            {
                playerOne.currentLocation = r14;
                locationRTB.Text += "Player One has moved North.\n\n";
                locationRTB.Text += playerOne.currentLocation.ToString();
            }
            else if (playerOne.currentLocation == r14)
            {
                playerOne.currentLocation = r15;
                locationRTB.Text += "Player One has moved North.\n\n";
                locationRTB.Text += playerOne.currentLocation.ToString();
            }
            else
            {
                MessageBox.Show("You cannot go North.");
            }

            locationRTB.SelectionStart = locationRTB.Text.Length;
            locationRTB.ScrollToCaret();
        }

        private void westButton_Click(object sender, EventArgs e)
        {
            if (playerOne.currentLocation == r1)
            {
                playerOne.currentLocation = r4;
                locationRTB.Text += "Player One has moved West.\n\n";
                locationRTB.Text += playerOne.currentLocation.ToString();
            }
            else if (playerOne.currentLocation == r3)
            {
                playerOne.currentLocation = r1;
                locationRTB.Text += "Player One has moved West.\n\n";
                locationRTB.Text += playerOne.currentLocation.ToString();
            }
            else if (playerOne.currentLocation == r6)
            {
                playerOne.currentLocation = r8;
                locationRTB.Text += "Player One has moved West.\n\n";
                locationRTB.Text += playerOne.currentLocation.ToString();
            }
            else if (playerOne.currentLocation == r7)
            {
                playerOne.currentLocation = r6;
                locationRTB.Text += "Player One has moved West.\n\n";
                locationRTB.Text += playerOne.currentLocation.ToString();
            }
            else if (playerOne.currentLocation == r11)
            {
                playerOne.currentLocation = r13;
                locationRTB.Text += "Player One has moved West.\n\n";
                locationRTB.Text += playerOne.currentLocation.ToString();
            }
            else if (playerOne.currentLocation == r12)
            {
                playerOne.currentLocation = r11;
                locationRTB.Text += "Player One has moved West.\n\n";
                locationRTB.Text += playerOne.currentLocation.ToString();
            }
            else
            {
                MessageBox.Show("There is no West exit.");
            }

            locationRTB.SelectionStart = locationRTB.Text.Length;
            locationRTB.ScrollToCaret();
        }

        private void southButton_Click(object sender, EventArgs e)
        {
            if (playerOne.currentLocation == r1)
            {
                playerOne.currentLocation = r2;
                locationRTB.Text += "Player One has moved South.\n\n";
                locationRTB.Text += playerOne.currentLocation.ToString();
            }
            else if (playerOne.currentLocation == r5)
            {
                playerOne.currentLocation = r1;
                locationRTB.Text += "Player One has moved South.\n\n";
                locationRTB.Text += playerOne.currentLocation.ToString();
            }
            else if (playerOne.currentLocation == r6)
            {
                playerOne.currentLocation = r5;
                locationRTB.Text += "Player One has moved South.\n\n";
                locationRTB.Text += playerOne.currentLocation.ToString();
            }
            else if (playerOne.currentLocation == r9)
            {
                playerOne.currentLocation = r6;
                locationRTB.Text += "Player One has moved South.\n\n";
                locationRTB.Text += playerOne.currentLocation.ToString();
            }
            else if (playerOne.currentLocation == r10)
            {
                playerOne.currentLocation = r9;
                locationRTB.Text += "Player One has moved South.\n\n";
                locationRTB.Text += playerOne.currentLocation.ToString();
            }
            else if (playerOne.currentLocation == r11)
            {
                playerOne.currentLocation = r10;
                locationRTB.Text += "Player One has moved South.\n\n";
                locationRTB.Text += playerOne.currentLocation.ToString();
            }
            else if (playerOne.currentLocation == r14)
            {
                playerOne.currentLocation = r11;
                locationRTB.Text += "Player One has moved South.\n\n";
                locationRTB.Text += playerOne.currentLocation.ToString();
            }
            else if (oppHead.received == true || document.received == true)
            {
                playerOne.currentLocation = r14;
                locationRTB.Text += "Player One has moved South.\n\n";
                locationRTB.Text += playerOne.currentLocation.ToString();
            }
            else
            {
                MessageBox.Show("There is no South exit.");
            }

            locationRTB.SelectionStart = locationRTB.Text.Length;
            locationRTB.ScrollToCaret();
        }

        private void inventoryButton_Click(object sender, EventArgs e)
        {
        }

        private void equipButton_Click(object sender, EventArgs e)
        {
            if (playerInventoryListBox.SelectedItem.ToString() == "")
            {
                MessageBox.Show("Please select an item!");
            }
            else if (playerInventoryListBox.SelectedItem.ToString() == "Sword")
            {
                if (sword.isEquiped == false)
                {
                    MessageBox.Show("You have equipped the Sword!");
                    playerOne.attackDamage = 50;
                    attackDamageDisplayLabel.Text = playerOne.attackDamage.ToString();
                    sword.isEquiped = true;
                }
                else if (sword.isEquiped == true)
                {
                    MessageBox.Show("You have already equipped the Sword!");
                }
            }
            else if (playerInventoryListBox.SelectedItem.ToString() == "Excalibur")
            {
                if (excalibur.isEquiped == true)
                {
                    MessageBox.Show("You have equipped EXCALIBUR!");
                    playerOne.attackDamage = 9001;
                    attackDamageDisplayLabel.Text = playerOne.attackDamage.ToString();
                    excalibur.isEquiped = true;
                }
                else if (excalibur.isEquiped == false)
                {
                    MessageBox.Show("You have already equipped Excalibur");
                }
            }
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            
        }

        private void unequipButton_Click(object sender, EventArgs e)
        {
            if (playerInventoryListBox.SelectedItem.ToString() == "")
            {
                MessageBox.Show("Please select an item to unequip!");
            }
            else if (sword.isEquiped == true)
            {
                if (playerInventoryListBox.SelectedItem.ToString() == "Sword")
                {
                    MessageBox.Show("You have unequipped the Sword");
                    playerOne.attackDamage = 25;
                    attackDamageDisplayLabel.Text = playerOne.attackDamage.ToString();
                    sword.isEquiped = false;
                }
            }
            else if (sword.isEquiped == false)
            {
                MessageBox.Show("The Sword is not equipped.");
            }
            else if (excalibur.isEquiped == true)
            {
                if (playerInventoryListBox.SelectedItem.ToString() == "Excalibur")
                {
                    MessageBox.Show("You have unequipped the Excalibur");
                    playerOne.attackDamage = 25;
                    attackDamageDisplayLabel.Text = playerOne.attackDamage.ToString();
                    excalibur.isEquiped = false;
                }
            }
            else if (excalibur.isEquiped == false)
            {
                MessageBox.Show("Excalibur is not equipped.");
            }
        }

        private void useButton_Click(object sender, EventArgs e)
        {
            if (playerInventoryListBox.SelectedItem.ToString() == "Potion")
            {
                if (playerOne.health < 100)
                {
                    MessageBox.Show("You have used the Potion");
                    playerOne.health += 50;
                    healthDisplayLabel.Text = playerOne.health.ToString();
                    if (playerOne.health >= 100)
                    {
                        playerOne.health = 100;
                    }
                    playerInventoryListBox.Items.Remove("Potion");
                }
                else
                {
                    MessageBox.Show("You have max health! No reason to heal!");
                }
            }

            else if (playerInventoryListBox.SelectedItem.ToString() == "Protection Scroll")
            {
                MessageBox.Show("You have used the Protection Scroll!");
                playerOne.health += 400;
                healthDisplayLabel.Text = playerOne.health.ToString();
                playerInventoryListBox.Items.Remove("Protection Scroll");
            }

            else if (playerOne.currentLocation == r8)
            {
                if (playerInventoryListBox.SelectedItem.ToString() == "Bottle")
                {
                    if (bottle.isFilled == false)
                    {
                        MessageBox.Show("You have filled the bottle with water from the pond.");
                        bottle.isFilled = true;
                    }
                    else if (bottle.isFilled == true)
                    {
                        MessageBox.Show("The bottle is already filled!");
                    }
                }
            }
        }

        private void userInputTB_TextChanged(object sender, EventArgs e)
        {

        }

        private void loadButton_Click(object sender, EventArgs e)
        {
            if (playerOne.currentLocation == r3)
            {
                label10.Visible = true;
                label11.Visible = true;
                label13.Visible = true;
                npcHealthDisplay.Visible = true;
                npcADLabel.Visible = true;
                npcFDDisplay.Visible = true;

                npcRTB.Text += "Hello and welcome to my shop! How may I assist you?\n";
            }
            else if (playerOne.currentLocation == r4)
            {
                label10.Visible = true;
                label11.Visible = true;
                label13.Visible = true;
                npcHealthDisplay.Visible = true;
                npcADLabel.Visible = true;
                npcFDDisplay.Visible = true;

                npcRTB.Text += "Hello.... I have been expecting you....\n";
                MessageBox.Show("Push talk");
            }
            else if (playerOne.currentLocation == r7)
            {
                label10.Visible = true;
                label11.Visible = true;
                label13.Visible = true;
                npcHealthDisplay.Visible = true;
                npcADLabel.Visible = true;
                npcFDDisplay.Visible = true;

                npcRTB.Text += "Why are you in my HUT?\n";
                MessageBox.Show("Chose your words wisely");
                MessageBox.Show("Say 'hello gnome'");
            }
            else if (playerOne.currentLocation == r15)
            {
                MessageBox.Show("Say '...'");
            }

            npcRTB.SelectionStart = displayRTB.Text.Length;
            npcRTB.ScrollToCaret();
        }

        private void talkButton_Click(object sender, EventArgs e)
        {
            if(playerOne.currentLocation == r3)
            {
                if (textBox1.Text.ToLower() == "")
                {
                    npcRTB.Text += "What? Say help!\n";
                    textBox1.Text = "";
                    textBox1.Focus();

                    npcRTB.SelectionStart = displayRTB.Text.Length;
                    npcRTB.ScrollToCaret();
                }
                else if (textBox1.Text.ToLower() == "help")
                {
                    MessageBox.Show("Say 'buy'");
                    textBox1.Text = "";
                    textBox1.Focus();

                    npcRTB.SelectionStart = displayRTB.Text.Length;
                    npcRTB.ScrollToCaret();
                }

                if (textBox1.Text.ToLower() == "buy")
                {
                    npcRTB.Text += "How much gold do you have?\n";
                    textBox1.Text = "";
                    textBox1.Focus();

                    npcRTB.SelectionStart = displayRTB.Text.Length;
                    npcRTB.ScrollToCaret();
                }

                if (textBox1.Text.ToLower() == "0")
                {
                    npcRTB.Text += "You have no money to purchase any of my wares.... but if you solve one of my riddles ill give you one free item!\n";
                    textBox1.Text = "";
                    textBox1.Focus();
                    MessageBox.Show("Say 'riddle'");

                    npcRTB.SelectionStart = displayRTB.Text.Length;
                    npcRTB.ScrollToCaret();
                }

                if (textBox1.Text.ToLower() == "riddle")
                {
                    npcRTB.Text += "I sometimes run, but I cannot walk. You always follow me around. What am I?\n";
                    textBox1.Text = "";
                    textBox1.Focus();

                    npcRTB.SelectionStart = displayRTB.Text.Length;
                    npcRTB.ScrollToCaret();
                }

                if (textBox1.Text.ToLower() == "nose")
                {
                    npcRTB.Text += "THAT'S CORRECT!, Here take this piece of a sword!\n";
                    npcRTB.Text += "If you answer this next riddle correctly ill give you another piece to that sword!\n";
                    MessageBox.Show("Say 'okay'");
                    textBox1.Text = "";
                    textBox1.Focus();

                    npcRTB.SelectionStart = displayRTB.Text.Length;
                    npcRTB.ScrollToCaret();
                }

                if (textBox1.Text.ToLower() == "okay")
                {
                    npcRTB.Text += "The more of them you take, the more you leave behind. What are they?";
                    textBox1.Text = "";
                    textBox1.Focus();

                    npcRTB.SelectionStart = displayRTB.Text.Length;
                    npcRTB.ScrollToCaret();
                }

                if (textBox1.Text.ToLower() == "footsteps") 
                {
                    npcRTB.Text += "THAT'S CORRECT AGAIN! Here's the 2nd piece of the sword! To bad you don't know how to put it together...\n";
                    npcRTB.Text += "I could put it together for you.. but you're gonna have to answer some more riddles\n";
                    npcRTB.SelectionStart = displayRTB.Text.Length;
                    npcRTB.ScrollToCaret();
                    MessageBox.Show("Say 'ok'");
                    textBox1.Text = "";
                    textBox1.Focus();

                    npcRTB.SelectionStart = displayRTB.Text.Length;
                    npcRTB.ScrollToCaret();
                }

                if (textBox1.Text.ToLower() == "ok")
                {
                    npcRTB.Text += "THAT'S THE SPIRIT!\n";
                    npcRTB.Text += "What is a kitten after it is 7 months old?\n";
                    npcRTB.SelectionStart = displayRTB.Text.Length;
                    npcRTB.ScrollToCaret();
                    textBox1.Text = "";
                    textBox1.Focus();

                    npcRTB.SelectionStart = displayRTB.Text.Length;
                    npcRTB.ScrollToCaret();
                }

                if (textBox1.Text.ToLower() == "8 months old")
                {
                    npcRTB.Text += "CORRECTO! ready for the next one?\n";
                    npcRTB.SelectionStart = displayRTB.Text.Length;
                    npcRTB.ScrollToCaret();
                    MessageBox.Show("say 'yes'");
                    textBox1.Text = "";
                    textBox1.Focus();

                    npcRTB.SelectionStart = displayRTB.Text.Length;
                    npcRTB.ScrollToCaret();
                }

                if (textBox1.Text.ToLower() == "yes")
                {
                    npcRTB.Text += "The Pope has it but he does not use it. Your father has it but your mother uses it. Nuns do not need it. Your sisters husband has it and she uses it. What is it?\n";
                    npcRTB.SelectionStart = displayRTB.Text.Length;
                    npcRTB.ScrollToCaret();
                    textBox1.Text = "";
                    textBox1.Focus();

                    npcRTB.SelectionStart = displayRTB.Text.Length;
                    npcRTB.ScrollToCaret();
                }

                if (textBox1.Text.ToLower() == "a lastname")
                {
                    npcRTB.Text += "CORRECT! Okay I will give you the completed put together sword!\n";
                    npcRTB.SelectionStart = displayRTB.Text.Length;
                    npcRTB.ScrollToCaret();
                    MessageBox.Show("30 minutes have passed....");
                    textBox1.Text = "";
                    textBox1.Focus();
                    MessageBox.Show("Say 'hello?'");
                    textBox1.Text = "";

                    npcRTB.SelectionStart = displayRTB.Text.Length;
                    npcRTB.ScrollToCaret();
                }

                if (textBox1.Text.ToLower() == "hello?")
                {
                    npcRTB.Text += "HOLD ON! I'M STILL WORKING ON IT!\n";
                    npcRTB.SelectionStart = displayRTB.Text.Length;
                    npcRTB.ScrollToCaret();
                    MessageBox.Show("2 hours have passed....");
                    MessageBox.Show("2 additional hours have passed....");
                    npcRTB.Text += "Good! You're still here! I have completed making the sword for you! Faster than I thought. Here you go!\n";
                    textBox1.Text = "";

                    npcRTB.SelectionStart = displayRTB.Text.Length;
                    npcRTB.ScrollToCaret();

                    MessageBox.Show("Say 'thank you'");

                    northButton.Visible = false;
                    eastButton.Visible = false;
                    southButton.Visible = false;
                    westButton.Visible = false;

                    npcRTB.Text += ":)\n";

                    MessageBox.Show("Say it.....");

                    npcRTB.Text += "Isn't there something you would like to say?\n";

                    npcRTB.SelectionStart = displayRTB.Text.Length;
                    npcRTB.ScrollToCaret();
                }

                if (textBox1.Text.ToLower() == "thank you")
                {
                    textBox1.Text = "";
                    npcRTB.Text += "Thank you come again!\n";

                    northButton.Visible = true;
                    eastButton.Visible = true;
                    southButton.Visible = true;
                    westButton.Visible = true;

                    npcRTB.SelectionStart = displayRTB.Text.Length;
                    npcRTB.ScrollToCaret();

                    if (excalibur.received == false)
                    {
                        playerInventoryListBox.Items.Add("Excalibur");
                        excalibur.received = true;
                    }
                    else if (excalibur.received == true)
                    {
                        MessageBox.Show("You already have this item!");
                    }
                }
                else if (textBox1.Text.ToLower() == "no")
                {
                    MessageBox.Show("THE NPC HAS KILLED YOU FOR NOT THANKING HIM");
                    MessageBox.Show("THE GAME IS NOW OVER BECAUSE YOU WERE INCONSIDERATE");
                    equipButton.Visible = false;
                    unequipButton.Visible = false;
                    useButton.Visible = false;
                    playerOne.health = 0;
                    healthDisplayLabel.Text = playerOne.health.ToString();
                    northButton.Visible = false;
                    eastButton.Visible = false;
                    westButton.Visible = false;
                    southButton.Visible = false;
                    loadButton.Visible = false;
                    textBox1.Visible = false;
                    talkButton.Visible = false;
                    attackButton.Visible = false;
                    lootButton.Visible = false;

                    npcRTB.SelectionStart = displayRTB.Text.Length;
                    npcRTB.ScrollToCaret();
                }

                npcRTB.SelectionStart = displayRTB.Text.Length;
                npcRTB.ScrollToCaret();
            }

            npcRTB.SelectionStart = displayRTB.Text.Length;
            npcRTB.ScrollToCaret();

            if (playerOne.currentLocation == r4)
            {
                npcRTB.Text += "The town is in trouble! The neighboring village has declared war on us for owning an item named 'excalibur'? I have never heard of this item in my life!\n";
                npcRTB.Text += "The city and I were hoping you could help us out and try to talk to the neighboring village and talk some sense into them!\n";
                npcRTB.Text += "As you know... the city has no military forces so if they actually do go war with us.. its over... for all of us.\n";
                npcRTB.Text += "Please help us....\n";

                npcRTB.SelectionStart = displayRTB.Text.Length;
                npcRTB.ScrollToCaret();

                if (questlog.received == false)
                {
                    playerInventoryListBox.Items.Add("Quest Log");
                    questlog.received = true;
                }
                else
                {
                    MessageBox.Show("You already have this item.");
                }

                if (document.received == true)
                {
                    npcRTB.Text += "You have saved the city! You did it!\n";
                    MessageBox.Show("You have won the game with no conflict with the final boss!");
                    attackButton.Visible = false;
                    lootButton.Visible = false;
                    button1.Visible = false;
                    displayRTB.Visible = false;
                    talkButton.Visible = false;
                    textBox1.Visible = false;
                    npcRTB.Visible = false;
                    label16.Visible = false;
                    southButton.Visible = false;
                    eastButton.Visible = false;
                    northButton.Visible = false;
                    westButton.Visible = false;
                    locationRTB.Visible = false;
                    healthDisplayLabel.Visible = false;
                    label2.Visible = false;
                    label3.Visible = false;
                    attackDamageDisplayLabel.Visible = false;
                    playerInventoryListBox.Visible = false;
                    inventoryButton.Visible = false;
                    equipButton.Visible = false;
                    useButton.Visible = false;
                    unequipButton.Visible = false;
                    label6.Visible = false;
                    label7.Visible = false;
                    label8.Visible = false;
                    label10.Visible = false;
                    label11.Visible = false;
                    label13.Visible = false;
                    oppHealthLabel.Visible = false;
                    oppADLabel.Visible = false;
                    oppFDLabel.Visible = false;
                    npcHealthDisplay.Visible = false;
                    npcADLabel.Visible = false;
                    npcFDDisplay.Visible = false;
                    label4.Visible = false;
                    playerStatusRTB.Visible = false;
                    loadButton.Visible = false;

                }
                else if (oppHead.received == true)
                {
                    npcRTB.Text += "You have saved the city! You did it!\n";
                    MessageBox.Show("You have won the game by killing the final boss!");
                    attackButton.Visible = false;
                    lootButton.Visible = false;
                    button1.Visible = false;
                    displayRTB.Visible = false;
                    talkButton.Visible = false;
                    textBox1.Visible = false;
                    npcRTB.Visible = false;
                    label16.Visible = false;
                    southButton.Visible = false;
                    eastButton.Visible = false;
                    northButton.Visible = false;
                    westButton.Visible = false;
                    locationRTB.Visible = false;
                    healthDisplayLabel.Visible = false;
                    label2.Visible = false;
                    label3.Visible = false;
                    attackDamageDisplayLabel.Visible = false;
                    playerInventoryListBox.Visible = false;
                    inventoryButton.Visible = false;
                    equipButton.Visible = false;
                    useButton.Visible = false;
                    unequipButton.Visible = false;
                    label6.Visible = false;
                    label7.Visible = false;
                    label8.Visible = false;
                    label10.Visible = false;
                    label11.Visible = false;
                    label13.Visible = false;
                    oppHealthLabel.Visible = false;
                    oppADLabel.Visible = false;
                    oppFDLabel.Visible = false;
                    npcHealthDisplay.Visible = false;
                    npcADLabel.Visible = false;
                    npcFDDisplay.Visible = false;
                    label4.Visible = false;
                    playerStatusRTB.Visible = false;
                    loadButton.Visible = false;
                }

                npcRTB.SelectionStart = displayRTB.Text.Length;
                npcRTB.ScrollToCaret();
            }

            npcRTB.SelectionStart = displayRTB.Text.Length;
            npcRTB.ScrollToCaret();

            if (playerOne.currentLocation == r7)
            {
                textBox1.Focus();
                if (textBox1.Text.ToLower() == "hello gnome")
                {
                    textBox1.Text = "";
                    textBox1.Focus();
                    npcRTB.Text += "WHY ARE YOU HERE?\n";
                    npcRTB.SelectionStart = displayRTB.Text.Length;
                    npcRTB.ScrollToCaret();
                    MessageBox.Show("Say 'quest' or 'item'");

                    npcRTB.SelectionStart = displayRTB.Text.Length;
                    npcRTB.ScrollToCaret();
                }

                if (textBox1.Text.ToLower() == "quest")
                {
                    textBox1.Text = "";
                    textBox1.Focus();
                    npcRTB.Text += "Oh? What quest?\n";
                    npcRTB.SelectionStart = displayRTB.Text.Length;
                    npcRTB.ScrollToCaret();
                    MessageBox.Show("If you have the quest log say, 'quest log', otherwise say 'item'");

                }

                if (textBox1.Text.ToLower() == "item")
                {
                    textBox1.Text = "";
                    textBox1.Focus();
                    npcRTB.Text += "I KNEW IT! DIRTY HUMANS ALWAYS TRYING TO STEAL MY THINGS\n";
                    npcRTB.SelectionStart = displayRTB.Text.Length;
                    npcRTB.ScrollToCaret();
                    MessageBox.Show("The Gnome is now your enemy");
                    attackButton.Enabled = true;
                    opponent.onSpawn();

                    oppHealthLabel.Text = npc.health.ToString();
                    opponent.attackDamage = 1;
                    oppADLabel.Text = opponent.attackDamage.ToString();
                    oppFDLabel.Text = npc.getNPCFaction();

                    label10.Visible = false;
                    label11.Visible = false;
                    label13.Visible = false;
                    npcHealthDisplay.Visible = false;
                    npcADLabel.Visible = false;
                    npcFDDisplay.Visible = false;

                    textBox1.Visible = false;
                    talkButton.Visible = false;
                }

                if (questlog.received == true)
                {
                    if (textBox1.Text.ToLower() == "quest log")
                    {
                        textBox1.Text = "";
                        textBox1.Focus();
                        npcRTB.Text += "Oh! I hate the people in that Castle! Here take this scroll this is what you need! Good luck on your quest!\n";
                        npcRTB.SelectionStart = displayRTB.Text.Length;
                        npcRTB.ScrollToCaret();

                        if (scroll.received == false)
                        {
                            playerInventoryListBox.Items.Add("Protection Scroll");
                            scroll.received = true;
                        }
                        else if (scroll.received == true)
                        {
                            MessageBox.Show("You already have this item!");
                        }
                    }
                }

                npcRTB.SelectionStart = displayRTB.Text.Length;
                npcRTB.ScrollToCaret();
            }

            npcRTB.SelectionStart = displayRTB.Text.Length;
            npcRTB.ScrollToCaret();

            if (playerOne.currentLocation == r15)
            {
                if (textBox1.Text.ToLower() == "...")
                {
                    textBox1.Text = "";
                    textBox1.Focus();
                    npcRTB.Text += "You have fought me multiple times.... but that was merely me learning your skills and weakening you...\n";
                    npcRTB.Text += "It's time for our final fight. You either win here or die here....\n";
                    MessageBox.Show("Beg for mercy by saying please");
                }   

                if (textBox1.Text.ToLower() == "please")
                {
                    if (bottle.isFilled == true)
                    {
                        textBox1.Text = "";
                        textBox1.Focus();
                        npcRTB.Text += "Wait.... what's in that bottle that you have?\n";
                        MessageBox.Show("Say 'pond water'");
                    }
                    else
                    {
                        textBox1.Text = "";
                        npcRTB.Text += "It's time to FIGHT!";

                        attackButton.Enabled = true;

                        opponent.onSpawn();
                        opponent.health = 500;
                        oppHealthLabel.Text = opponent.health.ToString();
                        opponent.attackDamage = 100;
                        oppADLabel.Text = opponent.attackDamage.ToString();
                        oppFDLabel.Text = opponent.getMOBFaction();
                    }
                }

                if (textBox1.Text.ToLower() == "pond water")
                {
                    textBox1.Text = "";
                    textBox1.Focus();
                    npcRTB.Text += "The water from the pond in the forest?????........ Can.... Can I.... Can I have that pond water?\n";
                    MessageBox.Show("Say 'yes' or 'no'");
                }

                if (textBox1.Text.ToLower() == "yes")
                {
                    textBox1.Text = "";
                    textBox1.Focus();
                    npcRTB.Text += "THANK YOU THANK YOU! In this case I will give you this document stating that I have cancelled the war!\n";
                    
                    if (document.received == false)
                    {
                        MessageBox.Show("You have received the document!");
                        playerInventoryListBox.Items.Add("No War Document!");
                        document.received = true;
                        r15.southExit = true;
                    }
                    else if (document.received == true)
                    {
                        MessageBox.Show("You already have this item!");
                    }
                }
                else if (textBox1.Text.ToLower() == "no")
                {
                    textBox1.Text = "";
                    textBox1.Focus();
                    npcRTB.Text += "THEN FIGHT ME\n";

                    attackButton.Enabled = true;

                    opponent.onSpawn();
                    opponent.health = 500;
                    oppHealthLabel.Text = opponent.health.ToString();
                    opponent.attackDamage = 100;
                    oppADLabel.Text = opponent.attackDamage.ToString();
                    oppFDLabel.Text = opponent.getMOBFaction();
                }

                npcRTB.SelectionStart = displayRTB.Text.Length;
                npcRTB.ScrollToCaret();
            }

            npcRTB.SelectionStart = displayRTB.Text.Length;
            npcRTB.ScrollToCaret();
        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void inventoryButton_Click_1(object sender, EventArgs e)
        {
            if (playerInventoryListBox.SelectedItem.ToString() == "Sword")
            {
                MessageBox.Show("Item Name : \t\tA sword" + "\n\n" + "Item Description : \t\tA long steel sword.");
            }
            else if (playerInventoryListBox.SelectedItem.ToString() == "Excalibur")
            {
                MessageBox.Show("Item Name: \t\tA legendary sword" + "\n\n" + "Item Description : \t\tA sword that deals..... OVER 9000 DAMAGE?");
            }
            else if (playerInventoryListBox.SelectedItem.ToString() == "Potion")
            {
                MessageBox.Show("Item Name: \t\tA small potion of healing" + "\n\n" + "Item Description : \t\tA small potion that heals for 50 hit points");
            }
            else if (playerInventoryListBox.SelectedItem.ToString() == "Quest Log")
            {
                MessageBox.Show("Quest Log :\n" + "\n\n1) Leave the town.\n\n 2) Enter the Woods.\n\n 3) Find the Gnome Hut and take its scroll.\n\n 4) Find the Pond in the woods and take a bottle of the water.\n\n 5) Exit the woods.\n\n 6) Survive the clearing.\n\n 7) Find and enter the Castle.\n\n 8) Find the Castle Owner and talk to him.... or kill him.\n\n 9) Return here with the good news of no war...... or the head of the castle owner..");
            }
            else if (playerInventoryListBox.SelectedItem.ToString() == "Protection Scroll")
            {
                MessageBox.Show("Protection Scroll\n\n Grants the user 400 additional health points!");
            }
            else if (playerInventoryListBox.SelectedItem.ToString() == "Bottle")
            {
                MessageBox.Show("Item Name: \t\tBottle" + "\n\n" + "Item Description : \t\tA bottle that can hold liquids");
            }
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            if (playerOne.currentLocation == r9)
            {
                if (opponent.r9spawn == false)
                {
                    attackButton.Enabled = true;
                    northButton.Enabled = false;
                    eastButton.Enabled = false;
                    southButton.Enabled = false;
                    westButton.Enabled = false;
                    opponent.onSpawn();
                    opponent.health = 25;
                    oppHealthLabel.Text = opponent.health.ToString();
                    opponent.attackDamage = 25;
                    oppADLabel.Text = opponent.attackDamage.ToString();
                    oppFDLabel.Text = opponent.getMOBFaction().ToString();
                    opponent.r9spawn = true;

                    MessageBox.Show("FIGHT ME NOW!");
                }
                else if (opponent.r9spawn == true)
                {
                    MessageBox.Show("You've already spawned this mob!");
                }
            }

            if (playerOne.currentLocation == r10)
            {
                if (opponent.r10spawn == false)
                {
                    attackButton.Enabled = true;
                    northButton.Enabled = false;
                    eastButton.Enabled = false;
                    southButton.Enabled = false;
                    westButton.Enabled = false;
                    opponent.r10spawn = true;
                    MessageBox.Show(".... I'M NOT DONE WITH YOU!!!");

                    opponent.onSpawn();
                    opponent.health = 25;
                    oppHealthLabel.Text = opponent.health.ToString();
                    opponent.attackDamage = 25;
                    oppADLabel.Text = opponent.attackDamage.ToString();
                    oppFDLabel.Text = opponent.getMOBFaction().ToString();
                }
                else if (opponent.r10spawn == true)
                {
                    MessageBox.Show("You've already spawned this mob!");
                }
            }

            if (playerOne.currentLocation == r11)
            {
                if (opponent.r11spawn == false)
                {
                    attackButton.Enabled = true;
                    northButton.Enabled = false;
                    eastButton.Enabled = false;
                    southButton.Enabled = false;
                    westButton.Enabled = false;
                    opponent.r11spawn = true;
                    MessageBox.Show("... THIS TIME I HAVE GOT YOU!");

                    opponent.onSpawn();
                    opponent.health = 25;
                    oppHealthLabel.Text = opponent.health.ToString();
                    opponent.attackDamage = 25;
                    oppADLabel.Text = opponent.attackDamage.ToString();
                    oppFDLabel.Text = opponent.getMOBFaction().ToString();
                }
                else if (opponent.r11spawn == true)
                {
                    MessageBox.Show("You've already spawned this mob!");
                }
            }

            if (playerOne.currentLocation == r12)
            {
                if (opponent.r12spawn == false)
                {
                    attackButton.Enabled = true;
                    northButton.Enabled = false;
                    eastButton.Enabled = false;
                    southButton.Enabled = false;
                    westButton.Enabled = false;
                    opponent.r12spawn = true;
                    MessageBox.Show("..... I HAVE IMPROVED SINCE THE LAST ROOM!");

                    opponent.onSpawn();
                    opponent.health = 26;
                    oppHealthLabel.Text = opponent.health.ToString();
                    opponent.attackDamage = 26;
                    oppADLabel.Text = opponent.attackDamage.ToString();
                    oppFDLabel.Text = opponent.getMOBFaction().ToString();
                }
                else if (opponent.r12spawn == true)
                {
                    MessageBox.Show("You've already spawned this mob!");
                }
            }

            if (playerOne.currentLocation == r13)
            {
                if (opponent.r13spawn == false)
                {
                    attackButton.Enabled = true;
                    northButton.Enabled = false;
                    eastButton.Enabled = false;
                    southButton.Enabled = false;
                    westButton.Enabled = false;
                    opponent.r13spawn = true;
                    MessageBox.Show(".... I HAVE A WEAPON THIS TIME!");

                    opponent.onSpawn();
                    opponent.health = 10;
                    oppHealthLabel.Text = opponent.health.ToString();
                    opponent.attackDamage = 10;
                    oppADLabel.Text = opponent.attackDamage.ToString();
                    oppFDLabel.Text = opponent.getMOBFaction().ToString();
                }
                else if (opponent.r13spawn == true)
                {
                    MessageBox.Show("You've already spawned this mob!");
                }
            }
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

                opponent.dead = true;
                lootButton.Enabled = true;

                displayRTB.Text += "Opponent has died. \n";

                if (playerOne.currentLocation == nightmare)
                {
                    playerOne.currentLocation = r2;
                    MessageBox.Show("WAKE UP");
                    playerOne.health = 100;
                    healthDisplayLabel.Text = playerOne.health.ToString();
                    locationRTB.Text += playerOne.currentLocation.ToString();
                    MessageBox.Show("Thank goodness... it was all just a dream...");
                }

                if (playerOne.currentLocation == r7)
                {
                    if (scroll.received == false)
                    {
                        MessageBox.Show("You have received the Protection Scroll!");
                        playerInventoryListBox.Items.Add("Protection Scroll");
                        scroll.received = true;
                    }
                    else if (scroll.received == true)
                    {
                        MessageBox.Show("You already have this item!");
                    }
                }

                if (playerOne.currentLocation == r9)
                {
                    northButton.Enabled = true;
                    eastButton.Enabled = true;
                    southButton.Enabled = true;
                    westButton.Enabled = true;
                }

                if (playerOne.currentLocation == r10)
                {
                    northButton.Enabled = true;
                    eastButton.Enabled = true;
                    southButton.Enabled = true;
                    westButton.Enabled = true;
                }

                if (playerOne.currentLocation == r11)
                {
                    northButton.Enabled = true;
                    eastButton.Enabled = true;
                    southButton.Enabled = true;
                    westButton.Enabled = true;
                }

                if (playerOne.currentLocation == r12)
                {
                    northButton.Enabled = true;
                    eastButton.Enabled = true;
                    southButton.Enabled = true;
                    westButton.Enabled = true;
                }

                if (playerOne.currentLocation == r13)
                {
                    northButton.Enabled = true;
                    eastButton.Enabled = true;
                    southButton.Enabled = true;
                    westButton.Enabled = true;
                }

                if (playerOne.currentLocation == r15)
                {
                    if(oppHead.received == false)
                    {
                        MessageBox.Show("You have defeated your opponent and have received his head!");
                        playerInventoryListBox.Items.Add("Castle Boss' Head");
                        oppHead.received = true;
                        r15.southExit = true;
                    }
                    else if (oppHead.received == true)
                    {
                        MessageBox.Show("You already have this item!");
                    }
                }
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
                MessageBox.Show("GAME OVER!");
            }

            displayRTB.SelectionStart = displayRTB.Text.Length;
            displayRTB.ScrollToCaret();
        }
    }
}
