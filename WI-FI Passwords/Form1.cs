namespace WI_FI_Passwords
{
    public partial class Form1 : Form
    {
        ParserResult pR;
        public Form1()
        {
            InitializeComponent();

            pR = CmdRequest.Request(@$"/c ping 127.0.0.1", new WifiNameParser());

            if (pR.ErrorMessage == null) label1.Text = pR.SingleResult;
        }
    }
}