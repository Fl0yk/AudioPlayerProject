using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections.Specialized;

namespace AudioPlayer
{
    public partial class Form1 : Form
    {
        private bool is_play, is_repeat, is_random;
        //private List<string> files;
        private StringDictionary file; //формат: ключ - название, значение - полный путь
        public Form1()
        {
            file = new StringDictionary();
            //files = new List<string>();
            InitializeComponent();
            string[] allfiles = Directory.GetFiles(Directory.GetCurrentDirectory() + "/Music", "*.mp3");
            foreach (string line in allfiles)
            {
                
                //files.Add(line);
                int index = line.LastIndexOf("\\");
                string name;
                if (index > 0)
                {
                    name = line.Substring(index + 1);
                    file.Add(name, line);
                    listAudio.Items.Add(name);
                }
            }
            is_play = false;
            is_repeat = false;
            is_random = false;
            trackVolume.Value = 50;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void listAudio_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listAudio.SelectedIndex != -1)
            {
                string aaa = file[listAudio.Items[listAudio.SelectedIndex].ToString()];
                player.URL = file[listAudio.Items[listAudio.SelectedIndex].ToString()];
                player.Ctlcontrols.play();
                is_play = true;
            }
        }

        private void buttonPause_Click(object sender, EventArgs e)
        {
            if (is_play)
            {
                player.Ctlcontrols.pause();
                label1.Text = "2 " + player.playState.ToString();
                is_play = false;
            }
            else
            {
                player.Ctlcontrols.play();
                is_play = true;
            }
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            if ((player.playState == WMPLib.WMPPlayState.wmppsPlaying || player.playState == WMPLib.WMPPlayState.wmppsPaused) && listAudio.SelectedIndex == listAudio.Items.Count - 1)
            {
                player.Ctlcontrols.currentPosition = player.Ctlcontrols.currentItem.duration;
            }
            else if (listAudio.SelectedIndex < listAudio.Items.Count - 1)
            {
                listAudio.SelectedIndex++;
            }
        }

        private void buttonPrev_Click(object sender, EventArgs e)
        {
            if ((player.playState == WMPLib.WMPPlayState.wmppsPlaying || player.playState == WMPLib.WMPPlayState.wmppsPaused) && player.Ctlcontrols.currentPosition > 10)
                player.Ctlcontrols.currentPosition = 0;
            else if (listAudio.SelectedIndex > 0)
            {
                listAudio.SelectedIndex--;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (player.playState == WMPLib.WMPPlayState.wmppsPlaying || player.playState == WMPLib.WMPPlayState.wmppsPaused)
            {
                progressBar.Maximum = (int)Math.Round((double)player.Ctlcontrols.currentItem.duration);
                progressBar.Value = (int)Math.Round((double)player.Ctlcontrols.currentPosition);

                labelFinish.Text = player.Ctlcontrols.currentItem.durationString;
                labelNow.Text = player.Ctlcontrols.currentPositionString;

                label1.Text = player.playState.ToString();
            }
            else if (player.playState == WMPLib.WMPPlayState.wmppsStopped)
            {
                if(is_repeat)
                {
                    player.Ctlcontrols.play();
                }
                else if(is_random)
                {
                    Random rnd = new Random();
                    listAudio.SelectedIndex = rnd.Next(listAudio.Items.Count);
                }
                else if (listAudio.SelectedIndex < listAudio.Items.Count - 1)
                    listAudio.SelectedIndex++;
                else
                {
                    if(listAudio.SelectedIndex != -1)
                        listAudio.SelectedIndex = 0;
                    else
                    {
                        progressBar.Value = 0;
                        labelFinish.Text = "00:00";
                        labelNow.Text = "00:00";
                    }
                }
            }
        }

        private void trackVolume_Scroll(object sender, EventArgs e)
        {
            player.settings.volume = trackVolume.Value;
        }

        private void progressBar_MouseDown(object sender, MouseEventArgs e)
        {
            if (player.playState == WMPLib.WMPPlayState.wmppsPlaying || player.playState == WMPLib.WMPPlayState.wmppsPaused)
                player.Ctlcontrols.currentPosition = player.currentMedia.duration * e.X / progressBar.Width;
        }

        private void buttonOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "Media file (*.mp3)|*.mp3";
            openFile.Multiselect = true;
            if (openFile.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string[] addFiles = openFile.FileNames;
                foreach (string line in addFiles)
                {
                    int index = line.LastIndexOf("\\");
                    string name;
                    if (index > 0)
                    {
                        name = line.Substring(index + 1);
                        try
                        {
                            file.Add(name, Directory.GetCurrentDirectory() + "/Music/" + name);
                            listAudio.Items.Add(name);
                            File.Copy(line, Directory.GetCurrentDirectory() + "/Music/" + name);
                        }
                        catch { }
                        //listAudio.Items.Add(name);
                        //try
                        //{
                        //    File.Copy(line, "E:/AidioPlayerProject/AudioPlayer/Music/" + name);
                        //    //files.Add("E:/AidioPlayerProject/AudioPlayer/Music/" + name);
                        //}
                        //catch { }
                    }
                }
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (listAudio.SelectedIndex != -1)
            {
                File.Delete(file[listAudio.Items[listAudio.SelectedIndex].ToString()]);
                //files.Remove(files[listAudio.SelectedIndex]);
                file.Remove(listAudio.Items[listAudio.SelectedIndex].ToString());
                if(listAudio.SelectedIndex == listAudio.Items.Count - 1)
                {
                    if(listAudio.Items.Count == 1)
                    {
                        listAudio.SelectedIndex = -1;
                        listAudio.Items.RemoveAt(0);
                        player.Ctlcontrols.stop();
                    }
                    else
                    {
                        listAudio.Items.RemoveAt(listAudio.SelectedIndex);
                        listAudio.SelectedIndex = 0;
                    }
                }
                else
                {
                    int tmp = listAudio.SelectedIndex;
                    listAudio.Items.RemoveAt(listAudio.SelectedIndex);
                    listAudio.SelectedIndex = tmp;
                }
            }

        }

        private void buttonRandom_Click(object sender, EventArgs e)
        {
            if (is_random)
            {
                is_random = false;
                labelIsRandom.Text = "Нет";
            }
            else if(!is_repeat)
            {
                is_random = true;
                labelIsRandom.Text = "Да";
            }
        }

        private void buttonRepeat_Click(object sender, EventArgs e)
        {
            if (is_repeat)
            {
                is_repeat = false;
                labelIsRepeat.Text = "Нет";
            }
            else if(!is_random)
            {
                is_repeat = true;
                labelIsRepeat.Text = "Да";
            }
        }
    }
}
//рандомить песню каждый раз по окончанию при включенном режиме +
//кнопки удаления, повтора песни +
//посмотреть hashset для названий и через него проверять на наличие -
//dictionarysring<навание, путь>??? +)