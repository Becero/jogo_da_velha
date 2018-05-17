/*
 *	AudioPlayer.cs
 *	Author: Lucas Cota
 *  Description: Audio Streamer.
 *	Date: 2018-05-16
 *	Modified: 2018-05-16
 */

using System.IO;
using NAudio.Wave;
using jogo_da_velha.Interfaces;
using System.Collections.Generic;

namespace jogo_da_velha.Helpers
{
	class AudioPlayer
	{
		// Resources
		private WaveStream waveStream;
		private IWavePlayer audioPlayer;
		private int playlistPosition = 0;
		private List<string> audioPlaylist;
		private IOnAudioChange onAudioChange;




		// Playlist Constructor
		public AudioPlayer(IOnAudioChange onAudioChange, List<string> audioPlaylist)
		{
			this.onAudioChange = onAudioChange;
			this.audioPlaylist = new List<string>(audioPlaylist);
		}




		public bool Stream()
		{
			if (audioPlaylist.Count < 1)
			{
				return false;
			}

			if (waveStream != null)
			{
				waveStream.Dispose();
			}

			if (audioPlayer != null && audioPlayer.PlaybackState != PlaybackState.Stopped)
			{
				audioPlayer.Stop();
			}

			if (audioPlayer != null)
			{
				audioPlayer.Dispose();
			}

			audioPlayer = new WaveOutEvent();
			waveStream = new AudioFileReader(audioPlaylist[playlistPosition]);

			audioPlayer.Init(waveStream);
			audioPlayer.PlaybackStopped += (sender, evn) => { Stream(); };
			audioPlayer.Play();

			onAudioChange.AudioChanged();

			return true;
		}

		public void Play()
		{
			if (audioPlayer != null)
			{
				audioPlayer.Play();
			}
		}

		public void Pause()
		{
			if (audioPlayer != null)
			{
				audioPlayer.Pause();
			}
		}

		public void SetVolume(int volume)
		{
			if (audioPlayer != null)
			{
				audioPlayer.Volume = volume / 100f;
			}
		}

		public void NextAudio()
		{
			if (audioPlayer != null)
			{
				if (playlistPosition != audioPlaylist.Count - 1)
				{
					playlistPosition++;
				}
				else
				{
					playlistPosition = 0;
				}

				audioPlayer.Stop();
			}
		}

		public void LastAudio()
		{
			if (audioPlayer != null)
			{
				if (playlistPosition != 0)
				{
					playlistPosition--;
				}
				else
				{
					playlistPosition = audioPlaylist.Count - 1;
				}

				audioPlayer.Stop();
			}
		}

		public string GetAudioName()
		{
			if (audioPlayer != null)
			{
				return Path.GetFileNameWithoutExtension(audioPlaylist[playlistPosition]);
			}

			return null;
		}

		public string GetAudioTime()
		{
			if (audioPlayer != null)
			{
				return waveStream.TotalTime.ToString("mm\\:ss");
			}

			return null;
		}

		public string GetAudioCurrentTime()
		{
			if (audioPlayer != null)
			{
				return waveStream.CurrentTime.ToString("mm\\:ss");
			}

			return null;
		}
	}
}
