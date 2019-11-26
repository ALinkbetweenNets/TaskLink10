using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TaskLink10Server
{
    public partial class FormServer : Form
    {
#pragma warning disable CS1998 // Bei der asynchronen Methode fehlen "await"-Operatoren. Die Methode wird synchron ausgeführt.
        public async Task<long> Collector()
#pragma warning restore CS1998 // Bei der asynchronen Methode fehlen "await"-Operatoren. Die Methode wird synchron ausgeführt.
        {
            long start = GC.GetTotalMemory(true);
            
            GC.Collect();
            
            GC.WaitForPendingFinalizers();
            Log(GC.WaitForFullGCComplete().ToString());
            GC.Collect();
            long finish = GC.GetTotalMemory(true);
            
            LogS($"Garbage Collection. Used Memory before: {start}. After Collection: {finish}");
            return (start - finish);
        }
    }
}
