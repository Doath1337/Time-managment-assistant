using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading.Tasks;

namespace TimeManagementAssistantCode;

 class ProcessInfo
{
    public static bool Check()
    {
        string LinkOfProcess = File.ReadLines(@"C:\Users\Dead Ghoul\AppData\Local\Temp\TimeManagmentAssistant_process.txt").First();
        bool notepadIsRunning  = Process.GetProcessesByName(LinkOfProcess).Length > 0;
        return notepadIsRunning;
    }

}
