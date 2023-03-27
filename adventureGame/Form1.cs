using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace adventureGame
{
    public partial class Form1 : Form
    {
        int page = 1;

        Random random = new Random();
        int randomValue;

        SoundPlayer deathSound = new SoundPlayer(Properties.Resources.deathSound);
        SoundPlayer yippee = new SoundPlayer(Properties.Resources.yippee);
        public Form1()
        {
            InitializeComponent();
            textOutput.Text = "You wake up in an abandoned Wendy's bathroom. Do you leave or go back to sleep?";

            option1.Text = "Go back to sleep";
            option2.Text = "Leave the bathroom";

            imageBox.Image = Properties.Resources.bathroom;

            option3.BackColor = Color.Black;
        }

        private void option1_Click(object sender, EventArgs e)
        {
            if (page == 1)
            {
                page = 2;
            }
            else if (page == 2)
            {
                page = 1;
            }
            else if (page == 3)
            {
                randomValue = random.Next(1, 101);

                if (randomValue >= 61)
                {
                    page = 5;
                }
                else
                {
                    page = 4;
                }
            }
            else if (page == 4)
            {
                page = 1;
            }
            else if (page == 5)
            {
                page = 6;
            }
            else if (page == 6)
            {
                page = 1;
            }
            else if (page == 7)
            {
                page = 9;
            }
            else if (page == 8)
            {
                page = 14;
            }
            else if (page == 9)
            {
                page = 1;
            }
            else if (page == 10)
            {
                page = 11;
            }
            else if (page == 11)
            {
                page = 13;
            }
            else if (page == 12)
            {
                page = 1;
            }
            else if (page == 13)
            {
                page = 17;
            }
            else if (page == 14)
            {
                page = 1;
            }
            else if (page == 15)
            {
                page = 16;
            }
            else if (page == 16)
            {
                page = 1;
            }
            else if (page == 17)
            {
                page = 18;
            }
            else if (page == 18)
            {
                page = 1;
            }
            else if (page == 19)
            {
                page = 1;
            }
            else if (page == 20)
            {
                page = 1;
            }
            else if (page == 21)
            {
                page = 24;
            }
            else if (page == 22)
            {
                page = 1;
            }
            else if (page == 23)
            {
                page = 24;
            }
            else if (page == 24)
            {
                page = 1;
            }

            switch(page)
            {
                case 1:
                    textOutput.Text = "You wake up in an abandoned Wendy's bathroom. Do you leave or go back to sleep?";

                    option1.Text = "Go back to sleep";
                    option2.Text = "Leave the bathroom";
                    option3.Text = "";

                    imageBox.Image = Properties.Resources.bathroom;

                    option3.BackColor = Color.Black;
                    option3.Enabled = false;
                    break;
                case 2:
                    textOutput.Text = "You fall asleep and die of E.coli from the Wendy's bathroom. Play again?";

                    option1.Text = "Yes";
                    option2.Text = "No";
                    option3.Text = "";

                    imageBox.Image = Properties.Resources.deathScreen;
                    deathSound.Play();

                    option3.BackColor = Color.Black;
                    option3.Enabled = false;
                    break;
                case 3:
                    textOutput.Text = "You leave out the back door and enter another room with a vent and a door. Which do you choose?";

                    option1.Text = "Go through vent";
                    option2.Text = "Go through door";
                    option3.Text = "";

                    imageBox.Image = Properties.Resources.vent;

                    option3.BackColor = Color.Black;
                    option3.Enabled = false;
                    break;
                case 4:
                    textOutput.Text = "You got trapped in the vents and died of boredom. Play again?";

                    option1.Text = "Yes";
                    option2.Text = "No";
                    option3.Text = "";

                    imageBox.Image = Properties.Resources.deathScreen;
                    deathSound.Play();

                    option3.BackColor = Color.Black;
                    option3.Enabled = false;
                    break;
                case 5:
                    textOutput.Text = "You made it into the main room and you find a hammer. Do you take it, leave it or throw it into a deepfryer";

                    option1.Text = "Throw it into a deepfryer";
                    option2.Text = "Leave the hammer";
                    option3.Text = "Take the hammer";

                    imageBox.Image = Properties.Resources.hammer;

                    option3.BackColor = Color.White;
                    option3.Enabled = true;
                    break;
                case 6:
                    textOutput.Text = "You throw the hammer into the deep fryer and oil splashes everywhere. You slip on the oil and hit your head on a table and die. Play again?";

                    option1.Text = "Yes";
                    option2.Text = "No";
                    option3.Text = "";

                    imageBox.Image = Properties.Resources.deathScreen;
                    deathSound.Play();

                    option3.BackColor = Color.Black;
                    option3.Enabled = false;
                    break;
                case 7:
                    textOutput.Text = "You got a hammer. Do you use it to break down a wall";

                    option1.Text = "Break down the wall";
                    option2.Text = "Don't break down the wall";
                    option3.Text = "";

                    imageBox.Image = Properties.Resources.wall;

                    option3.BackColor = Color.Black;
                    option3.Enabled = true;
                    break;
                case 8:
                    textOutput.Text = "You leave the hammer and continue walking and you find 2 exits. Do you leave out the front door or back door?";

                    option1.Text = "Front door";
                    option2.Text = "Back door";
                    option3.Text = "";

                    imageBox.Image = Properties.Resources.wendys;

                    option3.BackColor = Color.Black;
                    option3.Enabled = false;
                    break;
                case 9:
                    textOutput.Text = "You broke down the wall.";

                    option1.Text = "";
                    option2.Text = "";
                    option3.Text = "";

                    option1.BackColor = Color.Black;
                    option2.BackColor = Color.Black;
                    option3.BackColor = Color.Black;

                    option1.Enabled = false;
                    option2.Enabled = false;
                    option3.Enabled = false;

                    Refresh();
                    Thread.Sleep(1500);

                    textOutput.Text = "The roof collapses onto you and you get crushed to death. Play again?";

                    option1.BackColor = Color.White;
                    option2.BackColor = Color.White;

                    option1.Text = "Yes";
                    option2.Text = "No";
                    option3.Text = "";

                    option1.Enabled = true;
                    option2.Enabled = true;

                    imageBox.Image = Properties.Resources.deathScreen;
                    deathSound.Play();
                    break;
                case 10:
                    textOutput.Text = "You continue walking and you encounter a bear while walking. Do you fight it or run?";

                    option1.Text = "Fight the bear";
                    option2.Text = "Run from the bear";
                    option3.Text = "";

                    imageBox.Image = Properties.Resources.bear;

                    option3.BackColor = Color.Black;
                    option3.Enabled = false;
                    break;
                case 11:
                    textOutput.Text = "You ran from the bear and barely escaped outside. You see 2 paths in front of you which do you choose?";

                    option1.Text = "Left path";
                    option2.Text = "Right path";
                    option3.Text = "";

                    imageBox.Image = Properties.Resources.twoPaths;

                    option3.BackColor = Color.Black;
                    option3.Enabled = false;
                    break;
                case 12:
                    textOutput.Text = "You died to the bear RIP bozo. Play again?";

                    option1.Text = "Yes";
                    option2.Text = "No";
                    option3.Text = "";

                    imageBox.Image = Properties.Resources.deathScreen;
                    deathSound.Play();

                    option3.BackColor = Color.Black;
                    option3.Enabled = false;
                    break;
                case 13:
                    textOutput.Text = "You walk into a clearing and find a red Nissan Accord do you break into it?";

                    option1.Text = "Break into the car";
                    option2.Text = "Continue walking";
                    option3.Text = "";

                    imageBox.Image = Properties.Resources.redNissanAccord;

                    option3.BackColor = Color.Black;
                    option3.Enabled = false;
                    break;
                case 14:
                    textOutput.Text = "You walk outside the front door and fall into a sinkhole and get crushed by rocks. Play again?";

                    option1.Text = "Yes";
                    option2.Text = "No";
                    option3.Text = "";

                    imageBox.Image = Properties.Resources.deathScreen;
                    deathSound.Play();

                    option3.BackColor = Color.Black;
                    option3.Enabled = false;
                    break;
                case 15:
                    textOutput.Text = "You leave out the back door and you see a car. Do you break in to it?";

                    option1.Text = "Continue walking";
                    option2.Text = "Break into the car";
                    option3.Text = "";

                    imageBox.Image = Properties.Resources.redNissanAccord;

                    option3.BackColor = Color.Black;
                    option3.Enabled = false;
                    break;
                case 16:
                    textOutput.Text = "You walk into the street and get run down by a minivan. Play again?";

                    option1.Text = "Yes";
                    option2.Text = "No";
                    option3.Text = "";

                    imageBox.Image = Properties.Resources.deathScreen;
                    deathSound.Play();

                    option3.BackColor = Color.Black;
                    option3.Enabled = false;
                    break;
                case 17:
                    textOutput.Text = "You break in to the car and successfully hotwire it and drive to an intersection. Do you turn right, left or straight?";

                    option1.Text = "Turn left";
                    option2.Text = "Go straight";
                    option3.Text = "Turn right";

                    imageBox.Image = Properties.Resources.intersection;

                    option3.BackColor = Color.White;
                    option3.Enabled = true;
                    break;
                case 18:
                    textOutput.Text = "You turn left at the intersection and fall of a cliff and your car explodes. Play again?";

                    option1.Text = "Yes";
                    option2.Text = "No";
                    option3.Text = "";

                    imageBox.Image = Properties.Resources.deathScreen;
                    deathSound.Play();

                    option3.BackColor = Color.Black;
                    option3.Enabled = false;
                    break;
                case 19:
                    textOutput.Text = "You turn right at the intersection. You nearly hit an old lady. She pulls out a Fortnite rocket launcher and blows up your car. Play again?";

                    option1.Text = "Yes";
                    option2.Text = "No";
                    option3.Text = "";

                    imageBox.Image = Properties.Resources.deathScreen;
                    deathSound.Play();

                    option3.BackColor = Color.Black;
                    option3.Enabled = false;
                    break;
                case 20:
                    textOutput.Text = "You go straight at the intersection and encounter no issues and drive home. You win. Play again?";

                    option1.Text = "Yes";
                    option2.Text = "No";
                    option3.Text = "";

                    imageBox.Image = Properties.Resources.winner;
                    yippee.Play();

                    option3.BackColor = Color.Black;
                    option3.Enabled = false;
                    break;
                case 21:
                    textOutput.Text = "You take the right path and get lost in the forest. Do you call out for help or wander aimlessly?";

                    option1.Text = "Call for help";
                    option2.Text = "Wander aimlessly";
                    option3.Text = "";

                    imageBox.Image = Properties.Resources.forest;

                    option3.BackColor = Color.Black;
                    option3.Enabled = false;
                    break;
                case 22:
                    textOutput.Text = "You wander off into the forest and get lost and slowly die of dehydration. Play again?";

                    option1.Text = "Yes";
                    option2.Text = "No";
                    option3.Text = "";

                    imageBox.Image = Properties.Resources.deathScreen;
                    deathSound.Play();

                    option3.BackColor = Color.Black;
                    option3.Enabled = false;
                    break;
                case 23:
                    textOutput.Text = "You walk past the car and continue wandering into the forest and get lost. Do you call for help or wander aimlessly?";

                    option1.Text = "Call for help";
                    option2.Text = "Wander aimlessly";
                    option3.Text = "";

                    imageBox.Image = Properties.Resources.forest;

                    option3.BackColor = Color.Black;
                    option3.Enabled = false;
                    break;
                case 24:
                    textOutput.Text = "You call for help and a nearby hiker hears you and comes to rescue you and takes you to your house. You win. Play again?";

                    option1.Text = "Yes";
                    option2.Text = "No";
                    option3.Text = "";

                    imageBox.Image = Properties.Resources.winner;
                    yippee.Play();

                    option3.BackColor = Color.Black;
                    option3.Enabled = false;
                    break;
                case 99:
                    textOutput.Text = "Thank you for playing";

                    option1.Text = "";
                    option2.Text = "";
                    option3.Text = "";

                    imageBox.Image = Properties.Resources.endScreen;

                    option1.BackColor = Color.Black;
                    option2.BackColor = Color.Black;
                    option3.BackColor = Color.Black;
                    option1.Enabled = false;
                    option2.Enabled = false;
                    option3.Enabled = false;

                    Refresh();
                    Thread.Sleep(2000);

                    Application.Exit();
                    break;
            }
        }

        private void option2_Click(object sender, EventArgs e)
        {
            if (page == 1)
            {
                page = 3;
            }
            else if (page == 2)
            {
                page = 99;
            }
            else if (page == 3)
            {
                page = 5;
            }
            else if (page == 4)
            {
                page = 99;
            }
            else if (page == 5)
            {
                page = 8;
            }
            else if (page == 6)
            {
                page = 99;
            }
            else if (page == 7)
            {
                page = 10;
            }
            else if (page == 8)
            {
                page = 15;
            }
            else if (page == 9)
            {
                page = 99;
            }
            else if (page == 10)
            {
                page = 12;
            }
            else if (page == 11)
            {
                page = 21;
            }
            else if (page == 12)
            {
                page = 99;
            }
            else if (page == 13)
            {
                page = 17;
            }
            else if (page == 14)
            {
                page = 99;
            }
            else if (page == 15)
            {
                page = 17;
            }
            else if (page == 16)
            {
                page = 99;
            }
            else if (page == 17)
            {
                page = 20;
            }
            else if (page == 18)
            {
                page = 99;
            }
            else if (page == 19)
            {
                page = 99;
            }
            else if (page == 20)
            {
                page = 99;
            }
            else if (page == 21)
            {
                page = 24;
            }
            else if (page == 22)
            {
                page = 99;
            }
            else if (page == 23)
            {
                page = 24;
            }
            else if (page == 24)
            {
                page = 99;
            }

            switch (page)
            {
                case 1:
                    textOutput.Text = "You wake up in an abandoned Wendy's bathroom. Do you leave or go back to sleep?";

                    option1.Text = "Go back to sleep";
                    option2.Text = "Leave the bathroom";
                    option3.Text = "";

                    imageBox.Image = Properties.Resources.bathroom;

                    option3.BackColor = Color.Black;
                    option3.Enabled = false;
                    break;
                case 2:
                    textOutput.Text = "You fall asleep and die of E.coli from the Wendy's bathroom. Play again?";

                    option1.Text = "Yes";
                    option2.Text = "No";
                    option3.Text = "";

                    imageBox.Image = Properties.Resources.deathScreen;
                    deathSound.Play();

                    option3.BackColor = Color.Black;
                    option3.Enabled = false;
                    break;
                case 3:
                    textOutput.Text = "You leave out the back door and enter another room with a vent and a door. Which do you choose?";

                    option1.Text = "Go through vent";
                    option2.Text = "Go through door";
                    option3.Text = "";

                    imageBox.Image = Properties.Resources.vent;

                    option3.BackColor = Color.Black;
                    option3.Enabled = false;
                    break;
                case 4:
                    textOutput.Text = "You got trapped in the vents and died of boredom. Play again?";

                    option1.Text = "Yes";
                    option2.Text = "No";
                    option3.Text = "";

                    imageBox.Image = Properties.Resources.deathScreen;
                    deathSound.Play();

                    option3.BackColor = Color.Black;
                    option3.Enabled = false;
                    break;
                case 5:
                    textOutput.Text = "You made it into the main room and you find a hammer. Do you take it, leave it or throw it into a deepfryer";

                    option1.Text = "Throw it into a deepfryer";
                    option2.Text = "Leave the hammer";
                    option3.Text = "Take the hammer";

                    imageBox.Image = Properties.Resources.hammer;

                    option3.BackColor = Color.White;
                    option3.Enabled = true;
                    break;
                case 6:
                    textOutput.Text = "You throw the hammer into the deep fryer and oil splashes everywhere. You slip on the oil and hit your head on a table and die. Play again?";

                    option1.Text = "Yes";
                    option2.Text = "No";
                    option3.Text = "";

                    imageBox.Image = Properties.Resources.deathScreen;
                    deathSound.Play();

                    option3.BackColor = Color.Black;
                    option3.Enabled = false;
                    break;
                case 7:
                    textOutput.Text = "You got a hammer. Do you use it to break down a wall";

                    option1.Text = "Break down the wall";
                    option2.Text = "Don't break down the wall";
                    option3.Text = "";

                    imageBox.Image = Properties.Resources.wall;

                    option3.BackColor = Color.Black;
                    option3.Enabled = true;
                    break;
                case 8:
                    textOutput.Text = "You leave the hammer and continue walking and you find 2 exits. Do you leave out the front door or back door?";

                    option1.Text = "Front door";
                    option2.Text = "Back door";
                    option3.Text = "";

                    imageBox.Image = Properties.Resources.wendys;

                    option3.BackColor = Color.Black;
                    option3.Enabled = false;
                    break;
                case 9:
                    textOutput.Text = "You broke down the wall.";

                    option1.Text = "";
                    option2.Text = "";
                    option3.Text = "";

                    option1.BackColor = Color.Black;
                    option2.BackColor = Color.Black;
                    option3.BackColor = Color.Black;

                    option1.Enabled = false;
                    option2.Enabled = false;
                    option3.Enabled = false;

                    Refresh();
                    Thread.Sleep(1500);

                    textOutput.Text = "The roof collapses onto you and you get crushed to death. Play again?";

                    option1.BackColor = Color.White;
                    option2.BackColor = Color.White;

                    option1.Text = "Yes";
                    option2.Text = "No";
                    option3.Text = "";

                    option1.Enabled = true;
                    option2.Enabled = true;

                    imageBox.Image = Properties.Resources.deathScreen;
                    deathSound.Play();
                    break;
                case 10:
                    textOutput.Text = "You continue walking and you encounter a bear while walking. Do you fight it or run?";

                    option1.Text = "Fight the bear";
                    option2.Text = "Run from the bear";
                    option3.Text = "";

                    imageBox.Image = Properties.Resources.bear;

                    option3.BackColor = Color.Black;
                    option3.Enabled = false;
                    break;
                case 11:
                    textOutput.Text = "You ran from the bear and barely escaped outside. You see 2 paths in front of you which do you choose?";

                    option1.Text = "Left path";
                    option2.Text = "Right path";
                    option3.Text = "";

                    imageBox.Image = Properties.Resources.twoPaths;

                    option3.BackColor = Color.Black;
                    option3.Enabled = false;
                    break;
                case 12:
                    textOutput.Text = "You died to the bear RIP bozo. Play again?";

                    option1.Text = "Yes";
                    option2.Text = "No";
                    option3.Text = "";

                    imageBox.Image = Properties.Resources.deathScreen;
                    deathSound.Play();

                    option3.BackColor = Color.Black;
                    option3.Enabled = false;
                    break;
                case 13:
                    textOutput.Text = "You walk into a clearing and find a red Nissan Accord do you break into it?";

                    option1.Text = "Break into the car";
                    option2.Text = "Continue walking";
                    option3.Text = "";

                    imageBox.Image = Properties.Resources.redNissanAccord;

                    option3.BackColor = Color.Black;
                    option3.Enabled = false;
                    break;
                case 14:
                    textOutput.Text = "You walk outside the front door and fall into a sinkhole and get crushed by rocks. Play again?";

                    option1.Text = "Yes";
                    option2.Text = "No";
                    option3.Text = "";

                    imageBox.Image = Properties.Resources.deathScreen;
                    deathSound.Play();

                    option3.BackColor = Color.Black;
                    option3.Enabled = false;
                    break;
                case 15:
                    textOutput.Text = "You leave out the back door and you see a car. Do you break in to it?";

                    option1.Text = "Continue walking";
                    option2.Text = "Break into the car";
                    option3.Text = "";

                    imageBox.Image = Properties.Resources.redNissanAccord;

                    option3.BackColor = Color.Black;
                    option3.Enabled = false;
                    break;
                case 16:
                    textOutput.Text = "You walk into the street and get run down by a minivan. Play again?";

                    option1.Text = "Yes";
                    option2.Text = "No";
                    option3.Text = "";

                    imageBox.Image = Properties.Resources.deathScreen;
                    deathSound.Play();

                    option3.BackColor = Color.Black;
                    option3.Enabled = false;
                    break;
                case 17:
                    textOutput.Text = "You break in to the car and successfully hotwire it and drive to an intersection. Do you turn right, left or straight?";

                    option1.Text = "Turn left";
                    option2.Text = "Go straight";
                    option3.Text = "Turn right";

                    imageBox.Image = Properties.Resources.intersection;

                    option3.BackColor = Color.White;
                    option3.Enabled = true;
                    break;
                case 18:
                    textOutput.Text = "You turn left at the intersection and fall of a cliff and your car explodes. Play again?";

                    option1.Text = "Yes";
                    option2.Text = "No";
                    option3.Text = "";

                    imageBox.Image = Properties.Resources.deathScreen;
                    deathSound.Play();

                    option3.BackColor = Color.Black;
                    option3.Enabled = false;
                    break;
                case 19:
                    textOutput.Text = "You turn right at the intersection. You nearly hit an old lady. She pulls out a Fortnite rocket launcher and blows up your car. Play again?";

                    option1.Text = "Yes";
                    option2.Text = "No";
                    option3.Text = "";

                    imageBox.Image = Properties.Resources.deathScreen;
                    deathSound.Play();

                    option3.BackColor = Color.Black;
                    option3.Enabled = false;
                    break;
                case 20:
                    textOutput.Text = "You go straight at the intersection and encounter no issues and drive home. You win. Play again?";

                    option1.Text = "Yes";
                    option2.Text = "No";
                    option3.Text = "";

                    imageBox.Image = Properties.Resources.winner;
                    yippee.Play();

                    option3.BackColor = Color.Black;
                    option3.Enabled = false;
                    break;
                case 21:
                    textOutput.Text = "You take the right path and get lost in the forest. Do you call out for help or wander aimlessly?";

                    option1.Text = "Call for help";
                    option2.Text = "Wander aimlessly";
                    option3.Text = "";

                    imageBox.Image = Properties.Resources.forest;

                    option3.BackColor = Color.Black;
                    option3.Enabled = false;
                    break;
                case 22:
                    textOutput.Text = "You wander off into the forest and get lost and slowly die of dehydration. Play again?";

                    option1.Text = "Yes";
                    option2.Text = "No";
                    option3.Text = "";

                    imageBox.Image = Properties.Resources.deathScreen;
                    deathSound.Play();

                    option3.BackColor = Color.Black;
                    option3.Enabled = false;
                    break;
                case 23:
                    textOutput.Text = "You walk past the car and continue wandering into the forest and get lost. Do you call for help or wander aimlessly?";

                    option1.Text = "Call for help";
                    option2.Text = "Wander aimlessly";
                    option3.Text = "";

                    imageBox.Image = Properties.Resources.forest;

                    option3.BackColor = Color.Black;
                    option3.Enabled = false;
                    break;
                case 24:
                    textOutput.Text = "You call for help and a nearby hiker hears you and comes to rescue you and takes you to your house. You win. Play again?";

                    option1.Text = "Yes";
                    option2.Text = "No";
                    option3.Text = "";

                    imageBox.Image = Properties.Resources.winner;
                    yippee.Play();

                    option3.BackColor = Color.Black;
                    option3.Enabled = false;
                    break;
                case 99:
                    textOutput.Text = "Thank you for playing";

                    option1.Text = "";
                    option2.Text = "";
                    option3.Text = "";

                    imageBox.Image = Properties.Resources.endScreen;

                    option1.BackColor = Color.Black;
                    option2.BackColor = Color.Black;
                    option3.BackColor = Color.Black;
                    option1.Enabled = false;
                    option2.Enabled = false;
                    option3.Enabled = false;

                    Refresh();
                    Thread.Sleep(2000);

                    Application.Exit();
                    break;
            }
        }

        private void option3_Click(object sender, EventArgs e)
        {
            if (page == 5)
            {
                page = 7;
            }
            else if (page == 17)
            {
                page = 19;
            }
            else
            {
                option3.Enabled = false;
            }

            switch (page)
            {
                case 1:
                    textOutput.Text = "You wake up in an abandoned Wendy's bathroom. Do you leave or go back to sleep?";

                    option1.Text = "Go back to sleep";
                    option2.Text = "Leave the bathroom";
                    option3.Text = "";

                    imageBox.Image = Properties.Resources.bathroom;

                    option3.BackColor = Color.Black;
                    option3.Enabled = false;
                    break;
                case 2:
                    textOutput.Text = "You fall asleep and die of E.coli from the Wendy's bathroom. Play again?";

                    option1.Text = "Yes";
                    option2.Text = "No";
                    option3.Text = "";

                    imageBox.Image = Properties.Resources.deathScreen;
                    deathSound.Play();

                    option3.BackColor = Color.Black;
                    option3.Enabled = false;
                    break;
                case 3:
                    textOutput.Text = "You leave out the back door and enter another room with a vent and a door. Which do you choose?";

                    option1.Text = "Go through vent";
                    option2.Text = "Go through door";
                    option3.Text = "";

                    imageBox.Image = Properties.Resources.vent;

                    option3.BackColor = Color.Black;
                    option3.Enabled = false;
                    break;
                case 4:
                    textOutput.Text = "You got trapped in the vents and died of boredom. Play again?";

                    option1.Text = "Yes";
                    option2.Text = "No";
                    option3.Text = "";

                    imageBox.Image = Properties.Resources.deathScreen;
                    deathSound.Play();

                    option3.BackColor = Color.Black;
                    option3.Enabled = false;
                    break;
                case 5:
                    textOutput.Text = "You made it into the main room and you find a hammer. Do you take it, leave it or throw it into a deepfryer";

                    option1.Text = "Throw it into a deepfryer";
                    option2.Text = "Leave the hammer";
                    option3.Text = "Take the hammer";

                    imageBox.Image = Properties.Resources.hammer;

                    option3.BackColor = Color.White;
                    option3.Enabled = true;
                    break;
                case 6:
                    textOutput.Text = "You throw the hammer into the deep fryer and oil splashes everywhere. You slip on the oil and hit your head on a table and die. Play again?";

                    option1.Text = "Yes";
                    option2.Text = "No";
                    option3.Text = "";

                    imageBox.Image = Properties.Resources.deathScreen;
                    deathSound.Play();

                    option3.BackColor = Color.Black;
                    option3.Enabled = false;
                    break;
                case 7:
                    textOutput.Text = "You got a hammer. Do you use it to break down a wall";

                    option1.Text = "Break down the wall";
                    option2.Text = "Don't break down the wall";
                    option3.Text = "";

                    imageBox.Image = Properties.Resources.wall;

                    option3.BackColor = Color.Black;
                    option3.Enabled = true;
                    break;
                case 8:
                    textOutput.Text = "You leave the hammer and continue walking and you find 2 exits. Do you leave out the front door or back door?";

                    option1.Text = "Front door";
                    option2.Text = "Back door";
                    option3.Text = "";

                    imageBox.Image = Properties.Resources.wendys;

                    option3.BackColor = Color.Black;
                    option3.Enabled = false;
                    break;
                case 9:
                    textOutput.Text = "You broke down the wall.";

                    option1.Text = "";
                    option2.Text = "";
                    option3.Text = "";

                    option1.BackColor = Color.Black;
                    option2.BackColor = Color.Black;
                    option3.BackColor = Color.Black;

                    option1.Enabled = false;
                    option2.Enabled = false;
                    option3.Enabled = false;

                    Refresh();
                    Thread.Sleep(1500);

                    textOutput.Text = "The roof collapses onto you and you get crushed to death. Play again?";

                    option1.BackColor = Color.White;
                    option2.BackColor = Color.White;

                    option1.Text = "Yes";
                    option2.Text = "No";
                    option3.Text = "";

                    option1.Enabled = true;
                    option2.Enabled = true;

                    imageBox.Image = Properties.Resources.deathScreen;
                    deathSound.Play();
                    break;
                case 10:
                    textOutput.Text = "You continue walking and you encounter a bear while walking. Do you fight it or run?";

                    option1.Text = "Fight the bear";
                    option2.Text = "Run from the bear";
                    option3.Text = "";

                    imageBox.Image = Properties.Resources.bear;

                    option3.BackColor = Color.Black;
                    option3.Enabled = false;
                    break;
                case 11:
                    textOutput.Text = "You ran from the bear and barely escaped outside. You see 2 paths in front of you which do you choose?";

                    option1.Text = "Left path";
                    option2.Text = "Right path";
                    option3.Text = "";

                    imageBox.Image = Properties.Resources.twoPaths;

                    option3.BackColor = Color.Black;
                    option3.Enabled = false;
                    break;
                case 12:
                    textOutput.Text = "You died to the bear RIP bozo. Play again?";

                    option1.Text = "Yes";
                    option2.Text = "No";
                    option3.Text = "";

                    imageBox.Image = Properties.Resources.deathScreen;
                    deathSound.Play();

                    option3.BackColor = Color.Black;
                    option3.Enabled = false;
                    break;
                case 13:
                    textOutput.Text = "You walk into a clearing and find a red Nissan Accord do you break into it?";

                    option1.Text = "Break into the car";
                    option2.Text = "Continue walking";
                    option3.Text = "";

                    imageBox.Image = Properties.Resources.redNissanAccord;

                    option3.BackColor = Color.Black;
                    option3.Enabled = false;
                    break;
                case 14:
                    textOutput.Text = "You walk outside the front door and fall into a sinkhole and get crushed by rocks. Play again?";

                    option1.Text = "Yes";
                    option2.Text = "No";
                    option3.Text = "";

                    imageBox.Image = Properties.Resources.deathScreen;
                    deathSound.Play();

                    option3.BackColor = Color.Black;
                    option3.Enabled = false;
                    break;
                case 15:
                    textOutput.Text = "You leave out the back door and you see a car. Do you break in to it?";

                    option1.Text = "Continue walking";
                    option2.Text = "Break into the car";
                    option3.Text = "";

                    imageBox.Image = Properties.Resources.redNissanAccord;

                    option3.BackColor = Color.Black;
                    option3.Enabled = false;
                    break;
                case 16:
                    textOutput.Text = "You walk into the street and get run down by a minivan. Play again?";

                    option1.Text = "Yes";
                    option2.Text = "No";
                    option3.Text = "";

                    imageBox.Image = Properties.Resources.deathScreen;
                    deathSound.Play();

                    option3.BackColor = Color.Black;
                    option3.Enabled = false;
                    break;
                case 17:
                    textOutput.Text = "You break in to the car and successfully hotwire it and drive to an intersection. Do you turn right, left or straight?";

                    option1.Text = "Turn left";
                    option2.Text = "Go straight";
                    option3.Text = "Turn right";

                    imageBox.Image = Properties.Resources.intersection;

                    option3.BackColor = Color.White;
                    option3.Enabled = true;
                    break;
                case 18:
                    textOutput.Text = "You turn left at the intersection and fall of a cliff and your car explodes. Play again?";

                    option1.Text = "Yes";
                    option2.Text = "No";
                    option3.Text = "";

                    imageBox.Image = Properties.Resources.deathScreen;
                    deathSound.Play();

                    option3.BackColor = Color.Black;
                    option3.Enabled = false;
                    break;
                case 19:
                    textOutput.Text = "You turn right at the intersection. You nearly hit an old lady. She pulls out a Fortnite rocket launcher and blows up your car. Play again?";

                    option1.Text = "Yes";
                    option2.Text = "No";
                    option3.Text = "";

                    imageBox.Image = Properties.Resources.deathScreen;
                    deathSound.Play();

                    option3.BackColor = Color.Black;
                    option3.Enabled = false;
                    break;
                case 20:
                    textOutput.Text = "You go straight at the intersection and encounter no issues and drive home. You win. Play again?";

                    option1.Text = "Yes";
                    option2.Text = "No";
                    option3.Text = "";

                    imageBox.Image = Properties.Resources.winner;
                    yippee.Play();

                    option3.BackColor = Color.Black;
                    option3.Enabled = false;
                    break;
                case 21:
                    textOutput.Text = "You take the right path and get lost in the forest. Do you call out for help or wander aimlessly?";

                    option1.Text = "Call for help";
                    option2.Text = "Wander aimlessly";
                    option3.Text = "";

                    imageBox.Image = Properties.Resources.forest;

                    option3.BackColor = Color.Black;
                    option3.Enabled = false;
                    break;
                case 22:
                    textOutput.Text = "You wander off into the forest and get lost and slowly die of dehydration. Play again?";

                    option1.Text = "Yes";
                    option2.Text = "No";
                    option3.Text = "";

                    imageBox.Image = Properties.Resources.deathScreen;
                    deathSound.Play();

                    option3.BackColor = Color.Black;
                    option3.Enabled = false;
                    break;
                case 23:
                    textOutput.Text = "You walk past the car and continue wandering into the forest and get lost. Do you call for help or wander aimlessly?";

                    option1.Text = "Call for help";
                    option2.Text = "Wander aimlessly";
                    option3.Text = "";

                    imageBox.Image = Properties.Resources.forest;

                    option3.BackColor = Color.Black;
                    option3.Enabled = false;
                    break;
                case 24:
                    textOutput.Text = "You call for help and a nearby hiker hears you and comes to rescue you and takes you to your house. You win. Play again?";

                    option1.Text = "Yes";
                    option2.Text = "No";
                    option3.Text = "";

                    imageBox.Image = Properties.Resources.winner;
                    yippee.Play();

                    option3.BackColor = Color.Black;
                    option3.Enabled = false;
                    break;
                case 99:
                    textOutput.Text = "Thank you for playing";

                    option1.Text = "";
                    option2.Text = "";
                    option3.Text = "";

                    imageBox.Image = Properties.Resources.endScreen;

                    option1.BackColor = Color.Black;
                    option2.BackColor = Color.Black;
                    option3.BackColor = Color.Black;
                    option1.Enabled = false;
                    option2.Enabled = false;
                    option3.Enabled = false;

                    Refresh();
                    Thread.Sleep(2000);

                    Application.Exit();
                    break;
            }
        }
    }
}
