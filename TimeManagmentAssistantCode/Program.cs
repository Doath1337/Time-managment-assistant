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
using Microsoft.Win32;

namespace TimeManagementAssistantCode;

class Program
{
    const string name = "MyTestApplication";
    static public bool SetAutorunValue(bool autorun)
    {
        string ExePath = System.Reflection.Assembly.GetEntryAssembly().Location;

        RegistryKey reg;
        reg = Registry.CurrentUser.CreateSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Run\\");
        try
        {
            if (autorun)
                reg.SetValue(name, ExePath);
            else
                reg.DeleteValue(name);

            reg.Close();
        }
        catch
        {
            return false;
        }
        return true;
    }
    static void Main(string[] args)
    {
        bool autorun= true;
        SetAutorunValue(autorun);
        Program.CheckOpeningOfProcess();
        ProcessIsActive();
    }

    static void ProcessIsActive()
    {
        long SleepTime;

        
        string timeDelay = File.ReadLines(@"C:\Users\Dead Ghoul\AppData\Local\Temp\TimeManagmentAssistant_process.txt").Skip(1).First();
        string Audio = File.ReadLines(@"C:\Users\Dead Ghoul\AppData\Local\Temp\TimeManagmentAssistant_process.txt").Skip(2).First();
        if (Int32.TryParse(timeDelay, out int Delay))
        {
        }
        else
        { 
        }
        Delay = Delay* 60000;   
        bool ProcessCheck = ProcessInfo.Check();
        while (ProcessCheck == true)
        {
            Thread.Sleep(Delay);
            ProcessCheck = ProcessInfo.Check();
            if (ProcessCheck == true)
            {
                SoundPlayer player = new SoundPlayer(Audio);
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
            Thread.Sleep(180000);
            ProcessCheck = ProcessInfo.Check();
        }
        return ProcessCheck;
    }
}


