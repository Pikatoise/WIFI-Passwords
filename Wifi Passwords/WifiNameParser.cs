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
            response = response
            .Replace("\r\nПрофили интерфейса Беспроводная сеть 2:\r\n\r\nПрофили групповой политики (только чтение)\r\n------------------------------------------\r\n    <Отсутствует>\r\n\r\nПрофили пользователей\r\n---------------------------\r\n    ", "")
            .Replace("Все профили пользователей     : ", "")
            .Replace("\r", "")
            .Replace("\n", "");

            return new ParserResult() { MultipleResult = response.Split(new string[] { "    " }, StringSplitOptions.None).ToList() };
        }
    }
}
