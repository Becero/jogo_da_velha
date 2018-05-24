/*
 *	GameLogic.cs
 *	Author: Carlos Alberto
 *  Description: Game Battlefield Logic.
 *	Date: 2018-05-17
 *	Modified: 2018-05-17
 */

using System;
using System.Windows.Forms;

using jogo_da_velha.Game.Dialogs;

namespace jogo_da_velha.Game
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

            int i = 0;
            int j = 0;

            // Verifica quais casa estao vazias e salva a qtd
            for (i = 0; i < 3; i++)
            {
                for (j = 0; j < 3; j++)
                {
                    if (bf[i, j].Text.Equals(""))
                    {
                        countPossiblePositions++;
                    }
                }
            }

            if (countPossiblePositions == 0)
            {
				DrawDialog.Create();

                return;
            }

            // Cria um vetor com qtd de posicoes dinamicas
            possibleMovements = new Control[countPossiblePositions];

            // Usa uma posicao aleatoria
            randomPosition = random.Next(possibleMovements.Length);

            // Zera a qtd de posicoes para usar a variavel como um controlador para o preenchimento do vetor de posicoes
            countPossiblePositions = 0;

            // Preenche o vetor com os campos livres
            for (i = 0; i < 3; i++)
            {
                for (j = 0; j < 3; j++)
                {
                    if (bf[i, j].Text.Equals(""))
                    {
                        // Adiciona as posicoes livres para movimentar
                        possibleMovements[countPossiblePositions] = bf[i, j];
                        countPossiblePositions++;
                    }
                }
            }
            
            // Controlador das jogadas do humano
            int countHumanSelection = 0;
            Control freePosIAplay = new Control();
        
            /*
             * DIAGONAIS - Verifica cada possibilidade de vitória inimiga nas diagonais
             */
            // Primeira Diagonal
            // Esquerda superior e centro
            if ((!bf[0, 0].Text.Equals(symbol) && (!bf[0, 0].Text.Equals(""))) &&
                (!bf[1, 1].Text.Equals(symbol) && (!bf[1, 1].Text.Equals(""))))
            {
                // Verifica se direita inferior esta livre
                if (bf[2, 2].Text.Equals(""))
                {
                    // Defende
                    bf[2, 2].Text = symbol;
                    bf[2, 2].Enabled = false;
                    return;
                }                
            }

            // Esquerda superior e direita inferior
            if ((!bf[0, 0].Text.Equals(symbol) && (!bf[0, 0].Text.Equals(""))) &&
                (!bf[2, 2].Text.Equals(symbol) && (!bf[2, 2].Text.Equals(""))))
            {
                // Verifica se centro esta livre
                if (bf[1, 1].Text.Equals(""))
                {
                    // Defende
                    bf[1, 1].Text = symbol;
                    bf[1, 1].Enabled = false;
                    return;
                }
            }

            // Centro e direita inferior
            if ((!bf[2, 2].Text.Equals(symbol) && (!bf[2, 2].Text.Equals(""))) &&
                (!bf[1, 1].Text.Equals(symbol) && (!bf[1, 1].Text.Equals(""))))
            {
                // Verifica se esquerda superior esta livre
                if (bf[0, 0].Text.Equals(""))
                {
                    // Defende
                    bf[0, 0].Text = symbol;
                    bf[0, 0].Enabled = false;
                    return;
                }
            }

            // Segunda Diagonal
            // Direita superior e centro
            if ((!bf[0, 2].Text.Equals(symbol) && (!bf[0, 2].Text.Equals(""))) &&
                (!bf[1, 1].Text.Equals(symbol) && (!bf[1, 1].Text.Equals(""))))
            {
                // Verifica se esquerda inferior esta livre
                if (bf[2, 0].Text.Equals(""))
                {
                    // Defende
                    bf[2, 0].Text = symbol;
                    bf[2, 0].Enabled = false;
                    return;
                }
            }

            // Direita superior e esquerda inferior
            if ((!bf[0, 2].Text.Equals(symbol) && (!bf[0, 2].Text.Equals(""))) &&
                (!bf[2, 0].Text.Equals(symbol) && (!bf[2, 0].Text.Equals(""))))
            {
                // Verifica se centro esta livre
                if (bf[1, 1].Text.Equals(""))
                {
                    // Defende
                    bf[1, 1].Text = symbol;
                    bf[1, 1].Enabled = false;
                    return;
                }
            }

            // Esquerda inferior e centro
            if ((!bf[2, 0].Text.Equals(symbol) && (!bf[2, 0].Text.Equals(""))) &&
                (!bf[1, 1].Text.Equals(symbol) && (!bf[1, 1].Text.Equals(""))))
            {
                // Verifica se direita superior esta livre
                if (bf[0, 2].Text.Equals(""))
                {
                    // Defende
                    bf[0, 2].Text = symbol;
                    bf[0, 2].Enabled = false;
                    return;
                }
            }

            // Checa todas as linhas pra ver se tem chance do humano vencer
            for (i = 0; i < 3; i++)
            {
                for (j = 0; j < 3; j++)
                {
                    // posicao vazia
                    if (bf[i, j].Text.Equals(""))
                    {
                        // Armazena a posicao livre
                        freePosIAplay = bf[i, j];
                    }
                    else
                    {
                        // Verifica se o simbolo na posicao é diferente do simbolo da IA
                        if (!bf[i, j].Text.Equals(symbol))
                        {
                            // Sendo diferente, incrementa a contagem humana
                            countHumanSelection++;
                        }
                    }
                }

                // Se humano marcou 2 casas na mesma linha e a posicao de defesa esta livre, IA defende
                if (countHumanSelection == 2 && freePosIAplay.Text.Equals(""))
                {
                    freePosIAplay.Text = symbol;
                    freePosIAplay.Enabled = false;
                    return;
                }
                else
                {
                    // Reinicia a contagem para a próxima linha
                    countHumanSelection = 0;
                }

            }

            // Reinicia contagem para a verificacao de colunas
            countHumanSelection = 0;

            // Verifica todas as colunas pra ver se tem chance do humano vencer
            for (i = 0; i < 3; i++)
            {
                for (j = 0; j < 3; j++)
                {
                    // posicao vazia
                    if (bf[j, i].Text.Equals(""))
                    {
                        freePosIAplay = bf[j, i];
                    }
                    else
                    {
                        // Verifica se o simbolo na posicao é diferente do simbolo da IA
                        if (!bf[j, i].Text.Equals(symbol))
                        {
                            // Sendo diferente, incrementa a contagem humana
                            countHumanSelection++;
                        }
                    }
                }

                // Se humano marcou 2 casas na mesma coluna e a posicao de defesa esta livre, IA defende
                if (countHumanSelection == 2 && freePosIAplay.Text.Equals(""))
                {
                    freePosIAplay.Text = symbol;
                    freePosIAplay.Enabled = false;
                    return;
                }
                else
                {
                    // Reinicia a contagem para a próxima linha
                    countHumanSelection = 0;
                }
            }

            // Se o centro estiver livre, seleciona (melhor posicao)
            if (bf[1, 1].Text.Equals(""))
            {
                bf[1, 1].Text = symbol;
                bf[1, 1].Enabled = false;
                return;
            }
            // Se o centro ja foi selecionado, joga aleatoriamente
            else
            {
                // Se a IA nao precisar tomar nenhuma decisao, faz uma jogada aleatoria
                possibleMovements[randomPosition].Text = symbol;
                possibleMovements[randomPosition].Enabled = false;
            }
        }



        // Verifica se houve vitória
        public static bool CheckVictory(Control[,] bf, String symbol)
        {
            if ((bf[0, 0].Text.Equals(symbol) && bf[0, 1].Text.Equals(symbol) && bf[0, 2].Text.Equals(symbol)) ||
                (bf[1, 0].Text.Equals(symbol) && bf[1, 1].Text.Equals(symbol) && bf[1, 2].Text.Equals(symbol)) ||
                (bf[2, 0].Text.Equals(symbol) && bf[2, 1].Text.Equals(symbol) && bf[2, 2].Text.Equals(symbol)) ||
                (bf[0, 0].Text.Equals(symbol) && bf[1, 0].Text.Equals(symbol) && bf[2, 0].Text.Equals(symbol)) ||
                (bf[0, 1].Text.Equals(symbol) && bf[1, 1].Text.Equals(symbol) && bf[2, 1].Text.Equals(symbol)) ||
                (bf[0, 2].Text.Equals(symbol) && bf[1, 2].Text.Equals(symbol) && bf[2, 2].Text.Equals(symbol)) ||
                (bf[0, 0].Text.Equals(symbol) && bf[1, 1].Text.Equals(symbol) && bf[2, 2].Text.Equals(symbol)) ||
                (bf[0, 2].Text.Equals(symbol) && bf[1, 1].Text.Equals(symbol) && bf[2, 0].Text.Equals(symbol)))
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
