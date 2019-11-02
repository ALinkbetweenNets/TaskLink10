using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
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
            ButtonDisable();
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
        IPAdd:
            string enteredAddress = StringCheck(InputBox(
                "Enter new IPv4 Address of a Client Computer (eg. 192.168.1.5)",
                "New Client IP"));
            if (enteredAddress.Length > 0)
            {
                if (IPFilter(enteredAddress))
                {
                    listBoxIP.Items.Add(enteredAddress);
                }
                else if (ConfirmationBox("Invalid IPv4 Formatting. Retry?", "Invalid IPv4 Format"))
                    goto IPAdd;
            }
            else
            {
                LogBox("You have to enter an IP Address in the IPv4 Format");
            }
        }

        public async void buttonConnect_Click(object sender, EventArgs e)
        {
            try
            {
                await ConnectAsync(listBoxIP.SelectedItem.ToString());
            }
            catch (Exception ex)
            { Log(ex); }
        }

        public void buttonLocalIPRefresh_Click(object sender, EventArgs e)
        {
            RefreshLocalIP();
        }

        public void buttonIPRemove_Click(object sender, EventArgs e)
        {
            try
            {
                listBoxIP.Items.Remove(listBoxIP.SelectedItem);

            }
            catch (Exception ex)
            {
                Log(ex);
            }
        }

        public void buttonIPClear_Click(object sender, EventArgs e)
        {
            if (ConfirmationBox("Are you sure you want to remove all IP Addresses from the List?", "Deleting all IPs"))
                listBoxIP.Items.Clear();
        }

        public void buttonIPSave_Click(object sender, EventArgs e)
        {
            IPSave();
        }

        public void buttonIPLoad_Click(object sender, EventArgs e)
        {
            IPLoad();
        }

        public async void buttonProcKill_Click(object sender, EventArgs e)
        {
            try
            {
                await ConnectAsync(listBoxIP.SelectedItem.ToString(),"KILL",listBoxProc.SelectedItem.ToString());
            }
            catch (Exception ex)
            { Log(ex); }
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
