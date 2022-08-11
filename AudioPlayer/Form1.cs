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
        private StringDictionary file; //формат: ключ - название, значение - полный путь
        public Form1()
        {
            file = new StringDictionary();
            InitializeComponent();
            string[] allfiles = Directory.GetFiles(Directory.GetCurrentDirectory() + "/Music", "*.mp3"); //копируем пути+названия всех песен из файла музыки
                                                                                                         //штука сверху получает путь в Debug
            foreach (string line in allfiles)
            {

                //files.Add(line);
                int index = line.LastIndexOf("\\"); //находим индекс последней черточки из всего пути, чтоб получить название
                string name;
                if (index > 0)
                {
                    name = line.Substring(index + 1); //копируем все, что после индекса
                    file.Add(name, line);
                    listAudio.Items.Add(name);
                }
            }
            is_play = false;
            is_repeat = false;
            is_random = false;
            trackVolume.Value = 50; //изначально громкость на 50 процентов
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void listAudio_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listAudio.SelectedIndex != -1)//Если выюрали песню, а не тыкнули в пустое место
            {
                player.URL = file[listAudio.Items[listAudio.SelectedIndex].ToString()]; //указываем путь файла с песней
                player.Ctlcontrols.play();
                is_play = true;
            }
        }

        private void buttonPause_Click(object sender, EventArgs e)
        {
            if (is_play)
            {
                player.Ctlcontrols.pause();
                label1.Text = "2 " + player.playState.ToString(); //отладчик через лейбел
                is_play = false;
            }
            else
            {
                player.Ctlcontrols.play();
                is_play = true;
            }
        }

        private void buttonNext_Click(object sender, EventArgs e) //перемотка вперед 
        {
            if ((player.playState == WMPLib.WMPPlayState.wmppsPlaying //проверяет состояние на то, что песня играет
                || player.playState == WMPLib.WMPPlayState.wmppsPaused) // проверяет состояние на то, что песня на паузе
                && is_random)
            {
                Random rnd = new Random();
                listAudio.SelectedIndex = rnd.Next(listAudio.Items.Count);//если случайный режим, то рандомим индекс при перемотке вперед
            }
            else if ((player.playState == WMPLib.WMPPlayState.wmppsPlaying
                || player.playState == WMPLib.WMPPlayState.wmppsPaused)
                && listAudio.SelectedIndex == listAudio.Items.Count - 1) //если последняя песня
            {
                listAudio.SelectedIndex = 0;
            }
            else if (listAudio.SelectedIndex < listAudio.Items.Count - 1)
            {
                listAudio.SelectedIndex++;
            }
        }

        private void buttonPrev_Click(object sender, EventArgs e) //перемотка назад
        {

            if ((player.playState == WMPLib.WMPPlayState.wmppsPlaying
                || player.playState == WMPLib.WMPPlayState.wmppsPaused)
                && player.Ctlcontrols.currentPosition > 10) //если песня проиграла меньше 10 секунд, то перематываем в начало
            {
                player.Ctlcontrols.currentPosition = 0; //устанавливаем положение песни на начало
            }
            else if ((player.playState == WMPLib.WMPPlayState.wmppsPlaying
                || player.playState == WMPLib.WMPPlayState.wmppsPaused)
                && is_random)
            {
                Random rnd = new Random();
                listAudio.SelectedIndex = rnd.Next(listAudio.Items.Count);
            }
            else if (listAudio.SelectedIndex > 0)
            {
                listAudio.SelectedIndex--;
            }
        }

        private void timer1_Tick(object sender, EventArgs e) //таймер:)
        {
            if (player.playState == WMPLib.WMPPlayState.wmppsPlaying
                || player.playState == WMPLib.WMPPlayState.wmppsPaused)
            {
                progressBar.Maximum = (int)Math.Round((double)player.Ctlcontrols.currentItem.duration); //устанавливаем максимум в зависимости от времени песни
                progressBar.Value = (int)Math.Round((double)player.Ctlcontrols.currentPosition); //отображаем положение сейчас

                labelFinish.Text = player.Ctlcontrols.currentItem.durationString; //Время всей песни
                labelNow.Text = player.Ctlcontrols.currentPositionString; //Сколько уже прошло

                label1.Text = player.playState.ToString(); //Отладочка
            }
            else if (player.playState == WMPLib.WMPPlayState.wmppsStopped) //Если песня закончилась
            {
                if (is_repeat)
                {
                    player.Ctlcontrols.play(); //Если на повторе, то запскаем заново
                }
                else if (is_random)
                {
                    Random rnd = new Random();
                    listAudio.SelectedIndex = rnd.Next(listAudio.Items.Count);
                }
                else if (listAudio.SelectedIndex < listAudio.Items.Count - 1)
                    listAudio.SelectedIndex++;
                else
                {
                    if (listAudio.SelectedIndex != -1)
                        listAudio.SelectedIndex = 0;
                    else //если песня закончилась и выбрано пустое место, то все обнуляем
                    {
                        player.URL = ""; //мб костыль, не нашел метода, который бы обнулил путь к файлу
                        progressBar.Value = 0;
                        labelFinish.Text = "00:00";
                        labelNow.Text = "00:00";
                    }
                }
            }
        }

        private void trackVolume_Scroll(object sender, EventArgs e) //Регулятор громкости
        {
            player.settings.volume = trackVolume.Value;
        }

        private void progressBar_MouseDown(object sender, MouseEventArgs e) //промотка песни
        {
            if (player.playState == WMPLib.WMPPlayState.wmppsPlaying
                || player.playState == WMPLib.WMPPlayState.wmppsPaused)
            {
                player.Ctlcontrols.currentPosition = player.Ctlcontrols.currentItem.duration * e.X / progressBar.Width;
                //Перематываем песню на позицию, котрая считается: время всей песни(player.currentMedia.duration) * координата нажатия по x
                // / длинна всего счетчика
            }
        }

        private void buttonOpen_Click(object sender, EventArgs e) //добавление песен
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "Media file (*.mp3)|*.mp3"; //устанавливаем фильтр, чтоб можно было открывать только .mp3 файлы
            openFile.Multiselect = true; //Включаем возможность выбрать несколько файлов сразу
            if (openFile.ShowDialog() == System.Windows.Forms.DialogResult.OK) //проверяем, что резульаты всех файлов нормальное
            {
                string[] addFiles = openFile.FileNames; //массив путей выбранных файлов
                foreach (string line in addFiles)
                {
                    int index = line.LastIndexOf("\\");
                    string name;
                    if (index > 0)
                    {
                        name = line.Substring(index + 1);
                        try
                        {
                            file.Add(name, Directory.GetCurrentDirectory() + "/Music/" + name); //Если такая песня уже есть, то будет исключение,
                            //из-за чего дальше не пойдет и выйдет из try
                            listAudio.Items.Add(name);
                            File.Copy(line, Directory.GetCurrentDirectory() + "/Music/" + name); //КОПИРУЕМ файл в основную папку с песнями
                        }
                        catch { }
                    }
                }
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e) //Удаление песни
        {
            if (listAudio.SelectedIndex != -1)
            {
                File.Delete(file[listAudio.Items[listAudio.SelectedIndex].ToString()]); //Удаляем файл из основной папки(исходник живой, есл его не удаляли)
                file.Remove(listAudio.Items[listAudio.SelectedIndex].ToString()); //Удаляем по названию из контейнера

                if (listAudio.SelectedIndex == listAudio.Items.Count - 1)
                {
                    if (listAudio.Items.Count == 1) //Если удаляем последнюю песню
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
                    int tmp = listAudio.SelectedIndex; //Запоминаем индекс(т.к. при удалении он его автоматом меняет на -1)
                    listAudio.Items.RemoveAt(listAudio.SelectedIndex); //Удаляем из списка песен
                    listAudio.SelectedIndex = tmp; //Переходим на следующую песню после удаляемой
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
            else if (!is_repeat)
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
            else if (!is_random)
            {
                is_repeat = true;
                labelIsRepeat.Text = "Да";
            }
        }
    }
}