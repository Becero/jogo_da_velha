namespace jogo_da_velha
{
    partial class Battlefield
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
			this.components = new System.ComponentModel.Container();
			this.btnEsqSup = new System.Windows.Forms.Button();
			this.btnMidMid = new System.Windows.Forms.Button();
			this.btnEsqMid = new System.Windows.Forms.Button();
			this.btnDirMid = new System.Windows.Forms.Button();
			this.btnDirSup = new System.Windows.Forms.Button();
			this.btnMidSup = new System.Windows.Forms.Button();
			this.btnMidInf = new System.Windows.Forms.Button();
			this.btnDirInf = new System.Windows.Forms.Button();
			this.btnEsqInf = new System.Windows.Forms.Button();
			this.btnStart = new System.Windows.Forms.Button();
			this.MediaPlayer_Button_PlayPause = new System.Windows.Forms.Button();
			this.MediaPlayer_Button_NextMusic = new System.Windows.Forms.Button();
			this.MediaPlayer_Button_LastMusic = new System.Windows.Forms.Button();
			this.MediaPlayer_TrackBar_Volume = new System.Windows.Forms.TrackBar();
			this.MediaPlayer_Label_Volume = new System.Windows.Forms.Label();
			this.MediaPlayer_Label_AudioName = new System.Windows.Forms.Label();
			this.MediaPlayer_Label_VolumeValue = new System.Windows.Forms.Label();
			this.MediaPlayer_Label_AudioTime = new System.Windows.Forms.Label();
			this.OnAudioTimeChanged = new System.Windows.Forms.Timer(this.components);
			this.MediaPlayer_TrackBar_AudioTime = new System.Windows.Forms.TrackBar();
			this.MediaPlayer_LineSeparator = new jogo_da_velha.Components.LineSeparator();
			((System.ComponentModel.ISupportInitialize)(this.MediaPlayer_TrackBar_Volume)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.MediaPlayer_TrackBar_AudioTime)).BeginInit();
			this.SuspendLayout();
			// 
			// btnEsqSup
			// 
			this.btnEsqSup.Enabled = false;
			this.btnEsqSup.Location = new System.Drawing.Point(72, 28);
			this.btnEsqSup.Margin = new System.Windows.Forms.Padding(2);
			this.btnEsqSup.Name = "btnEsqSup";
			this.btnEsqSup.Size = new System.Drawing.Size(56, 61);
			this.btnEsqSup.TabIndex = 0;
			this.btnEsqSup.UseVisualStyleBackColor = true;
			this.btnEsqSup.Click += new System.EventHandler(this.btnEsqSup_Click);
			// 
			// btnMidMid
			// 
			this.btnMidMid.Enabled = false;
			this.btnMidMid.Location = new System.Drawing.Point(132, 93);
			this.btnMidMid.Margin = new System.Windows.Forms.Padding(2);
			this.btnMidMid.Name = "btnMidMid";
			this.btnMidMid.Size = new System.Drawing.Size(56, 61);
			this.btnMidMid.TabIndex = 1;
			this.btnMidMid.UseVisualStyleBackColor = true;
			this.btnMidMid.Click += new System.EventHandler(this.btnMidMid_Click);
			// 
			// btnEsqMid
			// 
			this.btnEsqMid.Enabled = false;
			this.btnEsqMid.Location = new System.Drawing.Point(72, 93);
			this.btnEsqMid.Margin = new System.Windows.Forms.Padding(2);
			this.btnEsqMid.Name = "btnEsqMid";
			this.btnEsqMid.Size = new System.Drawing.Size(56, 61);
			this.btnEsqMid.TabIndex = 2;
			this.btnEsqMid.UseVisualStyleBackColor = true;
			this.btnEsqMid.Click += new System.EventHandler(this.btnEsqMid_Click);
			// 
			// btnDirMid
			// 
			this.btnDirMid.Enabled = false;
			this.btnDirMid.Location = new System.Drawing.Point(192, 93);
			this.btnDirMid.Margin = new System.Windows.Forms.Padding(2);
			this.btnDirMid.Name = "btnDirMid";
			this.btnDirMid.Size = new System.Drawing.Size(56, 61);
			this.btnDirMid.TabIndex = 3;
			this.btnDirMid.UseVisualStyleBackColor = true;
			this.btnDirMid.Click += new System.EventHandler(this.btnDirMid_Click);
			// 
			// btnDirSup
			// 
			this.btnDirSup.Enabled = false;
			this.btnDirSup.Location = new System.Drawing.Point(192, 28);
			this.btnDirSup.Margin = new System.Windows.Forms.Padding(2);
			this.btnDirSup.Name = "btnDirSup";
			this.btnDirSup.Size = new System.Drawing.Size(56, 61);
			this.btnDirSup.TabIndex = 4;
			this.btnDirSup.UseVisualStyleBackColor = true;
			this.btnDirSup.Click += new System.EventHandler(this.btnDirSup_Click);
			// 
			// btnMidSup
			// 
			this.btnMidSup.Enabled = false;
			this.btnMidSup.Location = new System.Drawing.Point(132, 28);
			this.btnMidSup.Margin = new System.Windows.Forms.Padding(2);
			this.btnMidSup.Name = "btnMidSup";
			this.btnMidSup.Size = new System.Drawing.Size(56, 61);
			this.btnMidSup.TabIndex = 5;
			this.btnMidSup.UseVisualStyleBackColor = true;
			this.btnMidSup.Click += new System.EventHandler(this.btnMidSup_Click);
			// 
			// btnMidInf
			// 
			this.btnMidInf.Enabled = false;
			this.btnMidInf.Location = new System.Drawing.Point(132, 158);
			this.btnMidInf.Margin = new System.Windows.Forms.Padding(2);
			this.btnMidInf.Name = "btnMidInf";
			this.btnMidInf.Size = new System.Drawing.Size(56, 61);
			this.btnMidInf.TabIndex = 6;
			this.btnMidInf.UseVisualStyleBackColor = true;
			this.btnMidInf.Click += new System.EventHandler(this.btnMidInf_Click);
			// 
			// btnDirInf
			// 
			this.btnDirInf.Enabled = false;
			this.btnDirInf.Location = new System.Drawing.Point(192, 158);
			this.btnDirInf.Margin = new System.Windows.Forms.Padding(2);
			this.btnDirInf.Name = "btnDirInf";
			this.btnDirInf.Size = new System.Drawing.Size(56, 61);
			this.btnDirInf.TabIndex = 7;
			this.btnDirInf.UseVisualStyleBackColor = true;
			this.btnDirInf.Click += new System.EventHandler(this.btnDirInf_Click);
			// 
			// btnEsqInf
			// 
			this.btnEsqInf.Enabled = false;
			this.btnEsqInf.Location = new System.Drawing.Point(72, 158);
			this.btnEsqInf.Margin = new System.Windows.Forms.Padding(2);
			this.btnEsqInf.Name = "btnEsqInf";
			this.btnEsqInf.Size = new System.Drawing.Size(56, 61);
			this.btnEsqInf.TabIndex = 8;
			this.btnEsqInf.UseVisualStyleBackColor = true;
			this.btnEsqInf.Click += new System.EventHandler(this.btnEsqInf_Click);
			// 
			// btnStart
			// 
			this.btnStart.Location = new System.Drawing.Point(122, 236);
			this.btnStart.Margin = new System.Windows.Forms.Padding(2);
			this.btnStart.Name = "btnStart";
			this.btnStart.Size = new System.Drawing.Size(75, 37);
			this.btnStart.TabIndex = 9;
			this.btnStart.Text = "Start";
			this.btnStart.UseVisualStyleBackColor = true;
			this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
			// 
			// MediaPlayer_Button_PlayPause
			// 
			this.MediaPlayer_Button_PlayPause.Location = new System.Drawing.Point(92, 442);
			this.MediaPlayer_Button_PlayPause.Name = "MediaPlayer_Button_PlayPause";
			this.MediaPlayer_Button_PlayPause.Size = new System.Drawing.Size(75, 23);
			this.MediaPlayer_Button_PlayPause.TabIndex = 11;
			this.MediaPlayer_Button_PlayPause.Text = "❚❚";
			this.MediaPlayer_Button_PlayPause.UseVisualStyleBackColor = true;
			this.MediaPlayer_Button_PlayPause.Click += new System.EventHandler(this.MediaPlayer_Button_PlayPause_Click);
			// 
			// MediaPlayer_Button_NextMusic
			// 
			this.MediaPlayer_Button_NextMusic.Location = new System.Drawing.Point(173, 442);
			this.MediaPlayer_Button_NextMusic.Name = "MediaPlayer_Button_NextMusic";
			this.MediaPlayer_Button_NextMusic.Size = new System.Drawing.Size(75, 23);
			this.MediaPlayer_Button_NextMusic.TabIndex = 12;
			this.MediaPlayer_Button_NextMusic.Text = "▶▶";
			this.MediaPlayer_Button_NextMusic.UseVisualStyleBackColor = true;
			this.MediaPlayer_Button_NextMusic.Click += new System.EventHandler(this.MediaPlayer_Button_NextMusic_Click);
			// 
			// MediaPlayer_Button_LastMusic
			// 
			this.MediaPlayer_Button_LastMusic.Location = new System.Drawing.Point(12, 442);
			this.MediaPlayer_Button_LastMusic.Name = "MediaPlayer_Button_LastMusic";
			this.MediaPlayer_Button_LastMusic.Size = new System.Drawing.Size(75, 23);
			this.MediaPlayer_Button_LastMusic.TabIndex = 13;
			this.MediaPlayer_Button_LastMusic.Text = "◀◀";
			this.MediaPlayer_Button_LastMusic.UseVisualStyleBackColor = true;
			this.MediaPlayer_Button_LastMusic.Click += new System.EventHandler(this.MediaPlayer_Button_LastMusic_Click);
			// 
			// MediaPlayer_TrackBar_Volume
			// 
			this.MediaPlayer_TrackBar_Volume.Location = new System.Drawing.Point(267, 328);
			this.MediaPlayer_TrackBar_Volume.Maximum = 100;
			this.MediaPlayer_TrackBar_Volume.Name = "MediaPlayer_TrackBar_Volume";
			this.MediaPlayer_TrackBar_Volume.Orientation = System.Windows.Forms.Orientation.Vertical;
			this.MediaPlayer_TrackBar_Volume.Size = new System.Drawing.Size(45, 121);
			this.MediaPlayer_TrackBar_Volume.TabIndex = 14;
			this.MediaPlayer_TrackBar_Volume.TickFrequency = 10;
			this.MediaPlayer_TrackBar_Volume.Value = 30;
			this.MediaPlayer_TrackBar_Volume.Scroll += new System.EventHandler(this.MediaPlayer_TrackBar_Volume_Scroll);
			// 
			// MediaPlayer_Label_Volume
			// 
			this.MediaPlayer_Label_Volume.AutoSize = true;
			this.MediaPlayer_Label_Volume.Location = new System.Drawing.Point(264, 312);
			this.MediaPlayer_Label_Volume.Name = "MediaPlayer_Label_Volume";
			this.MediaPlayer_Label_Volume.Size = new System.Drawing.Size(42, 13);
			this.MediaPlayer_Label_Volume.TabIndex = 15;
			this.MediaPlayer_Label_Volume.Text = "Volume";
			// 
			// MediaPlayer_Label_AudioName
			// 
			this.MediaPlayer_Label_AudioName.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.MediaPlayer_Label_AudioName.Location = new System.Drawing.Point(12, 330);
			this.MediaPlayer_Label_AudioName.Name = "MediaPlayer_Label_AudioName";
			this.MediaPlayer_Label_AudioName.Size = new System.Drawing.Size(252, 66);
			this.MediaPlayer_Label_AudioName.TabIndex = 16;
			// 
			// MediaPlayer_Label_VolumeValue
			// 
			this.MediaPlayer_Label_VolumeValue.AutoSize = true;
			this.MediaPlayer_Label_VolumeValue.Location = new System.Drawing.Point(266, 452);
			this.MediaPlayer_Label_VolumeValue.Name = "MediaPlayer_Label_VolumeValue";
			this.MediaPlayer_Label_VolumeValue.Size = new System.Drawing.Size(27, 13);
			this.MediaPlayer_Label_VolumeValue.TabIndex = 17;
			this.MediaPlayer_Label_VolumeValue.Text = "30%";
			// 
			// MediaPlayer_Label_AudioTime
			// 
			this.MediaPlayer_Label_AudioTime.AutoSize = true;
			this.MediaPlayer_Label_AudioTime.Location = new System.Drawing.Point(12, 401);
			this.MediaPlayer_Label_AudioTime.Name = "MediaPlayer_Label_AudioTime";
			this.MediaPlayer_Label_AudioTime.Size = new System.Drawing.Size(72, 13);
			this.MediaPlayer_Label_AudioTime.TabIndex = 18;
			this.MediaPlayer_Label_AudioTime.Text = "00:00 / 00:00";
			// 
			// OnAudioTimeChanged
			// 
			this.OnAudioTimeChanged.Tick += new System.EventHandler(this.MediaPlayer_Timer_AudioTime_Tick);
			// 
			// MediaPlayer_TrackBar_AudioTime
			// 
			this.MediaPlayer_TrackBar_AudioTime.AutoSize = false;
			this.MediaPlayer_TrackBar_AudioTime.LargeChange = 0;
			this.MediaPlayer_TrackBar_AudioTime.Location = new System.Drawing.Point(7, 417);
			this.MediaPlayer_TrackBar_AudioTime.Maximum = 100;
			this.MediaPlayer_TrackBar_AudioTime.Name = "MediaPlayer_TrackBar_AudioTime";
			this.MediaPlayer_TrackBar_AudioTime.Size = new System.Drawing.Size(241, 20);
			this.MediaPlayer_TrackBar_AudioTime.TabIndex = 19;
			this.MediaPlayer_TrackBar_AudioTime.TickStyle = System.Windows.Forms.TickStyle.None;
			this.MediaPlayer_TrackBar_AudioTime.Scroll += new System.EventHandler(this.MediaPlayer_TrackBar_AudioTime_Scroll);
			this.MediaPlayer_TrackBar_AudioTime.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MediaPlayer_TrackBar_AudioTime_MouseDown);
			// 
			// MediaPlayer_LineSeparator
			// 
			this.MediaPlayer_LineSeparator.Location = new System.Drawing.Point(0, 300);
			this.MediaPlayer_LineSeparator.MaximumSize = new System.Drawing.Size(2000, 2);
			this.MediaPlayer_LineSeparator.MinimumSize = new System.Drawing.Size(0, 2);
			this.MediaPlayer_LineSeparator.Name = "MediaPlayer_LineSeparator";
			this.MediaPlayer_LineSeparator.Size = new System.Drawing.Size(312, 2);
			this.MediaPlayer_LineSeparator.TabIndex = 10;
			// 
			// Battlefield
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(310, 476);
			this.Controls.Add(this.MediaPlayer_TrackBar_AudioTime);
			this.Controls.Add(this.MediaPlayer_Label_AudioTime);
			this.Controls.Add(this.MediaPlayer_Label_VolumeValue);
			this.Controls.Add(this.MediaPlayer_Label_AudioName);
			this.Controls.Add(this.MediaPlayer_Label_Volume);
			this.Controls.Add(this.MediaPlayer_TrackBar_Volume);
			this.Controls.Add(this.MediaPlayer_Button_LastMusic);
			this.Controls.Add(this.MediaPlayer_Button_NextMusic);
			this.Controls.Add(this.MediaPlayer_Button_PlayPause);
			this.Controls.Add(this.MediaPlayer_LineSeparator);
			this.Controls.Add(this.btnStart);
			this.Controls.Add(this.btnEsqInf);
			this.Controls.Add(this.btnDirInf);
			this.Controls.Add(this.btnMidInf);
			this.Controls.Add(this.btnMidSup);
			this.Controls.Add(this.btnDirSup);
			this.Controls.Add(this.btnDirMid);
			this.Controls.Add(this.btnEsqMid);
			this.Controls.Add(this.btnMidMid);
			this.Controls.Add(this.btnEsqSup);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Margin = new System.Windows.Forms.Padding(2);
			this.MaximizeBox = false;
			this.Name = "Battlefield";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Jogo da Velha";
			((System.ComponentModel.ISupportInitialize)(this.MediaPlayer_TrackBar_Volume)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.MediaPlayer_TrackBar_AudioTime)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEsqSup;
        private System.Windows.Forms.Button btnMidMid;
        private System.Windows.Forms.Button btnEsqMid;
        private System.Windows.Forms.Button btnDirMid;
        private System.Windows.Forms.Button btnDirSup;
        private System.Windows.Forms.Button btnMidSup;
        private System.Windows.Forms.Button btnMidInf;
        private System.Windows.Forms.Button btnDirInf;
        private System.Windows.Forms.Button btnEsqInf;
        private System.Windows.Forms.Button btnStart;
		private Components.LineSeparator MediaPlayer_LineSeparator;
		private System.Windows.Forms.Button MediaPlayer_Button_PlayPause;
		private System.Windows.Forms.Button MediaPlayer_Button_NextMusic;
		private System.Windows.Forms.Button MediaPlayer_Button_LastMusic;
		private System.Windows.Forms.TrackBar MediaPlayer_TrackBar_Volume;
		private System.Windows.Forms.Label MediaPlayer_Label_Volume;
		private System.Windows.Forms.Label MediaPlayer_Label_AudioName;
		private System.Windows.Forms.Label MediaPlayer_Label_VolumeValue;
		private System.Windows.Forms.Label MediaPlayer_Label_AudioTime;
		private System.Windows.Forms.Timer OnAudioTimeChanged;
		private System.Windows.Forms.TrackBar MediaPlayer_TrackBar_AudioTime;
	}
}

