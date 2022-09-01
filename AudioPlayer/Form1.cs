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
using System.Drawing.Drawing2D;

namespace AudioPlayer
{
    public partial class Form1 : Form
    {
        private bool is_play, is_repeat, is_random;

        string to_image = Directory.GetCurrentDirectory();

        private StringDictionary file; //формат: ключ - название, значение - полный путь
        public Form1()
        {
            InitializeComponent();
  

            file = new StringDictionary();
            
            to_image = to_image.Remove(to_image.LastIndexOf("\\"));
            to_image = to_image.Remove(to_image.LastIndexOf("\\"));
           
            to_image += "/image/";

            string[] allfiles = Directory.GetFiles(Directory.GetCurrentDirectory() + "/Music", "*.mp3"); //копируем пути + названия всех песен из файла музыки
                                                //штука сверху получает путь в Debug
            foreach (string line in allfiles)
            {
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
        private void listAudio_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listAudio.SelectedIndex != -1)//Если выюрали песню, а не тыкнули в пустое место
            {
                label3.Text = "Играет: ";
                player.URL = file[listAudio.Items[listAudio.SelectedIndex].ToString()]; //указываем путь файла с песней
                player.Ctlcontrols.play();
                is_play = true;
                playPause.Image = Image.FromFile(to_image + "PAUSE.png");
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

        private void close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void collapse_Click(object sender, EventArgs e) //сворачивает окно
        {
            this.WindowState = FormWindowState.Minimized;
        }

        Point lastPoint; 
        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left) //нажатие ЛКМ в зоне приложения
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;

            }
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }
      
        Graphics g;
       
        Pen myPen = new Pen(Color.Black);
        SolidBrush solidBrush = new SolidBrush(Color.FromArgb(255, 255, 224, 192));
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.SmoothingMode =
            System.Drawing.Drawing2D.SmoothingMode.AntiAlias; //сглаживание

            myPen.Color = Color.FromArgb(255, 180, 162, 132);
            myPen.Width = 7;
            g = CreateGraphics();
            g.DrawRectangle(myPen, 0, 0, 470, 304);
            myPen.Width = 4;
            g.DrawLine(myPen, 0, 240, 470, 240);


            PointF point1 = new PointF(470, 2);
            PointF point2 = new PointF(370, 2);
            PointF point3 = new PointF(470, 102);
        
            PointF[] curvePoints1 = //правый треугольник
            {
                point1,
                point2,
                point3,
            };

            e.Graphics.FillPolygon(solidBrush, curvePoints1); //закрашиваем
            e.Graphics.DrawPolygon(myPen, curvePoints1); //обводим


            PointF point4 = new PointF(2, 2);
            PointF point5 = new PointF(2, 102);
            PointF point6 = new PointF(102, 2);

            PointF[] curvePoints2 = //левый треугольник
            {
                point4,
                point5,
                point6,
            };

            e.Graphics.FillPolygon(solidBrush, curvePoints2);
            e.Graphics.DrawPolygon(myPen, curvePoints2);

            PointF point7 = new PointF(2, 102);
            PointF point8 = new PointF(102, 2);
            PointF point9 = new PointF(370, 2);
            PointF point10 = new PointF(470, 102);
            PointF point11 = new PointF(470, 240);
            PointF point12 = new PointF(2, 240);


            PointF[] curvePoints3 = //шестиугольник(для заднего фона)
            {
                point7,
                point8,
                point9,
                point10,
                point11,
                point12,

            };
            Image myImage = Image.FromFile(to_image + "FON1.jpg");
            TextureBrush myTextureBrush = new TextureBrush(myImage); //инициализация заливки картинкой
            e.Graphics.FillPolygon(myTextureBrush, curvePoints3);  //заливка шестиугольника картинкой фона
            e.Graphics.DrawPolygon(myPen, curvePoints3);

            myPen.Width = 4;

            g.DrawArc(myPen, new Rectangle(110, 200, 30, 30), -270, 180); //полуокружности
            g.DrawArc(myPen, new Rectangle(330, 200, 30, 30), -90, 180);

            g.DrawLine(myPen, 125, 201, 346, 201);  //линии, соединяющие окружности
            g.DrawLine(myPen, 125, 230, 346, 230);

