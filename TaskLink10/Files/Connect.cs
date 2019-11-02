using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TaskLink10
{
    public partial class FormServer : Form
    {
        /// <summary>
        /// Network port to use for TCP connection. Must be unused by other services.
        /// Must be equal on communicating Systems.
        /// </summary>
        private const ushort port = 2502;

        /// <summary>
        /// Connects to Server with provided IP Address via TCP on specified port using TaskLink Protocol
        /// </summary>
        /// <param name="address">The local network TCP-IP Address to connect to</param>
        /// <param name="type">What TaskLinkTCPMessage Type (REQUEST, RESPONSE)</param>
        /// <param name="content">For Response only: the data to transmit (ProcessNames separated with ";")</param>
        public async Task<string> ConnectAsync(IPAddress address, string type = "REQUEST", string content = "")
        {
            if (SessionPassword?.Length != 0)
                try
                {
                    TcpClient tcpClient = new TcpClient();
                    LogS("Connecting...");
                    await tcpClient.ConnectAsync(address, port);
                    LogS("Connected");
                    NetworkStream stream = tcpClient.GetStream();
                    LogS("Opened Stream");
                    //byte[] ByteResponse = new byte[100];
                    LogS("Transmitting.....");

                    /* Server
                     *      Client
                     * LINK  4
                     * 4    LINK
                     * 
                     * SP[0-4]  5 -> ==
                     * 5    SP[5-9] -> ==
                     * type     10
                     * 5        Resp.Length
                     * Resp.Length  Response
                     */

                    async void Write(string msg)
                    {
                        LogS("Sending " + msg)
                        byte[] bytes = GetBytes(msg);
                        await stream.WriteAsync(GetBytes(bytes.Length.ToString()), 0, bytes.Length);
                        await stream.WriteAsync(bytes, 0, bytes.Length);
                    }
                    async string Read()
                    {
                        /*
                        
                        return GetString(Response, length);
                        */



                        byte[] Response = new byte[3];
                        int length = await stream.ReadAsync(Response, 0, 3);
                        int ResponseLength = Convert.ToInt32(GetString(Response, length));
                        LogS(GetString(ByteResponse3, k));

                        byte[] ByteResponse4 = new byte[ResponseLength];
                        k = await stream.ReadAsync(ByteResponse4, 0, ResponseLength);
                        string Response = GetString(ByteResponse4, k);
                        return Response;
                    }


                    
                    
                    
                    LogS("Receiving");
                    if (GetString(ByteResponse1, k) == "LINK")
                    {
                        await stream.WriteAsync(GetBytes(
                            SessionPassword.Substring(0, 4)), 0,
                            GetBytes(SessionPassword.Substring(0, 4)).Length);
                        //Sends first 5 chars of Session Password
                        byte[] ByteResponse2 = new byte[5];
                        k = await stream.ReadAsync(ByteResponse2, 0, GetBytes("a").Length * 5);
                        LogS("Received:" + GetString(ByteResponse2, k) + "\nSP SubString:" + SessionPassword.Substring(5, 5));
                        if (GetString(ByteResponse2, k) == SessionPassword.Substring(5, 5))
                        {//Check if Received is first 5 chars of Session Password
                            await stream.WriteAsync(GetBytes(type), 0, GetBytes(type).Length);
                            if (type == "KILL")
                            {
                                /*string s;
                                if (content.Length >= 10)
                                    s = GetBytes(content).Length.ToString();
                                else
                                    s = 0 + GetBytes(content).Length.ToString();

                                await stream.WriteAsync(GetBytes(s), 0,
                                        GetBytes(GetBytes(content).Length.ToString()).Length);
                                */
                                await stream.WriteAsync(GetBytes(content), 0, GetBytes(content).Length);
                                byte[] ByteResponse3 = new byte[10];

                                k = await stream.ReadAsync(ByteResponse3, 0, GetBytes("a").Length * 5);
                                if (GetString(ByteResponse3, k) == "S")
                                {
                                    LogSMsgBox($"Successfully Stopped Process: {content}");
                                    return "S";
                                }
                                else
                                {
                                    LogSMsgBox($"Could not Kill Process: {content}");
                                    return "F";
                                }
                            }
                            else if (type == "REQUEST")
                            {
                                byte[] ByteResponse3 = new byte[4];
                                k = await stream.ReadAsync(ByteResponse3, 0, 4);
                                int ResponseLength = Convert.ToInt32(GetString(ByteResponse3, k));
                                LogS(GetString(ByteResponse3, k));

                                byte[] ByteResponse4 = new byte[ResponseLength];
                                k = await stream.ReadAsync(ByteResponse4, 0, ResponseLength);
                                string Response = GetString(ByteResponse4, k);
                                return Response;
                            }
                            //await stream.WriteAsync(GetBytes("END"), 0, GetBytes("END").Length);
                        }
                        else LogS("INCORRECT PASSWORD: " + GetString(ByteResponse2, k));
                    }
                    else LogS("INCORRECT PROTOCOL: " + GetString(ByteResponse1, k));

                    stream.Close();
                    //Handlemsg(Response.ToString());
                    tcpClient.Close();
                    LogS("Connection Closed");
                    return "";
                }
                catch (Exception ex)
                {
                    LogS(ex);
                    LogSMsgBox("Error In TCP Connection");
                    //stream.Close();
                    //Handlemsg(Response.ToString());
                    //tcpClient.Close();
                    LogS("Connection Closed");
                    return "";
                }
            else LogSMsgBox();
            return "";
        }
    }
}
