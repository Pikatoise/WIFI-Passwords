namespace Wifi_Passwords
{
    public interface IParser
    {
        ParserResult Parse(string response);
    }
}
