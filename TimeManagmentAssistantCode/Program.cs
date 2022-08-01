using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;
using System.Numerics;


namespace TimeManagementAssistantCode;

class Program
{

    static void Main(string[] args)
    {

        string path = @"C:\Users\Dead Ghoul\AppData\Local\Temp\TimeManagmentAssistant_process.txt";
        StreamReader sr = new StreamReader(@"C:\Users\Dead Ghoul\AppData\Local\Temp\TimeManagmentAssistant_process.txt");
        string TextOfFileOfProcess = File.ReadAllText(path);
        string NameOfProcess = sr.ReadLine();
        Program.CheckOpeningOfProcess();
         bool ProcessCheck = ProcessInfo.Check();
        int count = 5000;
       

    }
    static void ProcessIsActive()
    {
        
        bool ProcessCheck = ProcessInfo.Check();
        while (ProcessCheck == true)
        {
            Thread.Sleep(10000);
            ProcessCheck = ProcessInfo.Check();
            if (ProcessCheck == true)
            {
                SoundPlayer player = new SoundPlayer(@"C:\Users\Dead Ghoul\source\repos\TimeManagementAssistant\TimeManagmentAssistantCode\664110.wav");
                player.Play();

                 

            }
            else if (ProcessCheck == false)
            {
                CheckOpeningOfProcess();
            }


        }
        
    }
    static bool CheckOpeningOfProcess()
    {
        bool ProcessCheck = ProcessInfo.Check();
        while (ProcessCheck != true)
        {
            Thread.Sleep(2000);
            ProcessCheck = ProcessInfo.Check();
        }
        return ProcessCheck;
    }
}


