/*
 *	Battlefield.cs
 *	Author: Lucas Cota, Carlos Alberto, Caio Souza, Gabriel Werneck
 *  Description: Game Battlefield.
 *	Date: 2018-05-16
 *	Modified: 2018-05-16
 */

using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using jogo_da_velha.Helpers;

namespace jogo_da_velha
{
	public partial class Battlefield : Form
	{
		// Resources
		private bool symbol;
		private bool lastSymbol;
		private bool started = false;



		// AudioPlayer Resources
		private bool audioPlayer_Paused;
		private AudioPlayer audioPlayer = new AudioPlayer(Directory.GetFiles("Soundtrack/").ToList());




		// Default Constructor
		public Battlefield()
		{
			InitializeComponent();

			audioPlayer.Stream();
		}




		// Events
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

		// Botão da Esquerda Superior
		private void btnEsqSup_Click(object sender, EventArgs e)
		{
			OnButtonClick(btnEsqSup);
		}

		// Botão do Centro Superior
		private void btnMidSup_Click(object sender, EventArgs e)
		{
			OnButtonClick(btnMidSup);
		}

		// Botão da Esquerda Central
		private void btnDirSup_Click(object sender, EventArgs e)
		{
			OnButtonClick(btnDirSup);
		}

		// Botão Central
		private void btnEsqMid_Click(object sender, EventArgs e)
		{
			OnButtonClick(btnEsqMid);
		}

		// Botão da Direita Central
		private void btnMidMid_Click(object sender, EventArgs e)
		{
			OnButtonClick(btnMidMid);
		}

		// Botão da Direita Central
		private void btnDirMid_Click(object sender, EventArgs e)
		{
			OnButtonClick(btnDirMid);
		}

		// Botão da Esquerda Inferior
		private void btnEsqInf_Click(object sender, EventArgs e)
		{
			OnButtonClick(btnEsqInf);
		}

		// Botão do Centro Inferior
		private void btnMidInf_Click(object sender, EventArgs e)
		{
			OnButtonClick(btnMidInf);
		}

		// Botão da Direita Inferior
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
		}




		// Media Player
		private void MediaPlayer_Button_PlayPause_Click(object sender, EventArgs e)
		{
			if (audioPlayer_Paused)
			{
				audioPlayer.Play();

				MediaPlayer_Button_PlayPause.Text = "Pause";

				audioPlayer_Paused = false;
			}
			else
			{
				audioPlayer.Pause();

				MediaPlayer_Button_PlayPause.Text = "Play";

				audioPlayer_Paused = true;
			}
		}

		private void MediaPlayer_Button_NextMusic_Click(object sender, EventArgs e)
		{

		}

		private void MediaPlayer_Button_LastMusic_Click(object sender, EventArgs e)
		{

		}

		private void MediaPlayer_TrackBar_Volume_Scroll(object sender, EventArgs e)
		{
			OnVolumeChange();
		}

		private void OnVolumeChange()
		{
			audioPlayer.SetVolume(MediaPlayer_TrackBar_Volume.Value);

			MediaPlayer_Label_VolumeValue.Text = String.Format("{0}%", MediaPlayer_TrackBar_Volume.Value);
		}
	}
}
