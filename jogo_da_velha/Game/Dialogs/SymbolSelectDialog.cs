/*
 *	SymbolSelectDialog.cs
 *	Author: Lucas Cota
 *  Description: Symbol Select Dialog.
 *	Date: 2018-05-23
 *	Modified: 2018-05-23
 */

using System.Windows.Forms;

namespace jogo_da_velha.Game.Dialogs
{
	class SymbolSelectDialog
	{
		public static DialogResult Create()
		{
			MessageBoxManager.No = "O";
			MessageBoxManager.Yes = "X";

			MessageBoxManager.Register();

			DialogResult symbolDialog = MessageBox.Show
			(
				"Selecione um símbolo.",
				"Jogo da Velha", MessageBoxButtons.YesNo, MessageBoxIcon.Information
			);

			MessageBoxManager.Unregister();

			return symbolDialog;
		}
	}
}
