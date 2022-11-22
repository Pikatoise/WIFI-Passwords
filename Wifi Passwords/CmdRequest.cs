using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Text;

namespace Wifi_Passwords
{
    public static class CmdRequest
    {
        public static ParserResult Request(string command, IParser Parser)
        {
            //Encoding.RegisterProvider(CodePagesEncodingProvider.Instance); // На фреймворке не нужна
            var codepage = CultureInfo.CurrentCulture.TextInfo.OEMCodePage;
            string rowresult;

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
