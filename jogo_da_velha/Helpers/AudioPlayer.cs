/*
 *	AudioPlayer.cs
 *	Author: Lucas Cota
 *  Description: Audio Streamer.
 *	Date: 2018-05-16
 *	Modified: 2018-05-16
 */

using System;
using NAudio;
using NAudio.Wave;
using System.Collections.Generic;

namespace jogo_da_velha.Helpers
{
	class AudioPlayer
	{
		// Resources
		private WaveStream waveStream;
		private IWavePlayer audioPlayer;
		private Queue<string> audioPlaylist;




		// Playlist Constructor
		public AudioPlayer(List<string> audioPlaylist)
		{
			this.audioPlaylist = new Queue<string>(audioPlaylist);
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
			waveStream = new AudioFileReader(audioPlaylist.Dequeue());

			audioPlayer.Init(waveStream);
			audioPlayer.PlaybackStopped += (sender, evn) => { Stream(); };
			audioPlayer.Play();

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
	}
}
