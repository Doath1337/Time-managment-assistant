﻿using System;
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

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string NameOfProcess = textBox_process.Text;
        
            string path = @"C:\Users\Dead Ghoul\AppData\Local\Temp\TimeManagmentAssistant_process.txt";
            FileInfo FileOfProcess = new FileInfo(path);
            if (!FileOfProcess.Exists)
            {
                using (StreamWriter sw = FileOfProcess.CreateText())
                {
                    sw.WriteLine(textBox_process.Text);

                }
            }
            else{
                using (StreamWriter sw = FileOfProcess.CreateText())
                {
                    
                    sw.WriteLine(textBox_process.Text);
                }

            }
           
           
            
        }

    }
}