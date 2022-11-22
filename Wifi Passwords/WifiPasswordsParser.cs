using System;

namespace Wifi_Passwords
{
    public class WifiPasswordsParser : IParser
    {
        public ParserResult Parse(string response)
        {
            return new ParserResult()
            {
                SingleResult = response.Replace("\r","")
                                       .Replace("\n","")
                                       .Replace("    Содержимое ключа            : ", "")
            };
        }
    }
}
