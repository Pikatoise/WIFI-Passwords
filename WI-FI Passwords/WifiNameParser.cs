using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WI_FI_Passwords
{
    public class WifiNameParser : IParser
    {
        public ParserResult Parse(string response)
        {
            return new ParserResult() { SingleResult = response };
        }
    }
}
