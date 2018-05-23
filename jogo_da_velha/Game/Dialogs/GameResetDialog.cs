/*
 *	GameResetDialog.cs
 *	Author: Lucas Cota
 *  Description: Game Reset Dialog.
 *	Date: 2018-05-23
 *	Modified: 2018-05-23
 */

using System.Windows.Forms;

namespace jogo_da_velha.Game.Dialogs
{
	class GameResetDialog
	{
		public static DialogResult Create()
		{
			MessageBoxManager.No = "Não";
			MessageBoxManager.Yes = "Sim";

			MessageBoxManager.Register();

			DialogResult resetDialog = MessageBox.Show
			(
				"Deseja começar um novo jogo?",
				"Jogo da Velha", MessageBoxButtons.YesNo, MessageBoxIcon.Question
			);

			MessageBoxManager.Unregister();

			return resetDialog;
		}
	}
}
