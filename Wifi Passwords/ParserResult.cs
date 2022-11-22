using System.Collections.Generic;

namespace Wifi_Passwords
{
    public struct ParserResult
    {
        public string ErrorMessage { get; set; }
        public string SingleResult { get; set; }
        public List<string> MultipleResult { get; set; }
    }
}
