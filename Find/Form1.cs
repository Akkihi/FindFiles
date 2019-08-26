using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Find
{
    public partial class Form1 : Form
    {
        public static string pathfolders = "";

        public static string filenames;

        public static string wordfiles;

        public static string wordtitle;

        public static int countfiles;

        public static int lastcountfiles;

        public static List<string> ListV = new List<string>();

        Queue<string> qe = new Queue<string>();

        public static string pauseresume;

        TimeSpan time1;

        DateTime initial_time = DateTime.Now;

        public Form1()
        {
            InitializeComponent();
            pauseresume = "pause";
            wordfiles = "";
            Timer.Stop();
        }


        void TrueFalse()
        {
            if (Path_Text.Text == null && pauseresume == "pause")
            {
                Filename_Btn.Enabled = false;
                StopSearch_Btn.Enabled = false;
                ResumeSearch_Btn.Enabled = false;
            }
            else
            {
                Filename_Btn.Enabled = true;
                StopSearch_Btn.Enabled = true;
                ResumeSearch_Btn.Enabled = true;
            }
            if (pathfolders == null && pauseresume == "pause")
            {
                Filename_Btn.Enabled = false;
                StopSearch_Btn.Enabled = false;
                ResumeSearch_Btn.Enabled = false;
            }
            else
            {
                Filename_Btn.Enabled = true;
                StopSearch_Btn.Enabled = true;
                ResumeSearch_Btn.Enabled = true;
            }

            if (pauseresume == "resume")
            {
                Filename_Btn.Enabled = false;
            }
            else
            {
                Filename_Btn.Enabled = true;

            }

            if (pauseresume == "pause")
            {
                StopSearch_Btn.Enabled = false;
            }
            else
            {
                StopSearch_Btn.Enabled = true;

            }
            if (pauseresume == "pause")
            {
                ResumeSearch_Btn.Enabled = true;
            }
            else
            {
                ResumeSearch_Btn.Enabled = false;

            }

        }


        private void Path_Btn_Click(object sender, EventArgs e)
        {
            TrueFalse();
            pathfolders = Path_Text.Text;
            Path_Text.Text = FBD.SelectedPath;
            if (FBD.ShowDialog() == DialogResult.OK)
            {
                Path_Text.Text = FBD.SelectedPath;
                pathfolders = Path_Text.Text;

            }


        }

        public void Filename_Btn_Click(object sender, EventArgs e)
        {

            wordfiles = WordinFile_Text.Text;
            lastcountfiles = 0;
            qe.Clear();
            ListView.Items.Clear();
            filenames = Filename_Text.Text;
            if (filenames == "")
            {
                filenames = "*";
            }
            Searching();
            pauseresume = "resume";
            TrueFalse();
            Timer.Stop();
            Timer.Dispose();
            PrivateTimer();
        }

        private void StopSearch_Btn_Click(object sender, EventArgs e)
        {
            Timer.Enabled = false;
            Timer.Stop();
            pauseresume = "pause";
            lastcountfiles = countfiles;
            PrivateTimer();
            TrueFalse();

        }

        private void ResumeSearch_Btn_Click(object sender, EventArgs e)
        {

            filenames = Filename_Text.Text;
            if (filenames == "")
            {
                filenames = "*";
            }
            pauseresume = "resume";
            PrivateTimer();
            TrueFalse();
            Searching();
        }

        public async void Searching()
        {
            await Task.Run(() =>
            {

                DirectoryInfo Dir = new DirectoryInfo(pathfolders);

                var files = Dir.GetFiles(filenames, SearchOption.AllDirectories);


                if (pauseresume == "resume")
                {

                    for (countfiles = lastcountfiles; countfiles < files.Length; countfiles++)
                    {
 
                        if (wordfiles != "")
                        {
                            var stream = new StreamReader(files[countfiles].FullName);
                            while (!stream.EndOfStream)
                            {
                                var line = stream.ReadLine();
                                foreach (Match a in Regex.Matches(line, wordfiles, RegexOptions.IgnoreCase))
                                {
                                    wordtitle = files[countfiles].FullName;

                                }

                            }
                            stream.Dispose();

                            if (!ListV.Contains(wordtitle))
                            {
                                ListV.Add(wordtitle);
                                qe.Enqueue(wordtitle);
                            }
                        }
                        else
                        {
                            ListV.Add(files[countfiles].FullName);
                            qe.Enqueue(files[countfiles].Name);
                        }

                        AddList();
                        Action action = () =>
                        {
                            if (files.Length == ListView.Items.Count)
                            {
                                pauseresume = "pause";
                                TrueFalse();
                                Timer.Stop();
                                StopSearch_Btn.Enabled = false;
                                ResumeSearch_Btn.Enabled = false;
                                Timer_Label.Text = "Структура загружена за: " + time1.Minutes.ToString() + " минут : " + time1.Seconds.ToString() + " секунд : " + time1.Milliseconds.ToString() + " миллисекунд.";
                            }
                        };
                        if (InvokeRequired)
                            Invoke(action);
                        else
                            action();

                    }
                }

            });
        }

        public void AddList()
        {
            if (pauseresume == "resume")
            {
                Action action = () =>
                {
                    if (qe.Count > 0)
                    {
                        Filename_Label.Text = "Кол-во файлов просчитано: " + ListView.Items.Count + "\n" + "Последний обработанный файл:" + ListView.Items.Add(qe.Dequeue());
                        Timer_Label.Text = "Загрузка структуры: " + time1.Minutes.ToString() + " минут : " + time1.Seconds.ToString() + " секунд : " + time1.Milliseconds.ToString() + " миллисекунд.";
                        Timer_Label.Refresh();
                        PrivateTimer();
                    }
                };
                if (InvokeRequired)
                    Invoke(action);
                else
                    action();
                Timer.Start();
            }

        }

        private void ListView_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Filename_Label_Update(object sender, EventArgs e)
        {

        }

        private void Filename_Label_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        void PrivateTimer()
        {
                DateTime current_time = DateTime.Now;
                time1 = current_time - initial_time;
                Timer.Enabled = true;            
        }
        private void PrivateTimer(object sender, EventArgs e)
        {

            
        }



        private void Path_Text_TextChanged(object sender, EventArgs e)
        {

        }

        private void ListView_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void ListView_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (ListView.SelectedIndices.Count == 1)
            {
                Process.Start(ListV[ListView.SelectedIndices[0]]);

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
