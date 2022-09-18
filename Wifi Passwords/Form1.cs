using System.Collections.Generic;
using System.Windows.Forms;

namespace Wifi_Passwords
{
    public partial class Form1 : Form
    {
        ParserResult resultNames;
        List<string> passwords;
        public Form1()
        {
            InitializeComponent();

            resultNames = CmdRequest.Request($@"/c netsh wlan show profiles", new WifiNameParser()); // Для теста: ping 127.0.0.1 | netsh wlan show profiles

            if (resultNames.ErrorMessage == null)
            {
                foreach (string s in resultNames.MultipleResult)
                {
                    passwords.Add(CmdRequest.Request($@"/c netsh wlan show profile name=""{s}"" key=clear | find /I ""Содержимое ключа""", new WifiNameParser()).SingleResult);
                }
            } else textBox1.Text = resultNames.ErrorMessage;
        }
    }
}
