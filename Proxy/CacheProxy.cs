namespace Proxy;

public class CacheProxy
{
    private readonly Dictionary<string, string> _cache = new();
    private readonly Database _database;

    public CacheProxy()
    {
        _database = Database.Connect();
    }

    public string GetData(string request)
    {
        if (_cache.ContainsKey(request))
        {
            return _cache[request];
        }
        else
        {
            // Expensive operation to be avoided: 
            var data = _database.GetData(request);
            _cache.Add(request, data);
            return data;
        }
    }
}