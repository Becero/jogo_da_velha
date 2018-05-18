/*
 *	GameLogic.cs
 *	Author: Carlos Alberto
 *  Description: Game Battlefield Logic.
 *	Date: 2018-05-17
 *	Modified: 2018-05-17
 */

using System;
using System.Windows.Forms;

namespace jogo_da_velha
{
    class GameLogic
    {
        private static bool play;

        public static void EnemyMovement(String symbol, String[,] bf, int posX, int posY)
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (bf[i, j].Equals("") && !play)
                    {
                        bf[i, j] = symbol;
                        play = true;
                    }
                }
            }

            play = false;

            MessageBox.Show("Campo de batalha\n\n" +
                " " + bf[0, 0] + " | " + bf[0, 1] + " | " + bf[0, 2] + " \n" +
                " " + bf[1, 0] + " | " + bf[1, 1] + " | " + bf[1, 2] + " \n" +
                " " + bf[2, 0] + " | " + bf[2, 1] + " | " + bf[2, 2] + " \n");
        }

        public static bool CheckVictory(String[,] bf)
        {
            if ((bf[0, 0].Equals("X") && bf[0, 1].Equals("X") && bf[0, 2].Equals("X")) ||
                (bf[1, 0].Equals("X") && bf[1, 1].Equals("X") && bf[1, 2].Equals("X")) ||
                (bf[2, 0].Equals("X") && bf[2, 1].Equals("X") && bf[2, 2].Equals("X")) ||
                (bf[0, 0].Equals("X") && bf[1, 0].Equals("X") && bf[2, 0].Equals("X")) ||
                (bf[0, 1].Equals("X") && bf[1, 1].Equals("X") && bf[2, 1].Equals("X")) ||
                (bf[0, 2].Equals("X") && bf[1, 2].Equals("X") && bf[2, 2].Equals("X")) ||
                (bf[0, 0].Equals("X") && bf[1, 1].Equals("X") && bf[2, 2].Equals("X")) ||
                (bf[0, 2].Equals("X") && bf[1, 1].Equals("X") && bf[2, 0].Equals("X")))
            {
                return true;
            }
			else if ((bf[0, 0].Equals("O") && bf[0, 1].Equals("O") && bf[0, 2].Equals("O")) ||
                (bf[1, 0].Equals("O") && bf[1, 1].Equals("O") && bf[1, 2].Equals("O")) ||
                (bf[2, 0].Equals("O") && bf[2, 1].Equals("O") && bf[2, 2].Equals("O")) ||
                (bf[0, 0].Equals("O") && bf[1, 0].Equals("O") && bf[2, 0].Equals("O")) ||
                (bf[0, 1].Equals("O") && bf[1, 1].Equals("O") && bf[2, 1].Equals("O")) ||
                (bf[0, 2].Equals("O") && bf[1, 2].Equals("O") && bf[2, 2].Equals("O")) ||
                (bf[0, 0].Equals("O") && bf[1, 1].Equals("O") && bf[2, 2].Equals("O")) ||
                (bf[0, 2].Equals("O") && bf[1, 1].Equals("O") && bf[2, 0].Equals("O")))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
