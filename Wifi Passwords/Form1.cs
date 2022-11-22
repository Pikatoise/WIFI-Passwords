using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Wifi_Passwords
{
    public partial class MainForm : Form
    {
        ParserResult resultNames;
        List<string> passwords = new List<string>();

        public MainForm()
        {
            InitializeComponent();

            ParseNetworks();

            DisplayNetworks();
        }

        void ParseNetworks()
        {
            resultNames = CmdRequest.Request($@"/c netsh wlan show profiles", new WifiNameParser()); // Для теста: ping 127.0.0.1 | netsh wlan show profiles

            if (resultNames.ErrorMessage == null)
                foreach (string s in resultNames.MultipleResult)
                    passwords.Add(CmdRequest.Request(
                        $@"/c netsh wlan show profile name=""{s}"" key=clear | find /I ""Содержимое ключа""", 
                        new WifiPasswordsParser()).SingleResult);
        }

        void DisplayNetworks()
        {
            if (resultNames.ErrorMessage == null)
                for (int i = 0; i < resultNames.MultipleResult.Count; i++)
                    if (!string.IsNullOrEmpty(passwords[i]))
                        mainGrid.Rows.Add(resultNames.MultipleResult[i], passwords[i]);
            else
            {
                labelNetworkKey.Visible = false;
                labelNetworkName.Visible = false;
                mainGrid.Enabled = false;
                mainGrid.Visible = false;
                labelError.Visible = true;
                labelErrorText.Visible = true;

                labelErrorText.Text = resultNames.ErrorMessage;
            }
        }
    }
}
