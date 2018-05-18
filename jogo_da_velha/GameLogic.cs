using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace jogo_da_velha
{
    class GameLogic
    {
        private static bool play;

        public static void EnemyMovement(String symbol, Control[,] bf, int posX, int posY)
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (bf[i, j].Text.Equals("") && !play)
                    {
                        bf[i, j].Text = symbol;
                        bf[i, j].Enabled = false;
                        play = true;
                    }
                }
            }

            play = false;
        }

        public static bool CheckVictory(Control[,] bf)
        {
            if ((bf[0, 0].Text.Equals("X") && bf[0, 1].Text.Equals("X") && bf[0, 2].Text.Equals("X")) ||
                (bf[1, 0].Text.Equals("X") && bf[1, 1].Text.Equals("X") && bf[1, 2].Text.Equals("X")) ||
                (bf[2, 0].Text.Equals("X") && bf[2, 1].Text.Equals("X") && bf[2, 2].Text.Equals("X")) ||
                (bf[0, 0].Text.Equals("X") && bf[1, 0].Text.Equals("X") && bf[2, 0].Text.Equals("X")) ||
                (bf[0, 1].Text.Equals("X") && bf[1, 1].Text.Equals("X") && bf[2, 1].Text.Equals("X")) ||
                (bf[0, 2].Text.Equals("X") && bf[1, 2].Text.Equals("X") && bf[2, 2].Text.Equals("X")) ||
                (bf[0, 0].Text.Equals("X") && bf[1, 1].Text.Equals("X") && bf[2, 2].Text.Equals("X")) ||
                (bf[0, 2].Text.Equals("X") && bf[1, 1].Text.Equals("X") && bf[2, 0].Text.Equals("X")))
            {
                return true;
            } else if ((bf[0, 0].Text.Equals("O") && bf[0, 1].Text.Equals("O") && bf[0, 2].Text.Equals("O")) ||
                (bf[1, 0].Text.Equals("O") && bf[1, 1].Text.Equals("O") && bf[1, 2].Text.Equals("O")) ||
                (bf[2, 0].Text.Equals("O") && bf[2, 1].Text.Equals("O") && bf[2, 2].Text.Equals("O")) ||
                (bf[0, 0].Text.Equals("O") && bf[1, 0].Text.Equals("O") && bf[2, 0].Text.Equals("O")) ||
                (bf[0, 1].Text.Equals("O") && bf[1, 1].Text.Equals("O") && bf[2, 1].Text.Equals("O")) ||
                (bf[0, 2].Text.Equals("O") && bf[1, 2].Text.Equals("O") && bf[2, 2].Text.Equals("O")) ||
                (bf[0, 0].Text.Equals("O") && bf[1, 1].Text.Equals("O") && bf[2, 2].Text.Equals("O")) ||
                (bf[0, 2].Text.Equals("O") && bf[1, 1].Text.Equals("O") && bf[2, 0].Text.Equals("O")))
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
