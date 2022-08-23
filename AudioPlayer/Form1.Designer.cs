﻿
namespace AudioPlayer
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.listAudio = new System.Windows.Forms.ListBox();
            this.trackVolume = new System.Windows.Forms.TrackBar();
            this.labelFinish = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.labelNow = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.player = new AxWMPLib.AxWindowsMediaPlayer();
            this.AudioName = new System.Windows.Forms.Label();
            this.trash = new System.Windows.Forms.PictureBox();
            this.up = new System.Windows.Forms.PictureBox();
            this.right = new System.Windows.Forms.PictureBox();
            this.playPause = new System.Windows.Forms.PictureBox();
            this.left = new System.Windows.Forms.PictureBox();
            this.random = new System.Windows.Forms.PictureBox();
            this.replay = new System.Windows.Forms.PictureBox();
            this.collapse = new System.Windows.Forms.PictureBox();
            this.close = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.trackVolume)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trash)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.up)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.right)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playPause)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.left)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.random)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.replay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.collapse)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.close)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // progressBar
            // 
            this.progressBar.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.progressBar.ForeColor = System.Drawing.Color.DarkCyan;
            this.progressBar.Location = new System.Drawing.Point(5, 298);
            this.progressBar.Margin = new System.Windows.Forms.Padding(4);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(617, 10);
            this.progressBar.TabIndex = 5;
            this.progressBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.progressBar_MouseDown);
            // 
            // listAudio
            // 
            this.listAudio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.listAudio.Font = new System.Drawing.Font("Lucida Console", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listAudio.ForeColor = System.Drawing.Color.SaddleBrown;
            this.listAudio.FormattingEnabled = true;
            this.listAudio.ItemHeight = 17;
            this.listAudio.Location = new System.Drawing.Point(103, 51);
            this.listAudio.Margin = new System.Windows.Forms.Padding(4);
            this.listAudio.Name = "listAudio";
            this.listAudio.Size = new System.Drawing.Size(414, 174);
            this.listAudio.TabIndex = 6;
            this.listAudio.SelectedIndexChanged += new System.EventHandler(this.listAudio_SelectedIndexChanged);
            // 
            // trackVolume
            // 
            this.trackVolume.AutoSize = false;
            this.trackVolume.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.trackVolume.LargeChange = 0;
            this.trackVolume.Location = new System.Drawing.Point(409, 325);
            this.trackVolume.Margin = new System.Windows.Forms.Padding(4);
            this.trackVolume.Maximum = 100;
            this.trackVolume.Name = "trackVolume";
            this.trackVolume.Size = new System.Drawing.Size(133, 38);
            this.trackVolume.TabIndex = 8;
            this.trackVolume.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackVolume.Scroll += new System.EventHandler(this.trackVolume_Scroll);
            // 
            // labelFinish
            // 
            this.labelFinish.AutoSize = true;
            this.labelFinish.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.labelFinish.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelFinish.Location = new System.Drawing.Point(562, 316);
            this.labelFinish.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelFinish.Name = "labelFinish";
            this.labelFinish.Size = new System.Drawing.Size(55, 24);
            this.labelFinish.TabIndex = 10;
            this.labelFinish.Text = "00:00";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // labelNow
            // 
            this.labelNow.AutoSize = true;
            this.labelNow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.labelNow.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelNow.Location = new System.Drawing.Point(13, 313);
            this.labelNow.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelNow.Name = "labelNow";
            this.labelNow.Size = new System.Drawing.Size(55, 24);
            this.labelNow.TabIndex = 11;
            this.labelNow.Text = "00:00";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.label1.Font = new System.Drawing.Font("Lucida Console", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label1.Location = new System.Drawing.Point(161, 246);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 14);
            this.label1.TabIndex = 13;
            // 
            // player
            // 
            this.player.Enabled = true;
            this.player.Location = new System.Drawing.Point(243, 147);
            this.player.Margin = new System.Windows.Forms.Padding(4);
            this.player.Name = "player";
            this.player.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("player.OcxState")));
            this.player.Size = new System.Drawing.Size(10, 10);
            this.player.TabIndex = 7;
            // 
            // AudioName
            // 
            this.AudioName.AutoSize = true;
            this.AudioName.Font = new System.Drawing.Font("Monotype Corsiva", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AudioName.ForeColor = System.Drawing.Color.SaddleBrown;
            this.AudioName.Location = new System.Drawing.Point(5, 11);
            this.AudioName.Name = "AudioName";
            this.AudioName.Size = new System.Drawing.Size(87, 20);
            this.AudioName.TabIndex = 23;
            this.AudioName.Text = "APDplayer";
            this.AudioName.DoubleClick += new System.EventHandler(this.AudioName_DoubleClick);
            // 
            // trash
            // 
            this.trash.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.trash.Image = global::AudioPlayer.Properties.Resources.TRASH1;
            this.trash.Location = new System.Drawing.Point(351, 316);
            this.trash.Name = "trash";
            this.trash.Size = new System.Drawing.Size(40, 41);
            this.trash.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.trash.TabIndex = 22;
            this.trash.TabStop = false;
            this.trash.Click += new System.EventHandler(this.trash_Click);
            this.trash.MouseEnter += new System.EventHandler(this.trash_MouseEnter);
            this.trash.MouseLeave += new System.EventHandler(this.trash_MouseLeave);
            // 
            // up
            // 
            this.up.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.up.Image = global::AudioPlayer.Properties.Resources.UP;
            this.up.Location = new System.Drawing.Point(305, 316);
            this.up.Name = "up";
            this.up.Size = new System.Drawing.Size(40, 41);
            this.up.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.up.TabIndex = 21;
            this.up.TabStop = false;
            this.up.Click += new System.EventHandler(this.up_Click);
            this.up.MouseEnter += new System.EventHandler(this.up_MouseEnter);
            this.up.MouseLeave += new System.EventHandler(this.up_MouseLeave);
            // 
            // right
            // 
            this.right.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.right.Image = global::AudioPlayer.Properties.Resources.RIGHT;
            this.right.Location = new System.Drawing.Point(259, 316);
            this.right.Name = "right";
            this.right.Size = new System.Drawing.Size(40, 41);
            this.right.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.right.TabIndex = 21;
            this.right.TabStop = false;
            this.right.Click += new System.EventHandler(this.right_Click);
            // 
            // playPause
            // 
            this.playPause.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.playPause.Image = global::AudioPlayer.Properties.Resources.PLAY;
            this.playPause.Location = new System.Drawing.Point(213, 316);
            this.playPause.Name = "playPause";
            this.playPause.Size = new System.Drawing.Size(40, 41);
            this.playPause.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.playPause.TabIndex = 21;
            this.playPause.TabStop = false;
            this.playPause.Click += new System.EventHandler(this.playPause_Click);
            // 
            // left
            // 
            this.left.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.left.Image = global::AudioPlayer.Properties.Resources.LEFT;
            this.left.Location = new System.Drawing.Point(167, 316);
            this.left.Name = "left";
            this.left.Size = new System.Drawing.Size(40, 41);
            this.left.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.left.TabIndex = 21;
            this.left.TabStop = false;
            this.left.Click += new System.EventHandler(this.left_Click);
            // 
            // random
            // 
            this.random.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.random.Image = global::AudioPlayer.Properties.Resources.RANDOM;
            this.random.Location = new System.Drawing.Point(121, 316);
            this.random.Name = "random";
            this.random.Size = new System.Drawing.Size(40, 41);
            this.random.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.random.TabIndex = 21;
            this.random.TabStop = false;
            this.random.Click += new System.EventHandler(this.random_Click);
            // 
            // replay
            // 
            this.replay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.replay.Image = global::AudioPlayer.Properties.Resources.REPLAY;
            this.replay.Location = new System.Drawing.Point(75, 316);
            this.replay.Name = "replay";
            this.replay.Size = new System.Drawing.Size(40, 41);
            this.replay.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.replay.TabIndex = 21;
            this.replay.TabStop = false;
            this.replay.Click += new System.EventHandler(this.replay_Click);
            // 
            // collapse
            // 
            this.collapse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.collapse.Image = global::AudioPlayer.Properties.Resources.COLLAPSE;
            this.collapse.Location = new System.Drawing.Point(555, 12);
            this.collapse.Name = "collapse";
            this.collapse.Size = new System.Drawing.Size(26, 25);
            this.collapse.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.collapse.TabIndex = 20;
            this.collapse.TabStop = false;
            this.collapse.Click += new System.EventHandler(this.collapse_Click);
            this.collapse.MouseEnter += new System.EventHandler(this.collapse_MouseEnter);
            this.collapse.MouseLeave += new System.EventHandler(this.collapse_MouseLeave);
            // 
            // close
            // 
            this.close.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.close.Image = global::AudioPlayer.Properties.Resources.CLOSE;
            this.close.Location = new System.Drawing.Point(587, 12);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(31, 25);
            this.close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.close.TabIndex = 19;
            this.close.TabStop = false;
            this.close.Click += new System.EventHandler(this.close_Click);
            this.close.MouseEnter += new System.EventHandler(this.close_MouseEnter);
            this.close.MouseLeave += new System.EventHandler(this.close_MouseLeave);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(243, 252);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(218, 24);
            this.panel1.TabIndex = 24;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Lucida Console", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label2.Location = new System.Drawing.Point(3, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 19);
            this.label2.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Lucida Console", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label3.Location = new System.Drawing.Point(168, 256);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 23);
            this.label3.TabIndex = 25;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(630, 376);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.AudioName);
            this.Controls.Add(this.trash);
            this.Controls.Add(this.up);
            this.Controls.Add(this.right);
            this.Controls.Add(this.playPause);
            this.Controls.Add(this.left);
            this.Controls.Add(this.random);
            this.Controls.Add(this.replay);
            this.Controls.Add(this.collapse);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelNow);
            this.Controls.Add(this.labelFinish);
            this.Controls.Add(this.listAudio);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.player);
            this.Controls.Add(this.close);
            this.Controls.Add(this.trackVolume);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.trackVolume)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trash)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.up)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.right)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playPause)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.left)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.random)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.replay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.collapse)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.close)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.ListBox listAudio;
        private AxWMPLib.AxWindowsMediaPlayer player;
        private System.Windows.Forms.TrackBar trackVolume;
        private System.Windows.Forms.Label labelFinish;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label labelNow;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox close;
        private System.Windows.Forms.PictureBox collapse;
        private System.Windows.Forms.PictureBox replay;
        private System.Windows.Forms.PictureBox left;
        private System.Windows.Forms.PictureBox playPause;
        private System.Windows.Forms.PictureBox right;
        private System.Windows.Forms.PictureBox up;
        private System.Windows.Forms.PictureBox random;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.PictureBox trash;
        private System.Windows.Forms.Label AudioName;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

