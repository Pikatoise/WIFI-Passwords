using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wifi_Passwords
{
    public struct ParserResult
    {
        public string ErrorMessage { get; set; }
        public string SingleResult { get; set; }
        public IEnumerable<string> MultipleResult { get; set; }
    }
}
