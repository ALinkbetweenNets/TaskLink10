using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TaskLink10Server
{
    public partial class FormServer : Form
    {
        public FormServer()
        {
            InitializeComponent();
            GetDateTime();
            RefreshLocalIP();
        }

        public void buttonSPSet_Click(object sender, EventArgs e)
        {
        SPInput:
            buttonSPSet.Enabled = false;

            string Input = InputBox(
                "Enter new Session Password", "Session Password");
            if (Input.Length > 0)
            {
                string hash = GetHashSha256(Input);

                SessionPassword = hash;
                LogBox("Set new Session Password. SHA-256 Hash:\n" +
                        SessionPassword);

                buttonSPSet.Text = "Set new Session Password";
                
            }
            else
            {
                if (ConfirmationBox("Please enter a Password", "Invalid Input"))
                    goto SPInput;
            }
            buttonSPSet.Enabled = true;
            EnableButtons();\
        }

        public void buttonSPSave_Click(object sender, EventArgs e)
        {

        }

        public void buttonIPAdd_Click(object sender, EventArgs e)
        {

        }

        public void buttonConnect_Click(object sender, EventArgs e)
        {

        }

        public void buttonLocalIPRefresh_Click(object sender, EventArgs e)
        {

        }

        public void buttonIPRemove_Click(object sender, EventArgs e)
        {

        }

        public void buttonIPClear_Click(object sender, EventArgs e)
        {

        }

        public void buttonIPSave_Click(object sender, EventArgs e)
        {

        }

        public void buttonIPLoad_Click(object sender, EventArgs e)
        {

        }

        public void buttonProcKill_Click(object sender, EventArgs e)
        {

        }

        public void buttonLogClear_Click(object sender, EventArgs e)
        {

        }
    }
}
