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
            IPLoad(false);
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
            EnableButtons();
        }

        public void buttonSPSave_Click(object sender, EventArgs e)
        {
            SPSave();
        }

        public void buttonIPAdd_Click(object sender, EventArgs e)
        {
            string enteredAddress = StringCheck(InputBox(
                "Enter new IPv4 Address of a Client Computer (eg. 192.168.1.5)",
                "New Client IP"));
            if (enteredAddress.Length > 0)
            {
                if (IPFilter(enteredAddress))
                {
                    listBoxClientIPs.Items.Add(enteredAddress);
                    buttonSave.Enabled = true;
                    buttonRemove.Enabled = true;
                    buttonClear.Enabled = true;
                }
                else LogMsgBox("Invalid IPv4 Formatting");
            }
            else
            {

            }
        }

        public void buttonConnect_Click(object sender, EventArgs e)
        {

        }

        public void buttonLocalIPRefresh_Click(object sender, EventArgs e)
        {
            RefreshLocalIP();
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
            IPLoad();
        }

        public void buttonProcKill_Click(object sender, EventArgs e)
        {

        }

        public void buttonLogClear_Click(object sender, EventArgs e)
        {
            textBoxLog.Text = string.Empty;
        }

        private void listBoxProc_SelectedIndexChanged(object sender, EventArgs e)
        {
            EnableButtons();
        }

        private void listBoxIP_SelectedIndexChanged(object sender, EventArgs e)
        {
            EnableButtons();
        }
    }
}
