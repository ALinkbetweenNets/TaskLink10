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

        /// <summary>
        /// Filter for local IP Addresses used in IPFilter
        /// </summary>
        private const string localIPFilter = "MTkyLjE2OC4 =";


        /// <summary>
        /// Used in the IPFilter to check wether given IPs can be parsed
        /// </summary>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Codequalität", "IDE0052:Ungelesene private Member entfernen", Justification = "<Ausstehend>")]
        private IPAddress testIP;

        /// <summary>
        /// Local IP Address used for connections. Replaced at init
        /// </summary>
        private string LocalIP = "192.168.1.10";

        ///<summary>
        ///Gets IP Address of Internal Network and Writes to label
        ///</summary>
        private void RefreshLocalIP()
        {
            try
            {
                IPHostEntry host = Dns.GetHostEntry(Dns.GetHostName());
                Log("Local IP Addresses:");
                foreach (IPAddress address in host.AddressList)
                {
                    if (address.AddressFamily == AddressFamily.InterNetwork
                        && IPFilter(address))
                    {
                        LocalIP = address.ToString();
                        Log(LocalIP);
                    }
                }
                if (LocalIP?.Length > 0)
                {
                    labelLocalIP.Text = "Local IP: " + LocalIP;
                }
                else
                {
                    Log("Could not get local IP Address");
                }
                
            }
            catch (Exception ex)
            {
                Log(ex);
                Log("Error while getting local IP");
            }
        }


        /// <summary>
        /// Tests IPv4 Address with IP localIPFilter
        /// </summary>
        /// <param name="IPToCheck">The IPv4 Address to test</param>
        /// <returns>Wether The given IPv4 is local (IP Filter applies)</returns>
        private bool IPFilter(string IPToCheck) => IPAddress.TryParse(IPToCheck, out testIP)
            && IPToCheck.StartsWith(utf8.GetString(
                Convert.FromBase64String(localIPFilter))) ? true : false;

        /// <summary>
        /// Overload for IPAddress Objects. Tests IPv4 Address with IP localIPFilter
        /// </summary>
        /// <param name="IPToCheck">The IPv4 Address to test</param>
        /// <returns>Wether The given IPv4 is local (IP Filter applies)</returns>
        private bool IPFilter(IPAddress IPToCheck) => IPToCheck.ToString().StartsWith(
            utf8.GetString(Convert.FromBase64String(localIPFilter))) ? true : false;

    }
}
