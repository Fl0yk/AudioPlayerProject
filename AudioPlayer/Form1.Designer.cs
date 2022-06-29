
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
            this.player = new AxWMPLib.AxWindowsMediaPlayer();
            this.trackVolume = new System.Windows.Forms.TrackBar();
            this.labelFinish = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.labelNow = new System.Windows.Forms.Label();
            this.buttonOpen = new System.Windows.Forms.Button();
            this.buttonPrev = new System.Windows.Forms.Button();
            this.buttonNext = new System.Windows.Forms.Button();
            this.buttonPause = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonRepeat = new System.Windows.Forms.Button();
            this.labelIsRepeat = new System.Windows.Forms.Label();
            this.buttonRandom = new System.Windows.Forms.Button();
            this.labelIsRandom = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackVolume)).BeginInit();
            this.SuspendLayout();
            // 
            // progressBar
            // 
            this.progressBar.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.progressBar.Location = new System.Drawing.Point(23, 230);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(744, 26);
            this.progressBar.TabIndex = 5;
            this.progressBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.progressBar_MouseDown);
            // 
            // listAudio
            // 
            this.listAudio.FormattingEnabled = true;
            this.listAudio.Location = new System.Drawing.Point(313, 12);
            this.listAudio.Name = "listAudio";
            this.listAudio.Size = new System.Drawing.Size(388, 212);
            this.listAudio.TabIndex = 6;
            this.listAudio.SelectedIndexChanged += new System.EventHandler(this.listAudio_SelectedIndexChanged);
            // 
            // player
            // 
            this.player.Enabled = true;
            this.player.Location = new System.Drawing.Point(521, 112);
            this.player.Name = "player";
            this.player.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("player.OcxState")));
            this.player.Size = new System.Drawing.Size(118, 30);
            this.player.TabIndex = 7;
            // 
            // trackVolume
            // 
            this.trackVolume.LargeChange = 0;
            this.trackVolume.Location = new System.Drawing.Point(55, 179);
            this.trackVolume.Maximum = 100;
            this.trackVolume.Name = "trackVolume";
            this.trackVolume.Size = new System.Drawing.Size(194, 45);
            this.trackVolume.TabIndex = 8;
            this.trackVolume.Scroll += new System.EventHandler(this.trackVolume_Scroll);
            // 
            // labelFinish
            // 
            this.labelFinish.AutoSize = true;
            this.labelFinish.BackColor = System.Drawing.Color.Transparent;
            this.labelFinish.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelFinish.Location = new System.Drawing.Point(714, 234);
            this.labelFinish.Name = "labelFinish";
            this.labelFinish.Size = new System.Drawing.Size(44, 18);
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
            this.labelNow.BackColor = System.Drawing.Color.Transparent;
            this.labelNow.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelNow.Location = new System.Drawing.Point(30, 234);
            this.labelNow.Name = "labelNow";
            this.labelNow.Size = new System.Drawing.Size(44, 18);
            this.labelNow.TabIndex = 11;
            this.labelNow.Text = "00:00";
            // 
            // buttonOpen
            // 
            this.buttonOpen.BackgroundImage = global::AudioPlayer.Properties.Resources.ебать_палки_и_круги;
            this.buttonOpen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonOpen.Location = new System.Drawing.Point(707, 164);
            this.buttonOpen.Name = "buttonOpen";
            this.buttonOpen.Size = new System.Drawing.Size(60, 60);
            this.buttonOpen.TabIndex = 12;
            this.buttonOpen.UseVisualStyleBackColor = true;
            this.buttonOpen.Click += new System.EventHandler(this.buttonOpen_Click);
            // 
            // buttonPrev
            // 
            this.buttonPrev.BackColor = System.Drawing.Color.Transparent;
            this.buttonPrev.BackgroundImage = global::AudioPlayer.Properties.Resources.две_стрелки_влево;
            this.buttonPrev.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonPrev.Location = new System.Drawing.Point(57, 98);
            this.buttonPrev.Name = "buttonPrev";
            this.buttonPrev.Size = new System.Drawing.Size(60, 60);
            this.buttonPrev.TabIndex = 4;
            this.buttonPrev.UseVisualStyleBackColor = false;
            this.buttonPrev.Click += new System.EventHandler(this.buttonPrev_Click);
            // 
            // buttonNext
            // 
            this.buttonNext.BackColor = System.Drawing.Color.Transparent;
            this.buttonNext.BackgroundImage = global::AudioPlayer.Properties.Resources.хуйня_две_стрелки_вправо;
            this.buttonNext.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonNext.Location = new System.Drawing.Point(189, 98);
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.Size = new System.Drawing.Size(60, 60);
            this.buttonNext.TabIndex = 3;
            this.buttonNext.UseVisualStyleBackColor = false;
            this.buttonNext.Click += new System.EventHandler(this.buttonNext_Click);
            // 
            // buttonPause
            // 
            this.buttonPause.BackColor = System.Drawing.Color.Transparent;
            this.buttonPause.BackgroundImage = global::AudioPlayer.Properties.Resources.палка_стрелка_вправо;
            this.buttonPause.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonPause.Location = new System.Drawing.Point(123, 98);
            this.buttonPause.Name = "buttonPause";
            this.buttonPause.Size = new System.Drawing.Size(60, 60);
            this.buttonPause.TabIndex = 1;
            this.buttonPause.UseVisualStyleBackColor = false;
            this.buttonPause.Click += new System.EventHandler(this.buttonPause_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(357, 262);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "label1";
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(707, 98);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(60, 60);
            this.buttonDelete.TabIndex = 14;
            this.buttonDelete.Text = "Удалить";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonRepeat
            // 
            this.buttonRepeat.Location = new System.Drawing.Point(123, 32);
            this.buttonRepeat.Name = "buttonRepeat";
            this.buttonRepeat.Size = new System.Drawing.Size(60, 60);
            this.buttonRepeat.TabIndex = 15;
            this.buttonRepeat.Text = "Повтор";
            this.buttonRepeat.UseVisualStyleBackColor = true;
            this.buttonRepeat.Click += new System.EventHandler(this.buttonRepeat_Click);
            // 
            // labelIsRepeat
            // 
            this.labelIsRepeat.AutoSize = true;
            this.labelIsRepeat.Location = new System.Drawing.Point(141, 16);
            this.labelIsRepeat.Name = "labelIsRepeat";
            this.labelIsRepeat.Size = new System.Drawing.Size(26, 13);
            this.labelIsRepeat.TabIndex = 16;
            this.labelIsRepeat.Text = "Нет";
            // 
            // buttonRandom
            // 
            this.buttonRandom.Location = new System.Drawing.Point(189, 32);
            this.buttonRandom.Name = "buttonRandom";
            this.buttonRandom.Size = new System.Drawing.Size(60, 60);
            this.buttonRandom.TabIndex = 17;
            this.buttonRandom.Text = "Рандом";
            this.buttonRandom.UseVisualStyleBackColor = true;
            this.buttonRandom.Click += new System.EventHandler(this.buttonRandom_Click);
            // 
            // labelIsRandom
            // 
            this.labelIsRandom.AutoSize = true;
            this.labelIsRandom.Location = new System.Drawing.Point(199, 12);
            this.labelIsRandom.Name = "labelIsRandom";
            this.labelIsRandom.Size = new System.Drawing.Size(26, 13);
            this.labelIsRandom.TabIndex = 18;
            this.labelIsRandom.Text = "Нет";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 284);
            this.Controls.Add(this.labelIsRandom);
            this.Controls.Add(this.buttonRandom);
            this.Controls.Add(this.labelIsRepeat);
            this.Controls.Add(this.buttonRepeat);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonOpen);
            this.Controls.Add(this.labelNow);
            this.Controls.Add(this.labelFinish);
            this.Controls.Add(this.trackVolume);
            this.Controls.Add(this.listAudio);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.buttonPrev);
            this.Controls.Add(this.buttonNext);
            this.Controls.Add(this.buttonPause);
            this.Controls.Add(this.player);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackVolume)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonPause;
        private System.Windows.Forms.Button buttonNext;
        private System.Windows.Forms.Button buttonPrev;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.ListBox listAudio;
        private AxWMPLib.AxWindowsMediaPlayer player;
        private System.Windows.Forms.TrackBar trackVolume;
        private System.Windows.Forms.Label labelFinish;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label labelNow;
        private System.Windows.Forms.Button buttonOpen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonRepeat;
        private System.Windows.Forms.Label labelIsRepeat;
        private System.Windows.Forms.Button buttonRandom;
        private System.Windows.Forms.Label labelIsRandom;
    }
}

