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
            try
            {
                if (listBoxIP.Items.Count > 0
                    && listBoxIP.SelectedItem.ToString().Length > 0)
                    buttonConnect.Enabled = true;
            }
            catch (Exception ex)
            {
                Log(ex);
            }

            if (SessionPassword.Length > 0)
                buttonSPSave.Enabled = true;










        }

    }
}
