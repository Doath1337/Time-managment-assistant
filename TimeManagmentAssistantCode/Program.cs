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
using System.Reflection;
using Microsoft.Win32;
using System.Diagnostics;

namespace TimeManagementAssistantCode;

class Program
{
    const string name = "TimeManager";
    static public bool SetAutorunValue(bool autorun)
    {
        string ExePath = Environment.CurrentDirectory + "\\TimeManagmentAssistantCode.exe";
         
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
        var docFolder = Environment.GetFolderPath(
        Environment.SpecialFolder.MyDocuments,
        Environment.SpecialFolderOption.Create);
        string path = Path.Combine(docFolder, "TimeManager.txt");
        Program.CheckOpeningOfProcess(path);
        ProcessIsActive(path);
    }

    static void ProcessIsActive(string path)
    {
       

        
        string timeDelay = File.ReadLines(path).Skip(1).First();
        string Audio = File.ReadLines(path).Skip(2).First();
        if (Int32.TryParse(timeDelay, out int Delay))
        {
        }
        else
        { 
        }
        Delay = Delay* 60000;   
        bool ProcessCheck = Check(path);
        while (ProcessCheck == true)
        {
            Thread.Sleep(Delay);
            ProcessCheck = Check(path);
            if (ProcessCheck == true)
            {
                SoundPlayer player = new SoundPlayer(Audio);
                player.Play();
            }
            else if (ProcessCheck == false)
            {
                CheckOpeningOfProcess(path);
            }
        }
        
    }
    static bool CheckOpeningOfProcess(string path)
    {
        bool ProcessCheck = Check(path);
        while (ProcessCheck != true)
        {
            Thread.Sleep(180000);
            ProcessCheck = Check(path);
        }
        return ProcessCheck;
    }
    public static bool Check(string path)
    {
        string LinkOfProcess = File.ReadLines(path).First();
        bool AppIsRunning = Process.GetProcessesByName(LinkOfProcess).Length > 0;
        return AppIsRunning;
    }
}


