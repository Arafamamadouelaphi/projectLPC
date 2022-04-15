#region using statements
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//using System.Threading.Tasks;
using System.Drawing;
#endregion

namespace project
{
    public class JOUEUR
    {
        #region Declaration;
        int[] dice;
        int[] diceresult;
        static Random rand;
        bool played = false;
        int handRank, mod1, mod2, mod3;
        string result, name;

        #endregion
        #region properties
        public int[]  Dice
        {
            get { return dice; }
        }
        public string Name

        {
            set { name = value; }
            get { return name; }
        }
        public bool Played
        {
            set { played = value; }
            get { return played; }
        }
        public string Result

        {
            //set { result = value; }
            get { return result; }
        }
        public int Handrank
        {
            get { return handRank; }
        }
        public int Mod1
        {
            get { return mod1; }
        }
        public int Mod2
        {
            get { return mod2; }
        }
        public int Mod3
        {
            get { return mod3; }
        }

        #endregion
        #region initialization

        public JOUEUR(string nomdujoueur)
        {
            name = nomdujoueur;
            dice = new int[5] { 0, 0, 0, 0, 0 };
            diceresult = new int[6] { 0, 0, 0, 0, 0, 0 };
            result = "lancer le dés";
            rand = new Random();

            handRank = 0;
            mod1 = 0;
            mod2 = 0;
            mod3 = 0;
            played = false;
        }



        #endregion
        #region public Methods


        public void RollDice()
        {
            for (int i = 0; i < dice.Length; i++)
            {
                dice[i] = rand.Next(1, 6 + 1);
                switch (dice[i])
                {

                    case 1:
                        diceresult[0]++;
                        break;
                    case 2:
                        diceresult[1]++;
                        break;
                    case 3:
                        diceresult[2]++;
                        break;
                    case 4:
                        diceresult[3]++;
                        break;
                    case 5:
                        diceresult[4]++;
                        break;
                    case 6:
                        diceresult[5]++;
                        break;
                }
            }
            getResult();
        }
        public void resetplayer()
        {

            for (int i = 0; i < diceresult.Length; i++)
            
                diceresult[i] = 0;
            for (int i = 0; i < dice.Length; i++)

                dice[i] = 0;
            played = false;
            mod1 = 0;
            mod2 = 0;
            mod3 = 0;


        }


        #endregion
        #region private Methods
        private void getResult()
        {
            bool fivekind = false, fourking = false, hightstraght = false,
                lowstraight = false, fullHouse = false, threeking = false, twopair = false,
                onepair = false, havesix = false, havefive = false, havefour = false, havetree = false, haveone = false, havetwo = false;
            for (int i = 0; i < diceresult.Length; i++)
            {
                if (diceresult[i] == 5)
                {
                    fivekind = true;
                    mod1 = i;
                }
                    
                else if (diceresult[1] == 4)
                {
                    fourking = true;
                    mod1 = i;
                }
                    
                else if (diceresult[1] == 1 &&
                    diceresult[2] == 1 &&
                    diceresult[3] == 1 &&
                    diceresult[4] == 1 &&
                    diceresult[5] == 1)
                    hightstraght = true;
                else if (diceresult[1] == 1 &&
                   diceresult[2] == 1 &&
                   diceresult[3] == 1 &&
                   diceresult[4] == 1 &&
                   diceresult[5] == 1)
                    lowstraight = true;
                else if (diceresult[i] == 3)
                {
                    threeking = true;
                    mod1 = i;
                    for (int j = 0; j < diceresult.Length; j++)
                    {
                        if (diceresult[j] == 2) { fullHouse = true;
                            mod2 = i;
                        }
                           
                    }

                }

                else if (diceresult[i] == 2)
                {
                    onepair = true;
                    if (mod1 == 0)
                        mod1 = 1;
                 
                    for (int j = i + 1; j < diceresult.Length; j++)
                    {
                        if (diceresult[j] == 2)
                            twopair = true;
                        if (mod2 == 0)
                            mod2 = j;
                    }
                }


            }
            for (int i = 0; i < dice.Length; i++)
                switch (dice[i])
                {
                    case 6:
                        havesix = true;
                        mod3 += 6;
                        break;
                    case 5:
                        havefive = true; mod3 += 5;
                        break;
                    case 4:
                        havefour = true;
                        mod3 += 4;
                        break;
                    case 3:
                        havetree = true;
                        mod3 += 3;
                        break;
                    case 2:
                        havetwo = true;
                        mod3 += 2;
                        break;
                    case 1:
                        haveone = true;
                        mod3 += 1;
                        break;
                }
            if (fivekind) 
            {
                result = "FIVE OF A KING ";
                handRank = 14;
            }

                
            else if (fourking)
            {
                result = "FOUR OF A KING";
                handRank = 13;
            }
               

            else if (hightstraght)
            { result = "hightstraight";
                handRank = 12;
            }

            else if (lowstraight)
            { 
                result = "lowstraight";
                handRank = 11;
            }
                

            else if (fullHouse)

            { result = "fullHouse";
                handRank = 10;
            }

            else if (threeking)
            {
                result = "three is king";
                handRank = 9;
            }
               

            else if (twopair)

            {
                result = "two paire";
                handRank = 8;
            }
            else if (onepair)

            { result = "one  pair";
                handRank = 7;
            }

            else if (havesix)
            {
                result = "six hight";
                handRank = 6;
            }

            else if (havefive)

            {
                result = "FIVE HIGHT";
                    handRank = 5;
            }

            else if (havefour)

            { result = "FOUR HIGHT ";
                handRank = 4;
            }
            else if (havetree)

            {
                result = "TREE HIGHT ";
                handRank = 3;
            }

            else if (havetwo)

            {
                result = "TWO HIGHT";
                handRank = 2;
            }


            else if (haveone)

            {
                result = "le 1er est haut";
                handRank = 1;
            }



        }
        #endregion

    }

}
