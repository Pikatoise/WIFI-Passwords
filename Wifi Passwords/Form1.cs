using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Wifi_Passwords
{
    public partial class Form1 : Form
    {
        ParserResult pR;
        public Form1()
        {
            InitializeComponent();

            pR = CmdRequest.Request($@"/c netsh wlan show profiles", new WifiNameParser()); // Для теста: ping 127.0.0.1 | netsh wlan show profiles

            if (pR.ErrorMessage == null) textBox1.Text = pR.MultipleResult[0];
        }
    }
}
