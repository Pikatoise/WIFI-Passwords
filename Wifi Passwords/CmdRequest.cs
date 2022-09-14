﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wifi_Passwords
{
    public static class CmdRequest
    {
        public static ParserResult Request(string command, IParser Parser)
        {
            string rowresult;

            //Encoding.RegisterProvider(CodePagesEncodingProvider.Instance); // На фреймворке не нужна

            var codepage = CultureInfo.CurrentCulture.TextInfo.OEMCodePage;

            using (Process procCommand = Process.Start(new ProcessStartInfo(@"cmd", command)
            {
                WindowStyle = ProcessWindowStyle.Hidden,
                RedirectStandardOutput = true,
                UseShellExecute = false,
                CreateNoWindow = true,
                StandardOutputEncoding = Encoding.GetEncoding(codepage)
            }))
            {
                StreamReader srIncoming = procCommand.StandardOutput;
                rowresult = srIncoming.ReadToEnd();
            }

            return Parser.Parse(rowresult);
        }
    }
}
