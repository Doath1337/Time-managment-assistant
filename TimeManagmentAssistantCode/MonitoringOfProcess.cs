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
       
       bool notepadIsRunning  = Process.GetProcessesByName("devenv").Length > 0;
        return notepadIsRunning;
    }

}
