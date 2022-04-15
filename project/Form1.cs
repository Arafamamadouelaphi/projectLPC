#region using statements
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
#endregion;

namespace project
{
    public partial class Form1 : Form

    {
        #region Declaration
        Image[] diceimage;
        JOUEUR joueur1, joueur2;

        #endregion
        #region initialization
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            joueur1 = new JOUEUR("joueur1");
            joueur2 = new JOUEUR("joueur2");
            lblp1name.Text = joueur1.Name;
            lbl2plnom.Text = joueur2.Name;
            diceimage = new Image[7];
            diceimage[0] = Properties.Resources.dice_0;
            diceimage[1] = Properties.Resources.dice_1;
            diceimage[2] = Properties.Resources.dice_2;
            diceimage[3] = Properties.Resources.dice_3;
            diceimage[4] = Properties.Resources.dice_4;
            diceimage[5] = Properties.Resources.dice_5;
            diceimage[6] = Properties.Resources.dice_6;
           

        }
        #endregion
        #region private methods
        private void button1_Click(object sender, EventArgs e)
        {
            if (!joueur1.Played)
            {
                joueur1.RollDice();
                label1dice.Image = diceimage[joueur1.Dice[0]];
                label2dice.Image = diceimage[joueur1.Dice[1]];
                label3dice.Image = diceimage[joueur1.Dice[2]];
                label4dice.Image = diceimage[joueur1.Dice[3]];
                label5dice.Image = diceimage[joueur1.Dice[4]];
                result.Text = joueur1.Result;
                joueur1.Played = true;

                chekwinner();

            }

        }


        private void chekwinner()
        {
            if (joueur1.Played && joueur2.Played)
            {
                if (joueur1.Handrank > joueur2.Handrank)
                {
                    labelgagnant.Text = joueur1.Name + "WINS";
                }
                else
                if (joueur2.Handrank > joueur1.Handrank)
                {
                    labelgagnant.Text = joueur2.Name + "WINS";
                }
                else
                if (joueur1.Handrank == 8 && joueur2.Handrank == 8)
                {
                    if (joueur1.Mod1 > joueur2.Mod1 &&
                         joueur1.Mod1 > joueur2.Mod2)
                    {
                        labelgagnant.Text = joueur1.Name + "WINS";
                    }
            else if (joueur1.Mod2 > joueur2.Mod1 &&
                       joueur1.Mod2 > joueur2.Mod2)
                    {
                        labelgagnant.Text = joueur1.Name + "WINS";
                    }
                    
          else if
                       (joueur1.Mod1 == joueur2.Mod1 &&
                        joueur1.Mod2 == joueur2.Mod2 ||
                        joueur1.Mod2 == joueur2.Mod1 &&
                        joueur1.Mod1 == joueur2.Mod2
                       )


                    {
          if (joueur1.Mod3 > joueur2.Mod3)
                        {
                            labelgagnant.Text = joueur1.Name + "WINS";
                        }
          else if (joueur2.Mod3 > joueur1.Mod3)
                        {
                            labelgagnant.Text = joueur2.Name + "WINS";
                        }
          else 
                        {
                            labelgagnant.Text = joueur1.Name + "Ties" + joueur2.Name;
                        }
                    }
                }
    else if (joueur1.Handrank == joueur2.Handrank)
                {
                      if (joueur1.Mod1 > joueur2.Mod1)
                        labelgagnant.Text = joueur1.Name + "WINS";

                }
     else if (joueur2.Mod1 > joueur1.Mod1)
                    labelgagnant.Text = joueur2.Name + "WINS";
    else if (joueur1.Mod1 == joueur2.Mod1)
                {
                    if (joueur1.Mod2 > joueur2.Mod2)
                        labelgagnant.Text = joueur1.Name + "WINS";
                    else if (joueur2.Mod2 > joueur1.Mod2)
                        labelgagnant.Text = joueur2.Name + "WINS";
    else if (joueur1.Mod2 == joueur2.Mod2)
                    {
                        if (joueur1.Mod3 > joueur2.Mod3)
                            labelgagnant.Text = joueur1.Name + "WINS";
                        else if (joueur2.Mod3 > joueur1.Mod3)
                            labelgagnant.Text = joueur2.Name + "WINS";
                        else if (joueur1.Mod3 == joueur2.Mod3)
                            labelgagnant.Text = joueur1.Name + "Ties" + joueur2.Name;
                    }
                }
                joueur1.resetplayer();
                joueur2.resetplayer();

            }
            else if (joueur1.Played && !joueur2.Played) 
            
                labelgagnant.Text = "waiting for"   + joueur2.Name +   "to roll";
            else if (joueur2.Played && !joueur1.Played)
                {
                    labelgagnant.Text = "waiting for"   + joueur1.Name +   "to roll";
                }

        }
        #endregion

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void labeldisplay_Click(object sender, EventArgs e)
        {

        }

        private void lbl2plnom_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!joueur2.Played)
            {
                joueur2.RollDice();
                label4.Image = diceimage[joueur2.Dice[0]];
                label5.Image = diceimage[joueur2.Dice[1]];
                label6.Image = diceimage[joueur2.Dice[2]];
                label7.Image = diceimage[joueur2.Dice[3]];
                label8.Image = diceimage[joueur2.Dice[4]];
                resultat2.Text = joueur2.Result;
                joueur2.Played = true;

                chekwinner();

            }
        }
    }
}
