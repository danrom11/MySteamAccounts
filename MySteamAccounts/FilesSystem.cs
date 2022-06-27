using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace MySteamAccounts
{
    static internal class FilesSystem
    {
        //[DllImport("user32.dll", SetLastError = true)]
        //private static extern IntPtr FindWindow(string lpClassName, string lpWindowName);
        //[DllImport("user32.dll", SetLastError = true)]
        //private static extern IntPtr FindWindowEx(IntPtr hwndParent, IntPtr hwndChildAfter, string lpszClass, string lpszWindow);
        //[DllImport("user32.dll")]
        //private static extern int SendMessage(IntPtr hWnd, int uMsg, int wParam, string lParam);
        //[DllImport("user32.dll")]
        //private static extern bool SetForegroundWindow(IntPtr hWnd);

        internal static string GetPathSteam()
        {
            RegistryKey regKey = Registry.CurrentUser;
            regKey = regKey.OpenSubKey(@"Software\Valve\Steam");
            return regKey != null ? regKey.GetValue("SteamPath").ToString() + @"\steam.exe" : "null";
        }

        internal static void StartSteam(string login, string password, string path)
        {
            KillProgram();
            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.FileName = path;
            startInfo.Arguments = "-login " + login + " " + password;
            Process.Start(startInfo); 

           // SetForegroundWindow(steamHandler);

            //IntPtr steamHandler = FindWindow("vguiPopupWindow", "Вход в Steam");
            //IntPtr steamHandlerEN = FindWindow("vguiPopupWindow", "Steam Login");
            //if (steamHandler == IntPtr.Zero && steamHandlerEN == IntPtr.Zero) 
            //{
            //    Console.WriteLine("NO KILL");
            //    ProcessStartInfo startInfo = new ProcessStartInfo(); 
            //    startInfo.FileName = path;
            //    startInfo.Arguments = "-login " + login + " " + password;
            //    Process.Start(startInfo); 
            //    SetForegroundWindow(steamHandler); 
            //}
            //else 
            //{
            //    Console.WriteLine("KILL");
            //    KillProgram(); 
            //    ProcessStartInfo startInfo = new ProcessStartInfo(); 
            //    startInfo.FileName = path;
            //    startInfo.Arguments = "-login " + login + " " + password;
            //    Process.Start(startInfo); 
            //    SetForegroundWindow(steamHandler);
            //}
        }

        private static void KillProgram()
        {
            foreach (var process in Process.GetProcessesByName("Steam"))
                process.Kill();
        }
    }

    public class masFiles
    {
        public string login;
        public string password;
        public string crypto;
        public string[] information;
        public masFiles(string login, string password, string crypto, string[] information)
        {
            this.login = login;
            this.password = password;
            this.information = information;
            this.crypto = crypto;
        }
    }
}
