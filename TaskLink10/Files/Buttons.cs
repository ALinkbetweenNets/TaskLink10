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
        public void EnableButtons()
        {
            LogS("ButtonEnableCheck");
            bool SPSet = SessionPassword.Length > 0;
            try
            {
                if (listBoxIP.Items.Count > 0
                    && listBoxIP.SelectedItem.ToString().Length > 0)
                {
                    buttonIPRemove.Enabled = true;
                    if (SPSet)
                        buttonConnect.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                Log(ex);
            }
                buttonSPSave.Enabled = SPSet;
                buttonProcKill.Enabled = listBoxProc.Items.Count > 0 
                && listBoxProc.SelectedItem.ToString().Length > 0 && SPSet;










        }

    }
}
