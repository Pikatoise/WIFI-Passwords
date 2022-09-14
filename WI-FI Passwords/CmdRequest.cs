﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WI_FI_Passwords
{
    public static class CmdRequest
    {
        public static ParserResult Request(string command, IParser Parser)
        {
            string rowresult;

            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
            var codepage = CultureInfo.CurrentCulture.TextInfo.OEMCodePage;

            using (Process? procCommand = Process.Start(new ProcessStartInfo(@"cmd", command)
            {
                WindowStyle = ProcessWindowStyle.Hidden,
                RedirectStandardOutput = true,
                UseShellExecute = false,
                CreateNoWindow = true,
                StandardOutputEncoding = Encoding.GetEncoding(codepage)
            }))
            {
                StreamReader srIncoming = procCommand.StandardOutput;
                //rowresult = srIncoming.ReadToEnd();

                rowresult = "\r\nПрофили интерфейса Беспроводная сеть 2:\r\n\r\nПрофили групповой политики (только чтение)\r\n------------------------------------------\r\n    <Отсутствует>\r\n\r\nПрофили пользователей\r\n---------------------------\r\n    Все профили пользователей     : pikatoise\r\n    Все профили пользователей     : Cheburashka\r\n";
            }

            return Parser.Parse(rowresult);
        }
    }
}
