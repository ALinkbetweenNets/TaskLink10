using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskLink10Server
{
    public partial class FormServer
    {
        /// <summary>
        /// The File under which the Client IPs get stored
        /// </summary>
        private const string pathIP = "IP.tl";

        /// <summary>
        /// The File under which the Session Password get stored
        /// </summary>
        private const string pathSP = "SP.tl";

        public void IPSave()
        {
            List<string> ipList = new List<string>();
            Log("Creating File");
            foreach (string ip in listBoxIP.Items)
            {
                ipList.Add(ip);
            }
            Log("Writing...");
            File.WriteAllLines(pathIP, ipList);
            LogBox($"Saved IP List to {pathIP}");
        }

        /// <summary>
        /// Loads IP Addresses from IPs.tl, checks them via IPFilter and adds them to listBoxClientIPs
        /// </summary>
        private void IPLoad(bool output = true)
        {
            try
            {
                if (File.Exists(pathIP))
                {
                    listBoxIP.Items.Clear();
                    string[] ipFile = File.ReadAllLines(pathIP);
                    Log("Loaded File:" + pathIP);
                    foreach (string ip in ipFile)
                    {
                        Log("\t" + StringCheck(ip));
                        if (IPFilter(StringCheck(ip)))
                            listBoxIP.Items.Add(ip);
                    }
                    if (output)
                        LogBox("Loaded IP Addresses from File");
                }
                else if (output)
                    LogBox($"No File under {pathIP}");
            }
            catch (Exception ex)
            {
                Log(ex);
                LogBox($"Error While Loading IP Addresses from: {pathIP}");
            }
        }

        /// <summary>
        /// Writes Session Password to File
        /// </summary>
        public void SPSave()
        {
            try
            {
                string[] SPList = new string[1];
                SPList[0] = SessionPassword;
                Log("Writing...");
                File.WriteAllLines(pathSP, SPList);
                Log("Writing Done");
                LogBox($"Saved Session Password to {pathSP}");
            }
            catch (Exception ex)
            {
                Log(ex);
                LogBox($"Error while trying to save Session Password to {pathSP}");
            }
        }

        /// <summary>
        /// Loads Session Password from File
        /// </summary>
        /// <param name="output"></param>
        public void SPLoad(bool output = true)
        {
            try
            {
                if (File.Exists(pathSP))
                {
                    string[] SPFile = File.ReadAllLines(pathSP);
                    Log("Loaded File:");
                    foreach (string i in SPFile)
                    {
                        string ii = StringCheck(i);
                        Log(ii);
                        if (ii.Length > 0)
                        {
                            SessionPassword = ii;
                            Log($"Loaded Session Password (Hash: {SessionPassword}) from {pathSP}");
                            if (output)
                                LogBox($"Loaded Session Password (Hash: {SessionPassword}) from {pathSP}");
                        }
                    }
                }
                else LogS($"No File under {pathSP}");
            }
            catch (Exception ex)
            {
                Log(ex);
                LogBox("Error initially loading Session Password");
            }
        }
    }
}