            e.Graphics.FillPie(solidBrush, new Rectangle(110, 200, 30, 30), -270, 180); //заливка полуокружностей
            e.Graphics.FillPie(solidBrush, new Rectangle(330, 200, 30, 30), -90, 180);
            e.Graphics.FillRectangle(solidBrush, new Rectangle(124, 201, 222, 29)); //заливка прямоугольника

        }


        private void timer1_Tick(object sender, EventArgs e) //таймер:)
        {

            if (label2.Left > -label2.Width)
            {
                label2.Left -= 5;
            }
            else
            {
                label2.Left = panel1.Width;
            }

            if (player.playState == WMPLib.WMPPlayState.wmppsPlaying
                || player.playState == WMPLib.WMPPlayState.wmppsPaused)
            {
                label2.Text = listAudio.SelectedItem.ToString();

                progressBar.Maximum = (int)Math.Round((double)player.Ctlcontrols.currentItem.duration); //устанавливаем максимум в зависимости от времени песни
                progressBar.Value = (int)Math.Round((double)player.Ctlcontrols.currentPosition); //отображаем положение сейчас

                labelFinish.Text = player.Ctlcontrols.currentItem.durationString; //Время всей песни
                labelNow.Text = player.Ctlcontrols.currentPositionString; //Сколько уже прошло
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
                else if (listAudio.SelectedIndex < listAudio.Items.Count - 1) //если играла не последняя песня, и не выбран никакой режим
                    listAudio.SelectedIndex++;
                else
                {
                    if (listAudio.SelectedIndex != -1)
                        listAudio.SelectedIndex = 0;
                    else //если песня закончилась и выбрано пустое место, то все обнуляем
                    {
                        label2.Text = "";
                        label3.Text = "А где? :(";
                        player.URL = null;
                        progressBar.Value = 0;
                        labelFinish.Text = "00:00";
                        labelNow.Text = "00:00";
                    }
                }
            }
        }
        private void collapse_MouseEnter(object sender, EventArgs e) //наведение курсором
        {
            collapse.Image = Image.FromFile(to_image + "COLLAPSE1.png"); 
        }

        private void collapse_MouseLeave(object sender, EventArgs e) //курсор не наводится
        {
            collapse.Image = Image.FromFile(to_image + "COLLAPSE.png"); 
        }

        private void close_MouseEnter(object sender, EventArgs e)
        {
            close.Image = Image.FromFile(to_image + "CLOSE1.png");

        }

        private void close_MouseLeave(object sender, EventArgs e)
        {
            close.Image = Image.FromFile(to_image + "CLOSE.png");

        }

        private void right_Click(object sender, EventArgs e)
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

        private void left_Click(object sender, EventArgs e)
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


        private void playPause_Click(object sender, EventArgs e)
        {
            if (is_play)
            {
                if (player.URL != null)
                {

                    label3.Text = "Пауза: ";

                    label2.Text = play_now(player.URL);
                }

                player.Ctlcontrols.pause();
                is_play = false;
                playPause.Image = Image.FromFile(to_image + "PLAY.png");


            }
            else
            {
                if (player.URL != null)
                {

                    label3.Text = "Играет: ";

                    label2.Text = play_now(player.URL);
                }
                player.Ctlcontrols.play();
                is_play = true;
                playPause.Image = Image.FromFile(to_image + "PAUSE.png");

            }

        }

        private void up_Click(object sender, EventArgs e)
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

        private void trash_Click(object sender, EventArgs e)
        {
            if (listAudio.SelectedIndex != -1)
            {
                File.Delete(file[listAudio.Items[listAudio.SelectedIndex].ToString()]); //Удаляем файл из основной папки(исходник живой, если его не удаляли)
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
        private void trash_MouseEnter(object sender, EventArgs e)
        {
            trash.Image = Image.FromFile(to_image + "TRASH1.png");
        }

        private void trash_MouseLeave(object sender, EventArgs e)
        {
            trash.Image = Image.FromFile(to_image + "TRASH.png");

        }

        private void up_MouseEnter(object sender, EventArgs e)
        {
            up.Image = Image.FromFile(to_image + "UP1.png");
        }

        private void up_MouseLeave(object sender, EventArgs e)
        {
            up.Image = Image.FromFile(to_image + "UP.png");

        }


        private void random_Click(object sender, EventArgs e)
        {
            if (is_random)
            {
                is_random = false;
                random.Image = Image.FromFile(to_image + "RANDOM.png"); 
            }

            else if (!is_repeat)
            {
                is_random = true;
                random.Image = Image.FromFile(to_image + "RANDOM1.png");
            }
        }

        private void AudioName_DoubleClick(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.youtube.com/watch?v=dQw4w9WgXcQ");
        }

        private void replay_Click(object sender, EventArgs e)
        {
            if (is_repeat)
            {
                replay.Image = Image.FromFile(to_image + "REPLAY.png");

                is_repeat = false;
            }
            else if (!is_random)
            {
                replay.Image = Image.FromFile(to_image + "REPLAY1.png");
                is_repeat = true;
            }
        }

        private string play_now(string URL)
        {
            int index = URL.LastIndexOf("\\"); //находим индекс последней черточки из всего пути, чтоб получить название
            string name;
            if (index > 0)
            {
                name = URL.Substring(index + 1);
            }
            else
            {
                name = "";
            }
            return name;
        }
    }
}