﻿using System;
using System.Windows.Forms;

using NAudio;

namespace jogo_da_velha
{
	public partial class Battlefield : Form
	{
		private bool symbol;
		private bool started = false;

		public Battlefield()
		{
			InitializeComponent();
		}

		private void btnStart_Click(object sender, EventArgs e)
		{
			if (!started)
			{
				OnSymbolSelect();

				started = true;

				btnStart.Text = "Reset";
			}
			else
			{
				OnGameReset();
			}
		}

		private void btnEsqSup_Click(object sender, EventArgs e)
		{
			OnButtonClick(btnEsqSup);
		}

		private void btnMidSup_Click(object sender, EventArgs e)
		{
			OnButtonClick(btnMidSup);
		}

		private void btnDirSup_Click(object sender, EventArgs e)
		{
			OnButtonClick(btnDirSup);
		}

		private void btnEsqMid_Click(object sender, EventArgs e)
		{
			OnButtonClick(btnEsqMid);
		}

		private void btnMidMid_Click(object sender, EventArgs e)
		{
			OnButtonClick(btnMidMid);
		}

		private void btnDirMid_Click(object sender, EventArgs e)
		{
			OnButtonClick(btnDirMid);
		}

		private void btnEsqInf_Click(object sender, EventArgs e)
		{
			OnButtonClick(btnEsqInf);
		}

		private void btnMidInf_Click(object sender, EventArgs e)
		{
			OnButtonClick(btnMidInf);
		}

		private void btnDirInf_Click(object sender, EventArgs e)
		{
			OnButtonClick(btnDirInf);
		}




		// Game Events
		private void OnGameStart(params Button[] gameButtons)
		{
			foreach (Button currentButton in gameButtons)
			{
				currentButton.Text = null;
				currentButton.Enabled = true;
			}
		}

		private void OnSymbolSelect()
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

			if (symbolDialog == DialogResult.Yes)
			{
				symbol = true;
			}
			else
			{
				symbol = false;
			}

			OnGameStart(btnEsqSup, btnMidSup, btnDirSup, btnEsqMid, btnMidMid, btnDirMid, btnEsqInf, btnMidInf, btnDirInf);
		}

		private void OnGameReset()
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

			if (resetDialog == DialogResult.Yes)
			{
				OnSymbolSelect();
			}
		}

		private void OnButtonClick(Button button)
		{
			if (button.Enabled)
			{
				if (symbol)
				{
					button.Text = "X";
				}
				else
				{
					button.Text = "O";
				}

				button.Enabled = false;
			}
		}
	}
}
