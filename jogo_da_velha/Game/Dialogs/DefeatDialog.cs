/*
 *	DefeatDialog.cs
 *	Author: Lucas Cota
 *  Description: Game Defeat Dialog.
 *	Date: 2018-05-23
 *	Modified: 2018-05-23
 */

using System.Windows.Forms;

namespace jogo_da_velha.Game.Dialogs
{
	class DefeatDialog
	{
		public static void Create()
		{
			MessageBoxManager.OK = "CHORAR";

			MessageBoxManager.Register();

			DialogResult resetDialog = MessageBox.Show
			(
				"          VOCÊ PERDEU! PARABÉNS!          ",
				"DERROTA", MessageBoxButtons.OK, MessageBoxIcon.Information
			);

			MessageBoxManager.Unregister();
		}
	}
}
