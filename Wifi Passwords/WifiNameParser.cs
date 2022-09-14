using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wifi_Passwords
{
    public class WifiNameParser : IParser
    {
        public ParserResult Parse(string response)
        {
            

            return new ParserResult() { SingleResult = response };
        }
    }
}
