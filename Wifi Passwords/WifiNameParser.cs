using System;
using System.Linq;

namespace Wifi_Passwords
{
    public class WifiNameParser : IParser
    {
        public ParserResult Parse(string response)
        {
            if (response.Contains("не запущена"))
                return new ParserResult() { ErrorMessage = "Служба беспроводной сети \nотсутствует или не запущена." };

            if (!response.Contains("     : "))
                return new ParserResult() { ErrorMessage = "Сохраненные беспроводные \nсети отсутствуют или не найдены" };

            response = response
            .Substring(response.IndexOf("    Все")+4)
            .Replace("\r", "")
            .Replace("\n", "")
            .Replace("Все профили пользователей     : ", "");

            return new ParserResult() { MultipleResult = response.Split(new string[] { "    " }, StringSplitOptions.None).ToList() };
        }
    }
}
