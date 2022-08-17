using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using System.Diagnostics;
using System.ComponentModel;
namespace TimeManagementAssistant
{

    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            

        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            MaximizeBox = false;
            textBox_audio.Visible = false;
        }
        Form NullTextExeptionError;
        private void button1_Click(object sender, EventArgs e)
        {
            bool endsOnWav = textBox_audio.Text.EndsWith(".wav");


            int num;
            bool isNum = int.TryParse(textBox_time.Text, out num);
            if (isNum) { }
            else
            {
                NullTextExeptionError = new NullTextExeptionError();
                NullTextExeptionError.Show();
                return;
            }
            int NumOfMin = Int32.Parse(textBox_time.Text);
            if (textBox_audio.Text == "" || textBox_process.Text == "" || textBox_time.Text == "" || NumOfMin > 2000 || endsOnWav == false)
            {
                NullTextExeptionError.Show();
                return;
            }
            string NameOfProcess = textBox_process.Text;
            var docFolder = Environment.GetFolderPath(
        Environment.SpecialFolder.MyDocuments,
        Environment.SpecialFolderOption.Create);
            string path = Path.Combine(docFolder, "TimeManager.txt");

            FileInfo FileOfProcess = new FileInfo(path);
            if (!FileOfProcess.Exists)
            {
                using (StreamWriter sw = FileOfProcess.CreateText())
                {
                    sw.WriteLine(textBox_process.Text);
                    sw.WriteLine(textBox_time.Text);
                    sw.WriteLine(textBox_audio.Text);

                }
            }
            else
            {
                using (StreamWriter sw = FileOfProcess.CreateText())
                {

                    sw.WriteLine(textBox_process.Text);
                    sw.WriteLine(textBox_time.Text);
                    sw.WriteLine(textBox_audio.Text);
                }

            }
            string ExeFolder = Environment.CurrentDirectory + "\\TimeManagmentAssistantCode.exe";
            Process.Start(ExeFolder);



        }



        private void fAQToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("To start using the application, you need to fill in three lines in the forme.\n \nIn the first line, enter the file name of the process being started without an extension.\n \nIn the second line, enter the integer value >0 and <2000\n\nIn the third line, click on the button and select .wav file  \n\nAfter filling in, press ENTER.\nIf everything was successful, the program will be added to autorun. You can disable it by using the Task Manager");
        }

        private void telegramToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("https://t.me/Kill1237");
        }

        private void vKToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("https://vk.com/dead_inside_ss");
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clipboard.SetText("alexandrkorobeinikov2@gmail.com");

        }
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        
        private void button2_Click(object sender, EventArgs e)
        {
            
            OpenFileDialog openFileDialog1 = new OpenFileDialog() { Filter = "(*.wav)|*.wav" };
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
                textBox_audio.Text = openFileDialog1.FileName;
        }
    }
}
