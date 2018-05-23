/*
 *	VictoryDialog.cs
 *	Author: Lucas Cota
 *  Description: Game Victory Dialog.
 *	Date: 2018-05-23
 *	Modified: 2018-05-23
 */

using System.Windows.Forms;

namespace jogo_da_velha.Game.Dialogs
{
	class VictoryDialog
	{
		public static void Create()
		{
			MessageBoxManager.OK = "YEAH";

			MessageBoxManager.Register();

			DialogResult resetDialog = MessageBox.Show
			(
				"          VOCÊ GANHOU!          ",
				"VITÓRIA", MessageBoxButtons.OK, MessageBoxIcon.Information
			);

			MessageBoxManager.Unregister();
		}
	}
}
