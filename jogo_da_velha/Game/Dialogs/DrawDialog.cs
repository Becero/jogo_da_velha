/*
 *	DrawDialog.cs
 *	Author: Lucas Cota
 *  Description: Game Draw Dialog.
 *	Date: 2018-05-23
 *	Modified: 2018-05-23
 */

using System.Windows.Forms;

namespace jogo_da_velha.Game.Dialogs
{
	class DrawDialog
	{
		public static void Create()
		{
			MessageBoxManager.OK = "ENTENDI";

			MessageBoxManager.Register();

			MessageBox.Show
			(
				"          VOCÊ EMPATOU!          ",
				"EMPATE", MessageBoxButtons.OK, MessageBoxIcon.Information
			);

			MessageBoxManager.Unregister();
		}
	}
}
