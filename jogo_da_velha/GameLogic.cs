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
        // Armazena uma lista de posicoes livres
        private static Control[] possibleMovements;

        // Movimento inimigo
        public static void EnemyMovement(String symbol, Control[,] bf)
        {
            // Quantidade de posicoes livres
            int countPossiblePositions = 0;

            Random random = new Random();
            int randomPosition;

            // Verifica quais casa estao vazia
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (bf[i, j].Text.Equals(""))
                    {
                        countPossiblePositions++;
                    }
                }
            }

            if(countPossiblePositions == 0)
            {
                MessageBox.Show("Empate!");
                return;
            }

            // Cria um vetor com qtd de posicoes dinamicas
            possibleMovements = new Control[countPossiblePositions];

            // Usa uma posicao aleatoria
            randomPosition = random.Next(possibleMovements.Length);

            // Zera a qtd de posicoes para usar a variavel como um controlador para o preenchimento do vetor de posicoes
            countPossiblePositions = 0;

            // Preenche o vetor com os campos livres
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (bf[i, j].Text.Equals(""))
                    {
                        // Adiciona as posicoes livres para movimentar
                        possibleMovements[countPossiblePositions] = bf[i, j];
                        countPossiblePositions++;
                    }
                }
            }

            // percepcao X

            if (bf[0, 0].Text.Equals("X") && bf[0, 1].Text.Equals("X"))
            {
                bf[0, 2].Text = symbol;
                bf[0, 2].Enabled = false;
            }
            if (bf[0, 1].Text.Equals("X") && bf[0, 2].Text.Equals("X"))
            {
                bf[0, 0].Text = symbol;
                bf[0, 0].Enabled = false;
            }
            if (bf[0, 0].Text.Equals("X") && bf[0, 2].Text.Equals("X"))
            {
                bf[0, 1].Text = symbol;
                bf[0, 1].Enabled = false;
            }


            if (bf[1, 0].Text.Equals("X") && bf[1, 1].Text.Equals("X"))
            {
                bf[1, 2].Text = symbol;
                bf[1, 2].Enabled = false;
            }
            if (bf[1, 1].Text.Equals("X") && bf[1, 2].Text.Equals("X"))
            {
                bf[1, 0].Text = symbol;
                bf[1, 0].Enabled = false;
            }
            if (bf[1, 0].Text.Equals("X") && bf[1, 2].Text.Equals("X"))
            {
                bf[1, 1].Text = symbol;
                bf[1, 1].Enabled = false;
            }


            if (bf[2, 0].Text.Equals("X") && bf[2, 1].Text.Equals("X"))
            {
                bf[2, 2].Text = symbol;
                bf[2, 2].Enabled = false;
            }
            if (bf[2, 1].Text.Equals("X") && bf[2, 2].Text.Equals("X"))
            {
                bf[2, 0].Text = symbol;
                bf[2, 0].Enabled = false;
            }
            if (bf[2, 0].Text.Equals("X") && bf[2, 2].Text.Equals("X"))
            {
                bf[2, 1].Text = symbol;
                bf[2, 1].Enabled = false;
            }


            if (bf[0, 0].Text.Equals("X") && bf[1, 0].Text.Equals("X"))
            {
                bf[2, 0].Text = symbol;
                bf[2, 0].Enabled = false;
            }
            if (bf[1, 0].Text.Equals("X") && bf[2, 0].Text.Equals("X"))
            {
                bf[0, 0].Text = symbol;
                bf[0, 0].Enabled = false;
            }
            if (bf[0, 0].Text.Equals("X") && bf[2, 0].Text.Equals("X"))
            {
                bf[1, 0].Text = symbol;
                bf[1, 0].Enabled = false;
            }


            if (bf[0, 1].Text.Equals("X") && bf[1, 1].Text.Equals("X"))
            {
                bf[2, 1].Text = symbol;
                bf[2, 1].Enabled = false;
            }
            if (bf[1, 1].Text.Equals("X") && bf[2, 1].Text.Equals("X"))
            {
                bf[0, 1].Text = symbol;
                bf[0, 1].Enabled = false;
            }
            if (bf[0, 1].Text.Equals("X") && bf[2, 1].Text.Equals("X"))
            {
                bf[1, 1].Text = symbol;
                bf[1, 1].Enabled = false;
            }


            if (bf[0, 2].Text.Equals("X") && bf[1, 2].Text.Equals("X"))
            {
                bf[2, 2].Text = symbol;
                bf[2, 2].Enabled = false;
            }
            if (bf[1, 2].Text.Equals("X") && bf[2, 2].Text.Equals("X"))
            {
                bf[0, 2].Text = symbol;
                bf[0, 2].Enabled = false;
            }
            if (bf[0, 2].Text.Equals("X") && bf[2, 2].Text.Equals("X"))
            {
                bf[1, 2].Text = symbol;
                bf[1, 2].Enabled = false;
            }



            if (bf[0, 0].Text.Equals("X") && bf[1, 1].Text.Equals("X"))
            {
                bf[2, 2].Text = symbol;
                bf[2, 2].Enabled = false;
            }
            if (bf[1, 1].Text.Equals("X") && bf[2, 2].Text.Equals("X"))
            {
                bf[0, 0].Text = symbol;
                bf[0, 0].Enabled = false;
            }
            if (bf[0, 0].Text.Equals("X") && bf[2, 2].Text.Equals("X"))
            {
                bf[1, 1].Text = symbol;
                bf[1, 1].Enabled = false;
            }


            if (bf[0, 2].Text.Equals("X") && bf[1, 1].Text.Equals("X"))
            {
                bf[2, 0].Text = symbol;
                bf[2, 0].Enabled = false;
            }
            if (bf[1, 1].Text.Equals("X") && bf[2, 0].Text.Equals("X"))
            {
                bf[0, 2].Text = symbol;
                bf[0, 2].Enabled = false;
            }
            if (bf[0, 2].Text.Equals("X") && bf[2, 0].Text.Equals("X"))
            {
                bf[1, 1].Text = symbol;
                bf[1, 1].Enabled = false;
            }


            if (bf[0, 0].Text.Equals("X") && bf[1, 1].Text.Equals("X"))
            {
                bf[2, 2].Text = symbol;
                bf[2, 2].Enabled = false;
            }
            if (bf[1, 1].Text.Equals("X") && bf[2, 2].Text.Equals("X"))
            {
                bf[0, 0].Text = symbol;
                bf[0, 0].Enabled = false;
            }
            if (bf[0, 0].Text.Equals("X") && bf[2, 2].Text.Equals("X"))
            {
                bf[1, 1].Text = symbol;
                bf[1, 1].Enabled = false;
            }


            /* percepcao O
             
             if (bf[0, 0].Text.Equals("O") && bf[0, 1].Text.Equals("O"))
            {
                bf[0, 2].Text = symbol;
                bf[0, 2].Enabled = false;
            }
            if (bf[0, 1].Text.Equals("O") && bf[0, 2].Text.Equals("O"))
            {
                bf[0, 0].Text = symbol;
                bf[0, 0].Enabled = false;
            }
            if (bf[0, 0].Text.Equals("O") && bf[0, 2].Text.Equals("O"))
            {
                bf[0, 1].Text = symbol;
                bf[0, 1].Enabled = false;
            }


            if (bf[1, 0].Text.Equals("O") && bf[1, 1].Text.Equals("O"))
            {
                bf[1, 2].Text = symbol;
                bf[1, 2].Enabled = false;
            }
            if (bf[1, 1].Text.Equals("O") && bf[1, 2].Text.Equals("O"))
            {
                bf[1, 0].Text = symbol;
                bf[1, 0].Enabled = false;
            }
            if (bf[1, 0].Text.Equals("O") && bf[1, 2].Text.Equals("O"))
            {
            	bf[1, 1].Text = symbol;
                bf[1, 1].Enabled = false;
            }


            if (bf[2, 0].Text.Equals("O") && bf[2, 1].Text.Equals("O"))
            {
                bf[2, 2].Text = symbol;
                bf[2, 2].Enabled = false;
            }
            if (bf[2, 1].Text.Equals("O") && bf[2, 2].Text.Equals("O"))
            {
                bf[2, 0].Text = symbol;
                bf[2, 0].Enabled = false;
            }
            if (bf[2, 0].Text.Equals("O") && bf[2, 2].Text.Equals("O"))
            {
                bf[2, 1].Text = symbol;
                bf[2, 1].Enabled = false;
            }


            if (bf[0, 0].Text.Equals("O") && bf[1, 0].Text.Equals("O"))
            {
                bf[2, 0].Text = symbol;
                bf[2, 0].Enabled = false;
            }
            if (bf[1, 0].Text.Equals("O") && bf[2, 0].Text.Equals("O"))
            {
                bf[0, 0].Text = symbol;
                bf[0, 0].Enabled = false;
            }
            if (bf[0, 0].Text.Equals("O") && bf[2, 0].Text.Equals("O"))
            {
                bf[1, 0].Text = symbol;
                bf[1, 0].Enabled = false;
            }


            if (bf[0, 1].Text.Equals("O") && bf[1, 1].Text.Equals("O"))
            {
               bf[2, 1].Text = symbol;
               bf[2, 1].Enabled = false;
            }
            if (bf[1, 1].Text.Equals("O") && bf[2, 1].Text.Equals("O"))
            {
                bf[0, 1].Text = symbol;
                bf[0, 1].Enabled = false;
            }
            if (bf[0, 1].Text.Equals("O") && bf[2, 1].Text.Equals("O"))
            {
                bf[1, 1].Text = symbol;
                bf[1, 1].Enabled = false;
            }


            if (bf[0, 2].Text.Equals("O") && bf[1, 2].Text.Equals("O"))
            {
                bf[2, 2].Text = symbol;
                bf[2, 2].Enabled = false;
            }
            if (bf[1, 2].Text.Equals("O") && bf[2, 2].Text.Equals("O"))
            {
                bf[0, 2].Text = symbol;
                bf[0, 2].Enabled = false;
            }
            if (bf[0, 2].Text.Equals("O") && bf[2, 2].Text.Equals("O"))
            {
                bf[1, 2].Text = symbol;
                bf[1, 2].Enabled = false;
            }



            if (bf[0, 0].Text.Equals("O") && bf[1, 1].Text.Equals("O"))
            {
                bf[2, 2].Text = symbol;
                bf[2, 2].Enabled = false;
            }
            if (bf[1, 1].Text.Equals("O") && bf[2, 2].Text.Equals("O"))
            {
                bf[0, 0].Text = symbol;
                bf[0, 0].Enabled = false;
            }
            if (bf[0, 0].Text.Equals("O") && bf[2, 2].Text.Equals("O"))
            {
                bf[1, 1].Text = symbol;
                bf[1, 1].Enabled = false;
            }
            

            if (bf[0, 2].Text.Equals("O") && bf[1, 1].Text.Equals("O"))
            {
                bf[2, 0].Text = symbol;
                bf[2, 0].Enabled = false;
            }
            if (bf[1, 1].Text.Equals("O") && bf[2, 0].Text.Equals("O"))
            {
                bf[0, 2].Text = symbol;
                bf[0, 2].Enabled = false;
            }
            if (bf[0, 2].Text.Equals("O") && bf[2, 0].Text.Equals("O"))
            {
                bf[1, 1].Text = symbol;
                bf[1, 1].Enabled = false;
            }


            if (bf[0, 0].Text.Equals("O") && bf[1, 1].Text.Equals("O"))
            {
                bf[2, 2].Text = symbol;
                bf[2, 2].Enabled = false;
            }
            if (bf[1, 1].Text.Equals("O") && bf[2, 2].Text.Equals("O"))
            {
                bf[0, 0].Text = symbol;
                bf[0, 0].Enabled = false;
            }
            if (bf[0, 0].Text.Equals("O") && bf[2, 2].Text.Equals("O"))
            {
                bf[1, 1].Text = symbol;
                bf[1, 1].Enabled = false;
            }
 
              
            */



            /* Faz jogada aleatoria

            else
            {
                possibleMovements[randomPosition].Text = symbol;
                possibleMovements[randomPosition].Enabled = false;

            }

           */


        }





        // Verifica se houve vitória
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
