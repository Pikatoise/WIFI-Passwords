using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WI_FI_Passwords
{
    public interface IParser
    {
        ParserResult Parse(string response);
    }
}
