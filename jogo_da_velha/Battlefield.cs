using System;
using System.Windows.Forms;

namespace jogo_da_velha
{
	public partial class Battlefield : Form
	{
        // true - 'X'   false - 'Y'
		private bool symbol;
        private bool lastSymbol;
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

        // Botao da Esquerda Superior
		private void btnEsqSup_Click(object sender, EventArgs e)
		{
			OnButtonClick(btnEsqSup);
		}

        // Botao do Centro Superior
		private void btnMidSup_Click(object sender, EventArgs e)
		{
			OnButtonClick(btnMidSup);
		}

        // Botao da Direita Superior
		private void btnDirSup_Click(object sender, EventArgs e)
		{
			OnButtonClick(btnDirSup);
		}

        // Botao da Esquerda Central
		private void btnEsqMid_Click(object sender, EventArgs e)
		{
			OnButtonClick(btnEsqMid);
		}

        // Botao Central
		private void btnMidMid_Click(object sender, EventArgs e)
		{
			OnButtonClick(btnMidMid);
		}

        // Botao da Direita Central
		private void btnDirMid_Click(object sender, EventArgs e)
		{
			OnButtonClick(btnDirMid);
		}

        // Botao da Esquerda Inferior
		private void btnEsqInf_Click(object sender, EventArgs e)
		{
			OnButtonClick(btnEsqInf);
		}

        // Botao do Centro Inferior
		private void btnMidInf_Click(object sender, EventArgs e)
		{
			OnButtonClick(btnMidInf);
		}

        // Botao da Direita Inferior
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

            // Alterna simbolos
            if (button.Text.Equals("X"))
            {
                lastSymbol = true;
                symbol = false;
            }
            else
            {
                lastSymbol = false;
                symbol = true;
            }

            // TODO: Verificar se deu velha

		}




		// Media Player
		private void MediaPlayer_Button_PlayPause_Click(object sender, EventArgs e)
		{

		}

		private void MediaPlayer_Button_NextMusic_Click(object sender, EventArgs e)
		{

		}

		private void MediaPlayer_Button_LastMusic_Click(object sender, EventArgs e)
		{

		}

		private void MediaPlayer_TrackBar_Volume_Scroll(object sender, EventArgs e)
		{

		}
	}
}
