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
using jogo_da_velha.Interfaces;

namespace jogo_da_velha
{
	public partial class Battlefield : Form, IOnAudioChange
	{
		// Resources
		private bool lastSymbol;
		private bool playerSymbol;
		private bool gameStarted = false;



		// AudioPlayer Resources
		private bool audioPaused;
		private AudioPlayer audioPlayer; 




		// Default Constructor
		public Battlefield()
		{
			InitializeComponent();

			// Initialize AudioPlayer
			if (!Directory.Exists("Music/"))
			{
				Directory.CreateDirectory("Music/");
			}

			audioPlayer = new AudioPlayer(this, Directory.GetFiles("Music/").ToList());

			// Initialize AudioPlayer Stream
			if (!audioPlayer.Stream())
			{
				MediaPlayer_Label_AudioName.Text = "Nenhuma música encontrada na pasta 'Music'. Você pode adicionar músicas nessa pasta para escutar durante o jogo.";
			}

			OnVolumeChange();
		}




		// Events
		private void btnStart_Click(object sender, EventArgs e)
		{
			if (!gameStarted)
			{
				OnSymbolSelect();

				btnStart.Text = "Reset";

				gameStarted = true;
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
				playerSymbol = true;
			}
			else
			{
				playerSymbol = false;
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
				if (playerSymbol)
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
				playerSymbol = false;
				lastSymbol = true;
			}
			else
			{
				playerSymbol = true;
				lastSymbol = false;
			}
		}




		// AudioPlayer
		private void MediaPlayer_Button_PlayPause_Click(object sender, EventArgs e)
		{
			if (audioPaused)
			{
				audioPlayer.Play();

				MediaPlayer_Button_PlayPause.Text = "❚❚";

				audioPaused = false;
			}
			else
			{
				audioPlayer.Pause();

				MediaPlayer_Button_PlayPause.Text = "▶";

				audioPaused = true;
			}
		}

		private void MediaPlayer_Button_NextMusic_Click(object sender, EventArgs e)
		{
			audioPlayer.NextAudio();

			MediaPlayer_Button_PlayPause.Text = "❚❚";
		}

		private void MediaPlayer_Button_LastMusic_Click(object sender, EventArgs e)
		{
			audioPlayer.LastAudio();

			MediaPlayer_Button_PlayPause.Text = "❚❚";
		}

		private void MediaPlayer_TrackBar_Volume_Scroll(object sender, EventArgs e)
		{
			OnVolumeChange();
		}




		// AudioPlayer Events
		private void OnVolumeChange()
		{
			audioPlayer.SetVolume(MediaPlayer_TrackBar_Volume.Value);

			if (MediaPlayer_TrackBar_Volume.Value > 0)
			{
				MediaPlayer_Label_VolumeValue.Text = String.Format("{0}%", MediaPlayer_TrackBar_Volume.Value);
			}
			else
			{
				MediaPlayer_Label_VolumeValue.Text = "Muted";
			}
		}




		// Interfaces
		void IOnAudioChange.AudioChanged()
		{
			MediaPlayer_Label_AudioName.Text = audioPlayer.GetAudioName();
		}
	}
}
