using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TaskLink10Server
{
    public partial class FormServer : Form
    {
        private string[] GetProcesses()
        {
            List<string> processList = new List<string>();
            foreach (System.Diagnostics.Process p in System.Diagnostics.Process.GetProcesses())
            {
                string path = p.MainModule.FileName;
                
                if(path.StartsWith(@"C:\Windows\"))
                    processList.Add("*"+p.ProcessName + ";");
                else
                processList.Add(p.ProcessName + ";");
            }
            processList.Sort();
            return processList.ToArray();


        }
    }
}