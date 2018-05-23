/*
 *	Battlefield.cs
 *	Author: Lucas Cota, Carlos Alberto, Caio Souza, Gabriel Werneck
 *  Description: Game Battlefield.
 *	Date: 2018-05-23
 *	Modified: 2018-05-23
 */

using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;

using jogo_da_velha.Modules;
using jogo_da_velha.Interfaces;

namespace jogo_da_velha.Game
{
    public partial class Battlefield : Form, IOnAudioChange
    {
        // Resources
        private String playerSymbol;
        private Control[,] battleMatrix = new Control[3,3];

		// Check
		private bool gameStarted = false;

		// AudioPlayer Resources
		private bool audioPaused;
		private AudioPlayer audioPlayer;
		private AudioPlayer audioPlayerTemp;




		// Default Constructor
		public Battlefield()
		{
			InitializeComponent();

			// Initialize AudioPlayer
			try
			{
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
				else
				{
					OnAudioTimeChanged.Start();

					OnVolumeChange();
				}
			}
			catch (IOException e)
			{
				Console.WriteLine(e);
			}
			catch (Exception e)
			{
				Console.WriteLine(e);
			}
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
			OnButtonClick(btnEsqSup, 0, 0);
		}

		// Botão do Centro Superior
		private void btnMidSup_Click(object sender, EventArgs e)
		{
			OnButtonClick(btnMidSup, 0 ,1);
		}

		// Botão da Esquerda Central
		private void btnDirSup_Click(object sender, EventArgs e)
		{
			OnButtonClick(btnDirSup, 0, 2);
		}

		// Botão Central
		private void btnEsqMid_Click(object sender, EventArgs e)
		{
			OnButtonClick(btnEsqMid, 1, 0);
		}

		// Botão da Direita Central
		private void btnMidMid_Click(object sender, EventArgs e)
		{
			OnButtonClick(btnMidMid, 1, 1);
		}

		// Botão da Direita Central
		private void btnDirMid_Click(object sender, EventArgs e)
		{
			OnButtonClick(btnDirMid, 1, 2);
		}

		// Botão da Esquerda Inferior
		private void btnEsqInf_Click(object sender, EventArgs e)
		{
			OnButtonClick(btnEsqInf, 2, 0);
		}

		// Botão do Centro Inferior
		private void btnMidInf_Click(object sender, EventArgs e)
		{
			OnButtonClick(btnMidInf, 2, 1);
		}

		// Botão da Direita Inferior
		private void btnDirInf_Click(object sender, EventArgs e)
		{
			OnButtonClick(btnDirInf, 2, 2);
		}




		// Game Events
		private void OnGameStart(params Button[] gameButtons)
		{
            int bt = 0;

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    battleMatrix[i, j] = gameButtons[bt];
                    battleMatrix[i, j].Text = "";
                    battleMatrix[i, j].Enabled = true;

                    bt++;
                }
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
				playerSymbol = "X";
			}
			else
			{
				playerSymbol = "O";
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

			// AudioPlayer Transition
			if (audioPlayerTemp != null)
			{
				audioPlayerTemp.Stop();
			}

			if (!audioPaused)
			{
				audioPlayer.Play();
			}
		}

		private void OnGameTerminated(bool isVictory)
		{
			if (isVictory && File.Exists("sounds/victory.mp3"))
			{
				audioPlayer.Pause();

				audioPlayerTemp = new AudioPlayer();

				audioPlayerTemp.SetVolume(MediaPlayer_TrackBar_Volume.Value);

				audioPlayerTemp.Stream("sounds/victory.mp3");
			}
		}

		private void OnButtonClick(Button button, int posX, int posY)
		{
			if (button.Enabled)
			{
				if (playerSymbol.Equals("X"))
				{
					button.Text = "X";
				}
				else
				{
					button.Text = "O";
				}
                
                battleMatrix[posX, posY] = button;

				button.Enabled = false;
			}
            
            // Human Victory
            if (GameLogic.CheckVictory(battleMatrix))
            {
				OnGameTerminated(true);

                MessageBox.Show("Humano venceu!");

				OnGameReset();

				return;
            }

            if (button.Text.Equals("X"))
			{
                GameLogic.EnemyMovement("O", battleMatrix);
            }
			else
			{
                GameLogic.EnemyMovement("X", battleMatrix);
            }
            
            // CPU Victory
            if (GameLogic.CheckVictory(battleMatrix))
            {
				OnGameTerminated(false);

				MessageBox.Show("Computador venceu!");

				OnGameReset();

				return;
            }
        }




		// MediaPlayer
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
			audioPlayer.Next();

			MediaPlayer_Button_PlayPause.Text = "❚❚";
		}

		private void MediaPlayer_Button_LastMusic_Click(object sender, EventArgs e)
		{
			audioPlayer.Back();

			MediaPlayer_Button_PlayPause.Text = "❚❚";
		}

		private void MediaPlayer_TrackBar_Volume_Scroll(object sender, EventArgs e)
		{
			OnVolumeChange();
		}

		private void MediaPlayer_TrackBar_AudioTime_Scroll(object sender, EventArgs e)
		{
			audioPlayer.SetTime(MediaPlayer_TrackBar_AudioTime.Value);
		}

		private void MediaPlayer_TrackBar_AudioTime_MouseDown(object sender, MouseEventArgs e)
		{
			audioPlayer.SetTime(Convert.ToInt32(((double)e.X / (double)MediaPlayer_TrackBar_AudioTime.Width) * MediaPlayer_TrackBar_AudioTime.Maximum));
		}

		private void MediaPlayer_Timer_AudioTime_Tick(object sender, EventArgs e)
		{
			MediaPlayer_Label_AudioTime.Text = String.Format("{0} / {1}", audioPlayer.GetAudioCurrentTime().ToString("mm\\:ss"), audioPlayer.GetAudioTime().ToString("mm\\:ss"));

			MediaPlayer_TrackBar_AudioTime.Value = Math.Min(MediaPlayer_TrackBar_AudioTime.Maximum, (int)(100 * audioPlayer.GetAudioCurrentTime().TotalSeconds / audioPlayer.GetAudioTime().TotalSeconds));
		}




		// MediaPlayer Events
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
