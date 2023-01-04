namespace Proxy;

public class Database
{
    private readonly Dictionary<string, string> _data = new();

    public Database()
    {
        _data.Add("Costumer/1", "Will");
    }
    
    
    public static Database Connect()
    {
        return new Database();
    }

    public string GetData(string request)
    {
        return _data[request];
    }
}