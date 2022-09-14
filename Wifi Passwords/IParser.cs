using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wifi_Passwords
{
    public interface IParser
    {
        ParserResult Parse(string response);
    }
}
