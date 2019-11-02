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

        /// <summary>
        /// Logs the specified MSG to Console and GUI textBox
        /// </summary>
        /// <param name="msg">Log message</param>
        public static void Log(string msg)
        {
            Console.WriteLine(msg);
            LogTextBox(msg);
        }

        /// <summary>
        /// Overload for Exceptions. Only write to Console
        /// </summary>
        /// <param name="exception">Exception</param>
        public static void Log(Exception ex)
        {
            Console.WriteLine("EXCEPTION\r\nException Message: " + ex.Message);
            Console.WriteLine("Exception Source: " + ex.Source);
            Console.WriteLine("Exception: " + ex.ToString());
        }

        /// <summary>
        /// Static Version of Log
        /// </summary>
        /// <param name="msg">Message to write into Log</param>
        public static void LogS(string msg)
        {
            Console.WriteLine(msg);
        }

        /*/// <summary>
        /// Version of LogS. Returns logging message for return in functions
        /// </summary>
        /// <param name="msg">String to Log and return</param>
        public static string LogR(string msg)
        {
            Console.WriteLine(msg);
            return msg;
        }*/

        /// <summary>
        /// Writes Message to Log TextBox
        /// </summary>
        /// <param name="msg"></param>
        public static void LogTextBox(string msg)
        {
            //textBoxLog.AppendText(msg + "\r\n");
            
        }

        /// <summary>
        /// Shows Message Box and Logs Message
        /// </summary>
        /// <param name="msg">Message to display and Log</param>
        public static void LogBox(string msg = "Please set a Session Password first")
        {
            try
            {
                Log($"MsgBox ({msg})");
                Microsoft.VisualBasic.Interaction.MsgBox(msg,
                        Microsoft.VisualBasic.MsgBoxStyle.OkOnly);
            }
            catch (Exception ex)
            {
                Log(ex);
            }
        }

        /// <summary>
        /// Displays Input Dialog and returns User Input
        /// </summary>
        /// <param name="text">Main Text</param>
        /// <param name="title">Dialog Box Title</param>
        /// <param name="EnteredText">The Text that is already entered</param>
        /// <returns>entered text</returns>
        public static string InputBox(string text, string title, string EnteredText = "")
        {
            try
            {
                string Input = Microsoft.VisualBasic.Interaction.InputBox(text,
                           title, EnteredText, 0, 0);

                LogS($"Input Box: { title} : {text} -> {Input}");
                return Input;
            }
            catch (Exception ex)
            {
                Log(ex);
                LogBox("Error while trying to show Input Box");
                return string.Empty;
            }
        }

        /// <summary>
        /// Shows Yes No Box and returns Answer
        /// </summary>
        /// <param name="text">Main Text in Box</param>
        /// <param name="title">Windows Title</param>
        /// <returns>Wether Yes was clicked</returns>
        public static bool ConfirmationBox(string text, string title)
        {
            try
            {
                LogS("Confirmation Box: " + title + " - " + text);
                if (Microsoft.VisualBasic.Interaction.MsgBox(
                    text, Microsoft.VisualBasic.MsgBoxStyle.YesNo, title)
                    == Microsoft.VisualBasic.MsgBoxResult.Yes)
                {
                    LogS("Result: Yes");
                    return true;
                }
                else
                {
                    LogS("Result: No");
                    return false;
                }
            }
            catch (Exception ex)
            {
                Log(ex);
                Log("Error while trying to show Confirmation Box");
                return false;
            }
        }
    }
}
