namespace Factory;

public class MachineLearningCookieFactory : ICookieFactory
{
    public ICookie CreateCookie(string request)
    {
        if (request.Contains("chocolate"))
        {
            return new ChocolateCookie();
        }
        
        return new VanillaCookie();
    }
}