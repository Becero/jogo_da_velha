/*
 *	Program.cs
 *	Author: Lucas Cota, Carlos Alberto, Caio Souza, Gabriel Werneck
 *  Description: Main.
 *	Date: 2018-05-16
 *	Modified: 2018-05-16
 */

using System;
using System.Windows.Forms;

using jogo_da_velha.Game

namespace jogo_da_velha
{
    static class Program
    {
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Battlefield());
        }
    }
}
