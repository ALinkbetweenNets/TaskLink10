﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TaskLink10Client
{
    public partial class FormClient : Form
    {
        /// <summary>
        /// Array of chars that should be removed from the TCP traffic -> enhancing safety
        /// </summary>
        private static char[] BAD_CHARS = { '/', '\\', '\"', '\'', '{', '}' };

        /// <summary>
        /// Removes any Bad Chars from given String
        /// </summary>
        /// <param name="testString">String to remove Bad Chars from</param>
        /// <returns></returns>
        private static string StringCheck(string testString)
        {
            //return Regex.Replace(testString, @"[!@#$%_?/\\]", "");
            foreach (char bad in BAD_CHARS)
            {
                if (testString.Contains(bad.ToString()))
                    testString = testString.Replace(bad.ToString(), string.Empty);
            }
            return testString;
        }

        /// <summary>
        /// Converts bytes to string
        /// </summary>
        /// <param name="bytesToConvert"></param>
        /// <param name="byteLength">Length of message</param>
        /// <param name="cleartext">Wether to not decrypt message</param>
        /// <returns>Built string</returns>
        private string GetString(byte[] bytesToConvert, int byteLength, bool encrypted = false)
        {
            StringBuilder stringBuilder = new StringBuilder();
            for (int i = 0; i < byteLength; i++)
                stringBuilder.Append(Convert.ToChar(bytesToConvert[i]).ToString());
            string finishedString = StringCheck(stringBuilder.ToString());
            Console.WriteLine("Received: " + finishedString);
            return encrypted ? DecryptString(finishedString) : finishedString;
        }

        /// <summary>
        /// Converts string to bytes
        /// </summary>
        /// <param name="stringToConvert"></param>
        /// <param name="cleartext">Wether to not encrypt message</param>
        /// <returns>Converted Bytes</returns>
        private byte[] GetBytes(string stringToConvert, bool encrypt = false)
        {
            stringToConvert = StringCheck(stringToConvert);
            return encrypt ? utf8.GetBytes(EncryptString(stringToConvert)) : utf8.GetBytes(stringToConvert);
        }
    }
}
