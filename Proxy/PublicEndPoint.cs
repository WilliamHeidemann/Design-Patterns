namespace Proxy;

public class PublicEndPoint
{
    private readonly CacheProxy _proxy = new();
    
    public string RequestData(string request)
    {
        return _proxy.GetData(request);
    }
}